using System;
using System.Collections.Concurrent;
using System.Globalization;
using System.IO;
using System.Threading;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;

namespace TrueEnd.Host
{
    // Host-only frame dump for frame-by-frame comparison with a recording of the game.
    // Every completed frame of the camera's output texture is scaled, read back synchronously
    // (offline playback runs on the capture clock, so stalling the GPU does not change timing)
    // and encoded to JPEG on the recorder's own threads (joined on dispose; no thread-pool work
    // is left behind when the IL2CPP player shuts down). The host's black fade overlay is composited
    // like the client's uGUI black tint (black with alpha, blended in linear space).
    internal sealed class LiveFrameRecorder : IDisposable
    {
        private const int Quality = 92;
        private const int Workers = 4;
        private readonly string directory;
        private readonly int width;
        private readonly StreamWriter index;
        private readonly BlockingCollection<(byte[] pixels, float fade, int w, int h, string file)> queue =
            new BlockingCollection<(byte[], float, int, int, string)>(Workers * 2);
        private readonly Thread[] threads = new Thread[Workers];
        private RenderTexture scaled;
        private int frame;
        private int failures;
        private bool disposed;

        public LiveFrameRecorder(string directory, int width)
        {
            this.directory = directory;
            this.width = width;
            Directory.CreateDirectory(directory);
            index = new StreamWriter(Path.Combine(directory, "frames.tsv"));
            index.WriteLine("frame\ttime\tfade\tfile");
            for (int i = 0; i < Workers; i++)
            {
                threads[i] = new Thread(Encode) { IsBackground = true, Name = "LiveFrameEncoder" + i };
                threads[i].Start();
            }
        }

        public void Record(RenderTexture source, double time, float fade)
        {
            if (source == null) return;
            int w = width > 0 ? width : source.width;
            int h = Math.Max(2, (int)Math.Round(source.height * (double)w / source.width) & ~1);
            if (scaled == null || scaled.width != w || scaled.height != h)
            {
                if (scaled != null) scaled.Release();
                scaled = new RenderTexture(w, h, 0, RenderTextureFormat.ARGB32, RenderTextureReadWrite.sRGB);
                scaled.Create();
                index.Flush();
                File.WriteAllText(Path.Combine(directory, "geometry.txt"),
                    $"source {source.width}x{source.height}\nframe {w}x{h}\nscreen {Screen.width}x{Screen.height}\n");
            }
            Graphics.Blit(source, scaled);
            var request = AsyncGPUReadback.Request(scaled, 0, TextureFormat.RGBA32);
            request.WaitForCompletion();
            int number = frame++;
            string file = $"f{number:D6}.jpg";
            index.WriteLine(string.Format(CultureInfo.InvariantCulture, "{0}\t{1:F6}\t{2:F4}\t{3}", number, time, fade, file));
            if (request.hasError)
            {
                failures++;
                Debug.LogError($"LIVE_FRAME readback failed frame={number}");
                return;
            }
            // Blocks while all workers are busy, so memory stays bounded.
            queue.Add((request.GetData<byte>().ToArray(), fade, w, h, file));
        }

        private void Encode()
        {
            foreach (var (pixels, fade, w, h, file) in queue.GetConsumingEnumerable())
            {
                try
                {
                    if (fade > 0f)
                    {
                        // The client's black tint is a uGUI image blended in linear space (linear colour space project),
                        // so darken in linear light and re-encode to sRGB.
                        float keep = 1f - Math.Min(1f, fade);
                        var lut = new byte[256];
                        for (int v = 0; v < 256; v++)
                        {
                            double c = v / 255.0;
                            double lin = (c <= 0.04045 ? c / 12.92 : Math.Pow((c + 0.055) / 1.055, 2.4)) * keep;
                            double srgb = lin <= 0.0031308 ? lin * 12.92 : 1.055 * Math.Pow(lin, 1 / 2.4) - 0.055;
                            lut[v] = (byte)Math.Min(255, (int)(srgb * 255 + 0.5));
                        }
                        for (int i = 0; i < pixels.Length; i += 4)
                        {
                            pixels[i] = lut[pixels[i]];
                            pixels[i + 1] = lut[pixels[i + 1]];
                            pixels[i + 2] = lut[pixels[i + 2]];
                        }
                    }
                    byte[] jpg = ImageConversion.EncodeArrayToJPG(pixels, GraphicsFormat.R8G8B8A8_SRGB, (uint)w, (uint)h, 0, Quality);
                    File.WriteAllBytes(Path.Combine(directory, file), jpg);
                }
                catch (Exception exception)
                {
                    Interlocked.Increment(ref failures);
                    Debug.LogException(exception);
                }
            }
        }

        public void Dispose()
        {
            if (disposed) return;
            disposed = true;
            queue.CompleteAdding();
            foreach (var thread in threads) thread.Join();
            queue.Dispose();
            index.Dispose();
            if (scaled != null) scaled.Release();
            Debug.Log($"LIVE_FRAMES frames={frame} failures={failures} dir={directory}");
        }
    }
}

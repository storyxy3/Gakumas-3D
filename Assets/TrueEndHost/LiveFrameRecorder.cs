using System;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;

namespace TrueEnd.Host
{
    // Host-only frame dump for frame-by-frame comparison with a recording of the game.
    // Every completed frame of the camera's output texture is scaled, read back synchronously
    // (offline playback runs on the capture clock, so stalling the GPU does not change timing)
    // and encoded to JPEG on worker threads. The host's black fade overlay is composited
    // the same way OnGUI draws it (black with alpha over the frame).
    internal sealed class LiveFrameRecorder : IDisposable
    {
        private const int Quality = 92;
        private const int MaxPendingEncodes = 8;
        private readonly string directory;
        private readonly int width;
        private readonly StreamWriter index;
        private readonly SemaphoreSlim slots = new SemaphoreSlim(MaxPendingEncodes);
        private RenderTexture scaled;
        private int frame;
        private int failures;

        public LiveFrameRecorder(string directory, int width)
        {
            this.directory = directory;
            this.width = width;
            Directory.CreateDirectory(directory);
            index = new StreamWriter(Path.Combine(directory, "frames.tsv"));
            index.WriteLine("frame\ttime\tfade\tfile");
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
            byte[] pixels = request.GetData<byte>().ToArray();
            slots.Wait();
            Task.Run(() =>
            {
                try
                {
                    if (fade > 0f)
                    {
                        float keep = 1f - Mathf.Clamp01(fade);
                        for (int i = 0; i < pixels.Length; i += 4)
                        {
                            pixels[i] = (byte)(pixels[i] * keep + 0.5f);
                            pixels[i + 1] = (byte)(pixels[i + 1] * keep + 0.5f);
                            pixels[i + 2] = (byte)(pixels[i + 2] * keep + 0.5f);
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
                finally
                {
                    slots.Release();
                }
            });
        }

        public void Dispose()
        {
            for (int i = 0; i < MaxPendingEncodes; i++) slots.Wait();
            index.Dispose();
            if (scaled != null) scaled.Release();
            Debug.Log($"LIVE_FRAMES frames={frame} failures={failures} dir={directory}");
        }
    }
}

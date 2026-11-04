using System;
using System.Collections.Generic;
using CriWare.CriMana;
using UnityEngine;
using ManaStatus = CriWare.CriMana.Player.Status;
using ManaTimer = CriWare.CriMana.Player.TimerType;

namespace CriWare
{
    public sealed partial class CriAtomNativeBackend
    {
        private sealed class ManaFrame
        {
            internal readonly byte[][] Planes = new byte[3][];
            internal readonly IntPtr[] Textures = new IntPtr[3];
            internal int TextureCount;
            internal bool Released;
            internal uint Skipped;
            internal ulong Time, Unit;

            internal void Copy(CriManaMpeg1Decoder.Frame source)
            {
                CopyPlane(0, source.Y); CopyPlane(1, source.U); CopyPlane(2, source.V);
                TextureCount = 0;
            }
            private void CopyPlane(int index, byte[] input)
            {
                if (Planes[index] == null || Planes[index].Length != input.Length) Planes[index] = new byte[input.Length];
                Buffer.BlockCopy(input, 0, Planes[index], 0, input.Length);
            }
        }

        private readonly Dictionary<IntPtr, Texture2D> manaTextures = new Dictionary<IntPtr, Texture2D>();

        private sealed partial class ManaPlayer
        {
            internal ManaFrame PastReference, DelayedReference;
            internal int SeekBase, ConsumedFrames;
        }

        private static void InitializeManaFrames(ManaPlayer p)
        {
            p.Ready.Clear(); p.Free.Clear();
            p.Pending = p.Displayed = p.PastReference = p.DelayedReference = null;
            p.SeekBase = p.DecodedFrame;
            p.ConsumedFrames = 0;
            p.Skipped = p.SkipRequests = p.TimeCompensation = 0;
            // Native MPV 630A8: three reference pictures + (six buffers - one).
            for (int i = 0; i < 8; i++) p.Free.Enqueue(new ManaFrame());
        }

        private static void PumpManaFrames(ManaPlayer p)
        {
            while (p.Free.Count != 0 && !p.EndOfVideo)
            {
                bool discardNonReference = (p.Concatenated == 0 && p.DecodedFrame < p.SeekFrame) || p.SkipRequests != 0;
                if (!p.Decoder.TryDecodePicture(out var decoded, out var presentation, discardNonReference))
                { p.EndOfVideo = true; break; }
                ManaFrame output;
                if (decoded == null)
                {
                    output = p.DelayedReference;
                    p.DelayedReference = null;
                    ForgetManaReference(p);
                }
                else if (decoded.PictureType == 3)
                {
                    bool preroll = p.Concatenated == 0 && p.DecodedFrame < p.SeekFrame;
                    if (preroll || p.SkipRequests != 0)
                    {
                        p.DecodedFrame++; p.Skipped++;
                        if (preroll) p.TimeCompensation++;
                        else p.SkipRequests--;
                        continue;
                    }
                    output = p.Free.Dequeue();
                    output.Copy(decoded); output.Released = false;
                }
                else
                {
                    ForgetManaReference(p);
                    output = p.DelayedReference;
                    p.PastReference = output;
                    p.DelayedReference = p.Free.Dequeue();
                    p.DelayedReference.Copy(decoded);
                    p.DelayedReference.Released = false;
                }
                if (presentation == null) continue;
                // Native 63AAC snapshots actual B skips when the picture is
                // queued for presentation, including delayed I/P references.
                output.Skipped = p.Skipped;
                int index = p.DecodedFrame++;
                if (p.Concatenated == 0 && index < p.SeekFrame)
                {
                    p.ConsumedFrames++;
                    ReturnManaFrame(p, output);
                }
                else p.Ready.Enqueue(output);
            }
        }

        private static void ForgetManaReference(ManaPlayer p)
        {
            var frame = p.PastReference;
            p.PastReference = null;
            if (frame?.Released == true) p.Free.Enqueue(frame);
        }

        private static void ReturnManaFrame(ManaPlayer p, ManaFrame frame)
        {
            frame.Released = true;
            if (!ReferenceEquals(frame, p.PastReference)) p.Free.Enqueue(frame);
        }

        public bool CRIWAREDEF25F94(int player_id, int num_textures, IntPtr[] tex_ptrs)
        {
            var p = GetMana(player_id);
            if (p?.Decoder == null) return false;
            p.Attached = true; p.Stopping = false;
            if (p.Pending != null) { ReturnManaFrame(p, p.Pending); p.Pending = null; }
            if (p.Displayed != null) { ReturnManaFrame(p, p.Displayed); p.Displayed = null; }
            if (p.Status == ManaStatus.WaitPrep) p.Status = ManaStatus.Prep;
            return true;
        }

        // On the original GLES renderer detach is a no-op; Vulkan alone defers
        // its GPU objects by three frames. Unity owns this host's GPU lifetime.
        public bool CRIWARE5F215F75(int player_id, int num_textures, IntPtr[] tex_ptrs) => GetMana(player_id) != null;
        public sbyte CRIWARE412BF0B2(int player_id) => GetMana(player_id)?.Attached == true ? (sbyte)0 : (sbyte)-1;

        public bool CRIWARE9F502893(int player_id, int num_textures, IntPtr[] tex_ptrs, FrameInfo frame_info,
            ref bool frame_drop)
        {
            var p = GetMana(player_id);
            if (p == null || !p.Attached || p.Status != ManaStatus.Playing || p.Ready.Count == 0) return false;
            var frame = p.Ready.Peek();
            uint n = (uint)p.Video.FrameRateNumerator, d = (uint)p.Video.FrameRateDenominator;
            ulong time = p.FileTime / p.FileTimeUnit * n + p.FileTime % p.FileTimeUnit * n / p.FileTimeUnit +
                ((ulong)p.SeekBase + (ulong)p.ConsumedFrames + p.TimeCompensation) * d;
            int index = p.SeekBase + p.ConsumedFrames + (int)frame.Skipped;
            if (p.Clock.UsesTime && index != 0 && index != p.SeekFrame &&
                (float)((float)time * 1000f / (float)n) > (float)((float)p.TimeCount * 1000f / (float)p.TimeUnit)) return false;
            frame_drop &= p.Clock.UsesTime && unchecked(p.TimeCount * n) / p.TimeUnit > time + d;
            p.Ready.Dequeue(); p.ConsumedFrames++;
            frame.Time = time; frame.Unit = n;
            frame_info.frameNo = p.FrameBase + index; frame_info.frameNoPerFile = index;
            frame_info.width = (uint)p.Video.Width; frame_info.height = (uint)p.Video.Height;
            frame_info.dispWidth = (uint)p.Video.DisplayWidth; frame_info.dispHeight = (uint)p.Video.DisplayHeight;
            frame_info.numImages = 3; frame_info.framerateN = n; frame_info.framerateD = d;
            frame_info.time = time; frame_info.tunit = n;
            frame_info.cntConcatenatedMovie = p.Concatenated; frame_info.cntSkippedFrames = frame.Skipped;
            frame_info.totalFramesPerFile = (uint)p.Video.TotalFrames;
            if (frame_drop) ReleaseManaFrame(p, frame);
            else
            {
                if (p.Pending != null) ReleaseManaFrame(p, p.Pending);
                if (p.Displayed != null) ReleaseManaFrame(p, p.Displayed);
                p.Pending = frame; p.Displayed = null;
            }
            return true;
        }

        private static void ReleaseManaFrame(ManaPlayer p, ManaFrame frame)
        {
            // Original 53D90/64708: a late release requests a future B-picture
            // skip and advances time compensation immediately. Ready pictures
            // retain the skipped-count snapshot from when they were decoded.
            float now = (float)((float)p.TimeCount / (float)p.TimeUnit) * 1000f;
            float then = (float)((float)frame.Time / (float)frame.Unit) * 1000f;
            float duration = 1000f / (float)((float)p.Video.FrameRateNumerator / (float)p.Video.FrameRateDenominator);
            if (p.Timer != ManaTimer.None && (float)(now - then) > (float)(4f * duration))
            { p.SkipRequests++; p.TimeCompensation++; }
            ReturnManaFrame(p, frame);
        }

        public bool CRIWARE1A1436DD(int player_id, int num_textures, IntPtr[] tex_ptrs)
        {
            var p = GetMana(player_id);
            if (p?.Pending == null) return false;
            if (num_textures < 0 || num_textures > 3 || tex_ptrs == null || num_textures > tex_ptrs.Length) return false;
            p.Pending.TextureCount = num_textures;
            Array.Copy(tex_ptrs, p.Pending.Textures, num_textures);
            return true;
        }

        internal void RegisterManaTexture(IntPtr pointer, Texture2D texture) => manaTextures[pointer] = texture;
        internal void UnregisterManaTexture(Texture texture)
        {
            IntPtr key = IntPtr.Zero;
            foreach (var pair in manaTextures) if (ReferenceEquals(pair.Value, texture)) { key = pair.Key; break; }
            if (key != IntPtr.Zero) manaTextures.Remove(key);
        }

        internal void IssueManaRenderEvent(int eventId)
        {
            if ((eventId & unchecked((int)0xffff0000)) != manaRenderingEventOffset) return;
            var p = manaPlayers[eventId & 255];
            if (p == null || p.Stopping || ((eventId >> 8) & 255) != 2 || p.Pending == null) return;
            var frame = p.Pending;
            for (int i = 0; i < frame.TextureCount; i++)
            {
                if (!manaTextures.TryGetValue(frame.Textures[i], out var texture) || texture == null)
                    throw new InvalidOperationException("The Mana render event references an unregistered texture.");
                texture.LoadRawTextureData(frame.Planes[i]);
                texture.Apply(false, false);
            }
            p.Displayed = frame; p.Pending = null;
        }
    }
}

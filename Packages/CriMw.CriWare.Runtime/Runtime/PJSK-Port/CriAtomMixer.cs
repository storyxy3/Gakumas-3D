using System;
using System.Collections.Generic;
using System.IO;

namespace CriWare
{
    // Native ASR bus order/effect/send stages: 0x14BF84, 0x14C4AC, 0x14FAF4.
    // This owns the stereo ASR configuration used by the original archive host.
    internal sealed class CriAtomMixer
    {
        private sealed class Bus
        {
            internal int Number;
            internal string Name;
            internal float Volume;
            internal readonly float[][] Input = { new float[256], new float[256] };
            internal readonly float[][] Scratch = { new float[256], new float[256] };
            internal bool Silent = true;
            internal readonly List<CriAtomDsp> Effects = new List<CriAtomDsp>();
            internal readonly List<Link> Links = new List<Link>();
        }
        private readonly struct Link
        {
            internal readonly int Bus;
            internal readonly float Level;
            internal Link(int bus, float level) { Bus = bus; Level = level; }
        }
        private readonly Dictionary<int, Bus> buses = new Dictionary<int, Bus>();
        private readonly Dictionary<string, int> names = new Dictionary<string, int>(StringComparer.Ordinal);
        private readonly List<Bus> order = new List<Bus>();
        private int blockFrames;

        // report: when supplied (backend C8 path), an effect the managed DSP
        // cannot run is reported and bypassed instead of failing the setting.
        internal CriAtomMixer(CriAtomUtf.Row? acf, string settingName, int sampleRate, Action<string> report = null)
        {
            if (!acf.HasValue || string.IsNullOrEmpty(settingName))
            {
                var output = new Bus { Number = 0, Name = "MasterOut", Volume = 1f };
                buses.Add(0, output); names.Add(output.Name, 0); order.Add(output);
                return;
            }
            var root = acf.Value;
            var settings = ReadTable(root, "DspSettingTable");
            int selected = -1;
            for (int i = 0; i < settings.RowCount; i++)
                if (settings.GetRow(i).Get<string>("Name") == settingName) { selected = i; break; }
            if (selected < 0) throw new InvalidDataException("Unknown ACF DSP bus setting: " + settingName);
            var setting = settings.GetRow(selected);
            if (Number(setting, "NumExtendBuses") != 0 || Number(setting, "NumMixerAisacs") != 0)
                throw new NotSupportedException("Extended DSP buses and mixer AISACs are outside the original stereo setting.");
            var busRows = ReadTable(root, "BusTable");
            var busNames = ReadTable(root, "BusNameTable");
            var effectRows = ReadTable(root, "DspFxTable");
            var linkRows = ReadTable(root, "BusLinkTable");
            int first = Number(setting, "StartIndex"), count = Number(setting, "NumBuses");
            for (int i = first; i < first + count; i++)
            {
                var row = busRows.GetRow(i);
                var bus = new Bus
                {
                    Number = Number(row, "BusNo"), Volume = row.Get<float>("Volume"),
                    Name = busNames.GetRow(Number(row, "BusNameIndex")).Get<string>("StringValue")
                };
                if (row.Get<float>("Pan3dVolume") != 1f || row.Get<float>("Pan3dAngle") != 0f || row.Get<float>("Pan3dDistance") != 1f)
                    throw new NotSupportedException("The stereo archive DSP setting uses the identity bus pan matrix.");
                int effectStart = Number(row, "StartFxIndex"), effectCount = Number(row, "NumFxs");
                for (int effect = effectStart; effect < effectStart + effectCount; effect++)
                {
                    var definition = effectRows.GetRow(effect);
                    if (Number(definition, "Bypass") != 0) continue;
                    try
                    {
                        bus.Effects.Add(CriAtomDsp.Create(definition.Get<string>("DspName"), 2, 2, sampleRate, 256,
                            Floats(definition.Get<ArraySegment<byte>>("ConfigParameters")),
                            Floats(definition.Get<ArraySegment<byte>>("Parameters"))));
                    }
                    catch (NotSupportedException exception) when (report != null)
                    {
                        report("E-HARUKI-UNSUPPORTED:DSP effect " + definition.Get<string>("DspName") + " on bus " + bus.Name + " is bypassed. (" + exception.Message + ")");
                    }
                }
                int linkStart = Number(row, "StartBusLinkIndex"), linkCount = Number(row, "NumBusLinks");
                for (int link = linkStart; link < linkStart + linkCount; link++)
                {
                    var definition = linkRows.GetRow(link);
                    // Authored type 2 becomes native route type 0: post volume/pan.
                    if (Number(definition, "Type") != 2) throw new NotSupportedException("Unsupported ACF bus-link stage.");
                    bus.Links.Add(new Link(Number(definition, "SendBusNo"), definition.Get<float>("SendLevel")));
                }
                buses.Add(bus.Number, bus); names.Add(bus.Name, bus.Number);
            }
            // Native visits upstream buses first, retaining ascending bus order
            // among the five independent sends in ProjectSekai.acf.
            var pending = new List<Bus>(buses.Values);
            pending.Sort((left, right) => left.Number.CompareTo(right.Number));
            while (pending.Count != 0)
            {
                int next = pending.FindIndex(candidate => !pending.Exists(other =>
                    other.Links.Exists(link => link.Bus == candidate.Number)));
                if (next < 0) throw new InvalidDataException("Cyclic ACF DSP bus links.");
                order.Add(pending[next]); pending.RemoveAt(next);
            }
            if (!buses.ContainsKey(0)) throw new InvalidDataException("The DSP setting has no MasterOut bus.");
            foreach (var bus in order)
                foreach (var link in bus.Links)
                    if (!buses.ContainsKey(link.Bus)) throw new InvalidDataException("ACF bus link refers to an absent bus.");
        }

        internal bool TryGetBus(string name, out int number) => names.TryGetValue(name, out number);

        internal void BeginBlock(int count)
        {
            if (count <= 0 || count > 256 || (count & 15) != 0) throw new ArgumentOutOfRangeException(nameof(count));
            blockFrames = count;
            foreach (var bus in order)
            {
                foreach (var channel in bus.Input) Array.Clear(channel, 0, count);
                bus.Silent = true;
            }
        }

        internal void Add(int busNumber, float[] input, int inputOffset, int outputChannel,
            int frames, float previousGain, float gain)
        {
            if (!buses.TryGetValue(busNumber, out var bus)) return;
            if (outputChannel < 0 || outputChannel > 1 || frames < 0 || frames > blockFrames || inputOffset < 0 || inputOffset > input.Length - frames)
                throw new ArgumentOutOfRangeException(nameof(frames));
            if (previousGain == 0f && gain == 0f) return;
            AddSamples(bus.Input[outputChannel], input, inputOffset, frames, previousGain, gain);
            bus.Silent = false;
        }

        internal void Render(float[][] output)
        {
            foreach (var bus in order)
            {
                float[][] source = bus.Input, target = bus.Scratch;
                bool silent = bus.Silent;
                foreach (var effect in bus.Effects)
                {
                    effect.Process(source, target, blockFrames, silent, out silent);
                    var swap = source; source = target; target = swap;
                }
                if (bus.Number == 0)
                {
                    for (int channel = 0; channel < 2; channel++)
                        for (int frame = 0; frame < blockFrames; frame++)
                            output[channel][frame] = silent ? 0f : (float)(source[channel][frame] * bus.Volume);
                }
                if (silent) continue;
                foreach (var link in bus.Links)
                {
                    float gain = (float)(link.Level * bus.Volume);
                    if (gain == 0f) continue;
                    var destination = buses[link.Bus];
                    for (int channel = 0; channel < 2; channel++)
                        AddSamples(destination.Input[channel], source[channel], 0, blockFrames, gain, gain);
                    destination.Silent = false;
                }
            }
        }

        // ASR's four-lane ramps accumulate step*4, rather than recomputing a
        // scalar lerp for every sample (0x13A1F0). Remainders use 0x13A118.
        internal static void AddSamples(float[] destination, float[] source, int sourceOffset, int count,
            float previousGain, float gain)
        {
            if (previousGain == gain)
            {
                for (int i = 0; i < count; i++) destination[i] = (float)(destination[i] + (gain == 1f ? source[sourceOffset + i] : (float)(gain * source[sourceOffset + i])));
                return;
            }
            int vectorCount = count & ~15;
            if (vectorCount != 0)
            {
                float step = (float)((float)(gain - previousGain) / vectorCount), advance = (float)(step * 4f);
                float g0 = previousGain, g1 = (float)(step + previousGain), g2 = (float)((float)(step + step) + previousGain), g3 = (float)((float)(step * 3f) + previousGain);
                for (int i = 0; i < vectorCount; i += 4)
                {
                    destination[i] = (float)(destination[i] + (float)(g0 * source[sourceOffset + i]));
                    destination[i + 1] = (float)(destination[i + 1] + (float)(g1 * source[sourceOffset + i + 1]));
                    destination[i + 2] = (float)(destination[i + 2] + (float)(g2 * source[sourceOffset + i + 2]));
                    destination[i + 3] = (float)(destination[i + 3] + (float)(g3 * source[sourceOffset + i + 3]));
                    g0 = (float)(advance + g0); g1 = (float)(advance + g1); g2 = (float)(advance + g2); g3 = (float)(advance + g3);
                }
            }
            int remainder = count - vectorCount;
            float tail = previousGain, tailStep = remainder == 0 ? 0f : (float)((float)(gain - previousGain) / remainder);
            for (int i = vectorCount; i < count; i++)
            {
                destination[i] = (float)(destination[i] + (float)(tail * source[sourceOffset + i]));
                tail = (float)(tailStep + tail);
            }
        }

        internal static CriAtomUtf.Table ReadTable(CriAtomUtf.Row row, string name) =>
            CriAtomUtf.Table.Parse(row.Get<ArraySegment<byte>>(name));
        internal static int Number(CriAtomUtf.Row row, string name) => Convert.ToInt32(row[name]);
        internal static float[] Floats(ArraySegment<byte> bytes)
        {
            if ((bytes.Count & 3) != 0) throw new InvalidDataException("Invalid big-endian float array.");
            var result = new float[bytes.Count / 4];
            for (int i = 0; i < result.Length; i++)
            {
                int offset = bytes.Offset + i * 4;
                uint bits = (uint)(bytes.Array[offset] << 24 | bytes.Array[offset + 1] << 16 | bytes.Array[offset + 2] << 8 | bytes.Array[offset + 3]);
                result[i] = BitConverter.Int32BitsToSingle(unchecked((int)bits));
            }
            return result;
        }
    }
}

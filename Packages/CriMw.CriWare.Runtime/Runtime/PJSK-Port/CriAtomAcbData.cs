using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;

namespace CriWare
{
    // Original ACB graph and metadata. This owns no player, clock, decoder or DSP.
    internal sealed class CriAtomAcbData
    {
        internal sealed class Cue
        {
            public int Index, Id, Type, PanType;
            public string Name, UserData;
            public long Length;
            public ushort NumTracks, NumRelatedWaveforms;
            public short NumLimits = -1;
            public byte Priority, HeaderVisibility, IgnorePlayerParameter, Probability = 100;
            public float Volume = 1, ConeInsideAngle = 360, ConeOutsideAngle = 360;
            public float MinAttenuationDistance, MaxAttenuationDistance = 30, SourceRadius, InteriorDistance, DopplerFactor;
            public readonly List<uint> CategoryIds = new List<uint>();
            internal int ReferenceType, ReferenceIndex;
        }

        internal sealed class Waveform
        {
            public int Index, Id, SamplingRate, Channels;
            public uint Format, NumSamples;
            public bool Streaming, Loop;
            public uint LoopStartSample, LoopEndSample;
            public ArraySegment<byte> Data;
        }

        internal readonly struct Command
        {
            public ushort Code { get; }
            public ArraySegment<byte> Payload { get; }
            internal Command(ushort code, ArraySegment<byte> payload) { Code = code; Payload = payload; }
        }

        internal sealed class RandomState
        {
            private uint x, y, z, w;
            public RandomState(uint seed) { Reset(seed); }
            internal RandomState(uint x, uint y, uint z, uint w) { this.x = x; this.y = y; this.z = z; this.w = w; }
            public void Reset(uint seed)
            {
                x = unchecked(1812433253u * (seed ^ (seed >> 30)));
                y = unchecked(1812433253u * (x ^ (x >> 30)) + 1);
                z = unchecked(1812433253u * (y ^ (y >> 30)) + 2);
                w = unchecked(1812433253u * (z ^ (z >> 30)) + 3);
            }
            public uint NextUInt()
            {
                uint t = x ^ (x << 11);
                x = y; y = z; z = w;
                return w = w ^ (w >> 19) ^ t ^ (t >> 8);
            }
            public uint NextInclusive(uint minimum, uint maximum)
            {
                // Native range arguments are nonnegative signed ints on these paths.
                if (minimum > int.MaxValue || maximum > int.MaxValue) throw new ArgumentOutOfRangeException(nameof(maximum));
                return NextUInt() % (Math.Max(minimum, maximum) - minimum + 1) + minimum;
            }
        }

        internal sealed class SelectionState
        {
            public RandomState MainRandom { get; }
            public RandomState AudioRandom { get; }
            public SelectionState(RandomState mainRandom, RandomState audioRandom)
            {
                MainRandom = mainRandom ?? throw new ArgumentNullException(nameof(mainRandom));
                AudioRandom = audioRandom ?? throw new ArgumentNullException(nameof(audioRandom));
            }
            public static SelectionState CreatePlayer(RandomState currentGlobal) => new SelectionState(
                new RandomState(currentGlobal.NextInclusive(0, int.MaxValue)),
                new RandomState(currentGlobal.NextInclusive(0, int.MaxValue)));
        }

        internal readonly struct BusSend
        {
            public string Name { get; }
            public float Level { get; }
            internal BusSend(string name, float level) { Name = name; Level = level; }
        }

        internal sealed class ParameterLayer
        {
            public string TableName;
            public int RowIndex;
            public IReadOnlyDictionary<uint, float> Scalars;
            public IReadOnlyList<uint> CategoryIds;
            public IReadOnlyList<BusSend> BusSends;
            public IReadOnlyList<string> GlobalAisacNames;
            public IReadOnlyList<Command> Commands;
            public int CueLimitCount = -1, CueLimitIndex = 65535, PriorityType = -1;
            public byte CueLimitMode;
            // Parameter block of D2EE4/D2FB4/D30B0/D31A8 (0x1f, 0x40); type 0/0xff clears it (CAC44).
            public BiquadSetting Biquad;
            public bool BiquadCleared;
        }

        internal sealed class BiquadSetting
        {
            public int Type;
            public float Frequency, Q, Gain;
        }

        internal sealed class WaveEvent
        {
            public Waveform Waveform;
            public long TimeUs, StartOffsetUs;
            public int TrackIndex;
            public IReadOnlyList<ParameterLayer> Layers;
            internal int Ordinal;
            internal CriAtomAcbData Owner;
            internal OffsetChoice[] OffsetChoices;
            internal bool OffsetResolved;
        }

        internal sealed class OffsetChoice
        {
            internal ArraySegment<byte> Payload;
            internal bool Resolved;
            internal long Value;
        }

        private readonly Dictionary<string, CriAtomUtf.Table> tables = new Dictionary<string, CriAtomUtf.Table>(StringComparer.Ordinal);
        private readonly Dictionary<string, Cue> byName = new Dictionary<string, Cue>(StringComparer.Ordinal);
        private readonly CriAtomAfs2 bank;
        // Native work fields belong to the loaded ACB, shared by its players.
        // Keep equivalent state separately instead of changing original input bytes.
        private readonly Dictionary<int, int> previousTracks = new Dictionary<int, int>();
        private readonly Dictionary<int, int> previousOffsets = new Dictionary<int, int>();
        public string Name { get; }
        public uint Version { get; }
        public float Volume { get; }
        public ushort AwbSubkey => bank?.Subkey ?? 0;
        public IReadOnlyList<Cue> Cues { get; }
        public IReadOnlyList<Waveform> Waveforms { get; }

        public static CriAtomAcbData Parse(ArraySegment<byte> bytes) => new CriAtomAcbData(bytes);

        private CriAtomAcbData(ArraySegment<byte> bytes)
        {
            var header = CriAtomUtf.Table.Parse(bytes);
            if (header.RowCount != 1) throw new InvalidDataException("Expected one original ACB header row.");
            var row = header.GetRow(0);
            Name = row.Get<string>("Name");
            Version = row.Get<uint>("Version");
            Volume = row.Get<float>("AcbVolume");
            foreach (var column in header.Columns)
            {
                if (column.Type != 11) continue;
                var blob = row.Get<ArraySegment<byte>>(column.Name);
                if (blob.Count >= 4 && U32(blob, 0) == 0x40555446)
                    tables.Add(column.Name, CriAtomUtf.Table.Parse(blob));
            }
            var awb = row.Get<ArraySegment<byte>>("AwbFile");
            if (awb.Count != 0) bank = CriAtomAfs2.Parse(awb);
            var waveTable = RequireTable("WaveformTable");
            var waves = new Waveform[waveTable.RowCount];
            for (int i = 0; i < waves.Length; i++)
            {
                var source = waveTable.GetRow(i);
                int encoding = Number(source, "EncodeType");
                var wave = new Waveform
                {
                    Index = i, SamplingRate = Number(source, "SamplingRate"), Channels = Number(source, "NumChannels"),
                    NumSamples = source.Get<uint>("NumSamples"), Streaming = Number(source, "Streaming") != 0,
                    Loop = Number(source, "LoopFlag") == 2,
                    Format = encoding == 0 ? 1u : encoding == 2 ? 3u : encoding == 6 ? 4u : encoding == 20 ? 5u : 0u
                };
                wave.Id = Number(source, wave.Streaming ? "StreamAwbId" : "MemoryAwbId");
                if (!wave.Streaming && bank != null) bank.TryGetValue((uint)wave.Id, out wave.Data);
                int extension = Number(source, "ExtensionData", 65535);
                if (extension != 65535)
                {
                    var loop = RequireTable("WaveformExtensionDataTable").GetRow(extension);
                    wave.LoopStartSample = loop.Get<uint>("LoopStart");
                    wave.LoopEndSample = loop.Get<uint>("LoopEnd");
                }
                waves[i] = wave;
            }
            Waveforms = Array.AsReadOnly(waves);

            var cueTable = RequireTable("CueTable");
            var cues = new Cue[cueTable.RowCount];
            for (int i = 0; i < cues.Length; i++)
            {
                var source = cueTable.GetRow(i);
                uint length = source.Get<uint>("Length");
                var cue = new Cue
                {
                    Index = i, Id = unchecked((int)source.Get<uint>("CueId")), UserData = source.Get<string>("UserData"),
                    Length = length == uint.MaxValue ? -1 : length, HeaderVisibility = (byte)Number(source, "HeaderVisibility"),
                    NumRelatedWaveforms = (ushort)Number(source, "NumRelatedWaveforms"), PanType = Version >= 0x1350000 ? 0 : -1,
                    ReferenceType = Number(source, "ReferenceType"), ReferenceIndex = Number(source, "ReferenceIndex")
                };
                if (cue.ReferenceType == 3)
                {
                    var sequence = RequireTable("SequenceTable").GetRow(cue.ReferenceIndex);
                    cue.Type = Number(sequence, "Type");
                    cue.NumTracks = (ushort)Number(sequence, "NumTracks");
                    ReadCueParameters(cue, Commands(sequence, "SeqCommandTable"));
                }
                else if (cue.ReferenceType == 2)
                {
                    var synth = RequireTable("SynthTable").GetRow(cue.ReferenceIndex);
                    cue.Type = Number(synth, "Type");
                    cue.NumTracks = (ushort)(synth.Get<ArraySegment<byte>>("ReferenceItems").Count / 4);
                    ReadCueParameters(cue, Commands(synth, "SynthCommandTable"));
                }
                cues[i] = cue;
            }
            var names = RequireTable("CueNameTable");
            for (int i = 0; i < names.RowCount; i++)
            {
                var source = names.GetRow(i);
                int index = Number(source, "CueIndex");
                if (index < 0 || index >= cues.Length) throw new InvalidDataException("ACB cue name points outside CueTable.");
                string name = source.Get<string>("CueName");
                if (cues[index].Name == null) cues[index].Name = name;
                byName.Add(name, cues[index]);
            }
            Cues = Array.AsReadOnly(cues);
        }

        public Cue GetCue(int index) => Cues[index];
        public bool TryGetCue(string name, out Cue cue) => byName.TryGetValue(name, out cue);

        public IReadOnlyList<WaveEvent> CreatePlan(Cue cue, SelectionState state) => CreatePlan(cue, state, out _);

        // C8: waves that need an external/streaming AWB or a non-HCA codec are
        // skipped and counted; a cue with no playable wave left is unsupported.
        public IReadOnlyList<WaveEvent> CreatePlan(Cue cue, SelectionState state, out int skippedWaves)
        {
            skipped = 0;
            if (cue == null || cue.Index < 0 || cue.Index >= Cues.Count || !ReferenceEquals(Cues[cue.Index], cue))
                throw new ArgumentException("Cue does not belong to this ACB.", nameof(cue));
            if (state == null) throw new ArgumentNullException(nameof(state));
            var result = new List<WaveEvent>();
            Expand(cue.ReferenceType, cue.ReferenceIndex, 0, 0, -1, new List<ParameterLayer>(),
                new List<OffsetChoice>(), state, new HashSet<long>(), result);
            result.Sort((a, b) => a.TimeUs != b.TimeUs ? a.TimeUs.CompareTo(b.TimeUs) : a.Ordinal.CompareTo(b.Ordinal));
            skippedWaves = skipped;
            if (skipped != 0 && result.Count == 0)
                throw new NotSupportedException("The original wave requires an unsupported streaming bank or codec.");
            return result.AsReadOnly();
        }
        private int skipped;

        // Call when the event reaches the audio server, before voice-level random
        // parameters. Plan creation must not advance the separate audio RNG stream.
        public long ResolveStartOffset(WaveEvent wave, SelectionState state)
        {
            if (wave == null || wave.Owner != this) throw new ArgumentException("Event does not belong to this ACB.", nameof(wave));
            if (state == null) throw new ArgumentNullException(nameof(state));
            if (wave.OffsetResolved) return wave.StartOffsetUs;
            foreach (var offset in wave.OffsetChoices)
            {
                if (!offset.Resolved)
                {
                    var payload = offset.Payload;
                    int choices = U16(payload, 0);
                    int previous = previousOffsets.TryGetValue(payload.Offset, out var stored) ? stored : U16(payload, 2);
                    bool exclude = previous >= 0 && previous < choices;
                    uint maximum = (uint)Math.Max(0, choices - (exclude ? 2 : 1));
                    int choice = (int)state.AudioRandom.NextInclusive(0, maximum);
                    if (exclude && choice >= previous) choice++;
                    previousOffsets[payload.Offset] = choice;
                    if (choice < choices) offset.Value = unchecked((int)(1000u * U32(payload, 4 + 4 * choice)));
                    offset.Resolved = true;
                }
                wave.StartOffsetUs += offset.Value;
            }
            wave.OffsetResolved = true;
            return wave.StartOffsetUs;
        }

        private void Expand(int type, int index, long time, long startOffset, int trackIndex,
            List<ParameterLayer> layers, List<OffsetChoice> offsets, SelectionState state, HashSet<long> visiting, List<WaveEvent> result)
        {
            long key = ((long)type << 32) | (uint)index;
            if (!visiting.Add(key)) throw new InvalidDataException("Cyclic original ACB playback graph.");
            int layerCount = layers.Count;
            try
            {
                if (type == 1)
                {
                    var wave = Waveforms[index];
                    if (wave.Streaming || wave.Data.Array == null || wave.Format != 3) { skipped++; return; }
                    var ordered = layers.ToArray();
                    Array.Reverse(ordered);
                    result.Add(new WaveEvent { Waveform = wave, TimeUs = time, StartOffsetUs = startOffset,
                        TrackIndex = trackIndex, Layers = Array.AsReadOnly(ordered), Ordinal = result.Count,
                        Owner = this, OffsetChoices = offsets.ToArray() });
                    return;
                }
                if (type == 2)
                {
                    var synth = RequireTable("SynthTable").GetRow(index);
                    if (Number(synth, "Type") != 0) throw new NotSupportedException("Unsupported original synth selection type.");
                    // Synth commands run on the server thread (mode 2, sub_145478), after plan creation.
                    layers.Add(ReadLayer("SynthTable", index, "SynthCommandTable", null));
                    var items = synth.Get<ArraySegment<byte>>("ReferenceItems");
                    RequireMultiple(items, 4);
                    for (int i = 0; i < items.Count; i += 4)
                        Expand(U16(items, i), U16(items, i + 2), time, startOffset, trackIndex, layers, offsets, state, visiting, result);
                    return;
                }
                // Type 7 (a synth item naming a nested sequence; only SE_VL_CALL_TOYA) runs
                // natively as a child playback with its own slot, which is not modelled (C8).
                if (type != 3) throw new NotSupportedException("Unsupported original playback reference type: " + type);
                var sequence = RequireTable("SequenceTable").GetRow(index);
                if (Number(sequence, "PlaybackRatio") != 100)
                    throw new NotSupportedException("Unsupported original sequence playback ratio.");
                layers.Add(ReadLayer("SequenceTable", index, "SeqCommandTable", state.MainRandom));
                var tracks = sequence.Get<ArraySegment<byte>>("TrackIndex");
                int count = Number(sequence, "NumTracks");
                RequireCount(tracks, count, 2);
                foreach (int selected in SelectTracks(sequence, index, count, state.MainRandom))
                {
                    int ti = U16(tracks, selected * 2);
                    var track = RequireTable("TrackTable").GetRow(ti);
                    layers.Add(ReadLayer("TrackTable", ti, "TrackCommandTable", state.MainRandom));
                    long eventTime = time, seek = startOffset;
                    var trackOffsets = new List<OffsetChoice>(offsets);
                    foreach (var command in ReadCommands(RequireTable("TrackEventTable").GetRow(Number(track, "EventIndex")).Get<ArraySegment<byte>>("Command")))
                    {
                        var payload = command.Payload;
                        switch (command.Code)
                        {
                            case 0x7d0:
                                RequireLength(payload, 4);
                                Expand(U16(payload, 0), U16(payload, 2), eventTime, seek, ti, layers, trackOffsets, state, visiting, result);
                                break;
                            case 0x7d1:
                                RequireLength(payload, 4);
                                eventTime += unchecked((int)(1000u * U32(payload, 0)));
                                break;
                            case 0x7d5:
                                RequireLength(payload, 2);
                                eventTime += unchecked((short)U16(payload, 0));
                                break;
                            case 0x3e4:
                                // The shipped ambient command is an initial random
                                // seek, with its previous choice stored in the ACB.
                                if (eventTime != time) throw new NotSupportedException("Random seek after a scheduled event needs incremental execution.");
                                RequireCount(payload, 1, 4);
                                int choices = U16(payload, 0);
                                RequireLength(payload, 4 + 4 * choices);
                                if (choices < 1) throw new InvalidDataException("Empty original random seek list.");
                                trackOffsets.Add(new OffsetChoice { Payload = payload });
                                break;
                            default: throw new NotSupportedException("Unsupported original track event: 0x" + command.Code.ToString("x"));
                        }
                    }
                    layers.RemoveAt(layers.Count - 1);
                }
            }
            finally
            {
                if (layers.Count > layerCount) layers.RemoveRange(layerCount, layers.Count - layerCount);
                visiting.Remove(key);
            }
        }

        private IEnumerable<int> SelectTracks(CriAtomUtf.Row sequence, int index, int count, RandomState random)
        {
            int type = Number(sequence, "Type");
            if (type == 0) { for (int i = 0; i < count; i++) yield return i; yield break; }
            if (type != 3 && type != 4 || Version >= 0x1420000)
                throw new NotSupportedException("Unsupported original sequence selection type/version.");
            if (count == 0) yield break;
            var weights = sequence.Get<ArraySegment<byte>>("TrackValues");
            bool weighted = weights.Count != 0;
            if (weighted) RequireLength(weights, 2 * count);
            int previous = previousTracks.TryGetValue(index, out var last) ? last : -1;
            uint total = 0, available = 0;
            int positive = 0;
            for (int i = 0; i < count; i++)
            {
                uint weight = weighted ? U16(weights, i * 2) : 1u;
                total += weight;
                if (i == previous) continue;
                available += weight;
                if (weight != 0) positive++;
            }
            uint maximum;
            bool exclude = type == 4 && previous >= 0 && positive != 0;
            if (type == 3) maximum = weighted && total != 0 ? total : (uint)(count - 1);
            else if (previous < 0) maximum = weighted ? Math.Max(total, 100u) : (uint)(count - 1);
            else if (!weighted) maximum = (uint)(count - 1);
            else maximum = total >= 100 && available != 0 ? available :
                total == 0 && available != 0 ? (uint)positive : 100 - total + available;
            uint draw = random.NextInclusive(0, maximum);
            uint cumulative = 0;
            for (int i = 0; i < count; i++)
            {
                if (exclude && i == previous) continue;
                cumulative += weighted ? U16(weights, i * 2) : 1u;
                if ((ushort)cumulative < draw) continue;
                if (type == 4 && count != 1) previousTracks[index] = i;
                yield return i;
                yield break;
            }
        }

        // sub_84A6C. Sequence and track commands run in criAtomExPlayer_Start on the
        // caller's thread, so random ranges draw from the player's main generator
        // (player +0x258, sub_F45D8) in command order, interleaved with track selection.
        private ParameterLayer ReadLayer(string tableName, int rowIndex, string commandTable, RandomState random)
        {
            var row = RequireTable(tableName).GetRow(rowIndex);
            if (Number(row, "ParameterPallet", 65535) != 65535 || Number(row, "NumActionTracks") != 0
                || row.Get<ArraySegment<byte>>("LocalAisacs").Count != 0)
                throw new NotSupportedException("Unsupported original local AISAC, parameter pallet or action track.");
            var commands = new List<Command>(Commands(row, commandTable));
            var scalars = new Dictionary<uint, float>();
            var categories = new List<uint>();
            var sends = new List<BusSend>();
            var aisacs = new List<string>();
            var layer = new ParameterLayer { TableName = tableName, RowIndex = rowIndex };
            foreach (var command in commands)
            {
                var payload = command.Payload;
                switch (command.Code)
                {
                    case 0x41:
                        RequireMultiple(payload, 4);
                        for (int i = 0; i < payload.Count; i += 4) categories.Add(U32(payload, i));
                        break;
                    case 0x45: RequireLength(payload, 4); scalars[89] = Float(payload, 0); break;
                    case 0x57: RequireLength(payload, 2); scalars[0] = (float)(U16(payload, 0) / 100f); break;
                    case 0x5: RequireLength(payload, 2); scalars[3] = unchecked((short)U16(payload, 0)); break;
                    // Native ID 4 reserves the maximum frequency ratio in cents;
                    // it does not randomize pitch or consume the audio RNG.
                    case 0x79: RequireLength(payload, 2); scalars[4] = unchecked((short)U16(payload, 0)); break;
                    case 0x6f:
                        RequireLength(payload, 4);
                        var send = new BusSend(RequireTable("StringValueTable").GetRow(U16(payload, 0)).Get<string>("StringValue"), (float)(U16(payload, 2) / 10000f));
                        int existing = sends.FindIndex(value => value.Name == send.Name);
                        // C9644 overwrites within a layer; CDEF4 multiplies across layers.
                        if (existing < 0) sends.Add(send); else sends[existing] = send;
                        break;
                    case 0x4f:
                        RequireLength(payload, 5);
                        layer.CueLimitCount = U16(payload, 0); layer.CueLimitIndex = U16(payload, 2);
                        layer.CueLimitMode = payload.Array[payload.Offset + 4];
                        break;
                    case 0x51: RequireLength(payload, 1); layer.PriorityType = payload.Array[payload.Offset]; break;
                    // Random pitch: centre 0, range in cents, clamped to +-2400 (case 8).
                    case 0x8: RequireLength(payload, 2); scalars[3] = RandomRange(random, 0f, unchecked((short)U16(payload, 0)), -2400f, 2400f); break;
                    // Random pitch with an explicit centre (case 60; MenuCommon only, not oracle-covered).
                    case 0x3c:
                        RequireLength(payload, 4);
                        scalars[3] = RandomRange(random, unchecked((short)U16(payload, 0)), unchecked((short)U16(payload, 2)), -2400f, 2400f);
                        break;
                    // Pan3d angle in tenths of a degree (case 11) and its random range (case 61).
                    case 0xb: RequireLength(payload, 2); scalars[5] = (float)(unchecked((short)U16(payload, 0)) / 10f); break;
                    case 0x3d:
                        RequireLength(payload, 4);
                        scalars[5] = RandomRange(random, (float)(unchecked((short)U16(payload, 0)) / 10f),
                            (float)(unchecked((short)U16(payload, 2)) / 10f), -360f, 360f);
                        break;
                    case 0x1f:
                    case 0x40:
                    {
                        byte type = payload.Array[payload.Offset];
                        if ((byte)(type + 1) < 2)
                        {
                            layer.Biquad = null; layer.BiquadCleared = true;
                            break;
                        }
                        // Case 31: frequency u16/10000, Q u16/100, gain u16/100. Case 64 draws
                        // frequency in [0, 1] and Q in [0.01, 10] from (centre, range) pairs.
                        var biquad = new BiquadSetting { Type = type };
                        if (command.Code == 0x1f)
                        {
                            RequireLength(payload, 7);
                            biquad.Frequency = (float)(U16(payload, 1) / 10000f);
                            biquad.Q = (float)(U16(payload, 3) / 100f);
                            biquad.Gain = (float)(U16(payload, 5) / 100f);
                        }
                        else
                        {
                            RequireLength(payload, 11);
                            biquad.Frequency = RandomRange(random, (float)(U16(payload, 1) / 10000f), (float)(U16(payload, 3) / 10000f), 0f, 1f);
                            biquad.Q = RandomRange(random, (float)(U16(payload, 5) / 100f), (float)(U16(payload, 7) / 100f), 0.01f, 10f);
                            biquad.Gain = (float)(U16(payload, 9) / 100f);
                        }
                        layer.Biquad = biquad; layer.BiquadCleared = false;
                        break;
                    }
                    default: throw new NotSupportedException("Unsupported original parameter command: 0x" + command.Code.ToString("x"));
                }
            }
            int start = Number(row, "GlobalAisacStartIndex", 65535), count = Number(row, "GlobalAisacNumRefs");
            for (int i = 0; i < count; i++) aisacs.Add(RequireTable("GlobalAisacReferenceTable").GetRow(start + i).Get<string>("Name"));
            layer.Scalars = new ReadOnlyDictionary<uint, float>(scalars);
            layer.CategoryIds = categories.AsReadOnly(); layer.BusSends = sends.AsReadOnly();
            layer.GlobalAisacNames = aisacs.AsReadOnly(); layer.Commands = commands.AsReadOnly();
            return layer;
        }

        // sub_D46D0: centre +- range clipped to [minimum, maximum], drawn with one
        // 0..0x7fffffff sample (no draw for a zero range), then clamped again.
        private static float RandomRange(RandomState random, float centre, float range, float minimum, float maximum)
        {
            float value = centre;
            if (range != 0f)
            {
                if (random == null) throw new NotSupportedException("Random parameter ranges on synth commands are drawn on the audio server.");
                uint draw = random.NextInclusive(0, int.MaxValue);
                float low = (float)(centre - range), high = (float)(centre + range);
                if (low < minimum) low = minimum;
                if (high > maximum) high = maximum;
                value = (float)(low + (float)((float)((float)(high - low) * (float)(int)draw) * 4.656612873077393e-10f));
            }
            value = value > minimum ? value : minimum;
            return value < maximum ? value : maximum;
        }

        // Native metadata visits table order and returns the first waveform; it
        // does not run the sequence's random selection or scheduling commands.
        public bool TryGetWaveformInfo(Cue cue, out Waveform waveform)
        {
            return FindWaveform(cue.ReferenceType, cue.ReferenceIndex, new HashSet<long>(), out waveform);
        }

        private bool FindWaveform(int type, int index, HashSet<long> visiting, out Waveform waveform)
        {
            waveform = null;
            if (!visiting.Add(((long)type << 32) | (uint)index)) return false;
            if (type == 1) { waveform = Waveforms[index]; return true; }
            if (type == 2 || type == 6)
            {
                var items = RequireTable("SynthTable").GetRow(index).Get<ArraySegment<byte>>("ReferenceItems");
                RequireMultiple(items, 4);
                for (int offset = 0; offset < items.Count; offset += 4)
                    if (FindWaveform(U16(items, offset), U16(items, offset + 2), visiting, out waveform)) return true;
            }
            else if (type == 3 || type == 7)
            {
                var sequence = RequireTable("SequenceTable").GetRow(index);
                var tracks = sequence.Get<ArraySegment<byte>>("TrackIndex");
                int count = Number(sequence, "NumTracks");
                RequireCount(tracks, count, 2);
                for (int i = 0; i < count; i++)
                {
                    var track = RequireTable("TrackTable").GetRow(U16(tracks, i * 2));
                    foreach (var command in ReadCommands(RequireTable("TrackEventTable").GetRow(Number(track, "EventIndex")).Get<ArraySegment<byte>>("Command")))
                    {
                        if (command.Code == 4000) break;
                        if (command.Code == 2000 || command.Code == 2003 || command.Code == 2004)
                        {
                            RequireCount(command.Payload, 1, 4);
                            if (FindWaveform(U16(command.Payload, 0), U16(command.Payload, 2), visiting, out waveform)) return true;
                        }
                    }
                }
            }
            return false;
        }

        private void ReadCueParameters(Cue cue, IEnumerable<Command> commands)
        {
            // Original CueInfo reads only the root sequence/synth command row
            // (sub_8CB68 / sub_86C3C), independently of playback inheritance.
            foreach (var command in commands)
            {
                var data = command.Payload;
                switch (command.Code)
                {
                    case 0x41:
                        RequireMultiple(data, 4);
                        for (int offset = 0; offset < data.Count; offset += 4) cue.CategoryIds.Add(U32(data, offset));
                        break;
                    case 0x45: RequireCount(data, 1, 4); cue.MaxAttenuationDistance = Float(data, 0); break;
                    case 0x46: RequireCount(data, 1, 1); cue.PanType = data.Array[data.Offset]; break;
                    case 0x4f: RequireCount(data, 1, 5); cue.NumLimits = unchecked((short)U16(data, 0)); break;
                    case 0x57: RequireCount(data, 1, 2); cue.Volume = (float)(U16(data, 0) / 100f); break;
                }
            }
        }

        private IEnumerable<Command> Commands(CriAtomUtf.Row row, string table)
        {
            int index = Number(row, "CommandIndex", 65535);
            return index == 65535 ? Array.Empty<Command>() :
                ReadCommands(RequireTable(table).GetRow(index).Get<ArraySegment<byte>>("Command"));
        }

        internal static IEnumerable<Command> ReadCommands(ArraySegment<byte> data)
        {
            int offset = 0;
            while (offset < data.Count)
            {
                if (data.Count - offset < 3) throw new InvalidDataException("Truncated ACB command header.");
                ushort code = U16(data, offset);
                int length = data.Array[data.Offset + offset + 2];
                offset += 3;
                if (length > data.Count - offset) throw new InvalidDataException("Truncated ACB command payload.");
                var payload = new ArraySegment<byte>(data.Array, data.Offset + offset, length);
                offset += length;
                // Native end stops before any retained padding after the row.
                if (code == 0) yield break;
                yield return new Command(code, payload);
            }
        }

        private CriAtomUtf.Table RequireTable(string name) => tables.TryGetValue(name, out var table) ? table :
            throw new InvalidDataException("Missing original ACB table: " + name);
        private static int Number(CriAtomUtf.Row row, string name, int fallback = 0) =>
            row.TryGetValue(name, out var value) ? Convert.ToInt32(value) : fallback;
        private static ushort U16(ArraySegment<byte> bytes, int offset) =>
            (ushort)((bytes.Array[bytes.Offset + offset] << 8) | bytes.Array[bytes.Offset + offset + 1]);
        private static uint U32(ArraySegment<byte> bytes, int offset) => ((uint)U16(bytes, offset) << 16) | U16(bytes, offset + 2);
        private static float Float(ArraySegment<byte> bytes, int offset) => BitConverter.Int32BitsToSingle(unchecked((int)U32(bytes, offset)));
        private static void RequireMultiple(ArraySegment<byte> bytes, int width)
        {
            if (bytes.Count % width != 0) throw new InvalidDataException("Malformed original ACB reference list.");
        }
        private static void RequireCount(ArraySegment<byte> bytes, int count, int width)
        {
            if (count < 0 || (long)count * width > bytes.Count) throw new InvalidDataException("Truncated original ACB value.");
        }
        private static void RequireLength(ArraySegment<byte> bytes, int length)
        {
            if (bytes.Count != length) throw new InvalidDataException("Unexpected original ACB command size.");
        }
    }
}

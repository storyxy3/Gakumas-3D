using System;
using System.Collections.Generic;
using System.IO;

namespace CriWare
{
    public sealed partial class CriAtomNativeBackend
    {
        private sealed class Aisac
        {
            internal uint Control;
            internal bool HasDefault;
            internal float Default;
            internal Graph[] Graphs;
        }
        private sealed class Graph
        {
            internal ushort Type;
            internal float[] Controls, Destinations;
            internal bool HasCurve;
        }
        private readonly Dictionary<string, Aisac> globalAisacs = new Dictionary<string, Aisac>(StringComparer.Ordinal);
        private Aisac[][] categoryAisacs;
        private CriAtomCategoryState categories;
        private readonly Dictionary<string, int> categoryNames = new Dictionary<string, int>(StringComparer.Ordinal);
        private readonly Dictionary<uint, int> categoryIndices = new Dictionary<uint, int>();

        private void InstallCategories(CriAtomUtf.Row root)
        {
            categoryNames.Clear(); categoryIndices.Clear();
            var rows = CriAtomMixer.ReadTable(root, "CategoryTable");
            var names = CriAtomMixer.ReadTable(root, "CategoryNameTable");
            var commands = CriAtomMixer.ReadTable(root, "CommandTable");
            var configs = new CriAtomCategoryState.CategoryConfig[rows.RowCount];
            for (int i = 0; i < rows.RowCount; i++)
            {
                var row = rows.GetRow(i);
                categoryIndices.Add(Convert.ToUInt32(row["Id"]), i);
                float gain = 1f; int limit = 0; ushort list = ushort.MaxValue;
                var payload = commands.GetRow(CriAtomMixer.Number(row, "CommandIndex")).Get<ArraySegment<byte>>("Command");
                foreach (var command in CriAtomAcbData.ReadCommands(payload))
                {
                    if (command.Code == 0x57) gain = (float)(Be16(command.Payload, 0) / 100f);
                    else if (command.Code == 0x49) { limit = Be16(command.Payload, 0); list = Be16(command.Payload, 2); }
                    // C8: an unknown category command is reported and ignored.
                    else Report("E-HARUKI-UNSUPPORTED:ACF category command 0x" + command.Code.ToString("x") + " is ignored.");
                }
                configs[i] = new CriAtomCategoryState.CategoryConfig(gain, limit, list);
            }
            for (int i = 0; i < names.RowCount; i++)
            {
                var row = names.GetRow(i);
                categoryNames.Add(row.Get<string>("Name"), CriAtomMixer.Number(row, "Index"));
            }
            var reactRows = CriAtomMixer.ReadTable(root, "ReactTable");
            var reacts = new CriAtomCategoryState.ReactConfig[reactRows.RowCount];
            for (int i = 0; i < reacts.Length; i++)
            {
                var row = reactRows.GetRow(i);
                reacts[i] = new CriAtomCategoryState.ReactConfig
                {
                    SourceCategory = CriAtomMixer.Number(row, "Src"), DestinationCategory = CriAtomMixer.Number(row, "Dest"),
                    ParameterId = Convert.ToUInt32(row["ParameterId"]), Level = row.Get<float>("Level"),
                    DecrementTimeMs = (ushort)CriAtomMixer.Number(row, "DecrementTime"),
                    IncrementTimeMs = (ushort)CriAtomMixer.Number(row, "IncrementTime"),
                    HoldTimeMs = (ushort)CriAtomMixer.Number(row, "HoldTime"), FixedHold = CriAtomMixer.Number(row, "HoldType") == 1,
                    CountPausingCue = CriAtomMixer.Number(row, "CountPausingCue") != 0,
                    StartCurveType = (byte)CriAtomMixer.Number(row, "StartCurveType"), EndCurveType = (byte)CriAtomMixer.Number(row, "EndCurveType"),
                    StartCurveStrength = (float)(CriAtomMixer.Number(row, "StartCurveStrength") / 100f),
                    EndCurveStrength = (float)(CriAtomMixer.Number(row, "EndCurveStrength") / 100f)
                };
            }
            var accepted = new List<CriAtomCategoryState.ReactConfig>();
            foreach (var react in reacts)
            {
                bool categoriesExist = (uint)react.SourceCategory < configs.Length && (uint)react.DestinationCategory < configs.Length;
                bool volumeCurve = react.ParameterId == 0 && (react.StartCurveType == 0 || react.StartCurveType == 2) &&
                    (react.EndCurveType == 0 || react.EndCurveType == 2) && react.StartCurveStrength >= 0f && react.StartCurveStrength <= 1f &&
                    react.EndCurveStrength >= 0f && react.EndCurveStrength <= 1f;
                if (categoriesExist && volumeCurve) accepted.Add(react);
                else Report("E-HARUKI-UNSUPPORTED:ACF REACT row " + react.SourceCategory + "->" + react.DestinationCategory + " is ignored.");
            }
            categories = new CriAtomCategoryState(configs, accepted.ToArray());
        }
        private void ClearCategories() { categories = null; categoryNames.Clear(); categoryIndices.Clear(); }
        public void criAtomExCategory_SetVolumeByName(string name, float volume)
        {
            if (name == null || categories == null || !categoryNames.TryGetValue(name, out int index))
            { Report("E:Category was not found: " + name); return; }
            categories.SetVolume(index, volume);
        }
        private void InstallAisacs(CriAtomUtf.Row root)
        {
            globalAisacs.Clear();
            uint version = root.Get<uint>("Version");
            var graphRows = CriAtomMixer.ReadTable(root, "GraphTable");
            var graphs = new Graph[graphRows.RowCount];
            for (int i = 0; i < graphs.Length; i++)
            {
                var row = graphRows.GetRow(i);
                ushort type = (ushort)CriAtomMixer.Number(row, "Type");
                var destinations = row.Get<ArraySegment<byte>>("Destinations");
                var graph = new Graph
                {
                    Type = type, Controls = CriAtomMixer.Floats(row.Get<ArraySegment<byte>>("Controls")),
                    HasCurve = row.Get<ArraySegment<byte>>("Curve").Count != 0
                };
                if (version >= 0x1310300) graph.Destinations = CriAtomMixer.Floats(destinations);
                else
                {
                    graph.Destinations = new float[destinations.Count / 2];
                    float scale = CriAtomAisacGraph.GetLegacyDestinationScale(type);
                    for (int j = 0; j < graph.Destinations.Length; j++) graph.Destinations[j] = (float)(unchecked((short)Be16(destinations, j * 2)) / scale);
                }
                if (type != 1)
                {
                    // C8: non-volume AISAC graphs are reported and not applied.
                    Report("E-HARUKI-UNSUPPORTED:ACF AISAC graph " + i + " of type " + type + " is ignored.");
                    continue;
                }
                graphs[i] = graph;
            }
            var globals = ReadAisacs(CriAtomMixer.ReadTable(root, "GlobalAisacTable"), graphs, version, Report);
            var names = CriAtomMixer.ReadTable(root, "GlobalAisacNameTable");
            for (int i = 0; i < names.RowCount; i++)
            {
                var row = names.GetRow(i); globalAisacs.Add(row.Get<string>("Name"), globals[CriAtomMixer.Number(row, "Index")]);
            }
            var own = ReadAisacs(CriAtomMixer.ReadTable(root, "AisacTable"), graphs, version, Report);
            var categoryRows = CriAtomMixer.ReadTable(root, "CategoryTable");
            categoryAisacs = new Aisac[categoryRows.RowCount][];
            for (int i = 0; i < categoryAisacs.Length; i++)
            {
                var indices = categoryRows.GetRow(i).Get<ArraySegment<byte>>("Aisacs");
                categoryAisacs[i] = new Aisac[indices.Count / 2];
                for (int j = 0; j < categoryAisacs[i].Length; j++) categoryAisacs[i][j] = own[Be16(indices, 2 * j)];
            }
        }
        private static Aisac[] ReadAisacs(CriAtomUtf.Table rows, Graph[] graphs, uint version, Action<string> report)
        {
            var result = new Aisac[rows.RowCount];
            for (int i = 0; i < result.Length; i++)
            {
                var row = rows.GetRow(i);
                bool unsupported = CriAtomMixer.Number(row, "Type") != 0 || CriAtomMixer.Number(row, "AutoModulationIndex") != 65535;
                if (unsupported) report("E-HARUKI-UNSUPPORTED:Random or automatic ACF AISAC " + i + " is ignored.");
                uint control = Convert.ToUInt32(row["ControlId"]);
                if (version < 0x1270000) control += 64536u;
                else control += 65536u;
                var indices = row.Get<ArraySegment<byte>>("GraphIndexes");
                var value = new Aisac
                {
                    Control = control, HasDefault = CriAtomMixer.Number(row, "DefaultControlFlag") != 0,
                    Default = row.Get<float>("DefaultControl"), Graphs = new Graph[indices.Count / 2]
                };
                var used = new List<Graph>();
                if (!unsupported)
                    for (int j = 0; j < indices.Count / 2; j++) { var graph = graphs[Be16(indices, 2 * j)]; if (graph != null) used.Add(graph); }
                value.Graphs = used.ToArray();
                result[i] = value;
            }
            return result;
        }
        private void ClearAisacs() { globalAisacs.Clear(); categoryAisacs = null; }
        private static ushort Be16(ArraySegment<byte> bytes, int offset)
        {
            if (offset < 0 || offset > bytes.Count - 2) throw new InvalidDataException("Truncated CRI parameter.");
            int at = bytes.Offset + offset;
            return (ushort)(bytes.Array[at] << 8 | bytes.Array[at + 1]);
        }
        private float ApplyAisac(Aisac aisac, Parameters controls, float gain)
        {
            if (!controls.TryGet(aisac.Control, out float control))
            {
                if (!aisac.HasDefault) return gain;
                control = aisac.Default;
            }
            foreach (var graph in aisac.Graphs) gain = (float)(gain * (CriAtomAisacGraph.Evaluate(control, graph.Controls, graph.Destinations, graph.HasCurve)));
            return gain;
        }

        private bool ReserveCueLimits(Playback playback)
        {
            // Native 1494E4 reserves the ACB's shared limit-index queues before
            // category allocation. A stopped cue releases its slot immediately,
            // while its voice and playback status can still be releasing.
            foreach (var wave in playback.Plan)
                foreach (var layer in wave.Layers)
                {
                    int index = layer.CueLimitIndex;
                    if (layer.CueLimitCount <= 0 || index == ushort.MaxValue || playback.CueLimits.Contains(index)) continue;
                    if (!playback.Bank.CueLimits.TryGetValue(index, out var queue))
                        playback.Bank.CueLimits.Add(index, queue = new List<Playback>());
                    if (queue.Count >= layer.CueLimitCount)
                    {
                        if (layer.CueLimitMode == 1) return false;
                        StopPlayback(queue[0], false);
                    }
                    queue.Add(playback);
                    playback.CueLimits.Add(index);
                }
            return true;
        }

        private static void ReleaseCueLimits(Playback playback)
        {
            foreach (int index in playback.CueLimits) playback.Bank.CueLimits[index].Remove(playback);
            playback.CueLimits.Clear();
        }

        private bool ReserveCategories(Playback playback)
        {
            if (categories == null) return true;
            bool firstWins = false;
            if (playback.Plan.Count != 0)
                foreach (var layer in playback.Plan[0].Layers)
                    if (layer.PriorityType >= 0) firstWins = layer.PriorityType != 0;
            foreach (uint id in playback.Cue.CategoryIds)
            {
                if (!categoryIndices.TryGetValue(id, out int category)) continue;
                if (!categories.TryReserve(category, playback.Id, 0, firstWins, null, out uint victim)) return false;
                playback.Categories.Add(category);
                if (victim != 0) StopPlayback(FindPlayback(victim), false);
            }
            return true;
        }
        private void CountPlayback(Playback playback, bool increment)
        {
            if (categories == null || playback.Counted == increment) return;
            bool unpaused = increment ? playback.PauseMask == 0 : playback.CountedUnpaused;
            foreach (int category in playback.Categories) categories.ChangePlayingCount(category, increment, true, unpaused);
            playback.Counted = increment;
            playback.CountedUnpaused = increment && unpaused;
        }
        private void ReleaseCategories(Playback playback)
        {
            if (categories == null) return;
            CountPlayback(playback, false);
            ReleaseCategoryLimits(playback);
        }
        private void ReleaseCategoryLimits(Playback playback)
        {
            if (categories == null) return;
            foreach (int category in playback.Categories) categories.Release(category, playback.Id);
        }

        private void UpdatePlaybackParameters(Playback playback)
        {
            foreach (var voice in playback.Voices) voice.ParametersDirty = true;
        }
        private float VoiceGain(Playback playback, CriAtomAcbData.WaveEvent wave)
        {
            var controls = new Parameters();
            foreach (var layer in wave.Layers)
                foreach (var entry in layer.Scalars) if (entry.Key >= 65536) controls.Set(entry.Key, entry.Value);
            foreach (var entry in playback.Snapshot.Values) if (entry.Key >= 65536) controls.Set(entry.Key, entry.Value);
            float gain = 1f;
            foreach (var layer in wave.Layers)
            {
                if (layer.Scalars.TryGetValue(0, out float level)) gain = (float)(gain * (level));
                foreach (string name in layer.GlobalAisacNames)
                    if (globalAisacs.TryGetValue(name, out var aisac)) gain = ApplyAisac(aisac, controls, gain);
            }
            if (playback.Snapshot.TryGet(0, out float playerGain)) gain = (float)(gain * (playerGain));
            foreach (int category in playback.Categories)
            {
                gain = (float)(gain * (categories.GetVolume(category)));
                if (categoryAisacs != null)
                    foreach (var aisac in categoryAisacs[category]) gain = ApplyAisac(aisac, controls, gain);
                gain = categories.ApplyReactGains(category, gain);
            }
            float volume = (float)(playback.Bank.Sheet.Volume * gain);
            float final = (float)(volume * playback.FaderGain);
            if (playback.Snapshot.TryGet(182, out float extra)) final = (float)(extra * final);
            else if (playback.Snapshot.Get(181, 0f) == 1f) final = (float)(0f * final);
            // Native fmaxNumber followed by the ASR zero-volume threshold.
            return float.IsNaN(final) || final <= 1f / 65536f ? 0f : final;
        }
        private static float VoicePitch(Playback playback, CriAtomAcbData.WaveEvent wave)
        {
            float pitch = 0f;
            foreach (var layer in wave.Layers) if (layer.Scalars.TryGetValue(3, out float value)) pitch = (float)(pitch + (value));
            return (float)(pitch + playback.Snapshot.Get(3, 0f));
        }
        // Parameter 5 (Pan3d angle, degrees) from the ACB layers, summed like pitch;
        // the shipped content sets it on one sequence layer only.
        private static float VoicePanAngle(CriAtomAcbData.WaveEvent wave)
        {
            float angle = 0f;
            foreach (var layer in wave.Layers) if (layer.Scalars.TryGetValue(5, out float value)) angle = (float)(angle + (value));
            return angle;
        }

        // sub_D80FC as the ASR calls it for the stereo output ({inputs, 2, 2}): each
        // input channel's layout angle plus the Pan3d angle is panned between the
        // adjacent entries of the 2-speaker ring (unk_25EBF0 over the initialised
        // angles at 0x2ACA90), whose surround entries fold into L/R at -3 dB. Pan3d
        // interior distance, volume and spread keep their defaults (1, 1, 1), so the
        // 0.7071 mono and identity stereo matrices of angle 0 fall out unchanged.
        private static readonly float[] LayoutAngles = { -30f, 30f, 0f, 0f, -120f, 120f };
        private static readonly int[] RingAngle = { 4, 0, 1, 5 }, RingSpeaker = { 0, 0, 1, 1 };
        private static readonly float[] RingWeight = { 0.7079457640647888f, 1f, 1f, 0.7079457640647888f };
        internal static float[,] PanMatrix(int channels, float angle)
        {
            var matrix = new float[channels, 2];
            int[] map = channels == 1 ? new[] { 2 } : new[] { 0, 1 };
            for (int channel = 0; channel < channels; channel++)
            {
                float position = (float)(angle + (float)(1f * LayoutAngles[map[channel]]));
                position = position % 360f;
                if (position > 180f) position = (float)(position + -360f);
                if (!(position > -180f)) position = (float)(position + 360f);
                int count = RingAngle.Length, low = -1, high = 0;
                float first = LayoutAngles[RingAngle[0]], lowAngle = 0f, highAngle = 0f, x = position;
                if (!(first > position))
                {
                    float current = first;
                    for (int i = 1; i < count; i++)
                    {
                        float previous = current;
                        current = LayoutAngles[RingAngle[i]];
                        if (current > position) { low = i - 1; high = i; lowAngle = previous; highAngle = current; break; }
                    }
                }
                if (low < 0)
                {
                    low = count - 1; high = 0;
                    highAngle = (float)(first + 360f);
                    lowAngle = LayoutAngles[RingAngle[low]];
                    if (lowAngle > position) x = (float)(position + 360f);
                }
                float span = (float)(highAngle - lowAngle), t = 0f;
                if (!(span < 1.1754943508222875e-38f)) t = (float)((float)((float)(x - lowAngle) / span) * 1.5707963705062866f);
                CriAtomLibm.SinCosF(t, out float sin, out float cos);
                const float level = (float)(1f * (float)(1f * 1f));
                matrix[channel, RingSpeaker[low]] = (float)(matrix[channel, RingSpeaker[low]] + (float)((float)(cos * RingWeight[low]) * level));
                matrix[channel, RingSpeaker[high]] = (float)(matrix[channel, RingSpeaker[high]] + (float)((float)(sin * RingWeight[high]) * level));
            }
            return matrix;
        }

        private Dictionary<int, float> VoiceSends(CriAtomAcbData.WaveEvent wave)
        {
            var result = new Dictionary<int, float>();
            foreach (var layer in wave.Layers)
                foreach (var send in layer.BusSends)
                    if (mixer.TryGetBus(send.Name, out int bus))
                        result[bus] = result.TryGetValue(bus, out float previous) ? (float)(previous * send.Level) : send.Level;
            if (!result.ContainsKey(0)) result.Add(0, 1f);
            return result;
        }
    }
}

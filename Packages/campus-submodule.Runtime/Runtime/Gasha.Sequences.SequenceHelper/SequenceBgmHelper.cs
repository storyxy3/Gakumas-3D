namespace Gasha.Sequences.SequenceHelper
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::Gasha.Sequences.SequenceHelper;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Timeline;

    public class SequenceBgmHelper
    {
        [Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec
        {
            public static readonly _003C_003Ec _003C_003E9;
            public static Func<IMarker, bool> _003C_003E9__0_0;
            public _003C_003Ec()
            {
            }

            internal bool _003CSwitchBgm_003Eb__0_0(IMarker x)
            {
                return default(bool);
            }
        }

        public static void SwitchBgm(PlayableDirector director, string pickupBgmAssetName, long pickupBgmStartTimeMs, string envBgmAssetName, long envBgmStartTimeMs)
        {
        }
    }
}

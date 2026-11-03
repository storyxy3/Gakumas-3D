namespace Campus.Common
{
    using global::System.Collections.Generic;
    using global::Campus.Common;

    public static class SoundEnum
    {
        public enum SoundEffectType
        {
            None,
            TapCommon,
            TapForward,
            TapBack,
            Swipe,
            DialogOpen,
            DialogClose,
            TapTitle,
            MapFlick,
            TapExecute,
            TapCancel,
            TapSelect,
            TapDisabled,
            TapCheck,
            TapTab
        }

        public enum SoundVolumeType
        {
            Bgm,
            Se,
            Voice
        }

        public static readonly Dictionary<SoundEffectType, string> SoundEffectAssetNames;
    }
}

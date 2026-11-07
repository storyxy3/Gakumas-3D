namespace Titan
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::UnityEngine.Playables;

    [Serializable]
    public class TitanControlClipBehaviour : PlayableBehaviour
    {
        [CompilerGenerated]
        private float _003CStart_003Ek__BackingField;
        [CompilerGenerated]
        private float _003CDuration_003Ek__BackingField;
        public float Start
        {
            [CompilerGenerated]
            get
            {
                return _003CStart_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CStart_003Ek__BackingField = value;
            }
        }

        public float Duration
        {
            [CompilerGenerated]
            get
            {
                return _003CDuration_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CDuration_003Ek__BackingField = value;
            }
        }

        public TitanControlClipBehaviour()
        {
        }
    }
}

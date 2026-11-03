namespace Titan
{
    using global::System;
    using global::Titan;
    using global::UnityEngine;
    using global::UnityEngine.Playables;

    [Serializable]
    public class TrackGroupVariableValue : IVariableValue, ICloneable
    {
        [SerializeField]
        private string _name;
        [SerializeField]
        private PlayableAsset _parent;
        public object GetValue(IValueResolver resolver)
        {
            return null;
        }

        public object Clone()
        {
            return null;
        }

        public TrackGroupVariableValue()
        {
        }
    }
}

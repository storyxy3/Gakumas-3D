namespace Titan
{
    using global::Titan;
    using global::UnityEngine;

    public class TextMeshProCharClipBase<TValue, TParameter> : TweenerClipBase<TValue, TParameter> where TParameter : ParameterBase<TValue>, new()
    {
        [SerializeField]
        private float _delayTime;
        [SerializeField]
        private float _charDuration;
        public float DelayTime
        {
            get
            {
                return default(float);
            }

            internal set
            {
            }
        }

        public float CharDuration
        {
            get
            {
                return default(float);
            }

            internal set
            {
            }
        }

        public override bool IsFixedDuration
        {
            get
            {
                return default(bool);
            }
        }

        public TextMeshProCharClipBase()
        {
        }
    }
}

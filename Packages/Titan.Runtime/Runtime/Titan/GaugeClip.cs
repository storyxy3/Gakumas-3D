namespace Titan
{
    using global::Titan;
    using global::UnityEngine;
    using global::UnityEngine.Playables;

    public class GaugeClip : TweenerClipBase<float, FloatParameter>
    {
        [SerializeField]
        private ExposedReference<PlayableDirector> _playableDirector;
        public TweenCreationContext GetFullGaugeTweenCreationContext(IExposedPropertyTable resolver)
        {
            return null;
        }

        public PlayableDirector GetFullGaugeTweenPlayableDirector(IExposedPropertyTable resolver)
        {
            return null;
        }

        public GaugeClip()
        {
        }
    }
}

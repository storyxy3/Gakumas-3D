namespace Campus.Titan
{
    using global::System.ComponentModel;
    using global::Campus.Titan;
    using global::DG.Tweening;
    using global::Titan;
    using global::UnityEngine;
    using global::UnityEngine.Timeline;

    [TitanTrackBindingType(typeof(CanvasGroup))]
    [TrackClipType(typeof(CampusCanvasGroupAlphaClip))]
    [DisplayName("Titan/CanvasGroup/Alpha(Campus用)")]
    public class CampusCanvasGroupAlphaTrack : FloatTweenerTrackBase<CampusCanvasGroupAlphaClip, CanvasGroup>
    {
        [SerializeField]
        private bool _enableBlocksRaycasts;
        protected override float DefaultInitialValue
        {
            get
            {
                return default(float);
            }
        }

        protected override Tween GetTween(CanvasGroup component, float endValue, CampusCanvasGroupAlphaClip clipAsset, float duration)
        {
            return null;
        }

        private void SetBlocksRaycasts(SetBlocksRaycastsType type, CanvasGroup component, Tween tween, bool value)
        {
        }

        protected override void SetInitialValue(TweenCreationContext context, CanvasGroup component)
        {
        }

        protected override float GetValue(CanvasGroup component)
        {
            return default(float);
        }

        protected override void SetValue(float value, CanvasGroup component)
        {
        }

        public CampusCanvasGroupAlphaTrack()
        {
        }
    }
}

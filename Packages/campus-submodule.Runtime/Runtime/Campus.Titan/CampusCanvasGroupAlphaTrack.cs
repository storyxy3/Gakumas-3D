namespace Campus.Titan
{
    using global::System.ComponentModel;
    using global::System.Runtime.CompilerServices;
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
        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass4_0
        {
            public CanvasGroup component;
            public bool value;
            public _003C_003Ec__DisplayClass4_0()
            {
            }

            internal void _003CSetBlocksRaycasts_003Eb__0()
            {
            }

            internal void _003CSetBlocksRaycasts_003Eb__1()
            {
            }

            internal void _003CSetBlocksRaycasts_003Eb__2()
            {
            }

            internal void _003CSetBlocksRaycasts_003Eb__3()
            {
            }
        }

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

namespace Titan
{
    using global::DG.Tweening;
    using global::Titan;

    public class CustomTweenClip : LoopableTweenClip
    {
        public Tween GetClipTween(IValueResolver resolver)
        {
            return null;
        }

        public CustomTweenClip()
        {
        }
    }
}

namespace Campus.Common.Extensions
{
    using global::DG.Tweening;
    using global::DG.Tweening.Core;

    public static class SequenceExtensions
    {
        private static readonly DOGetter<float> EmptyGetter;
        private static readonly DOSetter<float> EmptySetter;
        public static Sequence AppendCallbackTween(this Sequence seq, TweenCallback callback)
        {
            return null;
        }

        public static Sequence InsertCallbackTween(this Sequence seq, float atPosition, TweenCallback callback)
        {
            return null;
        }

        public static Sequence InsertForwardCallbackTween(this Sequence seq, float atPosition, TweenCallback callback)
        {
            return null;
        }

        private static Tween CallbackTween(TweenCallback callback)
        {
            return null;
        }

        private static Tween ForwardCallbackTween(TweenCallback callback)
        {
            return null;
        }

        private static void InvokeIfNeeded(bool canInvoke, TweenCallback callback)
        {
        }
    }
}

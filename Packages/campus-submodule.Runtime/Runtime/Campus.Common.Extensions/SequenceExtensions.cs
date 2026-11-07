namespace Campus.Common.Extensions
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::Campus.Common.Extensions;
    using global::DG.Tweening;
    using global::DG.Tweening.Core;
    using global::DG.Tweening.Plugins.Options;

    public static class SequenceExtensions
    {
        [Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec
        {
            public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();
            public _003C_003Ec()
            {
            }

            internal float _003C_002Ecctor_003Eb__12_0()
            {
                return default(float);
            }

            internal void _003C_002Ecctor_003Eb__12_1(float _)
            {
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass9_0
        {
            public TweenerCore<float, float, FloatOptions> tween;
            public TweenCallback callback;
            public _003C_003Ec__DisplayClass9_0()
            {
            }

            internal void _003CForwardCallbackTween_003Eb__0()
            {
            }
        }

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

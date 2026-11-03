namespace Titan
{
    using global::System;
    using global::Titan;

    public abstract class TweenerClipBase : LoopableTweenClip
    {
        public abstract Type ParameterType { get; }

        protected TweenerClipBase()
        {
        }
    }
}

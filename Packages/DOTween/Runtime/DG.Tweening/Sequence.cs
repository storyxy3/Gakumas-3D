namespace DG.Tweening
{
    using global::System.Collections.Generic;
    using global::DG.Tweening;
    using global::DG.Tweening.Core;
    using global::DG.Tweening.Core.Enums;

    public sealed class Sequence : Tween
    {
        internal readonly List<Tween> sequencedTweens;
        private readonly List<ABSSequentiable> _sequencedObjs;
        internal float lastTweenInsertTime;
        internal Sequence()
        {
        }

        internal static Sequence DoInsert(Sequence inSequence, Tween t, float atPosition)
        {
            return null;
        }

        internal static Sequence DoAppendInterval(Sequence inSequence, float interval)
        {
            return null;
        }

        internal static Sequence DoPrependInterval(Sequence inSequence, float interval)
        {
            return null;
        }

        internal static Sequence DoInsertCallback(Sequence inSequence, TweenCallback callback, float atPosition)
        {
            return null;
        }

        internal override float UpdateDelay(float elapsed)
        {
            return default(float);
        }

        internal override void Reset()
        {
        }

        internal override bool Startup()
        {
            return default(bool);
        }

        internal override bool ApplyTween(float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, UpdateMode updateMode, UpdateNotice updateNotice)
        {
            return default(bool);
        }

        internal static void Setup(Sequence s)
        {
        }

        internal static bool DoStartup(Sequence s)
        {
            return default(bool);
        }

        internal static bool DoApplyTween(Sequence s, float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, UpdateMode updateMode)
        {
            return default(bool);
        }

        private static bool ApplyInternalCycle(Sequence s, float fromPos, float toPos, UpdateMode updateMode, bool useInverse, bool prevPosIsInverse, bool multiCycleStep = false)
        {
            return default(bool);
        }

        private static void StableSortSequencedObjs(List<ABSSequentiable> list)
        {
        }

        private static bool IsAnyCallbackSet(Sequence s)
        {
            return default(bool);
        }
    }
}

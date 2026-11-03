namespace Titan
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::DG.Tweening;
    using global::DG.Tweening.Core;
    using global::Titan;
    using global::UnityEngine;
    using global::UnityEngine.Playables;

    public class TweenCreationContext : IDisposable, ITimelineTween, ICollectValueRevertersContext
    {
        public const float CallbackTweenDelta = 0.0001f;
        private static readonly IReadOnlyList<TweenWithDelay> EmptyInfiniteTweens;
        private static readonly DOGetter<float> ZeroGetter;
        private static readonly DOSetter<float> EmptySetter;
        [CompilerGenerated]
        private Sequence _003CSequence_003Ek__BackingField;
        [CompilerGenerated]
        private PlayableDirector _003CDirector_003Ek__BackingField;
        [CompilerGenerated]
        private IValueResolver _003CValueResolver_003Ek__BackingField;
        [CompilerGenerated]
        private List<CallbackEntry> _003CCallbackEntries_003Ek__BackingField;
        [CompilerGenerated]
        private List<TweenWithDelay> _003CInfiniteTweens_003Ek__BackingField;
        private bool _containsInfinite;
        [CompilerGenerated]
        private bool _003CIgnoreInitialValue_003Ek__BackingField;
        [CompilerGenerated]
        private readonly bool _003CIsTimeline_003Ek__BackingField;
        [CompilerGenerated]
        private float _003CPositionOffset_003Ek__BackingField;
        [CompilerGenerated]
        private bool _003CIsRoot_003Ek__BackingField;
        [CompilerGenerated]
        private float _003CDuration_003Ek__BackingField;
        [CompilerGenerated]
        private TweenCreationContext _003CRoot_003Ek__BackingField;
        private List<IValueReverter> _valueReverters;
        public Sequence Sequence
        {
            [CompilerGenerated]
            get
            {
                return null;
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        Tween Titan.ITimelineTween.Main
        {
            get
            {
                return null;
            }
        }

        public PlayableDirector Director
        {
            [CompilerGenerated]
            get
            {
                return null;
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public IValueResolver ValueResolver
        {
            [CompilerGenerated]
            get
            {
                return null;
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public List<CallbackEntry> CallbackEntries
        {
            [CompilerGenerated]
            get
            {
                return null;
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public List<TweenWithDelay> InfiniteTweens
        {
            [CompilerGenerated]
            get
            {
                return null;
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        IReadOnlyList<TweenWithDelay> Titan.ITimelineTween.InfiniteTweens
        {
            get
            {
                return null;
            }
        }

        public bool IgnoreInitialValue
        {
            [CompilerGenerated]
            get
            {
                return default(bool);
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public bool IsTimeline
        {
            [CompilerGenerated]
            get
            {
                return default(bool);
            }
        }

        internal float PositionOffset
        {
            [CompilerGenerated]
            get
            {
                return default(float);
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public bool IsRoot
        {
            [CompilerGenerated]
            get
            {
                return default(bool);
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public float Duration
        {
            [CompilerGenerated]
            get
            {
                return default(float);
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public TweenCreationContext Root
        {
            [CompilerGenerated]
            get
            {
                return null;
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public bool IsRevertEnabled
        {
            get
            {
                return default(bool);
            }
        }

        private TweenCreationContext(PlayableDirector director, bool isTimeline)
        {
        }

        public static TweenCreationContext Create(PlayableDirector director, bool isTimeline, bool ignoreInitialValue = false)
        {
            return null;
        }

        public TweenCreationContext CreateChild(PlayableDirector director, bool ignoreInitialValue = false)
        {
            return null;
        }

        private void UpdateDuration(float time)
        {
        }

        public void Insert(float position, Tween tween)
        {
        }

        public void InsertCallback(float position, TweenCallback callback, MarkerExecutionType executionType, CallbackTiming timing)
        {
        }

        private void InsertInfiniteTween(float position, Tween tween, LoopType loopType, GameObject gameObject)
        {
        }

        public void InsertChild(float position, TweenCreationContext child)
        {
        }

        public void SetTimeScale(float timeScale)
        {
        }

        private static bool TrySetLoopOffset(Tween tween, float duration, ref int loopCount, ref LoopType loopType, float loopOffset, GameObject gameObject, out Tween result, out float resultDuration)
        {
            throw null;
        }

        public void SetLoopAndInsert(float position, TweenCreationContext childContext, ITweenLoopInfo loopInfo)
        {
        }

        public void SetLoopAndInsert(float position, Tween tween, ITweenLoopInfo loopInfo)
        {
        }

        public void Revert()
        {
        }

        void Titan.ICollectValueRevertersContext.Add(IValueReverter reverter)
        {
        }

        public void SetGroup(string groupName)
        {
        }

        public void Dispose()
        {
        }
    }
}

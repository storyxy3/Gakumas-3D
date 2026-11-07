namespace Titan
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::DG.Tweening;
    using global::DG.Tweening.Core;
    using global::DG.Tweening.Plugins.Options;
    using global::Titan;
    using global::UnityEngine;
    using global::UnityEngine.Playables;

    public class TweenCreationContext : IDisposable, ITimelineTween, ICollectValueRevertersContext
    {
        [Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec
        {
            public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();
            public static DOGetter<float> _003C_003E9__63_0;
            public static DOGetter<float> _003C_003E9__64_2;
            public static DOGetter<float> _003C_003E9__64_0;
            public _003C_003Ec()
            {
            }

            internal float _003CSetTimeScale_003Eb__63_0()
            {
                return default(float);
            }

            internal float _003CTrySetLoopOffset_003Eb__64_2()
            {
                return default(float);
            }

            internal float _003CTrySetLoopOffset_003Eb__64_0()
            {
                return default(float);
            }

            internal float _003C_002Ecctor_003Eb__71_0()
            {
                return default(float);
            }

            internal void _003C_002Ecctor_003Eb__71_1(float _)
            {
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass60_0
        {
            public MarkerExecutionType executionType;
            public CallbackTiming timing;
            public TweenCallback callback;
            public TweenerCore<float, float, FloatOptions> tween;
            public float prevTime;
            public _003C_003Ec__DisplayClass60_0()
            {
            }

            internal void _003CInsertCallback_003Eb__0()
            {
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass61_0
        {
            public Tween tween;
            public _003C_003Ec__DisplayClass61_0()
            {
            }

            internal void _003CInsertInfiniteTween_003Eb__0()
            {
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass63_0
        {
            public Sequence tween;
            public _003C_003Ec__DisplayClass63_0()
            {
            }

            internal void _003CSetTimeScale_003Eb__1(float x)
            {
            }

            internal void _003CSetTimeScale_003Eb__2()
            {
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass64_0
        {
            public float loopOffset;
            public Tween tween;
            public float targetDuration;
            public _003C_003Ec__DisplayClass64_0()
            {
            }

            internal void _003CTrySetLoopOffset_003Eb__1(float x)
            {
            }

            internal void _003CTrySetLoopOffset_003Eb__4()
            {
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass64_1
        {
            public float duration2;
            public _003C_003Ec__DisplayClass64_0 CS_0024_003C_003E8__locals1;
            public _003C_003Ec__DisplayClass64_1()
            {
            }

            internal void _003CTrySetLoopOffset_003Eb__3(float x)
            {
            }
        }

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
                return _003CSequence_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CSequence_003Ek__BackingField = value;
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
                return _003CDirector_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CDirector_003Ek__BackingField = value;
            }
        }

        public IValueResolver ValueResolver
        {
            [CompilerGenerated]
            get
            {
                return _003CValueResolver_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CValueResolver_003Ek__BackingField = value;
            }
        }

        public List<CallbackEntry> CallbackEntries
        {
            [CompilerGenerated]
            get
            {
                return _003CCallbackEntries_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CCallbackEntries_003Ek__BackingField = value;
            }
        }

        public List<TweenWithDelay> InfiniteTweens
        {
            [CompilerGenerated]
            get
            {
                return _003CInfiniteTweens_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CInfiniteTweens_003Ek__BackingField = value;
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
                return _003CIgnoreInitialValue_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CIgnoreInitialValue_003Ek__BackingField = value;
            }
        }

        public bool IsTimeline
        {
            [CompilerGenerated]
            get
            {
                return _003CIsTimeline_003Ek__BackingField;
            }
        }

        internal float PositionOffset
        {
            [CompilerGenerated]
            get
            {
                return _003CPositionOffset_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CPositionOffset_003Ek__BackingField = value;
            }
        }

        public bool IsRoot
        {
            [CompilerGenerated]
            get
            {
                return _003CIsRoot_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CIsRoot_003Ek__BackingField = value;
            }
        }

        public float Duration
        {
            [CompilerGenerated]
            get
            {
                return _003CDuration_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CDuration_003Ek__BackingField = value;
            }
        }

        public TweenCreationContext Root
        {
            [CompilerGenerated]
            get
            {
                return _003CRoot_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CRoot_003Ek__BackingField = value;
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

namespace Cysharp.Threading.Tasks
{
    using global::System;
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.Internal;
    using global::UnityEngine;
    using global::UnityEngine.LowLevel;

    public static class PlayerLoopHelper
    {
        private static readonly ContinuationQueue ThrowMarkerContinuationQueue;
        private static readonly PlayerLoopRunner ThrowMarkerPlayerLoopRunner;
        private static int mainThreadId;
        private static string applicationDataPath;
        private static SynchronizationContext unitySynchronizationContext;
        private static ContinuationQueue[] yielders;
        private static PlayerLoopRunner[] runners;
        public static SynchronizationContext UnitySynchronizationContext
        {
            get
            {
                return null;
            }
        }

        public static int MainThreadId
        {
            get
            {
                return default(int);
            }
        }

        public static bool IsMainThread
        {
            get
            {
                return default(bool);
            }
        }

        private static PlayerLoopSystem[] InsertRunner(PlayerLoopSystem loopSystem, bool injectOnFirst, Type loopRunnerYieldType, ContinuationQueue cq, Type loopRunnerType, PlayerLoopRunner runner)
        {
            return null;
        }

        private static PlayerLoopSystem[] RemoveRunner(PlayerLoopSystem loopSystem, Type loopRunnerYieldType, Type loopRunnerType)
        {
            return null;
        }

        private static PlayerLoopSystem[] InsertUniTaskSynchronizationContext(PlayerLoopSystem loopSystem)
        {
            return null;
        }

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
        private static void Init()
        {
        }

        private static int FindLoopSystemIndex(PlayerLoopSystem[] playerLoopList, Type systemType)
        {
            return default(int);
        }

        private static void InsertLoop(PlayerLoopSystem[] copyList, InjectPlayerLoopTimings injectTimings, Type loopType, InjectPlayerLoopTimings targetTimings, int index, bool injectOnFirst, Type loopRunnerYieldType, Type loopRunnerType, PlayerLoopTiming playerLoopTiming)
        {
        }

        public static void Initialize(ref PlayerLoopSystem playerLoop, InjectPlayerLoopTimings injectTimings = InjectPlayerLoopTimings.All)
        {
        }

        public static void AddAction(PlayerLoopTiming timing, IPlayerLoopItem action)
        {
        }

        private static void ThrowInvalidLoopTiming(PlayerLoopTiming playerLoopTiming)
        {
        }

        public static void AddContinuation(PlayerLoopTiming timing, Action continuation)
        {
        }
    }
}

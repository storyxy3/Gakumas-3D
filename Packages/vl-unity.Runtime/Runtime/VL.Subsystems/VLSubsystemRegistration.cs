namespace VL.Subsystems
{
    using global::System;
    using global::UnityEngine;
    using global::UnityEngine.LowLevel;

    public class VLSubsystemRegistration
    {
        private struct VLLastLateUpdate
        {
        }

        private struct VLBeforeRendering
        {
        }

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        private static void Initialize()
        {
        }

        private static void InsertSystem(PlayerLoopSystem[] copyList, Type injectType, Type loopType, PlayerLoopSystem target)
        {
        }

        private static int FindLoopSystemIndex(PlayerLoopSystem[] subSystems, Type systemType)
        {
            return default(int);
        }
    }
}

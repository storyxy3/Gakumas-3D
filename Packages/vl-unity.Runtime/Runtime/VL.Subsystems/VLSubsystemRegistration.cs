namespace VL.Subsystems
{
    using global::System;
    using global::System.Runtime.CompilerServices;
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

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass3_0
        {
            public PlayerLoopSystem target;
            public _003C_003Ec__DisplayClass3_0()
            {
            }

            internal bool _003CInsertSystem_003Eb__0(PlayerLoopSystem ls)
            {
                return default(bool);
            }
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

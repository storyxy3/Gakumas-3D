namespace VL.Subsystems
{
    using global::System;
    using global::System.Linq;
    using global::UnityEngine.Rendering;
    using global::UnityEngine.PlayerLoop;
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
                return ls.type != target.type;
            }
        }

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        private static void Initialize()
        {
            RenderPipelineManager.beginContextRendering -= VLSubsystem.OnBeginContextRendering;
            RenderPipelineManager.beginContextRendering += VLSubsystem.OnBeginContextRendering;
            var loop = PlayerLoop.GetCurrentPlayerLoop();
            var copy = loop.subSystemList.ToArray();
            var lastLateUpdate = new PlayerLoopSystem { subSystemList = null, updateDelegate = VLSubsystem.LastLateUpdate, type = typeof(VLLastLateUpdate) };
            var beforeRendering = new PlayerLoopSystem { subSystemList = null, updateDelegate = VLSubsystem.BeforeRendering, type = typeof(VLBeforeRendering) };
            InsertSystem(copy, typeof(PostLateUpdate.DirectorLateUpdate), typeof(PostLateUpdate), lastLateUpdate);
            InsertSystem(copy, typeof(PostLateUpdate.FinishFrameRendering), typeof(PostLateUpdate), beforeRendering);
            loop.subSystemList = copy;
            PlayerLoop.SetPlayerLoop(loop);
        }

        private static void InsertSystem(PlayerLoopSystem[] copyList, Type injectType, Type loopType, PlayerLoopSystem target)
        {
            var closure = new _003C_003Ec__DisplayClass3_0 { target = target };
            int loopIndex = FindLoopSystemIndex(copyList, loopType);
            var source = copyList[loopIndex].subSystemList.Where(closure._003CInsertSystem_003Eb__0).ToArray();
            var result = new PlayerLoopSystem[source.Length + 1];
            int sourceIndex = source.Length - 1;
            for (int i = result.Length - 1; i >= 0; i--)
            {
                if (sourceIndex < 0) throw new Exception("Target PlayerLoopSystem does not found. Type:" + injectType.ToString());
                var system = source[sourceIndex--];
                result[i] = system;
                if (system.type == injectType) result[--i] = closure.target;
            }
            copyList[loopIndex].subSystemList = result;
        }

        private static int FindLoopSystemIndex(PlayerLoopSystem[] subSystems, Type systemType)
        {
            for (int i = 0; i < subSystems.Length; i++)
                if (subSystems[i].type == systemType) return i;
            throw new Exception("Target PlayerLoopSystem does not found. Type:" + systemType.ToString());
        }
    }
}

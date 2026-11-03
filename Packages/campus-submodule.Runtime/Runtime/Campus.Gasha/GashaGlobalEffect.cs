namespace Campus.Gasha
{
    using global::System;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::Campus.Common;
    using global::Campus.Gasha;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;
    using global::Gasha.Sequences;
    using global::JetBrains.Annotations;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;
    using global::UnityEngine.UI;

    public class GashaGlobalEffect : MonoBehaviour
    {
        [Serializable]
        public class ParticleId
        {
            public string id;
            [CanBeNull]
            public ParticleSystem particle;
            public ParticleId()
            {
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CPlayFreeze_003Ed__19 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public GashaGlobalEffect _003C_003E4__this;
            private UniTask.Awaiter _003C_003Eu__1;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CSetUp_003Ed__12 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public GashaGlobalEffect _003C_003E4__this;
            public CancellationToken ct;
            private UniTask<(bool isSuccess, ICampusActorController controller)>.Awaiter _003C_003Eu__1;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        public ParticleId[] particles;
        public GashaGlobalEffectTitanHandler[] titanHandlers;
        public GashaFreezeEffect freezeEffect;
        [NonSerialized]
        [CanBeNull]
        public ICampusActorController actorController;
        public RawImage capturedImage;
        private RTHandle capturedHandle;
        private CampusButton _skipButton;
        public Vector3 actorPosition;
        public GashaFadeOutHandler fadeOutHandler;
        private GashaGlobalEffectBindParam _param;
        public void Bind(GashaGlobalEffectBindParam bindParam)
        {
        }

        [AsyncStateMachine(typeof(_003CSetUp_003Ed__12))]
        public UniTask SetUp([Optional] CancellationToken ct)
        {
            return default(UniTask);
        }

        public void PlayParticle(string particleId)
        {
        }

        public void StopParticle(string effectId)
        {
        }

        public void PauseParticles()
        {
        }

        public void ResumeParticles()
        {
        }

        public void StopBgm()
        {
        }

        public void PlaySE(string assetName, CancellationToken ct)
        {
        }

        [AsyncStateMachine(typeof(_003CPlayFreeze_003Ed__19))]
        public UniTask PlayFreeze()
        {
            return default(UniTask);
        }

        public void Show3DModel()
        {
        }

        public void Hide3DModel()
        {
        }

        public void ShowSkipButton()
        {
        }

        public void HideSkipButton()
        {
        }

        public void PlayTitan(string handlerName)
        {
        }

        public void FadeOut(AnimationCurve inCurve, float inDuration, AnimationCurve outCurve, float outDuration)
        {
        }

        public void CaptureRequest()
        {
        }

        public void SetActiveCaptureImage(bool active)
        {
        }

        private void OnDestroy()
        {
        }

        public GashaGlobalEffect()
        {
        }
    }
}

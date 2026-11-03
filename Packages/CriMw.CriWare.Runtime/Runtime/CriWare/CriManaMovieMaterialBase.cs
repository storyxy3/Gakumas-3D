namespace CriWare
{
    using global::System;
    using global::System.Collections;
    using global::System.Collections.Generic;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::CriWare;
    using global::CriWare.CriMana;
    using global::UnityEngine;

    public abstract class CriManaMovieMaterialBase : CriMonoBehaviour
    {
        public enum MaxFrameDrop
        {
            Disabled,
            One,
            Two,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten
        }

        public enum RenderMode
        {
            Always,
            OnVisibility,
            Never
        }

        public delegate void OnApplicationPauseCallback(CriManaMovieMaterialBase manaMovieMaterial, bool appPause);
        [CompilerGenerated]
        private sealed class _003CRestartPlayerRoutine_003Ed__60 : IEnumerator<object>, IEnumerator, IDisposable
        {
            private int _003C_003E1__state;
            private object _003C_003E2__current;
            public CriManaMovieMaterialBase _003C_003E4__this;
            object System.Collections.Generic.IEnumerator<System.Object>.Current
            {
                [DebuggerHidden]
                get
                {
                    return null;
                }
            }

            object System.Collections.IEnumerator.Current
            {
                [DebuggerHidden]
                get
                {
                    return null;
                }
            }

            [DebuggerHidden]
            public _003CRestartPlayerRoutine_003Ed__60(int _003C_003E1__state)
            {
            }

            [DebuggerHidden]
            void System.IDisposable.Dispose()
            {
            }

            bool global::System.Collections.IEnumerator.MoveNext()
            {
                return default(bool);
            }

            [DebuggerHidden]
            void System.Collections.IEnumerator.Reset()
            {
            }
        }

        public bool playOnStart;
        public bool restartOnEnable;
        [CompilerGenerated]
        private bool _003CisMaterialAvailable_003Ek__BackingField;
        [CompilerGenerated]
        private Player _003Cplayer_003Ek__BackingField;
        public RenderMode renderMode;
        public OnApplicationPauseCallback onApplicationPauseCallback;
        private Player.TimerType _timerType;
        [SerializeField]
        private Material _material;
        [SerializeField]
        private MaxFrameDrop _maxFrameDrop;
        private bool materialOwn;
        protected bool isMonoBehaviourStartCalled;
        private bool wasDisabled;
        private bool wasPausedOnDisable;
        private bool previousOnApplicationPauseStatus;
        private WaitForEndOfFrame frameEnd;
        private bool unpauseOnApplicationUnpause;
        [CompilerGenerated]
        private bool _003CHaveRendererOwner_003Ek__BackingField;
        private CriManaMoviePlayerHolder playerHolder;
        public MaxFrameDrop maxFrameDrop
        {
            get
            {
                return default(MaxFrameDrop);
            }

            set
            {
            }
        }

        protected abstract bool initializeWithAdvancedAudio { get; }
        protected abstract bool initializeWithAmbisonics { get; }

        public bool isMaterialAvailable
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

        public Player player
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

        public Material material
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public Player.TimerType timerType
        {
            get
            {
                return default(Player.TimerType);
            }

            set
            {
            }
        }

        protected abstract uint FilePathLength { get; }

        protected bool HaveRendererOwner
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

        private void DestroyOwnMaterial()
        {
        }

        protected abstract void SetDataToPlayer();
        public void Play()
        {
        }

        public void Stop()
        {
        }

        public void Pause(bool sw)
        {
        }

        protected virtual void OnMaterialAvailableChanged()
        {
        }

        protected virtual void OnMaterialUpdated()
        {
        }

        public void PlayerManualInitialize()
        {
        }

        public void PlayerManualFinalize()
        {
        }

        public void PlayerManualSetup()
        {
        }

        public virtual bool RenderTargetManualSetup()
        {
            return default(bool);
        }

        public virtual void RenderTargetManualFinalize()
        {
        }

        public void PlayerManualUpdate()
        {
        }

        protected virtual void Awake()
        {
        }

        protected override void OnEnable()
        {
        }

        [IteratorStateMachine(typeof(_003CRestartPlayerRoutine_003Ed__60))]
        private IEnumerator RestartPlayerRoutine()
        {
            return null;
        }

        protected override void OnDisable()
        {
        }

        protected virtual void OnDestroy()
        {
        }

        protected virtual void Start()
        {
        }

        public override void CriInternalUpdate()
        {
        }

        public virtual void RenderMovie()
        {
        }

        public override void CriInternalLateUpdate()
        {
        }

        protected virtual void OnWillRenderObject()
        {
        }

        private void OnApplicationPause(bool appPause)
        {
        }

        private void ProcessApplicationPause(bool appPause)
        {
        }

        private void CreateMaterial()
        {
        }

        protected CriManaMovieMaterialBase()
        {
        }
    }
}

namespace Campus.Common
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::System.Threading;
    using global::Campus.Common;
    using global::Cysharp.Threading.Tasks;

    public class CampusLoadAsyncSceneParam : CampusLoadSceneParam
    {
        [CompilerGenerated]
        private bool _003CAllowSceneActivation_003Ek__BackingField;
        [CompilerGenerated]
        private Func<CancellationToken, UniTask> _003COnPrepareSceneTask_003Ek__BackingField;
        [CompilerGenerated]
        private Func<CancellationToken, UniTask> _003COnActivationTask_003Ek__BackingField;
        [CompilerGenerated]
        private Action _003COnActivationAction_003Ek__BackingField;
        public bool AllowSceneActivation
        {
            [CompilerGenerated]
            get
            {
                return _003CAllowSceneActivation_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CAllowSceneActivation_003Ek__BackingField = value;
            }
        }

        public Func<CancellationToken, UniTask> OnPrepareSceneTask
        {
            [CompilerGenerated]
            get
            {
                return _003COnPrepareSceneTask_003Ek__BackingField;
            }
        }

        public Func<CancellationToken, UniTask> OnActivationTask
        {
            [CompilerGenerated]
            get
            {
                return _003COnActivationTask_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003COnActivationTask_003Ek__BackingField = value;
            }
        }

        public Action OnActivationAction
        {
            [CompilerGenerated]
            get
            {
                return _003COnActivationAction_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003COnActivationAction_003Ek__BackingField = value;
            }
        }

        // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
        public CampusLoadAsyncSceneParam(string sceneName) : base(default(string))
        {
        }

        // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
        public CampusLoadAsyncSceneParam(int sceneBuildIndex) : base(default(int))
        {
        }
    }
}

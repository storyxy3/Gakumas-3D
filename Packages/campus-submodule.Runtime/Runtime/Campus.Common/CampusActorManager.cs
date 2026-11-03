namespace Campus.Common
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::Campus.Common;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;
    using global::VL;

    public class CampusActorManager : VLDefaultActorManager<CampusActorManager, CampusActorController, ICampusActorController, CampusActorModelParts, CampusActorDescriptor, ICampusActorDescriptor>
    {
        private sealed class ActorInfo
        {
            [CompilerGenerated]
            private readonly CampusActorDescriptor _003CDescriptor_003Ek__BackingField;
            [CompilerGenerated]
            private readonly int _003CIndex_003Ek__BackingField;
            [CompilerGenerated]
            private bool _003CIsGenerating_003Ek__BackingField;
            [CompilerGenerated]
            private bool _003CIsSuccess_003Ek__BackingField;
            public CampusActorDescriptor Descriptor
            {
                [CompilerGenerated]
                get
                {
                    return null;
                }
            }

            public int Index
            {
                [CompilerGenerated]
                get
                {
                    return default(int);
                }
            }

            public bool IsGenerating
            {
                [CompilerGenerated]
                get
                {
                    return default(bool);
                }

                [CompilerGenerated]
                set
                {
                }
            }

            public bool IsSuccess
            {
                [CompilerGenerated]
                get
                {
                    return default(bool);
                }

                [CompilerGenerated]
                set
                {
                }
            }

            public ActorInfo(CampusActorDescriptor descriptor, int index)
            {
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass19_0
        {
            public ActorInfo actorInfo;
            public _003C_003Ec__DisplayClass19_0()
            {
            }

            internal bool _003CUpdateCacheActorAsync_003Eb__0()
            {
                return default(bool);
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CSafeUpdateActorAsync_003Ed__20 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder<(bool isSuccess, ICampusActorController controller)> _003C_003Et__builder;
            public ActorInfo actorInfo;
            public CampusActorManager _003C_003E4__this;
            public int index;
            public CampusActorDescriptor descriptor;
            public CancellationToken ct;
            private bool _003CisSuccess_003E5__2;
            private UniTask<(bool isSuccess, ICampusActorController controller)>.Awaiter _003C_003Eu__1;
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
        private struct _003CUpdateActorAsync_003Ed__21 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder<(bool isSuccess, ICampusActorController controller)> _003C_003Et__builder;
            public CampusActorManager _003C_003E4__this;
            public int index;
            public CampusActorDescriptor descriptor;
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

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CUpdateCacheActorAsync_003Ed__19 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder<(bool isSuccess, ICampusActorController controller)> _003C_003Et__builder;
            public CampusActorManager _003C_003E4__this;
            public CampusActorDescriptor descriptor;
            public CancellationToken ct;
            private _003C_003Ec__DisplayClass19_0 _003C_003E8__1;
            private UniTask.Awaiter _003C_003Eu__1;
            private UniTask<(bool isSuccess, ICampusActorController controller)>.Awaiter _003C_003Eu__2;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        private bool _isInitialized;
        public const int MaxCacheCount = 6;
        private LRUCache<CampusActorDescriptor, ActorInfo> _actorIndexLRUCache;
        private int _actorIndex;
        private Stack<int> _reusableIndexes;
        private CampusActorModelKeeper _actorModelLoaders;
        public Action<ICampusActorController> onCreateActor;
        private Dictionary<string, string> _jointLimitAssetMap;
        [CompilerGenerated]
        private static Action m_onInitialize;
        public static event Action onInitialize
        {
            [CompilerGenerated]
            add
            {
            }

            [CompilerGenerated]
            remove
            {
            }
        }

        public void ClearCache()
        {
        }

        protected override void OnEnable()
        {
        }

        private void TryInitialize()
        {
        }

        private ActorInfo GetCacheActorInfo(CampusActorDescriptor descriptor)
        {
            return null;
        }

        public bool TryGetCached(CampusActorDescriptor descriptor, out ICampusActorController controller)
        {
            throw null;
        }

        public bool IsGenerating()
        {
            return default(bool);
        }

        public bool IsGenerating(int index)
        {
            return default(bool);
        }

        [AsyncStateMachine(typeof(_003CUpdateCacheActorAsync_003Ed__19))]
        public UniTask<(bool, ICampusActorController)> UpdateCacheActorAsync(CampusActorDescriptor descriptor, CancellationToken ct)
        {
            return default(UniTask<(bool, ICampusActorController)>);
        }

        [AsyncStateMachine(typeof(_003CSafeUpdateActorAsync_003Ed__20))]
        private UniTask<(bool, ICampusActorController)> SafeUpdateActorAsync(ActorInfo actorInfo, int index, CampusActorDescriptor descriptor, CancellationToken ct)
        {
            return default(UniTask<(bool, ICampusActorController)>);
        }

        [AsyncStateMachine(typeof(_003CUpdateActorAsync_003Ed__21))]
        public UniTask<(bool, ICampusActorController)> UpdateActorAsync(int index, CampusActorDescriptor descriptor, CancellationToken ct)
        {
            return default(UniTask<(bool, ICampusActorController)>);
        }

        public bool ExistActor(string uniqueId)
        {
            return default(bool);
        }

        public int GetActorIndex(string uniqueId)
        {
            return default(int);
        }

        public bool TryDestroyActor(string uniqueId)
        {
            return default(bool);
        }

        public int GetFreeActorIndex()
        {
            return default(int);
        }

        public void SetJointLimitAssetMap(Dictionary<string, string> value)
        {
        }

        public string GetJointLimitAsset(string characterId)
        {
            return null;
        }

        public CampusActorManager()
        {
        }
    }
}

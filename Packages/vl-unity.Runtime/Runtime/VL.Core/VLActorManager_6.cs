namespace VL.Core
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::UnityEngine;
    using global::UnityEngine.SceneManagement;
    using global::VL;
    using global::VL.Core;

    [ExecuteAlways]
    [DefaultExecutionOrder(1000)]
    public class VLActorManager<TManager, TController, TIController, TModelParts, TDescriptor, TIDescriptor> : VLMonoBehaviourSingleton<TManager> where TManager : MonoBehaviour where TController : VLActorController<TModelParts, TDescriptor, TIDescriptor>, TIController where TIController : class, IVLActorController<TIDescriptor> where TModelParts : VLActorModelParts<TDescriptor> where TDescriptor : VLActorDescriptor, TIDescriptor where TIDescriptor : IVLActorDescriptor
    {
        [Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec
        {
            public static readonly _003C_003Ec _003C_003E9;
            public static Comparison<TIController> _003C_003E9__16_0;
            public _003C_003Ec()
            {
            }

            internal int _003CGetActorList_003Eb__16_0(TIController x, TIController y)
            {
                return default(int);
            }
        }

        protected const int ORDER_START = 100;
        protected const int ORDER_INTERVAL = 10;
        [SerializeField]
        private List<int> _actorIndexes;
        [SerializeField]
        protected List<TController> _actorModels;
        [SerializeField]
        private VLActorSettings _settings;
        public VLActorSettings settings
        {
            get
            {
                return null;
            }
        }

        protected virtual void LateUpdate()
        {
        }

        protected void CheckActorList()
        {
        }

        protected TIController CreateActor(int actorIndex, [Optional] Scene scene)
        {
            return null;
        }

        protected virtual TController OnCreateActor(int actorIndex)
        {
            return null;
        }

        protected virtual void OnDestroyActor(TController controller)
        {
        }

        public void DestroyActor(int actorIndex)
        {
        }

        public void DestroyAllActor()
        {
        }

        public TIController GetActor(int actorIndex)
        {
            return null;
        }

        public bool ContainsActor(int actorIndex)
        {
            return default(bool);
        }

        public List<TIController> GetActorList()
        {
            return null;
        }

        public int GetActorCount()
        {
            return default(int);
        }

        public (bool, TIController) UpdateActor(int index, TDescriptor descriptor)
        {
            return default((bool, TIController));
        }

        public VLActorManager()
        {
        }
    }
}

namespace VL
{
    using global::System;
    using global::System.Collections.Generic;
    using global::UnityEngine;
    using global::VL;
    using global::VL.Core;

    public class VLDefaultActorManager<TManager, TController, TIController, TModelParts, TDescriptor, TIDescriptor> : VLActorManager<TManager, TController, TIController, TModelParts, TDescriptor, TIDescriptor> where TManager : MonoBehaviour where TController : VLDefaultActorController<TModelParts, TDescriptor, TIDescriptor>, TIController where TIController : class, IVLDefaultActorController<TIDescriptor>, IVLActorController<TIDescriptor> where TModelParts : VLActorModelParts<TDescriptor> where TDescriptor : VLDefaultActorDescriptor, TIDescriptor where TIDescriptor : IVLDefaultActorDescriptor
    {
        [SerializeField]
        [HideInInspector]
        protected List<TController> _actorDepthList;
        private Comparison<TController> _onSort;
        protected override TController OnCreateActor(int actorIndex)
        {
            return null;
        }

        protected override void OnDestroyActor(TController controller)
        {
        }

        private int SortActorDepth(TController a, TController b)
        {
            return default(int);
        }

        private void UpdateActorOrder()
        {
        }

        protected override void LateUpdate()
        {
        }

        public void SetActiveActorList(params int[] activeList)
        {
        }

        public void SetActiveAllActor(bool active)
        {
        }

        private bool CreateRaycastHit(RaycastHit hit, out VLActorRaycastHit actorHit)
        {
            throw null;
        }

        public bool Raycast(out VLActorRaycastHit actorHit, float distance)
        {
            throw null;
        }

        public int RaycastNonAlloc(RaycastHit[] hitBuffer, VLActorRaycastHit[] actorHitBuffer, float distance)
        {
            return default(int);
        }

        public int RaycastNonAlloc(Ray ray, RaycastHit[] hitBuffer, VLActorRaycastHit[] actorHitBuffer, float distance)
        {
            return default(int);
        }

        public VLDefaultActorManager()
        {
        }
    }
}

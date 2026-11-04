namespace VLB
{
    using global::System;
    using global::VLB;

    public class SharedVLBEntityManager : IDisposable
    {
        private VLBEntityManager _entityManager;
        private int _referenceCounter;
        public VLBEntityManager Get()
        {
            if (_entityManager == null)
            {
                _entityManager = new VLBEntityManager();
                foreach (var beam in UnityEngine.Object.FindObjectsOfType<VolumetricLightBeamSD>())
                {
                    if (beam.isActiveAndEnabled && !_entityManager.IsValid(beam.entity))
                        beam.entity = _entityManager.CreateEntity(beam);
                }
                VolumetricLightBeamSD.onVLBAdd += OnVLBAdd;
                VolumetricLightBeamSD.onVLBRemove += OnVLBRemove;
                VolumetricLightBeamSD.onVLBPropertyChange += OnVLBPropertyChange;
                VolumetricLightBeamSD.onVLBMaterialChange += OnVLBMaterialChange;
            }
            _referenceCounter++;
            return _entityManager;
        }

        public void Release(VLBEntityManager manager)
        {
            if (_referenceCounter != 0 && --_referenceCounter == 0) Dispose();
        }

        public void Dispose()
        {
            _entityManager.Dispose();
            _entityManager = null;
            _referenceCounter = 0;
            VolumetricLightBeamSD.onVLBAdd -= OnVLBAdd;
            VolumetricLightBeamSD.onVLBRemove -= OnVLBRemove;
            VolumetricLightBeamSD.onVLBPropertyChange -= OnVLBPropertyChange;
            VolumetricLightBeamSD.onVLBMaterialChange -= OnVLBMaterialChange;
        }

        private void OnVLBAdd(VolumetricLightBeamSD vlb)
        {
            if (!_entityManager.IsValid(vlb.entity)) vlb.entity = _entityManager.CreateEntity(vlb);
        }

        private void OnVLBRemove(VolumetricLightBeamSD vlb)
        {
            _entityManager.DestroyEntity(vlb.entity);
        }

        private void OnVLBPropertyChange(VolumetricLightBeamSD vlb)
        {
            if (_entityManager.IsValid(vlb.entity)) _entityManager.UpdateEntityData(vlb.entity, vlb);
        }

        private void OnVLBMaterialChange(VolumetricLightBeamSD vlb)
        {
            OnVLBRemove(vlb);
            OnVLBAdd(vlb);
        }

        public SharedVLBEntityManager()
        {
        }
    }
}

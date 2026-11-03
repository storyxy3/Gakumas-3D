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
            return null;
        }

        public void Release(VLBEntityManager manager)
        {
        }

        public void Dispose()
        {
        }

        private void OnVLBAdd(VolumetricLightBeamSD vlb)
        {
        }

        private void OnVLBRemove(VolumetricLightBeamSD vlb)
        {
        }

        private void OnVLBPropertyChange(VolumetricLightBeamSD vlb)
        {
        }

        private void OnVLBMaterialChange(VolumetricLightBeamSD vlb)
        {
        }

        public SharedVLBEntityManager()
        {
        }
    }
}

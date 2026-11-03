namespace VLB
{
    using global::UnityEngine;
    using global::VLB;

    public abstract class VolumetricLightBeamAbstractBase : MonoBehaviour
    {
        public enum AttachedLightType
        {
            NoLight,
            OtherLight,
            SpotLight
        }

        public const string ClassName = "VolumetricLightBeamAbstractBase";
        [SerializeField]
        protected int pluginVersion;
        protected Light m_CachedLightSpot;
        public bool hasGeometry
        {
            get
            {
                return default(bool);
            }
        }

        public Bounds bounds
        {
            get
            {
                return default(Bounds);
            }
        }

        public int _INTERNAL_pluginVersion
        {
            get
            {
                return default(int);
            }
        }

        public Light lightSpotAttached
        {
            get
            {
                return null;
            }
        }

        public abstract BeamGeometryAbstractBase GetBeamGeometry();
        public abstract bool IsScalable();
        public abstract Vector3 GetLossyScale();
        public Light GetLightSpotAttachedSlow(out AttachedLightType lightType)
        {
            throw null;
        }

        protected void InitLightSpotAttachedCached()
        {
        }

        protected VolumetricLightBeamAbstractBase()
        {
        }
    }
}

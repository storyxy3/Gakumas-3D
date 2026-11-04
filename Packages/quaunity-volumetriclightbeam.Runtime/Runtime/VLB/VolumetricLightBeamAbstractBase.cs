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
        protected int pluginVersion = -1;
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
                return m_CachedLightSpot;
            }
        }

        public abstract BeamGeometryAbstractBase GetBeamGeometry();
        public abstract bool IsScalable();
        public abstract Vector3 GetLossyScale();
        public Light GetLightSpotAttachedSlow(out AttachedLightType lightType)
        {
            if (TryGetComponent<Light>(out Light light))
            {
                if (light.type == LightType.Spot)
                {
                    lightType = AttachedLightType.SpotLight;
                    return light;
                }
                lightType = AttachedLightType.OtherLight;
                return null;
            }
            lightType = AttachedLightType.NoLight;
            return null;
        }

        protected void InitLightSpotAttachedCached()
        {
            m_CachedLightSpot = GetLightSpotAttachedSlow(out AttachedLightType lightType);
        }

        protected VolumetricLightBeamAbstractBase()
        {
        }
    }
}

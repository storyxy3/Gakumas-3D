namespace Campus.Common.GoboLight
{
    using global::Campus.Common.GoboLight;
    using global::UnityEngine;

    [ExecuteAlways]
    [RequireComponent(typeof(Light))]
    public class GoboLight : MonoBehaviour
    {
        public int goboIndex;
        private Light _lightComponent;
        private void OnEnable()
        {
        }

        public unsafe void UpdateLightData(LightData* pLightData)
        {
        }

        public GoboLight()
        {
        }
    }
}

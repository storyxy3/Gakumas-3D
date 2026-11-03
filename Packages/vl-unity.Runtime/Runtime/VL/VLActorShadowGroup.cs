namespace VL
{
    using global::System.Collections.Generic;
    using global::UnityEngine;

    [ExecuteAlways]
    public class VLActorShadowGroup : MonoBehaviour
    {
        private List<Renderer> _renderers;
        private Bounds _bounds;
        private void OnEnable()
        {
        }

        private void OnDisable()
        {
        }

        private Bounds GetBoundsEvent(Camera camera, float far, int resolution)
        {
            return default(Bounds);
        }

        public VLActorShadowGroup()
        {
        }
    }
}

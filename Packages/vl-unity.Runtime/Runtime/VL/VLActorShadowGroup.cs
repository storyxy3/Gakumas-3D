namespace VL
{
    using global::System.Collections.Generic;
    using global::UnityEngine;

    [ExecuteAlways]
    public class VLActorShadowGroup : MonoBehaviour
    {
        private List<Renderer> _renderers = new List<Renderer>(32);
        private Bounds _bounds;
        private void OnEnable()
        {
            Rendering.ActorShadowPass.getBounds += GetBoundsEvent;
            GetComponentsInChildren(_renderers);
        }

        private void OnDisable()
        {
            Rendering.ActorShadowPass.getBounds -= GetBoundsEvent;
        }

        private Bounds GetBoundsEvent(Camera camera, float far, int resolution)
        {
            _bounds = Rendering.AABBUtility.MinBounds;
            foreach (var renderer in _renderers) _bounds.Encapsulate(renderer.bounds);
            return _bounds;
        }

        public VLActorShadowGroup()
        {
        }
    }
}

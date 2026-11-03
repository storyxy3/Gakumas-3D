namespace Qua.VectorUI
{
    using global::System.Collections.Generic;
    using global::Qua.VectorUI;
    using global::UnityEngine;
    using global::UnityEngine.UI;

    [ExecuteAlways]
    [RequireComponent(typeof(RoundedPolyline))]
    public abstract class GraphicOutlineSetterBase<T> : MonoBehaviour where T : Graphic
    {
        private static readonly List<RoundedPolyline.Vertex> ListCache;
        [SerializeField]
        protected T _source;
        protected RoundedPolyline _target;
        private RoundedPolyline.Vertex[] _cachedArray;
        private bool _dirty;
        private void Awake()
        {
        }

        private void OnEnable()
        {
        }

        private void OnDisable()
        {
        }

        private void RegisterAction()
        {
        }

        private void UnregisterAction()
        {
        }

        private void SetDirty()
        {
        }

        private void LateUpdate()
        {
        }

        protected abstract void UpdateVertices(List<RoundedPolyline.Vertex> list);
        private void UpdateVertices()
        {
        }

        private void SetVertices(List<RoundedPolyline.Vertex> list)
        {
        }

        protected GraphicOutlineSetterBase()
        {
        }
    }
}

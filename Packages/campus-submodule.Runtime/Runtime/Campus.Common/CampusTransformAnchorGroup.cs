namespace Campus.Common
{
    using global::Campus.Common;
    using global::UnityEngine;

    [RequireComponent(typeof(CampusTransformAnchorGroup))]
    public class CampusTransformAnchorGroup : MonoBehaviour, ICampusTransformAnchor
    {
        [SerializeField]
        private CampusTransformAnchor[] _transformAnchors;
        public CampusTransformAnchor[] TransformAnchors
        {
            get
            {
                return _transformAnchors;
            }
        }

        private void OnValidate()
        {
            if (global::Qua.Extensions.IEnumerableExtensions.IsNullOrEmpty(_transformAnchors)) _transformAnchors = GetComponentsInChildren<CampusTransformAnchor>();
        }

        public void SetAnchorActive(bool value)
        {
            foreach (var anchor in _transformAnchors) anchor.SetAnchorActive(value);
        }

        public void SetAnchorOffset(Vector3 value)
        {
            foreach (var anchor in _transformAnchors) anchor.SetAnchorOffset(value);
        }

        public void SetYaw(float value)
        {
            foreach (var anchor in _transformAnchors) anchor.SetYaw(value);
        }

        public void SetPitch(float value)
        {
            foreach (var anchor in _transformAnchors) anchor.SetPitch(value);
        }

        public void SetRoll(float value)
        {
            foreach (var anchor in _transformAnchors) anchor.SetRoll(value);
        }

        public void SetDistance(float value)
        {
            foreach (var anchor in _transformAnchors) anchor.SetDistance(value);
        }

        public void SetUseCamera(bool value)
        {
            foreach (var anchor in _transformAnchors) anchor.SetUseCamera(value);
        }

        public void SetUpDirection(CampusTransformAnchor.UpDirection value)
        {
            foreach (var anchor in _transformAnchors) anchor.SetUpDirection(value);
        }

        public CampusTransformAnchorGroup()
        {
        }
    }
}

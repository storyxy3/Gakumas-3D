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
                return null;
            }
        }

        private void OnValidate()
        {
        }

        public void SetAnchorActive(bool value)
        {
        }

        public void SetAnchorOffset(Vector3 value)
        {
        }

        public void SetYaw(float value)
        {
        }

        public void SetPitch(float value)
        {
        }

        public void SetRoll(float value)
        {
        }

        public void SetDistance(float value)
        {
        }

        public void SetUseCamera(bool value)
        {
        }

        public void SetUpDirection(CampusTransformAnchor.UpDirection value)
        {
        }

        public CampusTransformAnchorGroup()
        {
        }
    }
}

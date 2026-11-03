namespace Campus.Common
{
    using global::Campus.Common;
    using global::UnityEngine;

    public class CampusCameraSwitcher : MonoBehaviour
    {
        [SerializeField]
        private CampusSwitchableCamera[] _switchableCameras;
        public int CameraCount
        {
            get
            {
                return default(int);
            }
        }

        private void OnValidate()
        {
        }

        public CampusSwitchableCamera GetCamera(int index)
        {
            return null;
        }

        public CampusCameraSwitcher()
        {
        }
    }
}

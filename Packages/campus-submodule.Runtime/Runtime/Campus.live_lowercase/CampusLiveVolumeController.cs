namespace Campus.live
{
    using global::Campus.live;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;

    [ExecuteAlways]
    public class CampusLiveVolumeController : MonoBehaviour
    {
        private Volume[] _volumes;
        [SerializeField]
        private int _priority;
        [SerializeField]
        private VolumeProfileData _volumeProfileData;
        public Volume[] Volumes
        {
            get
            {
                return null;
            }
        }

        public VolumeProfileData VolumeProfileData
        {
            get
            {
                return null;
            }
        }

        private void OnEnable()
        {
        }

        private void OnDisable()
        {
        }

        public void SetVolumeProfile(int index, VolumeProfile profile)
        {
        }

        public void SetVolumeWeight(int index, float weight)
        {
        }

        public void SetVolumeActive(int index, bool active)
        {
        }

        public void SetLiveVolumeData(VolumeProfileData volumeProfileData)
        {
        }

        public CampusLiveVolumeController()
        {
        }
    }
}

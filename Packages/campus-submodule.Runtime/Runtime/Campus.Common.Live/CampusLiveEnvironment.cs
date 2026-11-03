namespace Campus.Common.Live
{
    using global::Campus.Live.Equipment;
    using global::UnityEngine;

    public class CampusLiveEnvironment : MonoBehaviour
    {
        [SerializeField]
        private LiveEquipmentReceiver _equipmentReceiver;
        public LiveEquipmentReceiver equipmentReceiver
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public CampusLiveEnvironment()
        {
        }
    }
}

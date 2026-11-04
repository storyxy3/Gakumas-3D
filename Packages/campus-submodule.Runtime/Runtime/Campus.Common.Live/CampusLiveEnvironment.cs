// TODO(qa-recon): Selected APK bodies still need reconstruction: .ctor.
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
                return _equipmentReceiver;
            }

            set
            {
                _equipmentReceiver = value;
            }
        }

        public CampusLiveEnvironment()
        {
        }
    }
}

namespace Campus.Live.Equipment
{
    using global::Campus.Live.Equipment;
    using global::UnityEngine;
    using global::UnityEngine.Serialization;

    public class EquipmentValue : MonoBehaviour
    {
        public EquipmentId id;
        public EquipmentId reverseId;
        [SerializeField]
        [HideInInspector]
        private int _selectedIdGroupIndex;
        [FormerlySerializedAs("customSceneTransform")]
        public Transform targetTransform;
        public float intensity = 1f;
        [ColorUsage(false, true)]
        public Color color;
        [FormerlySerializedAs("strobe")]
        public float bpm;
        public float v0;
        public float v1;
        public float v2;
        public float v3;
        private LiveEquipmentController _controller;
        public LiveEquipmentController EquipmentController
        {
            get
            {
                return _controller;
            }
        }

        public void SetController(LiveEquipmentController controller)
        {
            _controller = controller;
        }

        public EquipmentValue()
        {
        }
    }
}

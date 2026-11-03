namespace Qua.UI
{
    using global::Qua.UI;
    using global::UnityEngine;
    using global::UnityEngine.UI;

    [RequireComponent(typeof(Graphic))]
    public class UIScroll : QuaUIBehaviour
    {
        public enum UpdateType
        {
            Update,
            LateUpdate,
            UnscaledUpdate,
            UnscaledLateUpdate
        }

        private bool _isQuit;
        [SerializeField]
        public UpdateType updateType;
        [SerializeField]
        public bool useDeltaTime;
        [SerializeField]
        public bool resetDeltaTimeOnEnable;
        [SerializeField]
        public AnimationCurve xCurve;
        [SerializeField]
        public AnimationCurve yCurve;
        [SerializeField]
        private Shader _scrollShader;
        private float _deltaTime;
        private Graphic _targetGraphic;
        private Material _createdMaterial;
        private Graphic TargetGraphic
        {
            get
            {
                return null;
            }
        }

        private Material TargetMaterial
        {
            get
            {
                return null;
            }
        }

        public void ResetDeltaTime()
        {
        }

        private void OnApplicationQuit()
        {
        }

        protected override void OnDestroy()
        {
        }

        protected override void OnEnable()
        {
        }

        private void Update()
        {
        }

        private void LateUpdate()
        {
        }

        private float GetCurrentTime()
        {
            return default(float);
        }

        private void UpdateDeltaTime()
        {
        }

        private void ApplyUV(float time)
        {
        }

        public UIScroll()
        {
        }
    }
}

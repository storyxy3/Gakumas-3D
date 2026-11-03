namespace Campus.Common
{
    using global::UnityEngine;
    using global::UnityEngine.UI;

    public class RotateRing : MonoBehaviour
    {
        [SerializeField]
        private Transform _startRotateRoot;
        [SerializeField]
        private Transform _endRotateRoot;
        [SerializeField]
        private Image _ring;
        [SerializeField]
        [Range(0f, 1f)]
        private float _startValue;
        [SerializeField]
        [Range(0f, 1f)]
        private float _endValue;
        public float StartValue
        {
            get
            {
                return default(float);
            }

            set
            {
            }
        }

        public float EndValue
        {
            get
            {
                return default(float);
            }

            set
            {
            }
        }

        private void Apply()
        {
        }

        public RotateRing()
        {
        }
    }
}

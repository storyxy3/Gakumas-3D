namespace Titan
{
    using global::System;
    using global::UnityEngine;

    [Serializable]
    public class EaseInfo
    {
        [SerializeField]
        private string _easeId;
        [SerializeField]
        private float _parameter1;
        [SerializeField]
        private float _parameter2;
        public string EaseId
        {
            get
            {
                return null;
            }
        }

        public float Parameter1
        {
            get
            {
                return default(float);
            }
        }

        public float Parameter2
        {
            get
            {
                return default(float);
            }
        }

        public EaseInfo()
        {
        }
    }
}

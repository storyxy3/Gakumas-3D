namespace Common.Live
{
    using global::System;
    using global::UnityEngine;

    [Serializable]
    public class OverrideMonitorSprite
    {
        [SerializeField]
        private string _key;
        [SerializeField]
        private Sprite _value;
        public string Key
        {
            get
            {
                return null;
            }
        }

        public Sprite Value
        {
            get
            {
                return null;
            }
        }

        public OverrideMonitorSprite()
        {
        }
    }
}

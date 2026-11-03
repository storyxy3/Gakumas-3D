namespace Campus.Common
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::Campus.Common;
    using global::Qua.UI;
    using global::UnityEngine;

    [RequireComponent(typeof(CampusButton))]
    public class CampusButtonToggle : QuaUIBehaviour
    {
        [SerializeField]
        private CampusButton _button;
        [SerializeField]
        private GameObject _uncheckedRoot;
        [SerializeField]
        private GameObject _checkedRoot;
        [SerializeField]
        private bool _checked;
        public Action<bool> onClickedToggleCallback;
        public bool IsChecked
        {
            get
            {
                return default(bool);
            }
        }

        protected override void Awake()
        {
        }

        private void SetCheckedRootActive()
        {
        }

        public void SwitchRoot()
        {
        }

        public void SetChecked(bool isChecked)
        {
        }

        private void OnClicked()
        {
        }

        public CampusButtonToggle()
        {
        }

        [CompilerGenerated]
        private void _003CAwake_003Eb__7_0()
        {
        }
    }
}

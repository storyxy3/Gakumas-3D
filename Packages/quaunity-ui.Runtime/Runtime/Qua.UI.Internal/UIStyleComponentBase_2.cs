namespace Qua.UI.Internal
{
    using global::Qua.UI.Internal;
    using global::UnityEngine;

    public abstract class UIStyleComponentBase<TComponent, TStyleType> : UIStyleComponentBase where TComponent : MonoBehaviour where TStyleType : ClassEnumBase
    {
        private TComponent _targetComponent;
        [SerializeField]
        protected bool _applyOnEnable;
        [SerializeField]
        protected TStyleType _styleType;
        public TComponent TargetComponent
        {
            get
            {
                return null;
            }
        }

        public TStyleType StyleType
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        protected abstract void ApplyStyle(TStyleType style);
        protected override void Start()
        {
        }

        protected override void OnEnable()
        {
        }

        protected UIStyleComponentBase()
        {
        }
    }
}

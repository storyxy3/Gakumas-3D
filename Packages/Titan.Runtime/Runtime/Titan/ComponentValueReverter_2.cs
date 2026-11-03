namespace Titan
{
    using global::Titan;
    using global::UnityEngine;

    public class ComponentValueReverter<TComponent, TValue> : IValueReverter where TComponent : Object
    {
        private readonly IComponentValueSetter<TComponent, TValue> _setter;
        private readonly TComponent _component;
        private readonly TValue _value;
        public ComponentValueReverter(IComponentValueSetter<TComponent, TValue> setter, TValue value, TComponent component)
        {
        }

        public void Revert()
        {
        }
    }
}

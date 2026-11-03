namespace Titan
{
    public interface IComponentValueSetter<in TComponent, in TValue>
    {
        void SetValue(TValue value, TComponent component);
    }
}

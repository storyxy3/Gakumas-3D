namespace Titan
{
    using global::Titan;

    public interface IVariableValue
    {
        object GetValue(IValueResolver resolver);
    }
}

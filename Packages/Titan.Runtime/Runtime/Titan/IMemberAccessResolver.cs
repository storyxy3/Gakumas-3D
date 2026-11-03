namespace Titan
{
    using global::Titan;

    public interface IMemberAccessResolver
    {
        Value GetFieldValue(Value value, string fieldName);
    }
}

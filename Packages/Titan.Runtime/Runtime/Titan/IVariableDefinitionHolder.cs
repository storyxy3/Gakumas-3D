namespace Titan
{
    using global::System.Collections.Generic;
    using global::Titan;

    public interface IVariableDefinitionHolder
    {
        IList<VariableDefinition> Variables { get; }
    }
}

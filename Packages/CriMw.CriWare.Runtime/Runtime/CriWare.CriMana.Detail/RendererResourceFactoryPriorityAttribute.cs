namespace CriWare.CriMana.Detail
{
    using global::System;

    [AttributeUsage(AttributeTargets.Class)]
    public class RendererResourceFactoryPriorityAttribute : Attribute
    {
        public readonly int priority;
        public RendererResourceFactoryPriorityAttribute(int priority)
        {
        }
    }
}

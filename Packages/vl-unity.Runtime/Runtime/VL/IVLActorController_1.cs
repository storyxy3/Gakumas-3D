namespace VL
{
    using global::VL;

    public interface IVLActorController<IDescriptor> : IVLActorController, IVLTransform where IDescriptor : IVLActorDescriptor
    {
        IDescriptor descriptor { get; }

        void SetChildRendererActive(string partsId, bool active);
    }
}

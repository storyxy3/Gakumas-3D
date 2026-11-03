namespace VL
{
    using global::VL;

    public class VLDefaultActorController : VLDefaultActorController<VLDefaultActorModelParts, VLDefaultActorDescriptor, IVLDefaultActorDescriptor>, IVLDefaultActorController, IVLDefaultActorController<IVLDefaultActorDescriptor>, IVLActorController<IVLDefaultActorDescriptor>, IVLActorController, IVLTransform
    {
        public VLDefaultActorController()
        {
        }

        bool VL.IVLActorController.TryGetComponent<T>(out T component)
        {
            throw null;
        }
    }
}

namespace VL
{
    using global::UnityEngine;
    using global::VL.Core;

    public class VLActorSettings : ScriptableObject
    {
        public RuntimeAnimatorController actorController;
        public virtual void OnActorBuilded(bool isSuccess, VLActorController actor)
        {
        }

        public virtual void OnActorDestroy(VLActorController actor)
        {
        }

        public VLActorSettings()
        {
        }
    }
}

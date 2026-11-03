namespace VL
{
    using global::UnityEngine;
    using global::VL;

    public struct VLActorRaycastHit
    {
        public int actorIndex;
        public VLActorBodyType bodyType;
        public RaycastHit hit;
    }
}

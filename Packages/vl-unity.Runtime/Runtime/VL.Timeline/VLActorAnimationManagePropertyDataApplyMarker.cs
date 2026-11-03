namespace VL.Timeline
{
    using global::System.ComponentModel;
    using global::ActorAnimation;
    using global::UnityEngine.Timeline;

    [DisplayName("Live/VL ActorAnimation ManagePropertyData Apply Marker")]
    public class VLActorAnimationManagePropertyDataApplyMarker : Marker
    {
        public ActorAnimationManagePropertyData propertyData;
        public VLActorAnimationManagePropertyDataApplyMarker()
        {
        }
    }
}

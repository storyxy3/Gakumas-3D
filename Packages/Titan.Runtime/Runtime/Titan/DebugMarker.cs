namespace Titan
{
    using global::System.ComponentModel;
    using global::Titan;
    using global::UnityEngine;

    [DisplayName("Titan/Debug Marker")]
    public class DebugMarker : TweenMarkerBase
    {
        [SerializeField]
        private string _message;
        public override void Execute(TweenCreationContext context)
        {
        }

        public DebugMarker()
        {
        }
    }
}

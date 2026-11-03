namespace Titan
{
    using global::System;
    using global::UnityEngine.Timeline;

    public class TitanTrackBindingTypeAttribute : TrackBindingTypeAttribute
    {
        // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
        public TitanTrackBindingTypeAttribute(Type type) : base(default)
        {
        }
    }
}

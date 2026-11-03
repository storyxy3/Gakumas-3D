namespace Titan
{
    using global::System.ComponentModel;
    using global::System.Runtime.CompilerServices;
    using global::DG.Tweening;
    using global::Titan;
    using global::UnityEngine;
    using global::UnityEngine.Timeline;

    [TitanTrackBindingType(typeof(Transform))]
    [TrackClipType(typeof(WorldPathClip))]
    [DisplayName("Titan/Transform/WorldPath")]
    public class WorldPathTrack : PathTrackBase<WorldPathClip>
    {
        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass0_0
        {
            public WorldPathClip clipAsset;
            public Vector3 position;
            public _003C_003Ec__DisplayClass0_0()
            {
            }

            internal Vector3 _003CGetTween_003Eb__0(Vector3 point)
            {
                return default(Vector3);
            }
        }

        protected override Tween GetTween(Transform component, WorldPathClip clipAsset, float duration)
        {
            return null;
        }

        protected override Vector3 GetValue(Transform component)
        {
            return default(Vector3);
        }

        public override void SetValue(Vector3 value, Transform component)
        {
        }

        public WorldPathTrack()
        {
        }
    }
}

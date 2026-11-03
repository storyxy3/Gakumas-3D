namespace Titan
{
    using global::System.Runtime.CompilerServices;
    using global::DG.Tweening;
    using global::DG.Tweening.Plugins.Core.PathCore;
    using global::Titan;
    using global::UnityEngine;

    public abstract class PathTrack3DBase<TClipAsset> : PathTrackBase<TClipAsset> where TClipAsset : PathClip3DBase
    {
        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass0_0
        {
            public TClipAsset clipAsset;
            public PathTrack3DBase<TClipAsset> _003C_003E4__this;
            public Transform component;
            public Vector3[] wayPoints;
            public Path path;
            public _003C_003Ec__DisplayClass0_0()
            {
            }

            internal Vector3 _003CGetTween_003Eb__0(Vector3 point)
            {
                return default(Vector3);
            }

            internal void _003CGetTween_003Eb__4(Vector3 x)
            {
            }

            internal Vector3 _003CGetTween_003Eb__1()
            {
                return default(Vector3);
            }

            internal void _003CGetTween_003Eb__2(Vector3 x)
            {
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass0_1
        {
            public bool isInitialized;
            public _003C_003Ec__DisplayClass0_0 CS_0024_003C_003E8__locals1;
            public _003C_003Ec__DisplayClass0_1()
            {
            }

            internal Vector3 _003CGetTween_003Eb__3()
            {
                return default(Vector3);
            }
        }

        protected override Tween GetTween(Transform component, TClipAsset clipAsset, float duration)
        {
            return null;
        }

        protected PathTrack3DBase()
        {
        }
    }
}

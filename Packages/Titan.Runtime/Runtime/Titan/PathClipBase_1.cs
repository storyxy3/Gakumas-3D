namespace Titan
{
    using global::System.Collections.Generic;
    using global::System.Runtime.InteropServices;
    using global::DG.Tweening;
    using global::Titan;
    using global::UnityEngine;

    public abstract class PathClipBase<TVector> : LoopableTweenClip
    {
        [SerializeField]
        private EaseInfo _easeInfo;
        [SerializeField]
        private TVector[] _wayPoints;
        [SerializeField]
        private PathType _pathType;
        [SerializeField]
        private bool _isRelative;
        public EaseInfo EaseInfo
        {
            get
            {
                return null;
            }
        }

        public abstract IReadOnlyList<IPathVertex> PathVertices { get; }

        public PathType PathType
        {
            get
            {
                return default(PathType);
            }
        }

        public bool IsRelative
        {
            get
            {
                return default(bool);
            }
        }

        public virtual bool IsClosed
        {
            get
            {
                return default(bool);
            }
        }

        public IEnumerable<Vector3> GetWayPoints(IValueResolver resolver)
        {
            return null;
        }

        protected abstract Vector3 GetVector3(TVector vector);
        protected abstract TVector GetVector(Vector3 vector);
        protected abstract void CreatePathVertices(Vector3 targetPoint, Vector3 inController, Vector3 outController);
        private IReadOnlyList<Vector3> ConvertPathVerticesToWayPoints(IReadOnlyList<IPathVertex> pathVertices, [Optional] TVector[] targetPoints)
        {
            return null;
        }

        protected PathClipBase()
        {
        }
    }
}

namespace Titan
{
    using global::System.Collections.Generic;
    using global::DG.Tweening;
    using global::DG.Tweening.Core;
    using global::DG.Tweening.Plugins.Core.PathCore;
    using global::DG.Tweening.Plugins.Options;
    using global::Titan;
    using global::UnityEngine;

    public abstract class PathClip3DBase : PathClipBase<Vector3>
    {
        [SerializeField]
        private PathVertex3D[] _pathVertices;
        [SerializeField]
        private PathMode _pathMode;
        [SerializeField]
        private bool _isClosed;
        [SerializeField]
        private Vector3AxisType _lockPosition;
        [SerializeField]
        private Vector3AxisType _lockRotation;
        [SerializeField]
        private float _lookAhead;
        public PathMode PathMode
        {
            get
            {
                return default(PathMode);
            }
        }

        public override IReadOnlyList<IPathVertex> PathVertices
        {
            get
            {
                return null;
            }
        }

        public override bool IsClosed
        {
            get
            {
                return default(bool);
            }
        }

        protected override Vector3 GetVector(Vector3 vector)
        {
            return default(Vector3);
        }

        protected override Vector3 GetVector3(Vector3 vector)
        {
            return default(Vector3);
        }

        protected override void CreatePathVertices(Vector3 targetPoint, Vector3 inController, Vector3 outController)
        {
        }

        public void SetPathOptions(TweenerCore<Vector3, Path, PathOptions> tweener)
        {
        }

        private static AxisConstraint GetAxisConstraint(Vector3AxisType axisType)
        {
            return default(AxisConstraint);
        }

        protected PathClip3DBase()
        {
        }
    }
}

namespace Titan
{
    using global::System.Collections.Generic;
    using global::Titan;
    using global::UnityEngine;

    public abstract class PathClip2DBase : PathClipBase<Vector2>
    {
        [SerializeField]
        private PathVertex[] _pathVertices;
        public override IReadOnlyList<IPathVertex> PathVertices
        {
            get
            {
                return null;
            }
        }

        protected override Vector2 GetVector(Vector3 vector)
        {
            return default(Vector2);
        }

        protected override Vector3 GetVector3(Vector2 vector)
        {
            return default(Vector3);
        }

        protected override void CreatePathVertices(Vector3 targetPoint, Vector3 inController, Vector3 outController)
        {
        }

        protected PathClip2DBase()
        {
        }
    }
}

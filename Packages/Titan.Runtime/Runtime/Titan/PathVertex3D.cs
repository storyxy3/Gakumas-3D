namespace Titan
{
    using global::System;
    using global::Titan;
    using global::UnityEngine;

    [Serializable]
    public class PathVertex3D : IPathVertex
    {
        [SerializeField]
        private Vector3 _targetPoint;
        [SerializeField]
        private Vector3 _inController;
        [SerializeField]
        private Vector3 _outController;
        public Vector3 TargetPoint
        {
            get
            {
                return default(Vector3);
            }

            set
            {
            }
        }

        public Vector3 InController
        {
            get
            {
                return default(Vector3);
            }

            set
            {
            }
        }

        public Vector3 OutController
        {
            get
            {
                return default(Vector3);
            }

            set
            {
            }
        }

        public PathVertex3D()
        {
        }
    }
}

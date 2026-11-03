namespace Campus.Photography
{
    using global::System;
    using global::Campus.Photography;
    using global::UnityEngine;

    [Serializable]
    public class PhotographyScreenSpotData
    {
        [Serializable]
        public class CameraScreenSpot
        {
            [SerializeField]
            private Vector2 _position;
            [SerializeField]
            private float _rotation;
            [SerializeField]
            private float _scale;
            public Vector2 Position
            {
                get
                {
                    return default(Vector2);
                }
            }

            public float Rotation
            {
                get
                {
                    return default(float);
                }
            }

            public float Scale
            {
                get
                {
                    return default(float);
                }
            }

            public CameraScreenSpot()
            {
            }
        }

        [Serializable]
        public class ActorScreenSpot
        {
            [SerializeField]
            private Vector2 _position;
            [SerializeField]
            private float _scale;
            public Vector2 Position
            {
                get
                {
                    return default(Vector2);
                }
            }

            public float Scale
            {
                get
                {
                    return default(float);
                }
            }

            public ActorScreenSpot()
            {
            }
        }

        [SerializeField]
        private CameraScreenSpot _cameraSpot;
        [SerializeField]
        private ActorScreenSpot[] _actorSpots;
        public CameraScreenSpot CameraSpot
        {
            get
            {
                return null;
            }
        }

        public ActorScreenSpot[] ActorSpots
        {
            get
            {
                return null;
            }
        }

        public PhotographyScreenSpotData()
        {
        }
    }
}

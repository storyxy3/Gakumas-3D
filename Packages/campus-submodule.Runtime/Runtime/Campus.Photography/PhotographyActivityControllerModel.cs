namespace Campus.Photography
{
    using global::System.Runtime.CompilerServices;
    using global::Campus.Common;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;

    public class PhotographyActivityControllerModel
    {
        private const float DefaultFNumber = -1f;
        [CompilerGenerated]
        private float _003CZoomRatio_003Ek__BackingField;
        [CompilerGenerated]
        private float _003CFNumber_003Ek__BackingField;
        private readonly VolumeProfile _volumeProfile;
        [CompilerGenerated]
        private Transform _003CFocusTarget_003Ek__BackingField;
        [CompilerGenerated]
        private ICampusActorController _003CFocusActor_003Ek__BackingField;
        [CompilerGenerated]
        private (Vector3 pos, float angleX, float angleY, float colliderY, float cameraHeight) _003CStartData_003Ek__BackingField;
        [CompilerGenerated]
        private bool _003CIsSetDataFrame_003Ek__BackingField;
        [CompilerGenerated]
        private Vector2 _003CFrameDeltaPositionXZ_003Ek__BackingField;
        [CompilerGenerated]
        private float _003CFrameDeltaPositionY_003Ek__BackingField;
        public float ZoomRatio
        {
            [CompilerGenerated]
            get
            {
                return _003CZoomRatio_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CZoomRatio_003Ek__BackingField = value;
            }
        }

        public float FNumber
        {
            [CompilerGenerated]
            get
            {
                return _003CFNumber_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CFNumber_003Ek__BackingField = value;
            }
        }

        public Transform FocusTarget
        {
            [CompilerGenerated]
            get
            {
                return _003CFocusTarget_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CFocusTarget_003Ek__BackingField = value;
            }
        }

        public ICampusActorController FocusActor
        {
            [CompilerGenerated]
            get
            {
                return _003CFocusActor_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CFocusActor_003Ek__BackingField = value;
            }
        }

        public (Vector3 pos, float angleX, float angleY, float colliderY, float cameraHeight) StartData
        {
            [CompilerGenerated]
            get
            {
                return default((Vector3, float, float, float, float));
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public bool IsSetDataFrame
        {
            [CompilerGenerated]
            get
            {
                return _003CIsSetDataFrame_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CIsSetDataFrame_003Ek__BackingField = value;
            }
        }

        public Vector2 FrameDeltaPositionXZ
        {
            [CompilerGenerated]
            get
            {
                return _003CFrameDeltaPositionXZ_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CFrameDeltaPositionXZ_003Ek__BackingField = value;
            }
        }

        public float FrameDeltaPositionY
        {
            [CompilerGenerated]
            get
            {
                return _003CFrameDeltaPositionY_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CFrameDeltaPositionY_003Ek__BackingField = value;
            }
        }

        public PhotographyActivityControllerModel(VolumeProfile volumeProfile)
        {
        }

        public void SetStartData(Vector3 position, float angleX, float angleY, float colliderY, float cameraHeight)
        {
        }

        public void SetFocusTarget(ICampusActorController actorController, Transform target)
        {
        }

        public void SetFocusTarget(Transform target)
        {
        }

        public void SetFocalPoint(float value)
        {
        }

        public void SetFNumberFixed(float value)
        {
        }

        public void ResetData()
        {
        }
    }
}

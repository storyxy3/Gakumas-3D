namespace Campus.Common
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::Campus.Common;
    using global::Campus.Photography;
    using global::Cinemachine;
    using global::UnityEngine;

    public class CampusPhotographySceneLayout : MonoBehaviour
    {
        [Serializable]
        public class ActorLookAtSetting
        {
            public byte EnableLookAtFlag;
            public bool GetEnableLookAt(int index)
            {
                return default(bool);
            }

            public ActorLookAtSetting()
            {
            }
        }

        [Serializable]
        public class ActorSetting
        {
            public Vector3 frontActorPosition;
            public ActorSetting()
            {
            }
        }

        [Serializable]
        public class SceneLayoutLookAngleLimit
        {
            [SerializeField]
            [Header("振り向き直す角度")]
            private float _lookAgainAngle;
            [SerializeField]
            [Header("振り向き無効にする角度")]
            private float _lookOutAngle;
            public float LookAgainAngle
            {
                get
                {
                    return default(float);
                }
            }

            public float LookOutAngle
            {
                get
                {
                    return default(float);
                }
            }

            public SceneLayoutLookAngleLimit()
            {
            }
        }

        [SerializeField]
        private string _id;
        [SerializeField]
        private Transform _cameraSpot;
        [CompilerGenerated]
        private CinemachineVirtualCamera _003CVirtualCamera_003Ek__BackingField;
        [SerializeField]
        private CampusVirtualActorController[] _actors;
        [SerializeField]
        private CampusActorLayout _actorLayout;
        [SerializeField]
        private bool isOverrideCameraHeight;
        [SerializeField]
        private float _minCameraHeight;
        [SerializeField]
        private float _maxCameraHeight;
        [SerializeField]
        private ActorLookAtSetting[] _actorLookAtSettings;
        [SerializeField]
        private ActorSetting[] _actorSettings;
        [SerializeField]
        private PhotographyScreenSpotData photographyScreenSpotData;
        [SerializeField]
        private SceneLayoutLookAngleLimit _overwriteBodyLookAngleLimit;
        [SerializeField]
        private SceneLayoutLookAngleLimit _overwriteEyeLookAngleLimit;
        public string Id
        {
            get
            {
                return null;
            }
        }

        public Transform CameraSpot
        {
            get
            {
                return null;
            }
        }

        public CinemachineVirtualCamera VirtualCamera
        {
            [CompilerGenerated]
            get
            {
                return _003CVirtualCamera_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CVirtualCamera_003Ek__BackingField = value;
            }
        }

        public CampusActorLayout ActorLayout
        {
            get
            {
                return null;
            }
        }

        public bool IsOverrideCameraHeight
        {
            get
            {
                return default(bool);
            }
        }

        public float MinCameraHeight
        {
            get
            {
                return default(float);
            }
        }

        public float MaxCameraHeight
        {
            get
            {
                return default(float);
            }
        }

        public ActorLookAtSetting[] ActorLookAtSettings
        {
            get
            {
                return null;
            }
        }

        public ActorSetting[] ActorSettings
        {
            get
            {
                return null;
            }
        }

        public PhotographyScreenSpotData PhotographyScreenSpotData
        {
            get
            {
                return null;
            }
        }

        public (float overwriteLookAgainAngle, float overwriteLookOutAngle) OverwriteBodyLookAngleLimit
        {
            get
            {
                return default((float, float));
            }
        }

        public (float overwriteLookAgainAngle, float overwriteLookOutAngle) OverwriteEyeLookAngleLimit
        {
            get
            {
                return default((float, float));
            }
        }

        private void OnEnable()
        {
        }

        public void SetupActor(IList<ICampusActorController> actors)
        {
        }

        public void Unset()
        {
        }

        public bool GetActorLookAtSettings(int originIndex, int targetIndex)
        {
            return default(bool);
        }

        private void SetActorSettings()
        {
        }

        public CampusPhotographySceneLayout()
        {
        }
    }
}

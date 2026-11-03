namespace Campus.Common
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::Campus.Common;
    using global::UnityEngine;
    using global::VL;

    [Serializable]
    public class CampusActorDescriptor : VLDefaultActorDescriptor, ICampusActorDescriptor, IVLDefaultActorDescriptor, IVLActorDescriptor
    {
        private sealed class UniqueIdTypeEqualityComparer : IEqualityComparer<CampusActorDescriptor>
        {
            public bool Equals(CampusActorDescriptor x, CampusActorDescriptor y)
            {
                return default(bool);
            }

            public int GetHashCode(CampusActorDescriptor obj)
            {
                return default(int);
            }

            public UniqueIdTypeEqualityComparer()
            {
            }
        }

        [SerializeField]
        private string _uniqueId;
        [SerializeField]
        private bool _autoBlinkDisabled;
        [SerializeField]
        private bool _useADVSettings;
        [SerializeField]
        private bool _correctSkeletonToCmmnHeight;
        [CompilerGenerated]
        private CampusActorAnimationJointLimitSetting _003CjointLimitSetting_003Ek__BackingField;
        [CompilerGenerated]
        private static readonly IEqualityComparer<CampusActorDescriptor> _003CUniqueIdTypeComparer_003Ek__BackingField;
        public string uniqueId
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public bool autoBlinkDisabled
        {
            get
            {
                return default(bool);
            }

            set
            {
            }
        }

        public bool useADVSettings
        {
            get
            {
                return default(bool);
            }

            set
            {
            }
        }

        public bool correctSkeletonToCmmnHeight
        {
            get
            {
                return default(bool);
            }

            set
            {
            }
        }

        public CampusActorAnimationJointLimitSetting jointLimitSetting
        {
            [CompilerGenerated]
            get
            {
                return null;
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public string body
        {
            get
            {
                return null;
            }
        }

        public string face
        {
            get
            {
                return null;
            }
        }

        public string hair
        {
            get
            {
                return null;
            }
        }

        public static IEqualityComparer<CampusActorDescriptor> UniqueIdTypeComparer
        {
            [CompilerGenerated]
            get
            {
                return null;
            }
        }

        public string GetCharacterId()
        {
            return null;
        }

        public CampusActorDescriptor()
        {
        }
    }
}

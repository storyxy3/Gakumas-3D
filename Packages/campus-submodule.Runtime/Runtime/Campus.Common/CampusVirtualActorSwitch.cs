namespace Campus.Common
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::Campus.Common;
    using global::Campus.Timeline;
    using global::UnityEngine;

    [ExecuteAlways]
    [DefaultExecutionOrder(-500)]
    public class CampusVirtualActorSwitch : MonoBehaviour
    {
        [Serializable]
        public class SourceVirualActor
        {
            public CampusVirtualActorController virtualActorController;
            public Transform[] bones;
            public SourceVirualActor()
            {
            }
        }

        [SerializeField]
        private int _activeGroupIndex;
        [SerializeField]
        private int _slotIndex;
        private IDisposable _currentActorSignalSubscription;
        public Transform[] targetBones;
        [SerializeField]
        private List<SourceVirualActor> _sourceVirualActorList;
        public int ActiveGroupIndex
        {
            get
            {
                return default(int);
            }
        }

        public int SourceVirualActorCount
        {
            get
            {
                return default(int);
            }
        }

        public void SetActiveVirtualActorIndex(int index)
        {
        }

        private void OnEnable()
        {
        }

        private void OnDisable()
        {
        }

        private void LateUpdate()
        {
        }

        private static ICurrentActorSignalController FindCurrentActorSignalController()
        {
            return null;
        }

        private void ApplyActiveGroup()
        {
        }

        private bool IsValidGroupIndex(int index)
        {
            return default(bool);
        }

        public CampusVirtualActorSwitch()
        {
        }

        [CompilerGenerated]
        private bool _003COnEnable_003Eb__11_0(CurrentActorSignalData signal)
        {
            return default(bool);
        }

        [CompilerGenerated]
        private void _003COnEnable_003Eb__11_1(CurrentActorSignalData signal)
        {
        }
    }
}

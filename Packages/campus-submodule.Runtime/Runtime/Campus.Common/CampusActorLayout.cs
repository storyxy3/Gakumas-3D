namespace Campus.Common
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Runtime.InteropServices;
    using global::Campus.Common;
    using global::UnityEngine;
    using global::UnityEngine.SceneManagement;
    using global::VL.Animation;

    [ExecuteAlways]
    [DefaultExecutionOrder(2000)]
    public class CampusActorLayout : MonoBehaviour
    {
        [Serializable]
        public class Constraint
        {
            public string name;
            public Transform transform;
            public Constraint()
            {
            }
        }

        [Serializable]
        public class Data
        {
            public Constraint root;
            public Data()
            {
            }
        }

        [SerializeField]
        private Data[] _dataArray;
        private Transform[] _dataArrayTransformCaches;
        [SerializeField]
        private IAnimationPlayer _player;
        public static readonly string RootName;
        public IAnimationPlayer player
        {
            get
            {
                return null;
            }
        }

        public void ApplyToActors(IEnumerable<ICampusActorController> actors)
        {
        }

        public static CampusActorLayout CreateActorLayout([Optional] Scene scene)
        {
            return null;
        }

        public Transform[] GetDataTransforms()
        {
            return null;
        }

        public CampusActorLayout()
        {
        }
    }
}

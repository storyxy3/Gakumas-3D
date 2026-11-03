namespace Campus.Common
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
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

        [Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec
        {
            public static readonly _003C_003Ec _003C_003E9;
            public static Func<Data, Transform> _003C_003E9__10_0;
            public _003C_003Ec()
            {
            }

            internal Transform _003CGetDataTransforms_003Eb__10_0(Data data)
            {
                return null;
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

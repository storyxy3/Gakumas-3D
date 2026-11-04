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
            public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();
            public static Func<Data, Transform> _003C_003E9__10_0;
            public _003C_003Ec()
            {
            }

            internal Transform _003CGetDataTransforms_003Eb__10_0(Data data)
            {
                return data.root?.transform;
            }
        }

        [SerializeField]
        private Data[] _dataArray;
        private Transform[] _dataArrayTransformCaches;
        [SerializeField]
        private IAnimationPlayer _player;
        public static readonly string RootName = "ActorLayout";
        public IAnimationPlayer player
        {
            get
            {
                if (_player == null) TryGetComponent(out _player);
                return _player;
            }
        }

        public void ApplyToActors(IEnumerable<ICampusActorController> actors)
        {
            using (var enumerator = actors.GetEnumerator())
            {
                int index = 0;
                while (enumerator.MoveNext())
                {
                    if (index >= _dataArray.Length) break;
                    if (_dataArray[index] != null && global::VL.VLExtension.IsValid(enumerator.Current))
                        enumerator.Current.SetActorLayout(_dataArray[index].root.transform);
                    index++;
                }
            }
        }

        public static CampusActorLayout CreateActorLayout([Optional] Scene scene)
        {
            var layout = UnityEngine.Object.Instantiate(Resources.Load<CampusActorLayout>(RootName));
            layout.gameObject.name = RootName;
            if (scene.IsValid() && layout.gameObject.scene != scene) SceneManager.MoveGameObjectToScene(layout.gameObject, scene);
            return layout;
        }

        public Transform[] GetDataTransforms()
        {
            if (_dataArrayTransformCaches == null)
                _dataArrayTransformCaches = _dataArray == null ? Array.Empty<Transform>() : FasterLinq.Select(_dataArray, _003C_003Ec._003C_003E9__10_0 ?? (_003C_003Ec._003C_003E9__10_0 = _003C_003Ec._003C_003E9._003CGetDataTransforms_003Eb__10_0)).ToArray();
            return _dataArrayTransformCaches;
        }

        public CampusActorLayout()
        {
        }
    }
}

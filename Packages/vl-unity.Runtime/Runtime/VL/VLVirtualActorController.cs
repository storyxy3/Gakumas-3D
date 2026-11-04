namespace VL
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::UnityEngine;
    using global::UnityEngine.Animations;
    using global::VL;

    public abstract class VLVirtualActorController : MonoBehaviour
    {
        [Serializable]
        public struct BindData
        {
            public string name;
            public Transform transform;
        }

        public interface IBindResult
        {
            void LateUpdate(BindData data);
        }

        public class ErrorResult : IBindResult
        {
            public ErrorResult()
            {
                Debug.LogError("不明なBind");
            }

            public void LateUpdate(BindData data)
            {
            }
        }

        public class BoneResult : IBindResult
        {
            public Transform target;
            public float translationWeight;
            public float rotationWeight;
            public Vector3 translationOffset;
            public Vector3 rotationOffset;
            public BoneResult(BindData boneBind, Transform target, float translationWeight, float rotationWeight, Vector3 translationOffset, Vector3 rotationOffset)
            {
                this.target = target;
                this.translationOffset = translationOffset;
                this.rotationOffset = rotationOffset;
                this.translationWeight = translationWeight;
                this.rotationWeight = rotationWeight;
                if (boneBind.transform != null && target != null) SetupConstraint(boneBind);
            }

            private void SetupConstraint(BindData bone)
            {
                if (bone.transform.TryGetComponent<PositionConstraint>(out var position))
                {
                    // The original increments the index as sources are removed.
                    for (int i = 0; i < position.sourceCount; ++i) position.RemoveSource(i);
                }
                else position = bone.transform.gameObject.AddComponent<PositionConstraint>();
                position.AddSource(new ConstraintSource { sourceTransform = target, weight = translationWeight });
                position.constraintActive = true;
                position.translationOffset = translationOffset;
                position.locked = true;
                if (bone.transform.TryGetComponent<RotationConstraint>(out var rotation))
                {
                    for (int i = 0; i < rotation.sourceCount; ++i) rotation.RemoveSource(i);
                }
                else rotation = bone.transform.gameObject.AddComponent<RotationConstraint>();
                rotation.AddSource(new ConstraintSource { sourceTransform = target, weight = rotationWeight });
                rotation.constraintActive = true;
                rotation.rotationOffset = rotationOffset;
                rotation.locked = true;
            }

            public void LateUpdate(BindData data)
            {
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass14_0
        {
            public Transform boneTransform;
            public _003C_003Ec__DisplayClass14_0()
            {
            }

            internal bool _003CAddBone_003Eb__0(BindData x)
            {
                return x.transform == boneTransform;
            }
        }

        public int index;
        [SerializeField]
        private List<BindData> _binds = new List<BindData>();
        private List<IBindResult> _results;
        public static readonly string RootName = "VirtualActor_{0:00}";
        protected virtual Vector3 rootPosition
        {
            get
            {
                return transform.position;
            }
        }

        protected virtual Quaternion rootRotation
        {
            get
            {
                return transform.rotation;
            }
        }

        protected virtual void Setup()
        {
        }

        protected virtual IBindResult OnBind(BindData boneBind)
        {
            return new ErrorResult();
        }

        public void Bind()
        {
            if (_binds == null) return;
            _results = new List<IBindResult>(_binds.Count);
            for (int i = 0; i < _binds.Count; i++)
            {
                var result = OnBind(_binds[i]);
                if (result != null) _results.Add(result);
            }
        }

        protected void AddBone(string boneName)
        {
            var closure = new _003C_003Ec__DisplayClass14_0 { boneTransform = null };
            closure.boneTransform = transform.Find(boneName);
            if (closure.boneTransform == null)
            {
                closure.boneTransform = new GameObject(boneName).transform;
                closure.boneTransform.SetParent(transform);
            }
            if (_binds.Exists(closure._003CAddBone_003Eb__0)) return;
            _binds.Add(new BindData { name = boneName, transform = closure.boneTransform });
        }

        protected void AddBind(string bindName)
        {
            _binds.Add(new BindData { name = bindName });
        }

        protected void UnBind()
        {
            _binds.Clear();
            _results = null;
        }

        private void LateUpdate()
        {
            if (_binds == null || _results == null)
            {
                _ = Application.isPlaying;
                return;
            }
            transform.position = rootPosition;
            transform.rotation = rootRotation;
            for (int i = 0; i < _results.Count; i++)
            {
                var result = _results[i];
                var bind = _binds[i];
                result?.LateUpdate(bind);
            }
            OnLateUpdate();
        }

        protected virtual void OnLateUpdate()
        {
        }

        public static T Create<T>(int index)
            where T : VLVirtualActorController
        {
            Debug.Log("Create VirtualActor");
            var controller = new GameObject(string.Format(RootName, index)).AddComponent<T>();
            controller.index = index;
            controller.Setup();
            return controller;
        }

        protected VLVirtualActorController()
        {
        }
    }
}

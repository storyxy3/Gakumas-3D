namespace VL
{
    using global::System;
    using global::System.Collections.Generic;
    using global::UnityEngine;
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
            }

            private void SetupConstraint(BindData bone)
            {
            }

            public void LateUpdate(BindData data)
            {
            }
        }

        public int index;
        [SerializeField]
        private List<BindData> _binds;
        private List<IBindResult> _results;
        public static readonly string RootName;
        protected virtual Vector3 rootPosition
        {
            get
            {
                return default(Vector3);
            }
        }

        protected virtual Quaternion rootRotation
        {
            get
            {
                return default(Quaternion);
            }
        }

        protected virtual void Setup()
        {
        }

        protected virtual IBindResult OnBind(BindData boneBind)
        {
            return null;
        }

        public void Bind()
        {
        }

        protected void AddBone(string boneName)
        {
        }

        protected void AddBind(string bindName)
        {
        }

        protected void UnBind()
        {
        }

        private void LateUpdate()
        {
        }

        protected virtual void OnLateUpdate()
        {
        }

        public static T Create<T>(int index)
            where T : VLVirtualActorController
        {
            return null;
        }

        protected VLVirtualActorController()
        {
        }
    }
}

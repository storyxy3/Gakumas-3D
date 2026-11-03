namespace VL
{
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::UnityEngine;
    using global::VL;
    using global::VL.FaceSystem;

    [DefaultExecutionOrder(1000)]
    public class VLActorFaceTargetCorrection : MonoBehaviour
    {
        public interface IAngleTarget
        {
            void SetWeight(float weight);
        }

        public class SkinnedMeshAngleTarget : IAngleTarget
        {
            public SkinnedMeshRenderer renderer;
            public int targetIndex;
            public void SetWeight(float weight)
            {
            }

            public SkinnedMeshAngleTarget()
            {
            }
        }

        public class FaceModelAngleTarget : IAngleTarget
        {
            public VLActorFaceModel faceModel;
            public int targetIndex;
            public void SetWeight(float weight)
            {
            }

            public FaceModelAngleTarget()
            {
            }
        }

        private static readonly Dictionary<string, int> BLENDSHAPE_NAME_MAP;
        public Transform target;
        [Header("0:top45 1:under45 2:side45 3:side90")]
        public AnimationCurve[] angleCurve;
        private List<IAngleTarget>[] targets;
        private Vector3 _euler;
        private void OnEnable()
        {
        }

        private void OnDisable()
        {
        }

        private Vector3 ClampEuler(Vector3 euler)
        {
            return default(Vector3);
        }

        private void LateUpdate()
        {
        }

        public void UpdateTarget()
        {
        }

        public VLActorFaceTargetCorrection()
        {
        }

        [CompilerGenerated]
        internal static bool _003CUpdateTarget_003Eg__TryGetBlendShapeIndex_007C12_0(string blendShapeName, out int index)
        {
            throw null;
        }
    }
}

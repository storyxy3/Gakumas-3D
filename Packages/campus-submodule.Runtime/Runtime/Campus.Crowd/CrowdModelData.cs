namespace Campus.Crowd
{
    using global::System;
    using global::Campus.Crowd;
    using global::UnityEngine;

    [CreateAssetMenu(fileName = "CrowdModelData.asset", menuName = "Campus/Crowd/モデルデータ生成", order = 10001)]
    public class CrowdModelData : ScriptableObject
    {
        [Serializable]
        public class SubMeshData
        {
            public int indexCount;
            public int indexStart;
            public int vertexStart;
            public int vertexCount;
            public Material material;
            public SubMeshData()
            {
            }
        }

        [Serializable]
        public class MeshData
        {
            public Mesh mesh;
            public SubMeshData[] subMeshes;
            public MeshData()
            {
            }
        }

        [Serializable]
        public class CrowdVolumeBoneData
        {
            public int boneIndex;
            public Vector3 size;
            public CrowdVolumeBoneData()
            {
            }
        }

        public MeshData crowdMeshData;
        public MeshData penlightMeshData;
        public int[] penlightTypeWeights;
        public int[] penlightAmountWeights;
        public Avatar avatar;
        [SerializeField]
        private string[] bones;
        public int rightHandBoneIndex;
        public int leftHandBoneIndex;
        public int[] excludeBoundBoneIndexes;
        public CrowdVolumeBoneData[] volumeBoneDatas;
        [SerializeField]
        private Matrix4x4[] bindPoses;
        [SerializeField]
        private Vector4 boundingSphere;
        public string[] Bones
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public Matrix4x4[] BindPoses
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public Vector4 BoundingSphere
        {
            get
            {
                return default(Vector4);
            }

            set
            {
            }
        }

        public CrowdModelData()
        {
        }
    }
}

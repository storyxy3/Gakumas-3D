namespace Campus.Crowd
{
    using global::Campus.Crowd;
    using global::UnityEngine;

    public class CrowdData : ScriptableObject
    {
        public int version;
        public int length;
        public PersonInfo[] personInfos;
        public Bounds aabb;
        public OctreeInfo[] octreeInfos;
        public int subMeshCount;
        public CrowdData()
        {
        }
    }
}

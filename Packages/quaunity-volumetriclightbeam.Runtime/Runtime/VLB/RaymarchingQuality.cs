namespace VLB
{
    using global::System;
    using global::UnityEngine;
    using global::VLB;

    [Serializable]
    public class RaymarchingQuality
    {
        public string name;
        public int stepCount;
        [SerializeField]
        private int _UniqueID;
        private static RaymarchingQuality ms_DefaultInstance;
        private const int kRandomUniqueIdMinRange = 4;
        public int uniqueID
        {
            get
            {
                return default(int);
            }
        }

        private RaymarchingQuality(int uniqueID)
        {
        }

        public static RaymarchingQuality New(string name, int forcedUniqueID, int stepCount)
        {
            return null;
        }
    }
}

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
        private static RaymarchingQuality ms_DefaultInstance = new RaymarchingQuality(-1);
        private const int kRandomUniqueIdMinRange = 4;
        public int uniqueID
        {
            get
            {
                return _UniqueID;
            }
        }

        private RaymarchingQuality(int uniqueID)
        {
            name = "New quality";
            _UniqueID = uniqueID;
            stepCount = 10;
        }

        public static RaymarchingQuality New(string name, int forcedUniqueID, int stepCount)
        {
            return new RaymarchingQuality(forcedUniqueID) { name = name, stepCount = stepCount };
        }
    }
}

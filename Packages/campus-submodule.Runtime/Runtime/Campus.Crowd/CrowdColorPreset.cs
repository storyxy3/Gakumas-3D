namespace Campus.Crowd
{
    using global::System;
    using global::Campus.Crowd;
    using global::UnityEngine;

    [CreateAssetMenu(fileName = "CrowdColorPreset.asset", menuName = "Campus/Crowd/カラーリスト生成", order = 10000)]
    public class CrowdColorPreset : ScriptableObject
    {
        [Serializable]
        public class ColorType
        {
            public string name;
            [ColorUsage(false, true)]
            public Color color;
            public ColorType()
            {
            }
        }

        public ColorType[] colors;
        private void OnEnable()
        {
        }

        public CrowdColorPreset()
        {
        }
    }
}

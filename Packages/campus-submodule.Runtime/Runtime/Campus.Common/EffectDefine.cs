namespace Campus.Common
{
    using global::UnityEngine;

    [CreateAssetMenu(fileName = "EffectDefine", menuName = "Campus/EffectDefine")]
    public class EffectDefine : ScriptableObject
    {
        public Vector3 position;
        public Vector3 rotation;
        public Vector3 scale;
        [Header("親階層のスケール値の影響")]
        public ParticleSystemScalingMode scaleMode;
        [Header("エフェクトの発生ボーン名")]
        public string container;
        [Header("発生ボーンを親に設定しない")]
        public bool isNotSetParent;
        [Header("Prefab設定")]
        public GameObject prefab;
        [Header("再生時間設定")]
        public float lifeTime;
        private string _effectIdCache;
        public string EffectId
        {
            get
            {
                return null;
            }
        }

        public EffectDefine()
        {
        }
    }
}

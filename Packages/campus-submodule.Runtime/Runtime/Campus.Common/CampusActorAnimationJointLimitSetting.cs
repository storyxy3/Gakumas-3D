namespace Campus.Common
{
    using global::UnityEngine;

    [CreateAssetMenu(fileName = "ActorAnimationJointLimitSettings", menuName = "ActorAnimation/Joint Limit/Settings")]
    public class CampusActorAnimationJointLimitSetting : ScriptableObject
    {
        [Header("目の制限値")]
        [Tooltip("目の制限有効")]
        public bool eyeLimitEnable;
        [Range(0f, 2f)]
        [Tooltip("目の上方向の制限値")]
        public float eyeUpLimit;
        [Range(0f, -2f)]
        [Tooltip("目の下方向の制限値")]
        public float eyeDownLimit;
        public CampusActorAnimationJointLimitSetting()
        {
        }
    }
}

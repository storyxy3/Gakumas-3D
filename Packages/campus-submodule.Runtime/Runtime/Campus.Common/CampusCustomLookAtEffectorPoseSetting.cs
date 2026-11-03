namespace Campus.Common
{
    using global::Campus.Common;
    using global::UnityEngine;

    public class CampusCustomLookAtEffectorPoseSetting : ScriptableObject
    {
        [Range(0f, 1f)]
        public float weight;
        [Range(0f, 1f)]
        public float eyesWeight;
        [Range(0f, 1f)]
        public float headWeight;
        [Range(0f, 1f)]
        public float bodyWeight;
        [Range(0f, 2f)]
        public float eyeInOutLimit;
        [Range(0f, 2f)]
        public float eyeUpLimit;
        [Range(0f, -2f)]
        public float eyeDownLimit;
        [Range(0f, 2f)]
        public float headLeftRightLimit;
        [Range(0f, 2f)]
        public float headFrontLimit;
        [Range(0f, -2f)]
        public float headBackLimit;
        [Range(0f, 2f)]
        public float headRollLeftRightLimit;
        [Range(0f, 2f)]
        public float neckLeftRightLimit;
        [Range(0f, 2f)]
        public float neckFrontLimit;
        [Range(0f, -2f)]
        public float neckBackLimit;
        [Range(0f, 2f)]
        public float neckRollLeftRightLimit;
        [Range(0f, 2f)]
        public float bodyLeftRightLimit;
        [Range(0f, 2f)]
        public float bodyFrontLimit;
        [Range(0f, -2f)]
        public float bodyBackLimit;
        [Range(0f, 2f)]
        public float bodyTwistLeftRightLimit;
        [Range(0f, 1f)]
        [Tooltip("目の動きの有効度。目,頭,体の合計が1になるように設定してください。")]
        public float eyeEnableWeight;
        [Range(0f, 1f)]
        [Tooltip("頭の動きの有効度。目,頭,体の合計が1になるように設定してください。")]
        public float headEnableWeight;
        [Range(0f, 1f)]
        [Tooltip("体の動きの有効度。目,頭,体の合計が1になるように設定してください。")]
        public float bodyEnableWeight;
        public float lookAtInWeightSpeed;
        [SerializeField]
        [Tooltip("目標を向く目の動きのカーブ。両端を(0,0),(1,1)としてください。")]
        public AnimationCurve lookAtInEyeWeightCurve;
        [SerializeField]
        [Tooltip("目標を向く頭の動きのカーブ。両端を(0,0),(1,1)としてください。")]
        public AnimationCurve lookAtInHeadWeightCurve;
        [SerializeField]
        [Tooltip("目標を向く体の動きのカーブ。両端を(0,0),(1,1)としてください。")]
        public AnimationCurve lookAtInBodyWeightCurve;
        public float lookAtOutWeightSpeed;
        [SerializeField]
        [Tooltip("目標から戻る目の動きのカーブ。両端を(0,0),(1,任意)としてください。")]
        public AnimationCurve lookAtOutEyeWeightCurve;
        [SerializeField]
        [Tooltip("目標から戻る頭の動きのカーブ。両端を(0,0),(1,任意)としてください。")]
        public AnimationCurve lookAtOutHeadWeightCurve;
        [SerializeField]
        [Tooltip("目標から戻る体の動きのカーブ。両端を(0,0),(1,任意)としてください。")]
        public AnimationCurve lookAtOutBodyWeightCurve;
        [SerializeField]
        [Tooltip("目の補正")]
        public CampusCustomLookAtEyeCorrectionType customLookAtEyeCorrectionType;
        public CampusCustomLookAtEffectorPoseSetting()
        {
        }
    }
}

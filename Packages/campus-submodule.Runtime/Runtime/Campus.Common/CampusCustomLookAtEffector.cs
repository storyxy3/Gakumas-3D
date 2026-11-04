namespace Campus.Common
{
    using global::System;
    using global::System.Collections.Generic;
    using global::Campus.Common;
    using global::DG.Tweening;
    using global::UnityEngine;
    using global::VL.IK;

    [ExecuteAlways]
    public class CampusCustomLookAtEffector : CustomLookAtEffector
    {
        public enum EnableLimitWeightCalcType
        {
            EnableBool,
            EnableEaseWeightFromMaxSetting,
            CustomMethod
        }

        [Serializable]
        public class CampusCustomLookAtEffectorPoseSettingWeight
        {
            public float weight;
            public CampusCustomLookAtEffectorPoseSetting setting;
            public CampusCustomLookAtEffectorPoseSettingWeight()
            {
            }
        }

        public bool isEnableLookAt;
        public EnableLimitWeightCalcType enableLimitWeightCalcType;
        public Ease easeCurveEaseWeightFromMaxSetting = (Ease)4;
        public Func<float> enableLimitWeightCalcFunc;
        public float enableLimitWeight;
        [Range(0f, 2f)]
        public float eyeInOutLimit = 0.7f;
        [Range(0f, 2f)]
        public float eyeUpLimit = 0.7f;
        [Range(0f, 2f)]
        public float eyeDownLimit = 0.7f;
        [Range(0f, 2f)]
        public float headLeftRightLimit = 0.7f;
        [Range(0f, 2f)]
        public float headFrontLimit = 0.7f;
        [Range(0f, 2f)]
        public float headBackLimit = 0.7f;
        [Range(0f, 2f)]
        public float headRollLeftRightLimit = 0.7f;
        [Range(0f, 2f)]
        public float neckLeftRightLimit = 0.7f;
        [Range(0f, 2f)]
        public float neckFrontLimit = 0.7f;
        [Range(0f, 2f)]
        public float neckBackLimit = 0.7f;
        [Range(0f, 2f)]
        public float neckRollLeftRightLimit = 0.7f;
        [Range(0f, 2f)]
        public float bodyLeftRightLimit = 0.7f;
        [Range(0f, 2f)]
        public float bodyFrontLimit = 0.7f;
        [Range(0f, 2f)]
        public float bodyBackLimit = 0.7f;
        [Range(0f, 2f)]
        public float bodyTwistLeftRightLimit = 0.7f;
        public float sampleTime;
        public List<CampusCustomLookAtEffectorPoseSettingWeight> poseSettings = new List<CampusCustomLookAtEffectorPoseSettingWeight>();
        public CampusCustomLookAtEyeCorrectionType customLookAtEyeCorrectionType;
        private void OnEnable()
        {
        }

        private void Update()
        {
        }

        public void ResetInternalState()
        {
        }

        public void UpdateLimit()
        {
        }

        public void UpdateLookAtWeight()
        {
        }

        public bool IsPoseSettingsValid()
        {
            return default(bool);
        }

        public bool IsLookAtWeightValid()
        {
            return default(bool);
        }

        public bool IsLookAtWeightCurveValid()
        {
            return default(bool);
        }

        private bool IsLookAtInWeightCurveValid()
        {
            return default(bool);
        }

        private bool IsLookAtOutWeightCurveValid()
        {
            return default(bool);
        }

        private float GetLookAtInWeightSpeed()
        {
            return default(float);
        }

        private float GetLookAtOutWeightSpeed()
        {
            return default(float);
        }

        private float GetInEyesWeight()
        {
            return default(float);
        }

        private float GetInHeadWeight()
        {
            return default(float);
        }

        private float GetInBodyWeight()
        {
            return default(float);
        }

        private float GetOutEyesWeight()
        {
            return default(float);
        }

        private float GetOutHeadWeight()
        {
            return default(float);
        }

        private float GetOutBodyWeight()
        {
            return default(float);
        }

        public bool SetLookAtPoseSettingWeight(int index, float weight)
        {
            return default(bool);
        }

        public void LoadPoseSetting(CampusCustomLookAtEffectorPoseSetting poseSetting)
        {
        }

        public CampusCustomLookAtEffector()
        {
        }
    }
}

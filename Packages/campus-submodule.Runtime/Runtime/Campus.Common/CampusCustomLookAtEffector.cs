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
        public Ease easeCurveEaseWeightFromMaxSetting;
        public Func<float> enableLimitWeightCalcFunc;
        public float enableLimitWeight;
        [Range(0f, 2f)]
        public float eyeInOutLimit;
        [Range(0f, 2f)]
        public float eyeUpLimit;
        [Range(0f, 2f)]
        public float eyeDownLimit;
        [Range(0f, 2f)]
        public float headLeftRightLimit;
        [Range(0f, 2f)]
        public float headFrontLimit;
        [Range(0f, 2f)]
        public float headBackLimit;
        [Range(0f, 2f)]
        public float headRollLeftRightLimit;
        [Range(0f, 2f)]
        public float neckLeftRightLimit;
        [Range(0f, 2f)]
        public float neckFrontLimit;
        [Range(0f, 2f)]
        public float neckBackLimit;
        [Range(0f, 2f)]
        public float neckRollLeftRightLimit;
        [Range(0f, 2f)]
        public float bodyLeftRightLimit;
        [Range(0f, 2f)]
        public float bodyFrontLimit;
        [Range(0f, 2f)]
        public float bodyBackLimit;
        [Range(0f, 2f)]
        public float bodyTwistLeftRightLimit;
        public float sampleTime;
        public List<CampusCustomLookAtEffectorPoseSettingWeight> poseSettings;
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

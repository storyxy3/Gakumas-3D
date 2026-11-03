namespace Campus.Common
{
    using global::System.Runtime.InteropServices;
    using global::Campus.Common;
    using global::Campus.Common.Animation;
    using global::CriWare;
    using global::UnityEngine;
    using global::VL;
    using global::VL.Animation;
    using global::VL.IK;

    public interface ICampusActorController : IVLDefaultActorController<ICampusActorDescriptor>, IVLActorController<ICampusActorDescriptor>, IVLActorController, IVLTransform
    {
        float SweatWeight { set; }

        float HighlightWeight { set; }

        float TargetCorrectionWeight { set; }

        bool isDestroyed { get; }

        bool IsBuildSuccess { get; }

        float LookAtEyeSideCorrectionWeight { set; }

        float LookAtEyeSideCorrectionDeFactoWeight { get; }

        void EnableBakedSwingBone(MotionDefine motionDefine);
        void SetupPropConstraintAnimation(MotionDefine motionDefine);
        void SetupSeatedDynamicCorrection(MotionDefine motionDefine);
        void SetupAllIKGoalToOverrideTarget();
        void ResetAllIKGoalToOriginalTarget();
        void SetTalkActive(bool active);
        void PlayTalk(CriAtomSource source, bool lipSyncEnabled, [global::System.Runtime.InteropServices.Optional, global::System.Runtime.InteropServices.DefaultParameterValue(false)] bool skipPlayState, [Optional] VLTalkMotionSelector selector);
        void PlayTalk();
        void StopTalk();
        void UpdateTalkAdditive(float time, float weight);
        void ExecuteEyeBlink(bool forceBlink = false);
        void SetEyeBlinkWeight(float weight);
        void SetEyeBlinkEnable(bool enable);
        bool CanEyeBlink();
        CustomLookAtEffector GetCurrentCustomLookAtEffector();
        void SetCustomLookAt(Transform t);
        void SetCustomLookAt(Vector3 pos);
        void SetCampusCustomLookAtEffector(CampusCustomLookAtEffector effector);
        void ResetCustomLookAt();
        Vector3 GetFullBodyIkHeadOriginalPosition();
        Quaternion GetFullBodyIkHeadOriginalRotation();
        Vector3 GetFullBodyIkHeadOriginalForward();
        void DisableJointLimitSetting();
        void ResetDynamicSkin();
        void SetActorLayout(Transform actorLayout);
        float GetHumanScale();
        void SampleAnimation(AnimationClip clip, float time);
        CustomGraphAnimationPlayer GetCustomGraphAnimationPlayer();
        void SetAnimationEventActive(bool active);
        IAnimationController PlayMotion(MotionDefine motion);
        IAnimationController GetAnimationController(LayerParam param);
        IAnimationController GetPlayingAnimationController();
        void PlayEffect(HumanBodyBones targetBone, ParticleSystem effect);
        void StopEffects();
    }
}

namespace ActorAnimation
{
    using global::System.Collections.Generic;
    using global::ActorAnimation;
    using global::UnityEngine;
    using global::UnityEngine.Animations;
    using global::UnityEngine.Playables;

    public class ActorAnimationFullbodyIKSimpleInitializer : MonoBehaviour
    {
        public ActorAnimationIKBodyEffectorLocator bodyEffectorLocator;
        public ActorAnimationIKGoalEffectorLocator leftHandGoalEffectorLocator;
        public ActorAnimationIKGoalEffectorLocator rightHandGoalEffectorLocator;
        public ActorAnimationIKGoalEffectorLocator leftFootGoalEffectorLocator;
        public ActorAnimationIKGoalEffectorLocator rightFootGoalEffectorLocator;
        public ActorAnimationIKHintEffectorLocator leftElbowHintEffectorLocator;
        public ActorAnimationIKHintEffectorLocator rightElbowHintEffectorLocator;
        public ActorAnimationIKHintEffectorLocator leftKneeHintEffectorLocator;
        public ActorAnimationIKHintEffectorLocator rightKneeHintEffectorLocator;
        public ActorAnimationLookAtEffectorLocator lookAtEffectorLocator;
        public Transform move;
        public Transform reference;
        public Transform hips;
        public ActorAnimationFullBodyIKPullPartSetting pullPartSetting;
        public List<ActorAnimationIKCorrectionCollider> actorAnimationIKCorrectionColliders;
        public ActorAnimationIKCorrectionGoal rightHandCorrection;
        public ActorAnimationIKCorrectionGoal leftHandCorrection;
        public Animator _animator;
        private PlayableGraph graph;
        private AnimationScriptPlayable playable;
        private ActorAnimationFullBodyIKJobSkeleton skeleton;
        private void Awake()
        {
        }

        private void OnDestroy()
        {
        }

        public void CreateFullbodyIKJobSkeleton()
        {
        }

        public ActorAnimationFullbodyIKSimpleInitializer()
        {
        }
    }
}

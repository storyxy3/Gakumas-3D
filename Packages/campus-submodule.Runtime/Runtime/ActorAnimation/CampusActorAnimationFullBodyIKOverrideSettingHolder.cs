namespace ActorAnimation
{
    using global::System.Collections.Generic;
    using global::ActorAnimation;
    using global::UnityEngine;
    using global::VL.IK;

    public class CampusActorAnimationFullBodyIKOverrideSettingHolder : MonoBehaviour
    {
        public ActorAnimationIKHandleType iKHandleType;
        public EffectorBase[] overrideEffectorBases;
        public List<EffectorBase> OverrideEffectorBases(List<EffectorBase> originalEffectorBases)
        {
            for (int i = 0; i < originalEffectorBases.Count; i++)
            {
                for (int j = 0; j < overrideEffectorBases.Length; j++)
                {
                    if (originalEffectorBases[i] is IKGoalEffector goal && overrideEffectorBases[j] is IKGoalEffector overrideGoal)
                    {
                        if (goal.goal == overrideGoal.goal)
                        {
                            overrideGoal.HandleType = iKHandleType;
                            originalEffectorBases[i] = overrideGoal;
                        }
                    }
                    else if (originalEffectorBases[i] is IKHintEffector hint && overrideEffectorBases[j] is IKHintEffector overrideHint)
                    {
                        if (hint.hint == overrideHint.hint)
                        {
                            overrideHint.HandleType = iKHandleType;
                            originalEffectorBases[i] = overrideHint;
                        }
                    }
                    else if (originalEffectorBases[i] is IKBodyEffector && overrideEffectorBases[j] is IKBodyEffector overrideBody)
                    {
                        overrideBody.HandleType = iKHandleType;
                        originalEffectorBases[i] = overrideBody;
                    }
                }
            }
            return originalEffectorBases;
        }

        public CampusActorAnimationFullBodyIKOverrideSettingHolder()
        {
        }
    }
}

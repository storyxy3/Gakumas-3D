namespace VL.Unsafe.Jobs
{
    using global::Unity.Burst;
    using global::Unity.Collections;
    using global::Unity.Mathematics;
    using global::UnityEngine.Animations;
    using global::VL;
    using global::VL.Unsafe.Jobs;

    [BurstCompile]
    public struct VLActorExpressionJob : IAnimationJob
    {
        public NativeList<ExpressionData> expressions;
        public NativeList<MuscleExpressionData> muscleExpressions;
        public NativeList<JobUtility.Array2DInfo> expressionSymbolsInfo;
        public NativeList<ActorExpressionSymbol> expressionSymbols;
        public void ProcessAnimation(AnimationStream stream)
        {
        }

        private void ProcessStandardExpression(AnimationStream stream)
        {
        }

        private void ProcessMuscleExpression(AnimationStream stream)
        {
        }

        private unsafe void SetValue(float3 value, ExpressionData* e, AnimationStream output)
        {
        }

        public void ProcessRootMotion(AnimationStream stream)
        {
        }
    }
}

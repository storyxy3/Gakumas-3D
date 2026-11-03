namespace VL
{
    using global::Unity.Collections;
    using global::UnityEngine;
    using global::UnityEngine.Animations;
    using global::VL;
    using global::VL.Animation;
    using global::VL.Unsafe.Jobs;

    [ExecuteAlways]
    [AddComponentMenu("")]
    public class VLActorExpression : VLActorExtension
    {
        public const int ExpressionCapacity = 20;
        public const int MuscleExpressionCapacity = 4;
        public const int SymbolCapacity = 20;
        [SerializeField]
        private VLActorExpressionBone[] _expressionBones;
        private AnimationScriptPlayable _scriptPlayable;
        private IAnimationPlayer _animationPlayer;
        private NativeList<ExpressionData> _expressions;
        private NativeList<MuscleExpressionData> _muscleExpressions;
        private NativeList<JobUtility.Array2DInfo> _expressionSymbolsInfo;
        private NativeList<ActorExpressionSymbol> _expressionSymbols;
        private AnimationPlayableOutput _output;
        public override void Initialize()
        {
        }

        public bool Setup(VLActorExpressionBone[] expressionBones)
        {
            return default(bool);
        }

        public override void OnUpdate()
        {
        }

        public override void Dispose()
        {
        }

        public VLActorExpression()
        {
        }
    }
}

namespace VL
{
    using global::Unity.Mathematics;
    using global::UnityEngine.Animations;
    using global::VL;
    using global::VL.Unsafe.Jobs;

    public static class VLActorExpressionUtility
    {
        public static void ConvertTransAxis(string str, out VLActorExpressionBone.TransformType trans, out VLActorExpressionBone.AxisType axis)
        {
            throw null;
        }

        private static float3 ThreeAxisRot(float r11, float r12, float r21, float r31, float r32)
        {
            return default(float3);
        }

        public static float3 ToEuler(quaternion q, math.RotationOrder rotSeq)
        {
            return default(float3);
        }

        public unsafe static float3 GetReferenceValue(ExpressionData* e, AnimationStream input)
        {
            return default(float3);
        }

        public unsafe static float3 GetReferenceValue(int transformType, ExpressionData* e, AnimationStream input)
        {
            return default(float3);
        }

        public unsafe static float Execute(this ActorExpressionSymbolEnumerator enumerator, ExpressionData* e, AnimationStream input)
        {
            return default(float);
        }

        private unsafe static float Process(ref ActorExpressionSymbolEnumerator enumerator, ExpressionData* e, AnimationStream input)
        {
            return default(float);
        }
    }
}

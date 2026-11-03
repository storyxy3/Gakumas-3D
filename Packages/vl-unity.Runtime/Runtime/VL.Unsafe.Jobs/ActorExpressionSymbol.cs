namespace VL.Unsafe.Jobs
{
    using global::System;
    using global::UnityEngine.Animations;
    using global::VL.LimitedLisp;
    using global::VL.Unsafe.Jobs;

    [Serializable]
    public struct ActorExpressionSymbol : ISymbol<float>
    {
        public enum Method : short
        {
            Plus = 1,
            Multiply = 2,
            Minus = 3,
            Divide = 4,
            Abs = 100,
            ReferenceBone = 200
        }

        private Method _ope;
        private Argument _arg;
        private float _value;
        private short _transformType;
        private byte _axisType;
        public Method ope
        {
            get
            {
                return default(Method);
            }
        }

        public Argument arg
        {
            get
            {
                return default(Argument);
            }
        }

        public float value
        {
            get
            {
                return default(float);
            }
        }

        public void Initialize(string s)
        {
        }

        public unsafe float Process(ExpressionData* e, AnimationStream input)
        {
            return default(float);
        }

        public unsafe float Process(ExpressionData* e, AnimationStream input, float arg0)
        {
            return default(float);
        }

        public unsafe float Process(ExpressionData* e, AnimationStream input, float arg0, float arg1)
        {
            return default(float);
        }
    }
}

namespace Titan
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::Titan;
    using global::UnityEngine;

    public class ExpressionHolder
    {
        [Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec
        {
            public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();
            public static Func<ExpressionWithName, string> _003C_003E9__7_0;
            public static Func<ExpressionWithName, ExpressionWithName> _003C_003E9__7_1;
            public _003C_003Ec()
            {
            }

            internal string _003C_002Ector_003Eb__7_0(ExpressionWithName x)
            {
                return null;
            }

            internal ExpressionWithName _003C_002Ector_003Eb__7_1(ExpressionWithName x)
            {
                return null;
            }
        }

        private readonly ExpressionWithName[] _expressions;
        private Dictionary<string, ExpressionWithName> _nameToExpressions;
        [CompilerGenerated]
        private readonly UnityEngine.Object _003CLogHint_003Ek__BackingField;
        public UnityEngine.Object LogHint
        {
            [CompilerGenerated]
            get
            {
                return _003CLogHint_003Ek__BackingField;
            }
        }

        public ExpressionHolder(ExpressionWithName[] expressions, UnityEngine.Object logHint)
        {
        }

        public string GetExpression(string name)
        {
            return null;
        }

        public Value GetExpressionValue(string name, IValueResolver resolver)
        {
            return null;
        }
    }
}

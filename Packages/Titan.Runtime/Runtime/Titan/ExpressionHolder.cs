namespace Titan
{
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::Titan;
    using global::UnityEngine;

    public class ExpressionHolder
    {
        private readonly ExpressionWithName[] _expressions;
        private Dictionary<string, ExpressionWithName> _nameToExpressions;
        [CompilerGenerated]
        private readonly Object _003CLogHint_003Ek__BackingField;
        public Object LogHint
        {
            [CompilerGenerated]
            get
            {
                return null;
            }
        }

        public ExpressionHolder(ExpressionWithName[] expressions, Object logHint)
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

namespace Uguiss
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::System.Text.RegularExpressions;
    using global::Uguiss;

    public class Expression
    {
        private static class ErrorMessages
        {
            public static readonly string UnexpectedToken;
            public static readonly string UnexpectedNumber;
            public static readonly string UnexpectedString;
            public static readonly string UnexpectedIdentifier;
            public static readonly string UnexpectedEOS;
        }

        private static class Symbols
        {
            public static readonly string LParen;
            public static readonly string RParen;
            public static readonly string Not;
            public static readonly string Plus;
            public static readonly string Minus;
            public static readonly string Multiplication;
            public static readonly string Division;
            public static readonly string Modulo;
            public static readonly string Less;
            public static readonly string Greater;
            public static readonly string LessEqual;
            public static readonly string GreaterEqual;
            public static readonly string Equal;
            public static readonly string NotEqual;
            public static readonly string And;
            public static readonly string Or;
        }

        private enum TokenType
        {
            LParen,
            RParen,
            Operator,
            Operand,
            EOF
        }

        private abstract class Token
        {
            public static readonly EOFToken EOF;
            public abstract TokenType TokenType { get; }

            public abstract void Validate(Token left);
            protected Token()
            {
            }
        }

        private class EOFToken : Token
        {
            public override TokenType TokenType
            {
                get
                {
                    return default(TokenType);
                }
            }

            public override void Validate(Token left)
            {
            }

            public EOFToken()
            {
            }
        }

        private abstract class ParenToken : Token
        {
            public static readonly LParenToken Left;
            public static readonly RParenToken Right;
            public abstract string Symbol { get; }

            protected ParenToken()
            {
            }
        }

        private class LParenToken : ParenToken
        {
            public override TokenType TokenType
            {
                get
                {
                    return default(TokenType);
                }
            }

            public override string Symbol
            {
                get
                {
                    return null;
                }
            }

            public override void Validate(Token left)
            {
            }

            public override string ToString()
            {
                return null;
            }

            public LParenToken()
            {
            }
        }

        private class RParenToken : ParenToken
        {
            public override TokenType TokenType
            {
                get
                {
                    return default(TokenType);
                }
            }

            public override string Symbol
            {
                get
                {
                    return null;
                }
            }

            public override void Validate(Token left)
            {
            }

            public override string ToString()
            {
                return null;
            }

            public RParenToken()
            {
            }
        }

        private enum OperatorType
        {
            Not,
            Positive,
            Negative,
            Multiplication,
            Division,
            Modulo,
            Addition,
            Subtraction,
            Less,
            Greater,
            LessEqual,
            GreaterEqual,
            Equal,
            NotEqual,
            And,
            Or
        }

        private enum ArityType
        {
            Unary,
            Binary
        }

        private enum AssociativityType
        {
            Left,
            Right
        }

        private class OperatorToken : Token
        {
            [CompilerGenerated]
            private sealed class _003C_003Ec__DisplayClass1_0
            {
                public string symbol;
                public _003C_003Ec__DisplayClass1_0()
                {
                }

                internal bool _003CFind_003Eb__0(OperatorToken x)
                {
                    return default(bool);
                }
            }

            [CompilerGenerated]
            private sealed class _003C_003Ec__DisplayClass1_1
            {
                public ArityType arity;
                public _003C_003Ec__DisplayClass1_0 CS_0024_003C_003E8__locals1;
                public _003C_003Ec__DisplayClass1_1()
                {
                }

                internal bool _003CFind_003Eb__1(OperatorToken x)
                {
                    return default(bool);
                }
            }

            private static readonly List<OperatorToken> TokenList;
            [CompilerGenerated]
            private string _003CSymbol_003Ek__BackingField;
            [CompilerGenerated]
            private OperatorType _003CType_003Ek__BackingField;
            [CompilerGenerated]
            private ArityType _003CArity_003Ek__BackingField;
            [CompilerGenerated]
            private AssociativityType _003CAssociativity_003Ek__BackingField;
            [CompilerGenerated]
            private int _003CPriority_003Ek__BackingField;
            public override TokenType TokenType
            {
                get
                {
                    return default(TokenType);
                }
            }

            public string Symbol
            {
                [CompilerGenerated]
                get
                {
                    return null;
                }

                [CompilerGenerated]
                private set
                {
                }
            }

            public OperatorType Type
            {
                [CompilerGenerated]
                get
                {
                    return default(OperatorType);
                }

                [CompilerGenerated]
                private set
                {
                }
            }

            public ArityType Arity
            {
                [CompilerGenerated]
                get
                {
                    return default(ArityType);
                }

                [CompilerGenerated]
                private set
                {
                }
            }

            public AssociativityType Associativity
            {
                [CompilerGenerated]
                get
                {
                    return default(AssociativityType);
                }

                [CompilerGenerated]
                private set
                {
                }
            }

            public int Priority
            {
                [CompilerGenerated]
                get
                {
                    return default(int);
                }

                [CompilerGenerated]
                private set
                {
                }
            }

            public static OperatorToken Find(string symbol, Token left)
            {
                return null;
            }

            public OperatorToken(string symbol, OperatorType type, ArityType arity, AssociativityType associativity, int priority)
            {
            }

            public override void Validate(Token left)
            {
            }

            public override string ToString()
            {
                return null;
            }
        }

        public enum OperandType
        {
            Literal,
            Variable
        }

        private abstract class OperandToken : Token
        {
            public override TokenType TokenType
            {
                get
                {
                    return default(TokenType);
                }
            }

            public abstract OperandType Type { get; }

            protected OperandToken()
            {
            }
        }

        private class LiteralToken : OperandToken
        {
            [Serializable]
            [CompilerGenerated]
            private sealed class _003C_003Ec
            {
                public static readonly _003C_003Ec _003C_003E9;
                public static MatchEvaluator _003C_003E9__8_0;
                public _003C_003Ec()
                {
                }

                internal string _003CTryParseString_003Eb__8_0(Match match)
                {
                    return null;
                }
            }

            [CompilerGenerated]
            private Literal _003CLiteral_003Ek__BackingField;
            private static readonly Regex EscapeReplaceRegex;
            public override OperandType Type
            {
                get
                {
                    return default(OperandType);
                }
            }

            public Literal Literal
            {
                [CompilerGenerated]
                get
                {
                    return null;
                }

                [CompilerGenerated]
                private set
                {
                }
            }

            public static LiteralToken Parse(string token)
            {
                return null;
            }

            private static LiteralToken TryParseString(string token)
            {
                return null;
            }

            private static LiteralToken TryParseNumber(string token)
            {
                return null;
            }

            private static LiteralToken TryParseBoolean(string token)
            {
                return null;
            }

            private static LiteralToken TryParseNull(string token)
            {
                return null;
            }

            public override void Validate(Token left)
            {
            }

            public override string ToString()
            {
                return null;
            }

            public LiteralToken()
            {
            }
        }

        private class VariableToken : OperandToken
        {
            [CompilerGenerated]
            private string _003CVariableName_003Ek__BackingField;
            private static readonly Regex VariableRegex;
            public override OperandType Type
            {
                get
                {
                    return default(OperandType);
                }
            }

            public string VariableName
            {
                [CompilerGenerated]
                get
                {
                    return null;
                }

                [CompilerGenerated]
                private set
                {
                }
            }

            public static VariableToken Parse(string token)
            {
                return null;
            }

            public override void Validate(Token left)
            {
            }

            public VariableToken()
            {
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass11_0
        {
            public Expression _003C_003E4__this;
            public Stack<Literal> stack;
            public _003C_003Ec__DisplayClass11_0()
            {
            }

            internal void _003CEvaluate_003Eb__0(Token token)
            {
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass12_0
        {
            public Stack<Token> stack;
            public List<Token> outputs;
            public _003C_003Ec__DisplayClass12_0()
            {
            }

            internal void _003CParse_003Eb__0(Token token)
            {
            }
        }

        private static readonly Regex TokenSplitRegex;
        private Dictionary<string, Literal> _variableMap;
        static Expression()
        {
        }

        public bool VariableExists(string name)
        {
            return default(bool);
        }

        public Literal GetVariable(string name)
        {
            return null;
        }

        public void SetVariable(string name, string value)
        {
        }

        public void SetVariable(string name, bool value)
        {
        }

        public void RemoveAllVariables()
        {
        }

        public Literal Evaluate(string exp)
        {
            return null;
        }

        private List<Token> Parse(string exp)
        {
            return null;
        }

        private List<Token> Tokenize(string exp)
        {
            return null;
        }

        public Expression()
        {
        }
    }
}

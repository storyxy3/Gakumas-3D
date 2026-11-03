namespace Uguiss
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Text;
    using global::Uguiss;

    public class Parser
    {
        [Flags]
        private enum Symbol
        {
            None = 0,
            SingleLineCommand = 1,
            CommandStart = 2,
            CommandEnd = 4,
            ParameterSeparator = 8,
            ExpressionStart = 0x10,
            ExpressionEnd = 0x20,
            NewLine = 0x40,
            SingleLineComment = 0x80,
            CommentStart = 0x100,
            CommentEnd = 0x200,
            SingleLineCommandReader = 0x1C2,
            MultiLineCommandReader = 0x186,
            CommandParameterReader = 0x1A
        }

        private static class Symbols
        {
        }

        private class State
        {
            public bool success;
            public int position;
            public string value;
            public State()
            {
            }
        }

        private static readonly char[] EscapeSequences;
        private const char ElementSeparatorCharacter = ' ';
        private const char EscapeCharacter = '\\';
        private const char StringLiteralCharacter = '"';
        private readonly Engine _engine;
        private readonly StringBuilder _builder;
        public Parser(Engine engine)
        {
        }

        public List<AbstractCommand> Parse(string script)
        {
            return null;
        }

        private void ClearBuilder()
        {
        }

        private static (Symbol, int) FindSymbol(Symbol targets, string source, int position)
        {
            return default((Symbol, int));
        }

        private static bool IsMatchSymbol(Symbol targets, string source, int position)
        {
            return default(bool);
        }

        private static Symbol ParseSymbol(string source, int position)
        {
            return default(Symbol);
        }

        private static int GetSymbolLength(Symbol symbol)
        {
            return default(int);
        }

        private bool IsEscaped(string source, int position)
        {
            return default(bool);
        }

        private State ReadSingleLineCommand(string source, int position)
        {
            return null;
        }

        private State ReadMultiLineCommand(string source, int position, bool capture = false)
        {
            return null;
        }

        private State ReadSingleLineComment(string source, int position)
        {
            return null;
        }

        private State ReadMultiLineComment(string source, int position)
        {
            return null;
        }

        private State ReadExpression(string source, int position, bool capture = false)
        {
            return null;
        }

        private AbstractCommand ParseCommand(string source)
        {
            return null;
        }

        private static (int, int) FindSeparatorPosition(string source, int position, int length)
        {
            return default((int, int));
        }

        private AbstractCommand ParseAliasCommand(string source)
        {
            return null;
        }

        public ParameterData ParseParameter(string source)
        {
            return null;
        }

        private string UnescapeParameter(string source, bool expression = false)
        {
            return null;
        }

        private string ToExpressionString(string source)
        {
            return null;
        }
    }
}

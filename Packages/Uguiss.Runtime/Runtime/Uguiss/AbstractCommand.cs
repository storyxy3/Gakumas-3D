namespace Uguiss
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Reflection;
    using global::System.Runtime.CompilerServices;
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Uguiss;

    public abstract class AbstractCommand
    {
        [AttributeUsage(AttributeTargets.Class, Inherited = false)]
        protected class CommandAttribute : Attribute
        {
            [CompilerGenerated]
            private string _003CCategory_003Ek__BackingField;
            [CompilerGenerated]
            private string _003CName_003Ek__BackingField;
            [CompilerGenerated]
            private string _003CDescription_003Ek__BackingField;
            [CompilerGenerated]
            private CommandType _003CCommandType_003Ek__BackingField;
            public string Category
            {
                [CompilerGenerated]
                set
                {
                    _003CCategory_003Ek__BackingField = value;
                }
            }

            public string Name
            {
                [CompilerGenerated]
                set
                {
                    _003CName_003Ek__BackingField = value;
                }
            }

            public string Description
            {
                [CompilerGenerated]
                set
                {
                    _003CDescription_003Ek__BackingField = value;
                }
            }

            public CommandType CommandType
            {
                [CompilerGenerated]
                set
                {
                    _003CCommandType_003Ek__BackingField = value;
                }
            }

            public CommandAttribute(string category, string name, string description, CommandType commandType = CommandType.Main)
            {
            }
        }

        [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
        protected class ParameterAttribute : Attribute
        {
            [CompilerGenerated]
            private bool _003CRequired_003Ek__BackingField;
            [CompilerGenerated]
            private string _003CName_003Ek__BackingField;
            [CompilerGenerated]
            private string _003CDescription_003Ek__BackingField;
            [CompilerGenerated]
            private string _003CDefaultValue_003Ek__BackingField;
            [CompilerGenerated]
            private bool _003CHideInInspector_003Ek__BackingField;
            public bool Required
            {
                [CompilerGenerated]
                get
                {
                    return _003CRequired_003Ek__BackingField;
                }

                [CompilerGenerated]
                set
                {
                    _003CRequired_003Ek__BackingField = value;
                }
            }

            public string Name
            {
                [CompilerGenerated]
                get
                {
                    return _003CName_003Ek__BackingField;
                }
            }

            public string Description
            {
                [CompilerGenerated]
                set
                {
                    _003CDescription_003Ek__BackingField = value;
                }
            }

            public string DefaultValue
            {
                [CompilerGenerated]
                set
                {
                    _003CDefaultValue_003Ek__BackingField = value;
                }
            }

            public bool HideInInspector
            {
                [CompilerGenerated]
                set
                {
                    _003CHideInInspector_003Ek__BackingField = value;
                }

                // TODO(qa-recon): Getter stripped from game metadata; required for C# interface/attribute compilation.
                get
                {
                    throw null;
                }
            }

            public ParameterAttribute()
            {
            }

            public ParameterAttribute(bool required, string description, string defaultValue)
            {
            }
        }

        [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
        protected class RequiredParameterAttribute : ParameterAttribute
        {
            public RequiredParameterAttribute()
            {
            }

            public RequiredParameterAttribute(string description, string defaultValue = "")
            {
            }
        }

        [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
        protected class OptionalParameterAttribute : ParameterAttribute
        {
            public OptionalParameterAttribute()
            {
            }

            public OptionalParameterAttribute(string description, string defaultValue = "")
            {
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass27_0
        {
            public Dictionary<MemberInfo, ParameterAttribute> parameterMap;
            public _003C_003Ec__DisplayClass27_0()
            {
            }

            internal void _003CGetParameterMap_003Eb__0(MemberInfo member)
            {
            }
        }

        [OptionalParameter("GroupLength", "", HideInInspector = true)]
        internal FloatParameter groupLength;
        private static readonly Dictionary<Type, Dictionary<MemberInfo, ParameterAttribute>> ParameterCache;
        [CompilerGenerated]
        private List<AbstractParameter> _003CParameters_003Ek__BackingField;
        [CompilerGenerated]
        private Engine _003CEngine_003Ek__BackingField;
        [CompilerGenerated]
        private bool _003CIsInvalid_003Ek__BackingField;
        [CompilerGenerated]
        private bool _003CIsActive_003Ek__BackingField;
        public int GroupLength
        {
            get
            {
                return default(int);
            }
        }

        public virtual bool IsGroupCommand
        {
            get
            {
                return default(bool);
            }
        }

        public List<AbstractParameter> Parameters
        {
            [CompilerGenerated]
            get
            {
                return _003CParameters_003Ek__BackingField;
            }

            [CompilerGenerated]
            protected set
            {
                _003CParameters_003Ek__BackingField = value;
            }
        }

        public Engine Engine
        {
            [CompilerGenerated]
            get
            {
                return _003CEngine_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CEngine_003Ek__BackingField = value;
            }
        }

        public bool IsInvalid
        {
            [CompilerGenerated]
            get
            {
                return _003CIsInvalid_003Ek__BackingField;
            }

            [CompilerGenerated]
            protected set
            {
                _003CIsInvalid_003Ek__BackingField = value;
            }
        }

        public bool IsActive
        {
            [CompilerGenerated]
            get
            {
                return _003CIsActive_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CIsActive_003Ek__BackingField = value;
            }
        }

        public bool IsExecutable
        {
            get
            {
                return default(bool);
            }
        }

        public List<AbstractCommand> GetCommandsInGroup()
        {
            return null;
        }

        private int OffsetIndexRecursive(int index)
        {
            return default(int);
        }

        public void Initialize(Engine engine, List<KeyValuePair<string, string>> paramList)
        {
        }

        private static Dictionary<MemberInfo, ParameterAttribute> GetParameterMap(Type commandType)
        {
            return null;
        }

        private void InitializeParameters(List<KeyValuePair<string, string>> paramList)
        {
        }

        private AbstractParameter AddParameter(Type type, bool required, string name, List<KeyValuePair<string, string>> paramList)
        {
            return null;
        }

        protected virtual void OnInitialize()
        {
        }

        public virtual UniTask PreExecuteAsync(CancellationToken cancellationToken)
        {
            return default(UniTask);
        }

        public virtual UniTask ExecuteAsync(CancellationToken cancellationToken)
        {
            return default(UniTask);
        }

        public void ValidateParameters()
        {
        }

        protected AbstractCommand()
        {
        }
    }
}

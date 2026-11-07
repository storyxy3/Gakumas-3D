namespace Uguiss
{
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::Uguiss;

    public class AbstractParameter
    {
        [CompilerGenerated]
        private bool _003CRequired_003Ek__BackingField;
        [CompilerGenerated]
        private string _003CName_003Ek__BackingField;
        [CompilerGenerated]
        private Engine _003CEngine_003Ek__BackingField;
        [CompilerGenerated]
        private List<string> _003CRawValues_003Ek__BackingField;
        public bool Required
        {
            [CompilerGenerated]
            get
            {
                return _003CRequired_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
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

            [CompilerGenerated]
            private set
            {
                _003CName_003Ek__BackingField = value;
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

        public List<string> RawValues
        {
            [CompilerGenerated]
            get
            {
                return _003CRawValues_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CRawValues_003Ek__BackingField = value;
            }
        }

        public string RawValue
        {
            get
            {
                return null;
            }
        }

        public bool HasValue
        {
            get
            {
                return default(bool);
            }
        }

        public void Initialize(bool required, string name, Engine engine)
        {
        }

        public void AddValue(string value = "")
        {
        }

        public void RemoveAllValues()
        {
        }

        public AbstractParameter()
        {
        }
    }
}

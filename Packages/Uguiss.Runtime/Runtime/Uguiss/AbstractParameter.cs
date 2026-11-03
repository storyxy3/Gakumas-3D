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
                return default(bool);
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public string Name
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

        public Engine Engine
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

        public List<string> RawValues
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

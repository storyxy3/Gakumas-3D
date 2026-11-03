namespace Titan
{
    using global::System;
    using global::System.Runtime.InteropServices;
    using global::Titan;
    using global::UnityEngine;

    [Serializable]
    public class VariableDefinition
    {
        [SerializeField]
        private string _name;
        [SerializeField]
        private int _type;
        [SerializeField]
        private float _number;
        [SerializeField]
        private UnityEngine.Object _unityObject;
        [SerializeReference]
        private object _object;
        private object _value;
        private static VariableInputHandler _variableInputHandler;
        public string Name
        {
            get
            {
                return null;
            }
        }

        public object GetValueObject(IValueResolver resolver, [Optional] object logHint)
        {
            return null;
        }

        public void ResetCache()
        {
        }

        public VariableDefinition()
        {
        }
    }
}

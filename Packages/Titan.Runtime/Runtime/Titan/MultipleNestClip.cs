namespace Titan
{
    using global::System.Collections.Generic;
    using global::Titan;
    using global::UnityEngine;

    public class MultipleNestClip : LoopableTweenClip, IVariableDefinitionHolder
    {
        [SerializeField]
        private float _delay;
        [SerializeField]
        private bool _ignoreInactive;
        [SerializeField]
        private string _groupName;
        [SerializeField]
        private VariableDefinition[] _variables;
        public float Delay
        {
            get
            {
                return default(float);
            }
        }

        public bool IgnoreInactive
        {
            get
            {
                return default(bool);
            }
        }

        public string GroupName
        {
            get
            {
                return null;
            }
        }

        public override bool IsFixedDuration
        {
            get
            {
                return default(bool);
            }
        }

        public IList<VariableDefinition> Variables
        {
            get
            {
                return null;
            }
        }

        public string GetGroupName(IValueResolver resolver)
        {
            return null;
        }

        public MultipleNestClip()
        {
        }
    }
}

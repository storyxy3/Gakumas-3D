namespace Titan
{
    using global::System.Collections.Generic;
    using global::Titan;
    using global::UnityEngine;

    public class NestClip : LoopableTweenClip, IVariableDefinitionHolder
    {
        [SerializeField]
        private string _groupName;
        [SerializeField]
        private VariableDefinition[] _variables;
        [SerializeField]
        private float _timeScale;
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

        public float GetTimeScale(IValueResolver resolver)
        {
            return default(float);
        }

        public string GetGroupName(IValueResolver resolver)
        {
            return null;
        }

        public NestClip()
        {
        }
    }
}

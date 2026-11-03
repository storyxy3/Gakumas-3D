namespace VL
{
    using global::System;
    using global::System.Collections.Generic;

    [Serializable]
    public class AnimationBindingData
    {
        public string name;
        public string path;
        public string type;
        public List<string> properties;
        public AnimationBindingData()
        {
        }
    }
}

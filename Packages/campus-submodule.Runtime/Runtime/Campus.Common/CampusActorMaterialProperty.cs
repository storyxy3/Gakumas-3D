namespace Campus.Common
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::UnityEngine;

    [Serializable]
    public class CampusActorMaterialProperty
    {
        public string materialName;
        public Texture col;
        public Texture sdw;
        public Texture def;
        public int tileX = 1;
        public int tileY = 1;
        public int tileFPS = 1;
        [CompilerGenerated]
        private double _003CCurrentTime_003Ek__BackingField;
        public double CurrentTime
        {
            [CompilerGenerated]
            get
            {
                return _003CCurrentTime_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CCurrentTime_003Ek__BackingField = value;
            }
        }

        public CampusActorMaterialProperty()
        {
        }
    }
}

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
        public int tileX;
        public int tileY;
        public int tileFPS;
        [CompilerGenerated]
        private double _003CCurrentTime_003Ek__BackingField;
        public double CurrentTime
        {
            [CompilerGenerated]
            get
            {
                return default(double);
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public CampusActorMaterialProperty()
        {
        }
    }
}

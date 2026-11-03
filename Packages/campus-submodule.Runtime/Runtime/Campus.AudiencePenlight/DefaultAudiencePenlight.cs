namespace Campus.AudiencePenlight
{
    using global::System.Runtime.CompilerServices;
    using global::Campus.AudiencePenlight;
    using global::UnityEngine;

    public class DefaultAudiencePenlight : IAudiencePenlight
    {
        [CompilerGenerated]
        private readonly bool _003CUseColorProjection_003Ek__BackingField;
        [CompilerGenerated]
        private readonly Vector4[] _003CColorTable_003Ek__BackingField;
        [CompilerGenerated]
        private readonly Vector2 _003CProjectionUvRectMin_003Ek__BackingField;
        [CompilerGenerated]
        private readonly Vector2 _003CProjectionUvRectMax_003Ek__BackingField;
        public bool UseColorProjection
        {
            [CompilerGenerated]
            get
            {
                return default(bool);
            }
        }

        public Vector4[] ColorTable
        {
            [CompilerGenerated]
            get
            {
                return null;
            }
        }

        public Vector2 ProjectionUvRectMin
        {
            [CompilerGenerated]
            get
            {
                return default(Vector2);
            }
        }

        public Vector2 ProjectionUvRectMax
        {
            [CompilerGenerated]
            get
            {
                return default(Vector2);
            }
        }

        public DefaultAudiencePenlight(params Color[] colors)
        {
        }
    }
}

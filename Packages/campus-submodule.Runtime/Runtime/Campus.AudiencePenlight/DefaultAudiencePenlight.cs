// TODO(qa-recon): Selected APK bodies still need reconstruction: .ctor, get_ProjectionUvRectMax, get_ProjectionUvRectMin.
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
                return _003CUseColorProjection_003Ek__BackingField;
            }
        }

        public Vector4[] ColorTable
        {
            [CompilerGenerated]
            get
            {
                return _003CColorTable_003Ek__BackingField;
            }
        }

        public Vector2 ProjectionUvRectMin
        {
            [CompilerGenerated]
            get
            {
                return _003CProjectionUvRectMin_003Ek__BackingField;
            }
        }

        public Vector2 ProjectionUvRectMax
        {
            [CompilerGenerated]
            get
            {
                return _003CProjectionUvRectMax_003Ek__BackingField;
            }
        }

        public DefaultAudiencePenlight(params Color[] colors)
        {
            _003CUseColorProjection_003Ek__BackingField = false;
            _003CProjectionUvRectMin_003Ek__BackingField = Vector2.zero;
            _003CProjectionUvRectMax_003Ek__BackingField = Vector2.zero;
            if (global::Qua.Extensions.IEnumerableExtensions.IsNullOrEmpty(colors)) colors = new[] { Color.white };
            _003CColorTable_003Ek__BackingField = new Vector4[8];
            for (int i = 0; i < 8; i++) _003CColorTable_003Ek__BackingField[i] = colors[i % colors.Length];
        }
    }
}

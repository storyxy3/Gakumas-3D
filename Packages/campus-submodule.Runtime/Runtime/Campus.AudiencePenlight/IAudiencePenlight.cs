namespace Campus.AudiencePenlight
{
    using global::UnityEngine;

    public interface IAudiencePenlight
    {
        bool UseColorProjection { get; }

        Vector4[] ColorTable { get; }

        Vector2 ProjectionUvRectMin { get; }

        Vector2 ProjectionUvRectMax { get; }
    }
}

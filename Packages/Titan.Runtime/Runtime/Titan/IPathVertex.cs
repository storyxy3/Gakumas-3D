namespace Titan
{
    using global::UnityEngine;

    public interface IPathVertex
    {
        Vector3 TargetPoint { get; }

        Vector3 InController { get; }

        Vector3 OutController { get; }
    }
}

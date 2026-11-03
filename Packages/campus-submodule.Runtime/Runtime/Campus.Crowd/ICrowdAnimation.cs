namespace Campus.Crowd
{
    using global::Unity.Collections;
    using global::UnityEngine;

    public interface ICrowdAnimation
    {
        NativeArray<Matrix4x4> Matrices { get; }

        NativeArray<Matrix4x4> RawMatrices { get; }

        NativeArray<Bounds> Bounds { get; }
    }
}

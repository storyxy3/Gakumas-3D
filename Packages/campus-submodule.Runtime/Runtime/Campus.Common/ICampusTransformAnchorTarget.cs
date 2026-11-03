namespace Campus.Common
{
    using global::Campus.Common;
    using global::UnityEngine;

    public interface ICampusTransformAnchorTarget : ICampusTransformAnchor
    {
        void SetTarget(Transform value);
    }
}

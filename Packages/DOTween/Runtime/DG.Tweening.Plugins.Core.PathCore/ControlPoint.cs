namespace DG.Tweening.Plugins.Core.PathCore
{
    using global::System;
    using global::DG.Tweening.Plugins.Core.PathCore;
    using global::UnityEngine;

    [Serializable]
    public struct ControlPoint
    {
        public Vector3 a;
        public Vector3 b;
        public ControlPoint(Vector3 a, Vector3 b)
        {
            this = default;
        }

        public static ControlPoint operator +(ControlPoint cp, Vector3 v)
        {
            return default(ControlPoint);
        }

        public override string ToString()
        {
            return null;
        }
    }
}

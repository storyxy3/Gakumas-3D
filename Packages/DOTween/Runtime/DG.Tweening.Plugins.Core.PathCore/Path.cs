namespace DG.Tweening.Plugins.Core.PathCore
{
    using global::System;
    using global::System.Runtime.InteropServices;
    using global::DG.Tweening;
    using global::DG.Tweening.Plugins.Core.PathCore;
    using global::UnityEngine;

    [Serializable]
    public class Path
    {
        private static CatmullRomDecoder _catmullRomDecoder;
        private static LinearDecoder _linearDecoder;
        private static CubicBezierDecoder _cubicBezierDecoder;
        public float[] wpLengths;
        [SerializeField]
        public Vector3[] wps;
        [SerializeField]
        internal PathType type;
        [SerializeField]
        internal int subdivisionsXSegment;
        [SerializeField]
        internal int subdivisions;
        [SerializeField]
        internal ControlPoint[] controlPoints;
        [SerializeField]
        internal float length;
        [SerializeField]
        internal bool isFinalized;
        [SerializeField]
        internal float[] timesTable;
        [SerializeField]
        internal float[] lengthsTable;
        internal int linearWPIndex;
        internal bool addedExtraStartWp;
        internal bool addedExtraEndWp;
        private Path _incrementalClone;
        private int _incrementalIndex;
        private ABSPathDecoder _decoder;
        private bool _changed;
        internal Vector3[] nonLinearDrawWps;
        internal Vector3 targetPosition;
        internal Vector3? lookAtPosition;
        internal Color gizmoColor;
        public Path(PathType type, Vector3[] waypoints, int subdivisionsXSegment, [Optional] Color? gizmoColor)
        {
        }

        internal Path()
        {
        }

        internal void FinalizePath(bool isClosedPath, AxisConstraint lockPositionAxes, Vector3 currTargetVal)
        {
        }

        internal Vector3 GetPoint(float perc, bool convertToConstantPerc = false)
        {
            return default(Vector3);
        }

        internal float ConvertToConstantPathPerc(float perc)
        {
            return default(float);
        }

        internal int GetWaypointIndexFromPerc(float perc, bool isMovingForward)
        {
            return default(int);
        }

        internal static void RefreshNonLinearDrawWps(Path p)
        {
        }

        internal void Destroy()
        {
        }

        internal Path CloneIncremental(int loopIncrement)
        {
            return null;
        }

        internal void AssignWaypoints(Vector3[] newWps, bool cloneWps = false)
        {
        }

        internal void AssignDecoder(PathType pathType)
        {
        }

        internal void Draw()
        {
        }

        private static void Draw(Path p)
        {
        }
    }
}

namespace VLB
{
    using global::System;
    using global::Unity.Collections;
    using global::Unity.Mathematics;
    using global::UnityEngine;
    using global::VLB;

    public static class Utils
    {
        public enum FloatPackingPrecision
        {
            High = 64,
            Low = 8,
            Undef = 0
        }

        private static FloatPackingPrecision ms_FloatPackingPrecision;
        public static float ComputeConeRadiusEnd(float fallOffEnd, float spotAngle)
        {
            return Mathf.Tan(spotAngle * Mathf.Deg2Rad * 0.5f) * fallOffEnd;
        }

        public static float ComputeSpotAngle(float fallOffEnd, float coneRadiusEnd)
        {
            return Mathf.Atan2(coneRadiusEnd, fallOffEnd) * Mathf.Rad2Deg * 2f;
        }

        public static string GetPath(Transform current)
        {
            return null;
        }

        public static T NewWithComponent<T>(string name)
            where T : Component
        {
            return null;
        }

        public static T GetOrAddComponent<T>(this GameObject self)
            where T : Component
        {
            return null;
        }

        public static T GetOrAddComponent<T>(this MonoBehaviour self)
            where T : Component
        {
            return null;
        }

        public static void ForeachComponentsInDirectChildrenOnly<T>(this GameObject self, Action<T> lambda, bool includeInactive = false)
            where T : Component
        {
        }

        public static void SetupDepthCamera(Camera depthCamera, float coneApexOffsetZ, float maxGeometryDistance, float coneRadiusStart, float coneRadiusEnd, Vector3 beamLocalForward, Vector3 lossyScale, bool isScalable, Quaternion beamInternalLocalRotation, bool shouldScaleMinNearClipPlane)
        {
        }

        public static Vector3 Divide(this Vector3 aVector, Vector3 scale)
        {
            return default(Vector3);
        }

        public static Vector2 xy(this Vector3 aVector)
        {
            return default(Vector2);
        }

        public static bool Approximately(this float a, float b, float epsilon = 1E-05f)
        {
            return default(bool);
        }

        public static bool Approximately(this Vector2 a, Vector2 b, float epsilon = 1E-05f)
        {
            return (a - b).sqrMagnitude < epsilon;
        }

        public static Vector4 AsVector4(this Vector3 vec3, float w)
        {
            return default(Vector4);
        }

        public static Vector4 PlaneEquation(Vector3 normalizedNormal, Vector3 pt)
        {
            return new Vector4(normalizedNormal.x, normalizedNormal.y, normalizedNormal.z, -Vector3.Dot(normalizedNormal, pt));
        }

        public static float GetMaxArea2D(this Bounds self)
        {
            return default(float);
        }

        public static Plane TranslateCustom(this Plane plane, Vector3 translation)
        {
            return default(Plane);
        }

        public static Vector3 ClosestPointOnPlaneCustom(this Plane plane, Vector3 point)
        {
            return default(Vector3);
        }

        public static bool IsAlmostZero(float f)
        {
            return default(bool);
        }

        public static bool IsValid(this Plane plane)
        {
            return default(bool);
        }

        public static void SetKeywordEnabled(this Material mat, string name, bool enabled)
        {
            if (enabled)
                mat.EnableKeyword(name);
            else
                mat.DisableKeyword(name);
        }

        public static Matrix4x4 SampleInMatrix(this Gradient self, int floatPackingPrecision)
        {
            Matrix4x4 matrix = new Matrix4x4();
            for (int i = 0; i < 16; ++i)
                matrix[i] = self.Evaluate(Mathf.Clamp01(i / 15f)).PackToFloat(floatPackingPrecision);
            return matrix;
        }

        private static Vector4 Vector4_Floor(Vector4 vec)
        {
            return default(Vector4);
        }

        public static float PackToFloat(this Color color, int floatPackingPrecision)
        {
            float precision = floatPackingPrecision;
            float scale = floatPackingPrecision - 1;
            float packed = 0f;
            packed += Mathf.Floor(color.r * scale) * precision * precision * precision;
            packed += Mathf.Floor(color.g * scale) * precision * precision;
            packed += Mathf.Floor(color.b * scale) * precision;
            packed += Mathf.Floor(color.a * scale);
            return packed;
        }

        public static FloatPackingPrecision GetFloatPackingPrecision()
        {
            if (ms_FloatPackingPrecision == FloatPackingPrecision.Undef)
                ms_FloatPackingPrecision = SystemInfo.graphicsShaderLevel >= 35 ? FloatPackingPrecision.High : FloatPackingPrecision.Low;
            return ms_FloatPackingPrecision;
        }

        public static bool HasAtLeastOneFlag(this Enum mask, Enum flags)
        {
            return default(bool);
        }

        public static void MarkCurrentSceneDirty()
        {
        }

        public static Bounds TransformAABB(Bounds bounds, float4x4 transform)
        {
            return default(Bounds);
        }

        public static Plane GetPlane(Vector4 vector)
        {
            return default(Plane);
        }

        public static void CalcCullingPlane(NativeArray<Plane> planes, Matrix4x4 vpMatrix)
        {
        }

        public static bool TestPlanesAABB(NativeArray<Plane> planes, Bounds bounds)
        {
            return default(bool);
        }
    }
}

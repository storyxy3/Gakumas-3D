namespace Campus.Crowd
{
    using global::Campus.Crowd;
    using global::UnityEngine;
    using global::UnityEngine.Rendering.Universal;

    public class CrowdRenderingSetupData
    {
        public Matrix4x4 ViewProjMatrix;
        public Vector3 CameraPos;
        public Vector3 CameraForward;
        public float HeightOcclusion;
        public Vector4 CrowdParams;
        public Vector3 CrowdLookAt;
        public float CrowdRandomLookAtWeight;
        public Vector4 OcclusionSphere;
        public void Update(in CameraData cameraData, bool useMainCamera, Crowd crowd)
        {
        }

        public CrowdRenderingSetupData()
        {
        }
    }
}

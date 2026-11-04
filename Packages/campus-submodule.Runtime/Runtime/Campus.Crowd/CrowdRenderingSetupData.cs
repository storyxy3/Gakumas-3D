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
            ViewProjMatrix = cameraData.GetProjectionMatrix() * cameraData.GetViewMatrix();
            CameraPos = cameraData.worldSpaceCameraPos;
            CameraForward = cameraData.camera.transform.forward;
            HeightOcclusion = Mathf.Max(crowd.heightOcclusionStart.value, 0.001f);
            CrowdParams = new Vector4(1f / HeightOcclusion, crowd.heightOcclusionMin.value, 0f, 0f);
            CrowdLookAt = crowd.target.value.Position;
            CrowdRandomLookAtWeight = crowd.target.value.randomLookAtWeight;
            var position = crowd.occlusionPosition.value;
            OcclusionSphere = new Vector4(position.x, position.y, position.z, crowd.occlusionRadius.value);
        }

        public CrowdRenderingSetupData()
        {
        }
    }
}

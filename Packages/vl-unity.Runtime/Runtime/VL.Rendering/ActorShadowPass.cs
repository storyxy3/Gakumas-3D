// TODO(qa-recon): UpdateShadowData still differs in class-initialization calls; the actor registry lifecycle and dependent volume initialization are not reconstructed here.
namespace VL.Rendering
{
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;
    using global::UnityEngine.Rendering.Universal;
    using global::VL.Rendering;

    public class ActorShadowPass : ScriptableRenderPass
    {
        public struct ActorShadowData
        {
            public Matrix4x4 viewMatrix;
            public Matrix4x4 projMatrix;
            public Matrix4x4 shadowTransform;
            public Matrix4x4 lightToWorldMatrix;
            public int resolution;
            public float startDistance2;
            public float endDistance2;
            public float fade;
            public float strength;
            public float useOffset;
            public float facePartsStrength;
            public void Clear()
            {
                viewMatrix = Matrix4x4.identity;
                projMatrix = Matrix4x4.identity;
                shadowTransform = Matrix4x4.identity;
                resolution = 1024;
                strength = 0f;
                facePartsStrength = 0f;
                startDistance2 = 0f;
                endDistance2 = 10f;
            }
        }

        public delegate Bounds GetBoundsEvent(Camera camera, float far, int resolution);
        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003C_003Ec__DisplayClass33_0
        {
            public CameraPlanes cullingPlane;
            public int actorCount;
            public Bounds bounds;
        }

        [CompilerGenerated]
        private static GetBoundsEvent m_getBounds;
        public static readonly string _ACTOR_SHADOWS = "_ACTOR_SHADOWS";
        private ShaderTagId _shaderTag = new ShaderTagId("ShadowCaster");
        private readonly int _ShadowBias = Shader.PropertyToID("_ShadowBias");
        private readonly int _LightDirection = Shader.PropertyToID("_LightDirection");
        private readonly int _WorldToActorShadow = Shader.PropertyToID("_WorldToActorShadow");
        private readonly int _ActorShadowParams = Shader.PropertyToID("_ActorShadowParams");
        private readonly int _ActorShadowParams2 = Shader.PropertyToID("_ActorShadowParams2");
        private readonly int _ActorShadowOffset0 = Shader.PropertyToID("_ActorShadowOffset0");
        private readonly int _ActorShadowOffset1 = Shader.PropertyToID("_ActorShadowOffset1");
        private readonly int _ActorShadowmapSize = Shader.PropertyToID("_ActorShadowmapSize");
        private static readonly string _ActorShadowmapTexture = "_ActorShadowmapTexture";
        private int _ActorShadowmapTextureID = Shader.PropertyToID(_ActorShadowmapTexture);
        private RTHandle _actorShadowmapTexture;
        private ActorShadowData _actorShadowData;
        private Vector4 _actorShadowBias;
        private FilteringSettings _filteringSettings;
        private bool _supportsShadow;
        private static readonly Vector3[] _frustumCornersCached = new Vector3[4];
        private static readonly Vector3[] _transformBoundsCached = new Vector3[8];
        public static event GetBoundsEvent getBounds
        {
            [CompilerGenerated]
            add
            {
                GetBoundsEvent previous;
                GetBoundsEvent current = m_getBounds;
                do
                {
                    previous = current;
                    var updated = (GetBoundsEvent)System.Delegate.Combine(previous, value);
                    current = System.Threading.Interlocked.CompareExchange(ref m_getBounds, updated, previous);
                } while (!object.ReferenceEquals(current, previous));
            }

            [CompilerGenerated]
            remove
            {
                GetBoundsEvent previous;
                GetBoundsEvent current = m_getBounds;
                do
                {
                    previous = current;
                    var updated = (GetBoundsEvent)System.Delegate.Remove(previous, value);
                    current = System.Threading.Interlocked.CompareExchange(ref m_getBounds, updated, previous);
                } while (!object.ReferenceEquals(current, previous));
            }
        }

        public ActorShadowPass(ref DrawActorShadowPass.Settings settings)
        {
            profilingSampler = new ProfilingSampler("ActorShadowPass");
            renderPassEvent = RenderPassEvent.AfterRenderingShadows;
            _filteringSettings = new FilteringSettings(RenderQueueRange.opaque, settings.mask);
            if (settings.renderingLayer >= 0) _filteringSettings.renderingLayerMask = (uint)settings.renderingLayer;
        }

        public void Dispose()
        {
            _actorShadowmapTexture?.Release();
        }

        public void Setup(ref RenderingData renderingData, ref DrawActorShadowPass.Settings settings)
        {
            Clear();
            _actorShadowBias.x = settings.depthBias;
            _actorShadowBias.y = settings.normalBias;
            _supportsShadow = UpdateShadowData(ref renderingData, ref settings,
                Mathf.Min(renderingData.shadowData.mainLightShadowmapWidth, renderingData.shadowData.mainLightShadowmapHeight));
            ShadowUtils.ShadowRTReAllocateIfNeeded(ref _actorShadowmapTexture, _actorShadowData.resolution, _actorShadowData.resolution, 16, name: _ActorShadowmapTexture);
        }

        public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
        {
            ConfigureTarget(_actorShadowmapTexture);
            ConfigureClear(ClearFlag.All, Color.black);
        }

        private void DrawShadow(CommandBuffer cmd, ScriptableRenderContext context, ref RenderingData renderingData)
        {
            var bias = GetShadowBias(ref _actorShadowData.projMatrix, _actorShadowData.resolution);
            SetupActorShadowCasterConstants(cmd, ref _actorShadowData.lightToWorldMatrix, bias);
            var drawingSettings = CreateDrawingSettings(_shaderTag, ref renderingData, SortingCriteria.CommonOpaque);
            cmd.SetViewProjectionMatrices(_actorShadowData.viewMatrix, _actorShadowData.projMatrix);
            CoreUtils.SetKeyword(cmd, _ACTOR_SHADOWS, true);
            CoreUtils.SetKeyword(cmd, "_CASTING_PUNCTUAL_LIGHT_SHADOW", false);
            SetupActorShadowReceiverConstants(cmd);
            context.ExecuteCommandBuffer(cmd);
            cmd.Clear();
            context.DrawRenderers(renderingData.cullResults, ref drawingSettings, ref _filteringSettings);
        }

        public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
        {
            var cmd = CommandBufferPool.Get();
            using (new ProfilingScope(cmd, profilingSampler))
            {
                DrawShadow(cmd, context, ref renderingData);
                cmd.SetGlobalTexture(_ActorShadowmapTextureID, _actorShadowmapTexture.nameID);
            }
            context.ExecuteCommandBuffer(cmd);
            CommandBufferPool.Release(cmd);
        }

        public override void OnCameraCleanup(CommandBuffer cmd)
        {
            if (cmd == null) throw new System.ArgumentNullException("cmd");
            CoreUtils.SetKeyword(cmd, _ACTOR_SHADOWS, false);
        }

        private void Clear()
        {
            _actorShadowData.Clear();
        }

        private Matrix4x4 GetShadowTransform(Matrix4x4 proj, Matrix4x4 view)
        {
            if (SystemInfo.usesReversedZBuffer)
            {
                proj.m20 = -proj.m20;
                proj.m21 = -proj.m21;
                proj.m22 = -proj.m22;
                proj.m23 = -proj.m23;
            }
            var worldToShadow = proj * view;
            var scaleBias = Matrix4x4.identity;
            scaleBias.m00 = scaleBias.m11 = scaleBias.m22 = 0.5f;
            scaleBias.m03 = scaleBias.m13 = scaleBias.m23 = 0.5f;
            return scaleBias * worldToShadow;
        }

        private bool UpdateShadowData(ref RenderingData renderingData, ref DrawActorShadowPass.Settings settings, int resolution)
        {
            var stack = VolumeManager.instance.stack;
            var actorParameter = stack.GetComponent<VLActorParameter>();
            var shadow = stack.GetComponent<VLActorShadow>();
            var actors = VL.Core.VLActorController.actorControllers;
            var camera = renderingData.cameraData.camera;
            var cameraView = camera.worldToCameraMatrix;
            var vp = camera.projectionMatrix * cameraView;
            var state = new _003C_003Ec__DisplayClass33_0 { cullingPlane = new CameraPlanes(vp), actorCount = 0, bounds = default };
            if (actors != null)
            {
                int count = actors.Count;
                for (int i = 0; i < count; i++)
                {
                    var actor = actors[i];
                    if (actor != null && actor.IsRendererActive())
                        _003CUpdateShadowData_003Eg__UpdateBounds_007C33_0(actor.bounds, ref state);
                }
            }
            if (m_getBounds != null)
            {
                foreach (var callback in m_getBounds.GetInvocationList())
                {
                    if (callback is GetBoundsEvent getBoundsCallback)
                        _003CUpdateShadowData_003Eg__UpdateBounds_007C33_0(getBoundsCallback(camera, settings.far, resolution), ref state);
                }
            }
            if (state.actorCount == 0) return false;
            var cameraTransform = camera.transform;
            var position = cameraTransform.position;
            var rotation = cameraTransform.rotation;
            int lightIndex = renderingData.lightData.mainLightIndex;
            Quaternion lightRotation;
            if (shadow.directionalType.value == VLActorShadowDirectionalType.ShadowLight && lightIndex >= 0)
            {
                var light = renderingData.lightData.visibleLights[lightIndex];
                lightRotation = Quaternion.Inverse(rotation) * light.localToWorldMatrix.rotation;
            }
            else if (shadow.directionalType.value == VLActorShadowDirectionalType.Matcap)
            {
                var angle = actorParameter.mainLightAngle.value;
                lightRotation = actorParameter.mainLightSpace.value == LightSpaceType.Global
                    ? Quaternion.Inverse(rotation) * Quaternion.Euler(angle.x, angle.y, 0f)
                    : Quaternion.Euler(angle.y, -angle.x, 0f);
            }
            else
            {
                var angle = shadow.lightDirectional.value;
                lightRotation = Quaternion.Euler(angle.y, -angle.x, 0f);
            }
            var localBounds = AABBUtility.TransformAABB(state.bounds, cameraTransform.worldToLocalMatrix);
            float near = Mathf.Max(0f, localBounds.min.z);
            float far = Mathf.Min(localBounds.max.z, near + settings.far);
            _actorShadowData.startDistance2 = near * near;
            _actorShadowData.endDistance2 = far * far;
            _actorShadowData.fade = settings.fade;
            camera.CalculateFrustumCorners(new Rect(0f, 0f, 1f, 1f), 1f, Camera.MonoOrStereoscopicEye.Mono, _frustumCornersCached);
            var min = localBounds.min;
            var max = localBounds.max;
            min.x = Mathf.Max(min.x, _frustumCornersCached[0].x * far);
            min.y = Mathf.Max(min.y, _frustumCornersCached[0].y * far);
            min.z = near;
            max.x = Mathf.Min(max.x, _frustumCornersCached[2].x * far);
            max.y = Mathf.Min(max.y, _frustumCornersCached[2].y * far);
            max.z = far;
            localBounds.SetMinMax(min, max);
            var rotatedBounds = AABBUtility.TransformAABB(new Bounds(Vector3.zero, localBounds.size), Matrix4x4.Rotate(lightRotation));
            state.bounds = new Bounds(position + rotation * localBounds.center, rotatedBounds.size);
            var extents = state.bounds.extents;
            _actorShadowData.projMatrix = Matrix4x4.Ortho(-extents.x, extents.x, -extents.y, extents.y, -extents.z, extents.z);
            _actorShadowData.lightToWorldMatrix = Matrix4x4.TRS(state.bounds.center, rotation * lightRotation, new Vector3(1f, 1f, 1f));
            _actorShadowData.viewMatrix = Matrix4x4.Scale(new Vector3(1f, 1f, -1f)) * _actorShadowData.lightToWorldMatrix.inverse;
            _actorShadowData.shadowTransform = GetShadowTransform(_actorShadowData.projMatrix, _actorShadowData.viewMatrix);
            _actorShadowData.strength = shadow.shadowStrength.value;
            _actorShadowData.useOffset = shadow.useOffset.value;
            _actorShadowData.resolution = resolution;
            _actorShadowData.facePartsStrength = shadow.facePartsShadowStrength.value;
            return state.actorCount != 0;
        }

        private Vector4 GetShadowBias(ref Matrix4x4 lightProjectionMatrix, float shadowResolution)
        {
            float texelSize = (2f / lightProjectionMatrix.m00) / shadowResolution;
            return new Vector4(-_actorShadowBias.x * texelSize * 2.5f, -_actorShadowBias.y * texelSize * 2.5f, 0f, 0f);
        }

        private void SetupActorShadowCasterConstants(CommandBuffer cmd, ref Matrix4x4 lightToWorldMatrix, Vector4 shadowBias)
        {
            Vector4 lightDirection = lightToWorldMatrix.GetColumn(2);
            cmd.SetGlobalVector(_ShadowBias, shadowBias);
            cmd.SetGlobalVector(_LightDirection, new Vector4(-lightDirection.x, -lightDirection.y, -lightDirection.z, 0f));
        }

        private void SetupActorShadowReceiverConstants(CommandBuffer cmd)
        {
            float start = _actorShadowData.startDistance2;
            float end = _actorShadowData.endDistance2;
            float fadeStart = start + (end - start) * _actorShadowData.fade;
            float fadeScale = 1f / (end - fadeStart);
            float fadeBias = -fadeStart * fadeScale;
            float invResolution = 1f / _actorShadowData.resolution;
            float halfTexel = invResolution * 0.5f;
            cmd.SetGlobalTexture(_ActorShadowmapTextureID, _actorShadowmapTexture);
            cmd.SetGlobalMatrix(_WorldToActorShadow, _actorShadowData.shadowTransform);
            cmd.SetGlobalVector(_ActorShadowParams, new Vector4(_actorShadowData.strength, _actorShadowData.useOffset, fadeScale, fadeBias));
            cmd.SetGlobalFloat(_ActorShadowParams2, _actorShadowData.facePartsStrength);
            cmd.SetGlobalVector(_ActorShadowOffset0, new Vector4(-halfTexel, -halfTexel, halfTexel, -halfTexel));
            cmd.SetGlobalVector(_ActorShadowOffset1, new Vector4(-halfTexel, halfTexel, halfTexel, halfTexel));
            cmd.SetGlobalVector(_ActorShadowmapSize, new Vector4(invResolution, invResolution, _actorShadowData.resolution, _actorShadowData.resolution));
        }

        [CompilerGenerated]
        private static void _003CUpdateShadowData_003Eg__UpdateBounds_007C33_0(Bounds b, ref _003C_003Ec__DisplayClass33_0 P_1)
        {
            if (!P_1.cullingPlane.TestAABB(b)) return;
            if (P_1.actorCount == 0) P_1.bounds = b;
            else P_1.bounds.Encapsulate(b);
            P_1.actorCount++;
        }
    }
}

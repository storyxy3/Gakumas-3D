namespace VL
{
    using global::Cinemachine;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;

    [ExecuteAlways]
    [AddComponentMenu("")]
    [SaveDuringPlay]
    public class VLCinemachineFocusPoint : CinemachineExtension
    {
        private class VcamFocusPointState
        {
            public VolumeProfile profile;
            public void CreateProfile()
            {
                DestroyProfileCopy();
                profile = ScriptableObject.CreateInstance<VolumeProfile>();
                profile.components.Add(ScriptableObject.CreateInstance<VL.Rendering.VLDOF>());
                profile.isDirty = true;
            }

            public void DestroyProfileCopy()
            {
                if (profile != null) Cinemachine.RuntimeUtility.DestroyObject(profile);
                profile = null;
            }

            public VcamFocusPointState()
            {
            }
        }

        public float offset;
        public Transform target;
        public bool IsValid
        {
            get
            {
                return true;
            }
        }

        public void InvalidateCachedProfile()
        {
            var states = GetAllExtraStates<VcamFocusPointState>();
            for (int i = 0; i < states.Count; ++i) states[i].DestroyProfileCopy();
        }

        protected override void OnDestroy()
        {
            InvalidateCachedProfile();
            base.OnDestroy();
        }

        protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
        {
            if (stage != CinemachineCore.Stage.Finalize) return;
            var extra = GetExtraState<VcamFocusPointState>(vcam);
            if (extra.profile == null) extra.CreateProfile();
            if (extra.profile.TryGet<VL.Rendering.VLDOF>(out var dof))
            {
                float distance = offset;
                if (target != null)
                {
                    distance += Vector3.Distance(state.FinalPosition, target.position);
                    dof.focalPoint.overrideState = true;
                }
                else dof.focalPoint.overrideState = false;
                dof.focalPoint.value = Mathf.Max(0, distance);
                extra.profile.isDirty = true;
            }
            state.AddCustomBlendable(new CameraState.CustomBlendable(extra.profile, 1));
        }

        public VLCinemachineFocusPoint()
        {
        }
    }
}

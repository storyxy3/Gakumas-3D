namespace VL.Rendering
{
    using global::UnityEngine;
    using global::VL.Core;
    using global::VL.Rendering;

    [ExecuteAlways]
    public class VLSRPDrawUIBlurPassSetting : VLMonoBehaviourSingleton<VLSRPDrawUIBlurPassSetting>
    {
        [SerializeField]
        private UIBlurPass.BlurTargetType _blurTargetType;
        public UIBlurPass.BlurTargetType BlurTargetType
        {
            get
            {
                return default(UIBlurPass.BlurTargetType);
            }

            set
            {
            }
        }

        public VLSRPDrawUIBlurPassSetting()
        {
        }
    }
}

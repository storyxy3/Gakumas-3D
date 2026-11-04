namespace VL.Rendering
{
    using global::UnityEngine;
    using global::VL.Core;
    using global::VL.Rendering;

    [ExecuteAlways]
    public class VLSRPDrawUIBlurPassSetting : VLMonoBehaviourSingleton<VLSRPDrawUIBlurPassSetting>
    {
        [SerializeField]
        private UIBlurPass.BlurTargetType _blurTargetType = UIBlurPass.BlurTargetType.Blur;
        public UIBlurPass.BlurTargetType BlurTargetType
        {
            get
            {
                return _blurTargetType;
            }

            set
            {
                _blurTargetType = value;
            }
        }

        public VLSRPDrawUIBlurPassSetting()
        {
        }
    }
}

namespace Titan
{
    using global::DG.Tweening;
    using global::Titan;
    using global::UnityEngine;

    public class LocalRotateClip : TweenerClipBase<Vector3, Vector3Parameter>
    {
        [SerializeField]
        private RotateMode _mode;
        public RotateMode Mode
        {
            get
            {
                return default(RotateMode);
            }
        }

        public LocalRotateClip()
        {
        }
    }
}

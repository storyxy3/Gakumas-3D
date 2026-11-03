namespace Campus.Titan
{
    using global::Titan;
    using global::UnityEngine;

    public class SoundEffectClip : TweenClipBase
    {
        [SerializeField]
        private string _assetName;
        public string GetAssetName(IValueResolver resolver)
        {
            return null;
        }

        public SoundEffectClip()
        {
        }
    }
}

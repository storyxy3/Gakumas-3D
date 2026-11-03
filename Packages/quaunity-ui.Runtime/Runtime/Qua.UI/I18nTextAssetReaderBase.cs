namespace Qua.UI
{
    using global::UnityEngine;

    public abstract class I18nTextAssetReaderBase : ScriptableObject
    {
        public abstract string ReadFromTextAsset(TextAsset asset);
        protected I18nTextAssetReaderBase()
        {
        }
    }
}

namespace Octo
{
    using global::Octo;
    using global::UnityEngine;

    public interface IAssetOperator
    {
        string Name { get; }

        bool IsStreamedSceneAssetBundle { get; }

        LoadRequest<T> LoadAssetAsync<T>()
            where T : Object;
        LoadRequest<T> LoadAssetAsync<T>(string assetName)
            where T : Object;
        T[] LoadAllAssets<T>()
            where T : Object;
        void Unload(bool force = false);
    }
}

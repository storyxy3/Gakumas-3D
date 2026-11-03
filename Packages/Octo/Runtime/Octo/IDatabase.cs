namespace Octo
{
    public interface IDatabase
    {
        string[] GetAllAssetBundleNames();
        string[] GetAllResourceNames();
    }
}

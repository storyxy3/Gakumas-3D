namespace Qua.UI
{
    public interface II18n
    {
        string Get(string key);
        string GetWithParams(string key, params object[] values);
        bool ContainsKey(string key);
    }
}

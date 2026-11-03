namespace Octo.Caching
{
    internal enum CacheState : byte
    {
        None,
        Old,
        OldLocked,
        Latest
    }
}

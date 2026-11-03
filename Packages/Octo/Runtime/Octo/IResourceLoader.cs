namespace Octo
{
    using global::Octo;
    using global::UnityEngine;

    public interface IResourceLoader : ILoader<byte[]>, ILoader, ILoader<string>, ILoader<Texture2D>, ILoader<AudioClip>
    {
    }
}

namespace Octo.Caching
{
    using global::Octo.Caching;

    internal class OctoAndroidPackAppCaching : OctoAndroidAppCaching
    {
        protected override bool MoveAsset(string src, string dest)
        {
            return default(bool);
        }

        public OctoAndroidPackAppCaching()
        {
        }
    }
}

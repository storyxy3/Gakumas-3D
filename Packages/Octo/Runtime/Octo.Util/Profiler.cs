namespace Octo.Util
{
    using global::System;
    using global::Octo.Util;

    internal static class Profiler
    {
        public struct Token : IDisposable
        {
            public void Dispose()
            {
            }
        }

        public static Token StartWithToken()
        {
            return default(Token);
        }
    }
}

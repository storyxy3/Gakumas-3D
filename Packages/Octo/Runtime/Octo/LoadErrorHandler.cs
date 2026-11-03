namespace Octo
{
    using global::System;
    using global::Octo;

    public delegate bool LoadErrorHandler(LoadError error, int retryCount, Action retryAction);
}

namespace Octo
{
    using global::System;
    using global::System.Collections;
    using global::Octo;

    public delegate IEnumerator DownloadErrorHandler(DownloadError error, int retryCount, Action requestRetry);
}

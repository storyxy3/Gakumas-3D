namespace Octo
{
    using global::Octo;

    public class DownloadErrorCode : DatabaseErrorCode
    {
        public new static bool Defines(string code)
        {
            return default(bool);
        }

        internal new static bool Contains(string code)
        {
            return default(bool);
        }

        internal static string FromIOExceptionMessage(string ioErrorMessage)
        {
            return null;
        }

        internal static bool ConvertErrorCode(int httpStatusCode, out string errorCode)
        {
            throw null;
        }
    }
}

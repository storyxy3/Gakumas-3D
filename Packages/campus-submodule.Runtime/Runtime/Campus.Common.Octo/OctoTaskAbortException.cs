namespace Campus.Common.Octo
{
    using global::System;
    using global::Octo;

    public class OctoTaskAbortException : Exception
    {
        public OctoTaskAbortException(DatabaseError error)
        {
        }
    }
}

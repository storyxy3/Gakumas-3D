namespace Qua.Extensions
{
    using global::System;

    public interface IUniTaskExceptionHandler
    {
        void Handle(Exception e);
    }
}

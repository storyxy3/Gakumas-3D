namespace Uguiss
{
    using global::System;

    [Flags]
    public enum CommandType
    {
        Main = 1,
        Sub = 2,
        MainAndSub = 3
    }
}

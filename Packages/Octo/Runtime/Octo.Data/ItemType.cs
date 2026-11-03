namespace Octo.Data
{
    using global::System;

    [Flags]
    internal enum ItemType : byte
    {
        Minimum = 0,
        WithDeps = 1,
        WithTags = 2,
        WithDepsAndTags = 3
    }
}

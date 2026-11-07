namespace Octo.Data
{
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::Octo.Data;
    using global::Octo.Proto;

    internal class ItemWithDepsAndTags : ItemWithDeps
    {
        [CompilerGenerated]
        private string[] _003CTags_003Ek__BackingField;
        public override string[] Tags
        {
            [CompilerGenerated]
            get
            {
                return _003CTags_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CTags_003Ek__BackingField = value;
            }
        }

        public override ItemType Type
        {
            get
            {
                return default(ItemType);
            }
        }

        // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
        public ItemWithDepsAndTags(object /* TODO(qa-recon): octdata Octo.Proto.Data excluded. */ data, IList<string> tagNames) : base(default, default)
        {
        }
    }
}

namespace Octo.Data
{
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::Octo.Data;
    using global::Octo.Proto;

    internal class ItemWithTags : Item
    {
        [CompilerGenerated]
        private string[] _003CTags_003Ek__BackingField;
        public override string[] Tags
        {
            [CompilerGenerated]
            get
            {
                return null;
            }

            [CompilerGenerated]
            set
            {
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
        public ItemWithTags(object /* TODO(qa-recon): octdata Octo.Proto.Data excluded. */ data, IList<string> tagNames) : base(default, default)
        {
        }
    }
}

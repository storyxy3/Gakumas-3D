namespace Octo.Data
{
    using global::System.Collections.Generic;
    using global::Octo.Data;
    using global::Octo.Proto;

    internal class ItemWithDeps : Item
    {
        private Item[] _dependencies;
        private Item[] _flatDependencies;
        public override Item[] Dependencies
        {
            get
            {
                return null;
            }
        }

        public override Item[] FlatDependencies
        {
            get
            {
                return null;
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
        public ItemWithDeps(object /* TODO(qa-recon): octdata Octo.Proto.Data excluded. */ data, IList<string> tagNames) : base(default, default)
        {
        }

        public override void SetDependencies(object /* TODO(qa-recon): octdata Octo.Proto.Data excluded. */ data, Dictionary<int, Item> items)
        {
        }

        private Item[] CreateFlatDependencies()
        {
            return null;
        }

        private static void CreateFlatDependencies(HashSet<Item> itemSet, Item[] dependencies)
        {
        }
    }
}

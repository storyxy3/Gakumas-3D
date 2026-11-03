namespace Octo.Data
{
    using global::System.Collections.Generic;
    using global::Octo.Data;
    using global::Octo.Proto;

    internal static class ItemFactory
    {
        public static Item Create(object /* TODO(qa-recon): octdata Octo.Proto.Data excluded. */ data, IList<string> tagNames)
        {
            return null;
        }

        public static Item CreateByResource(object /* TODO(qa-recon): octdata Octo.Proto.Data excluded. */ data, IList<string> tagNames)
        {
            return null;
        }

        public static bool IsSameItemType(Item item, object /* TODO(qa-recon): octdata Octo.Proto.Data excluded. */ data)
        {
            return default(bool);
        }

        private static ItemType CalculateItemType(object /* TODO(qa-recon): octdata Octo.Proto.Data excluded. */ data)
        {
            return default(ItemType);
        }
    }
}

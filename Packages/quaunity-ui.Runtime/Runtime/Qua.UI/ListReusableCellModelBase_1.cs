namespace Qua.UI
{
    using global::System.Runtime.CompilerServices;

    public class ListReusableCellModelBase<TItemModel>
    {
        [CompilerGenerated]
        private TItemModel _003CItemModel_003Ek__BackingField;
        private int _index;
        public TItemModel ItemModel
        {
            [CompilerGenerated]
            get
            {
                return default(TItemModel);
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public int Index
        {
            get
            {
                return default(int);
            }
        }

        public virtual void SetIndex(int index)
        {
        }

        public void SetItemModel(TItemModel model)
        {
        }

        protected virtual void AssignItemModel()
        {
        }

        public ListReusableCellModelBase()
        {
        }
    }
}

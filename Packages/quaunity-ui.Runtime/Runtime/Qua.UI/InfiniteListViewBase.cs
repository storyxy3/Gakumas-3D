namespace Qua.UI
{
    using global::Qua.UI;
    using global::UnityEngine;

    public class InfiniteListViewBase : ListViewBase
    {
        public override void ClampScrollPosition()
        {
        }

        protected override int GetLowIndexOfBinarySearch()
        {
            return default(int);
        }

        protected override int GetHighIndexOfBinarySearch()
        {
            return default(int);
        }

        private int GetLowIndex(float point)
        {
            return default(int);
        }

        protected override Vector2 GetCellPoint(int index)
        {
            return default(Vector2);
        }

        public InfiniteListViewBase()
        {
        }
    }
}

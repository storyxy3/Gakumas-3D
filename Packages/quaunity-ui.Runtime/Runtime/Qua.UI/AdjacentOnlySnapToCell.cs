namespace Qua.UI
{
    using global::Qua.UI;

    public class AdjacentOnlySnapToCell : SnapToCell
    {
        protected override int GetIndexFromMomentum(float momentum, int currentIndex)
        {
            return default(int);
        }

        public AdjacentOnlySnapToCell()
        {
        }
    }
}

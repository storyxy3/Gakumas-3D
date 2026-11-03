namespace Qua.UI
{
    using global::Qua.UI;
    using global::UnityEngine;

    public class QuaSafeArea : IQuaSafeArea
    {
        private static IQuaSafeArea _default;
        public static IQuaSafeArea Default
        {
            get
            {
                return null;
            }
        }

        public Rect GetRect()
        {
            return default(Rect);
        }

        public QuaSafeArea()
        {
        }
    }
}

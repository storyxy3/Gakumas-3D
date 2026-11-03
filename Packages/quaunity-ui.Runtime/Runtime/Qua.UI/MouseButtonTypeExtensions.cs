namespace Qua.UI
{
    using global::Qua.UI;
    using global::UnityEngine.EventSystems;

    public static class MouseButtonTypeExtensions
    {
        public static bool IsAcceptable(this MouseButtonType self, MouseButtonType buttonType)
        {
            return default(bool);
        }

        public static bool IsAcceptable(this MouseButtonType self, PointerEventData.InputButton buttonEvent)
        {
            return default(bool);
        }

        private static MouseButtonType ToMouseButtonType(this PointerEventData.InputButton buttonEvent)
        {
            return default(MouseButtonType);
        }
    }
}

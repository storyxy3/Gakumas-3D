namespace Qua.UI
{
    using global::UnityEngine;
    using global::UnityEngine.EventSystems;

    public static class UIEventUtility
    {
        public static void PenetrateParentHandler<T>(Transform transform, PointerEventData eventData, ExecuteEvents.EventFunction<T> eventFunc)
            where T : IEventSystemHandler
        {
        }
    }
}

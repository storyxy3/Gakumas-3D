namespace UniRx.Triggers
{
    using global::System;
    using global::UniRx;
    using global::UnityEngine;
    using global::UnityEngine.EventSystems;

    public static class ObservableTriggerExtensions
    {
        public static IObservable<Unit> OnDestroyAsObservable(this Component component)
        {
            return null;
        }

        public static IObservable<Unit> OnDisableAsObservable(this Component component)
        {
            return null;
        }

        public static IObservable<Unit> OnRectTransformDimensionsChangeAsObservable(this Component component)
        {
            return null;
        }

        public static IObservable<PointerEventData> OnPointerDownAsObservable(this UIBehaviour component)
        {
            return null;
        }

        public static IObservable<PointerEventData> OnBeginDragAsObservable(this UIBehaviour component)
        {
            return null;
        }

        public static IObservable<Unit> OnDestroyAsObservable(this GameObject gameObject)
        {
            return null;
        }

        public static IObservable<Unit> OnEnableAsObservable(this GameObject gameObject)
        {
            return null;
        }

        public static IObservable<Unit> OnDisableAsObservable(this GameObject gameObject)
        {
            return null;
        }

        private static T GetOrAddComponent<T>(GameObject gameObject)
            where T : Component
        {
            return null;
        }
    }
}

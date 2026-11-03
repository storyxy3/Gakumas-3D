namespace Qua.UI.Internal
{
    using global::System;
    using global::UnityEngine;

    public class ScrollAnimationTween : MonoBehaviour
    {
        private RectTransform _target;
        private Vector2 _start;
        private Vector2 _end;
        private float _elapsedTime;
        private float _duration;
        private Action _onComplete;
        public static void Begin(RectTransform target, Vector2 targetPosition, float duration, Action callback)
        {
        }

        public static void Kill(RectTransform target)
        {
        }

        private void Update()
        {
        }

        private void Finish()
        {
        }

        private void OnDisable()
        {
        }

        public ScrollAnimationTween()
        {
        }
    }
}

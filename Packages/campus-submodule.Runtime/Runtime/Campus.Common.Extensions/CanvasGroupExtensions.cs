// APK 3.5.3: SetBlockingAlpha 0x7470d0c, DOFadeBlocking 0x7470db0.
// LiveSceneView.FadeBlackTintAsync uses this tween for its black overlay.
namespace Campus.Common.Extensions
{
    using System.Runtime.CompilerServices;
    using DG.Tweening;
    using UnityEngine;

    public static class CanvasGroupExtensions
    {
        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass1_0
        {
            public CanvasGroup canvasGroup;
            internal float _003CDOFadeBlocking_003Eb__0()
            {
                return canvasGroup.alpha;
            }
        }

        public static void SetBlockingAlpha(this CanvasGroup canvasGroup, float alpha)
        {
            canvasGroup.alpha = alpha;
            if ((canvasGroup.interactable && canvasGroup.blocksRaycasts) != (alpha >= 1f))
            {
                canvasGroup.interactable = alpha >= 1f;
                canvasGroup.blocksRaycasts = alpha >= 1f;
            }
        }

        public static Tween DOFadeBlocking(this CanvasGroup canvasGroup, float alpha, float duration)
        {
            var closure = new _003C_003Ec__DisplayClass1_0 { canvasGroup = canvasGroup };
            return DOTween.To(closure._003CDOFadeBlocking_003Eb__0, closure.canvasGroup.SetBlockingAlpha, alpha, duration)
                .SetLink(closure.canvasGroup.gameObject);
        }
    }
}

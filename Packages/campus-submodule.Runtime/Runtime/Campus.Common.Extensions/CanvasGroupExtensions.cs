// APK 3.5.3: SetBlockingAlpha 0x7470d0c, DOFadeBlocking 0x7470db0.
// LiveSceneView.FadeBlackTintAsync uses this tween for its black overlay.
namespace Campus.Common.Extensions
{
    using DG.Tweening;
    using UnityEngine;

    public static class CanvasGroupExtensions
    {
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
            return DOTween.To(() => canvasGroup.alpha, canvasGroup.SetBlockingAlpha, alpha, duration)
                .SetLink(canvasGroup.gameObject);
        }
    }
}

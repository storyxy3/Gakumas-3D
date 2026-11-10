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
            // Original compares 1 > alpha (x64 comiss(1,alpha)+setbe): NaN alpha counts as blocking.
            if ((canvasGroup.interactable && canvasGroup.blocksRaycasts) != !(1f > alpha))
            {
                canvasGroup.interactable = !(1f > alpha);
                canvasGroup.blocksRaycasts = !(1f > alpha);
            }
        }

        public static Tween DOFadeBlocking(this CanvasGroup canvasGroup, float alpha, float duration)
        {
            return DOTween.To(() => canvasGroup.alpha, canvasGroup.SetBlockingAlpha, alpha, duration)
                .SetLink(canvasGroup.gameObject);
        }
    }
}

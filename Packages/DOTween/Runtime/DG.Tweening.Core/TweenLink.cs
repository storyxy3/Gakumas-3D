namespace DG.Tweening.Core
{
    using global::DG.Tweening;
    using global::UnityEngine;

    internal class TweenLink
    {
        public readonly GameObject target;
        public readonly LinkBehaviour behaviour;
        public bool lastSeenActive;
        public TweenLink(GameObject target, LinkBehaviour behaviour)
        {
        }
    }
}

namespace Titan.Legacy
{
    using global::Titan;
    using global::UnityEngine;

    public class SpriteAnimationClip : LoopableTweenClip
    {
        [SerializeField]
        private Sprite[] _sprites;
        public Sprite[] Sprites
        {
            get
            {
                return null;
            }
        }

        public SpriteAnimationClip()
        {
        }
    }
}

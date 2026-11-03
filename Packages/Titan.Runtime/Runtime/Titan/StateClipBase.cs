namespace Titan
{
    using global::Titan;
    using global::UnityEngine;

    public class StateClipBase : LoopableTweenClip
    {
        [SerializeField]
        private bool _hold;
        public bool Hold
        {
            get
            {
                return default(bool);
            }
        }

        public StateClipBase()
        {
        }
    }
}

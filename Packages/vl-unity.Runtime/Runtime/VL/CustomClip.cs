namespace VL
{
    using global::UnityEngine;
    using global::UnityEngine.Playables;

    public abstract class CustomClip : ScriptableObject
    {
        public abstract bool isLooping { get; }
        public abstract float length { get; }

        public abstract Playable CreatePlayable(Animator animator, PlayableGraph graph);
        protected CustomClip()
        {
        }
    }
}

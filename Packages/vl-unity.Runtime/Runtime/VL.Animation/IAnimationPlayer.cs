namespace VL.Animation
{
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::VL.Animation;

    public interface IAnimationPlayer
    {
        bool initialized { get; }

        Animator animator { get; }

        PlayableGraph GetPlayableGraph();
        IAnimationController GetPlayingBaseController();
        IAnimationController GetPlayingLayerController(string layerName);
        void InsertRootPlayable(int order, OnInsertRootPlayable onConnect);
        void RemoveRootPlayable(int order, OnDisconnectRootPlayable onDisconnect);
        Playable GetRootPlayable(int order);
    }
}

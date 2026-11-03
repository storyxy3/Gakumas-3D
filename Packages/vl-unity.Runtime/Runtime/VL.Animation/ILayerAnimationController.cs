namespace VL.Animation
{
    using global::System;
    using global::UnityEngine.Playables;
    using global::VL.Animation;

    public interface ILayerAnimationController : IAnimationController, IDisposable
    {
        int GetPlayableCount();
        PlayState GetPlayablePlayState(int index);
        void PlayPlayable(int index);
        void PausePlayable(int index);
        void SetPlayableTime(int index, double time);
        void SetPlayableWeight(int index, float weight);
    }
}

namespace VL.Animation
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::UnityEngine.Animations;
    using global::UnityEngine.Playables;
    using global::VL.Animation;

    public class MotionTimelinePlayable : PlayableBehaviour
    {
        [Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec
        {
            public static readonly _003C_003Ec _003C_003E9;
            public static Func<LayerController, bool> _003C_003E9__9_0;
            public _003C_003Ec()
            {
            }

            internal bool _003CGetPlayingLayerControllers_003Eb__9_0(LayerController t)
            {
                return default(bool);
            }
        }

        public const int MaxLayer = 8;
        public const int AdditiveLayerStartIndex = 4;
        public IMotionDefinePlayerEvent playerEvent;
        private AnimationLayerMixerPlayable _layerMixerPlayable;
        private ScriptPlayable<MotionLayerMixerPlayable>[] _layerPlayables;
        private LayerController[] _playingControllers;
        private Dictionary<string, int> _layerNameTable;
        public ILayerAnimationController GetPlayingBaseController()
        {
            return null;
        }

        public ILayerAnimationController GetPlayingLayerController(string layerName)
        {
            return null;
        }

        public IEnumerable<ILayerAnimationController> GetPlayingLayerControllers()
        {
            return null;
        }

        public override void OnPlayableCreate(Playable playable)
        {
        }

        public override void OnBehaviourPause(Playable playable, FrameData info)
        {
        }

        public override void OnBehaviourPlay(Playable playable, FrameData info)
        {
        }

        public bool TryGetLayerIndex(string layerName, out int index)
        {
            throw null;
        }

        public ScriptPlayable<MotionLayerMixerPlayable> GetLayerMixerPlayable(string layerName)
        {
            return default(ScriptPlayable<MotionLayerMixerPlayable>);
        }

        public void SetLayerWeight(int layerIndex, float weight)
        {
        }

        public float GetLayerWeight(string layerName)
        {
            return default(float);
        }

        public float GetLayerWeight(int layerIndex)
        {
            return default(float);
        }

        public bool TryGetLayerPlayable(LayerController controller, out ScriptPlayable<MotionLayerPlayable> playable, out int layerIndex)
        {
            throw null;
        }

        public MotionTimelinePlayable()
        {
        }

        [CompilerGenerated]
        private int _003CTryGetLayerPlayable_003Eg__FindAvailableIndex_007C20_0(int startIndex)
        {
            return default(int);
        }
    }
}

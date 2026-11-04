namespace VL.Animation
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::UnityEngine;
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
            public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();
            public static Func<LayerController, bool> _003C_003E9__9_0;
            public _003C_003Ec()
            {
            }

            internal bool _003CGetPlayingLayerControllers_003Eb__9_0(LayerController t)
            {
                return t != null;
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
            return _playingControllers[0];
        }

        public ILayerAnimationController GetPlayingLayerController(string layerName)
        {
            return TryGetLayerIndex(layerName, out int index) ? _playingControllers[index] : null;
        }

        public IEnumerable<ILayerAnimationController> GetPlayingLayerControllers()
        {
            return _playingControllers.Where(_003C_003Ec._003C_003E9__9_0 ?? (_003C_003Ec._003C_003E9__9_0 = new Func<LayerController, bool>(_003C_003Ec._003C_003E9._003CGetPlayingLayerControllers_003Eb__9_0)));
        }

        public override void OnPlayableCreate(Playable playable)
        {
            _layerPlayables = new ScriptPlayable<MotionLayerMixerPlayable>[MaxLayer];
            _playingControllers = new LayerController[MaxLayer];
            _layerNameTable = new Dictionary<string, int>(MaxLayer);
            _layerMixerPlayable = AnimationLayerMixerPlayable.Create(playable.GetGraph(), MaxLayer);
            for (uint i = 0; i < MaxLayer; ++i)
                _layerMixerPlayable.SetLayerAdditive(i, i >= AdditiveLayerStartIndex);
            playable.AddInput(_layerMixerPlayable, 0, 1f);
        }

        public override void OnBehaviourPause(Playable playable, FrameData info)
        {
        }

        public override void OnBehaviourPlay(Playable playable, FrameData info)
        {
        }

        public bool TryGetLayerIndex(string layerName, out int index)
        {
            return _layerNameTable.TryGetValue(layerName, out index);
        }

        public ScriptPlayable<MotionLayerMixerPlayable> GetLayerMixerPlayable(string layerName)
        {
            return TryGetLayerIndex(layerName, out int index) ? _layerPlayables[index] : ScriptPlayable<MotionLayerMixerPlayable>.Null;
        }

        public void SetLayerWeight(int layerIndex, float weight)
        {
            if (_layerMixerPlayable.IsValid())
                _layerMixerPlayable.SetInputWeight(layerIndex, weight);
        }

        public float GetLayerWeight(string layerName)
        {
            return _layerMixerPlayable.IsValid() && TryGetLayerIndex(layerName, out int index) ? _layerMixerPlayable.GetInputWeight(index) : 0f;
        }

        public float GetLayerWeight(int layerIndex)
        {
            return _layerMixerPlayable.IsValid() ? _layerMixerPlayable.GetInputWeight(layerIndex) : 0f;
        }

        public bool TryGetLayerPlayable(LayerController controller, out ScriptPlayable<MotionLayerPlayable> playable, out int layerIndex)
        {
            for (int i = 0; i < _layerPlayables.Length; ++i)
            {
                if (!_layerPlayables[i].IsValid())
                    continue;
                MotionLayerMixerPlayable layer = _layerPlayables[i].GetBehaviour();
                if (layer.Disconnected())
                {
                    _layerNameTable.Remove(layer.layerName);
                    _layerMixerPlayable.DisconnectInput(i);
                    _layerPlayables[i].Destroy();
                    _playingControllers[i] = null;
                }
            }
            LayerParam param = controller.layerParam;
            ScriptPlayable<MotionLayerMixerPlayable> layerPlayable;
            if (_layerNameTable.TryGetValue(param.layerName, out int index))
            {
                layerPlayable = _layerPlayables[index];
                layerIndex = index;
            }
            else
            {
                layerIndex = _003CTryGetLayerPlayable_003Eg__FindAvailableIndex_007C20_0(param.isAdditive ? AdditiveLayerStartIndex : 0);
                if (layerIndex < 0)
                {
                    Debug.LogError("最大再生レイヤーを超えています " + param.layerName);
                    playable = ScriptPlayable<MotionLayerPlayable>.Null;
                    return false;
                }
                if (param.mask != null)
                    _layerMixerPlayable.SetLayerMaskFromAvatarMask((uint)layerIndex, param.mask);
                layerPlayable = ScriptPlayable<MotionLayerMixerPlayable>.Create(_layerMixerPlayable.GetGraph(), new MotionLayerMixerPlayable
                {
                    playerEvent = playerEvent,
                    layerName = param.layerName
                });
                _layerMixerPlayable.ConnectInput(layerIndex, layerPlayable, 0, 0f);
                _layerPlayables[layerIndex] = layerPlayable;
                _layerMixerPlayable.SetInputWeight(layerIndex, 1f);
                _layerNameTable.Add(param.layerName, layerIndex);
            }
            playable = layerPlayable.GetBehaviour().SetupLayer(param);
            _playingControllers[layerIndex] = controller;
            return true;
        }

        public MotionTimelinePlayable()
        {
        }

        [CompilerGenerated]
        private int _003CTryGetLayerPlayable_003Eg__FindAvailableIndex_007C20_0(int startIndex)
        {
            for (int i = 0; i < AdditiveLayerStartIndex; ++i)
            {
                if (!_layerPlayables[startIndex + i].IsValid())
                    return startIndex + i;
            }
            return -1;
        }
    }
}

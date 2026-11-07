namespace VL
{
    using global::System;
    using global::System.Collections;
    using global::System.Collections.Generic;
    using global::UnityEngine;
    using global::VL;
    using global::VL.Animation;

    [CreateAssetMenu(fileName = "MotionDefine.asset", menuName = "VL/Motion Define", order = 70000)]
    public class MotionDefine : ScriptableObject, IEnumerable<AnimationData>, IEnumerable
    {
        private class MotionDefineEnumerator : IEnumerator<AnimationData>, IEnumerator, IDisposable, IEnumerable<AnimationData>, IEnumerable
        {
            private MotionDefine _target;
            private bool _ignoreDispose;
            private int _currentIndex = -1;
            public AnimationData Current
            {
                get
                {
                    return _target[_currentIndex];
                }
            }

            object System.Collections.IEnumerator.Current
            {
                get
                {
                    return Current;
                }
            }

            public MotionDefineEnumerator(MotionDefine target, bool ignoreDispose)
            {
                _target = target;
                _ignoreDispose = ignoreDispose;
            }

            public bool MoveNext()
            {
                if (_target == null)
                {
                    Debug.Log(ReferenceEquals(_target, null) ? "Disposeされています" : "assetが破棄されています");
                    return false;
                }
                if (_currentIndex >= _target.count)
                    throw new InvalidOperationException("Resetを呼んでください");
                ++_currentIndex;
                return _currentIndex < _target.count;
            }

            public void Reset()
            {
                _currentIndex = -1;
            }

            public void Dispose()
            {
                if (_ignoreDispose)
                    Reset();
                else
                    _target = null;
            }

            public IEnumerator<AnimationData> GetEnumerator()
            {
                return this;
            }

            IEnumerator System.Collections.IEnumerable.GetEnumerator()
            {
                return this;
            }
        }

        [Tooltip("レイヤー扱いで再生するなら再生レイヤー名入力")]
        public string layerName;
        [Tooltip("加算アニメーションフラグ")]
        public bool isAdditive;
        [Tooltip("加算アニメーションを無視するフラグ")]
        public bool ignoreAdditive;
        [Obsolete("baseAnimationに移動")]
        [InspectorName("ApplyPlayableIK (Legacy)")]
        public bool applyPlayableIK;
        [Obsolete("baseAnimationに移動")]
        [InspectorName("ApplyFootIK (Legacy)")]
        public bool applyFootIK;
        public EffectData[] effects;
        [Tooltip("ループモーションのループ設定")]
        public bool isLoopMotionEffect;
        public AnimationData baseAnimation;
        private IEnumerable<AnimationData> _sharedEnumerator;
        public bool isLoop
        {
            get
            {
                return baseAnimation != null && baseAnimation.isLoop;
            }
        }

        public float animationLength
        {
            get
            {
                return baseAnimation != null ? baseAnimation.animationLength : 0f;
            }
        }

        public virtual AnimationData this[int index]
        {
            get
            {
                if (index >= count)
                    throw new IndexOutOfRangeException();
                return baseAnimation;
            }
        }

        public virtual int count
        {
            get
            {
                return 1;
            }
        }

        public virtual float OnProcessMixerWeight(int index, float weight, float time)
        {
            return weight;
        }

        private void OnEnable()
        {
            if (baseAnimation == null)
                baseAnimation = new AnimationData();
        }

        protected virtual void OnDestroy()
        {
            _sharedEnumerator = null;
        }

        public bool ContainAnimationClip(AnimationClip clip)
        {
            if (clip == null)
                return false;
            for (int i = 0; i < count; i++)
            {
                if (this[i]?.clip == clip)
                    return true;
            }
            return false;
        }

        public IEnumerable<AnimationData> SharedEnumerable()
        {
            if (_sharedEnumerator == null)
                _sharedEnumerator = new MotionDefineEnumerator(this, true);
            return _sharedEnumerator;
        }

        public IEnumerator<AnimationData> GetEnumerator()
        {
            return new MotionDefineEnumerator(this, false);
        }

        IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Validate()
        {
            if (effects != null && effects.Length >= 2)
                Array.Sort(effects);
        }

        public MotionDefine()
        {
        }
    }
}

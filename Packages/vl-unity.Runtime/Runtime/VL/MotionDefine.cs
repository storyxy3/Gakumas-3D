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
            private int _currentIndex;
            public AnimationData Current
            {
                get
                {
                    return null;
                }
            }

            object System.Collections.IEnumerator.Current
            {
                get
                {
                    return null;
                }
            }

            public MotionDefineEnumerator(MotionDefine target, bool ignoreDispose)
            {
            }

            public bool MoveNext()
            {
                return default(bool);
            }

            public void Reset()
            {
            }

            public void Dispose()
            {
            }

            public IEnumerator<AnimationData> GetEnumerator()
            {
                return null;
            }

            IEnumerator System.Collections.IEnumerable.GetEnumerator()
            {
                return null;
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
                return default(bool);
            }
        }

        public float animationLength
        {
            get
            {
                return default(float);
            }
        }

        public virtual AnimationData this[int index]
        {
            get
            {
                return null;
            }
        }

        public virtual int count
        {
            get
            {
                return default(int);
            }
        }

        public virtual float OnProcessMixerWeight(int index, float weight, float time)
        {
            return default(float);
        }

        private void OnEnable()
        {
        }

        protected virtual void OnDestroy()
        {
        }

        public bool ContainAnimationClip(AnimationClip clip)
        {
            return default(bool);
        }

        public IEnumerable<AnimationData> SharedEnumerable()
        {
            return null;
        }

        public IEnumerator<AnimationData> GetEnumerator()
        {
            return null;
        }

        IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return null;
        }

        public void Validate()
        {
        }

        public MotionDefine()
        {
        }
    }
}

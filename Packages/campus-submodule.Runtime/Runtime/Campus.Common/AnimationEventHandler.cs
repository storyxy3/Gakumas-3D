namespace Campus.Common
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::Campus.Common;
    using global::JetBrains.Annotations;
    using global::UnityEngine;

    public class AnimationEventHandler : MonoBehaviour
    {
        private class CreatedEntry<T>
            where T : UnityEngine.Object
        {
            public string id;
            public T target;
            public CreatedEntry(string id, T target)
            {
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass12_0
        {
            public AudioClip audioClip;
            public Func<CreatedEntry<AudioClip>, bool> _003C_003E9__0;
            public _003C_003Ec__DisplayClass12_0()
            {
            }

            internal bool _003COnStopVoice_003Eb__0(CreatedEntry<AudioClip> x)
            {
                return default(bool);
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass14_0
        {
            public AudioClip audioClip;
            public Func<CreatedEntry<AudioClip>, bool> _003C_003E9__0;
            public _003C_003Ec__DisplayClass14_0()
            {
            }

            internal bool _003COnStopSE_003Eb__0(CreatedEntry<AudioClip> x)
            {
                return default(bool);
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass21_0
        {
            public EffectDefine define;
            public Func<CreatedEntry<ParticleSystem>, bool> _003C_003E9__0;
            public _003C_003Ec__DisplayClass21_0()
            {
            }

            internal bool _003CStopEffectInternal_003Eb__0(CreatedEntry<ParticleSystem> x)
            {
                return default(bool);
            }
        }

        [SerializeField]
        [HideInInspector]
        private CampusActorController _actorController;
        private readonly List<CreatedEntry<ParticleSystem>> _createdParticles;
        private readonly List<CreatedEntry<AudioClip>> _createdSounds;
        [SerializeField]
        [HideInInspector]
        private bool _isActiveAnimationEvent;
        public bool IsInitialized
        {
            get
            {
                return default(bool);
            }
        }

        private bool _canPlayAnimationEvent
        {
            get
            {
                return default(bool);
            }
        }

        public void Initialize(CampusActorController actorController)
        {
        }

        public void SetAnimationEventActive(bool active)
        {
        }

        private void OnVoice(UnityEngine.Object obj)
        {
        }

        private void OnStopVoice(UnityEngine.Object obj)
        {
        }

        private void OnSE(UnityEngine.Object obj)
        {
        }

        private void OnStopSE(UnityEngine.Object obj)
        {
        }

        private void OnEffectLaunch(UnityEngine.Object obj)
        {
        }

        protected void OnEffectStop(UnityEngine.Object obj)
        {
        }

        private void OnEffectFinish(UnityEngine.Object obj)
        {
        }

        protected void OnAllEffectStop()
        {
        }

        private void OnAllEffectDestroy()
        {
        }

        private void PlayEffectInternal([NotNull] EffectDefine define)
        {
        }

        private void StopEffectInternal([NotNull] EffectDefine define, bool isInstant)
        {
        }

        private void AllEffectDestroyInternal()
        {
        }

        public void AllEffectStopInternal()
        {
        }

        protected void OnDestroy()
        {
        }

        public AnimationEventHandler()
        {
        }
    }
}

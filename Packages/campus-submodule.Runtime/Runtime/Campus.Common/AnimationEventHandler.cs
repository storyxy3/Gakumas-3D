namespace Campus.Common
{
    using global::System.Collections.Generic;
    using global::Campus.Common;
    using global::JetBrains.Annotations;
    using global::UnityEngine;

    public class AnimationEventHandler : MonoBehaviour
    {
        private class CreatedEntry<T>
            where T : Object
        {
            public string id;
            public T target;
            public CreatedEntry(string id, T target)
            {
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

        private void OnVoice(Object obj)
        {
        }

        private void OnStopVoice(Object obj)
        {
        }

        private void OnSE(Object obj)
        {
        }

        private void OnStopSE(Object obj)
        {
        }

        private void OnEffectLaunch(Object obj)
        {
        }

        protected void OnEffectStop(Object obj)
        {
        }

        private void OnEffectFinish(Object obj)
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

namespace Campus.Common
{
    using global::System.Collections.Generic;
    using global::UnityEngine;

    public class CampusActorEffectController
    {
        private List<ParticleSystem> _playingEffects;
        public void Initialize()
        {
            _playingEffects = new List<ParticleSystem>();
        }

        public void PlayEffect(Transform targetTransform, ParticleSystem effect)
        {
            if (effect == null || targetTransform == null) return;
            foreach (var playingEffect in _playingEffects)
            {
                if (playingEffect.name == effect.name && playingEffect.transform.parent == targetTransform)
                {
                    if (!playingEffect.isPlaying)
                    {
                        playingEffect.Stop();
                        playingEffect.Play();
                    }
                    return;
                }
            }
            effect.transform.SetParent(targetTransform, false);
            effect.Play();
            _playingEffects.Add(effect);
        }

        public void StopEffects()
        {
            for (int i = _playingEffects.Count - 1; i >= 0; i--) StopEffect(_playingEffects[i]);
        }

        public void StopEffect(ParticleSystem effect)
        {
            if (effect == null) return;
            effect.Stop();
            _playingEffects.Remove(effect);
            Object.Destroy(effect.gameObject);
        }

        public CampusActorEffectController()
        {
        }
    }
}

namespace VL
{
    using global::UnityEngine;
    using global::VL;

    [AddComponentMenu("")]
    public class VLActorTalk : VLActorTalkBase<VLActorTalkFFT, AudioSource>
    {
        private AudioClip _playingClip;
        protected override void CreateVLActorTalkFFT()
        {
        }

        protected override void OnPlayTalk(AudioSource source)
        {
        }

        protected override void OnReset()
        {
        }

        protected override bool ShouldReset(AudioSource source)
        {
            return default(bool);
        }

        public VLActorTalk()
        {
        }
    }
}

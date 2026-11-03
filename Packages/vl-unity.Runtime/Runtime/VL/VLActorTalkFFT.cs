namespace VL
{
    using global::System;
    using global::UnityEngine;
    using global::VL;

    [Serializable]
    public class VLActorTalkFFT : VLActorTalkFFTBase<AudioSource>
    {
        public override bool isPlaying
        {
            get
            {
                return default(bool);
            }
        }

        protected override void GetOutputData(AudioSource source, float[] array, int channel)
        {
        }

        protected override void OnSetAudioSource()
        {
        }

        protected override void OnReset()
        {
        }

        public VLActorTalkFFT()
        {
        }
    }
}

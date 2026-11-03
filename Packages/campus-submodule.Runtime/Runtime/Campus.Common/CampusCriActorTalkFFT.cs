namespace Campus.Common
{
    using global::System;
    using global::CriWare;
    using global::VL;

    [Serializable]
    public class CampusCriActorTalkFFT : VLActorTalkFFTBase<CriAtomSource>
    {
        private CriAtomExOutputAnalyzer _analyzer;
        public override bool isPlaying
        {
            get
            {
                return default(bool);
            }
        }

        public CampusCriActorTalkFFT()
        {
        }

        protected override void OnSetAudioSource()
        {
        }

        protected override void OnReset()
        {
        }

        protected override void GetOutputData(CriAtomSource source, float[] array, int channel)
        {
        }

        private void CreateAnalyzer()
        {
        }
    }
}

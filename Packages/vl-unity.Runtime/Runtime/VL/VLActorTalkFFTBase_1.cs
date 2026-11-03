namespace VL
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::UnityEngine;
    using global::VL;

    [Serializable]
    public abstract class VLActorTalkFFTBase<T> : IVLActorTalkFFT<T> where T : Component
    {
        public float talkThreshold;
        private float[] _fftInputRe;
        private float[] _fftInputIm;
        private float[] _fftOutputRe;
        private float[] _fftOutputIm;
        private int[] _bitScrollArray;
        private float[] _windowArray;
        private FFTWindow _fftWindow;
        [CompilerGenerated]
        private T _003CaudioSource_003Ek__BackingField;
        [CompilerGenerated]
        private bool _003CisTalk_003Ek__BackingField;
        [CompilerGenerated]
        private readonly bool _003CisPlaying_003Ek__BackingField;
        [CompilerGenerated]
        private float _003CtalkPower_003Ek__BackingField;
        private float[] _spectrum;
        private float[] _voiceSpectrum;
        public T audioSource
        {
            [CompilerGenerated]
            get
            {
                return null;
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        private int BitSize
        {
            get
            {
                return default(int);
            }
        }

        private int BitArrayDataSize
        {
            get
            {
                return default(int);
            }
        }

        public bool isTalk
        {
            [CompilerGenerated]
            get
            {
                return default(bool);
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public virtual bool isPlaying
        {
            [CompilerGenerated]
            get
            {
                return default(bool);
            }
        }

        private float talkPower
        {
            [CompilerGenerated]
            set
            {
            }
        }

        public VLActorTalkFFTBase()
        {
        }

        public void SetAudioSource(T source)
        {
        }

        protected abstract void OnSetAudioSource();
        public void Reset()
        {
        }

        protected abstract void OnReset();
        public void UpdateFFT()
        {
        }

        protected abstract void GetOutputData(T source, float[] array, int channel);
        private void AudioFFT(T source, FFTWindow fftWindow = FFTWindow.Hamming, int channel = 0)
        {
        }

        private void FFT(FFTWindow fftWindow)
        {
        }

        private int[] CreateBitScrollArray()
        {
            return null;
        }

        private void PreEmphasisFilter(float[] data)
        {
        }

        private void Windowing(float[] data, FFTWindow fftWindow)
        {
        }

        private void CreateWindowArray(FFTWindow fftWindow)
        {
        }

        private void InitializeFFTArray()
        {
        }
    }
}

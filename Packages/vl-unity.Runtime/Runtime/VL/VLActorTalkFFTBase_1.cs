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
                return _003CaudioSource_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CaudioSource_003Ek__BackingField = value;
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
                return _003CisTalk_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CisTalk_003Ek__BackingField = value;
            }
        }

        public virtual bool isPlaying
        {
            [CompilerGenerated]
            get
            {
                return _003CisPlaying_003Ek__BackingField;
            }
        }

        private float talkPower
        {
            [CompilerGenerated]
            set
            {
                _003CtalkPower_003Ek__BackingField = value;
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

namespace CriWare
{
    using global::CriWare;
    using global::UnityEngine;

    [AddComponentMenu("CRIWARE/CriManaMovieMaterial")]
    public class CriManaMovieMaterial : CriManaMovieMaterialBase
    {
        [SerializeField]
        private string _moviePath;
        [SerializeField]
        private bool _loop;
        [SerializeField]
        private bool _audioBaseConcatenation;
        [SerializeField]
        private bool _additiveMode;
        [SerializeField]
        private bool _advancedAudio;
        [SerializeField]
        private bool _ambisonics;
        [SerializeField]
        private bool _applyTargetAlpha;
        [SerializeField]
        private bool _uiRenderMode;
        private GameObject ambisonicSource;
        public string moviePath
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public bool loop
        {
            get
            {
                return default(bool);
            }

            set
            {
            }
        }

        public bool audioBaseConcatenation
        {
            get
            {
                return default(bool);
            }

            set
            {
            }
        }

        public bool advancedAudio
        {
            get
            {
                return default(bool);
            }

            set
            {
            }
        }

        public bool ambisonics
        {
            get
            {
                return default(bool);
            }

            set
            {
            }
        }

        public bool additiveMode
        {
            get
            {
                return default(bool);
            }

            set
            {
            }
        }

        public bool applyTargetAlpha
        {
            get
            {
                return default(bool);
            }

            set
            {
            }
        }

        public bool uiRenderMode
        {
            get
            {
                return default(bool);
            }

            set
            {
            }
        }

        protected override uint FilePathLength
        {
            get
            {
                return default(uint);
            }
        }

        protected override bool initializeWithAdvancedAudio
        {
            get
            {
                return default(bool);
            }
        }

        protected override bool initializeWithAmbisonics
        {
            get
            {
                return default(bool);
            }
        }

        protected override void SetDataToPlayer()
        {
        }

        public CriManaMovieMaterial()
        {
        }
    }
}

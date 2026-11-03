namespace CriWare
{
    using global::System;
    using global::CriWare;
    using global::UnityEngine;

    [AddComponentMenu("CRIWARE/Library Initializer")]
    public class CriWareInitializer : CriMonoBehaviour
    {
        public bool initializesFileSystem;
        public CriFsConfig fileSystemConfig;
        public bool initializesAtom;
        public CriAtomConfig atomConfig;
        public bool initializesMana;
        public CriManaConfig manaConfig;
        public bool useDecrypter;
        public CriWareDecrypter.Config DecrypterConfig;
        public bool dontInitializeOnAwake;
        public bool dontDestroyOnLoad;
        private static int initializationCount;
        private void Awake()
        {
        }

        protected override void OnEnable()
        {
        }

        private void Start()
        {
        }

        private void OnDestroy()
        {
        }

        public override void CriInternalUpdate()
        {
        }

        public override void CriInternalLateUpdate()
        {
        }

        public void Initialize()
        {
        }

        public void Shutdown()
        {
        }

        public static bool IsInitialized()
        {
            return default(bool);
        }

        public static void AddAudioEffectInterface(IntPtr effect_interface)
        {
        }

        public static bool InitializeFileSystem(CriFsConfig config)
        {
            return default(bool);
        }

        public static bool InitializeAtom(CriAtomConfig config)
        {
            return default(bool);
        }

        public static bool InitializeMana(CriManaConfig config)
        {
            return default(bool);
        }

        private void OnValidate()
        {
        }

        private void ValidateConfigEditorForNotPublic()
        {
        }

        private void ValidateConfigForNotPublic()
        {
        }

        private void ValidateConfigEditor()
        {
        }

        private void ValidateConfig()
        {
        }

        public CriWareInitializer()
        {
        }
    }
}

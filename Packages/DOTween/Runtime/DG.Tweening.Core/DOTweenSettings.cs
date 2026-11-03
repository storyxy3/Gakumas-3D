namespace DG.Tweening.Core
{
    using global::System;
    using global::DG.Tweening;
    using global::DG.Tweening.Core;
    using global::DG.Tweening.Core.Enums;
    using global::UnityEngine;

    public class DOTweenSettings : ScriptableObject
    {
        public enum SettingsLocation
        {
            AssetsDirectory,
            DOTweenDirectory,
            DemigiantDirectory
        }

        [Serializable]
        public class SafeModeOptions
        {
            public NestedTweenFailureBehaviour nestedTweenFailureBehaviour;
            public SafeModeOptions()
            {
            }
        }

        [Serializable]
        public class ModulesSetup
        {
            public bool showPanel;
            public bool audioEnabled;
            public bool physicsEnabled;
            public bool physics2DEnabled;
            public bool spriteEnabled;
            public bool uiEnabled;
            public bool textMeshProEnabled;
            public bool tk2DEnabled;
            public bool deAudioEnabled;
            public bool deUnityExtendedEnabled;
            public ModulesSetup()
            {
            }
        }

        public const string AssetName = "DOTweenSettings";
        public const string AssetFullFilename = "DOTweenSettings.asset";
        public bool useSafeMode;
        public SafeModeOptions safeModeOptions;
        public float timeScale;
        public bool useSmoothDeltaTime;
        public float maxSmoothUnscaledTime;
        public RewindCallbackMode rewindCallbackMode;
        public bool showUnityEditorReport;
        public LogBehaviour logBehaviour;
        public bool drawGizmos;
        public bool defaultRecyclable;
        public AutoPlay defaultAutoPlay;
        public UpdateType defaultUpdateType;
        public bool defaultTimeScaleIndependent;
        public Ease defaultEaseType;
        public float defaultEaseOvershootOrAmplitude;
        public float defaultEasePeriod;
        public bool defaultAutoKill;
        public LoopType defaultLoopType;
        public bool debugMode;
        public bool debugStoreTargetId;
        public bool showPreviewPanel;
        public SettingsLocation storeSettingsLocation;
        public ModulesSetup modules;
        public bool showPlayingTweens;
        public bool showPausedTweens;
        public DOTweenSettings()
        {
        }
    }
}

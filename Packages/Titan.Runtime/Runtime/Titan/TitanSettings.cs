namespace Titan
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::DG.Tweening;
    using global::Titan;
    using global::UnityEngine;

    public class TitanSettings : ScriptableObject
    {
        [Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec
        {
            public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();
            public static Func<EaseSetting, int, (EaseSetting x, int i)> _003C_003E9__10_0;
            public static Func<(EaseSetting x, int i), string> _003C_003E9__10_1;
            public static Func<EaseSetting, string> _003C_003E9__13_0;
            public _003C_003Ec()
            {
            }

            internal (EaseSetting, int) _003Cget_EaseIdToSettings_003Eb__10_0(EaseSetting x, int i)
            {
                return default((EaseSetting, int));
            }

            internal string _003Cget_EaseIdToSettings_003Eb__10_1((EaseSetting x, int i) x)
            {
                return null;
            }

            internal string _003Cget_EaseSettingLabels_003Eb__13_0(EaseSetting x)
            {
                return null;
            }
        }

        private static TitanSettings _instance;
        [SerializeField]
        private EaseSetting[] _easeSettings;
        private Dictionary<string, (EaseSetting, int)> _easeIdToSettings;
        [NonSerialized]
        private string[] _easeSettingLabels;
        [SerializeField]
        private bool _supportAnimationTrack;
        public static TitanSettings Instance
        {
            get
            {
                return null;
            }
        }

        public virtual ITweenPlayer TweenPlayer
        {
            get
            {
                return null;
            }
        }

        internal EaseSetting[] EaseSettings
        {
            get
            {
                return null;
            }
        }

        private Dictionary<string, (EaseSetting, int)> EaseIdToSettings
        {
            get
            {
                return null;
            }
        }

        public string[] EaseSettingLabels
        {
            get
            {
                return null;
            }
        }

        public bool SupportAnimationTrack
        {
            get
            {
                return default(bool);
            }
        }

        public int EaseSettingsCount
        {
            get
            {
                return default(int);
            }
        }

        public int GetEaseSettingIndex(string easeId)
        {
            return default(int);
        }

        public EaseSetting GetEaseSetting(int index)
        {
            return null;
        }

        public EaseSetting GetEaseSetting(string easeId)
        {
            return null;
        }

        internal EaseFunction GetEaseFunctionInternal(string easeId, float parameter1, float parameter2)
        {
            return null;
        }

        protected virtual EaseFunction GetEaseFunction(string easeId, float parameter1, float parameter2)
        {
            return null;
        }

        protected virtual double GetCustomEaseDuration(string easeId, float parameter1, float parameter2)
        {
            return default(double);
        }

        public static void SetEase(Tween tween, EaseInfo easeInfo)
        {
        }

        public static double GetEaseDuration(EaseInfo easeInfo)
        {
            return default(double);
        }

        public void OnChanged()
        {
        }

        public virtual VariableInputHandler GetVariableInputHandler()
        {
            return null;
        }

        public virtual IMemberAccessResolver GetMemberAccessResolver()
        {
            return null;
        }

        public virtual IVariableTable GetVariableTable(IVariableTable table)
        {
            return null;
        }

        public virtual float GetDefaultParameter1(TitanEase ease)
        {
            return default(float);
        }

        public virtual float GetDefaultParameter2(TitanEase ease)
        {
            return default(float);
        }

        protected static bool IsDefaultParameterEase(TitanEase ease)
        {
            return default(bool);
        }

        public TitanSettings()
        {
        }
    }
}

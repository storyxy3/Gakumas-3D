namespace Qua.UI
{
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::System.Text;
    using global::System.Text.RegularExpressions;
    using global::Qua.UI;
    using global::TMPro;
    using global::UnityEngine;

    [RequireComponent(typeof(TextMeshProUGUI))]
    [ExecuteAlways]
    public class TextMeshProUGUIRuby : QuaUIBehaviour
    {
        protected class RubyInfo
        {
            public int targetStartIndex;
            public int targetEndIndex;
            public int rubyStartIndex;
            public int rubyEndIndex;
            public RubyInfo()
            {
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass54_0
        {
            public int startIndex;
            public int endIndex;
            public _003C_003Ec__DisplayClass54_0()
            {
            }

            internal bool _003CGetTextRect_003Eb__0(TMP_CharacterInfo x)
            {
                return default(bool);
            }

            internal bool _003CGetTextRect_003Eb__1(TMP_CharacterInfo x)
            {
                return default(bool);
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass56_0
        {
            public int targetOffset;
            public int rubyOffset;
            public TextMeshProUGUIRuby _003C_003E4__this;
            public StringBuilder rubyBuilder;
            public _003C_003Ec__DisplayClass56_0()
            {
            }

            internal string _003CUpdateText_003Eb__0(Match match)
            {
                return null;
            }
        }

        protected const string TargetGroupName = "targetGroup";
        protected const string RubyGroupName = "rubyGroup";
        [SerializeField]
        private TextMeshProUGUI _rubyTMP;
        [SerializeField]
        [TextArea(5, 10)]
        private string _text;
        [SerializeField]
        private string _rubyLineHeight;
        [SerializeField]
        private float _rubyMargin;
        [SerializeField]
        private bool _adjustXPosition;
        private Regex _rubyRegex;
        private TextMeshProUGUI _targetTMP;
        private bool _isTargetTextDirty;
        private bool _isRubyTextDirty;
        [CompilerGenerated]
        private List<RubyInfo> _003CRubyInfos_003Ek__BackingField;
        [CompilerGenerated]
        private TMP_TextInfo _003CTargetTextInfo_003Ek__BackingField;
        [CompilerGenerated]
        private TMP_TextInfo _003CRubyTextInfo_003Ek__BackingField;
        [CompilerGenerated]
        private bool _003CHasRuby_003Ek__BackingField;
        protected virtual string RubyPattern
        {
            get
            {
                return null;
            }
        }

        protected Regex RubyRegex
        {
            get
            {
                return null;
            }
        }

        protected List<RubyInfo> RubyInfos
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

        protected TMP_TextInfo TargetTextInfo
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

        protected TMP_TextInfo RubyTextInfo
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

        public TextMeshProUGUI TargetTMP
        {
            get
            {
                return null;
            }
        }

        public TextMeshProUGUI RubyTMP
        {
            get
            {
                return null;
            }
        }

        public string Text
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public string RubyLineHeight
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public float RubyMargin
        {
            get
            {
                return default(float);
            }

            set
            {
            }
        }

        public bool AdjustXPosition
        {
            get
            {
                return default(bool);
            }

            set
            {
            }
        }

        public bool HasRuby
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

        protected override void Awake()
        {
        }

        protected override void OnEnable()
        {
        }

        protected override void OnDisable()
        {
        }

        protected override void OnRectTransformDimensionsChange()
        {
        }

        private void OnTextChanged(Object obj)
        {
        }

        private void UpdateRubyPosition()
        {
        }

        protected static bool ValidateTextInfo(TMP_TextInfo textInfo)
        {
            return default(bool);
        }

        private static Rect GetTextRect(TMP_TextInfo textInfo, int startIndex, int endIndex)
        {
            return default(Rect);
        }

        private static void OffsetCharacterPosition(TMP_TextInfo textInfo, int charIndex, Vector3 offset)
        {
        }

        private void UpdateText()
        {
        }

        private TextMeshProUGUI AddRubyTextObject()
        {
            return null;
        }

        protected virtual void OnUpdateText()
        {
        }

        protected virtual string GetRubyLineHeight(int lineIndex)
        {
            return null;
        }

        public TextMeshProUGUIRuby()
        {
        }
    }
}

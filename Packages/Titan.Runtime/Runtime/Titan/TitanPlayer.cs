namespace Titan
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::DG.Tweening;
    using global::Titan;
    using global::UnityEngine;
    using global::UnityEngine.Playables;

    [ExecuteAlways]
    [RequireComponent(typeof(PlayableDirector))]
    public class TitanPlayer : MonoBehaviour, IValueResolver, IVariableTable, IVariableDefinitionHolder
    {
        private enum AutoExecutionType
        {
            None,
            PlayOnAwake,
            CreateOnAwake,
            [InspectorName("Play On Enable (DisableでKill)")]
            PlayOnEnableKillOnDisable,
            [InspectorName("Play On Enable (DisableでComplete)")]
            PlayOnEnableCompleteOnDisable
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        internal struct _003C_003Ec__DisplayClass58_0<T>
        {
            public object obj;
            public string id;
        }

        [SerializeField]
        private PlayableDirector _director;
        [SerializeField]
        [HideInInspector]
        private int _loopCount;
        [SerializeField]
        [HideInInspector]
        private LoopType _loopType;
        [SerializeField]
        private VariableDefinition[] _variables;
        [SerializeField]
        private AutoExecutionType _autoType;
        private Dictionary<string, VariableDefinition> _variableMap;
        [CompilerGenerated]
        private ITimelineTween _003CCurrent_003Ek__BackingField;
        [CompilerGenerated]
        private string _003CCurrentGroupName_003Ek__BackingField;
        private readonly Dictionary<string, object> _parameters;
        private Parser _parser;
        [CompilerGenerated]
        private bool _003CIsRevertEnabled_003Ek__BackingField;
        [CompilerGenerated]
        private bool _003CAutoRevert_003Ek__BackingField;
        private static Action<TitanPlayer, string> _onCreateTween;
        private static Action<TitanPlayer> _onAwake;
        public PlayableDirector Director
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public IReadOnlyList<VariableDefinition> Variables
        {
            get
            {
                return null;
            }
        }

        IList<VariableDefinition> Titan.IVariableDefinitionHolder.Variables
        {
            get
            {
                return null;
            }
        }

        private Dictionary<string, VariableDefinition> VariableMap
        {
            get
            {
                return null;
            }
        }

        public ITimelineTween Current
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

        public string CurrentGroupName
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

        private Parser Parser
        {
            get
            {
                return null;
            }
        }

        public bool IsRevertEnabled
        {
            [CompilerGenerated]
            get
            {
                return default(bool);
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public bool AutoRevert
        {
            [CompilerGenerated]
            get
            {
                return default(bool);
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public static event Action<TitanPlayer, string> OnCreateTween
        {
            add
            {
            }

            remove
            {
            }
        }

        public static event Action<TitanPlayer> OnAwake
        {
            add
            {
            }

            remove
            {
            }
        }

        private void Awake()
        {
        }

        private void OnEnable()
        {
        }

        private void OnDisable()
        {
        }

        public void SetGroup(string groupName)
        {
        }

        public void SetGroups(params string[] groupNames)
        {
        }

        public double GetDuration([Optional] string groupName)
        {
            return default(double);
        }

        public ITimelineTween Play([Optional] string groupName)
        {
            return null;
        }

        public ITimelineTween CreateTween([Optional] string groupName)
        {
            return null;
        }

        public void Kill(bool complete = false)
        {
        }

        private ITimelineTween InternalCreateTween([Optional] string groupName)
        {
            return null;
        }

        void Titan.IValueResolver.OnWillCreateTween()
        {
        }

        public void SetValue<T>(string id, T value)
        {
        }

        public void RemoveValue(string id)
        {
        }

        public PlayableDirector GetDirector()
        {
            return null;
        }

        public bool TryGetValue<T>(string id, out T result)
        {
            throw null;
        }

        public Value Evaluate(string exp)
        {
            return null;
        }

        public IDisposable ParametersOverriddenScope(IEnumerable<KeyValuePair<string, object>> parameters)
        {
            return null;
        }

        public Value GetValue(string id)
        {
            return null;
        }

        public TitanPlayer()
        {
        }

        [CompilerGenerated]
        internal static bool _003CTryGetValue_003Eg__TryGetValueOfT_007C58_0<T>(object value, out T res, ref _003C_003Ec__DisplayClass58_0<T> P_2)
        {
            throw null;
        }
    }
}

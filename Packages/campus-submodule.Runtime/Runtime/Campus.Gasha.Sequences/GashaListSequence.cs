namespace Campus.Gasha.Sequences
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::Campus.Gasha;
    using global::Campus.Gasha.Sequences;
    using global::Campus.Gasha.VolumetricLight;
    using global::Campus.Live.Equipment;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;
    using global::JetBrains.Annotations;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Timeline;

    public class GashaListSequence : GashaSequenceBase, INotificationReceiver, ISequenceDirector
    {
        [Serializable]
        public class LightUpSeKeyValue
        {
            public RarityType rarityType;
            public string seAssetName;
            public LightUpSeKeyValue()
            {
            }
        }

        [Serializable]
        public enum OverrideRarity
        {
            None,
            R,
            SR,
            SSR
        }

        [Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec
        {
            public static readonly _003C_003Ec _003C_003E9;
            public static Func<LightParam, bool> _003C_003E9__20_0;
            public static Func<TrackAsset, bool> _003C_003E9__23_0;
            public static Func<GashaLightUpMarker, double> _003C_003E9__23_1;
            public static Func<GashaLightUpMarker, double> _003C_003E9__23_2;
            public static Func<GashaLightListStartMarker, bool> _003C_003E9__25_0;
            public static Func<GashaLightListStartMarker, int> _003C_003E9__25_1;
            public _003C_003Ec()
            {
            }

            internal bool _003CBind_003Eb__20_0(LightParam x)
            {
                return default(bool);
            }

            internal bool _003CGetLightUpMarkerTimes_003Eb__23_0(TrackAsset x)
            {
                return default(bool);
            }

            internal double _003CGetLightUpMarkerTimes_003Eb__23_1(GashaLightUpMarker x)
            {
                return default(double);
            }

            internal double _003CGetLightUpMarkerTimes_003Eb__23_2(GashaLightUpMarker x)
            {
                return default(double);
            }

            internal bool _003CGetInitialTime_003Eb__25_0(GashaLightListStartMarker x)
            {
                return default(bool);
            }

            internal int _003CGetInitialTime_003Eb__25_1(GashaLightListStartMarker x)
            {
                return default(int);
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass21_0
        {
            public CancellationToken ct;
            public _003C_003Ec__DisplayClass21_0()
            {
            }

            internal UniTask _003CSetup_003Eb__0(LightUpSeKeyValue lightUpSeKeyValue)
            {
                return default(UniTask);
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass21_1
        {
            public LightParam param;
            public _003C_003Ec__DisplayClass21_1()
            {
            }

            internal bool _003CSetup_003Eb__1(LightUpSeKeyValue x)
            {
                return default(bool);
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass22_0
        {
            public double initialTime;
            public _003C_003Ec__DisplayClass22_0()
            {
            }

            internal bool _003CPlay_003Eb__0(double x)
            {
                return default(bool);
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass25_0
        {
            public int lightCount;
            public _003C_003Ec__DisplayClass25_0()
            {
            }

            internal bool _003CGetInitialTime_003Eb__2(GashaLightListStartMarker x)
            {
                return default(bool);
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003COnClickedAsync_003Ed__34 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public GashaListSequence _003C_003E4__this;
            private UniTask.Awaiter _003C_003Eu__1;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CPlay_003Ed__22 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public GashaListSequence _003C_003E4__this;
            private UniTask.Awaiter _003C_003Eu__1;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CSetup_003Ed__21 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public CancellationToken ct;
            public GashaListSequence _003C_003E4__this;
            private UniTask.Awaiter _003C_003Eu__1;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        public GashaVolumetricLight[] lights;
        public LightUpSeKeyValue[] seKeyValues;
        private LightListSequenceParam _param;
        [NonSerialized]
        private int _lightUpIndex;
        private bool _requestReversalTap;
        private CancellationTokenSource _sequenceCts;
        private List<string> _lightUpSeNames;
        public PlayableDirector director;
        public string reversalSeAssetName;
        [CanBeNull]
        public LiveEquipmentController equipmentController;
        [CanBeNull]
        public LiveEquipmentReceiver equipmentReceiver;
        private GashaPlayableDirectorHandler _directorHandler;
        public float lightUpSeVolume;
        public float tapRestrictAfterReversal;
        public OverrideRarity overrideRarity;
        private bool _isProcessingOnClicked;
        public PlayableDirector Director
        {
            get
            {
                return null;
            }
        }

        public void Bind(LightListSequenceParam param)
        {
        }

        [AsyncStateMachine(typeof(_003CSetup_003Ed__21))]
        public override UniTask Setup([Optional] CancellationToken ct)
        {
            return default(UniTask);
        }

        [AsyncStateMachine(typeof(_003CPlay_003Ed__22))]
        public override UniTask Play()
        {
            return default(UniTask);
        }

        private double[] GetLightUpMarkerTimes()
        {
            return null;
        }

        private int[] GetLightindexMap(int lightCount)
        {
            return null;
        }

        private double GetInitialTime(int lightCount)
        {
            return default(double);
        }

        public override void Stop()
        {
        }

        public override void Pause()
        {
        }

        public override void UnPause()
        {
        }

        private void LightUpNext(bool playSe = true)
        {
        }

        public void LightDown()
        {
        }

        private bool TryPlayReversal()
        {
            return default(bool);
        }

        private void LightUpAll()
        {
        }

        public override void OnClicked()
        {
        }

        [AsyncStateMachine(typeof(_003COnClickedAsync_003Ed__34))]
        private UniTask OnClickedAsync()
        {
            return default(UniTask);
        }

        public void OnNotify(Playable origin, INotification notification, object context)
        {
        }

        private LightParam[] OverrideRarityParam(LightParam[] original, OverrideRarity targetRarity)
        {
            return null;
        }

        public GashaListSequence()
        {
        }

        [CompilerGenerated]
        private bool _003COnClicked_003Eb__33_0()
        {
            return default(bool);
        }

        [CompilerGenerated]
        internal static LightParam _003COverrideRarityParam_003Eg__OverrideRarity_007C36_0(LightParam lightParam, RarityType rarityType)
        {
            return null;
        }
    }
}

namespace Campus.Gasha
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::Campus.Gasha;
    using global::Campus.Gasha.Sequences;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;

    public static class GahsaBindUseCase
    {
        public class Result
        {
            public List<(GashaId gashaId, GashaSequenceBase sequence)> sequences;
            public List<GashaSequenceBase> cardSequences;
            public GashaGlobalEffect globalEffect;
            public Result()
            {
            }
        }

        [Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec
        {
            public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();
            public static Func<GashaCardModel.CardInfo, LightParam> _003C_003E9__1_2;
            public static Predicate<(GashaId gashaId, GashaSequenceBase sequence)> _003C_003E9__1_0;
            public static Predicate<(GashaId gashaId, GashaSequenceBase sequence)> _003C_003E9__1_1;
            public _003C_003Ec()
            {
            }

            internal LightParam _003CExecute_003Eb__1_2(GashaCardModel.CardInfo x)
            {
                return null;
            }

            internal bool _003CExecute_003Eb__1_0((GashaId gashaId, GashaSequenceBase sequence) x)
            {
                return default(bool);
            }

            internal bool _003CExecute_003Eb__1_1((GashaId gashaId, GashaSequenceBase sequence) x)
            {
                return default(bool);
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CExecute_003Ed__1 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder<Result> _003C_003Et__builder;
            public GashaId[] gashaIds;
            public GashaSceneModel sceneModel;
            public GashaCardModel cardModel;
            public GashaTimelineController timelineController;
            public GashaTimelineController.GashaTimelineBindParam bindParam;
            public GashaBgmModel bgmModel;
            public CancellationToken ct;
            private Result _003Cresult_003E5__2;
            private UniTask.Awaiter _003C_003Eu__1;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        [AsyncStateMachine(typeof(_003CExecute_003Ed__1))]
        public static UniTask<Result> Execute(GashaTimelineController timelineController, GashaTimelineController.GashaTimelineBindParam bindParam, GashaId[] gashaIds, GashaSceneModel sceneModel, GashaCardModel cardModel, GashaBgmModel bgmModel, CancellationToken ct)
        {
            return default(UniTask<Result>);
        }
    }
}

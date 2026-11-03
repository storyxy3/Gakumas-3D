namespace UniRx.Triggers
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::UniRx;
    using global::UniRx.Triggers;
    using global::UnityEngine;

    [DisallowMultipleComponent]
    public class ObservableStateMachineTrigger : StateMachineBehaviour
    {
        public class OnStateInfo
        {
            [CompilerGenerated]
            private Animator _003CAnimator_003Ek__BackingField;
            [CompilerGenerated]
            private AnimatorStateInfo _003CStateInfo_003Ek__BackingField;
            [CompilerGenerated]
            private int _003CLayerIndex_003Ek__BackingField;
            private Animator Animator
            {
                [CompilerGenerated]
                set
                {
                }
            }

            private AnimatorStateInfo StateInfo
            {
                [CompilerGenerated]
                set
                {
                }
            }

            private int LayerIndex
            {
                [CompilerGenerated]
                set
                {
                }
            }

            public OnStateInfo(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
            {
            }
        }

        public class OnStateMachineInfo
        {
            [CompilerGenerated]
            private Animator _003CAnimator_003Ek__BackingField;
            [CompilerGenerated]
            private int _003CStateMachinePathHash_003Ek__BackingField;
            private Animator Animator
            {
                [CompilerGenerated]
                set
                {
                }
            }

            private int StateMachinePathHash
            {
                [CompilerGenerated]
                set
                {
                }
            }

            public OnStateMachineInfo(Animator animator, int stateMachinePathHash)
            {
            }
        }

        private Subject<OnStateInfo> onStateExit;
        private Subject<OnStateInfo> onStateEnter;
        private Subject<OnStateInfo> onStateIK;
        private Subject<OnStateInfo> onStateUpdate;
        private Subject<OnStateMachineInfo> onStateMachineEnter;
        private Subject<OnStateMachineInfo> onStateMachineExit;
        public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
        }

        public IObservable<OnStateInfo> OnStateExitAsObservable()
        {
            return null;
        }

        public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
        }

        public IObservable<OnStateInfo> OnStateEnterAsObservable()
        {
            return null;
        }

        public override void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
        }

        public IObservable<OnStateInfo> OnStateIKAsObservable()
        {
            return null;
        }

        public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
        }

        public IObservable<OnStateInfo> OnStateUpdateAsObservable()
        {
            return null;
        }

        public override void OnStateMachineEnter(Animator animator, int stateMachinePathHash)
        {
        }

        public IObservable<OnStateMachineInfo> OnStateMachineEnterAsObservable()
        {
            return null;
        }

        public override void OnStateMachineExit(Animator animator, int stateMachinePathHash)
        {
        }

        public IObservable<OnStateMachineInfo> OnStateMachineExitAsObservable()
        {
            return null;
        }

        public ObservableStateMachineTrigger()
        {
        }
    }
}

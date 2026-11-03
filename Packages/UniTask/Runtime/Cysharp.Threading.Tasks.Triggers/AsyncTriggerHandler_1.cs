namespace Cysharp.Threading.Tasks.Triggers
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::System.Threading;
    using global::System.Threading.Tasks.Sources;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.Triggers;
    using global::UnityEngine;
    using global::UnityEngine.EventSystems;
    using global::UnityEngine.ParticleSystemJobs;

    public sealed class AsyncTriggerHandler<T> : IAsyncOneShotTrigger, IUniTaskSource<T>, IUniTaskSource, IValueTaskSource, IValueTaskSource<T>, ITriggerHandler<T>, IDisposable, IAsyncFixedUpdateHandler, IAsyncLateUpdateHandler, IAsyncOnAnimatorIKHandler, IAsyncOnAnimatorMoveHandler, IAsyncOnApplicationFocusHandler, IAsyncOnApplicationPauseHandler, IAsyncOnApplicationQuitHandler, IAsyncOnAudioFilterReadHandler, IAsyncOnBecameInvisibleHandler, IAsyncOnBecameVisibleHandler, IAsyncOnBeforeTransformParentChangedHandler, IAsyncOnCanvasGroupChangedHandler, IAsyncOnCollisionEnterHandler, IAsyncOnCollisionEnter2DHandler, IAsyncOnCollisionExitHandler, IAsyncOnCollisionExit2DHandler, IAsyncOnCollisionStayHandler, IAsyncOnCollisionStay2DHandler, IAsyncOnControllerColliderHitHandler, IAsyncOnDisableHandler, IAsyncOnDrawGizmosHandler, IAsyncOnDrawGizmosSelectedHandler, IAsyncOnEnableHandler, IAsyncOnGUIHandler, IAsyncOnJointBreakHandler, IAsyncOnJointBreak2DHandler, IAsyncOnParticleCollisionHandler, IAsyncOnParticleSystemStoppedHandler, IAsyncOnParticleTriggerHandler, IAsyncOnParticleUpdateJobScheduledHandler, IAsyncOnPostRenderHandler, IAsyncOnPreCullHandler, IAsyncOnPreRenderHandler, IAsyncOnRectTransformDimensionsChangeHandler, IAsyncOnRectTransformRemovedHandler, IAsyncOnRenderImageHandler, IAsyncOnRenderObjectHandler, IAsyncOnServerInitializedHandler, IAsyncOnTransformChildrenChangedHandler, IAsyncOnTransformParentChangedHandler, IAsyncOnTriggerEnterHandler, IAsyncOnTriggerEnter2DHandler, IAsyncOnTriggerExitHandler, IAsyncOnTriggerExit2DHandler, IAsyncOnTriggerStayHandler, IAsyncOnTriggerStay2DHandler, IAsyncOnValidateHandler, IAsyncOnWillRenderObjectHandler, IAsyncResetHandler, IAsyncUpdateHandler, IAsyncOnBeginDragHandler, IAsyncOnCancelHandler, IAsyncOnDeselectHandler, IAsyncOnDragHandler, IAsyncOnDropHandler, IAsyncOnEndDragHandler, IAsyncOnInitializePotentialDragHandler, IAsyncOnMoveHandler, IAsyncOnPointerClickHandler, IAsyncOnPointerDownHandler, IAsyncOnPointerEnterHandler, IAsyncOnPointerExitHandler, IAsyncOnPointerUpHandler, IAsyncOnScrollHandler, IAsyncOnSelectHandler, IAsyncOnSubmitHandler, IAsyncOnUpdateSelectedHandler
    {
        private static Action<object> cancellationCallback;
        private readonly AsyncTriggerBase<T> trigger;
        private CancellationToken cancellationToken;
        private CancellationTokenRegistration registration;
        private bool isDisposed;
        private bool callOnce;
        private UniTaskCompletionSourceCore<T> core;
        [CompilerGenerated]
        private ITriggerHandler<T> _003CCysharp_002EThreading_002ETasks_002EITriggerHandler_003CT_003E_002EPrev_003Ek__BackingField;
        [CompilerGenerated]
        private ITriggerHandler<T> _003CCysharp_002EThreading_002ETasks_002EITriggerHandler_003CT_003E_002ENext_003Ek__BackingField;
        ITriggerHandler<T> Cysharp.Threading.Tasks.ITriggerHandler<T>.Prev
        {
            [CompilerGenerated]
            get
            {
                return null;
            }

            [CompilerGenerated]
            set
            {
            }
        }

        ITriggerHandler<T> Cysharp.Threading.Tasks.ITriggerHandler<T>.Next
        {
            [CompilerGenerated]
            get
            {
                return null;
            }

            [CompilerGenerated]
            set
            {
            }
        }

        UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOneShotTrigger.OneShotAsync()
        {
            return default(UniTask);
        }

        internal AsyncTriggerHandler(AsyncTriggerBase<T> trigger, bool callOnce)
        {
        }

        internal AsyncTriggerHandler(AsyncTriggerBase<T> trigger, CancellationToken cancellationToken, bool callOnce)
        {
        }

        private static void CancellationCallback(object state)
        {
        }

        public void Dispose()
        {
        }

        T Cysharp.Threading.Tasks.IUniTaskSource<T>.GetResult(short token)
        {
            return default(T);
        }

        void Cysharp.Threading.Tasks.ITriggerHandler<T>.OnNext(T value)
        {
        }

        void Cysharp.Threading.Tasks.ITriggerHandler<T>.OnCompleted()
        {
        }

        void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token)
        {
        }

        UniTaskStatus Cysharp.Threading.Tasks.IUniTaskSource.GetStatus(short token)
        {
            return default(UniTaskStatus);
        }

        UniTaskStatus Cysharp.Threading.Tasks.IUniTaskSource.UnsafeGetStatus()
        {
            return default(UniTaskStatus);
        }

        void Cysharp.Threading.Tasks.IUniTaskSource.OnCompleted(Action<object> continuation, object state, short token)
        {
        }

        UniTask Cysharp.Threading.Tasks.Triggers.IAsyncFixedUpdateHandler.FixedUpdateAsync()
        {
            return default(UniTask);
        }

        UniTask Cysharp.Threading.Tasks.Triggers.IAsyncLateUpdateHandler.LateUpdateAsync()
        {
            return default(UniTask);
        }

        UniTask<int> Cysharp.Threading.Tasks.Triggers.IAsyncOnAnimatorIKHandler.OnAnimatorIKAsync()
        {
            return default(UniTask<int>);
        }

        UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnAnimatorMoveHandler.OnAnimatorMoveAsync()
        {
            return default(UniTask);
        }

        UniTask<bool> Cysharp.Threading.Tasks.Triggers.IAsyncOnApplicationFocusHandler.OnApplicationFocusAsync()
        {
            return default(UniTask<bool>);
        }

        UniTask<bool> Cysharp.Threading.Tasks.Triggers.IAsyncOnApplicationPauseHandler.OnApplicationPauseAsync()
        {
            return default(UniTask<bool>);
        }

        UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnApplicationQuitHandler.OnApplicationQuitAsync()
        {
            return default(UniTask);
        }

        UniTask<(float[], int)> Cysharp.Threading.Tasks.Triggers.IAsyncOnAudioFilterReadHandler.OnAudioFilterReadAsync()
        {
            return default(UniTask<(float[], int)>);
        }

        UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnBecameInvisibleHandler.OnBecameInvisibleAsync()
        {
            return default(UniTask);
        }

        UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnBecameVisibleHandler.OnBecameVisibleAsync()
        {
            return default(UniTask);
        }

        UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnBeforeTransformParentChangedHandler.OnBeforeTransformParentChangedAsync()
        {
            return default(UniTask);
        }

        UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnCanvasGroupChangedHandler.OnCanvasGroupChangedAsync()
        {
            return default(UniTask);
        }

        UniTask<Collision> Cysharp.Threading.Tasks.Triggers.IAsyncOnCollisionEnterHandler.OnCollisionEnterAsync()
        {
            return default(UniTask<Collision>);
        }

        UniTask<Collision2D> Cysharp.Threading.Tasks.Triggers.IAsyncOnCollisionEnter2DHandler.OnCollisionEnter2DAsync()
        {
            return default(UniTask<Collision2D>);
        }

        UniTask<Collision> Cysharp.Threading.Tasks.Triggers.IAsyncOnCollisionExitHandler.OnCollisionExitAsync()
        {
            return default(UniTask<Collision>);
        }

        UniTask<Collision2D> Cysharp.Threading.Tasks.Triggers.IAsyncOnCollisionExit2DHandler.OnCollisionExit2DAsync()
        {
            return default(UniTask<Collision2D>);
        }

        UniTask<Collision> Cysharp.Threading.Tasks.Triggers.IAsyncOnCollisionStayHandler.OnCollisionStayAsync()
        {
            return default(UniTask<Collision>);
        }

        UniTask<Collision2D> Cysharp.Threading.Tasks.Triggers.IAsyncOnCollisionStay2DHandler.OnCollisionStay2DAsync()
        {
            return default(UniTask<Collision2D>);
        }

        UniTask<ControllerColliderHit> Cysharp.Threading.Tasks.Triggers.IAsyncOnControllerColliderHitHandler.OnControllerColliderHitAsync()
        {
            return default(UniTask<ControllerColliderHit>);
        }

        UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnDisableHandler.OnDisableAsync()
        {
            return default(UniTask);
        }

        UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnDrawGizmosHandler.OnDrawGizmosAsync()
        {
            return default(UniTask);
        }

        UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnDrawGizmosSelectedHandler.OnDrawGizmosSelectedAsync()
        {
            return default(UniTask);
        }

        UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnEnableHandler.OnEnableAsync()
        {
            return default(UniTask);
        }

        UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnGUIHandler.OnGUIAsync()
        {
            return default(UniTask);
        }

        UniTask<float> Cysharp.Threading.Tasks.Triggers.IAsyncOnJointBreakHandler.OnJointBreakAsync()
        {
            return default(UniTask<float>);
        }

        UniTask<Joint2D> Cysharp.Threading.Tasks.Triggers.IAsyncOnJointBreak2DHandler.OnJointBreak2DAsync()
        {
            return default(UniTask<Joint2D>);
        }

        UniTask<GameObject> Cysharp.Threading.Tasks.Triggers.IAsyncOnParticleCollisionHandler.OnParticleCollisionAsync()
        {
            return default(UniTask<GameObject>);
        }

        UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnParticleSystemStoppedHandler.OnParticleSystemStoppedAsync()
        {
            return default(UniTask);
        }

        UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnParticleTriggerHandler.OnParticleTriggerAsync()
        {
            return default(UniTask);
        }

        UniTask<ParticleSystemJobData> Cysharp.Threading.Tasks.Triggers.IAsyncOnParticleUpdateJobScheduledHandler.OnParticleUpdateJobScheduledAsync()
        {
            return default(UniTask<ParticleSystemJobData>);
        }

        UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnPostRenderHandler.OnPostRenderAsync()
        {
            return default(UniTask);
        }

        UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnPreCullHandler.OnPreCullAsync()
        {
            return default(UniTask);
        }

        UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnPreRenderHandler.OnPreRenderAsync()
        {
            return default(UniTask);
        }

        UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnRectTransformDimensionsChangeHandler.OnRectTransformDimensionsChangeAsync()
        {
            return default(UniTask);
        }

        UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnRectTransformRemovedHandler.OnRectTransformRemovedAsync()
        {
            return default(UniTask);
        }

        UniTask<(RenderTexture, RenderTexture)> Cysharp.Threading.Tasks.Triggers.IAsyncOnRenderImageHandler.OnRenderImageAsync()
        {
            return default(UniTask<(RenderTexture, RenderTexture)>);
        }

        UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnRenderObjectHandler.OnRenderObjectAsync()
        {
            return default(UniTask);
        }

        UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnServerInitializedHandler.OnServerInitializedAsync()
        {
            return default(UniTask);
        }

        UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnTransformChildrenChangedHandler.OnTransformChildrenChangedAsync()
        {
            return default(UniTask);
        }

        UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnTransformParentChangedHandler.OnTransformParentChangedAsync()
        {
            return default(UniTask);
        }

        UniTask<Collider> Cysharp.Threading.Tasks.Triggers.IAsyncOnTriggerEnterHandler.OnTriggerEnterAsync()
        {
            return default(UniTask<Collider>);
        }

        UniTask<Collider2D> Cysharp.Threading.Tasks.Triggers.IAsyncOnTriggerEnter2DHandler.OnTriggerEnter2DAsync()
        {
            return default(UniTask<Collider2D>);
        }

        UniTask<Collider> Cysharp.Threading.Tasks.Triggers.IAsyncOnTriggerExitHandler.OnTriggerExitAsync()
        {
            return default(UniTask<Collider>);
        }

        UniTask<Collider2D> Cysharp.Threading.Tasks.Triggers.IAsyncOnTriggerExit2DHandler.OnTriggerExit2DAsync()
        {
            return default(UniTask<Collider2D>);
        }

        UniTask<Collider> Cysharp.Threading.Tasks.Triggers.IAsyncOnTriggerStayHandler.OnTriggerStayAsync()
        {
            return default(UniTask<Collider>);
        }

        UniTask<Collider2D> Cysharp.Threading.Tasks.Triggers.IAsyncOnTriggerStay2DHandler.OnTriggerStay2DAsync()
        {
            return default(UniTask<Collider2D>);
        }

        UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnValidateHandler.OnValidateAsync()
        {
            return default(UniTask);
        }

        UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnWillRenderObjectHandler.OnWillRenderObjectAsync()
        {
            return default(UniTask);
        }

        UniTask Cysharp.Threading.Tasks.Triggers.IAsyncResetHandler.ResetAsync()
        {
            return default(UniTask);
        }

        UniTask Cysharp.Threading.Tasks.Triggers.IAsyncUpdateHandler.UpdateAsync()
        {
            return default(UniTask);
        }

        UniTask<PointerEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnBeginDragHandler.OnBeginDragAsync()
        {
            return default(UniTask<PointerEventData>);
        }

        UniTask<BaseEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnCancelHandler.OnCancelAsync()
        {
            return default(UniTask<BaseEventData>);
        }

        UniTask<BaseEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnDeselectHandler.OnDeselectAsync()
        {
            return default(UniTask<BaseEventData>);
        }

        UniTask<PointerEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnDragHandler.OnDragAsync()
        {
            return default(UniTask<PointerEventData>);
        }

        UniTask<PointerEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnDropHandler.OnDropAsync()
        {
            return default(UniTask<PointerEventData>);
        }

        UniTask<PointerEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnEndDragHandler.OnEndDragAsync()
        {
            return default(UniTask<PointerEventData>);
        }

        UniTask<PointerEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnInitializePotentialDragHandler.OnInitializePotentialDragAsync()
        {
            return default(UniTask<PointerEventData>);
        }

        UniTask<AxisEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnMoveHandler.OnMoveAsync()
        {
            return default(UniTask<AxisEventData>);
        }

        UniTask<PointerEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnPointerClickHandler.OnPointerClickAsync()
        {
            return default(UniTask<PointerEventData>);
        }

        UniTask<PointerEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnPointerDownHandler.OnPointerDownAsync()
        {
            return default(UniTask<PointerEventData>);
        }

        UniTask<PointerEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnPointerEnterHandler.OnPointerEnterAsync()
        {
            return default(UniTask<PointerEventData>);
        }

        UniTask<PointerEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnPointerExitHandler.OnPointerExitAsync()
        {
            return default(UniTask<PointerEventData>);
        }

        UniTask<PointerEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnPointerUpHandler.OnPointerUpAsync()
        {
            return default(UniTask<PointerEventData>);
        }

        UniTask<PointerEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnScrollHandler.OnScrollAsync()
        {
            return default(UniTask<PointerEventData>);
        }

        UniTask<BaseEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnSelectHandler.OnSelectAsync()
        {
            return default(UniTask<BaseEventData>);
        }

        UniTask<BaseEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnSubmitHandler.OnSubmitAsync()
        {
            return default(UniTask<BaseEventData>);
        }

        UniTask<BaseEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnUpdateSelectedHandler.OnUpdateSelectedAsync()
        {
            return default(UniTask<BaseEventData>);
        }
    }
}

namespace Qua.UI
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::Qua.UI;
    using global::Qua.Utility;
    using global::UnityEngine;

    public class UICurveEditor : QuaUIBehaviour
    {
        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass30_0
        {
            public UICurveEditor _003C_003E4__this;
            public DoubleClickGesture clickGesture;
            public Action<int, Vector2> _003C_003E9__1;
            public Action<int, UICurveKeyframe.HandleEdge, Vector2> _003C_003E9__2;
            public Action<int> _003C_003E9__3;
            public _003C_003Ec__DisplayClass30_0()
            {
            }

            internal UICurveKeyframe _003CInitialize_003Eb__0()
            {
                return null;
            }

            internal void _003CInitialize_003Eb__1(int index, Vector2 pos)
            {
            }

            internal void _003CInitialize_003Eb__2(int index, UICurveKeyframe.HandleEdge edge, Vector2 pos)
            {
            }

            internal void _003CInitialize_003Eb__3(int index)
            {
            }

            internal void _003CInitialize_003Eb__4()
            {
            }

            internal void _003CInitialize_003Eb__5()
            {
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003C_003Ec__DisplayClass33_0
        {
            public List<UICurveKeyframe> activesList;
        }

        [SerializeField]
        private AnimationCurveImage _curveImage;
        [SerializeField]
        private UICurveKeyframe _keyframePrefab;
        private SimpleComponentPool<UICurveKeyframe> _keyframePool;
        private AnimationCurve _curve;
        [CompilerGenerated]
        private Action<Vector2> _003COnCurveTappedCallback_003Ek__BackingField;
        [CompilerGenerated]
        private Action<Vector2> _003COnCurveDoubleTappedCallback_003Ek__BackingField;
        [CompilerGenerated]
        private Action<int, Vector2> _003COnKeyframeDraggedCallback_003Ek__BackingField;
        [CompilerGenerated]
        private Action<int> _003COnKeyframeDoubleTappedCallback_003Ek__BackingField;
        [CompilerGenerated]
        private Action<int, UICurveKeyframe.HandleEdge, Vector2> _003COnHandleDraggedCallback_003Ek__BackingField;
        [CompilerGenerated]
        private Action _003COnCurveModified_003Ek__BackingField;
        public AnimationCurveImage CurveImage
        {
            get
            {
                return null;
            }
        }

        public Action<Vector2> OnCurveTappedCallback
        {
            [CompilerGenerated]
            get
            {
                return _003COnCurveTappedCallback_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003COnCurveTappedCallback_003Ek__BackingField = value;
            }
        }

        public Action<Vector2> OnCurveDoubleTappedCallback
        {
            [CompilerGenerated]
            get
            {
                return _003COnCurveDoubleTappedCallback_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003COnCurveDoubleTappedCallback_003Ek__BackingField = value;
            }
        }

        public Action<int, Vector2> OnKeyframeDraggedCallback
        {
            [CompilerGenerated]
            get
            {
                return _003COnKeyframeDraggedCallback_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003COnKeyframeDraggedCallback_003Ek__BackingField = value;
            }
        }

        public Action<int> OnKeyframeDoubleTappedCallback
        {
            [CompilerGenerated]
            get
            {
                return _003COnKeyframeDoubleTappedCallback_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003COnKeyframeDoubleTappedCallback_003Ek__BackingField = value;
            }
        }

        public Action<int, UICurveKeyframe.HandleEdge, Vector2> OnHandleDraggedCallback
        {
            [CompilerGenerated]
            get
            {
                return _003COnHandleDraggedCallback_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003COnHandleDraggedCallback_003Ek__BackingField = value;
            }
        }

        public Action OnCurveModified
        {
            [CompilerGenerated]
            get
            {
                return _003COnCurveModified_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003COnCurveModified_003Ek__BackingField = value;
            }
        }

        public void Initialize()
        {
        }

        public void SetDefaultEvent()
        {
        }

        protected override void OnDestroy()
        {
        }

        public void SetCurve(AnimationCurve curve)
        {
        }

        public void AddKeyframe(Vector2 screenPos, bool rebuildCurve)
        {
        }

        public void RemoveKeyframe(int i, bool rebuildCurve)
        {
        }

        public void SetTangent(int i, UICurveKeyframe.HandleEdge edge, Vector2 deltaPos, bool syncInOut, bool rebuildCurve)
        {
        }

        public void MoveKeyframe(int i, Vector2 screenPos, bool rebuildCurve)
        {
        }

        public void RebuildCurve()
        {
        }

        protected override void OnRectTransformDimensionsChange()
        {
        }

        public UICurveEditor()
        {
        }

        [CompilerGenerated]
        private void _003CSetDefaultEvent_003Eb__31_0(Vector2 pos)
        {
        }

        [CompilerGenerated]
        private void _003CSetDefaultEvent_003Eb__31_1(int i, Vector2 pos)
        {
        }

        [CompilerGenerated]
        private void _003CSetDefaultEvent_003Eb__31_2(int i, UICurveKeyframe.HandleEdge edge, Vector2 pos)
        {
        }

        [CompilerGenerated]
        private void _003CSetDefaultEvent_003Eb__31_3(int i)
        {
        }

        [CompilerGenerated]
        private static UICurveKeyframe _003CSetCurve_003Eg__GetAndRemoveKeyframe_007C33_0(List<UICurveKeyframe> list, int index, ref _003C_003Ec__DisplayClass33_0 P_2)
        {
            return null;
        }
    }
}

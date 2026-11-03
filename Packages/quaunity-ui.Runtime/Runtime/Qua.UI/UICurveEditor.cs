namespace Qua.UI
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::Qua.UI;
    using global::Qua.Utility;
    using global::UnityEngine;

    public class UICurveEditor : QuaUIBehaviour
    {
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
                return null;
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public Action<Vector2> OnCurveDoubleTappedCallback
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

        public Action<int, Vector2> OnKeyframeDraggedCallback
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

        public Action<int> OnKeyframeDoubleTappedCallback
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

        public Action<int, UICurveKeyframe.HandleEdge, Vector2> OnHandleDraggedCallback
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

        public Action OnCurveModified
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
    }
}

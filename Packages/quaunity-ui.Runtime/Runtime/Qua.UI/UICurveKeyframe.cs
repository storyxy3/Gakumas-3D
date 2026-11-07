namespace Qua.UI
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::Qua.UI;
    using global::UnityEngine;
    using global::UnityEngine.UI;

    public class UICurveKeyframe : QuaUIBehaviour
    {
        public enum HandleEdge
        {
            In,
            Out
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass19_0
        {
            public UICurveKeyframe _003C_003E4__this;
            public DragGesture dragGesture;
            public _003C_003Ec__DisplayClass19_0()
            {
            }

            internal void _003CInitialize_003Eb__0()
            {
            }

            internal void _003CInitialize_003Eb__1()
            {
            }

            internal void _003CInitialize_003Eb__2(Vector2 pos)
            {
            }

            internal void _003CInitialize_003Eb__3(Vector2 pos)
            {
            }
        }

        [SerializeField]
        private UICurveHandle _in;
        [SerializeField]
        private UICurveHandle _out;
        [SerializeField]
        private Graphic _dragGraphic;
        [CompilerGenerated]
        private Action<int, Vector2> _003COnKeyframeDraggedCallback_003Ek__BackingField;
        [CompilerGenerated]
        private Action<int, HandleEdge, Vector2> _003COnHandleDraggedCallback_003Ek__BackingField;
        [CompilerGenerated]
        private Action<int> _003COnKeyframeDoubleTappedCallback_003Ek__BackingField;
        private int _index;
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

        public Action<int, HandleEdge, Vector2> OnHandleDraggedCallback
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

        public int Index
        {
            get
            {
                return default(int);
            }
        }

        public void Initialize()
        {
        }

        private void OnHandleDragged(Vector2 screenPos, HandleEdge edge)
        {
        }

        [MethodImpl(256)]
        public static bool ScreenPointToLocalPointInGraphic(Graphic graphic, Vector2 screenPos, out Vector2 localPoint)
        {
            throw null;
        }

        public void SetTangent(int index, bool isEnd, ref Keyframe kf, ref Vector2 curveAreaSize, ref Vector2 valueRange)
        {
        }

        [MethodImpl(256)]
        private static float TangentToDegree(float tangent, float aspect)
        {
            return default(float);
        }

        [MethodImpl(256)]
        private static float GetWeight(bool isZero, float weight, WeightedMode mode)
        {
            return default(float);
        }

        [MethodImpl(256)]
        private static float GetTangentMultiplier(ref Vector2 areaSize, ref Vector2 valueRange)
        {
            return default(float);
        }

        [MethodImpl(256)]
        private static float GetAspect(ref Vector2 vec)
        {
            return default(float);
        }

        public UICurveKeyframe()
        {
        }
    }
}

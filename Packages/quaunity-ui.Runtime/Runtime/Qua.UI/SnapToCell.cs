namespace Qua.UI
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::Qua.UI;
    using global::UnityEngine;

    public class SnapToCell : MonoBehaviour
    {
        private const float ThresholdSpeed = 400f;
        [CompilerGenerated]
        private int _003CSnappedIndex_003Ek__BackingField;
        [CompilerGenerated]
        private bool _003CIsSnapping_003Ek__BackingField;
        protected IListPresenter _listPresenter;
        protected IListView _listView;
        protected DragGesture _dragGesture;
        private float _cellSize;
        protected bool _isInfinite;
        protected ListEnum.CellPositionType _fixPositionType;
        public Action<int> onSnap;
        public Action<int> onNearestIndexChange;
        public Action onSnapFinished;
        [SerializeField]
        private float _momentumFactor;
        private int _preNearestIndex;
        public int SnappedIndex
        {
            [CompilerGenerated]
            get
            {
                return _003CSnappedIndex_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CSnappedIndex_003Ek__BackingField = value;
            }
        }

        public bool IsSnapping
        {
            [CompilerGenerated]
            get
            {
                return _003CIsSnapping_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CIsSnapping_003Ek__BackingField = value;
            }
        }

        public DragGesture DragGesture
        {
            get
            {
                return null;
            }
        }

        public float MomentumFactor
        {
            get
            {
                return default(float);
            }

            set
            {
            }
        }

        public void Initialize(IListPresenter listPresenter, ListEnum.CellPositionType fixPositionType, bool isInfinite)
        {
        }

        protected virtual DragGesture GetDragGesture()
        {
            return null;
        }

        protected virtual void OnDragFinished()
        {
        }

        public void CheckNearestIndexChange()
        {
        }

        public void SetNearestIndex()
        {
        }

        protected virtual int GetIndexFromMomentum(float momentum, int currentIndex)
        {
            return default(int);
        }

        protected float GetDirectionValue(Vector2 v)
        {
            return default(float);
        }

        public void SnapTo(int index, bool isLazy = false)
        {
        }

        private void SnapToNearestCell(bool isLazy = true)
        {
        }

        private void MoveByMomentum(float momentum)
        {
        }

        private void ScrollWithAnimation(Vector3 offset, Action callback)
        {
        }

        protected virtual void ScrollWithAnimation(RectTransform content, Vector2 targetAnchoredPosition, float duration, Action callback)
        {
        }

        private void KillScrollAnimation()
        {
        }

        protected virtual void KillScrollAnimation(RectTransform content)
        {
        }

        public void SnapToWithoutAnimation(int index)
        {
        }

        public SnapToCell()
        {
        }

        [CompilerGenerated]
        private void _003CSnapTo_003Eb__32_0()
        {
        }
    }
}

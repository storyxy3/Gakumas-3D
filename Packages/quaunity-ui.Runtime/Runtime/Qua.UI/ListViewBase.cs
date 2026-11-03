namespace Qua.UI
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::Qua.UI;
    using global::UnityEngine;
    using global::UnityEngine.Serialization;

    public class ListViewBase : QuaUIBehaviour, IListView
    {
        [SerializeField]
        protected QuaScrollRect _scrollView;
        [SerializeField]
        protected GameObject _scrollBarRoot;
        [SerializeField]
        private RectTransform _contentRoot;
        [SerializeField]
        protected ListEnum.DirectionType _directionType;
        [SerializeField]
        protected float _cellSize;
        [SerializeField]
        protected float _space;
        [SerializeField]
        protected float _paddingStart;
        [SerializeField]
        protected float _paddingEnd;
        [SerializeField]
        [FormerlySerializedAs("_outMargin")]
        protected float _marginStart;
        [SerializeField]
        [FormerlySerializedAs("_outMargin")]
        protected float _marginEnd;
        protected List<Vector2> _cellPoints;
        protected float _contentSize;
        private float _contentPositionOffset;
        private float _pivotOffset;
        [CompilerGenerated]
        private int _003CReusableCellCount_003Ek__BackingField;
        public Action onScrollPointSet;
        public Func<int, float> getCellSize;
        public Func<int> getItemCount;
        public QuaScrollRect ScrollView
        {
            get
            {
                return null;
            }
        }

        public RectTransform ListContentArea
        {
            get
            {
                return null;
            }
        }

        protected bool HasIndividualContent
        {
            get
            {
                return default(bool);
            }
        }

        public ListEnum.DirectionType DirectionType
        {
            get
            {
                return default(ListEnum.DirectionType);
            }
        }

        public float CellSize
        {
            get
            {
                return default(float);
            }
        }

        public int ReusableCellCount
        {
            [CompilerGenerated]
            get
            {
                return default(int);
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public virtual void BaseInitialize(int maxCellCount)
        {
        }

        protected virtual void InitializeAnchor()
        {
        }

        protected virtual int GetReusableCellCount()
        {
            return default(int);
        }

        protected virtual void CacheContentSizeAndCellPoints(int listLength)
        {
        }

        internal void UpdateContentAreaSize(int listLength)
        {
        }

        public void ResetPosition()
        {
        }

        public int GetEnsureStartIndex()
        {
            return default(int);
        }

        public int GetEnsureEndIndex()
        {
            return default(int);
        }

        protected virtual int GetLowIndexOfBinarySearch()
        {
            return default(int);
        }

        protected virtual int GetHighIndexOfBinarySearch()
        {
            return default(int);
        }

        protected virtual Vector2 GetCellPoint(int index)
        {
            return default(Vector2);
        }

        protected float GetRelativePoint(int index)
        {
            return default(float);
        }

        public float GetScrollValue()
        {
            return default(float);
        }

        public void SetScrollValue(float scrollValue)
        {
        }

        public bool TryGetScrollRatio(out float ratio)
        {
            throw null;
        }

        public void SetScrollRatio(float ratio)
        {
        }

        public bool IsInScrollPanel(int index)
        {
            return default(bool);
        }

        public void SetScrollBarActive(bool isActive)
        {
        }

        public void SetReusableCellPosition(Transform cell, int index)
        {
        }

        protected void StopMovement()
        {
        }

        public virtual void ClampScrollPosition()
        {
        }

        private void MoveRelative(Vector3 offset)
        {
        }

        public void MoveScroll(Vector3 offset)
        {
        }

        public virtual Vector3 GetFixPositionFromCenter(ListEnum.CellPositionType positionType, int index)
        {
            return default(Vector3);
        }

        public Vector3 GetPositionFromFixPosition(ListEnum.CellPositionType positionType, int index)
        {
            return default(Vector3);
        }

        public void MoveScrollToFixPosition(ListEnum.CellPositionType positionType, int index)
        {
        }

        public void MoveScroll(int centerIndex)
        {
        }

        public void MoveScrollByHeadIndex(int headIndex)
        {
        }

        public Vector3 GetPositionFromCenter(int index)
        {
            return default(Vector3);
        }

        protected Vector3 GetPositionFromCenter(Vector3 cellPosition)
        {
            return default(Vector3);
        }

        public virtual Vector3 GetCellCenter(int index)
        {
            return default(Vector3);
        }

        protected float GetViewportSize()
        {
            return default(float);
        }

        public ListViewBase()
        {
        }
    }
}

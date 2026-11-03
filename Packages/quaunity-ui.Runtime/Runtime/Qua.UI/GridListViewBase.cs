namespace Qua.UI
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::Qua.UI;
    using global::UnityEngine;

    public class GridListViewBase : ListViewBase
    {
        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003C_003Ec__DisplayClass19_0
        {
            public int directionPosition;
            public GridListViewBase _003C_003E4__this;
            public GridListCellArrangementContext context;
        }

        private static readonly GridListCellArrangementContext ContextCache;
        [SerializeField]
        protected float _otherSize;
        [SerializeField]
        protected float _otherSpace;
        public Func<int, float> getOtherSize;
        [CompilerGenerated]
        private int _003COtherCellCount_003Ek__BackingField;
        protected List<int> _cellDirectionPosition;
        public float OtherSize
        {
            get
            {
                return default(float);
            }
        }

        public float OtherSpace
        {
            get
            {
                return default(float);
            }
        }

        public int OtherCellCount
        {
            [CompilerGenerated]
            get
            {
                return default(int);
            }

            [CompilerGenerated]
            protected set
            {
            }
        }

        public IReadOnlyList<int> CellDirectionPosition
        {
            get
            {
                return null;
            }
        }

        public override void BaseInitialize(int maxCellCount)
        {
        }

        protected override int GetReusableCellCount()
        {
            return default(int);
        }

        protected virtual float GetOtherStartPadding(GridListCellArrangementContext context)
        {
            return default(float);
        }

        protected virtual bool ShouldChangeLine(GridListCellArrangementContext context)
        {
            return default(bool);
        }

        protected override void CacheContentSizeAndCellPoints(int listLength)
        {
        }

        public override Vector3 GetCellCenter(int index)
        {
            return default(Vector3);
        }

        protected float GetOtherAreaSize()
        {
            return default(float);
        }

        public virtual int GetOtherCellCount()
        {
            return default(int);
        }

        public GridListViewBase()
        {
        }

        [CompilerGenerated]
        private void _003CCacheContentSizeAndCellPoints_003Eg__SetOtherDirectionCells_007C19_0(ref _003C_003Ec__DisplayClass19_0 P_0)
        {
        }
    }
}

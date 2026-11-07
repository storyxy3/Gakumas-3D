namespace Qua.UI
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;

    public class GridListCellArrangementContext
    {
        [CompilerGenerated]
        private int _003CCurrentIndex_003Ek__BackingField;
        [CompilerGenerated]
        private int _003CCurrentLineStartIndex_003Ek__BackingField;
        [CompilerGenerated]
        private float _003CCurrentOtherSizeSum_003Ek__BackingField;
        [CompilerGenerated]
        private float _003COtherAreaSize_003Ek__BackingField;
        private readonly List<float> _otherSizeList;
        public int CurrentIndex
        {
            [CompilerGenerated]
            get
            {
                return _003CCurrentIndex_003Ek__BackingField;
            }

            [CompilerGenerated]
            internal set
            {
                _003CCurrentIndex_003Ek__BackingField = value;
            }
        }

        public int CurrentLineStartIndex
        {
            [CompilerGenerated]
            get
            {
                return _003CCurrentLineStartIndex_003Ek__BackingField;
            }

            [CompilerGenerated]
            internal set
            {
                _003CCurrentLineStartIndex_003Ek__BackingField = value;
            }
        }

        public float CurrentOtherSizeSum
        {
            [CompilerGenerated]
            get
            {
                return _003CCurrentOtherSizeSum_003Ek__BackingField;
            }

            [CompilerGenerated]
            internal set
            {
                _003CCurrentOtherSizeSum_003Ek__BackingField = value;
            }
        }

        public float OtherAreaSize
        {
            [CompilerGenerated]
            get
            {
                return _003COtherAreaSize_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003COtherAreaSize_003Ek__BackingField = value;
            }
        }

        internal void OnStartArrangement(float otherAreaSize)
        {
        }

        internal void SetOtherSizeList(int length, Func<int, float> getOtherSize)
        {
        }

        public float GetOtherSize(int index)
        {
            return default(float);
        }

        public GridListCellArrangementContext()
        {
        }
    }
}

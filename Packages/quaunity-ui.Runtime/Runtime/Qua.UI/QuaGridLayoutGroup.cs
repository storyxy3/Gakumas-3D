namespace Qua.UI
{
    using global::Qua.UI;
    using global::UnityEngine;
    using global::UnityEngine.UI;

    public class QuaGridLayoutGroup : LayoutGroup
    {
        public enum Corner
        {
            UpperLeft,
            UpperRight,
            UpperCenter,
            LowerLeft,
            LowerRight,
            LowerCenter
        }

        public enum Axis
        {
            Horizontal,
            Vertical
        }

        public enum Constraint
        {
            Flexible,
            FixedColumnCount,
            FixedRowCount
        }

        [SerializeField]
        protected Corner m_StartCorner;
        [SerializeField]
        protected Axis m_StartAxis;
        [SerializeField]
        protected Vector2 m_CellSize;
        [SerializeField]
        protected Vector2 m_Spacing;
        [SerializeField]
        protected Constraint m_Constraint;
        [SerializeField]
        protected int m_ConstraintCount;
        public Corner startCorner
        {
            get
            {
                return default(Corner);
            }

            set
            {
            }
        }

        public Axis startAxis
        {
            get
            {
                return default(Axis);
            }

            set
            {
            }
        }

        public Vector2 cellSize
        {
            get
            {
                return default(Vector2);
            }

            set
            {
            }
        }

        public Vector2 spacing
        {
            get
            {
                return default(Vector2);
            }

            set
            {
            }
        }

        public Constraint constraint
        {
            get
            {
                return default(Constraint);
            }

            set
            {
            }
        }

        public int constraintCount
        {
            get
            {
                return default(int);
            }

            set
            {
            }
        }

        protected QuaGridLayoutGroup()
        {
        }

        public override void CalculateLayoutInputHorizontal()
        {
        }

        public override void CalculateLayoutInputVertical()
        {
        }

        public override void SetLayoutHorizontal()
        {
        }

        public override void SetLayoutVertical()
        {
        }

        private void SetCellsAlongAxis(int axis)
        {
        }
    }
}

namespace Titan
{
    using global::System.Collections.Generic;
    using global::Titan;

    public class VariableInputHandler
    {
        private enum VariableInputType
        {
            Number = 0,
            Integer = 1,
            Transform = 2,
            Color = 3,
            Vector2 = 4,
            Bool = 5,
            String = 6,
            Expression = 100,
            TrackGroup = 110,
            Null = 999
        }

        private static VariableInputType[] PopupOrderVariableInputTypes;
        private string[] _popupNames;
        private int[] _popupTypes;
        private Dictionary<int, int> _typeToPopupIndex;
        private static VariableInputHandler _default;
        public static VariableInputHandler Default
        {
            get
            {
                return null;
            }
        }

        public virtual VariableType GetVariableType(int type)
        {
            return default(VariableType);
        }

        public VariableInputHandler()
        {
        }
    }
}

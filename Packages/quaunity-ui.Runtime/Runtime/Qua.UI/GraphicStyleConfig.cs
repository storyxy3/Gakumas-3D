namespace Qua.UI
{
    using global::System;
    using global::Qua.UI;
    using global::Qua.UI.Internal;
    using global::UnityEngine;

    public class GraphicStyleConfig : UIStyleConfigBase<GraphicStyleConfig, GraphicStyleConfig.Style>
    {
        [Serializable]
        public class Style : IUIStyle
        {
            [SerializeField]
            private string _name;
            [SerializeField]
            private string _popUpLabel;
            [SerializeField]
            private Color _color;
            [SerializeField]
            private Material _material;
            public string Name
            {
                get
                {
                    return null;
                }
            }

            public string PopUpLabel
            {
                get
                {
                    return null;
                }
            }

            public Color Color
            {
                get
                {
                    return default(Color);
                }
            }

            public Material Material
            {
                get
                {
                    return null;
                }
            }

            public Style()
            {
            }
        }

        public GraphicStyleConfig()
        {
        }
    }
}

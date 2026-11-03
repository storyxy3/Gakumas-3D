namespace Qua.UI
{
    using global::UnityEngine;
    using global::UnityEngine.UI;

    [RequireComponent(typeof(Text))]
    public class CondensedText : BaseMeshEffect
    {
        protected Text _text;
        protected float _scale;
        public Text Text
        {
            get
            {
                return null;
            }
        }

        public float Scale
        {
            get
            {
                return default(float);
            }
        }

        public override void ModifyMesh(VertexHelper vh)
        {
        }

        public CondensedText()
        {
        }
    }
}

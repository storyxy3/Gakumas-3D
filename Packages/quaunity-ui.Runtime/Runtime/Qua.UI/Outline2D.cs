namespace Qua.UI
{
    using global::System.Collections.Generic;
    using global::Qua.UI;
    using global::UnityEngine;
    using global::UnityEngine.UI;

    public class Outline2D : Shadow
    {
        public enum EffectType
        {
            None,
            Shadow,
            Outline,
            Outline8
        }

        [SerializeField]
        private EffectType _type;
        private List<UIVertex> _listCache;
        public EffectType Type
        {
            get
            {
                return default(EffectType);
            }

            set
            {
            }
        }

        public override void ModifyMesh(VertexHelper vh)
        {
        }

        private void ApplyOutline(List<UIVertex> list, params Vector2[] offsets)
        {
        }

        private void SetVerticesDirty()
        {
        }

        protected override void OnDisable()
        {
        }

        public Outline2D()
        {
        }
    }
}

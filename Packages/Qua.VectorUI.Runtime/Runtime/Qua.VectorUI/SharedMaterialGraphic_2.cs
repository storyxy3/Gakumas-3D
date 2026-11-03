namespace Qua.VectorUI
{
    using global::Qua.VectorUI;
    using global::UnityEngine;
    using global::UnityEngine.UI;

    [ExecuteAlways]
    [RequireComponent(typeof(CanvasRenderer))]
    public abstract class SharedMaterialGraphic<T, TKey> : MaskableGraphic where T : SharedMaterialGraphic<T, TKey>
    {
        private static MaterialCache<TKey> _materialCache;
        private Material _material;
        private TKey _currentKey;
        protected abstract string ShaderName { get; }

        public override Material material
        {
            get
            {
                return null;
            }
        }

        protected override void OnDisable()
        {
        }

        protected abstract TKey GetMaterialKey();
        protected virtual Material CreateMaterial()
        {
            return null;
        }

        protected void UpdateMaterialAndKey()
        {
        }

        protected void SetProperty<TValue>(ref TValue currentValue, TValue newValue, bool materialDirty = false)
            where TValue : struct
        {
        }

        protected SharedMaterialGraphic()
        {
        }
    }
}

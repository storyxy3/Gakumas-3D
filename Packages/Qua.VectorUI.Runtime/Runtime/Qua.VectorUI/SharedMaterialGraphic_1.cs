namespace Qua.VectorUI
{
    using global::Qua.VectorUI;

    public abstract class SharedMaterialGraphic<T> : SharedMaterialGraphic<T, bool> where T : SharedMaterialGraphic<T>
    {
        protected override bool GetMaterialKey()
        {
            return default(bool);
        }

        protected SharedMaterialGraphic()
        {
        }
    }
}

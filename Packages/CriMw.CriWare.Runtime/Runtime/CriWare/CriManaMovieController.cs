namespace CriWare
{
    using global::CriWare;
    using global::UnityEngine;

    [AddComponentMenu("CRIWARE/CriManaMovieController")]
    public class CriManaMovieController : CriManaMovieMaterial
    {
        public Renderer target;
        public bool useOriginalMaterial;
        private Material originalMaterial;
        public override void CriInternalUpdate()
        {
        }

        public override bool RenderTargetManualSetup()
        {
            return default(bool);
        }

        public override void RenderTargetManualFinalize()
        {
        }

        protected override void OnMaterialAvailableChanged()
        {
        }

        public CriManaMovieController()
        {
        }
    }
}

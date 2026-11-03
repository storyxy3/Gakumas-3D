namespace CriWare
{
    using global::CriWare;
    using global::UnityEngine;
    using global::UnityEngine.UI;

    [AddComponentMenu("CRIWARE/CriManaMovieControllerForUI")]
    public class CriManaMovieControllerForUI : CriManaMovieMaterial
    {
        public Graphic target;
        public bool useOriginalMaterial;
        private Material originalMaterial;
        protected override void Awake()
        {
        }

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

        public CriManaMovieControllerForUI()
        {
        }
    }
}

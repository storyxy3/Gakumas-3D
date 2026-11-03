namespace CriWare.CriMana.Detail
{
    using global::CriWare.CriMana;
    using global::CriWare.CriMana.Detail;
    using global::UnityEngine;
    using global::UnityEngine.Scripting;

    public static class AutoResisterRendererResourceFactories
    {
        [Preserve]
        [RendererResourceFactoryPriority(7000)]
        public class RendererResourceFactoryAndroidH264Rgb : RendererResourceFactory
        {
            public override RendererResource CreateRendererResource(int playerId, MovieInfo movieInfo, bool additive, Shader userShader)
            {
                return null;
            }

            protected override void OnDisposeManaged()
            {
            }

            protected override void OnDisposeUnmanaged()
            {
            }

            public RendererResourceFactoryAndroidH264Rgb()
            {
            }
        }

        [Preserve]
        [RendererResourceFactoryPriority(5050)]
        public class RendererResourceFactoryAndroidSofdecPrimeYuv : RendererResourceFactory
        {
            public override RendererResource CreateRendererResource(int playerId, MovieInfo movieInfo, bool additive, Shader userShader)
            {
                return null;
            }

            protected override void OnDisposeManaged()
            {
            }

            protected override void OnDisposeUnmanaged()
            {
            }

            public RendererResourceFactoryAndroidSofdecPrimeYuv()
            {
            }
        }

        [Preserve]
        [RendererResourceFactoryPriority(5060)]
        public class RendererResourceFactoryAndroidSofdecPrimeYuvLegacyGles2 : RendererResourceFactory
        {
            public override RendererResource CreateRendererResource(int playerId, MovieInfo movieInfo, bool additive, Shader userShader)
            {
                return null;
            }

            protected override void OnDisposeManaged()
            {
            }

            protected override void OnDisposeUnmanaged()
            {
            }

            public RendererResourceFactoryAndroidSofdecPrimeYuvLegacyGles2()
            {
            }
        }

        [Preserve]
        [RendererResourceFactoryPriority(10000)]
        public class RendererResourceFactorySofdecPrimeYuvRawData : RendererResourceFactory
        {
            public override RendererResource CreateRendererResource(int playerId, MovieInfo movieInfo, bool additive, Shader userShader)
            {
                return null;
            }

            protected override void OnDisposeManaged()
            {
            }

            protected override void OnDisposeUnmanaged()
            {
            }

            public RendererResourceFactorySofdecPrimeYuvRawData()
            {
            }
        }

        public static void InvokeAutoRegister()
        {
        }
    }
}

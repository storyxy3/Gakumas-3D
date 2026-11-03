namespace CriWare.CriMana.Detail
{
    using global::System;
    using global::System.Collections.Generic;
    using global::CriWare.CriMana;
    using global::CriWare.CriMana.Detail;
    using global::UnityEngine;

    public abstract class RendererResourceFactory : IDisposable
    {
        private static SortedList<int, RendererResourceFactory> factoryList;
        private bool disposed;
        public static void RegisterFactory(RendererResourceFactory factory, int priority)
        {
        }

        public static void DisposeAllFactories()
        {
        }

        public static RendererResource DispatchAndCreate(int playerId, MovieInfo movieInfo, bool additive, Shader userShader)
        {
            return null;
        }

        ~RendererResourceFactory()
        {
        }

        public void Dispose()
        {
        }

        private void Dispose(bool disposing)
        {
        }

        protected abstract void OnDisposeManaged();
        protected abstract void OnDisposeUnmanaged();
        public abstract RendererResource CreateRendererResource(int playerId, MovieInfo movieInfo, bool additive, Shader userShader);
        protected RendererResourceFactory()
        {
        }
    }
}

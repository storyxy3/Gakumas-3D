namespace Campus.DecalLight
{
    using global::System;
    using global::System.Collections.Generic;
    using global::Campus.DecalLight;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;

    public class CampusDecalLightDrawSystem : IDisposable
    {
        public static readonly int PositionAndAtten;
        public static readonly int Params;
        public static readonly int Params2;
        public static readonly int Color;
        public static readonly int UVScaleOffset;
        public static readonly int _DecalLightTexture;
        public const int MaxLightCount = 128;
        private readonly CampusDecalLightEntityManager _entityManager;
        private readonly ProfilingSampler _drawSampler;
        private readonly Material _sourceMaterial;
        private readonly int _stencilPass;
        private readonly int _maskPass;
        private readonly int _clearStencilPass;
        private readonly int _resolvePass;
        private Matrix4x4[] _localToWorlds;
        private Vector4[] _positionAndAttens;
        private Matrix4x4[] _params;
        private Vector4[] _colors;
        private Vector4[] _uvScaleOffsets;
        private Dictionary<int, Material> _materials;
        internal bool isSystemExecuted;
        public bool IsActive
        {
            get
            {
                return default(bool);
            }
        }

        public CampusDecalLightDrawSystem(CampusDecalLightEntityManager entityManager, Material sourceMaterial)
        {
        }

        public void Dispose()
        {
        }

        public void CompleteJob()
        {
        }

        public void Execute(CommandBuffer cmd)
        {
        }
    }
}

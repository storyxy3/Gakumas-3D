namespace Campus.Rendering.Shaders
{
    using global::System;
    using global::Unity.Mathematics;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;

    [GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, "/github/workspace/campus-client/campus-submodule/campus-submodule/Shader/Actor/ShaderLibrary/ActorCBuffer.cs", needAccessors = false, generateCBuffer = true, constantRegister = 6)]
    public struct ShaderVariablesActorLighting
    {
        public const int k_ACTOR_LENGTH = 16;
        public const int k_ACTOR_LIGHT_COUNT = 8;
        [HLSLArray(1, typeof(ShaderGenUInt4))]
        public unsafe fixed uint _LightData[4];
        [HLSLArray(8, typeof(Vector4))]
        public unsafe fixed float _LightPositions[32];
        [HLSLArray(8, typeof(Vector4))]
        public unsafe fixed float _LightColors[32];
        [HLSLArray(8, typeof(Vector4))]
        public unsafe fixed float _LightAttenuations[32];
        [HLSLArray(8, typeof(Vector4))]
        public unsafe fixed float _LightDirections[32];
        public unsafe Span<float4> LightPositions
        {
            get
            {
                fixed (float* p = _LightPositions) return new Span<float4>(p, 8);
            }
        }

        public unsafe Span<float4> LightColors
        {
            get
            {
                fixed (float* p = _LightColors) return new Span<float4>(p, 8);
            }
        }

        public unsafe Span<float4> LightAttenuations
        {
            get
            {
                fixed (float* p = _LightAttenuations) return new Span<float4>(p, 8);
            }
        }

        public unsafe Span<float4> LightDirections
        {
            get
            {
                fixed (float* p = _LightDirections) return new Span<float4>(p, 8);
            }
        }

        public unsafe Span<uint4> LightData
        {
            get
            {
                fixed (uint* p = _LightData) return new Span<uint4>(p, 1);
            }
        }
    }
}

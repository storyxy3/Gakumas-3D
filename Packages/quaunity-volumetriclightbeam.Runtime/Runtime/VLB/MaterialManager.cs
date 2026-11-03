namespace VLB
{
    using global::System.Collections.Generic;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;
    using global::VLB;

    public static class MaterialManager
    {
        public enum BlendingMode
        {
            Additive,
            SoftAdditive,
            TraditionalTransparency,
            Count
        }

        public enum ColorGradient
        {
            Off,
            MatrixLow,
            MatrixHigh,
            Count
        }

        public enum Noise3D
        {
            Off,
            On,
            Count
        }

        public static class SD
        {
            public enum DepthBlend
            {
                Off,
                On,
                Count
            }

            public enum DynamicOcclusion
            {
                Off,
                ClippingPlane,
                DepthTexture,
                Count
            }

            public enum MeshSkewing
            {
                Off,
                On,
                Count
            }

            public enum ShaderAccuracy
            {
                Fast,
                High,
                Count
            }
        }

        public static class HD
        {
            public enum Attenuation
            {
                Linear,
                Quadratic,
                Count
            }

            public enum Shadow
            {
                Off,
                On,
                Count
            }

            public enum Cookie
            {
                Off,
                SingleChannel,
                RGBA,
                Count
            }
        }

        private interface IStaticProperties
        {
            int GetPropertiesCount();
            int GetMaterialID();
            void ApplyToMaterial(Material mat);
            ShaderMode GetShaderMode();
        }

        public struct StaticPropertiesSD : IStaticProperties
        {
            public BlendingMode blendingMode;
            public Noise3D noise3D;
            public SD.DepthBlend depthBlend;
            public ColorGradient colorGradient;
            public SD.DynamicOcclusion dynamicOcclusion;
            public SD.MeshSkewing meshSkewing;
            public SD.ShaderAccuracy shaderAccuracy;
            public bool depthShadow;
            private int noise3DID
            {
                get
                {
                    return default(int);
                }
            }

            private int depthBlendID
            {
                get
                {
                    return default(int);
                }
            }

            private int colorGradientID
            {
                get
                {
                    return default(int);
                }
            }

            private int dynamicOcclusionID
            {
                get
                {
                    return default(int);
                }
            }

            private int meshSkewingID
            {
                get
                {
                    return default(int);
                }
            }

            private int shaderAccuracyID
            {
                get
                {
                    return default(int);
                }
            }

            private int depthShadowID
            {
                get
                {
                    return default(int);
                }
            }

            public ShaderMode GetShaderMode()
            {
                return default(ShaderMode);
            }

            public int GetPropertiesCount()
            {
                return default(int);
            }

            public int GetMaterialID()
            {
                return default(int);
            }

            public void ApplyToMaterial(Material mat)
            {
            }
        }

        public struct StaticPropertiesHD : IStaticProperties
        {
            public BlendingMode blendingMode;
            public HD.Attenuation attenuation;
            public Noise3D noise3D;
            public ColorGradient colorGradient;
            public HD.Shadow shadow;
            public HD.Cookie cookie;
            public int raymarchingQualityIndex;
            public static int staticPropertiesCount
            {
                get
                {
                    return default(int);
                }
            }

            private int blendingModeID
            {
                get
                {
                    return default(int);
                }
            }

            private int attenuationID
            {
                get
                {
                    return default(int);
                }
            }

            private int noise3DID
            {
                get
                {
                    return default(int);
                }
            }

            private int colorGradientID
            {
                get
                {
                    return default(int);
                }
            }

            private int dynamicOcclusionID
            {
                get
                {
                    return default(int);
                }
            }

            private int cookieID
            {
                get
                {
                    return default(int);
                }
            }

            private int raymarchingQualityID
            {
                get
                {
                    return default(int);
                }
            }

            public ShaderMode GetShaderMode()
            {
                return default(ShaderMode);
            }

            public int GetPropertiesCount()
            {
                return default(int);
            }

            public int GetMaterialID()
            {
                return default(int);
            }

            public void ApplyToMaterial(Material mat)
            {
            }
        }

        private class MaterialsGroup
        {
            public Material[] materials;
            public MaterialsGroup(int count)
            {
            }
        }

        public static MaterialPropertyBlock materialPropertyBlock;
        private static readonly BlendMode[] BlendingMode_SrcFactor;
        private static readonly BlendMode[] BlendingMode_DstFactor;
        private static readonly bool[] BlendingMode_AlphaAsBlack;
        private static Dictionary<uint, MaterialsGroup> ms_MaterialsGroupSD;
        private static Dictionary<uint, MaterialsGroup> ms_MaterialsGroupHD;
        public static Material NewMaterialPersistent(Shader shader, bool gpuInstanced)
        {
            return null;
        }

        public static Material GetInstancedMaterial(uint groupID, ref StaticPropertiesSD staticProps)
        {
            return null;
        }

        public static Material GetInstancedMaterial(uint groupID, ref StaticPropertiesHD staticProps)
        {
            return null;
        }

        private static Material GetInstancedMaterial(Dictionary<uint, MaterialsGroup> groups, uint groupID, ref IStaticProperties staticProps)
        {
            return null;
        }

        private static void SetBlendingMode(this Material mat, int nameID, BlendMode value)
        {
        }

        private static void SetZTest(this Material mat, int nameID, CompareFunction value)
        {
        }
    }
}

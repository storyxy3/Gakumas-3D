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
                    return Config.Instance.featureEnabledNoise3D ? (int)noise3D : 0;
                }
            }

            private int depthBlendID
            {
                get
                {
                    return Config.Instance.featureEnabledDepthBlend ? (int)depthBlend : 0;
                }
            }

            private int colorGradientID
            {
                get
                {
                    return Config.Instance.featureEnabledColorGradient != FeatureEnabledColorGradient.Off ? (int)colorGradient : 0;
                }
            }

            private int dynamicOcclusionID
            {
                get
                {
                    return Config.Instance.featureEnabledDynamicOcclusion ? (int)dynamicOcclusion : 0;
                }
            }

            private int meshSkewingID
            {
                get
                {
                    return Config.Instance.featureEnabledMeshSkewing ? (int)meshSkewing : 0;
                }
            }

            private int shaderAccuracyID
            {
                get
                {
                    return Config.Instance.featureEnabledShaderAccuracyHigh ? (int)shaderAccuracy : 0;
                }
            }

            private int depthShadowID
            {
                get
                {
                    return depthShadow ? 1 : 0;
                }
            }

            public ShaderMode GetShaderMode()
            {
                return ShaderMode.SD;
            }

            public int GetPropertiesCount()
            {
                return 2047;
            }

            public int GetMaterialID()
            {
                return (int)blendingMode
                    | (noise3DID << 2)
                    | (depthBlendID << 3)
                    | (colorGradientID << 4)
                    | (dynamicOcclusionID << 6)
                    | (meshSkewingID << 8)
                    | (shaderAccuracyID << 9)
                    | (depthShadowID << 10);
            }

            public void ApplyToMaterial(Material mat)
            {
                mat.SetKeywordEnabled("VLB_ALPHA_AS_BLACK", BlendingMode_AlphaAsBlack[(int)blendingMode]);
                mat.SetKeywordEnabled("VLB_COLOR_GRADIENT_MATRIX_LOW", colorGradient == ColorGradient.MatrixLow);
                mat.SetKeywordEnabled("VLB_COLOR_GRADIENT_MATRIX_HIGH", colorGradient == ColorGradient.MatrixHigh);
                mat.SetKeywordEnabled("VLB_DEPTH_BLEND", depthBlend == SD.DepthBlend.On);
                mat.SetKeywordEnabled("VLB_NOISE_3D", noise3D == Noise3D.On);
                mat.SetKeywordEnabled("VLB_OCCLUSION_CLIPPING_PLANE", dynamicOcclusion == SD.DynamicOcclusion.ClippingPlane);
                mat.SetKeywordEnabled("VLB_OCCLUSION_DEPTH_TEXTURE", dynamicOcclusion == SD.DynamicOcclusion.DepthTexture);
                mat.SetKeywordEnabled("VLB_MESH_SKEWING", meshSkewing == SD.MeshSkewing.On);
                mat.SetKeywordEnabled("VLB_SHADER_ACCURACY_HIGH", shaderAccuracy == SD.ShaderAccuracy.High);
                mat.SetKeywordEnabled("VLB_SHADOW", depthShadow);
                mat.SetBlendingMode(ShaderProperties.BlendSrcFactor, BlendingMode_SrcFactor[(int)blendingMode]);
                mat.SetBlendingMode(ShaderProperties.BlendDstFactor, BlendingMode_DstFactor[(int)blendingMode]);
                mat.SetZTest(ShaderProperties.ZTest, depthShadow ? CompareFunction.Always : CompareFunction.LessEqual);
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
                    return 216 * Config.Instance.raymarchingQualitiesCount;
                }
            }

            private int blendingModeID
            {
                get
                {
                    return (int)blendingMode;
                }
            }

            private int attenuationID
            {
                get
                {
                    return (int)attenuation;
                }
            }

            private int noise3DID
            {
                get
                {
                    return Config.Instance.featureEnabledNoise3D ? (int)noise3D : 0;
                }
            }

            private int colorGradientID
            {
                get
                {
                    return Config.Instance.featureEnabledColorGradient != FeatureEnabledColorGradient.Off ? (int)colorGradient : 0;
                }
            }

            private int dynamicOcclusionID
            {
                get
                {
                    return Config.Instance.featureEnabledShadow ? (int)shadow : 0;
                }
            }

            private int cookieID
            {
                get
                {
                    return Config.Instance.featureEnabledCookie ? (int)cookie : 0;
                }
            }

            private int raymarchingQualityID
            {
                get
                {
                    return (int)raymarchingQualityIndex;
                }
            }

            public ShaderMode GetShaderMode()
            {
                return ShaderMode.HD;
            }

            public int GetPropertiesCount()
            {
                return staticPropertiesCount;
            }

            public int GetMaterialID()
            {
                int id = blendingModeID;
                id = id * 2 + attenuationID;
                id = id * 2 + noise3DID;
                id = id * 3 + colorGradientID;
                id = id * 2 + dynamicOcclusionID;
                id = id * 3 + cookieID;
                return id * Config.Instance.raymarchingQualitiesCount + raymarchingQualityID;
            }

            public void ApplyToMaterial(Material mat)
            {
                mat.SetKeywordEnabled("VLB_ALPHA_AS_BLACK", BlendingMode_AlphaAsBlack[(int)blendingMode]);
                mat.SetKeywordEnabled("VLB_ATTENUATION_LINEAR", attenuation == HD.Attenuation.Linear);
                mat.SetKeywordEnabled("VLB_ATTENUATION_QUAD", attenuation == HD.Attenuation.Quadratic);
                mat.SetKeywordEnabled("VLB_COLOR_GRADIENT_MATRIX_LOW", colorGradient == ColorGradient.MatrixLow);
                mat.SetKeywordEnabled("VLB_COLOR_GRADIENT_MATRIX_HIGH", colorGradient == ColorGradient.MatrixHigh);
                mat.SetKeywordEnabled("VLB_NOISE_3D", noise3D == Noise3D.On);
                mat.SetKeywordEnabled("VLB_SHADOW", shadow == HD.Shadow.On);
                mat.SetKeywordEnabled("VLB_COOKIE_1CHANNEL", cookie == HD.Cookie.SingleChannel);
                mat.SetKeywordEnabled("VLB_COOKIE_RGBA", cookie == HD.Cookie.RGBA);
                for (int i = 0; i < Config.Instance.raymarchingQualitiesCount; ++i)
                    mat.SetKeywordEnabled(ShaderKeywords.HD.GetRaymarchingQuality(i), raymarchingQualityIndex == i);
                mat.SetBlendingMode(ShaderProperties.BlendSrcFactor, BlendingMode_SrcFactor[(int)blendingMode]);
                mat.SetBlendingMode(ShaderProperties.BlendDstFactor, BlendingMode_DstFactor[(int)blendingMode]);
                mat.SetZTest(ShaderProperties.ZTest, CompareFunction.Always);
            }
        }

        private class MaterialsGroup
        {
            public Material[] materials;
            public MaterialsGroup(int count)
            {
                materials = new Material[count];
            }
        }

        public static MaterialPropertyBlock materialPropertyBlock = new MaterialPropertyBlock();
        private static readonly BlendMode[] BlendingMode_SrcFactor = { BlendMode.One, BlendMode.OneMinusDstColor, BlendMode.SrcAlpha };
        private static readonly BlendMode[] BlendingMode_DstFactor = { BlendMode.One, BlendMode.One, BlendMode.OneMinusSrcAlpha };
        private static readonly bool[] BlendingMode_AlphaAsBlack = { true, true, false };
        private static Dictionary<uint, MaterialsGroup> ms_MaterialsGroupSD = new Dictionary<uint, MaterialsGroup>(1);
        private static Dictionary<uint, MaterialsGroup> ms_MaterialsGroupHD = new Dictionary<uint, MaterialsGroup>(1);
        public static Material NewMaterialPersistent(Shader shader, bool gpuInstanced)
        {
            if (!shader)
            {
                Debug.LogError("Invalid VLB Shader. Please try to reset the VLB Config asset or reinstall the plugin.");
                return null;
            }
            Material material = new Material(shader);
            BatchingHelper.SetMaterialProperties(material, gpuInstanced);
            return material;
        }

        public static Material GetInstancedMaterial(uint groupID, ref StaticPropertiesSD staticProps)
        {
            IStaticProperties properties = staticProps;
            return GetInstancedMaterial(ms_MaterialsGroupSD, groupID, ref properties);
        }

        public static Material GetInstancedMaterial(uint groupID, ref StaticPropertiesHD staticProps)
        {
            IStaticProperties properties = staticProps;
            return GetInstancedMaterial(ms_MaterialsGroupHD, groupID, ref properties);
        }

        private static Material GetInstancedMaterial(Dictionary<uint, MaterialsGroup> groups, uint groupID, ref IStaticProperties staticProps)
        {
            if (!groups.TryGetValue(groupID, out MaterialsGroup group))
            {
                group = new MaterialsGroup(staticProps.GetPropertiesCount());
                groups[groupID] = group;
            }
            int id = staticProps.GetMaterialID();
            Material material = group.materials[id];
            if (material == null)
            {
                material = Config.Instance.NewMaterialTransient(staticProps.GetShaderMode(), true);
                if (material)
                {
                    group.materials[id] = material;
                    staticProps.ApplyToMaterial(material);
                }
            }
            return material;
        }

        private static void SetBlendingMode(this Material mat, int nameID, BlendMode value)
        {
            mat.SetInt(nameID, (int)value);
        }

        private static void SetZTest(this Material mat, int nameID, CompareFunction value)
        {
            mat.SetInt(nameID, (int)value);
        }
    }
}

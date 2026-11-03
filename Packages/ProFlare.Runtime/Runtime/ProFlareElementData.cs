using global::Unity.Mathematics;
using global::UnityEngine;
using global::UnityEngine.Rendering;

[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, "./Library/PackageCache/jp.qualiarts.quaunity-proflare@81b58a622376/Runtime/ProFlareBatchForSRPData.cs", needAccessors = false, sourcePath = "Packages/jp.qualiarts.quaunity-proflare/Shader/ProFlareBatchForSRPData")]
public struct ProFlareElementData
{
    public uint flareIndex;
    public uint color;
    public float2 scale;
    public float3 offset;
    public float angle;
    public float4 uv;
    public Color32 color32
    {
        set
        {
        }
    }
}

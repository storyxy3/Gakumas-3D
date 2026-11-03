using global::Unity.Mathematics;
using global::UnityEngine.Rendering;

[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, "./Library/PackageCache/jp.qualiarts.quaunity-proflare@81b58a622376/Runtime/ProFlareBatchForSRPData.cs", needAccessors = false, sourcePath = "Packages/jp.qualiarts.quaunity-proflare/Shader/ProFlareBatchForSRPData")]
public struct ProFlareInputData
{
    public uint visible;
    public float3 lensPosition;
    public float occlusionScaleSpeed;
    public float occlusionBrightnessSpeed;
    public bool Visible
    {
        get
        {
            return default(bool);
        }

        set
        {
        }
    }
}

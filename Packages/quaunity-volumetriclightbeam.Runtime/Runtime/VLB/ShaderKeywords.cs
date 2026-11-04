namespace VLB
{
    public static class ShaderKeywords
    {
        public static class HD
        {
            public static string GetRaymarchingQuality(int id)
            {
                return "VLB_RAYMARCHING_QUALITY_" + id.ToString();
            }
        }
    }
}

using System;

namespace TrueEnd.Host
{
    // DMM PC CampusQualityManager.SetQuality (GameAssembly 2026-11-08): per QualityLevel the QualitySettings level,
    // VLSRPCameraController.maxBufferPixel, camera render scale and override volume index. The PC client defaults to
    // VeryHigh (its log prints QualitySettings level 4, "Ultimate"). Only tiers whose override profile is known are listed.
    internal sealed class QualityTier
    {
        public string name;
        public int qualitySettingsLevel;
        public int maxBufferPixel;
        public float renderScale;
        public int volumeIndex;

        public static QualityTier Get(string name)
        {
            switch (string.IsNullOrEmpty(name) ? "veryhigh" : name)
            {
                case "high": return new QualityTier { name = "high", qualitySettingsLevel = 3, maxBufferPixel = 3384, renderScale = 0.77f, volumeIndex = 3 };
                case "veryhigh": return new QualityTier { name = "veryhigh", qualitySettingsLevel = 4, maxBufferPixel = 3840, renderScale = 1f, volumeIndex = 4 };
                default: throw new ArgumentException("--quality-tier high|veryhigh");
            }
        }
    }
}

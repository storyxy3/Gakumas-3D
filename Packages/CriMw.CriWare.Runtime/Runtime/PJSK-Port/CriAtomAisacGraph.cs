using System;

namespace CriWare
{
    // Original libcri 314dec23..., graph sampler 0x8AF50 / scale dispatch 0x8B260.
    // The caller decodes BE float controls and destinations. Legacy destinations
    // are signed BE int16 divided by GetLegacyDestinationScale before sampling.
    internal static class CriAtomAisacGraph
    {
        internal static float GetLegacyDestinationScale(ushort graphType)
        {
            switch (graphType)
            {
                case 2: case 36: case 37: case 41: case 42: return 1f;
                case 6: case 43: case 44: case 45: case 46: case 47:
                case 48: case 49: case 50: case 51: return 100f;
                case 15: return 10f;
                case 38: return 1000f;
                default: return 10000f;
            }
        }

        internal static float Evaluate(float control, float[] controls, float[] normalizedDestinations, bool hasGraphCurve)
        {
            if (controls == null) throw new ArgumentNullException(nameof(controls));
            if (normalizedDestinations == null) throw new ArgumentNullException(nameof(normalizedDestinations));
            if (controls.Length == 0 || controls.Length != normalizedDestinations.Length)
                throw new ArgumentException("An AISAC graph requires matching nonempty control and destination arrays.");

            if (controls[0] >= control) return normalizedDestinations[0];
            int right = 1;
            while (right < controls.Length && controls[right] < control) right++;
            if (right == controls.Length) return normalizedDestinations[right - 1];
            if (controls[right] <= control) return normalizedDestinations[right];

            float x0 = controls[right - 1], x1 = controls[right];
            float y0 = normalizedDestinations[right - 1], y1 = normalizedDestinations[right];
            // Native reads curve mode/strength but ignores them when the curve
            // blob exists. Preserve its distinct operation order and rounding.
            // Cast each operation to retain float32 intermediates on Mono.
            if (hasGraphCurve) return (float)(y0 + (float)((float)(control - x0) * (float)((float)(y1 - y0) / (float)(x1 - x0))));
            float t = (float)((float)(control - x0) / (float)(x1 - x0));
            if (t < 0f) t = 0f;
            else if (t > 1f) t = 1f;
            return (float)(y0 + (float)((float)(y1 - y0) * t));
        }
    }
}

namespace ActorAnimation
{
    using global::System;
    using global::Unity.Mathematics;

    [Serializable]
    public struct ActorSwingJobDynamicBoneCash
    {
        public float3 cachedTranslation0;
        public float3 cachedTranslation1;
        public float3 cachedTranslation2;
        public float3 cachedTranslation3;
        public float3 cachedTranslation4;
        public const int CachedTranslationCount = 5;
        public int cachedTranslationStart;
        public void EnqueueCachedTranslation(float3 data)
        {
            switch (cachedTranslationStart % CachedTranslationCount)
            {
                case 0: cachedTranslation0 = data; break;
                case 1: cachedTranslation1 = data; break;
                case 2: cachedTranslation2 = data; break;
                case 3: cachedTranslation3 = data; break;
                case 4: cachedTranslation4 = data; break;
            }
            cachedTranslationStart++;
        }

        public bool IsAlreadyStable()
        {
            if (cachedTranslationStart < CachedTranslationCount) return false;
            return math.lengthsq(cachedTranslation0 - cachedTranslation1)
                + math.lengthsq(cachedTranslation1 - cachedTranslation2)
                + math.lengthsq(cachedTranslation2 - cachedTranslation3)
                + math.lengthsq(cachedTranslation3 - cachedTranslation4)
                + math.lengthsq(cachedTranslation4 - cachedTranslation0) < 0.000001f;
        }
    }
}

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
        }

        public bool IsAlreadyStable()
        {
            return default(bool);
        }
    }
}

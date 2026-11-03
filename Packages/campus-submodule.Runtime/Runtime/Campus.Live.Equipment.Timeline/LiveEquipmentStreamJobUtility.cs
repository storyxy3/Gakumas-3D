namespace Campus.Live.Equipment.Timeline
{
    using global::Campus.Live.Equipment;
    using global::Unity.Mathematics;

    public static class LiveEquipmentStreamJobUtility
    {
        private static void UpdateColor(ref LiveEquipmentAnimationData animationData, ref LiveEquipmentStreamData streamData)
        {
        }

        private static void UpdateIntensity(ref LiveEquipmentAnimationData animationData, ref LiveEquipmentStreamData streamData)
        {
        }

        private static void UpdateHVRotation(ref LiveEquipmentAnimationData animationData, ref LiveEquipmentStreamData streamData, ref LiveEquipmentInitialData initialData)
        {
        }

        private static void RevertRollRotation(ref float4 initialRotation)
        {
        }

        private static void UpdateBasicRotation(ref LiveEquipmentAnimationData animationData, ref LiveEquipmentStreamData streamData)
        {
        }

        public static LiveEquipmentStreamData ConvertNone()
        {
            return default(LiveEquipmentStreamData);
        }

        public static LiveEquipmentStreamData ConvertSimple(ref LiveEquipmentAnimationData animationData)
        {
            return default(LiveEquipmentStreamData);
        }

        public static LiveEquipmentStreamData ConvertBasic(ref LiveEquipmentAnimationData animationData)
        {
            return default(LiveEquipmentStreamData);
        }

        public static LiveEquipmentStreamData ConvertLight(ref LiveEquipmentAnimationData animationData, ref LiveEquipmentInitialData initialData)
        {
            return default(LiveEquipmentStreamData);
        }

        public static LiveEquipmentStreamData ConvertLaser(ref LiveEquipmentAnimationData animationData, ref LiveEquipmentInitialData initialData)
        {
            return default(LiveEquipmentStreamData);
        }

        public static LiveEquipmentStreamData ConvertPsyllium(ref LiveEquipmentAnimationData animationData, ref LiveEquipmentInitialData initialData)
        {
            return default(LiveEquipmentStreamData);
        }

        public static LiveEquipmentStreamData ConvertDirectionalLight(ref LiveEquipmentAnimationData animationData)
        {
            return default(LiveEquipmentStreamData);
        }
    }
}

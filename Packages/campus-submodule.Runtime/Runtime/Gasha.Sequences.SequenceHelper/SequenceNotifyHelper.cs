namespace Gasha.Sequences.SequenceHelper
{
    using global::System.Threading;
    using global::Campus.Gasha;
    using global::Titan;
    using global::UnityEngine.Playables;

    public static class SequenceNotifyHelper
    {
        public static void ProcessSeMarker(INotification notification, CancellationToken ct)
        {
        }

        public static void ProcessBgmMarker(INotification notification, string envBgmAssetName, long envBgmStartTimeMs, string pickupBgmAssetName, long pickupBgmStartTimeMs)
        {
        }

        public static void ProcessHapticMarker(INotification notification)
        {
        }

        public static void ProcessParticleMarker(INotification notification, GashaGlobalEffect globalEffect)
        {
        }

        public static void Process3DModelMarker(INotification notification, GashaGlobalEffect globalEffect)
        {
        }

        public static void ProcessCardNewDisplayMarker(bool showNewLabel, INotification notification, TitanPlayer isNewTitanPlayer, CancellationToken ct)
        {
        }
    }
}

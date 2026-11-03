namespace CriWare.CriTimeline.Mana
{
    using global::System;
    using global::System.Collections.Generic;
    using global::CriWare;
    using global::CriWare.CriTimeline.Mana;
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Timeline;

    [TrackColor(0.15f, 0.5f, 1f)]
    [TrackBindingType(typeof(CriManaMovieMaterialBase))]
    [TrackClipType(typeof(CriManaClipBase))]
    public class CriManaTrack : TrackAsset
    {
        public bool frameSync;
        public bool checkPosWithinClip;
        public readonly Guid guid;
        private static Dictionary<int, Guid> bindDict;
        public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
        {
            return default(Playable);
        }

        private void OnDestroy()
        {
        }

        private static void RemoveTrackFromBindDict(CriManaTrack trackAsset)
        {
        }

        public CriManaTrack()
        {
        }
    }
}

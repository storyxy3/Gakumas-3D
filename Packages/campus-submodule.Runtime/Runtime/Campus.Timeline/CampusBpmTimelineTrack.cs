namespace Campus.Timeline
{
    using global::System;
    using global::System.Linq;
    using global::Campus.Timeline;
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Timeline;

    [Serializable]
    [TrackClipType(typeof(CampusBpmTimelineAsset))]
    public class CampusBpmTimelineTrack : PlayableTrack
    {
        private void AddKey(AnimationCurve curve, float time, float value)
        {
            var key = new Keyframe { time = time, inTangent = float.PositiveInfinity, outTangent = float.PositiveInfinity, value = value };
            curve.AddKey(key);
        }

        public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
        {
            var bpmCurve = new AnimationCurve();
            var numeratorCurve = new AnimationCurve();
            var denominatorCurve = new AnimationCurve();
            var clips = GetClips().ToArray();
            for (int i = 0; i < clips.Length; i++)
            {
                var clip = clips[i];
                var asset = clip.asset as CampusBpmTimelineAsset;
                AddKey(bpmCurve, (float)clip.start, asset.behaviour.Bpm);
                AddKey(numeratorCurve, (float)clip.start, asset.behaviour.beatNumerator);
                AddKey(denominatorCurve, (float)clip.start, asset.behaviour.beatDenominator);
                if (i == clips.Length - 1)
                {
                    AddKey(bpmCurve, (float)clip.end, asset.behaviour.Bpm);
                    AddKey(numeratorCurve, (float)clip.end, asset.behaviour.beatNumerator);
                    AddKey(denominatorCurve, (float)clip.end, asset.behaviour.beatDenominator);
                }
            }
            var bpmInfo = new CampusBpmInfo(bpmCurve, numeratorCurve, denominatorCurve);
            InjectBpmBehaviour(go.GetComponent<PlayableDirector>(), bpmInfo);
            var playable = ScriptPlayable<CampusBpmTimelineMixer>.Create(graph, inputCount);
            playable.GetBehaviour().bpmInfo = bpmInfo;
            return playable;
        }

        private void InjectBpmBehaviour(PlayableDirector playableDirector, CampusBpmInfo bpmInfo)
        {
            if (playableDirector == null) return;
            var timeline = playableDirector.playableAsset as TimelineAsset;
            if (timeline == null) return;
            foreach (var track in timeline.GetOutputTracks())
            {
                if (track is IBpmTrack bpmTrack) bpmTrack.BpmInfo = bpmInfo;
                if (track is CampusDirectorControlTrack)
                {
                    foreach (var clip in track.GetClips())
                    {
                        var asset = clip.asset as CampusDirectorControlAsset;
                        InjectBpmBehaviour(asset.directorReference.Resolve(playableDirector), bpmInfo);
                    }
                }
            }
        }

        public CampusBpmTimelineTrack()
        {
        }
    }
}

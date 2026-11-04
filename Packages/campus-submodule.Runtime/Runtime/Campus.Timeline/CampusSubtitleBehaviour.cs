namespace Campus.Timeline
{
    using global::System;
    using global::Campus.Live;
    using global::UnityEngine.Playables;

    [Serializable]
    public class CampusSubtitleBehaviour : PlayableBehaviour
    {
        public SRTSubtitle subtitle;
        private string _lastSubtitle = "";
        public override void ProcessFrame(Playable playable, FrameData info, object playerData)
        {
            var text = playerData as global::TMPro.TMP_Text;
            if (text == null || subtitle == null || subtitle.subtitles == null || subtitle.subtitles.Length == 0) return;
            var current = GetSubtitle((float)playable.GetTime(), subtitle);
            if (current == _lastSubtitle) return;
            text.SetText(current);
            _lastSubtitle = current;
        }

        private string GetSubtitle(float time, SRTSubtitle block)
        {
            if (block == null) return "";
            foreach (var item in block.subtitles)
                if (item.from <= time && item.to >= time) return item.text;
            return "";
        }

        public CampusSubtitleBehaviour()
        {
        }
    }
}

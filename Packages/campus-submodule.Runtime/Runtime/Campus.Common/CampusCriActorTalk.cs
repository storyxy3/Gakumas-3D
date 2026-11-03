namespace Campus.Common
{
    using global::Campus.Common;
    using global::CriWare;
    using global::UnityEngine;
    using global::VL;

    [AddComponentMenu("")]
    public class CampusCriActorTalk : VLActorTalkBase<CampusCriActorTalkFFT, CriAtomSource>
    {
        private string _cueSheet;
        private string _cueName;
        protected override void CreateVLActorTalkFFT()
        {
        }

        protected override void OnPlayTalk(CriAtomSource source)
        {
        }

        protected override void OnReset()
        {
        }

        protected override bool ShouldReset(CriAtomSource source)
        {
            return default(bool);
        }

        public CampusCriActorTalk()
        {
        }
    }
}

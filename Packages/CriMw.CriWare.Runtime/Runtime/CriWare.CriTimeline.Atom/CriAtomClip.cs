namespace CriWare.CriTimeline.Atom
{
    using global::CriWare;
    using global::CriWare.CriTimeline.Atom;
    using global::UnityEngine;
    using global::UnityEngine.Playables;

    public class CriAtomClip : CriAtomClipBase
    {
        public string cueSheet;
        public string cueName;
        public CriAtomBehaviour templateBehaviour;
        public override string CueName
        {
            get
            {
                return null;
            }
        }

        public override string AcbPath
        {
            get
            {
                return null;
            }
        }

        public override string AwbPath
        {
            get
            {
                return null;
            }
        }

        public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
        {
            return default(Playable);
        }

        public override CriAtomExAcb GetAcb()
        {
            return null;
        }

        private CriAtomCueSheet GetCueSheet()
        {
            return null;
        }

        public override void SetCueFromAtomSource(CriAtomSourceBase atomSource)
        {
        }

        public CriAtomClip()
        {
        }
    }
}

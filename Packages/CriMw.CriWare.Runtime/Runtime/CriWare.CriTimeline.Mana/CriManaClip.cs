namespace CriWare.CriTimeline.Mana
{
    using global::CriWare.CriTimeline.Mana;
    using global::UnityEngine;
    using global::UnityEngine.Playables;

    public class CriManaClip : CriManaClipBase
    {
        public string m_moviePath;
        public TextAsset m_movieData;
        public CriManaBehaviour m_manaBehaviour;
        public override string MoviePath
        {
            get
            {
                return null;
            }
        }

        public override byte[] MovieData
        {
            get
            {
                return null;
            }
        }

        public override string MovieName
        {
            get
            {
                return null;
            }
        }

        public override int DataId
        {
            get
            {
                return default(int);
            }
        }

        public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
        {
            return default(Playable);
        }

        public CriManaClip()
        {
        }
    }
}

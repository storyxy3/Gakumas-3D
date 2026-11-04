using System.Collections;
using UnityEngine;

namespace CriWare
{
    // CriWare.CriAtomSource (TypeDefIndex 31676).
    [AddComponentMenu("CRIWARE/CRI Atom Source")]
    public class CriAtomSource : CriAtomSourceBase
    {
        [SerializeField]
        private string _cueName = "";
        [SerializeField]
        private string _cueSheet = "";

        public string cueName
        {
            set => _cueName = value;
            get => _cueName;
        }

        public string cueSheet
        {
            set => _cueSheet = value;
            get => _cueSheet;
        }

        protected override void PlayOnStart()
        {
            if (playOnStart && !string.IsNullOrEmpty(_cueName))
                StartCoroutine(PlayAsync(_cueName));
        }

        private IEnumerator PlayAsync(string cueName)
        {
            CriAtomExAcb acb = null;
            while (acb == null && !string.IsNullOrEmpty(_cueSheet))
            {
                acb = CriAtom.GetAcb(_cueSheet);
                if (acb == null)
                    yield return null;
            }
            player.SetCue(acb, cueName);
            InternalPlayCue();
        }

        public override CriAtomExPlayback Play()
        {
            return Play(_cueName);
        }

        protected override CriAtomExAcb GetAcb()
        {
            if (string.IsNullOrEmpty(_cueSheet))
                return null;
            return CriAtom.GetAcb(_cueSheet);
        }
    }
}

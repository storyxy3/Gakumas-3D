// Gakumas (CriWare 2.44.49) members missing from the PJSK port, copied from the DummyDll skeleton.
// TODO(qa-recon): bodies are skeleton placeholders until reconstructed from the game.
#pragma warning disable 0067, 0169, 0414, 0649
using AOT;
using System;
using UnityEngine.Scripting;
using UnityEngine;
using global::CriWare;
using global::System.Runtime.CompilerServices;
using global::System;
using global::UnityEngine;

namespace CriWare
{
    public abstract partial class CriAtomSourceBase
    {


        public uint randomPositionListMaxLength
        {
            get
            {
                return default(uint);
            }

            set
            {
            }
        }



        public CriAtomRegion regionOnStart
        {
            get
            {
                return null;
            }

            set
            {
            }
        }



        public CriAtomListener listenerOnStart
        {
            get
            {
                return null;
            }

            set
            {
            }
        }



        public float pan3dAngle
        {
            get
            {
                return default(float);
            }

            set
            {
            }
        }



        public float pan3dDistance
        {
            get
            {
                return default(float);
            }

            set
            {
            }
        }



        public int startTime
        {
            get
            {
                return default(int);
            }

            set
            {
            }
        }



        public long time
        {
            get
            {
                return default(long);
            }
        }



        public bool attenuationDistanceSetting
        {
            get
            {
                return default(bool);
            }

            set
            {
            }
        }



        public CriAtomExPlayback Play(int cueId)
        {
            return default(CriAtomExPlayback);
        }



        public void Pause(bool sw)
        {
        }



        public bool IsPaused()
        {
            return default(bool);
        }



        public void SetBusSendLevel(string busName, float level)
        {
        }



        [Obsolete("Use CriAtomSource.SetBusSendLevel(string, float)")]
        public void SetBusSendLevel(int busId, float level)
        {
        }



        public void SetBusSendLevelOffset(string busName, float levelOffset)
        {
        }



        [Obsolete("Use CriAtomSource.SetBusSendLevelOffset(string, float)")]
        public void SetBusSendLevelOffset(int busId, float levelOffset)
        {
        }



        [Obsolete("Use CriAtomSource.SetAisacControl")]
        public void SetAisac(string controlName, float value)
        {
        }



        public void SetAisacControl(uint controlId, float value)
        {
        }



        [Obsolete("Use CriAtomSource.SetAisacControl")]
        public void SetAisac(uint controlId, float value)
        {
        }



        public void AttachToAnalyzer(CriAtomExOutputAnalyzer analyzer)
        {
        }



        public void DetachFromAnalyzer(CriAtomExOutputAnalyzer analyzer)
        {
        }



        protected CriAtomSourceBase()
        {
        }
    }
}

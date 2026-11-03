namespace CriWare.CriTimeline.Atom
{
    using global::System;
    using global::System.Collections.Generic;
    using global::CriWare;
    using global::CriWare.CriTimeline.Atom;
    using global::UnityEngine;

    public class CriAtomTimelinePreviewer : IDisposable
    {
        private class PlayerSource : IDisposable
        {
            public readonly CriAtomExPlayer player;
            public readonly CriAtomEx3dSource source3d;
            private Vector3? lastPos;
            private bool disposed;
            public PlayerSource()
            {
            }

            ~PlayerSource()
            {
            }

            public void Dispose()
            {
            }

            private void dispose()
            {
            }

            public void Set3dTransform(Vector3 pos, Vector3 forward, Vector3 up, float deltaTime)
            {
            }

            public void ClearLastPos()
            {
            }
        }

        private class PreviewListener : IDisposable
        {
            public readonly CriAtomEx3dListener listener;
            public readonly CriAtomListener transformObj;
            private Vector3? lastPos;
            private bool disposed;
            public PreviewListener(CriAtomListener listenerObj)
            {
            }

            ~PreviewListener()
            {
            }

            public void Dispose()
            {
            }

            private void dispose()
            {
            }

            public void Set3dTransform(float deltaTime)
            {
            }

            public void Exile()
            {
            }

            public void ClearLastPos()
            {
            }
        }

        private static CriAtomTimelinePreviewer instance;
        private CriAtom atom;
        private string lastAcfFile;
        private Dictionary<string, CriAtomExAcb> acbTable;
        private Dictionary<Guid, PlayerSource> playerTable;
        private Dictionary<Guid, PreviewListener> listenerTable;
        private List<KeyValuePair<Guid, PreviewListener>> listenerPurgeList;
        private Guid? trackIdForListenerUpdate;
        public static CriAtomTimelinePreviewer Instance
        {
            get
            {
                return null;
            }
        }

        public static bool IsInitialized
        {
            get
            {
                return default(bool);
            }
        }

        public static void InstanceDispose()
        {
        }

        public CriAtomTimelinePreviewer()
        {
        }

        private PlayerSource GetPlayer(Guid trackId)
        {
            return null;
        }

        public void Update3dTransform(Guid trackId, Transform transform, float deltaTime)
        {
        }

        public void InitPreviewListenerList(CriAtomListener[] listenerList)
        {
        }

        public void UpdateAllListeners(Guid trackId, float deltaTime, CriAtomListener exclusiveObj)
        {
        }

        public void SetCue(Guid trackId, CriAtomExAcb acb, string cueName)
        {
        }

        public CriAtomExAcb GetAcb(string acbPath, string awbPath)
        {
            return null;
        }

        public CriAtomExPlayback Play(Guid trackId)
        {
            return default(CriAtomExPlayback);
        }

        public void StopTrack(Guid trackId, bool stopWithoutRelease = true)
        {
        }

        public void StopAllTracks(bool stopWithoutRelease = true)
        {
        }

        public void SetStartTime(Guid trackId, long startTimeMs)
        {
        }

        public void SetLoop(Guid trackId, bool sw)
        {
        }

        public void SetVolume(Guid trackId, float volume)
        {
        }

        public void SetPitch(Guid trackId, float pitch)
        {
        }

        public void SetAISAC(Guid trackId, string controlName, float value)
        {
        }

        public void PlayerUpdateParameter(Guid trackId, CriAtomExPlayback atomExPlayback)
        {
        }

        public void UpdateTimelineExtension(CriAtomSourceBase bindObject, Guid trackGuid)
        {
        }

        ~CriAtomTimelinePreviewer()
        {
        }

        public void Dispose()
        {
        }

        private void Dispose(bool disposing)
        {
        }
    }
}

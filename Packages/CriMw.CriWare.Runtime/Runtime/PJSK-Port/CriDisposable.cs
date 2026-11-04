using System;
using System.Collections.Generic;
using UnityEngine;

namespace CriWare
{
    // CriWare.CriDisposable (TypeDefIndex 31921).
    public abstract class CriDisposable : IDisposable
    {
        public Guid guid;

        protected CriDisposable()
        {
            guid = Guid.NewGuid();
        }

        public abstract void Dispose();
    }

    // CriWare.CriDisposableObjectManager (TypeDefIndex 31924): every native-backed object, disposed per module on
    // library finalization.
    public static class CriDisposableObjectManager
    {
        public enum ModuleType
        {
            Atom = 0,
            AtomMic = 1,
            Fs = 2,
            FsWeb = 3,
            Mana = 4,
            Lips = 5,
            Vip = 6,
            Rtc = 7
        }

        public struct ObjectRef
        {
            public Guid guid;
            public ModuleType type;
            public CriDisposable disposable;

            public ObjectRef(Guid _guid, CriDisposable _disposable, ModuleType _type)
            {
                guid = _guid;
                disposable = _disposable;
                type = _type;
            }
        }

        private static List<ObjectRef> refList = new List<ObjectRef>();

        public static void Register(CriDisposable disposable, ModuleType type)
        {
            if (SearchForDisposable(disposable) >= 0)
            {
                Debug.LogWarning("[CRIWARE] Internal: Duplicated object GUID");
                return;
            }
            lock (refList)
            {
                refList.Add(new ObjectRef(disposable.guid, disposable, type));
            }
        }

        public static bool Unregister(CriDisposable disposable)
        {
            lock (refList)
            {
                var index = SearchForDisposable(disposable);
                if (index < 0)
                    return false;
                refList.RemoveAt(index);
                return true;
            }
        }

        public static bool IsDisposed(CriDisposable disposable)
        {
            return SearchForDisposable(disposable) < 0;
        }

        public static void CallOnModuleFinalization(ModuleType type)
        {
            DisposeAll(type);
        }

        private static int SearchForDisposable(CriDisposable disposable)
        {
            lock (refList)
            {
                for (var i = refList.Count - 1; i >= 0; i--)
                {
                    if (refList[i].guid == disposable.guid)
                        return i;
                }
                return -1;
            }
        }

        private static void DisposeAll(ModuleType type)
        {
            lock (refList)
            {
                while (true)
                {
                    var index = GetNextWithType(type);
                    if (index < 0)
                        break;
                    if (refList[index].disposable != null)
                    {
                        refList[index].disposable.Dispose();
                    }
                    else
                    {
                        Debug.LogWarning("[CRIWARE] Internal: Object disposal(Type:" + refList[index].type.ToString() +
                                         ") not handled by CriDisposableObjectManager; memory leak may have occured.");
                        refList.RemoveAt(index);
                    }
                }
            }
        }

        private static int GetNextWithType(ModuleType type)
        {
            for (var i = refList.Count - 1; i >= 0; i--)
            {
                if (refList[i].type == type)
                    return i;
            }
            return -1;
        }
    }
}

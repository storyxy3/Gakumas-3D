namespace CriWare
{
    using global::System;
    using global::System.Collections.Generic;
    using global::CriWare;

    public static class CriDisposableObjectManager
    {
        public enum ModuleType
        {
            Atom,
            AtomMic,
            Fs,
            FsWeb,
            Mana,
            Lips,
            Vip,
            Rtc
        }

        public struct ObjectRef
        {
            public Guid guid;
            public ModuleType type;
            public CriDisposable disposable;
            public ObjectRef(Guid _guid, CriDisposable _disposable, ModuleType _type)
            {
                this = default;
            }
        }

        private static List<ObjectRef> refList;
        private static int SearchForDisposable(CriDisposable disposable)
        {
            return default(int);
        }

        public static void Register(CriDisposable disposable, ModuleType type)
        {
        }

        public static bool Unregister(CriDisposable disposable)
        {
            return default(bool);
        }

        public static bool IsDisposed(CriDisposable disposable)
        {
            return default(bool);
        }

        public static void CallOnModuleFinalization(ModuleType type)
        {
        }

        private static int GetNextWithType(ModuleType type)
        {
            return default(int);
        }

        public static void DisposeAll(ModuleType type)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using UnityEngine;

namespace CriWare
{
    // CriWare.CriManaPlugin (TypeDefIndex 31856), the library initialization members. The movie player and renderer
    // parts are ported with the stage screens (SL-E3).
    public partial class CriManaPlugin
    {
        private static int initializationCount = 0;
        private static bool isConfigured = false;
        private static bool enabledMultithreadedRendering = false;
        public static int renderingEventOffset = 1129775104;

        public static bool isInitialized => initializationCount > 0;

        public static uint GetPrimeBufferAlignmentSize() => CriWareNative.Native.CRIWARE747D292C();

        public static void SetConfigParameters(bool graphicsMultiThreaded, int num_decoders, int max_num_of_entries)
        {
            var graphicsDeviceType = SystemInfo.graphicsDeviceType;
            enabledMultithreadedRendering = graphicsMultiThreaded;
            Common.criWareUnity_SetRenderingEventOffsetForMana(renderingEventOffset);
            CRIWARE61D25984((int)graphicsDeviceType, enabledMultithreadedRendering, num_decoders, max_num_of_entries);
            isConfigured = true;
        }

        public static void SetConfigAdditonalParameters_ANDROID(bool enable_buffer_output_for_h264,
            bool enable_buffer_output_for_vp9)
        {
#if UNITY_ANDROID
            using (var version = new AndroidJavaClass("android.os.Build$VERSION"))
            {
                if (version.GetStatic<int>("SDK_INT") >= 16)
                    criManaUnity_SetConfigAdditionalParameters_ANDROID(enable_buffer_output_for_h264,
                        enable_buffer_output_for_vp9);
            }
#else
            // Host boundary: no android.os.Build off-device; every device the game supports has SDK_INT >= 16.
            criManaUnity_SetConfigAdditionalParameters_ANDROID(enable_buffer_output_for_h264,
                enable_buffer_output_for_vp9);
#endif
        }

        public static void InitializeLibrary()
        {
            initializationCount++;
            if (initializationCount != 1)
                return;
            if (IsLibraryInitialized())
            {
                FinalizeLibrary();
                initializationCount = 1;
            }
            if (!isConfigured)
                Debug.Log("[CRIWARE] Mana initialization parameters are not configured. Initializes Mana by default parameters.");
            CriFsPlugin.InitializeLibrary();
            CriAtomPlugin.InitializeLibrary();
            SetupVp9();
            CRIWARECF1918FA();
            CriMana.Detail.AutoResisterRendererResourceFactories.InvokeAutoRegister();
        }

        public static bool IsLibraryInitialized()
        {
            return CRIWARE39B9723F();
        }

        public static void FinalizeLibrary()
        {
            initializationCount--;
            if (initializationCount < 0)
            {
                initializationCount = 0;
                if (!IsLibraryInitialized())
                    return;
            }
            if (initializationCount != 0)
                return;
            CriDisposableObjectManager.CallOnModuleFinalization(CriDisposableObjectManager.ModuleType.Mana);
            CRIWAREEA336D77();
            CriMana.Detail.RendererResourceFactory.DisposeAllFactories();
            CriAtomPlugin.FinalizeLibrary();
            CriFsPlugin.FinalizeLibrary();
        }

        public static void UseStreamerManager(bool flag)
        {
            criMana_UseStreamerManager(flag);
        }

        private static void SetupVp9()
        {
            var vp9ExpansionClass = GetVp9ExpansionClass();
            if (vp9ExpansionClass == null)
                return;
            if (!IsVp9CodecSupported())
            {
                Debug.Log("[CRIWARE] VP9 video playback is not supported on the current platform.");
                return;
            }
            var method = vp9ExpansionClass.GetMethod("SetupVp9Decoder");
            if (method == null)
            {
                Debug.LogError("[CRIWARE] ERROR: CriManaVp9.SetupVp9Decoder method is not found.");
                return;
            }
            method.Invoke(null, null);
        }

        private static Type GetVp9ExpansionClass()
        {
            var type = Type.GetType("CriManaVp9");
            if (type != null)
                return type;
            return Type.GetType("CriWare.CriManaVp9, CriMw.CriWare.Vp9.Runtime");
        }

        // The 7.0.0 build ships no CriManaVp9 assembly, so SetupVp9 returns before reaching this check.
        private static bool IsVp9CodecSupported()
        {
            throw new NotSupportedException("CriManaPlugin.IsVp9CodecSupported is not on the StreamingLive paths.");
        }

        private static void CRIWARE61D25984(int graphics_api, bool graphics_multi_threaded, int num_decoders,
            int num_of_max_entries) =>
            CriWareNative.Native.CRIWARE61D25984(graphics_api, graphics_multi_threaded, num_decoders, num_of_max_entries);
        private static void criManaUnity_SetConfigAdditionalParameters_ANDROID(bool buffer_h264, bool buffer_vp9) =>
            CriWareNative.Native.criManaUnity_SetConfigAdditionalParameters_ANDROID(buffer_h264, buffer_vp9);
        private static void CRIWARECF1918FA() => CriWareNative.Native.CRIWARECF1918FA();
        private static void CRIWAREEA336D77() => CriWareNative.Native.CRIWAREEA336D77();
        private static bool CRIWARE39B9723F() => CriWareNative.Native.CRIWARE39B9723F();
        private static void criMana_UseStreamerManager(bool flag) => CriWareNative.Native.criMana_UseStreamerManager(flag);
    }
}

namespace CriWare.CriMana.Detail
{
    // CriWare.CriMana.Detail.RendererResourceFactoryPriorityAttribute (TypeDefIndex 31978).
    public class RendererResourceFactoryPriorityAttribute : Attribute
    {
        public readonly int priority;

        public RendererResourceFactoryPriorityAttribute(int priority)
        {
            this.priority = priority;
        }
    }

    // CriWare.CriMana.Detail.RendererResourceFactory (TypeDefIndex 31977): the factory registry (DispatchAndCreate and
    // the concrete factories are ported with the stage screens, SL-E3).
    public abstract partial class RendererResourceFactory : IDisposable
    {
        private static SortedList<int, RendererResourceFactory> factoryList =
            new SortedList<int, RendererResourceFactory>();
        private bool disposed;

        public static void RegisterFactory(RendererResourceFactory factory, int priority)
        {
            factoryList.Add(priority, factory);
        }

        public static void DisposeAllFactories()
        {
            foreach (var factory in factoryList)
                factory.Value.Dispose();
            factoryList.Clear();
        }

        ~RendererResourceFactory()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (disposed)
                return;
            if (disposing)
                OnDisposeManaged();
            OnDisposeUnmanaged();
            disposed = true;
        }

        protected abstract void OnDisposeManaged();

        protected abstract void OnDisposeUnmanaged();
    }

    // CriWare.CriMana.Detail.AutoResisterRendererResourceFactories (TypeDefIndex 31971): registers its public nested
    // factory types by their priority attribute (SL-E3). 注册哪几个工厂由 CriManaRendererResource.cs 按编译平台决定：
    // iOS/macOS 是 JP 7.0.0 iOS 集（5000/7000/10000），其余是 Android 集（5050/5060/7000/10000）。
    public static partial class AutoResisterRendererResourceFactories
    {
        public static void InvokeAutoRegister()
        {
            var types = typeof(AutoResisterRendererResourceFactories).GetNestedTypes(
                System.Reflection.BindingFlags.Public);
            foreach (var type in types)
            {
                if (!type.IsSubclassOf(typeof(RendererResourceFactory)))
                {
                    Debug.LogError("[CRIWARE] internal logic error. " + type.Name +
                                   " is required to be a subclass of RendererResourceFactory.");
                    continue;
                }
                var attribute = Attribute.GetCustomAttribute(type, typeof(RendererResourceFactoryPriorityAttribute));
                if (attribute == null)
                {
                    Debug.LogError("[CRIWARE] internal logic error. need priority attribute. (" + type.Name + ")");
                    continue;
                }
                RendererResourceFactory.RegisterFactory((RendererResourceFactory)Activator.CreateInstance(type),
                    ((RendererResourceFactoryPriorityAttribute)attribute).priority);
            }
        }
    }
}

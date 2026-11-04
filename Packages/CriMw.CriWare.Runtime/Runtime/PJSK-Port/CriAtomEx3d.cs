using System;
using System.Collections.Generic;
using UnityEngine;

namespace CriWare
{
    // CriWare.CriAtomEx3dSource (TypeDefIndex 31744): created by every CriAtomSource.
    public partial class CriAtomEx3dSource : CriDisposable
    {
        public struct Config
        {
            public bool enableVoicePriorityDecay;
            public uint randomPositionListMaxLength;
        }

        private uint currentRandomPositionListMaxLength;
        private IntPtr handle;

        public IntPtr nativeHandle => handle;

        public CriAtomEx3dSource(bool enableVoicePriorityDecay = false, uint randomPositionListMaxLength = 0)
        {
            var config = default(Config);
            config.enableVoicePriorityDecay = enableVoicePriorityDecay;
            config.randomPositionListMaxLength = randomPositionListMaxLength;
            handle = criAtomEx3dSource_Create(ref config, IntPtr.Zero, 0);
            CriDisposableObjectManager.Register(this, CriDisposableObjectManager.ModuleType.Atom);
            currentRandomPositionListMaxLength = randomPositionListMaxLength;
        }

        public override void Dispose()
        {
            Dispose(true);
        }

        private void Dispose(bool disposing)
        {
            CriDisposableObjectManager.Unregister(this);
            if (handle != IntPtr.Zero)
            {
                criAtomEx3dSource_Destroy(handle);
                handle = IntPtr.Zero;
            }
            if (disposing)
                GC.SuppressFinalize(this);
        }

        ~CriAtomEx3dSource()
        {
            Dispose(false);
        }

        public void Update()
        {
            criAtomEx3dSource_Update(handle);
        }

        public void SetPosition(float x, float y, float z)
        {
            var position = new CriAtomEx.NativeVector(x, y, z);
            criAtomEx3dSource_SetPosition(handle, ref position);
        }

        public void SetVelocity(float x, float y, float z)
        {
            var velocity = new CriAtomEx.NativeVector(x, y, z);
            criAtomEx3dSource_SetVelocity(handle, ref velocity);
        }

        public void SetOrientation(Vector3 front, Vector3 top)
        {
            var nfront = new CriAtomEx.NativeVector(front);
            var ntop = new CriAtomEx.NativeVector(top);
            criAtomEx3dSource_SetOrientation(handle, ref nfront, ref ntop);
        }

        public void Set3dRegion(CriAtomEx3dRegion region3d)
        {
            criAtomEx3dSource_Set3dRegionHn(handle, region3d != null ? region3d.nativeHandle : IntPtr.Zero);
        }

        public void SetRandomPositionConfig(CriAtomEx.Randomize3dConfig? config)
        {
            if (config.HasValue && config.Value.CalculationType != CriAtomEx.Randomize3dCalcType.None)
            {
                var value = config.Value;
                criAtomEx3dSource_SetRandomPositionConfig(handle, ref value);
            }
            else
            {
                criAtomEx3dSource_SetRandomPositionConfig(handle, IntPtr.Zero);
            }
        }

        private static IntPtr criAtomEx3dSource_Create(ref Config config, IntPtr work, int work_size) =>
            CriWareNative.Native.criAtomEx3dSource_Create(ref config, work, work_size);
        private static void criAtomEx3dSource_Destroy(IntPtr ex_3d_source) =>
            CriWareNative.Native.criAtomEx3dSource_Destroy(ex_3d_source);
        private static void criAtomEx3dSource_Set3dRegionHn(IntPtr ex_3d_source, IntPtr ex_3d_region) =>
            CriWareNative.Native.criAtomEx3dSource_Set3dRegionHn(ex_3d_source, ex_3d_region);
        private static void criAtomEx3dSource_Update(IntPtr ex_3d_source) =>
            CriWareNative.Native.criAtomEx3dSource_Update(ex_3d_source);
        private static void criAtomEx3dSource_SetPosition(IntPtr ex_3d_source, ref CriAtomEx.NativeVector position) =>
            CriWareNative.Native.criAtomEx3dSource_SetPosition(ex_3d_source, ref position);
        private static void criAtomEx3dSource_SetVelocity(IntPtr ex_3d_source, ref CriAtomEx.NativeVector velocity) =>
            CriWareNative.Native.criAtomEx3dSource_SetVelocity(ex_3d_source, ref velocity);
        private static void criAtomEx3dSource_SetOrientation(IntPtr ex_3d_source, ref CriAtomEx.NativeVector front,
            ref CriAtomEx.NativeVector top) =>
            CriWareNative.Native.criAtomEx3dSource_SetOrientation(ex_3d_source, ref front, ref top);
        private static void criAtomEx3dSource_SetRandomPositionConfig(IntPtr ex_3d_source,
            ref CriAtomEx.Randomize3dConfig config) =>
            CriWareNative.Native.criAtomEx3dSource_SetRandomPositionConfig(ex_3d_source, ref config);
        private static void criAtomEx3dSource_SetRandomPositionConfig(IntPtr ex_3d_source, IntPtr config) =>
            CriWareNative.Native.criAtomEx3dSource_SetRandomPositionConfig(ex_3d_source, config);
    }

    // CriWare.CriAtomEx3dListener (TypeDefIndex 31742): CriAtomListener's dummy native listener.
    public partial class CriAtomEx3dListener : CriDisposable
    {
        public struct Config
        {
            public int reserved;
        }

        private IntPtr handle;

        public IntPtr nativeHandle => handle;

        public CriAtomEx3dListener()
        {
            var config = default(Config);
            config.reserved = 0;
            handle = criAtomEx3dListener_Create(ref config, IntPtr.Zero, 0);
            CriDisposableObjectManager.Register(this, CriDisposableObjectManager.ModuleType.Atom);
        }

        public override void Dispose()
        {
            Dispose(true);
        }

        private void Dispose(bool disposing)
        {
            CriDisposableObjectManager.Unregister(this);
            if (handle != IntPtr.Zero)
            {
                criAtomEx3dListener_Destroy(handle);
                handle = IntPtr.Zero;
            }
            if (disposing)
                GC.SuppressFinalize(this);
        }

        ~CriAtomEx3dListener()
        {
            Dispose(false);
        }

        public void Update()
        {
            if (handle != IntPtr.Zero) CriWareNative.Native.criAtomEx3dListener_Update(handle);
        }

        public void SetPosition(float x, float y, float z)
        {
            if (handle == IntPtr.Zero) return;
            var position = new CriAtomEx.NativeVector(x, y, z);
            CriWareNative.Native.criAtomEx3dListener_SetPosition(handle, ref position);
        }

        public void SetVelocity(float x, float y, float z)
        {
            if (handle == IntPtr.Zero) return;
            var velocity = new CriAtomEx.NativeVector(x, y, z);
            CriWareNative.Native.criAtomEx3dListener_SetVelocity(handle, ref velocity);
        }

        public void SetOrientation(float fx, float fy, float fz, float ux, float uy, float uz)
        {
            if (handle == IntPtr.Zero) return;
            var front = new CriAtomEx.NativeVector(fx, fy, fz);
            var top = new CriAtomEx.NativeVector(ux, uy, uz);
            CriWareNative.Native.criAtomEx3dListener_SetOrientation(handle, ref front, ref top);
        }

        public void Set3dRegion(CriAtomEx3dRegion region3d)
        {
            if (handle != IntPtr.Zero)
                CriWareNative.Native.criAtomEx3dListener_Set3dRegionHn(handle, region3d != null ? region3d.nativeHandle : IntPtr.Zero);
        }

        private static IntPtr criAtomEx3dListener_Create(ref Config config, IntPtr work, int work_size) =>
            CriWareNative.Native.criAtomEx3dListener_Create(ref config, work, work_size);
        private static void criAtomEx3dListener_Destroy(IntPtr ex_3d_listener) =>
            CriWareNative.Native.criAtomEx3dListener_Destroy(ex_3d_listener);
    }

    // CriWare.CriAtomEx3dRegion (TypeDefIndex 31750): only a field type on the StreamingLive paths.
    public partial class CriAtomEx3dRegion : CriDisposable
    {
        private IntPtr handle;

        public IntPtr nativeHandle => handle;

        public override void Dispose()
        {
            throw new NotSupportedException("CriAtomEx3dRegion is not used on the StreamingLive paths.");
        }
    }

    // CriWare.CriAtomRegion (TypeDefIndex 31673): no StreamingLive asset has one; only the members CriAtomSourceBase
    // touches are declared.
    [AddComponentMenu("CRIWARE/CRI Atom Region")]
    [DisallowMultipleComponent]
    public partial class CriAtomRegion : CriMonoBehaviour
    {
        public CriAtomEx3dRegion region3dHn { get; private set; }
        internal List<CriAtomSourceBase> referringSources = new List<CriAtomSourceBase>();
        internal List<CriAtomListener> referringListeners = new List<CriAtomListener>();

        public override void CriInternalUpdate()
        {
        }

        public override void CriInternalLateUpdate()
        {
        }
    }
}

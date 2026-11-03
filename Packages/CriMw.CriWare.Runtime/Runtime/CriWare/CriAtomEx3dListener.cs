namespace CriWare
{
    using global::System;
    using global::System.Runtime.InteropServices;
    using global::CriWare;

    public class CriAtomEx3dListener : CriDisposable
    {
        public struct Config
        {
            public int reserved;
        }

        private IntPtr handle;
        public IntPtr nativeHandle
        {
            get
            {
                return default(IntPtr);
            }
        }

        public CriAtomEx3dListener()
        {
        }

        public override void Dispose()
        {
        }

        private void Dispose(bool disposing)
        {
        }

        public void Update()
        {
        }

        public void ResetParameters()
        {
        }

        public void SetPosition(float x, float y, float z)
        {
        }

        public void SetVelocity(float x, float y, float z)
        {
        }

        public void SetOrientation(float fx, float fy, float fz, float ux, float uy, float uz)
        {
        }

        [Obsolete("Use SetDopplerMultiplier instead")]
        public void SetDistanceFactor(float distanceFactor)
        {
        }

        public void SetDopplerMultiplier(float dopplerMultiplier)
        {
        }

        public void SetFocusPoint(float x, float y, float z)
        {
        }

        public void SetDistanceFocusLevel(float distanceFocusLevel)
        {
        }

        public void SetDirectionFocusLevel(float directionFocusLevel)
        {
        }

        public void Set3dRegion(CriAtomEx3dRegion region3d)
        {
        }

        public bool IsDestroyable()
        {
            return default(bool);
        }

        ~CriAtomEx3dListener()
        {
        }

        [PreserveSig]
        private static extern IntPtr criAtomEx3dListener_Create(ref Config config, IntPtr work, int work_size);
        [PreserveSig]
        private static extern void criAtomEx3dListener_Destroy(IntPtr ex_3d_listener);
        [PreserveSig]
        private static extern void criAtomEx3dListener_Update(IntPtr ex_3d_listener);
        [PreserveSig]
        private static extern void criAtomEx3dListener_ResetParameters(IntPtr ex_3d_listener);
        [PreserveSig]
        private static extern void criAtomEx3dListener_SetPosition(IntPtr ex_3d_listener, ref CriAtomEx.NativeVector position);
        [PreserveSig]
        private static extern void criAtomEx3dListener_SetVelocity(IntPtr ex_3d_listener, ref CriAtomEx.NativeVector velocity);
        [PreserveSig]
        private static extern void criAtomEx3dListener_SetOrientation(IntPtr ex_3d_listener, ref CriAtomEx.NativeVector front, ref CriAtomEx.NativeVector top);
        [PreserveSig]
        private static extern void criAtomEx3dListener_SetDistanceFactor(IntPtr ex_3d_listener, float distance_factor);
        [PreserveSig]
        private static extern void criAtomEx3dListener_SetDopplerMultiplier(IntPtr ex_3d_listener, float doppler_multiplier);
        [PreserveSig]
        private static extern void criAtomEx3dListener_SetFocusPoint(IntPtr ex_3d_listener, ref CriAtomEx.NativeVector focus_point);
        [PreserveSig]
        private static extern void criAtomEx3dListener_SetDistanceFocusLevel(IntPtr ex_3d_listener, float distance_focus_level);
        [PreserveSig]
        private static extern void criAtomEx3dListener_SetDirectionFocusLevel(IntPtr ex_3d_listener, float direction_focus_level);
        [PreserveSig]
        private static extern bool criAtomEx3dListener_IsDestroyable(IntPtr ex_3d_listener);
        [PreserveSig]
        private static extern void criAtomEx3dListener_Set3dRegionHn(IntPtr ex_3d_listener, IntPtr ex_3d_region);
    }
}

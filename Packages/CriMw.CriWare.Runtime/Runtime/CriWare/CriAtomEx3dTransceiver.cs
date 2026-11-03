namespace CriWare
{
    using global::System;
    using global::System.Runtime.InteropServices;
    using global::CriWare;
    using global::UnityEngine;

    public class CriAtomEx3dTransceiver : CriDisposable
    {
        public struct Config
        {
            public int reserved;
        }

        private static class UnsafeNativeMethods
        {
            [PreserveSig]
            internal static extern IntPtr criAtomEx3dTransceiver_Create(ref Config config, IntPtr work, int work_size);
            [PreserveSig]
            internal static extern void criAtomEx3dTransceiver_Destroy(IntPtr ex_3d_transceiver);
            [PreserveSig]
            internal static extern void criAtomEx3dTransceiver_Update(IntPtr ex_3d_transceiver);
            [PreserveSig]
            internal static extern void criAtomEx3dTransceiver_SetInputPosition(IntPtr ex_3d_transceiver, ref CriAtomEx.NativeVector position);
            [PreserveSig]
            internal static extern void criAtomEx3dTransceiver_SetOutputPosition(IntPtr ex_3d_transceiver, ref CriAtomEx.NativeVector position);
            [PreserveSig]
            internal static extern void criAtomEx3dTransceiver_SetInputOrientation(IntPtr ex_3d_transceiver, ref CriAtomEx.NativeVector front, ref CriAtomEx.NativeVector top);
            [PreserveSig]
            internal static extern void criAtomEx3dTransceiver_SetOutputOrientation(IntPtr ex_3d_transceiver, ref CriAtomEx.NativeVector front, ref CriAtomEx.NativeVector top);
            [PreserveSig]
            internal static extern void criAtomEx3dTransceiver_SetOutputConeParameter(IntPtr ex_3d_transceiver, float inside_angle, float outside_angle, float outside_volume);
            [PreserveSig]
            internal static extern void criAtomEx3dTransceiver_SetOutputMinMaxAttenuationDistance(IntPtr ex_3d_transceiver, float min_attenuation_distance, float max_attenuation_distance);
            [PreserveSig]
            internal static extern void criAtomEx3dTransceiver_SetOutputInteriorPanField(IntPtr ex_3d_transceiver, float transceiver_radius, float interior_distance);
            [PreserveSig]
            internal static extern void criAtomEx3dTransceiver_SetInputCrossFadeField(IntPtr ex_3d_transceiver, float direct_audio_radius, float crossfade_distance);
            [PreserveSig]
            internal static extern void criAtomEx3dTransceiver_SetOutputVolume(IntPtr ex_3d_transceiver, float volume);
            [PreserveSig]
            internal static extern void criAtomEx3dTransceiver_AttachAisac(IntPtr ex_3d_transceiver, string global_aisac_name);
            [PreserveSig]
            internal static extern void criAtomEx3dTransceiver_DetachAisac(IntPtr ex_3d_transceiver, string global_aisac_name);
            [PreserveSig]
            internal static extern void criAtomEx3dTransceiver_SetMaxAngleAisacDelta(IntPtr ex_3d_transceiver, float max_delta);
            [PreserveSig]
            internal static extern void criAtomEx3dTransceiver_SetDistanceAisacControlId(IntPtr ex_3d_transceiver, ushort aisac_control_id);
            [PreserveSig]
            internal static extern void criAtomEx3dTransceiver_SetListenerBasedAzimuthAngleAisacControlId(IntPtr ex_3d_transceiver, ushort aisac_control_id);
            [PreserveSig]
            internal static extern void criAtomEx3dTransceiver_SetListenerBasedElevationAngleAisacControlId(IntPtr ex_3d_transceiver, ushort aisac_control_id);
            [PreserveSig]
            internal static extern void criAtomEx3dTransceiver_SetTransceiverOutputBasedAzimuthAngleAisacControlId(IntPtr ex_3d_transceiver, ushort aisac_control_id);
            [PreserveSig]
            internal static extern void criAtomEx3dTransceiver_SetTransceiverOutputBasedElevationAngleAisacControlId(IntPtr ex_3d_transceiver, ushort aisac_control_id);
            [PreserveSig]
            internal static extern void criAtomEx3dTransceiver_Set3dRegionHn(IntPtr ex_3d_transceiver, IntPtr ex_3d_region);
        }

        private IntPtr handle;
        public IntPtr nativeHandle
        {
            get
            {
                return default(IntPtr);
            }
        }

        public CriAtomEx3dTransceiver()
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

        public void SetInputPosition(Vector3 position)
        {
        }

        public void SetOutputPosition(Vector3 position)
        {
        }

        public void SetInputOrientation(Vector3 front, Vector3 top)
        {
        }

        public void SetOutputOrientation(Vector3 front, Vector3 top)
        {
        }

        public void SetOutputConeParameter(float insideAngle, float outsideAngle, float outsideVolume)
        {
        }

        public void SetOutputMinMaxDistance(float minDistance, float maxDistance)
        {
        }

        public void SetOutputInteriorPanField(float radius, float interiorDistance)
        {
        }

        public void SetInputCrossFadeField(float directAudioRadius, float crossfadeDistance)
        {
        }

        public void SetOutputVolume(float volume)
        {
        }

        public void AttachAisac(string globalAisacName)
        {
        }

        public void DetachAisac(string globalAisacName)
        {
        }

        public void SetMaxAngleAisacDelta(float maxDelta)
        {
        }

        public void SetDistanceAisacControlId(ushort aisacControlId)
        {
        }

        public void SetListenerBasedAzimuthAngleAisacControlId(ushort aisacControlId)
        {
        }

        public void SetListenerBasedElevationAngleAisacControlId(ushort aisacControlId)
        {
        }

        public void SetTransceiverOutputBasedAzimuthAngleAisacControlId(ushort aisacControlId)
        {
        }

        public void SetTransceiverOutputBasedElevationAngleAisacControlId(ushort aisacControlId)
        {
        }

        public void Set3dRegion(CriAtomEx3dRegion region3d)
        {
        }

        ~CriAtomEx3dTransceiver()
        {
        }
    }
}

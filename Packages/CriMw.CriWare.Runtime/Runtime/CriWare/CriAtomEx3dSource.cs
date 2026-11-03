namespace CriWare
{
    using global::System;
    using global::System.Runtime.InteropServices;
    using global::CriWare;
    using global::UnityEngine;

    public class CriAtomEx3dSource : CriDisposable
    {
        public struct Config
        {
            public bool enableVoicePriorityDecay;
            public uint randomPositionListMaxLength;
            public Config(bool enableVoicePriorityDecay, uint randomPositionListMaxLength)
            {
                this = default;
            }
        }

        private uint currentRandomPositionListMaxLength;
        private IntPtr handle;
        public IntPtr nativeHandle
        {
            get
            {
                return default(IntPtr);
            }
        }

        public CriAtomEx3dSource(bool enableVoicePriorityDecay = false, uint randomPositionListMaxLength = 0u)
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

        public void SetOrientation(Vector3 front, Vector3 top)
        {
        }

        [Obsolete("Use CriAtomEx3dSource.SetOrientation(Vector3, Vector3) instead")]
        public void SetConeOrientation(float x, float y, float z)
        {
        }

        public void SetConeParameter(float insideAngle, float outsideAngle, float outsideVolume)
        {
        }

        public void SetMinMaxDistance(float minDistance, float maxDistance)
        {
        }

        public void SetInteriorPanField(float sourceRadius, float interiorDistance)
        {
        }

        public void SetDopplerFactor(float dopplerFactor)
        {
        }

        public void SetVolume(float volume)
        {
        }

        public void SetMaxAngleAisacDelta(float maxDelta)
        {
        }

        public void SetAttenuationDistanceSetting(bool flag)
        {
        }

        public bool GetAttenuationDistanceSetting()
        {
            return default(bool);
        }

        public void SetRandomPositionConfig(CriAtomEx.Randomize3dConfig? config)
        {
        }

        public void SetRandomPositionList(Vector3[] positionList)
        {
        }

        public void Set3dRegion(CriAtomEx3dRegion region3d)
        {
        }

        public void SetListenerBasedElevationAngleAisacControlId(ushort aisacControlId)
        {
        }

        public void SetSourceBasedElevationAngleAisacControlId(ushort aisacControlId)
        {
        }

        public void SetDistanceAisacControlId(ushort aisacControlId)
        {
        }

        public bool IsDestroyable()
        {
            return default(bool);
        }

        public CriAtomEx.NativeVector GetPosition()
        {
            return default(CriAtomEx.NativeVector);
        }

        ~CriAtomEx3dSource()
        {
        }

        [PreserveSig]
        private static extern IntPtr criAtomEx3dSource_Create(ref Config config, IntPtr work, int work_size);
        [PreserveSig]
        private static extern void criAtomEx3dSource_Destroy(IntPtr ex_3d_source);
        [PreserveSig]
        private static extern void criAtomEx3dSource_Update(IntPtr ex_3d_source);
        [PreserveSig]
        private static extern void criAtomEx3dSource_ResetParameters(IntPtr ex_3d_source);
        [PreserveSig]
        private static extern void criAtomEx3dSource_SetPosition(IntPtr ex_3d_source, ref CriAtomEx.NativeVector position);
        [PreserveSig]
        private static extern void criAtomEx3dSource_SetVelocity(IntPtr ex_3d_source, ref CriAtomEx.NativeVector velocity);
        [PreserveSig]
        private static extern void criAtomEx3dSource_SetOrientation(IntPtr ex_3d_source, ref CriAtomEx.NativeVector front, ref CriAtomEx.NativeVector top);
        [PreserveSig]
        private static extern void criAtomEx3dSource_SetConeOrientation(IntPtr ex_3d_source, ref CriAtomEx.NativeVector cone_orient);
        [PreserveSig]
        private static extern void criAtomEx3dSource_SetConeParameter(IntPtr ex_3d_source, float inside_angle, float outside_angle, float outside_volume);
        [PreserveSig]
        private static extern void criAtomEx3dSource_SetMinMaxAttenuationDistance(IntPtr ex_3d_source, float min_distance, float max_distance);
        [PreserveSig]
        private static extern void criAtomEx3dSource_SetInteriorPanField(IntPtr ex_3d_source, float source_radius, float interior_distance);
        [PreserveSig]
        private static extern void criAtomEx3dSource_SetDopplerFactor(IntPtr ex_3d_source, float doppler_factor);
        [PreserveSig]
        private static extern void criAtomEx3dSource_SetVolume(IntPtr ex_3d_source, float volume);
        [PreserveSig]
        private static extern void criAtomEx3dSource_SetMaxAngleAisacDelta(IntPtr ex_3d_source, float max_delta);
        [PreserveSig]
        private static extern void criAtomEx3dSource_SetAttenuationDistanceSetting(IntPtr ex_3d_source, bool flag);
        [PreserveSig]
        private static extern bool criAtomEx3dSource_GetAttenuationDistanceSetting(IntPtr ex_3d_source);
        [PreserveSig]
        private static extern void criAtomEx3dSource_SetRandomPositionConfig(IntPtr ex_3d_source, ref CriAtomEx.Randomize3dConfig config);
        [PreserveSig]
        private static extern void criAtomEx3dSource_SetRandomPositionConfig(IntPtr ex_3d_source, IntPtr config);
        [PreserveSig]
        private static extern void criAtomEx3dSource_SetRandomPositionList(IntPtr ex_3d_source, CriAtomEx.NativeVector[] position_list, uint length);
        [PreserveSig]
        private static extern void criAtomEx3dSource_SetDistanceAisacControlId(IntPtr ex_3d_source, ushort aisac_control_id);
        [PreserveSig]
        private static extern bool criAtomEx3dSource_IsDestroyable(IntPtr ex_3d_source);
        [PreserveSig]
        private static extern CriAtomEx.NativeVector criAtomEx3dSource_GetPosition(IntPtr ex_3d_source);
        [PreserveSig]
        private static extern void criAtomEx3dSource_Set3dRegionHn(IntPtr ex_3d_source, IntPtr ex_3d_region);
        [PreserveSig]
        private static extern void criAtomEx3dSource_SetListenerBasedElevationAngleAisacControlId(IntPtr ex_3d_source, ushort aisac_control_id);
        [PreserveSig]
        private static extern void criAtomEx3dSource_SetSourceBasedElevationAngleAisacControlId(IntPtr ex_3d_source, ushort aisac_control_id);
    }
}

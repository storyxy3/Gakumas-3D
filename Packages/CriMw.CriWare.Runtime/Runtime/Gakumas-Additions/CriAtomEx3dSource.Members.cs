// Gakumas (CriWare 2.44.49) members missing from the PJSK port, copied from the DummyDll skeleton.
// TODO(qa-recon): bodies are skeleton placeholders until reconstructed from the game.
#pragma warning disable 0067, 0169, 0414, 0649
using AOT;
using System;
using UnityEngine.Scripting;
using UnityEngine;
using global::CriWare;
using global::System.Runtime.InteropServices;
using global::System;
using global::UnityEngine;

namespace CriWare
{
    public partial class CriAtomEx3dSource
    {


        public void ResetParameters()
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



        public void SetRandomPositionList(Vector3[] positionList)
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


        [PreserveSig]
        private static void criAtomEx3dSource_ResetParameters(IntPtr ex_3d_source) { throw new NotSupportedException("native criAtomEx3dSource_ResetParameters (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomEx3dSource_SetConeOrientation(IntPtr ex_3d_source, ref CriAtomEx.NativeVector cone_orient) { throw new NotSupportedException("native criAtomEx3dSource_SetConeOrientation (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomEx3dSource_SetConeParameter(IntPtr ex_3d_source, float inside_angle, float outside_angle, float outside_volume) { throw new NotSupportedException("native criAtomEx3dSource_SetConeParameter (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomEx3dSource_SetMinMaxAttenuationDistance(IntPtr ex_3d_source, float min_distance, float max_distance) { throw new NotSupportedException("native criAtomEx3dSource_SetMinMaxAttenuationDistance (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomEx3dSource_SetInteriorPanField(IntPtr ex_3d_source, float source_radius, float interior_distance) { throw new NotSupportedException("native criAtomEx3dSource_SetInteriorPanField (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomEx3dSource_SetDopplerFactor(IntPtr ex_3d_source, float doppler_factor) { throw new NotSupportedException("native criAtomEx3dSource_SetDopplerFactor (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomEx3dSource_SetVolume(IntPtr ex_3d_source, float volume) { throw new NotSupportedException("native criAtomEx3dSource_SetVolume (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomEx3dSource_SetMaxAngleAisacDelta(IntPtr ex_3d_source, float max_delta) { throw new NotSupportedException("native criAtomEx3dSource_SetMaxAngleAisacDelta (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomEx3dSource_SetAttenuationDistanceSetting(IntPtr ex_3d_source, bool flag) { throw new NotSupportedException("native criAtomEx3dSource_SetAttenuationDistanceSetting (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static bool criAtomEx3dSource_GetAttenuationDistanceSetting(IntPtr ex_3d_source) { throw new NotSupportedException("native criAtomEx3dSource_GetAttenuationDistanceSetting (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomEx3dSource_SetRandomPositionList(IntPtr ex_3d_source, CriAtomEx.NativeVector[] position_list, uint length) { throw new NotSupportedException("native criAtomEx3dSource_SetRandomPositionList (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomEx3dSource_SetDistanceAisacControlId(IntPtr ex_3d_source, ushort aisac_control_id) { throw new NotSupportedException("native criAtomEx3dSource_SetDistanceAisacControlId (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static bool criAtomEx3dSource_IsDestroyable(IntPtr ex_3d_source) { throw new NotSupportedException("native criAtomEx3dSource_IsDestroyable (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static CriAtomEx.NativeVector criAtomEx3dSource_GetPosition(IntPtr ex_3d_source) { throw new NotSupportedException("native criAtomEx3dSource_GetPosition (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomEx3dSource_SetListenerBasedElevationAngleAisacControlId(IntPtr ex_3d_source, ushort aisac_control_id) { throw new NotSupportedException("native criAtomEx3dSource_SetListenerBasedElevationAngleAisacControlId (game P/Invoke; not part of the managed port)"); }


        [PreserveSig]
        private static void criAtomEx3dSource_SetSourceBasedElevationAngleAisacControlId(IntPtr ex_3d_source, ushort aisac_control_id) { throw new NotSupportedException("native criAtomEx3dSource_SetSourceBasedElevationAngleAisacControlId (game P/Invoke; not part of the managed port)"); }
    }
}

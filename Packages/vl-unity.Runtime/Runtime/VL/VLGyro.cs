namespace VL
{
    using global::System;
    using global::System.Collections;
    using global::System.Collections.Generic;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::UnityEngine;
    using global::UnityEngine.XR;
    using global::VL;

    [Serializable]
    public class VLGyro : IDisposable
    {
        public enum UpdateType
        {
            Swipe,
            Gyro,
            Hybrid
        }

        public enum RotationAxes
        {
            XAndY,
            XOnly,
            YOnly
        }

        [CompilerGenerated]
        private sealed class _003CInitialize_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
        {
            private int _003C_003E1__state;
            private object _003C_003E2__current;
            public VLGyro _003C_003E4__this;
            object System.Collections.Generic.IEnumerator<System.Object>.Current
            {
                [DebuggerHidden]
                get
                {
                    return null;
                }
            }

            object System.Collections.IEnumerator.Current
            {
                [DebuggerHidden]
                get
                {
                    return null;
                }
            }

            [DebuggerHidden]
            public _003CInitialize_003Ed__41(int _003C_003E1__state)
            {
            }

            [DebuggerHidden]
            void System.IDisposable.Dispose()
            {
            }

            bool global::System.Collections.IEnumerator.MoveNext()
            {
                return default(bool);
            }

            [DebuggerHidden]
            void System.Collections.IEnumerator.Reset()
            {
            }
        }

        public ScreenOrientation orientation;
        [SerializeField]
        private UpdateType _updateType;
        public float lerpFactor;
        public RotationAxes axisType;
        public float axisXLimitAngle;
        public float axisYLimitAngle;
        public bool emulateMouseInEditor;
        [CompilerGenerated]
        private bool _003CgyroSupported_003Ek__BackingField;
        private bool _defaultGyroEnable;
        private Quaternion _rotation;
        private Quaternion _gestureRotation;
        private Quaternion _startRotation;
        private Quaternion _hybridInvRotation;
        private bool _initialized;
        private bool _firstUpdate;
        private float anxX;
        private float anxY;
        private float stopPosSec;
        private bool dragging;
        private int _fingerId;
        private Vector2 _prevPosition;
        protected float jestureMin;
        protected float rotationSpeedX;
        protected float rotationSpeedY;
        protected float anxCof;
        [SerializeField]
        protected float axisAmplification;
        [SerializeField]
        protected float axisAmplificationMouse;
        private InputDevice _androidDevice;
        private bool _isAndroidDeviceValid;
        private Quaternion gyroBaseRotation
        {
            get
            {
                return default(Quaternion);
            }
        }

        public bool gyroSupported
        {
            [CompilerGenerated]
            get
            {
                return _003CgyroSupported_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CgyroSupported_003Ek__BackingField = value;
            }
        }

        public Quaternion gyroRotationRaw
        {
            get
            {
                return default(Quaternion);
            }
        }

        public UpdateType updateType
        {
            get
            {
                return default(UpdateType);
            }
        }

        [IteratorStateMachine(typeof(_003CInitialize_003Ed__41))]
        public IEnumerator Initialize()
        {
            return null;
        }

        public void Dispose()
        {
        }

        public void ResetRotation()
        {
        }

        public void ResetHybridGyro()
        {
        }

        public VLGyro()
        {
        }
    }
}

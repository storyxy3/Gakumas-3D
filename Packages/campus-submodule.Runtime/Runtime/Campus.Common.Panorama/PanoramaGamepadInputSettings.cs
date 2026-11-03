namespace Campus.Common.Panorama
{
    using global::Campus.Common.Panorama;
    using global::UnityEngine;

    [CreateAssetMenu(fileName = "PanoramaGamepadInputSettings.asset", menuName = "Campus/Panorama/Gamepad Input Settings")]
    public class PanoramaGamepadInputSettings : ScriptableObject
    {
        private const string AssetName = "PanoramaGamepadInputSettings";
        private const string AssetPath = "Assets/Data/System/Panorama/PanoramaGamepadInputSettings.asset";
        private const string AssetGuid = "4d0eb41b17eb3734fbea60db4e20f854";
        private const string LogPrefix = "[PanoramaGamepadInputSettings]";
        private const string DefaultLeftStickXAxis = "GamepadLeftStickHorizontal";
        private const string DefaultLeftStickYAxis = "GamepadLeftStickVertical";
        private const string DefaultRightStickXAxis = "GamepadRightStickHorizontal";
        private const string DefaultRightStickYAxis = "GamepadRightStickVertical";
        private const string DefaultLeftTriggerInput = "GamepadLeftTrigger";
        private const string DefaultRightTriggerInput = "GamepadRightTrigger";
        private const string DefaultLeftShoulderInput = "JoystickButton4";
        private const string DefaultRightShoulderInput = "JoystickButton5";
        private static PanoramaGamepadInputSettings _current;
        private static PanoramaGamepadInputSettings _fallback;
        private static bool _fallbackLogged;
        private static bool _loadLogged;
        [Header("Input Mapping")]
        [SerializeField]
        private string _leftStickXAxis;
        [SerializeField]
        private string _leftStickYAxis;
        [SerializeField]
        private string _rightStickXAxis;
        [SerializeField]
        private string _rightStickYAxis;
        [SerializeField]
        private string _leftTriggerInput;
        [SerializeField]
        private string _rightTriggerInput;
        [SerializeField]
        private string _leftShoulderInput;
        [SerializeField]
        private string _rightShoulderInput;
        [Header("入力の遊び")]
        [SerializeField]
        [Tooltip("左スティックのデッドゾーン。絶対値がこの値未満の移動入力は0として扱います。")]
        private float _leftStickDeadzone;
        [SerializeField]
        [Tooltip("右スティックのデッドゾーン。絶対値がこの値未満の回転入力は0として扱います。")]
        private float _rightStickDeadzone;
        [SerializeField]
        [Tooltip("L2/R2トリガーのデッドゾーン。絶対値がこの値未満の高さ変更/ズーム入力は0として扱います。")]
        private float _triggerDeadzone;
        [Header("入力倍率")]
        [SerializeField]
        [Tooltip("左スティックによる水平移動の入力倍率。1で標準、値を大きくするとゲームパッドの移動だけ速くなります。")]
        private float _gamepadMoveInputScale;
        [SerializeField]
        [Tooltip("L1/L2による高さ変更の入力倍率。1で標準、値を大きくするとゲームパッドの上下移動だけ速くなります。")]
        private float _gamepadHeightInputScale;
        [Header("入力補正")]
        [SerializeField]
        [Tooltip("L1/L2による高さ変更入力のスムージング時間（秒）。0にすると補正なしで即時反映します。")]
        private float _gamepadHeightInputSmoothTime;
        [Header("速度")]
        [SerializeField]
        [Tooltip("右スティックによる回転速度。矢印キーの回転速度には影響しません。")]
        private float _cameraRotationInputSpeed;
        [SerializeField]
        private bool _cameraRotationInputInvertHorizontal;
        [SerializeField]
        private bool _cameraRotationInputInvertVertical;
        [SerializeField]
        [Tooltip("R1/R2によるズーム速度。Z/Xキーのズーム速度には影響しません。")]
        private float _zoomRatioInputSpeed;
        public static PanoramaGamepadInputSettings Current
        {
            get
            {
                return null;
            }
        }

        public string LeftStickXAxis
        {
            get
            {
                return null;
            }
        }

        public string LeftStickYAxis
        {
            get
            {
                return null;
            }
        }

        public string RightStickXAxis
        {
            get
            {
                return null;
            }
        }

        public string RightStickYAxis
        {
            get
            {
                return null;
            }
        }

        public string LeftTriggerInput
        {
            get
            {
                return null;
            }
        }

        public string RightTriggerInput
        {
            get
            {
                return null;
            }
        }

        public string LeftShoulderInput
        {
            get
            {
                return null;
            }
        }

        public string RightShoulderInput
        {
            get
            {
                return null;
            }
        }

        public float LeftStickDeadzone
        {
            get
            {
                return default(float);
            }
        }

        public float RightStickDeadzone
        {
            get
            {
                return default(float);
            }
        }

        public float TriggerDeadzone
        {
            get
            {
                return default(float);
            }
        }

        public float GamepadMoveInputScale
        {
            get
            {
                return default(float);
            }
        }

        public float GamepadHeightInputScale
        {
            get
            {
                return default(float);
            }
        }

        public float GamepadHeightInputSmoothTime
        {
            get
            {
                return default(float);
            }
        }

        public float CameraRotationInputSpeed
        {
            get
            {
                return default(float);
            }
        }

        public bool CameraRotationInputInvertHorizontal
        {
            get
            {
                return default(bool);
            }
        }

        public bool CameraRotationInputInvertVertical
        {
            get
            {
                return default(bool);
            }
        }

        public float ZoomRatioInputSpeed
        {
            get
            {
                return default(float);
            }
        }

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetCacheOnRuntimeStart()
        {
        }

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        private static void LoadOnRuntimeStart()
        {
        }

        private static void LogLoadedOnce(string source, PanoramaGamepadInputSettings settings)
        {
        }

        private static void LogLoaded(string source, PanoramaGamepadInputSettings settings)
        {
        }

        private static string GetAssetPathForLog(PanoramaGamepadInputSettings settings)
        {
            return null;
        }

        private static PanoramaGamepadInputSettings LoadAssetByGuid()
        {
            return null;
        }

        public PanoramaGamepadInputSettings()
        {
        }
    }
}

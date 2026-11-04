namespace VL
{
    using global::System;
    using global::Unity.Mathematics;
    using global::UnityEngine;
    using global::UnityEngine.Serialization;
    using global::VL;

    public class VLActorExpressionBone : MonoBehaviour
    {
        public enum AxisType
        {
            X,
            Y,
            Z
        }

        [Flags]
        public enum AxisMaskType
        {
            X = 1,
            Y = 2,
            Z = 4
        }

        public enum TransformType
        {
            POSITION,
            ROTATION,
            POSITION_DELTA
        }

        public enum CalcType
        {
            MUL,
            MUSCLE_CONVERT
        }

        [Serializable]
        public class AxisData
        {
            public float coefficient;
            public float min = -180;
            public float max = 180;
            public AxisType outputAxisType;
            public AxisData()
            {

            }
        }

        [FormerlySerializedAs("_target")]
        [SerializeField]
        private Transform _referenceBone;
        [SerializeField]
        private string _referenceActorBoneName;
        [SerializeField]
        private AxisType _axisType;
        [SerializeField]
        private TransformType _transformType;
        [SerializeField]
        private CalcType _calcType;
        [SerializeField]
        private float _coefficient;
        [SerializeField]
        private float _min = -180;
        [SerializeField]
        private float _max = 180;
        [SerializeField]
        private bool _useAxisMask;
        [SerializeField]
        private AxisMaskType _axisMask;
        [SerializeField]
        private AxisData[] _axisData = new AxisData[3];
        [SerializeField]
        private math.RotationOrder _rotationOrder;
        [SerializeField]
        private bool _useCustomOutput;
        [SerializeField]
        private AxisType _outputAxisType;
        [SerializeField]
        private TransformType _outputTransformType;
        [SerializeField]
        [TextArea]
        [Header("詳細な挙動を定義 (Lisp)")]
        private string _lispText;
        [HideInInspector]
        public float init;
        [SerializeField]
        private HumanPartDof _humanPartDof;
        [SerializeField]
        private ArmDof _armDof;
        [SerializeField]
        private int _muscleAxisType;
        public bool useCustomOutput
        {
            get
            {
                return default(bool);
            }

            set
            {
            }
        }

        public Transform referenceBone
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public string referenceActorBoneName
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public AxisType axisType
        {
            get
            {
                return default(AxisType);
            }

            set
            {
            }
        }

        public TransformType transformType
        {
            get
            {
                return default(TransformType);
            }

            set
            {
            }
        }

        public CalcType calcType
        {
            get
            {
                return default(CalcType);
            }

            set
            {
            }
        }

        public float coefficient
        {
            get
            {
                return default(float);
            }

            set
            {
            }
        }

        public float min
        {
            get
            {
                return default(float);
            }

            set
            {
            }
        }

        public float max
        {
            get
            {
                return default(float);
            }

            set
            {
            }
        }

        public math.RotationOrder rotationOrder
        {
            get
            {
                return default(math.RotationOrder);
            }

            set
            {
            }
        }

        public bool useAxisMask
        {
            get
            {
                return default(bool);
            }

            set
            {
            }
        }

        public AxisMaskType axisMask
        {
            get
            {
                return default(AxisMaskType);
            }

            set
            {
            }
        }

        public AxisData[] axisData
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public TransformType outputTransformType
        {
            get
            {
                return default(TransformType);
            }

            set
            {
            }
        }

        public string lispText
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public float3 finalCoefficient
        {
            get
            {
                return default(float3);
            }
        }

        public float3 finalMin
        {
            get
            {
                return default(float3);
            }
        }

        public float3 finalMax
        {
            get
            {
                return default(float3);
            }
        }

        public int3 finalAxisType
        {
            get
            {
                return default(int3);
            }
        }

        public short finalOutputTransformType
        {
            get
            {
                return default(short);
            }
        }

        public byte finalAxisMaskType
        {
            get
            {
                return default(byte);
            }
        }

        public HumanPartDof humanPartDof
        {
            get
            {
                return default(HumanPartDof);
            }

            set
            {
            }
        }

        public ArmDof armDof
        {
            get
            {
                return default(ArmDof);
            }

            set
            {
            }
        }

        public int muscleAxisType
        {
            get
            {
                return default(int);
            }

            set
            {
            }
        }

        public VLActorExpressionBone()
        {

        }
    }
}

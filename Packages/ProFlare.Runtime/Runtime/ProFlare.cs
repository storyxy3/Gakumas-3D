using global::System.Collections.Generic;
using global::UnityEngine;

[ExecuteInEditMode]
public class ProFlare : MonoBehaviour
{
    public ProFlareAtlas _Atlas;
    public bool EditingAtlas;
    public bool isVisible = true;
    public List<ProFlareElement> Elements = new List<ProFlareElement>();
    public Transform thisTransform;
    public GameObject thisGameObject;
    public Vector3 LensPosition;
    public bool EditGlobals;
    public float GlobalScale = 100;
    public bool MultiplyScaleByTransformScale;
    public float GlobalBrightness = 1;
    public Color GlobalTintColor = Color.white;
    public bool useMaxDistance = true;
    public bool useDistanceScale = true;
    public bool useDistanceFade = true;
    public float GlobalMaxDistance = 150;
    public bool UseAngleLimit;
    public float maxAngle = 90;
    public bool UseAngleScale;
    public bool UseAngleBrightness = true;
    public bool UseAngleCurve;
    public AnimationCurve AngleCurve = new AnimationCurve(new Keyframe(0, 0), new Keyframe(1, 1));
    public LayerMask mask = 1;
    public bool RaycastPhysics;
    public bool Occluded;
    public float OccludeScale = 1;
    public bool pixelBasedOcclusion;
    public LayerMask pixelLayerMask = -257;
    public float occlusionScaleSpeed = 4;
    public float occlusionBrightnessSpeed = 32;
    public float OffScreenFadeDist = 0.2f;
    public bool useDynamicEdgeBoost;
    public float DynamicEdgeBoost = 1;
    public float DynamicEdgeBrightness = 0.1f;
    public float DynamicEdgeRange = 0.3f;
    public float DynamicEdgeBias = -0.1f;
    public AnimationCurve DynamicEdgeCurve = new AnimationCurve(new Keyframe(0, 0), new Keyframe(0.5f, 1), new Keyframe(1, 0));
    public bool useDynamicCenterBoost;
    public float DynamicCenterBoost = 1;
    public float DynamicCenterBrightness = 0.2f;
    public float DynamicCenterRange = 0.3f;
    public float DynamicCenterBias;
    public bool neverCull;
    public bool sunMode;
    public Transform sunModeTransformA;
    public Transform sunModeTransformB;
    public ProFlareBatchForSRP flareBatchForSrp;
    private bool Initialised;
    public bool DisabledPlayMode;
    private void Awake()
    {
        Initialised = false;
        DisabledPlayMode = false;
        thisTransform = transform;
        thisGameObject = gameObject;
    }

    private void Start()
    {
        if (!Initialised) Init();
        for (int i = 0; i < Elements.Count; ++i)
        {
            Elements[i].flareAtlas = _Atlas;
            Elements[i].flare = this;
        }
        if (sunMode && (sunModeTransformA == null || sunModeTransformB == null)) setupSunMode();
    }

    private void PopulateFlareBatches()
    {
    }

    private void Init()
    {
        if (thisTransform == null) thisTransform = transform;
        if (_Atlas == null) return;
        if (flareBatchForSrp == null && Camera.main != null) Camera.main.TryGetComponent(out flareBatchForSrp);
        for (int i = 0; i < Elements.Count; ++i) Elements[i].flareAtlas = _Atlas;
        if (flareBatchForSrp != null)
        {
            flareBatchForSrp.AddFlare(this);
            Initialised = true;
        }
    }

    public void ReInitialise()
    {
        Initialised = false;
        Init();
    }

    private void OnEnable()
    {
        if (Application.isPlaying && DisabledPlayMode) DisabledPlayMode = false;
        if (!Initialised) Init();
    }

    private void OnDisable()
    {
        if (Application.isPlaying) DisabledPlayMode = true;
        if (flareBatchForSrp != null)
        {
            flareBatchForSrp.RemoveFlare(this);
            Initialised = false;
        }
    }

    public void setupSunMode()
    {
        sunModeTransformA = new GameObject(name + "_SunTransform_Pos").transform;
        sunModeTransformB = new GameObject(name + "_SunTransform_Rot").transform;
        sunModeTransformB.parent = sunModeTransformA;
        sunModeTransformB.localPosition = Vector3.back;
    }

    private void OnDestroy()
    {
        if (!sunMode) return;
        if (Application.isPlaying)
        {
            if (sunModeTransformA != null) Destroy(sunModeTransformA.gameObject);
            if (sunModeTransformB != null) Destroy(sunModeTransformB.gameObject);
        }
        else
        {
            if (sunModeTransformA != null) DestroyImmediate(sunModeTransformA.gameObject);
            if (sunModeTransformB != null) DestroyImmediate(sunModeTransformB.gameObject);
        }
    }

    public ProFlare()
    {
    }
}

using global::System.Collections.Generic;
using global::UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(MeshFilter))]
public class ProFlareBatch : MonoBehaviour
{
    public enum Mode
    {
        Standard,
        SingleCamera
    }

    public Shader linearShader;
    public Shader gammaShader;
    public bool debugMessages;
    public Mode mode;
    public ProFlareAtlas _atlas;
    public List<FlareData> FlaresList;
    public List<ProFlareElement> FlareElements;
    public ProFlareElement[] FlareElementsArray;
    public Camera GameCamera;
    public Transform GameCameraTrans;
    public Camera FlareCamera;
    public Transform FlareCameraTrans;
    public MeshFilter meshFilter;
    public Transform thisTransform;
    public MeshRenderer meshRender;
    public float zPos;
    private Mesh bufferMesh;
    private Mesh meshA;
    private Mesh meshB;
    private bool PingPong;
    public Material mat;
    private Vector3[] vertices;
    private Vector2[] uv;
    private Color32[] colors;
    private int[] triangles;
    public bool useBrightnessThreshold;
    public int BrightnessThreshold;
    public bool overdrawDebug;
    public bool dirty;
    public bool useCulling;
    public int cullFlaresAfterTime;
    public int cullFlaresAfterCount;
    public bool culledFlaresNowVisiable;
    private float reshowCulledFlaresTimer;
    public float reshowCulledFlaresAfter;
    public Transform helperTransform;
    public bool showAllConnectedFlares;
    public bool VR_Mode;
    public float VR_Depth;
    public bool SingleCamera_Mode;
    public bool linearColorSpace;
    private Vector3[] verts;
    private Vector2 _scale;
    private Color32 _color;
    private float PI_Div180;
    private float Div180_PI;
    private int visibleFlares;
    private void Reset()
    {
    }

    private void Awake()
    {
    }

    private void Start()
    {
    }

    private void CreateMat()
    {
    }

    public void SwitchCamera(Camera newCamera)
    {
    }

    private void OnDestroy()
    {
    }

    public void RemoveFlare(ProFlare _flare)
    {
    }

    public void AddFlare(ProFlare _flare)
    {
    }

    private void setupPixelBasedOcclusion(FlareOcclusion data, ProFlare flare)
    {
    }

    private void CreateHelperTransform()
    {
    }

    private void Update()
    {
    }

    private void LateUpdate()
    {
    }

    public void UpdateFlares()
    {
    }

    public void ForceRefresh()
    {
    }

    private void ReBuildGeometry()
    {
    }

    private void SetupMeshes()
    {
    }

    private void Update2()
    {
    }

    private void UpdateGeometry()
    {
    }

    public ProFlareBatch()
    {
    }
}

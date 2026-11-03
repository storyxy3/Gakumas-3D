using global::System;
using global::UnityEngine;

[Serializable]
public class FlarePixelOcclusion
{
    public RenderTexture renderTexture;
    public Texture2D texture2D;
    public Rect rect;
    public Color pixelColor;
    public Camera pixelCamera;
    public Transform pixelCameraTransform;
    public bool pixelOcclusionPingPong;
    public FlarePixelOcclusion()
    {
    }
}

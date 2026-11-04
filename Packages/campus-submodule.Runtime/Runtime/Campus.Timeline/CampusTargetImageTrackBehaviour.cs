namespace Campus.Timeline
{
    using global::UnityEngine.Playables;
    using global::UnityEngine;
    using global::UnityEngine.UI;

    public sealed class CampusTargetImageTrackBehaviour : PlayableBehaviour
    {
        private RawImage _rawImage;
        private bool _rawImageInitialStateEnabled;
        public override void OnPlayableDestroy(Playable playable)
        {
            if (_rawImage != null) _rawImage.enabled = _rawImageInitialStateEnabled;
        }

        public override void ProcessFrame(Playable playable, FrameData info, object playerData)
        {
            if (_rawImage == null)
            {
                _rawImage = playerData as RawImage;
                _rawImageInitialStateEnabled = _rawImage != null && _rawImage.enabled;
            }
            int count = playable.GetInputCount();
            if (_rawImage == null) return;
            Vector2 center = Vector2.zero;
            float alpha = 0f;
            float scale = 0f;
            bool active = false;
            for (int i = 0; i < count; i++)
            {
                float weight = playable.GetInputWeight(i);
                if (weight <= 0f) continue;
                var behaviour = ((ScriptPlayable<CampusTargetImageClipBehaviour>)playable.GetInput(i)).GetBehaviour();
                if (behaviour.trackingTarget != null && global::VL.VLCameraController.HasInstance)
                {
                    Vector2 viewport = global::VL.VLCameraController.Instance.mainCamera.WorldToViewportPoint(behaviour.trackingTarget.position);
                    center = (behaviour.center + (viewport - new Vector2(0.5f, 0.5f)) * 2f) * weight;
                }
                else center += behaviour.center * weight;
                alpha += weight * behaviour.alpha;
                scale += weight * behaviour.scale;
                active = true;
            }
            _rawImage.enabled = active;
            _rawImage.texture = active && global::VL.Rendering.VLSRPCameraController.HasInstance ? global::VL.Rendering.VLSRPCameraController.Instance.targetTexture : null;
            if (_rawImage.texture == null) return;
            _rawImage.color = new Color(1f, 1f, 1f, alpha);
            var rect = _rawImage.rectTransform.rect;
            int width = _rawImage.texture.width;
            int height = _rawImage.texture.height;
            if (rect.width <= 0f || rect.height <= 0f || width <= 0 || height <= 0) return;
            float uvWidth = Mathf.Min(rect.width / rect.height * ((float)height / width), 1f);
            float uvHeight = Mathf.Min(rect.height / rect.width * ((float)width / height), 1f);
            if (scale > 0.001f)
            {
                uvWidth /= scale;
                uvHeight /= scale;
            }
            uvWidth = Mathf.Min(uvWidth, 1f);
            uvHeight = Mathf.Min(uvHeight, 1f);
            float x = center.x * 0.5f + 0.5f;
            float y = center.y * 0.5f + 0.5f;
            float halfWidth = uvWidth * 0.5f;
            float halfHeight = uvHeight * 0.5f;
            if (x + halfWidth > 1f) x = 1f - halfWidth;
            else if (x - halfWidth < 0f) x = halfWidth;
            if (y + halfHeight > 1f) y = 1f - halfHeight;
            else if (y - halfHeight < 0f) y = halfHeight;
            _rawImage.uvRect = new Rect(x - halfWidth, y - halfHeight, uvWidth, uvHeight);
        }

        public CampusTargetImageTrackBehaviour()
        {
        }
    }
}

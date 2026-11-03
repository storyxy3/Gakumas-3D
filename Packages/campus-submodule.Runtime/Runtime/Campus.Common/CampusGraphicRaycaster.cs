namespace Campus.Common
{
    using global::System.Collections.Generic;
    using global::UnityEngine.EventSystems;
    using global::UnityEngine.UI;

    public class CampusGraphicRaycaster : GraphicRaycaster
    {
        private readonly List<RaycastResult> _raycastResults;
        public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
        {
        }

        public CampusGraphicRaycaster()
        {
        }
    }
}

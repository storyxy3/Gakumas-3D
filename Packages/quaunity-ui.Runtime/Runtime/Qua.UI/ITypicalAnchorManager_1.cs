namespace Qua.UI
{
    using global::Qua.UI;
    using global::UnityEngine;

    public interface ITypicalAnchorManager<TAnchorType>
    {
        RectTransform GetAnchorTarget(TAnchorType anchorType);
        void AddTypicalAnchor(TypicalAnchorBase typicalAnchor);
        void RemoveTypicalAnchor(TypicalAnchorBase typicalAnchor);
    }
}

namespace VL
{
    using global::ActorAnimation;
    using global::UnityEngine;
    using global::VL;

    public interface IVLActorController : IVLTransform
    {
        int index { get; }

        Bounds bounds { get; }

        void ResetModel();
        void ResetTime();
        void ApplyActorAnimationManagePropertyData(ActorAnimationManagePropertyData propertyData);
        Transform GetHumanBodyBoneTransform(HumanBodyBones hbb);
        Transform GetBoneTransformByName(string boneName);
        bool IsRendererActive();
        void SetRendererActive(bool active);
        bool TryGetComponent<T>(out T component);
    }
}

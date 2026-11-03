namespace VL
{
    using global::System.Collections.Generic;
    using global::UnityEngine;
    using global::VL;
    using global::VL.FaceSystem;

    public interface IVLActorTalk
    {
        float AdditiveScale { set; }

        bool AutoAdditiveDisabled { set; }

        bool Setup(VLActorTalkData data, VLActorFaceModel faceModel, List<SkinnedMeshRenderer> renderers);
    }
}

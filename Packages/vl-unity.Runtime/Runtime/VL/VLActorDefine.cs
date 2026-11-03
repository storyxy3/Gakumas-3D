namespace VL
{
    using global::System.Collections.Generic;
    using global::UnityEngine;
    using global::VL;

    public static class VLActorDefine
    {
        public static readonly string ROOT_BONE_NAME;
        public static readonly string MOVE_BONE_NAME;
        public static readonly string PARTS_ROOT_NAME;
        public static readonly string PARTS_BODY_NAME;
        public static readonly string PARTS_FACE_NAME;
        public static readonly string PARTS_HAIR_NAME;
        public static readonly Dictionary<VLActorBodyType, string> BodyTypeWord;
        private static readonly Dictionary<HumanBodyBones, VLActorBodyType> HumanBoneToBody;
        private static readonly Dictionary<string, HumanBodyBones> boneToAvatarMap;
        private static readonly Dictionary<HumanBodyBones, string> avatarMapToString;
        private static bool[] _requiredDescriptionFlags;
        public static string GetPartsId(string assetName, bool toLower = false)
        {
            return null;
        }

        public static string GetRootName(string assetName)
        {
            return null;
        }

        public static string GetConnectionName(Transform transform)
        {
            return null;
        }

        public static bool IsBone(Transform transform)
        {
            return default(bool);
        }

        public static VLActorBodyType GetBodyType(HumanBodyBones hbb)
        {
            return default(VLActorBodyType);
        }

        public static bool TryGetHumanBodyBone(string transformName, out HumanBodyBones type)
        {
            throw null;
        }

        public static string HumanBodyToString(HumanBodyBones type)
        {
            return null;
        }

        public static void ClearRequiredDescriptionFlags()
        {
        }

        public static void AddRequiredDescriptionFlag(HumanBodyBones hbb)
        {
        }

        public static bool IsValidHumanDescription()
        {
            return default(bool);
        }
    }
}

namespace VL
{
    using global::System.Collections.Generic;
    using global::UnityEngine;
    using global::VL;

    public static class VLActorDefine
    {
        public static readonly string ROOT_BONE_NAME = "Reference";
        public static readonly string MOVE_BONE_NAME = "Move";
        public static readonly string PARTS_ROOT_NAME = "Root_";
        public static readonly string PARTS_BODY_NAME = "body";
        public static readonly string PARTS_FACE_NAME = "face";
        public static readonly string PARTS_HAIR_NAME = "hair";
        public static readonly Dictionary<VLActorBodyType, string> BodyTypeWord = new Dictionary<VLActorBodyType, string>
        {
            { (VLActorBodyType)0, "" },
            { (VLActorBodyType)1, "頭" },
            { (VLActorBodyType)2, "体" },
            { (VLActorBodyType)3, "腕" },
            { (VLActorBodyType)4, "胸" },
            { (VLActorBodyType)5, "手" },
            { (VLActorBodyType)6, "脚" }
        };
        private static readonly Dictionary<HumanBodyBones, VLActorBodyType> HumanBoneToBody = new Dictionary<HumanBodyBones, VLActorBodyType>
        {
            { (HumanBodyBones)9, (VLActorBodyType)1 },
            { (HumanBodyBones)10, (VLActorBodyType)1 },
            { (HumanBodyBones)14, (VLActorBodyType)3 },
            { (HumanBodyBones)16, (VLActorBodyType)3 },
            { (HumanBodyBones)13, (VLActorBodyType)3 },
            { (HumanBodyBones)15, (VLActorBodyType)3 },
            { (HumanBodyBones)18, (VLActorBodyType)5 },
            { (HumanBodyBones)17, (VLActorBodyType)5 },
            { (HumanBodyBones)2, (VLActorBodyType)6 },
            { (HumanBodyBones)4, (VLActorBodyType)6 },
            { (HumanBodyBones)1, (VLActorBodyType)6 },
            { (HumanBodyBones)3, (VLActorBodyType)6 },
            { (HumanBodyBones)8, (VLActorBodyType)4 },
            { (HumanBodyBones)7, (VLActorBodyType)2 },
            { (HumanBodyBones)0, (VLActorBodyType)2 }
        };
        private static readonly Dictionary<string, HumanBodyBones> boneToAvatarMap = new Dictionary<string, HumanBodyBones>
        {
            { "Hips", (HumanBodyBones)0 },
            { "Spine", (HumanBodyBones)7 },
            { "Spine1", (HumanBodyBones)8 },
            { "Spine2", (HumanBodyBones)54 },
            { "LeftShoulder", (HumanBodyBones)11 },
            { "LeftArm", (HumanBodyBones)13 },
            { "LeftForeArm", (HumanBodyBones)15 },
            { "LeftHand", (HumanBodyBones)17 },
            { "RightShoulder", (HumanBodyBones)12 },
            { "RightArm", (HumanBodyBones)14 },
            { "RightForeArm", (HumanBodyBones)16 },
            { "RightHand", (HumanBodyBones)18 },
            { "LeftUpLeg", (HumanBodyBones)1 },
            { "LeftLeg", (HumanBodyBones)3 },
            { "LeftFoot", (HumanBodyBones)5 },
            { "LeftToeBase", (HumanBodyBones)19 },
            { "RightUpLeg", (HumanBodyBones)2 },
            { "RightLeg", (HumanBodyBones)4 },
            { "RightFoot", (HumanBodyBones)6 },
            { "RightToeBase", (HumanBodyBones)20 },
            { "Neck", (HumanBodyBones)9 },
            { "Head", (HumanBodyBones)10 },
            { "LeftEye", (HumanBodyBones)21 },
            { "RightEye", (HumanBodyBones)22 },
            { "Mouth", (HumanBodyBones)23 },
            { "LeftHandThumb1", (HumanBodyBones)24 },
            { "LeftHandThumb2", (HumanBodyBones)25 },
            { "LeftHandThumb3", (HumanBodyBones)26 },
            { "LeftHandIndex1", (HumanBodyBones)27 },
            { "LeftHandIndex2", (HumanBodyBones)28 },
            { "LeftHandIndex3", (HumanBodyBones)29 },
            { "LeftHandMiddle1", (HumanBodyBones)30 },
            { "LeftHandMiddle2", (HumanBodyBones)31 },
            { "LeftHandMiddle3", (HumanBodyBones)32 },
            { "LeftHandRing1", (HumanBodyBones)33 },
            { "LeftHandRing2", (HumanBodyBones)34 },
            { "LeftHandRing3", (HumanBodyBones)35 },
            { "LeftHandPinky1", (HumanBodyBones)36 },
            { "LeftHandPinky2", (HumanBodyBones)37 },
            { "LeftHandPinky3", (HumanBodyBones)38 },
            { "RightHandThumb1", (HumanBodyBones)39 },
            { "RightHandThumb2", (HumanBodyBones)40 },
            { "RightHandThumb3", (HumanBodyBones)41 },
            { "RightHandIndex1", (HumanBodyBones)42 },
            { "RightHandIndex2", (HumanBodyBones)43 },
            { "RightHandIndex3", (HumanBodyBones)44 },
            { "RightHandMiddle1", (HumanBodyBones)45 },
            { "RightHandMiddle2", (HumanBodyBones)46 },
            { "RightHandMiddle3", (HumanBodyBones)47 },
            { "RightHandRing1", (HumanBodyBones)48 },
            { "RightHandRing2", (HumanBodyBones)49 },
            { "RightHandRing3", (HumanBodyBones)50 },
            { "RightHandPinky1", (HumanBodyBones)51 },
            { "RightHandPinky2", (HumanBodyBones)52 },
            { "RightHandPinky3", (HumanBodyBones)53 }
        };
        private static readonly Dictionary<HumanBodyBones, string> avatarMapToString = new Dictionary<HumanBodyBones, string>
        {
            { (HumanBodyBones)0, "Hips" },
            { (HumanBodyBones)7, "Spine" },
            { (HumanBodyBones)8, "Chest" },
            { (HumanBodyBones)54, "UpperChest" },
            { (HumanBodyBones)11, "LeftShoulder" },
            { (HumanBodyBones)13, "LeftUpperArm" },
            { (HumanBodyBones)15, "LeftLowerArm" },
            { (HumanBodyBones)17, "LeftHand" },
            { (HumanBodyBones)12, "RightShoulder" },
            { (HumanBodyBones)14, "RightUpperArm" },
            { (HumanBodyBones)16, "RightLowerArm" },
            { (HumanBodyBones)18, "RightHand" },
            { (HumanBodyBones)1, "LeftUpperLeg" },
            { (HumanBodyBones)3, "LeftLowerLeg" },
            { (HumanBodyBones)5, "LeftFoot" },
            { (HumanBodyBones)19, "LeftToes" },
            { (HumanBodyBones)2, "RightUpperLeg" },
            { (HumanBodyBones)4, "RightLowerLeg" },
            { (HumanBodyBones)6, "RightFoot" },
            { (HumanBodyBones)20, "RightToes" },
            { (HumanBodyBones)9, "Neck" },
            { (HumanBodyBones)10, "Head" },
            { (HumanBodyBones)21, "LeftEye" },
            { (HumanBodyBones)22, "RightEye" },
            { (HumanBodyBones)23, "Jaw" },
            { (HumanBodyBones)24, "Left Thumb Proximal" },
            { (HumanBodyBones)25, "Left Thumb Intermediate" },
            { (HumanBodyBones)26, "Left Thumb Distal" },
            { (HumanBodyBones)27, "Left Index Proximal" },
            { (HumanBodyBones)28, "Left Index Intermediate" },
            { (HumanBodyBones)29, "Left Index Distal" },
            { (HumanBodyBones)30, "Left Middle Proximal" },
            { (HumanBodyBones)31, "Left Middle Intermediate" },
            { (HumanBodyBones)32, "Left Middle Distal" },
            { (HumanBodyBones)33, "Left Ring Proximal" },
            { (HumanBodyBones)34, "Left Ring Intermediate" },
            { (HumanBodyBones)35, "Left Ring Distal" },
            { (HumanBodyBones)36, "Left Little Proximal" },
            { (HumanBodyBones)37, "Left Little Intermediate" },
            { (HumanBodyBones)38, "Left Little Distal" },
            { (HumanBodyBones)39, "Right Thumb Proximal" },
            { (HumanBodyBones)40, "Right Thumb Intermediate" },
            { (HumanBodyBones)41, "Right Thumb Distal" },
            { (HumanBodyBones)42, "Right Index Proximal" },
            { (HumanBodyBones)43, "Right Index Intermediate" },
            { (HumanBodyBones)44, "Right Index Distal" },
            { (HumanBodyBones)45, "Right Middle Proximal" },
            { (HumanBodyBones)46, "Right Middle Intermediate" },
            { (HumanBodyBones)47, "Right Middle Distal" },
            { (HumanBodyBones)48, "Right Ring Proximal" },
            { (HumanBodyBones)49, "Right Ring Intermediate" },
            { (HumanBodyBones)50, "Right Ring Distal" },
            { (HumanBodyBones)51, "Right Little Proximal" },
            { (HumanBodyBones)52, "Right Little Intermediate" },
            { (HumanBodyBones)53, "Right Little Distal" }
        };
        private static bool[] _requiredDescriptionFlags;
        public static string GetPartsId(string assetName, bool toLower = false)
        {
            int separator = assetName.LastIndexOf('_');
            if (separator + 1 < 2) return assetName;
            if (toLower) return assetName.Substring(separator + 1);
            return char.ToUpper(assetName[separator + 1]).ToString() + assetName.Substring(separator + 2);
        }

        public static string GetRootName(string assetName)
        {
            return PARTS_ROOT_NAME + GetPartsId(assetName);
        }

        public static string GetConnectionName(Transform transform)
        {
            string name = transform.name;
            int separator = name.LastIndexOf('_');
            return separator < 1 ? name : name.Substring(0, separator);
        }

        public static bool IsBone(Transform transform)
        {
            return !transform.TryGetComponent<Renderer>(out _);
        }

        public static VLActorBodyType GetBodyType(HumanBodyBones hbb)
        {
            HumanBoneToBody.TryGetValue(hbb, out var type);
            return type;
        }

        public static bool TryGetHumanBodyBone(string transformName, out HumanBodyBones type)
        {
            type = default;
            return boneToAvatarMap.TryGetValue(transformName, out type);
        }

        public static string HumanBodyToString(HumanBodyBones type)
        {
            string name = "";
            avatarMapToString.TryGetValue(type, out name);
            return name;
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

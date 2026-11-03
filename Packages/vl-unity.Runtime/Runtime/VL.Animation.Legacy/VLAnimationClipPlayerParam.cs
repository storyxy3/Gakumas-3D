namespace VL.Animation.Legacy
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::UnityEngine;
    using global::VL;
    using global::VL.Animation.Legacy;

    [Serializable]
    public class VLAnimationClipPlayerParam
    {
        [Serializable]
        public class LayerParam
        {
            public string layerName;
            public bool isAdditive;
            public AvatarMask mask;
            public LayerParam()
            {
            }
        }

        [SerializeField]
        private List<VLAnimationClipParam> _clips;
        [CompilerGenerated]
        private bool _003CisLoop_003Ek__BackingField;
        private string _layerName;
        [CompilerGenerated]
        private VLAnimationClipPlayerParamEvent _003ConComplete_003Ek__BackingField;
        public int clipCount
        {
            get
            {
                return default(int);
            }
        }

        public VLAnimationClipPlayerParamEvent onComplete
        {
            [CompilerGenerated]
            get
            {
                return null;
            }
        }

        public VLAnimationClipParam GetClip(int index)
        {
            return null;
        }

        public VLAnimationClipPlayerParam()
        {
        }

        public VLAnimationClipPlayerParam(params MotionDefine[] param)
        {
        }

        public float GetActualClipLength(int index)
        {
            return default(float);
        }

        private MotionDefine GetMotionDefine(int index)
        {
            return null;
        }

        public LayerParam GetLayerParam()
        {
            return null;
        }

        public override string ToString()
        {
            return null;
        }
    }
}

namespace Campus.Gasha.Sequences
{
    using global::Campus.Gasha.Sequences;
    using global::Cinemachine;
    using global::UnityEngine;

    public class LightListSequenceParam
    {
        public CinemachineBrain cinemachineBrain;
        public Camera uiCamera;
        public LightParam[] lightParams;
        public int LightCount
        {
            get
            {
                return default(int);
            }
        }

        public LightListSequenceParam()
        {
        }
    }
}

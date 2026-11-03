namespace Campus.Gasha
{
    using global::System.Collections.Generic;
    using global::Campus.Gasha;
    using global::JetBrains.Annotations;
    using global::VL;

    public class GashaActorMotionModel
    {
        public Dictionary<string, ActorMotionDefine> motionDefines;
        [CanBeNull]
        public ActorMotionDefine GetMotionDefine([CanBeNull] string characterId)
        {
            return null;
        }

        public static GashaActorMotionModel CreateFromTimelineController(GashaTimelineController timelineController)
        {
            return null;
        }

        public GashaActorMotionModel()
        {
        }
    }
}

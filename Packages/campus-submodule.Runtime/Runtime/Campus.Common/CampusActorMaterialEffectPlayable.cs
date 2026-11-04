namespace Campus.Common
{
    using global::Campus.Common;
    using global::UnityEngine.Playables;

    public class CampusActorMaterialEffectPlayable : PlayableBehaviour
    {
        public bool isSubTrack;
        public CampusActorController actorController;
        public CampusActorMaterialProperty overrideProperty;
        public bool isTimeline;
        public override void OnPlayableDestroy(Playable playable)
        {
            if (actorController == null || overrideProperty == null) return;
            actorController.RemoveOverrideMaterialProperty(overrideProperty.materialName);
        }

        public override void OnBehaviourPause(Playable playable, FrameData info)
        {
            if (isTimeline && info.effectivePlayState == PlayState.Paused) OverrideMaterialProperty(playable, info);
        }

        public override void PrepareFrame(Playable playable, FrameData info)
        {
            OverrideMaterialProperty(playable, info);
        }

        private void OverrideMaterialProperty(Playable playable, FrameData info)
        {
            if (actorController == null || overrideProperty == null) return;
            if (info.weight > 0f)
            {
                overrideProperty.CurrentTime = playable.GetTime();
                actorController.SetOverrideMaterialProperty(overrideProperty.materialName, overrideProperty);
            }
            else if (!isSubTrack) actorController.RemoveOverrideMaterialProperty(overrideProperty.materialName);
        }

        public CampusActorMaterialEffectPlayable()
        {
        }
    }
}

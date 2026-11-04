namespace ActorAnimation
{
    using global::ActorAnimation;
    using global::UnityEngine;
    using global::UnityEngine.Animations.Rigging;

    public class ActorAnimationJobBinder<TJob, TData> : AnimationJobBinder<TJob, TData> where TJob : struct, IActorAnimationJob where TData : struct, IActorAnimationRigData
    {
        public override TJob Create(Animator animator, ref TData data, Component component)
        {
            data.Sort();
            var job = new TJob();
            job.Create(animator, ref data);
            return job;
        }

        public override void Update(TJob job, ref TData data)
        {
            job.UpdateRigData(ref data);
        }

        public override void Destroy(TJob job)
        {
            job.Destroy();
        }

        public ActorAnimationJobBinder()
        {
        }
    }
}

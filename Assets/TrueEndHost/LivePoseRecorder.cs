using System;
using System.IO;
using System.Linq;
using ActorAnimation;
using Campus.Common;
using UnityEngine;

namespace TrueEnd.Host
{
    // Optional host telemetry: copies completed playback state without evaluating or modifying the graph.
    internal sealed class LivePoseRecorder : IDisposable
    {
        [Serializable] private sealed class Pose
        {
            public string name;
            public Vector3 position, localPosition, scale;
            public Quaternion rotation, localRotation;
            public Pose(Transform t)
            {
                name = t.name; position = t.position; rotation = t.rotation;
                localPosition = t.localPosition; localRotation = t.localRotation; scale = t.lossyScale;
            }
        }
        [Serializable] private sealed class Dynamic
        {
            public string name;
            public int parent, child, depth, hits;
            public bool active;
            public float length, rootWeight;
            public ActorSwingAffineTransform self, local, parentTx;
            public ActorSwingJobCollider collider;
            public ActorSwingJobLimitInfo limit;
        }
        [Serializable] private sealed class Static
        {
            public string name;
            public ActorSwingJobCollider collider;
        }
        [Serializable] private sealed class Frame
        {
            public double time;
            public float deltaTime;
            public Pose root, move;
            public Pose[] transforms;
            public Dynamic[] dynamics;
            public Static[] statics;
            public ActorSwingJobChainBone[] chains;
        }
        private readonly CampusActorAnimationRig rig;
        private readonly StreamWriter writer;
        private readonly Transform[] transforms;
        private double nextTime;

        public LivePoseRecorder(CampusActorController actor, string path)
        {
            rig = actor.GetComponent<CampusActorAnimationRig>();
            transforms = actor.GetComponentsInChildren<Transform>(true)
                .Where(t => t.name.Contains("Skirt") || t.name.Contains("UpLeg") ||
                    t.name == "LeftLeg" || t.name == "RightLeg" || t.name == "Hips").ToArray();
            Directory.CreateDirectory(Path.GetDirectoryName(path));
            writer = new StreamWriter(path);
            Debug.Log($"LIVE_POSE_LOG {path}");
        }

        public void Record(double time)
        {
            if (time < nextTime || !(rig.job is CampusActorAnimationJob job)) return;
            nextTime = time + 0.099;
            var skeleton = job.swingJobSkeleton;
            var data = rig.data;
            var frame = new Frame
            {
                time = time, deltaTime = Time.deltaTime,
                root = new Pose(data.root), move = new Pose(data.move),
                transforms = transforms.Select(t => new Pose(t)).ToArray(),
                dynamics = new Dynamic[skeleton.dynamicBones.Length],
                statics = new Static[skeleton.staticBones.Length],
                chains = new ActorSwingJobChainBone[skeleton.chainBones.Length]
            };
            for (int i = 0; i < frame.dynamics.Length; i++)
            {
                var bone = skeleton.dynamicBones[i];
                frame.dynamics[i] = new Dynamic
                {
                    name = data.swingDynamicBones[i].name, parent = bone.parentIndex, child = bone.childIndex,
                    depth = bone.depth, hits = bone.collision.hitCheckCount, active = bone.active,
                    length = bone.boneLength, rootWeight = bone.rootWeight, self = bone.selfTx,
                    local = bone.localTx, parentTx = bone.parentTx, collider = bone.collider, limit = bone.limit
                };
            }
            for (int i = 0; i < frame.statics.Length; i++)
                frame.statics[i] = new Static { name = data.swingStaticBones[i].name, collider = skeleton.staticBones[i].collider };
            for (int i = 0; i < frame.chains.Length; i++) frame.chains[i] = skeleton.chainBones[i];
            writer.WriteLine(JsonUtility.ToJson(frame));
            writer.Flush();
        }

        public void Dispose() => writer.Dispose();
    }
}

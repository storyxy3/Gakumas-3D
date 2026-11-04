namespace ActorAnimation
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::ActorAnimation;
    using global::Unity.Collections;
    using global::Unity.Collections.LowLevel.Unsafe;
    using global::UnityEngine;
    using global::Unity.Mathematics;
    using global::UnityEngine.Animations;
    using global::UnityEngine.Animations.Rigging;

    [Serializable]
    public struct ActorAnimationSwingJobSkeleton
    {
        [CompilerGenerated]
        private FloatProperty _003CjobWeight_003Ek__BackingField;
        [CompilerGenerated]
        private ReadOnlyTransformHandle _003CrootHandle_003Ek__BackingField;
        [CompilerGenerated]
        private ReadOnlyTransformHandle _003ChipsHandle_003Ek__BackingField;
        [CompilerGenerated]
        private ReadOnlyTransformHandle _003CheightCorrectionBoneHandle_003Ek__BackingField;
        public NativeList<ActorSwingJobDynamicBone> dynamicBones;
        public NativeList<ActorSwingJobStaticBone> staticBones;
        public NativeList<ActorSwingJobBreastBone> breastBones;
        public ActorSwingJobBreastBoneCurve breastBoneCurve;
        public NativeList<ActorSwingJobChainBone> chainBones;
        public NativeHashMap<int, int> instanceIDToDynamicBoneIndex;
        [CompilerGenerated]
        private ActorSwingJobSeatDynamicCorrection _003CseatedDynamicCorrection_003Ek__BackingField;
        [CompilerGenerated]
        private ActorAnimationManageProperty _003CmanageProperty_003Ek__BackingField;
        public bool isCmmnHeightCorrectionNeeded;
        private float _time;
        public ReadOnlyTransformHandle rootHandle
        {
            [CompilerGenerated]
            readonly get
            {
                return _003CrootHandle_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CrootHandle_003Ek__BackingField = value;
            }
        }

        public ReadOnlyTransformHandle hipsHandle
        {
            [CompilerGenerated]
            readonly get
            {
                return _003ChipsHandle_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003ChipsHandle_003Ek__BackingField = value;
            }
        }

        public ReadOnlyTransformHandle heightCorrectionBoneHandle
        {
            [CompilerGenerated]
            readonly get
            {
                return _003CheightCorrectionBoneHandle_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CheightCorrectionBoneHandle_003Ek__BackingField = value;
            }
        }

        public ActorSwingJobSeatDynamicCorrection seatedDynamicCorrection
        {
            [CompilerGenerated]
            readonly get
            {
                return _003CseatedDynamicCorrection_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CseatedDynamicCorrection_003Ek__BackingField = value;
            }
        }

        public ActorAnimationManageProperty manageProperty
        {
            [CompilerGenerated]
            readonly get
            {
                return _003CmanageProperty_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CmanageProperty_003Ek__BackingField = value;
            }
        }

        public void Execute(AnimationStream stream)
        {
            ProcessAnimation(stream);
        }

        public void ProcessAnimation(AnimationStream stream)
        {
            _time += stream.deltaTime;
            var data = manageProperty.Get(stream);
            var rootTx = ActorSwingAffineTransform.identity;
            if (rootHandle.IsValid(stream))
            {
                rootHandle.GetGlobalTR(stream, out var position, out var rotation);
                rootTx.Set(position, rotation);
            }
            var hipsTx = ActorSwingAffineTransform.identity;
            if (hipsHandle.IsValid(stream))
            {
                hipsHandle.GetLocalTRS(stream, out var position, out var rotation, out var scale);
                hipsTx.Set(position, rotation);
            }
            float3 origin = float3.zero;
            float heightScale = 1f;
            if (isCmmnHeightCorrectionNeeded && heightCorrectionBoneHandle.IsValid(stream))
            {
                heightScale = heightCorrectionBoneHandle.GetLocalScale(stream).x;
                origin = heightCorrectionBoneHandle.GetPosition(stream);
            }
            ProcessStaticBones(stream, ref data, rootTx, hipsTx, origin, heightScale);
            ProcessBreastBones(stream, ref data, rootTx, hipsTx);
            ProcessDynamicBones(stream, ref data, rootTx, hipsTx, origin, heightScale);
        }

        private void ProcessStaticBones(AnimationStream stream, ref ActorAnimationManagePropertyData managePropertyData, ActorSwingAffineTransform rootTx, ActorSwingAffineTransform hipsTx, float3 heightCorrectionBonePosition, float heightCorrectionBoneScale)
        {
            if (!staticBones.IsCreated) return;
            unsafe
            {
                var bone = (ActorSwingJobStaticBone*)staticBones.GetUnsafeReadOnlyPtr();
                var inverseRoot = rootTx.Inverse();
                for (int i = 0; i < staticBones.Length; i++, bone++)
                {
                    bone->driven.GetGlobalTR(stream, out var position, out var rotation);
                    var self = inverseRoot * new ActorSwingAffineTransform(position, rotation);
                    if (isCmmnHeightCorrectionNeeded)
                        self.translation = ScalePositionVector(self.translation, heightCorrectionBonePosition, 1f / heightCorrectionBoneScale);
                    float3 parentPosition = self.translation;
                    if (bone->parent.IsValid(stream))
                    {
                        bone->parent.GetGlobalTR(stream, out var parentWorldPosition, out var parentWorldRotation);
                        var parent = inverseRoot * new ActorSwingAffineTransform(parentWorldPosition, parentWorldRotation);
                        parentPosition = parent.translation;
                        if (isCmmnHeightCorrectionNeeded)
                            parentPosition = ScalePositionVector(parentPosition, heightCorrectionBonePosition, 1f / heightCorrectionBoneScale);
                    }
                    if (isCmmnHeightCorrectionNeeded) ScaleCollider(ref bone->collider, 1f / heightCorrectionBoneScale);
                    ActorSwingColliderUtility.UpdateCollider(ref bone->collider, self.translation, parentPosition, self.rotation);
                }
            }
        }

        private void ProcessBreastBones(AnimationStream stream, ref ActorAnimationManagePropertyData managePropertyData, ActorSwingAffineTransform rootTx, ActorSwingAffineTransform hipsTx)
        {
            if (!breastBones.IsCreated) return;
            unsafe
            {
                var bone = (ActorSwingJobBreastBone*)breastBones.GetUnsafeReadOnlyPtr();
                float modelingWeight = managePropertyData.modelingPoseWeight;
                float weight = managePropertyData.weight;
                float power = managePropertyData.swingBreastPowerWeight;
                float correctionPower = managePropertyData.swingBreastCorrectionPowerWeight;
                _ = stream.deltaTime;
                var inverseRoot = rootTx.Inverse();
                float3 cancel = ActorSwingUtility.GetRootCorrectionCancelPosition(hipsTx.translation, managePropertyData.rootWeight,
                    managePropertyData.rootHorizontalWeight, managePropertyData.rootVerticalWeight, bone->rootWeight, bone->rootWeight);
                for (int i = 0; i < breastBones.Length; i++, bone++)
                {
                    float damping = AnimationRuntimeUtils.Square(1f - bone->damping);
                    float spring = bone->spring;
                    float stiffness = bone->stiffness;
                    float pendulum = bone->pendulum;
                    float pendulumRange = bone->pendulumRange;
                    bool armCorrection = bone->useArmCorrection;
                    bone->driven.GetGlobalTR(stream, out var parentPosition, out var parentRotation);
                    var parent = inverseRoot * new ActorSwingAffineTransform(parentPosition, parentRotation);
                    parent.translation -= cancel;
                    bone->leftBreastSetting.breast.GetGlobalTR(stream, out var leftPosition, out var leftRotation);
                    var left = inverseRoot * new ActorSwingAffineTransform(leftPosition, leftRotation);
                    left.translation -= cancel;
                    bone->rightBreastSetting.breast.GetGlobalTR(stream, out var rightPosition, out var rightRotation);
                    var right = inverseRoot * new ActorSwingAffineTransform(rightPosition, rightRotation);
                    right.translation -= cancel;
                    float3 leftArm = inverseRoot * (float3)bone->leftBreastSetting.lowerArm.GetPosition(stream);
                    float3 rightArm = inverseRoot * (float3)bone->rightBreastSetting.lowerArm.GetPosition(stream);
                    int prewarm = bone->prewarmCount;
                    float remaining = 0.01667f;
                    if (prewarm >= 1)
                    {
                        bone->prewarmCount = 0;
                        remaining = prewarm * 0.5f * 0.01667f;
                    }
                    float divisor = math.min(math.ceil(remaining / 0.01667f), 3f);
                    bool isLeft = true;
                    while (remaining > 0f)
                    {
                        var target = isLeft ? left : right;
                        var setting = isLeft ? &bone->leftBreastSetting : &bone->rightBreastSetting;
                        float3 arm = isLeft ? leftArm : rightArm;
                        if (prewarm >= 1)
                        {
                            spring = 0f;
                            if (remaining.Equals(prewarm * 0.01667f * 0.5f))
                            {
                                target.rotation = (parent * setting->initialSelfTx.rotation).rotation;
                                setting->selfEndTx.translation = (target * setting->localEndTx).translation;
                            }
                        }
                        var endDefault = target * setting->localEndTx;
                        float3 force = float3.zero;
                        force += damping * (endDefault.translation - setting->selfEndTx.translation);
                        quaternion defaultRotation = target.rotation;
                        float step = math.min(remaining, 0.01667f) * 40f;
                        force += CalcStiffnessPendulum(DynamicType.Swing, setting->boneEndAxis, setting->boneEndLength,
                            target, setting->selfEndTx, endDefault, stiffness, pendulum, pendulumRange);
                        force += spring * setting->childSpeed;
                        if (armCorrection)
                        {
                            float3 armDirection = math.rotate(parent.Inverse().rotation, arm - cancel - parent.translation);
                            float up = AnimationCurveEvaluator.Evaluate(armDirection.y / math.length(armDirection), ref breastBoneCurve.upCurveData,
                                (KeyframeData*)breastBoneCurve.upKeyFrames.GetUnsafeReadOnlyPtr());
                            float3 localArm = parent.Inverse() * (arm - cancel);
                            float3 breastDirection = math.rotate(math.mul(parent.Inverse().rotation, defaultRotation), setting->localEndTx.translation);
                            force += math.rotate(defaultRotation, new float3(0f, 1f, 0f) * up) / divisor * correctionPower;
                            float angle = math.acos(math.dot(localArm, breastDirection) / (math.length(localArm) * math.length(breastDirection)));
                            angle = math.clamp(angle, 0f, 2.3f);
                            float side = AnimationCurveEvaluator.Evaluate(angle, ref breastBoneCurve.sideCurveData,
                                (KeyframeData*)breastBoneCurve.sideKeyFrames.GetUnsafeReadOnlyPtr());
                            force += math.rotate(defaultRotation, new float3(0f, 0f, isLeft ? 1f : -1f) * side) / divisor * correctionPower;
                        }
                        float3 delta = force * step * power;
                        setting->selfEndTx.translation += delta;
                        target.rotation = math.mul(ActorSwingUtility.FromToRotation(math.rotate(defaultRotation, setting->boneEndAxis),
                            setting->selfEndTx.translation - target.translation), defaultRotation);
                        setting->childSpeed = delta;
                        setting->selfEndTx.translation = ActorSwingUtility.UpdateSpringPosition(target.translation, setting->selfEndTx.translation, setting->boneEndLength);
                        ProcessBreastBoneLayer(weight, bone->limit, defaultRotation, ref target);
                        if (isLeft) left = target;
                        else
                        {
                            right = target;
                            quaternion originalLeft = left.rotation;
                            quaternion originalRight = right.rotation;
                            left.rotation = math.slerp(originalLeft, originalRight, bone->average);
                            right.rotation = math.slerp(originalRight, originalLeft, bone->average);
                            remaining -= 0.01667f;
                        }
                        isLeft = !isLeft;
                    }
                    if (modelingWeight >= 0.00001f)
                    {
                        var localLeft = parent.Inverse() * left;
                        bone->leftBreastSetting.breast.SetLocalRotation(stream, math.slerp(localLeft.rotation, bone->leftBreastSetting.modelingLocalTx.rotation, modelingWeight));
                        var localRight = parent.Inverse() * right;
                        bone->rightBreastSetting.breast.SetLocalRotation(stream, math.slerp(localRight.rotation, bone->rightBreastSetting.modelingLocalTx.rotation, modelingWeight));
                    }
                    else
                    {
                        bone->leftBreastSetting.breast.SetRotation(stream, (rootTx * left).rotation);
                        bone->rightBreastSetting.breast.SetRotation(stream, (rootTx * right).rotation);
                    }
                }
            }
        }

        private void ProcessBreastBoneLayer(float weight, ActorSwingJobLimitInfo limit, quaternion pDynamicDefaultRotation, ref ActorSwingAffineTransform targetBreastTx)
        {
            if (limit.useLimit == 1)
            {
                quaternion localRotation = math.mul(math.inverse(pDynamicDefaultRotation), targetBreastTx.rotation);
                float3 euler = ActorSwingUtility.ToUnityEuler(localRotation);
                euler = math.clamp(euler, limit.negative, limit.positive);
                targetBreastTx.rotation = math.mul(pDynamicDefaultRotation, ActorSwingUtility.ToUnityQuaternion(euler));
            }
            targetBreastTx.rotation = math.slerp(pDynamicDefaultRotation, targetBreastTx.rotation, weight);
        }

        private void ProcessDynamicBones(AnimationStream stream, ref ActorAnimationManagePropertyData managePropertyData, ActorSwingAffineTransform rootTx, ActorSwingAffineTransform hipsTx, float3 heightCorrectionBonePosition, float heightCorrectionBoneScale)
        {
            if (!dynamicBones.IsCreated) return;
            float power = managePropertyData.swingPowerWeight;
            float weight = managePropertyData.weight;
            float modelingWeight = managePropertyData.modelingPoseWeight;
            _ = stream.deltaTime;
            unsafe
            {
                var head = (ActorSwingJobDynamicBone*)dynamicBones.GetUnsafeReadOnlyPtr();
                var chainHead = (ActorSwingJobChainBone*)chainBones.GetUnsafeReadOnlyPtr();
                int chainStart = 0;
                int depth = head->depth;
                var inverseRoot = rootTx.Inverse();
                float inverseScale = 1f / heightCorrectionBoneScale;
                if (isCmmnHeightCorrectionNeeded)
                    for (int i = 0; i < chainBones.Length; i++) chainHead[i].initialLoopLength *= inverseScale;
                int layerStart = 0;
                var bone = head;
                for (int i = 0; i < dynamicBones.Length; i++, bone++)
                {
                    if (depth != bone->depth)
                    {
                        ProcessDynamicBoneLayer(head, layerStart, i - layerStart, weight, chainHead, ref chainStart,
                            ref managePropertyData, hipsTx, heightCorrectionBoneScale, seatedDynamicCorrection.enableSeatedDynamicCorrection);
                        depth = bone->depth;
                        layerStart = i;
                    }
                    if (bone->childIndex < 0) continue;
                    quaternion oldRotation = bone->selfTx.rotation;
                    float3 cancel = ActorSwingUtility.GetRootCorrectionCancelPosition(hipsTx.translation, managePropertyData.rootWeight,
                        managePropertyData.rootHorizontalWeight, managePropertyData.rootVerticalWeight, bone->rootWeight, bone->rootWeight);
                    if (bone->parentIndex < 0)
                    {
                        if (bone->parent.IsValid(stream))
                        {
                            bone->parent.GetGlobalTR(stream, out var position, out var rotation);
                            bone->selfTx.Set(new ActorSwingAffineTransform(position, rotation) * bone->localTx);
                        }
                        else
                        {
                            bone->driven.GetGlobalTR(stream, out var position, out var rotation);
                            bone->selfTx.Set(position, rotation);
                        }
                        bone->selfTx = inverseRoot * bone->selfTx;
                        bone->selfTx.translation -= cancel;
                        bone->parentTx = bone->selfTx;
                        if (isCmmnHeightCorrectionNeeded)
                            bone->selfTx.translation = ScalePositionVector(bone->selfTx.translation, heightCorrectionBonePosition, inverseScale);
                    }
                    else bone->parentTx = head[bone->parentIndex].selfTx * bone->localTx;
                    var self = bone->selfTx;
                    var child = head + bone->childIndex;
                    if (isCmmnHeightCorrectionNeeded)
                        child->selfTx.translation = ScalePositionVector(child->selfTx.translation, heightCorrectionBonePosition, inverseScale);
                    var childTx = child->selfTx;
                    var childDefault = self * child->localTx;
                    float damping = AnimationRuntimeUtils.Square(1f - child->damping);
                    float stiffness = child->stiffness;
                    float spring = child->spring;
                    float pendulum = child->pendulum;
                    float pendulumRange = child->pendulumRange;
                    float mass = child->mass;
                    float axisY = child->axisAddXToY;
                    float axisZ = child->axisAddXToZ;
                    float wind = child->wind;
                    bone->defaultRotation = self.rotation;
                    if (!bone->active)
                    {
                        childTx.translation = childDefault.translation;
                        bone->childSpeed = default;
                        child->selfTx = childTx;
                        bone->selfTx = self;
                        continue;
                    }
                    int prewarm = bone->prewarmCount;
                    float remaining = 0.01667f;
                    if (prewarm >= 1)
                    {
                        bone->prewarmCount = 0;
                        bone->childSpeed = default;
                        childTx.translation = childDefault.translation;
                        remaining = prewarm * 0.5f * 0.01667f;
                        spring = 0f;
                        axisY = axisZ = 0f;
                    }
                    while (remaining > 0f)
                    {
                        float step = math.min(remaining, 0.01667f) * 40f;
                        float3 force = damping * (childDefault.translation - childTx.translation);
                        force += CalcStiffnessPendulum(child->dynamicType, child->boneAxis, child->boneLength, self, childTx, childDefault, stiffness, pendulum, pendulumRange);
                        force.y -= mass * 0.01f;
                        if (bone->useWindGlobalForce)
                            force += math.rotate(inverseRoot.rotation, wind * ActorAnimationWindUtility.CalcWindPower(self.translation, ref managePropertyData, _time));
                        float3 velocity = force + spring * bone->childSpeed;
                        if (bone->dynamicType == DynamicType.Slide)
                        {
                            velocity = math.rotate(math.inverse(oldRotation), velocity);
                            velocity.y += axisY * (math.sign(velocity.y) * math.abs(velocity.x));
                            velocity.z += axisZ * (math.sign(velocity.z) * math.abs(velocity.x));
                            velocity = math.rotate(oldRotation, velocity);
                        }
                        float3 delta = power * (step * velocity);
                        childTx.translation += delta;
                        if (seatedDynamicCorrection.enableSeatedDynamicCorrection && bone->seatDynamicCorrection > 0.00001f)
                            childTx.translation = math.lerp(childTx.translation,
                                ProcessChainBoneSeatedDynamicCorrection(stream, self, childDefault, childTx, inverseRoot, cancel), bone->seatDynamicCorrection);
                        if (child->dynamicType == DynamicType.Swing)
                            self.rotation = math.mul(ActorSwingUtility.FromToRotation(math.rotate(self.rotation, child->boneAxis), childTx.translation - self.translation), bone->defaultRotation);
                        bone->childSpeed = delta;
                        remaining -= 0.01667f;
                        if (prewarm == 0 && remaining > 0f) continue;
                        if (child->dynamicType == DynamicType.Swing)
                            childTx.translation = ActorSwingUtility.UpdateSpringPosition(self.translation, childTx.translation, child->boneLength);
                        float3 collisionCancel = cancel;
                        if (isCmmnHeightCorrectionNeeded)
                        {
                            ScaleCollider(ref child->collider, inverseScale);
                            collisionCancel *= inverseScale;
                        }
                        self.translation += collisionCancel;
                        childTx.translation += collisionCancel;
                        ActorSwingColliderUtility.UpdateCollider(ref child->collider, childTx.translation, self.translation, self.rotation);
                        ActorSwingCollisionUtility.CheckDynamicCollision(staticBones, child, seatedDynamicCorrection.enableSeatedDynamicCorrection, ref self, ref childTx);
                        self.translation -= collisionCancel;
                        childTx.translation -= collisionCancel;
                        if (isCmmnHeightCorrectionNeeded) ScaleCollider(ref child->collider, heightCorrectionBoneScale);
                        child->selfTx = childTx;
                        bone->selfTx = self;
                        if (prewarm >= 1)
                        {
                            bone->EnqueueCachedTransform(child->selfTx);
                            if (bone->IsAlreadyStable()) break;
                        }
                    }
                }
                ProcessDynamicBoneLayer(head, layerStart, dynamicBones.Length - layerStart, weight, chainHead, ref chainStart,
                    ref managePropertyData, hipsTx, heightCorrectionBoneScale, seatedDynamicCorrection.enableSeatedDynamicCorrection);
                if (isCmmnHeightCorrectionNeeded)
                {
                    chainHead = (ActorSwingJobChainBone*)chainBones.GetUnsafeReadOnlyPtr();
                    for (int i = 0; i < chainBones.Length; i++) chainHead[i].initialLoopLength *= heightCorrectionBoneScale;
                    var statics = (ActorSwingJobStaticBone*)staticBones.GetUnsafeReadOnlyPtr();
                    for (int i = 0; i < staticBones.Length; i++) ScaleCollider(ref statics[i].collider, heightCorrectionBoneScale);
                }
                bone = head;
                for (int i = 0; i < dynamicBones.Length; i++, bone++)
                {
                    if (!bone->active || bone->childIndex < 0) continue;
                    var child = head + bone->childIndex;
                    if (isCmmnHeightCorrectionNeeded)
                    {
                        if (bone->parentIndex < 0)
                            bone->selfTx.translation = ScalePositionVector(bone->selfTx.translation, heightCorrectionBonePosition, heightCorrectionBoneScale);
                        child->selfTx.translation = ScalePositionVector(child->selfTx.translation, heightCorrectionBonePosition, heightCorrectionBoneScale);
                    }
                    if (child->dynamicType != DynamicType.Swing)
                    {
                        var childTx = child->selfTx;
                        childTx.translation += ActorSwingUtility.GetRootCorrectionCancelPosition(hipsTx.translation, managePropertyData.rootWeight,
                            managePropertyData.rootHorizontalWeight, managePropertyData.rootVerticalWeight, bone->rootWeight, bone->rootWeight);
                        var world = rootTx * childTx;
                        child->driven.SetPosition(stream, world.translation);
                        if (modelingWeight > 0.00001f)
                            child->driven.SetLocalPosition(stream, math.lerp((float3)child->driven.GetLocalPosition(stream), child->modelingLocalTx.translation, modelingWeight));
                    }
                    else
                    {
                        var world = rootTx * bone->selfTx;
                        bone->driven.SetRotation(stream, world.rotation);
                        if (modelingWeight > 0.00001f)
                            bone->driven.SetLocalRotation(stream, math.slerp(bone->driven.GetLocalRotation(stream), bone->modelingLocalTx.rotation, modelingWeight));
                    }
                }
            }
        }

        private unsafe void ProcessChainBone(ActorSwingJobChainBone* pChainHead, ActorSwingJobDynamicBone* pDynamicHead, int depth, ref int chainStartIndex, ref ActorAnimationManagePropertyData managePropertyData, ActorSwingAffineTransform hipsTx, float heightCorrectionBoneScale, bool enableSeatedDynamicCorrection)
        {
            int next = ProcessChainBoneCollider(pChainHead, pDynamicHead, depth, chainStartIndex, ref managePropertyData,
                hipsTx, heightCorrectionBoneScale, enableSeatedDynamicCorrection);
            if (ProcessChainBoneSmoothing(pChainHead, pDynamicHead, depth, chainStartIndex, ref managePropertyData, hipsTx))
                next = ProcessChainBoneCollider(pChainHead, pDynamicHead, depth, chainStartIndex, ref managePropertyData,
                    hipsTx, heightCorrectionBoneScale, enableSeatedDynamicCorrection);
            chainStartIndex = next;
        }

        private unsafe int ProcessChainBoneCollider(ActorSwingJobChainBone* pChainHead, ActorSwingJobDynamicBone* pDynamicHead, int depth, int chainStartIndex, ref ActorAnimationManagePropertyData managePropertyData, ActorSwingAffineTransform hipsTx, float heightCorrectionBoneScale, bool enableSeatedDynamicCorrection)
        {
            var chain = pChainHead + chainStartIndex;
            if (chain->depth != depth) return chainStartIndex;
            float inverseScale = 1f / heightCorrectionBoneScale;
            for (int i = chainStartIndex; i < chainBones.Length; i++, chain++)
            {
                if (chain->depth != depth) return i;
                var bone = pDynamicHead + chain->dynamicBoneIndex;
                if (!bone->active) continue;
                var subBone = pDynamicHead + chain->dynamicBoneIndex + chain->chainOffsetIndex;
                if (!subBone->active) continue;
                var self = bone->selfTx;
                var sub = subBone->selfTx;
                float3 cancel = ActorSwingUtility.GetRootCorrectionCancelPosition(hipsTx.translation, managePropertyData.rootWeight,
                    managePropertyData.rootHorizontalWeight, managePropertyData.rootVerticalWeight, bone->rootWeight, bone->rootWeight);
                float3 subCancel = ActorSwingUtility.GetRootCorrectionCancelPosition(hipsTx.translation, managePropertyData.rootWeight,
                    managePropertyData.rootHorizontalWeight, managePropertyData.rootVerticalWeight, subBone->rootWeight, subBone->rootWeight);
                if (isCmmnHeightCorrectionNeeded)
                {
                    ScaleCollider(ref chain->collider, inverseScale);
                    cancel *= inverseScale;
                    subCancel *= inverseScale;
                }
                self.translation += cancel;
                sub.translation += subCancel;
                ActorSwingColliderUtility.UpdateCollider(ref chain->collider, self.translation, sub.translation, self.rotation);
                ActorSwingCollisionUtility.CheckChainCollision(staticBones, chain, ref self, ref sub, pDynamicHead, bone, subBone,
                    ref managePropertyData, hipsTx, enableSeatedDynamicCorrection, isCmmnHeightCorrectionNeeded, inverseScale);
                self.translation -= cancel;
                sub.translation -= subCancel;
                if (isCmmnHeightCorrectionNeeded) ScaleCollider(ref chain->collider, heightCorrectionBoneScale);
                bone->selfTx = self;
                subBone->selfTx = sub;
                if (i + 1 == chainBones.Length) return chainBones.Length;
            }
            return chainStartIndex;
        }

        private unsafe bool ProcessChainBoneSmoothing(ActorSwingJobChainBone* pChainHead, ActorSwingJobDynamicBone* pDynamicHead, int depth, int chainStartIndex, ref ActorAnimationManagePropertyData managePropertyData, ActorSwingAffineTransform hipsTx)
        {
            var first = pChainHead + chainStartIndex;
            if (first->depth != depth || !first->around || !(first->smoothing >= 0.00001f)) return false;
            var positions = new NativeList<float3>(16, Allocator.Temp);
            var smoothed = new NativeList<float3>(16, Allocator.Temp);
            var chain = first;
            for (int i = chainStartIndex; i < chainBones.Length; i++)
            {
                var bone = pDynamicHead + chain->dynamicBoneIndex;
                // The APK advances the chain pointer only for an active entry.
                if (!bone->active) continue;
                positions.Add(bone->selfTx.translation);
                if (chain[1].depth != depth)
                {
                    if (!chain->around)
                    {
                        var sub = pDynamicHead + chain->dynamicBoneIndex + chain->chainOffsetIndex;
                        if (sub->active) positions.Add(sub->selfTx.translation);
                    }
                    break;
                }
                chain++;
            }
            for (int i = 0; i < positions.Length; i++)
            {
                int previous = i != 0 ? i - 1 : first->around ? positions.Length - 1 : 1;
                int next = i + 1;
                if (next >= positions.Length) next = first->around ? 0 : previous;
                Vector3 current = positions[i];
                Vector3 before = positions[previous];
                Vector3 after = positions[next];
                smoothed.Add(current + first->smoothing * ((before - current + (after - current)) * 0.5f));
            }
            float loopLength = ActorAnimationSwingSkeletonCalcUtility.GetChainLoopLength(smoothed, first->around);
            if (loopLength < first->initialLoopLength)
            {
                float3 center = float3.zero;
                for (int i = 0; i < smoothed.Length; i++) center += smoothed[i];
                center /= smoothed.Length;
                float scale = first->initialLoopLength / loopLength;
                for (int i = 0; i < smoothed.Length; i++) smoothed[i] = center + (smoothed[i] - center) * scale;
            }
            chain = first;
            for (int i = 0; chainStartIndex + i < chainBones.Length; i++)
            {
                if (chain->collision.hitCheckCount != 0)
                {
                    int next = i + 1;
                    if (next >= positions.Length) next = chain->around ? 0 : i;
                    smoothed[next] = positions[next];
                    smoothed[i] = positions[i];
                }
                chain++;
                if (chain->depth != depth) break;
            }
            chain = first;
            for (int i = 0; chainStartIndex + i < chainBones.Length; i++)
            {
                var bone = pDynamicHead + chain->dynamicBoneIndex;
                bone->selfTx.translation = smoothed[i];
                if (chain[1].depth != depth)
                {
                    if (!chain->around)
                        pDynamicHead[chain->dynamicBoneIndex + chain->chainOffsetIndex].selfTx.translation = smoothed[i + 1];
                    break;
                }
                chain++;
            }
            positions.Dispose();
            smoothed.Dispose();
            return true;
        }

        private float3 ProcessChainBoneSeatedDynamicCorrection(AnimationStream stream, ActorSwingAffineTransform selfTx, ActorSwingAffineTransform childDefaultTx, ActorSwingAffineTransform childTx, ActorSwingAffineTransform invRootTx, float3 cancelRootPosition)
        {
            Vector3 leftUpLeg = seatedDynamicCorrection.leftUpLeg.GetPosition(stream);
            Vector3 rightUpLeg = seatedDynamicCorrection.rightUpLeg.GetPosition(stream);
            Vector3 leftLeg = seatedDynamicCorrection.leftLeg.GetPosition(stream);
            Vector3 rightLeg = seatedDynamicCorrection.rightLeg.GetPosition(stream);
            Vector3 leftFoot = seatedDynamicCorrection.leftFoot.GetPosition(stream);
            Vector3 rightFoot = seatedDynamicCorrection.rightFoot.GetPosition(stream);
            Vector3 hips = invRootTx * (float3)((leftUpLeg + rightUpLeg) * 0.5f) - cancelRootPosition;
            Vector3 knee = invRootTx * (float3)((leftLeg + rightLeg) * 0.5f) - cancelRootPosition;
            Vector3 foot = invRootTx * (float3)((leftFoot + rightFoot) * 0.5f) - cancelRootPosition;
            float thighLength = math.length(new float2(knee.x - hips.x, knee.z - hips.z));
            float selfDistance = math.length(new float2(selfTx.translation.x - hips.x, selfTx.translation.z - hips.z));
            float3 result = childTx.translation;
            if (childDefaultTx.translation.y < knee.y)
            {
                float a = math.length(new float2(childDefaultTx.translation.x - hips.x, childDefaultTx.translation.z - hips.z));
                float b = math.length(new float2(childDefaultTx.translation.x - knee.x, childDefaultTx.translation.z - knee.z));
                float blend = a / (a + b);
                float3 target = math.lerp(selfTx.translation + (float3)(knee - hips), selfTx.translation + (float3)(foot - knee), blend * blend);
                if (selfTx.translation.y < knee.y && childDefaultTx.translation.y < knee.y) result = target;
                else if (selfTx.translation.y >= knee.y && childDefaultTx.translation.y < knee.y)
                {
                    float crossing = math.abs((knee.y - childDefaultTx.translation.y) / (selfTx.translation.y - childDefaultTx.translation.y));
                    result = math.lerp(result, target, crossing);
                }
            }
            if (thighLength < selfDistance)
            {
                float blend = math.min(selfDistance - thighLength, thighLength * 0.25f) / (thighLength * 0.25f);
                result = math.lerp(result, selfTx.translation + (float3)(foot - knee), blend);
            }
            return result;
        }

        private unsafe void ProcessDynamicBoneLayer(ActorSwingJobDynamicBone* pDynamicHead, int startIndex, int length, float weight, ActorSwingJobChainBone* pChainHead, ref int chainStartIndex, ref ActorAnimationManagePropertyData managePropertyData, ActorSwingAffineTransform hipsTx, float heightCorrectionBoneScale, bool enableSeatedDynamicCorrection)
        {
            var bone = pDynamicHead + startIndex;
            if (chainStartIndex < chainBones.Length)
                ProcessChainBone(pChainHead, pDynamicHead, bone->depth + 1, ref chainStartIndex,
                    ref managePropertyData, hipsTx, heightCorrectionBoneScale, enableSeatedDynamicCorrection);
            for (int i = 0; i < length; i++, bone++)
            {
                if (bone->childIndex < 0 || !bone->active) continue;
                var child = pDynamicHead + bone->childIndex;
                if (child->dynamicType != DynamicType.Swing)
                    child->selfTx = CalcDynamicSlide(bone, child, weight);
                else
                {
                    var self = CalcDynamicSwing(pDynamicHead, bone, weight);
                    child->selfTx = self * child->localTx;
                    bone->selfTx = self;
                }
            }
        }

        private unsafe ActorSwingAffineTransform CalcDynamicSwing(ActorSwingJobDynamicBone* pDynamicHead, ActorSwingJobDynamicBone* pDynamic, float weight)
        {
            var child = pDynamicHead + pDynamic->childIndex;
            var self = pDynamic->selfTx;
            quaternion rotation = math.mul(ActorSwingUtility.FromToRotation(math.rotate(self.rotation, child->boneAxis),
                child->selfTx.translation - self.translation), self.rotation);
            if (pDynamic->limit.useLimit == 1)
            {
                float3 euler = ActorSwingUtility.ToUnityEuler(math.mul(math.inverse(pDynamic->parentTx.rotation), rotation));
                if (!seatedDynamicCorrection.enableSeatedDynamicCorrection || pDynamic->seatDynamicCorrection < 0.00001f)
                    euler = math.clamp(euler, pDynamic->limit.negative, pDynamic->limit.positive);
                rotation = math.mul(pDynamic->parentTx.rotation, ActorSwingUtility.ToUnityQuaternion(euler));
                if (pDynamic->referenceLimit.boneIndex >= 0)
                {
                    euler = ActorSwingUtility.ToUnityEuler(rotation);
                    float3 reference = ActorSwingUtility.ToUnityEuler(pDynamicHead[pDynamic->referenceLimit.boneIndex].selfTx.rotation);
                    if (pDynamic->referenceLimit.max.x) euler.x = math.min(euler.x, reference.x);
                    if (pDynamic->referenceLimit.max.y) euler.y = math.min(euler.y, reference.y);
                    if (pDynamic->referenceLimit.max.z) euler.z = math.min(euler.z, reference.z);
                    if (pDynamic->referenceLimit.min.x) euler.x = math.max(euler.x, reference.x);
                    if (pDynamic->referenceLimit.min.y) euler.y = math.max(euler.y, reference.y);
                    if (pDynamic->referenceLimit.min.z) euler.z = math.max(euler.z, reference.z);
                    rotation = ActorSwingUtility.ToUnityQuaternion(euler);
                }
            }
            return new ActorSwingAffineTransform(self.translation, math.slerp(pDynamic->defaultRotation, rotation, weight));
        }

        private unsafe ActorSwingAffineTransform CalcDynamicSlide(ActorSwingJobDynamicBone* pDynamic, ActorSwingJobDynamicBone* pChildDynamic, float weight)
        {
            var local = pDynamic->selfTx.Inverse() * pChildDynamic->selfTx;
            float3 initial = pChildDynamic->localTx.translation;
            if (pChildDynamic->limit.useLimit == 1)
                local.translation = initial + math.clamp(local.translation - initial, pChildDynamic->limit.negative * 0.001f, pChildDynamic->limit.positive * 0.001f);
            local.translation = math.lerp(initial, local.translation, weight);
            return pDynamic->selfTx * local;
        }

        private float3 CalcStiffnessPendulum(DynamicType dynamicType, float3 boneAxis, float boneLength, ActorSwingAffineTransform selfTx, ActorSwingAffineTransform childTx, ActorSwingAffineTransform childDefaultTx, float stiffness, float pendulum, float pendulumRange)
        {
            if (dynamicType == DynamicType.Swing)
            {
                float3 direction = math.rotate(selfTx.rotation, boneAxis);
                float correction = 0f;
                if (pendulum > 0.00001f && pendulumRange > 0.00001f)
                {
                    float cosine = math.abs(math.dot(childTx.translation, childDefaultTx.translation))
                        / (math.length(childTx.translation) * math.length(childDefaultTx.translation));
                    correction = (1f / pendulumRange) * math.max(cosine - (1f - pendulumRange), 0f) * pendulum;
                }
                return direction * (stiffness - correction);
            }
            else
            {
                float3 difference = selfTx * (boneAxis * boneLength) - childTx.translation;
                float correction = 0f;
                if (pendulum > 0.00001f && pendulumRange > 0.00001f)
                {
                    float distance = math.min(math.length(childDefaultTx.translation - childTx.translation) * 10f, pendulumRange);
                    correction = (1f - distance / pendulumRange) * pendulum;
                }
                return difference * (stiffness - correction);
            }
        }

        private float ScaleScalar(float scalar, float scale)
        {
            return scalar * scale;
        }

        private float3 ScaleDirectionVector(float3 direction, float scale)
        {
            return direction * scale;
        }

        private float3 ScalePositionVector(float3 position, float3 origin, float scale)
        {
            return origin + (position - origin) * scale;
        }

        private void ScaleCollider(ref ActorSwingJobCollider jobCollider, float scale)
        {
            switch (jobCollider.type)
            {
                case ActorSwingColliderType.Sphere:
                    jobCollider.float_A *= scale;
                    jobCollider.float3_A *= scale;
                    break;
                case ActorSwingColliderType.Capsule:
                    jobCollider.float3_A *= scale;
                    jobCollider.float_A *= scale;
                    jobCollider.float_B *= scale;
                    jobCollider.float3_B *= scale;
                    break;
                case ActorSwingColliderType.Line:
                    jobCollider.float_A *= scale;
                    jobCollider.float_B *= scale;
                    jobCollider.float3_A *= scale;
                    break;
            }
        }

        public void ResetTime()
        {
            _time = 0f;
        }
    }
}

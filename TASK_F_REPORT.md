# Task F — True End rendering libraries

The supplied live-method census is reconstructed or retained where the existing
body already matches the APK. **Native parity remains incomplete: 632 same /
36 [layout] / 37 [semantic] / 0 not done**, over **705 distinct method names**.
There are no missing selected names or re-signed overloads. Every selected APK
signature has a matching rebuilt signature; none of these results depends on the
comparator skipping an unmatched generic or compiler-generated signature.

The input files contain 730 rows (201 VLB, 508 VL, 16 ProFlare, 5 AO). Repeated
names represent overloads; the canonical comparator aggregates them by name.
Counts include the previously reconstructed Task D methods reached by this census.
They do not count every method in these assemblies.

## Assembly totals

| Assembly | same | [layout] | [semantic] | not done |
|---|---:|---:|---:|---:|
| `quaunity-volumetriclightbeam.Runtime` | 163 | 16 | 16 | 0 |
| `vl-unity.Runtime` | 448 | 20 | 21 | 0 |
| `ProFlare.Runtime` | 16 | 0 | 0 | 0 |
| `AmplifyOcclusion.Runtime` | 5 | 0 | 0 | 0 |

`same` means equal normalized ARM64 instructions in the canonical comparator,
not byte-for-byte ELF equality. `[layout]` means the comparator's retained
semantic instruction sequence agrees while full normalized instructions differ;
it is not an independent proof of field-layout equality. `[semantic]` remains
an open native-comparison result, including differences attributable to inlining,
metadata initialization and compiler instruction ordering. These flags have not
been reclassified as successes. `not done` refers only to the selected census;
the dependencies listed below remain outside the completed method bodies.

## Reconstructed behavior

- VLB: configuration/defaults, material and shader helpers, SD beam properties and
  lifecycle, material/bounds updates, fade enumerators, and geometry transforms.
  The APK's `GenerateGeometry` path validates/migrates data; it does not create a
  mesh there. The protected far-branch instruction in material/bounds updating
  was resolved from its target before restoring the constant.
- VL animation: data/dictionary access, easing functions, motion graphs, clips,
  layers, play/pause/stop/time/weight control, completion state machine and Timeline
  adapters. Timeline clip capabilities use the APK's 26/27 flags, including
  extrapolation; the first native comparison exposed and corrected an incorrect
  clip-in flag.
- VL actors: registration and extension lifecycle, bone/default-pose lookup,
  synchronous AABB jobs, skinning setup, material updates, actor constants and
  collider dimensions. Repeated extension-list reads around virtual callbacks
  follow the original. The reversed extension-unregistration condition and
  incrementing constraint-source removal loops are retained and annotated.
- VL faces/helpers: blend shape lookup, face-system setup and native arrays,
  vertex bindings, facial/blink limits, selected talk/virtual-actor operations,
  IK defaults/accessors, Cinemachine focus profiles and HDR/destroy helpers.
  Face-model `Setup` used disassembly because Hex-Rays could not decompile its
  constructor call. The original `custom_{0}_{1}` naming string is preserved.
- ProFlare: component defaults/lifecycle, atlas names, batch registration/removal
  and UV data updates, including disposal with the existing job dependency.
  `PopulateFlareBatches` is genuinely empty in the APK. The batch constructor was
  also restored because registration needs its lists, queue and dictionary.
- AmplifyOcclusion: all Volume parameter defaults and the intensity activation
  predicate. The three enum-parameter constructors already match the original
  parameterless base-constructor calls and required no source changes.

Fields and their declaration order were retained. Original empty methods and
constructors were not populated with speculative behavior.

## Build and comparison evidence

- Unity **6000.0.77f1**, Android **IL2CPP ARM64**.
- Final `Tools/build_android.sh`: **zero C# errors**, native IL2CPP outputs emitted.
  APK packaging still fails at `:unityLibrary:lintVitalAnalyzeRelease` with
  `For input string: "37.0"` (`LIVE_BUILD Failed errors=3`), as anticipated by the
  task instructions. No successful APK packaging is claimed.
- Il2CppDumper emitted its initial protected-file heuristic warning, then found
  registrations and completed metadata, struct and DummyDll generation.
- Baseline: 98 same / 591 changed / 16 missing. Final: 632 same / 73 changed /
  0 missing. All 705 selected method-name groups have paired signatures.
- No tests, test assemblies, test scripts or verification harnesses were written
  or run. Verification used the required Unity build and native comparison tools.
  No web access, Windows access, proof runs, deployment or pushes.
- Only the four owned packages and this report were committed. The layout script's
  incidental `LAYOUT-ALL.md` rewrite was restored; no URP fork or other worktree
  was modified by this task.

Final native artifact SHA-256:

| Artifact | SHA-256 |
|---|---|
| `libil2cpp.so` | `bc2d4bd911ffb3a683e690d76a298c7e9d9e1fc622906609d29a1f0b6b6c60f7` |
| `global-metadata.dat` | `d00085cac9e530fc7ef60935cc242f67b1d3d0bc5260bf0d7a69527b0474ffd1` |

Local evidence is intentionally under ignored `.recon/task-f/`:
[final build log](.recon/task-f/build-final.log),
[dumper log](.recon/task-f/dumper-final.log),
[canonical JSON](.recon/task-f/final-func-diff.json),
[readable result](.recon/task-f/final-func-diff.txt),
[per-method status](.recon/task-f/final-method-status.json),
[signature pairing](.recon/task-f/final-signature-coverage.json),
[semantic instruction diffs](.recon/task-f/final-semantic-details.txt), and
[artifact hashes](.recon/task-f/final-SHA256SUMS).
The decompilation batches, method/address manifests and disassembly fallbacks
are retained there as well. These local evidence files are not part of the commits.

## Per-type results

Nested types and emitted generic instantiations are separate rows. Only methods
named in the supplied census contribute to these counts.

| Type | same | [layout] | [semantic] | not done |
|---|---:|---:|---:|---:|
| `AmplifyOcclusion.AmplifyOcclusion` | 2 | 0 | 0 | 0 |
| `AmplifyOcclusion.ApplicationMethodParameter` | 1 | 0 | 0 | 0 |
| `AmplifyOcclusion.PerPixelNormalSourceParameter` | 1 | 0 | 0 | 0 |
| `AmplifyOcclusion.SampleCountLevelParameter` | 1 | 0 | 0 | 0 |
| `ProFlare` | 10 | 0 | 0 | 0 |
| `ProFlareAtlas` | 2 | 0 | 0 | 0 |
| `ProFlareAtlas.Element` | 1 | 0 | 0 | 0 |
| `ProFlareBatchForSRP` | 2 | 0 | 0 | 0 |
| `ProFlareBatchForSRPData` | 1 | 0 | 0 | 0 |
| `VL.AABB.AABBJobData` | 8 | 1 | 0 | 0 |
| `VL.ActorMesh.VLActorSkinningSystem` | 2 | 0 | 0 | 0 |
| `VL.ActorMotionDefine` | 2 | 0 | 1 | 0 |
| `VL.Animation.AnimationPlayerBase` | 2 | 0 | 0 | 0 |
| `VL.Animation.ClipEvent` | 2 | 0 | 0 | 0 |
| `VL.Animation.ClipParam` | 3 | 1 | 0 | 0 |
| `VL.Animation.EffectData` | 1 | 0 | 0 | 0 |
| `VL.Animation.LayerController` | 25 | 0 | 0 | 0 |
| `VL.Animation.LayerParam` | 4 | 1 | 0 | 0 |
| `VL.Animation.MotionClipPlayable` | 8 | 0 | 0 | 0 |
| `VL.Animation.MotionDefinePlayer` | 26 | 0 | 2 | 0 |
| `VL.Animation.MotionEffectPlayable` | 4 | 0 | 1 | 0 |
| `VL.Animation.MotionLayerMixerPlayable` | 7 | 0 | 0 | 0 |
| `VL.Animation.MotionLayerPlayable` | 12 | 0 | 0 | 0 |
| `VL.Animation.MotionTimelinePlayable` | 12 | 0 | 0 | 0 |
| `VL.Animation.MotionTimelinePlayable.<>c` | 2 | 0 | 0 | 0 |
| `VL.Animation.PrepareFrameEvent` | 2 | 0 | 0 | 0 |
| `VL.Animation.Timeline.MotionDefinePlayerTimelineAsset` | 3 | 0 | 1 | 0 |
| `VL.Animation.Timeline.MotionDefinePlayerTimelineTrack` | 4 | 1 | 0 | 0 |
| `VL.Animation.Timeline.MotionDefinePlayerTimelineTrack.<>c` | 4 | 0 | 0 | 0 |
| `VL.Animation.Timeline.MotionDefinePlayerTimelineTrack.<>c__DisplayClass2_0` | 2 | 0 | 0 | 0 |
| `VL.Animation.Timeline.MotionDefinePlayerTimelineTrack.<>c__DisplayClass3_0` | 2 | 0 | 0 | 0 |
| `VL.Animation.Timeline.MotionDefinePlayerTimelineTrackLayerBehaviour` | 6 | 1 | 1 | 0 |
| `VL.AnimationData` | 5 | 0 | 1 | 0 |
| `VL.Core.BlendShapeWeight` | 2 | 0 | 0 | 0 |
| `VL.Core.BoneNameToTransformDictionary` | 1 | 0 | 0 | 0 |
| `VL.Core.ChildMapDictionary` | 1 | 0 | 0 | 0 |
| `VL.Core.DefaultBoneInfo` | 1 | 0 | 0 | 0 |
| `VL.Core.InstanceIDToDefaultBoneInfoIndexDictionary` | 1 | 0 | 0 | 0 |
| `VL.Core.MaterialInfo` | 11 | 1 | 0 | 0 |
| `VL.Core.PartsIdMapDictionary` | 1 | 0 | 0 | 0 |
| `VL.Core.SerializedDictionary<Int32Enum, object>` | 8 | 1 | 0 | 0 |
| `VL.Core.SerializedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>` | 8 | 1 | 0 | 0 |
| `VL.Core.SerializedDictionary<int, int>` | 8 | 1 | 0 | 0 |
| `VL.Core.SerializedDictionary<int, object>` | 8 | 1 | 0 | 0 |
| `VL.Core.SerializedDictionary<object, object>` | 8 | 1 | 0 | 0 |
| `VL.Core.VLActorController` | 45 | 2 | 1 | 0 |
| `VL.Core.VLActorController.<>c` | 2 | 0 | 0 | 0 |
| `VL.Core.VLActorController<object, object, __Il2CppFullySharedGenericType>` | 4 | 0 | 0 | 0 |
| `VL.Core.VLActorController<object, object, object>` | 4 | 0 | 0 | 0 |
| `VL.Core.VLActorModelParts` | 7 | 0 | 0 | 0 |
| `VL.Core.VLActorModelParts<object>` | 1 | 0 | 0 | 0 |
| `VL.Ease.EaseFunction` | 2 | 0 | 0 | 0 |
| `VL.Ease.EaseFunctions` | 22 | 0 | 1 | 0 |
| `VL.FaceSystem.VLActorFaceBindVertex` | 1 | 0 | 0 | 0 |
| `VL.FaceSystem.VLActorFaceModel` | 25 | 1 | 1 | 0 |
| `VL.FaceSystem.VLActorFaceModel.<>c` | 9 | 0 | 1 | 0 |
| `VL.IK.CustomLookAtEffector` | 1 | 0 | 0 | 0 |
| `VL.IK.IKBodyEffector` | 3 | 0 | 0 | 0 |
| `VL.IK.IKGoalEffector` | 3 | 0 | 0 | 0 |
| `VL.IK.IKHintEffector` | 3 | 0 | 0 | 0 |
| `VL.IK.LookAtEffector` | 1 | 0 | 0 | 0 |
| `VL.JobUtility.Array2DInfo` | 0 | 1 | 0 | 0 |
| `VL.MotionDefine` | 9 | 0 | 0 | 0 |
| `VL.MotionDefine.MotionDefineEnumerator` | 7 | 0 | 1 | 0 |
| `VL.MotionDefinePlayable` | 4 | 0 | 0 | 0 |
| `VL.MotionEffectBase` | 1 | 0 | 0 | 0 |
| `VL.Rendering.Skinning.VLSkinningModel` | 1 | 0 | 0 | 0 |
| `VL.Rendering.Skinning.VLSkinningSystem<VertexLayoutStreamPNT, Skinning4>` | 5 | 1 | 0 | 0 |
| `VL.Rendering.Skinning.VLSkinningSystem<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>` | 4 | 1 | 1 | 0 |
| `VL.Rendering.VLActorShadow` | 1 | 0 | 0 | 0 |
| `VL.Rendering.VLActorShadowDirectionalTypeParameter` | 1 | 0 | 0 | 0 |
| `VL.Subsystems.VLSubsystem` | 2 | 0 | 0 | 0 |
| `VL.Timeline.VLTimelineController` | 1 | 0 | 0 | 0 |
| `VL.VLActorAO` | 1 | 0 | 0 | 0 |
| `VL.VLActorBlendShapeLimitDataRuntime` | 2 | 0 | 1 | 0 |
| `VL.VLActorBodyAdditiveAnimation` | 1 | 0 | 0 | 0 |
| `VL.VLActorCollider` | 2 | 0 | 1 | 0 |
| `VL.VLActorDefine` | 1 | 0 | 0 | 0 |
| `VL.VLActorExpression` | 1 | 0 | 0 | 0 |
| `VL.VLActorExpressionBone` | 1 | 0 | 0 | 0 |
| `VL.VLActorExpressionBone.AxisData` | 1 | 0 | 0 | 0 |
| `VL.VLActorEyeBlinkDataRuntime` | 1 | 0 | 0 | 0 |
| `VL.VLActorFaceModelBlendShapeLimitDataRuntime` | 2 | 0 | 1 | 0 |
| `VL.VLActorFaceModelEyeBlinkDataRuntime` | 1 | 0 | 0 | 0 |
| `VL.VLActorFacialSystem` | 9 | 0 | 0 | 0 |
| `VL.VLActorFacialSystem.<>c` | 2 | 0 | 0 | 0 |
| `VL.VLActorTalkBase<__Il2CppFullySharedGenericType, object>` | 9 | 0 | 0 | 0 |
| `VL.VLActorTalkBase<object, object>` | 9 | 0 | 0 | 0 |
| `VL.VLCameraController` | 1 | 0 | 0 | 0 |
| `VL.VLCinemachineFocusPoint` | 4 | 1 | 0 | 0 |
| `VL.VLCinemachineFocusPoint.VcamFocusPointState` | 2 | 0 | 1 | 0 |
| `VL.VLDefaultActorController<object, object, __Il2CppFullySharedGenericType>` | 2 | 0 | 1 | 0 |
| `VL.VLDefaultActorController<object, object, object>` | 2 | 0 | 1 | 0 |
| `VL.VLDefaultActorModelParts<object>` | 0 | 0 | 1 | 0 |
| `VL.VLExtension` | 0 | 0 | 1 | 0 |
| `VL.VLMeshUtility` | 1 | 1 | 0 | 0 |
| `VL.VLTalkMotionSelector` | 2 | 0 | 0 | 0 |
| `VL.VLUtility` | 2 | 0 | 0 | 0 |
| `VL.VLVirtualActorController` | 7 | 1 | 0 | 0 |
| `VL.VLVirtualActorController.BoneResult` | 3 | 0 | 0 | 0 |
| `VL.VLVirtualActorController.ErrorResult` | 2 | 0 | 0 | 0 |
| `VL.VLVirtualActorController<__Il2CppFullySharedGenericType>` | 1 | 0 | 0 | 0 |
| `VL.VLVirtualActorController<object>` | 1 | 0 | 0 | 0 |
| `VLB.BatchingHelper` | 1 | 0 | 0 | 0 |
| `VLB.BeamGeometrySD` | 10 | 3 | 6 | 0 |
| `VLB.Config` | 5 | 1 | 0 | 0 |
| `VLB.Consts.Beam` | 1 | 0 | 0 | 0 |
| `VLB.Consts.Beam.SD` | 1 | 0 | 0 | 0 |
| `VLB.Consts.Internal` | 2 | 0 | 0 | 0 |
| `VLB.MaterialManager` | 2 | 0 | 1 | 0 |
| `VLB.MaterialManager.MaterialsGroup` | 1 | 0 | 0 | 0 |
| `VLB.MaterialManager.StaticPropertiesHD` | 8 | 1 | 0 | 0 |
| `VLB.MaterialManager.StaticPropertiesSD` | 9 | 1 | 0 | 0 |
| `VLB.Noise3D` | 3 | 0 | 0 | 0 |
| `VLB.PlatformHelper` | 2 | 0 | 0 | 0 |
| `VLB.SRPHelper` | 3 | 0 | 0 | 0 |
| `VLB.ShaderKeywords.HD` | 1 | 0 | 0 | 0 |
| `VLB.ShaderProperties` | 1 | 0 | 0 | 0 |
| `VLB.ShaderProperties.SD` | 1 | 0 | 0 | 0 |
| `VLB.SpotLightHelper` | 3 | 0 | 0 | 0 |
| `VLB.Utils` | 2 | 1 | 0 | 0 |
| `VLB.VolumetricLightBeamAbstractBase` | 1 | 0 | 0 | 0 |
| `VLB.VolumetricLightBeamSD` | 95 | 9 | 8 | 0 |
| `VLB.VolumetricLightBeamSD.<CoPlaytimeUpdate>d__221` | 5 | 0 | 1 | 0 |
| `VLB.VolumetricLightBeamSD.OnBeamGeometryInitialized` | 2 | 0 | 0 | 0 |
| `VLB.VolumetricLightBeamSD.OnWillCameraRenderCB` | 2 | 0 | 0 | 0 |
| `VLB.VolumetricLightBeamSD.VolumetricLightBeamAction` | 2 | 0 | 0 | 0 |

## Remaining TODOs and scope limits

1. **37 raw semantic flags remain.** The complete list below is preserved without
   reclassification. Reviewed differences include inlined getters/base constructors,
   ordered switch blocks, equality-versus-inequality calls, metadata-load timing,
   equivalent integer comparisons, stripped interface slots and the protected
   far branch. The task explicitly excludes chasing these code-generation cases;
   exact native correspondence is still not established for the flagged methods.
2. `VLB.MaterialManager..cctor` has the original constant-array hashes but the
   generated metadata owner is `QAReconstructionImplementationDetails` instead of
   `PrivateImplementationDetails`. Resolving that would require the separately
   owned metadata-restoration mechanism; its raw semantic flag remains.
3. The selected `VLActorBodyAdditiveAnimation.SetAdditiveAnimation` and
   `VLActorExpression.Setup` entry points restore their original virtual calls,
   but their `Dispose`/`Initialize` implementations remain outside this census.
   Source TODOs identify those dependencies. Other non-census actor-model
   initialization/build methods, talk setup/update callbacks, and virtual-actor
   binding/update methods also remain structural skeletons. Restored entry points
   are not evidence that these larger systems work end to end.
4. ProFlare's non-census rendering-system/batch scheduling, GPU update and rendering
   methods remain outside this task. The selected registration/UV methods all
   compare identically, but that does not establish a functioning full flare
   renderer. Other VLB modes, occlusion integrations and third-party dependencies
   outside the provided lists are similarly not claimed complete.
5. The inherited Task D shared-generic skinning-constructor semantic flag remains.
   URP-owned rendering dependencies and non-owned assembly implementations must
   be completed separately. No unsupported implementation was invented in those
   assemblies and no files there were changed.
6. The Gradle SDK `37.0` packaging failure is unresolved. No scene execution or
   rendered-output proof was performed under this task's verification rules.

### Raw semantic flags

- `VL.ActorMotionDefine$$get_count`
- `VL.Animation.MotionDefinePlayer$$GetSpeed`
- `VL.Animation.MotionDefinePlayer$$SetSpeed`
- `VL.Animation.MotionEffectPlayable$$PrepareFrame`
- `VL.Animation.Timeline.MotionDefinePlayerTimelineAsset$$get_clipCaps`
- `VL.Animation.Timeline.MotionDefinePlayerTimelineTrackLayerBehaviour$$ProcessFrame`
- `VL.AnimationData$$CreatePlayable`
- `VL.Core.VLActorController$$SetupSkinningModels`
- `VL.Ease.EaseFunctions$$GetEaseFunction`
- `VL.FaceSystem.VLActorFaceModel$$.ctor`
- `VL.FaceSystem.VLActorFaceModel.<>c$$<Setup>b__36_3`
- `VL.MotionDefine.MotionDefineEnumerator$$MoveNext`
- `VL.Rendering.Skinning.VLSkinningSystem<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>$$.ctor`
- `VL.VLActorBlendShapeLimitDataRuntime$$IsValid`
- `VL.VLActorCollider$$_ApplyCollider`
- `VL.VLActorFaceModelBlendShapeLimitDataRuntime$$IsValid`
- `VL.VLCinemachineFocusPoint.VcamFocusPointState$$CreateProfile`
- `VL.VLDefaultActorController<object, object, __Il2CppFullySharedGenericType>$$OnActorDestroy`
- `VL.VLDefaultActorController<object, object, object>$$OnActorDestroy`
- `VL.VLDefaultActorModelParts<object>$$.ctor`
- `VL.VLExtension$$IsValid`
- `VLB.BeamGeometrySD$$CoUpdateFadeOut`
- `VLB.BeamGeometrySD$$ComputeLocalMatrix`
- `VLB.BeamGeometrySD$$ComputeMaterialStaticProperties`
- `VLB.BeamGeometrySD$$RestartFadeOutCoroutine`
- `VLB.BeamGeometrySD$$UpdateMaterialAndBounds`
- `VLB.BeamGeometrySD$$get_isNoiseEnabled`
- `VLB.MaterialManager$$.cctor`
- `VLB.VolumetricLightBeamSD$$get__INTERNAL_DynamicOcclusionMode`
- `VLB.VolumetricLightBeamSD$$get_geomSegments`
- `VLB.VolumetricLightBeamSD$$get_geomSides`
- `VLB.VolumetricLightBeamSD$$get_hasMeshSkewing`
- `VLB.VolumetricLightBeamSD$$get_useColorTemperatureFromAttachedLightSpot`
- `VLB.VolumetricLightBeamSD$$get_usedColorMode`
- `VLB.VolumetricLightBeamSD$$set_sortingLayerID`
- `VLB.VolumetricLightBeamSD$$set_sortingOrder`
- `VLB.VolumetricLightBeamSD.<CoPlaytimeUpdate>d__221$$MoveNext`

## Source commits on `codex-f`

| Commit | Batch |
|---|---|
| `84b4733` | VLB configuration, materials and shader helpers |
| `20c771b` | VLB SD beam lifecycle, geometry properties and fades |
| `bf22fb6` | VL motion playables, layers and Timeline playback |
| `009b0d1` | Actor lifecycle, bone registration and AABB |
| `a5c9f9e` | Actor bone tables and colliders |
| `6e960cf` | Face skinning, vertex binding and facial limits |
| `dfe259e` | Remaining actor helpers, camera focus and corrected Timeline flags |
| `57d4cb2` | ProFlare registration, atlas UVs and defaults |
| `00fb922` | AmplifyOcclusion defaults and activation |

This report is committed separately. Nothing was pushed.

## Reproduce

Run in this worktree only:

```sh
bash Tools/build_android.sh
/data/xy/gakumas/scripts/live_check.sh /data/xy/gakumas/live-urp-codex \
  "$(cat .recon/task-f/census-regex.txt)"
/data/xy/gakumas/tools/venv/bin/python /data/xy/gakumas/scripts/live_show.py \
  /data/xy/gakumas/live-urp-codex 'Full.Class$$Method' --semantic
```

The saved regex is the escaped alternation of the distinct second-column names
from the four `/data/xy/gakumas/work/codex/F_methods/*.txt` files, anchored with
`^(?:...)$`. Save each comparison before running another. `live_check.sh` rewrites
`LAYOUT-ALL.md` as a side effect; that generated report is outside Task F's changes.
The structural skeleton generators still overwrite reconstructed method bodies;
preserve these commits before intentionally regenerating those skeletons.

# Task D — VL rendering method reconstruction

Implemented the owned VL rendering method bodies from APK 3.5.3. Native parity
is **incomplete**: **242 same / 19 [layout] / 23 [semantic]**, across 284 selected
method names. No selected game method name is missing; this does not mean that
all rendering dependencies or the full game assembly are implemented.

## Build and evidence

- Unity 6000.0.77f1 (`88f89d0d8b31`), Android IL2CPP ARM64, 2026-11-04.
- `bash Tools/build_android.sh`: no C# compiler errors; native IL2CPP artifacts
  generated and successfully read by Il2CppDumper. Full APK build **failed** at
  `:unityLibrary:lintVitalAnalyzeRelease`: `For input string: "37.0"`.
- Final build log: `.recon/task-d/build-final.log`; dumper log:
  `.recon/task-d/dumper-final.log`. Il2CppDumper emitted its initial protected-file
  heuristic warning, then located registrations, dumped metadata and generated
  the struct/DummyDll output successfully.
- [Raw canonical comparison](Evidence/TaskD/final-func-diff.json),
  [readable comparison](Evidence/TaskD/final-func-diff.txt),
  [method addresses, signatures and source paths](Evidence/TaskD/method-status.json),
  [semantic instruction differences](Evidence/TaskD/final-semantic-details.txt),
  [artifact hashes](Evidence/TaskD/SHA256SUMS).
- URP fork used: `dd8822782e15bb043ee8888b4c7e5a7ebfb97b0b`, clean at verification.
  No URP fork changes were made by this task.
- Source changes after the final native build are TODO comments and newline
  normalization only. No tests or verification harnesses were written or run.
  No PC access, deployment, proof runs or pushes.

The canonical tool aggregates overloads by method name. `[layout]` is the tool's
accepted category, not a claim of byte-for-byte equality. `[semantic]` remains
open even where the evidence suggests compiler scheduling, metadata naming or
inlining rather than changed behavior. Five live-only names are four generated
delegate BeginInvoke/EndInvoke methods and `VLSubsystemRegistration..ctor`.

One generated helper, `ActorShadowPass.<UpdateShadowData>g__UpdateBounds|33_0`,
was skipped by the canonical signature pairing: the APK's second parameter is
unnamed and the reconstructed parameter is `P_1`. The comparator treats any name
containing `<` as generic for this skip. A supplemental comparison using the
same tool's `Image.norm` confirms identical instructions:
[helper comparison](Evidence/TaskD/update-bounds-comparison.json). Thus all 242
reported same names have a paired comparison, including this supplement.

## Per-type results

Counts below are canonical method-name groups, with nested types and emitted
generic instantiations kept separate. Only `VLActorController.actorControllers`,
`VLActorExtension.controller`, and `VLUtility.GetLimitedResolution` are in scope
for those otherwise non-rendering types. Default constructors may legitimately
remain empty in C# when they match the APK's base-constructor call.

| Type | same | [layout] | [semantic] | not done |
|---|---:|---:|---:|---:|
| `VL.ActorMesh.CombineMeshJob` | 0 | 0 | 1 | 0 |
| `VL.ActorMesh.VLActorSkinningModel` | 13 | 0 | 1 | 0 |
| `VL.ActorMesh.VLActorSkinningSystem` | 2 | 0 | 0 | 0 |
| `VL.Core.BlendShapeWeight` | 3 | 0 | 0 | 0 |
| `VL.Core.MaterialInfo` | 16 | 1 | 0 | 0 |
| `VL.Core.VLActorController` | 0 | 0 | 1 | 0 |
| `VL.Core.VLMonoBehaviourSingleton<object>` | 5 | 1 | 0 | 0 |
| `VL.Rendering.ActorShadowPass` | 14 | 2 | 1 | 0 |
| `VL.Rendering.ActorShadowPass.ActorShadowData` | 0 | 1 | 0 | 0 |
| `VL.Rendering.ActorShadowPass.GetBoundsEvent` | 2 | 0 | 0 | 0 |
| `VL.Rendering.DownscaleApplyPass` | 2 | 0 | 0 | 0 |
| `VL.Rendering.DownscaleBuffers` | 3 | 0 | 0 | 0 |
| `VL.Rendering.DownscalePass` | 17 | 1 | 10 | 0 |
| `VL.Rendering.DownscaleSystemData` | 1 | 0 | 0 | 0 |
| `VL.Rendering.DownscaleSystemRendererFeature` | 6 | 1 | 2 | 0 |
| `VL.Rendering.DownscaleSystemRendererFeature.Settings` | 1 | 0 | 0 | 0 |
| `VL.Rendering.DownscaleTransparentPass` | 8 | 0 | 1 | 0 |
| `VL.Rendering.DownscaleTransparentPass.<>c` | 3 | 0 | 0 | 0 |
| `VL.Rendering.DrawActorShadowPass` | 4 | 0 | 0 | 0 |
| `VL.Rendering.DrawActorShadowPass.Settings` | 1 | 0 | 0 | 0 |
| `VL.Rendering.DrawMultiCameraPass` | 4 | 0 | 0 | 0 |
| `VL.Rendering.DrawMultiCameraPass.Settings` | 1 | 0 | 0 | 0 |
| `VL.Rendering.DrawRenderTargetBlurPass` | 4 | 0 | 0 | 0 |
| `VL.Rendering.DrawUIBlurPass` | 2 | 2 | 0 | 0 |
| `VL.Rendering.DrawUIBlurPass.Settings` | 1 | 0 | 0 | 0 |
| `VL.Rendering.DrawVLActor` | 3 | 0 | 0 | 0 |
| `VL.Rendering.DrawVLActor.Settings` | 1 | 0 | 0 | 0 |
| `VL.Rendering.MultiCameraMaskPass` | 3 | 0 | 0 | 0 |
| `VL.Rendering.MultiCameraPass` | 3 | 0 | 0 | 0 |
| `VL.Rendering.RenderTargetBlurPass` | 3 | 0 | 0 | 0 |
| `VL.Rendering.Skinning.BlendShapeJob<VertexLayoutStreamPNT>` | 1 | 0 | 0 | 0 |
| `VL.Rendering.Skinning.BlendShapeJob<__Il2CppFullySharedGenericStructType>` | 1 | 0 | 0 | 0 |
| `VL.Rendering.Skinning.CopyJob<VertexLayoutStreamPNT>` | 1 | 0 | 0 | 0 |
| `VL.Rendering.Skinning.CopyJob<__Il2CppFullySharedGenericStructType>` | 1 | 0 | 0 | 0 |
| `VL.Rendering.Skinning.Skinning4` | 0 | 1 | 0 | 0 |
| `VL.Rendering.Skinning.SkinningJob<VertexLayoutStreamPNT, Skinning4>` | 1 | 0 | 0 | 0 |
| `VL.Rendering.Skinning.SkinningJob<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>` | 1 | 0 | 0 | 0 |
| `VL.Rendering.Skinning.UpdateMatricesJob` | 1 | 0 | 0 | 0 |
| `VL.Rendering.Skinning.VLSkinningModel` | 1 | 0 | 0 | 0 |
| `VL.Rendering.Skinning.VLSkinningSystem.<>c<VertexLayoutStreamPNT, Skinning4>` | 3 | 0 | 0 | 0 |
| `VL.Rendering.Skinning.VLSkinningSystem.<>c<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>` | 3 | 0 | 0 | 0 |
| `VL.Rendering.Skinning.VLSkinningSystem<VertexLayoutStreamPNT, Skinning4>` | 6 | 1 | 0 | 0 |
| `VL.Rendering.Skinning.VLSkinningSystem<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>` | 5 | 1 | 1 | 0 |
| `VL.Rendering.Skinning.VertexLayoutStreamPNT` | 3 | 0 | 0 | 0 |
| `VL.Rendering.UIBlurPass` | 8 | 0 | 0 | 0 |
| `VL.Rendering.VLActorShadow` | 1 | 0 | 0 | 0 |
| `VL.Rendering.VLActorShadowDirectionalTypeParameter` | 1 | 0 | 0 | 0 |
| `VL.Rendering.VLMultiCamera` | 4 | 0 | 0 | 0 |
| `VL.Rendering.VLMultiCamera.MultiCameraData` | 2 | 0 | 0 | 0 |
| `VL.Rendering.VLSRPCameraController` | 35 | 0 | 2 | 0 |
| `VL.Rendering.VLSRPCameraController.CameraAction` | 2 | 0 | 0 | 0 |
| `VL.Rendering.VLSRPDrawUIBlurPassSetting` | 3 | 0 | 0 | 0 |
| `VL.Rendering.VLSRPRenderTargetBlur` | 5 | 0 | 0 | 0 |
| `VL.ShaderIDs` | 1 | 0 | 0 | 0 |
| `VL.ShaderKeywords` | 1 | 0 | 0 | 0 |
| `VL.Subsystems.VLSubsystem` | 5 | 0 | 0 | 0 |
| `VL.Subsystems.VLSubsystemRegistration` | 1 | 2 | 0 | 0 |
| `VL.Subsystems.VLSubsystemRegistration.<>c__DisplayClass3_0` | 2 | 0 | 0 | 0 |
| `VL.VLActorAO` | 8 | 0 | 0 | 0 |
| `VL.VLActorAO.UpdateJob` | 0 | 0 | 1 | 0 |
| `VL.VLActorExtension` | 1 | 0 | 0 | 0 |
| `VL.VLActorShadowGroup` | 2 | 2 | 0 | 0 |
| `VL.VLCameraController` | 3 | 0 | 0 | 0 |
| `VL.VLCameraControllerSingleton<object>` | 2 | 0 | 1 | 0 |
| `VL.VLMeshUtility` | 1 | 2 | 1 | 0 |
| `VL.VLUtility` | 0 | 1 | 0 | 0 |

Types with no method bodies to reconstruct: `VL.ActorMesh.VertexLayoutStream1`,
`VL.Rendering.Skinning.BlendShapeInfo`, `VertexLayoutStream2`, `ISkinning`,
`IStream0`, the pass enums, and data-only nested structs such as `CapsuleData`
and `BlurRequest`. These retain the structural skeleton; they are not counted
as function comparisons.

## Not done / boundaries

| Type or area | Status |
|---|---|
| `VL.Rendering.VLSRPTargetImage` | Not done: UI adapter, explicitly skipped under the task's UI exclusion. |
| `VL.Core.VLActorController` registry initialization and actor lifecycle | Not done: only the rendering registry getter was reconstructed. The list remains dependent on the unreconstructed actor lifecycle; render consumers cannot yet rely on a populated registry. |
| Other `VLActorExtension` / `VLUtility` methods | Not done: non-rendering behavior outside the selected helper methods. |
| `VLSRPRenderer`, `VLSRPRendererData`, URP-owned volumes, buffers, entity managers and post effects | Outside this tree's ownership; same namespace does not imply the same assembly. Dependencies remain incomplete. |
| AmplifyOcclusion, ProFlare and VLB implementations | Outside this task's assembly; called through their existing interfaces, with skeleton dependencies still present. |

## Remaining TODOs

All 23 raw semantic flags are retained in the evidence and marked in the
relevant source files. They are not reclassified as accepted results.

1. Restore the separately owned URP dependencies and rerun the comparison.
   `MipChainBuffer` initialization/support/mip-count bodies,
   `VLSRPRenderer.forwardLights`, and
   `VLSRPAdditionalCameraData.targetTexture` are examples affecting current
   code generation or execution. Reconstruct actor registry initialization and
   lifecycle before expecting actor shadow/AO rendering to work end to end.
2. Move the APK `RenderingUtility.SetGlobalMipBias` (`0xd7d919c`) and
   `GetMotionVectorData` (`0xd7d92f8`) bodies into the URP fork, then restore
   their original call targets. The fork does not declare these methods, so
   `VLRenderingCompatibility` currently contains their recovered bodies.
   Its TAA frame-influence access uses the recovered field at byte offset 4;
   expose that field through the owning assembly instead of retaining the
   layout-dependent access once the fork can be changed.
3. `DownscalePass..cctor` and `VLMeshUtility.CreateBoxMesh` have matching
   recovered constant-array hashes but different compiler-generated metadata
   owner names (`QAReconstructionImplementationDetails` versus
   `PrivateImplementationDetails`). Resolve this with the metadata restoration
   mechanism and rerun the canonical comparator; current raw flags remain open.
4. `DownscalePass` SSAO/SSR/shadow paths and feature camera predicates still
   differ in immediate ordering, branches, initialization and inlining.
   Recovered source follows the available disassembly, but exact correspondence
   has not been established for the remaining flags. In particular the second
   SSAO `IsActive()` call is deliberately unconditional with respect to SSR,
   as in the APK; preserve that evaluation order.
5. `CombineMeshJob.Execute` still differs around half conversion, metadata
   loads and native-array access/disposal; `VLActorAO.UpdateJob.Execute`
   differs in parity-selection code; `VLActorSkinningModel.Setup` retains an
   additional loop/index immediate; the fully shared generic skinning
   constructor retains a differing allocation comparison immediate. Resolve
   these emitted-code differences before claiming parity.
6. `VLCameraControllerSingleton<object>..ctor` has a different inlined base
   constructor target. `ActorShadowPass.UpdateShadowData` and the actor-list
   getter retain initialization-call differences. These are still semantic
   flags in the canonical report.
7. Gradle's SDK `37.0` parsing failure is unresolved. Native verification was
   possible, but no successfully packaged APK is claimed.

## Reconstruction provenance

Local ignored evidence under `.recon/task-d/` contains the sequential IDA
batches (`decomp`, `helper-decomp`, `extra-decomp`, `dependency-decomp`,
`actor-mesh-decomp`, `shadow-group-decomp`, `subsystem-decomp`) and disassembly
fallbacks. Method addresses and source paths are retained in the tracked
manifest. The original APK and DummyDll inputs were read only.

Recovered details include shader IDs/keywords; pass ordering; RT formats;
shadow culling and caster/receiver constants; blur/multi-camera handling;
SSAO, SSR and HiZ setup; material properties; mesh/bone-weight packing; skinning
jobs and subsystem registration. The APK's unusual tangent component copy in
`CombineMeshJob` is preserved and annotated rather than corrected speculatively.
The SSR step counts are 32/48/96; the box mesh uses the recovered 36 indices.

The skeleton regeneration scripts still regenerate skeletons. They do not
reconstruct these method bodies; intentionally rerunning them requires preserving
or reapplying the Task D commits.

## Commits

- `1da3074`: renderer features, blur/multi-camera passes, buffers, volume and shader IDs.
- `6d63faa`: actor shadow, downscale, SSAO/SSR and bounded URP compatibility bodies.
- `ec18eb4`: camera targets, singletons, actor AO/shadow helpers and resolution helpers.
- `a9afdd6`: skinning jobs/models, mesh/material operations and subsystem registration.
- The documentation/evidence commit containing this report records the final
  comparison. No commits were pushed.

## Reproduce the native comparison

Build with `bash Tools/build_android.sh`. Then dump the fresh native outputs
(the full APK packaging failure does not prevent these artifacts being emitted):

```sh
DOTNET_ROOT=/data/xy/.toolchains/dotnet-8 DOTNET_ROLL_FORWARD=Major \
  /data/xy/.toolchains/dotnet-8/dotnet \
  /data/xy/gakumas/tools/il2cppdumper/Il2CppDumper.dll \
  Library/Bee/Android/Prj/IL2CPP/Gradle/unityLibrary/src/main/jniLibs/arm64-v8a/libil2cpp.so \
  Library/Bee/Android/Prj/IL2CPP/Gradle/unityLibrary/src/main/assets/bin/Data/Managed/Metadata/global-metadata.dat \
  .recon/live-dump
/data/xy/gakumas/tools/venv/bin/python /data/xy/gakumas/scripts/urp_func_diff.py \
  Library/Bee/Android/Prj/IL2CPP/Gradle/unityLibrary/src/main/jniLibs/arm64-v8a/libil2cpp.so \
  .recon/live-dump/script.json "$(cat Evidence/TaskD/final-regex.txt)"
```

The canonical comparator writes shared `work/urp17/func_diff.json/.txt`.
Immediately save each run under `.recon/task-d/` before another task overwrites
those shared files. The tracked final evidence is a snapshot, not a live view.

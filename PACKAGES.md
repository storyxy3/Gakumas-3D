# Package sources and version evidence

Target: Unity **6000.0.77f1 (88f89d0d8b31)**, Android IL2CPP, ARM64. The
source game is APK 3.5.3. The URP/Core source base is **14.0.12**, not the
editor's default URP 17; see `../LIVE_TRUEEND.md` §6.12 and
`../work/urp17/qualiarts_urp14_changes.txt`.

**Exact package patches are not all recoverable from the evidence inspected.**
The manifest below pins reproducible candidates; a compatible field/signature
fingerprint is not proof of an exact package version. The game's managed
assemblies were stripped, so missing methods alone cannot exclude a candidate.
All assemblies inspected except Timeline have AssemblyVersion `0.0.0.0`;
Timeline has `1.0.0.0`. These are not UPM versions.

## Selected versions

| Package | Pinned source | Evidence and confidence |
| --- | --- | --- |
| Render Pipelines Universal / Core | 14.0.12, local `../work/urp14-fork-live` | Established project baseline: `DeferredLights.SetupLights(ScriptableRenderContext, ...)`, `ExecuteDeferredPass(ScriptableRenderContext, ...)`, `RenderStencilLights(ScriptableRenderContext, CommandBuffer, ...)` and `ClearStencilPartial(CommandBuffer)` match URP 14. The existing method comparison found 3,741 matches against 14.0.12. Game modifications are separately reconstructed in the fork. |
| Shader Graph | 14.0.12, same fork | Matching URP/Core package family and their dependency metadata; editor dependency, not independently identifiable from the stripped player's runtime API. |
| Universal Config | fork package | Taken from the already compiling reference project's package closure, using the same fork worktree path. |
| Cinemachine | 2.6.0, sanitized registry source + game additions | Strong identification: game `CinemachineCore` retains `kStreamingVersion`, `kVersionString`, `GenerateCameraActivationEvent(ICinemachineCamera, ICinemachineCamera)` and `GenerateCameraCutEvent(ICinemachineCamera)`. Candidate 2.6.0 `Runtime/Core/CinemachineCore.cs:16` sets `kVersionString = "2.6.0"`; the game's string-literal table contains `2.6.0` at `0xF013E38`. Candidate 2.8.9 contains `2.8.8` instead; 2.9.7 and cached 2.10.7 remove `kVersionString`. This is converging static evidence, not a runtime observation. |
| Timeline | 1.8.12, sanitized registry source + game addition | Compatible candidate from the Unity77 reference cache. `TimelineAsset` retains serialized `m_Version`, `List<ScriptableObject> m_Tracks`, `double m_FixedDuration`, `EditorSettings m_EditorSettings`, `MarkerTrack m_MarkerTrack`, and matching duration/track API. These are present in candidate `Runtime/TimelineAsset.cs` and its upgrade partial. Candidate 1.7.6 was also inspected; the retained members do not uniquely distinguish the patch. **Exact version unresolved.** |
| Burst | 1.8.29 | Compatible candidate from the Unity77 reference cache. Game `BurstCompilerOptions` has `ForceDisableBurstCompilation`, `ForceBurstCompilationSynchronously`, `IsSecondaryUnityProcess`, `_enableBurstCompilation`, `_enableBurstSafetyChecks`, and `CheckIsSecondaryUnityProcess()`; candidate `Runtime/BurstCompilerOptions.cs` has these. `BurstCompileAttribute` includes `DisableSafetyChecks` and `OptimizeFor`; `BurstRuntime.RuntimeLog(byte*, int, byte*, int)` also agrees. These are insufficient to identify a patch. **Exact version unresolved.** |
| Collections | 2.6.8, sanitized registry source | Game has both `NativeParallelHashMap` and the newer `NativeHashMap<TKey,TValue>` backed by `HashMapHelper<TKey>* m_Data`. `HashMapHelper` fields are `Ptr`, `Keys`, `Next`, `Buckets`, `Count`, `Capacity`, `Log2MinGrowth`, `BucketCapacity`, `AllocatedIndex`, `FirstFreeIdx`, `SizeOfTValue`, allocator. This rules out the old pre-rename map layout. Candidate 2.1.4, 2.4.0 and cached 2.6.7 share this structure; 2.6.8 is the compiling candidate: 2.6.7 runtime `xxHash3` depended on `System.Runtime.CompilerServices.Unsafe` from removed test infrastructure; the upstream 2.6.8 changelog explicitly removes that dependency, using byte-wise unaligned access in the source. The stripped game does not retain `xxHash3`, so this cannot identify its package patch. **Exact version unresolved.** |
| Mathematics | 1.3.2 | Compatible candidate from the Unity77 reference cache. Game `Random` contains `uint state`, `Random(uint)`, `CreateFromIndex(uint)`, `WangHash(uint)`, `InitState(uint = 1851936439)` and the retained vector/matrix types; these agree with candidate `Unity.Mathematics/random.cs`. This does not distinguish patch releases. **Exact version unresolved.** |
| Animation Rigging | 1.4.0, sanitized registry source | **1.4 family confirmed** by game `RigBuilder`, `Rig`, `RigTransform`, `TwoBoneIKConstraint` HelpURL attributes referring to `com.unity.animation.rigging@1.4`. `RigBuilder` field sequence is `m_RigLayers`, `m_RuntimeRigLayers`, `m_SyncSceneToStreamLayer`, `m_Effectors`, `m_IsInPreview`, static callbacks; 1.4.0 agrees. Candidates 1.2.1/1.3.0 have older documentation families. 1.4.1's editor changes do not establish a distinct retained runtime fingerprint. **1.4.0 versus 1.4.1 unresolved.** |
| uGUI / TextMeshPro | 2.0.0, embedded editor source + game additions | Game TMP HelpURL attributes explicitly point to `com.unity.ugui@2.0`; `TMP_Settings` retains `assetVersion`, `s_CurrentAssetVersion`, `version`, `SetAssetVersion()`. Unity77's uGUI 2.0.0 includes both the exact `UnityEngine.UI` and `Unity.TextMeshPro` assembly names. No separate legacy TMP package is added. |
| Visual Effect Graph | 17.0.4 runtime source from Unity77 | Compatible runtime candidate. Game `Unity.VisualEffectGraph.Runtime` includes `VisualEffectControlClip` with `scrubbing`, `startSeed`, `ReinitMode`, `PrewarmClipSettings`, `clipEvents`, `singleEvents`; the editor-bundled 17.0.4 source agrees. Its `PrewarmClipSettings` retains `enable`, `stepCount`, `deltaTime`, `eventName`, and `VFXTimeSpaceHelper.GetEventNormalizedSpace(...)` agrees. **Exact patch unresolved.** Only runtime source is included; see adaptation below. |
| Profiling Core | 1.0.2 | Game retains `Unity.Profiling.ProfilerCounterValue<T>` and constructor `(ProfilerCategory, string, ProfilerMarkerDataUnit, ProfilerCounterOptions)`, with get/set `Value`; registry 1.0.2 matches. Too little survives stripping to distinguish 1.0.x patches. **Exact patch unresolved.** |
| Memory Profiler | omitted unless required by closure | Game assembly exists. Registry 1.1.0 candidate was inspected: `MetadataInjector`, `MetadataCollect.CollectMetadata(MemorySnapshotMetadata)` and `DefaultMetadataCollect.FormatSecondsToTime(double)` agree. This is not needed solely because the game contains it; include only if a closure member references it. **Exact version unresolved.** |
| Newtonsoft JSON | 3.2.1 | Closure dependency, Unity's maintained UPM distribution of `Newtonsoft.Json`. Pin is a compatible candidate; no claim of exact game UPM patch. |
| Engine modules | 1.0.0 | Built-in Unity6000.0.77 modules. Version is Unity's package marker, not a separately selected library release. |

## Source locations and repeatability

Game evidence is read-only:

- `../work/il2cpp-3.5.3/dump.cs`
- `../work/il2cpp-3.5.3/stringliteral.json`
- `../work/il2cpp-3.5.3/DummyDll/<assembly>.dll`

Candidate caches inspected:

- `../work/urp17/ref-android-urp14/Library/PackageCache/`
- `../work/urp17/ref-android-77/Library/PackageCache/`
- `/data/xy/ALONE-u6/unity/Haruki3DMV/Library/PackageCache/`
- `/data/xy/.toolchains/unity-6000.0.77f1/Editor/Data/Resources/PackageManager/BuiltInPackages/`

Registry metadata and candidate source archives came from
`https://packages.unity.com/com.unity.<name>` and the archive URLs listed by
that index. The ignored `.package-evidence/` directory retains the inspected
indexes, downloaded candidate sources, and ILSpy projections for this session.
It is not required to build the project.

Run `python3 Packages/restore_registry.py` to regenerate the local registry
source copies. `Packages/registry-sources.json` records archive SHA-256 hashes
and the exact removed dependency entries. The script removes test assemblies,
test generator directories, samples, documentation, and test-framework package
dependencies from Collections and Rigging. Runtime API source is retained.
The runtime `GenerateTestsForBurstCompatibilityAttribute` is retained because
it is part of the real Collections API; its name does not make it a test.

Visual Effect Graph's authoring package requires ShaderGraph/Core 17, while
this project intentionally uses the game's URP14 fork. The local VFX package
therefore contains the bundled 17.0.4 **runtime** source and original metadata,
not the graph editor, compiler, or authoring resources. Its root asmdef is
adapted from optional `Unity.ugui` to the actual `UnityEngine.UI` assembly name,
and the absent optional `Unity.InputSystem` reference is omitted. Runtime
Timeline binding remains enabled. This is an explicit editor capability cut;
the project does not claim VFX graph authoring support. Existing game VFX asset
deserialization and runtime layout still require the final build comparison.

No Unity Test Framework, NUnit, performance-test package, or `testables` entry
is selected by the project manifest. No tests are authored or run.

## Remaining version work

The pins marked unresolved must not be reported as the game's proven exact
versions. The final layout comparison can identify structural mismatches but
cannot prove an exact version when multiple releases share runtime layout.
Further distinctions require surviving package-version metadata or a focused
method comparison against candidate builds, outside this initial evidence set.

## Game additions to registry assemblies

The game compiles `Titan.TitanTrackBase` into **Unity.Timeline**, not
`Titan.Runtime` (`dump.cs` TypeDefIndex 42102, around line 2836720). Timeline
is therefore embedded at 1.8.12. Its only game-added top-level type is generated
into `Runtime/QualiArts/_Skeleton/TitanTrackBase.cs` by
`Packages/restore_registry.py`, using the shared `SkeletonMetadata` helper and
`clean_source` cleanup. The class has no declared fields; it retains the internal
`GetSequenceTime(out double, out double)` override, protected virtual
`GetTitanSequenceTime(out double, out double)`, protected static
`CombineHash(int,int)`, and protected constructor. Bodies remain DummyDll
stubs. Stock `TrackAsset.GetSequenceTime` is already internal virtual and
`GatherProperties(PlayableDirector,IPropertyCollector)` is already public
virtual in 1.8.12, so no stock Timeline class change is needed for this hook.

All 73 game top-level Timeline types were checked against declarations in the
candidate Runtime source; generic `IntervalTree<T>` is stock. This inventory
does not assert that every retained stock method's body is identical.
The restore script requires the metadata helper built by the project skeleton
generation workflow before regenerating this additional type.

## Native-layout findings: uGUI and Cinemachine

The first actual Android native build exposed a shared UI base-class difference.
In the game, `Graphic` ends with compiler-generated
`<useLegacyMeshGeneration>k__BackingField` at `0xA0` and
`int <GraphicRebuildOrder>k__BackingField` at `0xA4`. The latter is absent in
stock uGUI 2.0.0. This explains the eight-byte shortfall in `MaskableGraphic`,
`RawImage`, and the custom game components derived from them. uGUI 2.0.0 is
therefore embedded from the pinned editor and the missing storage is inserted
exactly after the legacy backing field. The public `GraphicRebuildOrder`
property preserves DummyDll stub accessors; the metadata-name processor restores
the escaped backing field name.

The same game UI assembly adds a default interface getter
`ICanvasElement.GraphicRebuildOrder`, and `CanvasUpdateRegistry` adds the
`onLayoutComplete` event/backing field at `0x30`, static
`IComparer<ICanvasElement> s_SortGraphicComparer` at `0x10`, and nested
`GraphicSortComparer`. These additions retain metadata signatures and empty or
default bodies; event dispatch and graphic sorting behavior are not rebuilt.
The source still contains stock literal constants stripped from the game; these
do not consume instance storage and remain reportable metadata differences.

Cinemachine 2.6.0 is also a game fork. Game `LensSettings` adds
`[Tooltip("Focal Length for physical camera")] public float FocalLength` after
`Dutch`, at offset `0x14`. It enlarges `LensSettings` and shifts the embedded
`CameraState` and camera component fields. The native report's camera instance
shifts are therefore real missing storage, not merely stripped constants. The
field and `VerticalFOVToFocalLength(float)` / `FocalLengthToVerticalFOV()`
signatures are now added, with conversion bodies left as DummyDll stubs.
`CinemachineShotPlayable` adds `public Animator CameraAnimator` at `0x18` and
three lifecycle overrides; `CinemachineBrain` adds
`private static readonly AnimationCurve mDefaultLinearAnimationCurve` at static
offset `0x8`. No new static initializer executes game behavior.

All these edits are applied by `Packages/restore_registry.py` from fresh source.
They require a new native build to confirm corrected offsets; the first report
is evidence for the missing storage, not evidence that these fixes already
passed the layout comparison.

## Second native-layout pass: remaining TMP and Timeline storage

The second native build confirmed the added Graphic and Cinemachine storage
fixes. `AnimationOutputWeightProcessor` still retained the stock
`AnimationMotionXToDeltaPlayable m_MotionXPlayable` between `m_Output` and
`m_Mixers`; game metadata omits it. A complete source search finds only its
declaration, with no reads or writes. The restore script now removes that
unused declaration, bringing the expected `m_Mixers` offset from `0x30` to
`0x20` without changing executable code.

TMP still differs structurally: stock `TMP_Text` contains
`[SerializeField] private protected float m_characterHorizontalScale = 1.0f`
after `m_duoSpace`, but the game's field inventory omits it. Alignment changes
then enlarge TMP-derived classes by eight bytes. This field is actively read
by geometry and preferred-size calculations, and exposed through
`characterHorizontalScale`; it is not a dead declaration. The official
uGUI repository revision
`191f765e9d1b7e419ae7f20502a38b9d9966bfc8`
([TMP_Text source](https://github.com/Unity-Technologies/uGUI/blob/191f765e9d1b7e419ae7f20502a38b9d9966bfc8/com.unity.ugui/Runtime/TMP/TMP_Text.cs))
has no such field, property, or multipliers. It is a compatible older layout
candidate, but its active methods differ in additional ways; selecting those
bodies is not justified solely by a layout match.

`TMP_MaterialManager.MaskingMaterial` has only `stencilMaterial` at `0x10` and
`count` at `0x18` in the game. Both current and that older stock source also
contain `baseMaterial` and `stencilID`. Those members serve legacy stencil-cache
APIs (`GetStencilMaterial`, `GetBaseMaterial`, `AddMaskingMaterial`,
`ReleaseBaseMaterial`, `ListMaterials`) absent from the game metadata. A bounded
search across the embedded uGUI sources finds no callers outside their own
source file. This is evidence of game stripping, not evidence for a different
UPM patch. The retained `ReleaseStencilMaterial` method only requires the two
fields that remain in the game.

The legacy MaskingMaterial APIs and their extra fields are now guarded with
`UNITY_EDITOR`; `ListMaterials` and its debug calls require both `UNITY_EDITOR`
and `TMP_DEBUG_MODE`. Repository-wide search across `Packages/` and `Assets/`
confirmed no external caller of the four legacy cache APIs. Retained runtime
methods, including `ReleaseStencilMaterial`, are unchanged. The guards reproduce
the game player’s stripped storage while retaining editor-only legacy behavior.
This transformation is regenerated by `strip_unused_tmp_player_storage()` in
`Packages/restore_registry.py`.

The active `TMP_Text.characterHorizontalScale` implementation is deliberately
retained pending a method-level comparison; the TMP-derived eight-byte layout
mismatch remains an explicit unresolved package-source difference. No older
TMP method implementation has been transplanted.

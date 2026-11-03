# Rendering assembly closure

Source: APK 3.5.3 Il2CppDumper DummyDll assemblies. These are structural skeletons; runtime behavior is not reconstructed. No tests or test assemblies are part of this project.

## Included assemblies

| Assembly | Source types (top level) | Original references |
| --- | ---: | ---: |
| `vl-unity.Runtime` | 235 | 22 |
| `campus-submodule.Runtime` | 655 | 38 |
| `campus-submodule.Shader.Runtime` | 1 | 2 |
| `AmplifyOcclusion.Runtime` | 15 | 3 |
| `ActorAnimation.Runtime` | 157 | 8 |
| `ProFlare.Runtime` | 18 | 4 |
| `quaunity-volumetriclightbeam.Runtime` | 77 | 8 |
| `Uguiss.Runtime` | 33 | 2 |
| `Uguiss-Timeline.Runtime` | 40 | 3 |
| `UniTask` | 221 | 6 |
| `UniTask.Linq` | 4 | 1 |
| `Titan.Runtime` | 239 | 13 |
| `quaunity-ui.Runtime` | 179 | 9 |
| `CriMw.CriWare.Runtime` | 112 | 7 |
| `Qua.Utility` | 26 | 3 |
| `quaunity-global` | 5 | 4 |
| `DOTween` | 92 | 1 |
| `Qua.VectorUI.Runtime` | 15 | 3 |
| `UniRx` | 156 | 6 |
| `Qua.Base.Runtime` | 4 | 4 |
| `Qua.PolygonUtility` | 44 | 2 |
| `quaunity-crypto` | 4 | 1 |
| `Octo` | 129 | 11 |

Every local package has the exact original assembly name. Engine/.NET references are supplied by Unity rather than named asmdef references. Registry and fork assemblies are described in [PACKAGES.md](PACKAGES.md). The complete original reference table is retained in [Tools/closure.json](Tools/closure.json).

The main game assembly, Firebase, Grpc, purchasing, accounts and HTTP client stacks are outside the rendering closure. DOTween.Modules/Pro, SSS, WaterSystem, GrassSystem, ZString and other assemblies are not pulled in merely by name: the selected reference closure does not require them.

## Exact closure cuts

- `Titan.Runtime`: omit references to `Assembly-CSharp`, `campus-submodule.Runtime`, `Qua.VectorUI.Runtime`. DummyDll project reference table lists these assemblies, but full ilspycmd -il output contains zero qualified references to them; no source declaration edits required.
- `Qua.Base.Runtime/Qua.Base/StoreUtil.cs`: Store review coroutine dependencies are outside rendering. Three reference-typed fields retain reference storage, but exact declared types differ.
  - object /* TODO(qa-recon): Google.Play.Review.ReviewManager excluded from rendering closure. */ 
  - object /* TODO(qa-recon): Google.Play.Common.PlayAsyncOperation<PlayReviewInfo, ReviewErrorCode> excluded from rendering closure. */ 
  - object /* TODO(qa-recon): Google.Play.Common.PlayAsyncOperation<VoidResult, ReviewErrorCode> excluded from rendering closure. */ 
- `quaunity-crypto/Qua.Crypto/AES.cs`: Crypto implementation reference is outside rendering; pointer storage retained while exact declared type differs. No crypto behavior reconstructed.
  - object /* TODO(qa-recon): FastAES excluded from rendering closure. */ 

Octo is retained because `CampusAssetKeeperBase<T>` inherits its field-bearing `AssetKeeper`. Removing that base would change every derived rendering loader layout. Its backend-only dependencies are cut as follows:

- `Octo.Data/AESCrypt.cs`: Octo.Data.AESCrypt._fastAes -> object. Original declarations:
  - `private FastAES _fastAes;`
- `Octo.Data/DataManager.cs`: remove excluded protobuf namespace import. Original declarations:
  - `using ProtoBuf;`
- `Octo.Data/DataManager.cs`: Octo.Proto.Data parameter -> object. Original declarations:
  - `private void UpdateWithNewData(Dictionary<string, Item> dictionary, Data octodata)`
- `Octo.Data/DataManager.cs`: Octo.Proto.Database signature -> object. Original declarations:
  - `private SecureProtoBufDatabase<Database> ReadSecureDatabase(string path)`
  - `private void ResetAllDependencies(Database db)`
  - `private void SetUrls(Database db)`
  - `private void ConstructDictionary(Database db)`
- `Octo.Data/DataManager.cs`: ProtoBuf.ProtoWriter parameter -> object. Original declarations:
  - `private static void Write(ProtoWriter writer, int tag, IEnumerable<Item> items, Dictionary<string, int> tagDictionary)`
- `Octo.Data/Item.cs`: remove excluded protobuf namespace import. Original declarations:
  - `using ProtoBuf;`
- `Octo.Data/Item.cs`: Octo.Data.Item.state: Data.State -> int. Original declarations:
  - `public Data.State state;`
- `Octo.Data/Item.cs`: Octo.Proto.Data parameter -> object. Original declarations:
  - `public Item(Data data, IList<string> tagNames)`
  - `public virtual void SetData(Data data, IList<string> tagNames)`
  - `public virtual void SetDependencies(Data data, Dictionary<int, Item> items)`
- `Octo.Data/Item.cs`: ProtoBuf.ProtoWriter parameter -> object. Original declarations:
  - `public void Write(ProtoWriter writer, Dictionary<string, int> tagDictionary)`
- `Octo.Data/ItemFactory.cs`: Octo.Proto.Data parameter -> object. Original declarations:
  - `public static Item Create(Data data, IList<string> tagNames)`
  - `public static Item CreateByResource(Data data, IList<string> tagNames)`
  - `public static bool IsSameItemType(Item item, Data data)`
  - `private static ItemType CalculateItemType(Data data)`
- `Octo.Data/ItemWithDeps.cs`: Octo.Proto.Data parameter -> object. Original declarations:
  - `public ItemWithDeps(Data data, IList<string> tagNames)`
  - `public override void SetDependencies(Data data, Dictionary<int, Item> items)`
- `Octo.Data/ItemWithDepsAndTags.cs`: Octo.Proto.Data parameter -> object. Original declarations:
  - `public ItemWithDepsAndTags(Data data, IList<string> tagNames)`
- `Octo.Data/ItemWithTags.cs`: Octo.Proto.Data parameter -> object. Original declarations:
  - `public ItemWithTags(Data data, IList<string> tagNames)`
- `Octo.Data/ProtoWriterExtensions.cs`: remove excluded protobuf namespace import. Original declarations:
  - `using ProtoBuf;`
- `Octo.Data/ProtoWriterExtensions.cs`: ProtoBuf.ProtoWriter parameter -> object. Original declarations:
  - `public static void Write(this ProtoWriter writer, int tag, int value)`
  - `public static void Write(this ProtoWriter writer, int tag, uint value)`
  - `public static void Write(this ProtoWriter writer, int tag, string value)`
  - `public static void Write(this ProtoWriter writer, int tag, IEnumerable<int> values)`
  - `public static void Write(this ProtoWriter writer, int tag, IEnumerable<string> values)`
  - `public static void WriteIfNotDefault(this ProtoWriter writer, int tag, int value)`
  - `public static void WriteIfNotDefault(this ProtoWriter writer, int tag, uint value)`
- `Octo.Proto/StaticSerializer.cs`: Octo.Proto.StaticSerializer._serializer -> object. Original declarations:
  - `private static OCTProtoSerializer _serializer;`

Each source substitution includes `TODO(qa-recon)`. Reference storage is retained for object substitutions, but their exact declared types intentionally differ. The `Data.State` backend enum is replaced with `int`, preserving its underlying storage. Machine-readable substitutions: [closure-cuts.json](Tools/closure-cuts.json), [octo-cuts.json](Tools/octo-cuts.json).

## Reproducible generation and C# repairs

`python3 /data/xy/gakumas/scripts/skeleton_from_dummydll.py` runs `ilspycmd -p`, records original assembly references, and uses the same installed ILSpy library with automatic-property/event/anonymous-method reconstruction disabled to retain backing fields. It then applies the tracked Roslyn cleanup. `python3 Tools/generate_octo.py` handles the separately bounded Octo closure. The tracked copy of the main script is [Tools/skeleton_from_dummydll.py](Tools/skeleton_from_dummydll.py).

Mechanical repairs (no implementation reconstruction):

- Remove Il2CppDummyDll attributes/references. Preserve assembly attributes, including DOTween AssemblyVersion 1.0.0.0. Preserve real attributes and convert explicit-layout offsets to real `System.Runtime.InteropServices.FieldOffset` attributes.
- Preserve declaration field order, including backing fields. Escape invalid C# identifiers during source generation; the editor-only metadata postprocessor restores original names after compilation, including event backing fields and original numeric data-field names. Compiler-generated closure classes are retained. Source visibility is relaxed only for a compiler-generated Titan generic closure signature; ILPP restores its original private visibility. Explicit data-blob struct sizes are recovered from their compiler-encoded `__StaticArrayInitTypeSize=N` names.
- Restore explicit interface declarations from their escaped metadata names, including iterator interfaces and the IDictionary indexer.
- Keep default-return/empty/throw-null bodies; use `throw null` for invalid ref-return or unassigned-out Dummy bodies and `default(T)` for invalid `(T)null` expressions.
- Initialize struct constructor storage with `this = default`; synthesize required base constructor calls using default arguments, marked TODO. The original calls are absent from DummyDll and remain unknown.
- Represent optional parameters as Optional/DefaultParameterValue attributes when C# parameter ordering forbids a default expression.
- Add only C#-required stripped counterparts: `ActorAnimationJob.jobWeight` and `CampusActorAnimationJob.jobWeight` getters, `AbstractCommand.ParameterAttribute.HideInInspector` getter, and `ClipperLib.Int128.op_Inequality`. These are TODO stub members.
- Qualify `VLActorRigFurisodeJob.EvaluateRig` AffineTransform as UnityEngine.Animations.Rigging.AffineTransform; original IL explicitly references Unity.Animation.Rigging, while the candidate Mathematics also defines the short name.
- Unity-generated MonoScript descriptor and job-reflection-registration types are regenerated by Unity, rather than compiled twice from DummyDll.
- Namespace directory `Campus.live` is written as `Campus.live_lowercase` to avoid Unity treating it as a duplicate of `Campus.Live`; C# namespaces are unchanged.

No hand edits to generated local skeleton source are required. Fork source changes and its generator are committed separately on `live-base`, one initial stock-class addition commit per class. The editor-only VFX authoring integration is disabled because this project embeds VFX runtime sources against the game's older URP/Core fork.

## Validation

Final compile/build status and real Android IL2CPP field comparison are recorded in [LAYOUT.md](LAYOUT.md). A compilation alone is not evidence of layout equality or working runtime behavior.

## Completed native comparison

The final local skeleton closure has no missing types. Its eight mismatching
types comprise six explicit backend/review/crypto type substitutions and two
text components inheriting the stock TMP horizontal-scale storage difference.
All event and numeric compiler-generated field names are restored. See
[LAYOUT.md](LAYOUT.md) for the complete counts, indeterminate generic layouts,
extra compiler helpers, remaining registry/fork differences and artifact hashes.

Rerunning the main skeleton generator and the Octo generator produced no source
diff. No generated local assembly source requires a manual fix after regeneration.
The final Editor import and Android player script compilation have zero C# or
metadata-postprocessor errors. Native linking completed; Gradle's SDK `37.0`
lint parsing failure prevented APK packaging, as separately recorded in the
layout report. Existing game scenes and rendered behavior were not exercised;
this task supplies their structural foundation.

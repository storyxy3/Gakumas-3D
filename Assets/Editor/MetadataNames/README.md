# Original metadata names

`Unity.QA.Recon.MetadataNames.CodeGen` is an Editor-only IL postprocessor. C# cannot
spell original compiler-generated names such as `<field>k__BackingField`, so
ILSpy emits escaped identifiers (`_003Cfield_003Ek__BackingField`). The
postprocessor restores those names in compiled metadata before IL2CPP consumes
it. It changes names and references, not method bodies or field order.

The allowed assemblies are the local `Packages/<assembly>` packages whose
manifest identifies `com.qa-recon.*`, plus
`Unity.RenderPipelines.Universal.Runtime`,
`Unity.RenderPipelines.Core.Runtime`, `Unity.Timeline`, `UnityEngine.UI`, and
`Cinemachine`. Their escaped identifiers are changed only when the corresponding
original type/member exists. Unescaped stock names are preserved. The Editor processor itself is never shipped in a player.

Each rename is checked against the corresponding original DummyDll metadata.
The declaring type and member kind must match, and a currently valid original
identifier takes precedence over its decoded spelling. The processor handles
nested types, fields, methods, properties, events, parameters, generic
parameters, type/member references, custom-attribute type arguments, method
overrides, IL operands, locals, and exception-handler types. It retains portable
PDBs. Definition collisions fail compilation instead of producing ambiguous
metadata. Generic method arity is part of the collision identity. A compiler log line beginning `QA_RECON_METADATA` records the number
of changed identifiers per assembly.

The project defaults to the Unity process working directory and can be set with
`QA_RECON_PROJECT`. Original DummyDlls default to `../work/il2cpp-3.5.3/DummyDll`
relative to the project and can be set with `QA_RECON_DUMMYDLL`.

The original DummyDlls must remain available during compilation. Missing input
for a selected assembly fails compilation. Set overrides before starting Unity
so the IL postprocessor process inherits them.

The API and symbol-handling pattern follow the installed
`Library/PackageCache/com.unity.burst@6bb9aca3ef38/Unity.Burst.CodeGen/BurstILPostProcessor.cs`.
The asmdef references that package's shipped `Unity.Burst.Cecil.dll` and uses
Unity's `Unity.CompilationPipeline.Common.ILPostProcessing` API. The namespace
sorts after Burst's `zzzUnity` processor. The actual player layout comparison,
not source-name spelling, remains the acceptance evidence.

Unity 6000.0.77's `UnityCodeGenHelpers.IsCodeGen` requires both a `Unity.`
assembly-name prefix and a `.CodeGen` suffix. That naming enables the
`Unity.CompilationPipeline.Common` reference and IL postprocessor discovery.
The prefix is an Editor discovery convention, not a game runtime assembly.

Unity's MonoScript source generator adds a second compiler data holder when the
original `<PrivateImplementationDetails>` is present as an escaped source type.
The generated registration blobs are retained under
`<QAReconstructionImplementationDetails>` with their references intact; the
reconstructed holder receives the game's exact original name. This extra build
type remains visible in layout reports. The processor also restores
leading-digit field names using the original dump evidence described below.

ILSpy represents a field-like event as a custom event and an `m_`-prefixed
backing field. The prefix is removed only when the original DummyDll has both
an event and a same-named field with the same delegate type, the reconstructed
field has that type, and the prefixed name is absent from the original fields.

ILSpy prefixes RVA-data field names starting with a digit.
`OriginalDumpFieldNames.cs` contains 32 exact assembly/type/field/type mappings
extracted from the original `dump.cs` for the current assembly closure and
records the dump's SHA-256. The ILPP applies a mapping only when the original
DummyDll also contains the target name (or the prefixed spelling) and the
declared type matches. The numeric prefix is handled before Unicode escape
decoding: `_53A6...` must not be decoded as the character U+53A6. Regenerate the
table after expanding the closure:

```bash
python3 Assets/Editor/MetadataNames/GenerateDumpNameOverrides.py
```

The second native-build investigation found the underscore already present in
both `Library/ScriptAssemblies/AmplifyOcclusion.Runtime.dll` and
`Library/Bee/artifacts/Android/ManagedStripped/AmplifyOcclusion.Runtime.dll`.
The original DummyDll's field was `53A6DC4C...`, while both rebuilt assemblies
had `_53A6DC4C...`. This localized the mismatch to the ILPP's earlier name gate,
before stripping or IL2CPP. The gate now accepts the evidence-backed original
target name; it no longer requires the prefixed name in original metadata.

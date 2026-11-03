using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Mono.Cecil;
using Mono.Cecil.Cil;
using Unity.CompilationPipeline.Common.Diagnostics;
using Unity.CompilationPipeline.Common.ILPostProcessing;

// After Burst's zzzUnity namespace: restore metadata names only after source-
// based IL transforms have finished. This assembly is excluded from players.
namespace zzzzQA.Recon.MetadataNames
{
    public sealed class OriginalMetadataNames : ILPostProcessor
    {
        private static readonly Regex Escape = new Regex("_([0-9A-Fa-f]{4})", RegexOptions.CultureInvariant);
        private static string Project => Environment.GetEnvironmentVariable("QA_RECON_PROJECT") ?? "/data/xy/gakumas/live-urp";
        private static string DummyDll => Environment.GetEnvironmentVariable("QA_RECON_DUMMYDLL") ?? "/data/xy/gakumas/work/il2cpp-3.5.3/DummyDll";
        private static string Decode(string name) => Escape.Replace(name, m => ((char)Convert.ToInt32(m.Groups[1].Value, 16)).ToString());

        private static bool IsOwned(string assembly)
        {
            if (assembly == "Unity.RenderPipelines.Universal.Runtime" || assembly == "Unity.RenderPipelines.Core.Runtime" || assembly == "Unity.Timeline") return true;
            var package = Path.Combine(Project, "Packages", assembly);
            var manifest = Path.Combine(package, "package.json");
            return File.Exists(Path.Combine(package, assembly + ".asmdef")) && File.Exists(manifest) &&
                File.ReadAllText(manifest).Contains("com.qa-recon.");
        }

        public override ILPostProcessor GetInstance() => new OriginalMetadataNames();
        public override bool WillProcess(ICompiledAssembly assembly) => IsOwned(assembly.Name);

        private sealed class Names
        {
            public readonly HashSet<string> Fields = new HashSet<string>();
            public readonly HashSet<string> Methods = new HashSet<string>();
            public readonly HashSet<string> Properties = new HashSet<string>();
            public readonly HashSet<string> Events = new HashSet<string>();
            public readonly HashSet<string> Parameters = new HashSet<string>();
            public readonly HashSet<string> GenericParameters = new HashSet<string>();
        }

        private sealed class ReferenceResolver : DefaultAssemblyResolver
        {
            private readonly Dictionary<string, string> paths = new Dictionary<string, string>();
            private readonly Dictionary<string, AssemblyDefinition> loaded = new Dictionary<string, AssemblyDefinition>();
            public ReferenceResolver(IEnumerable<string> references)
            {
                foreach (var path in references)
                {
                    paths[Path.GetFileNameWithoutExtension(path)] = path;
                    AddSearchDirectory(Path.GetDirectoryName(Path.GetFullPath(path)));
                }
            }
            public override AssemblyDefinition Resolve(AssemblyNameReference name)
            {
                if (loaded.TryGetValue(name.Name, out var found)) return found;
                if (!paths.TryGetValue(name.Name, out var path)) return base.Resolve(name);
                found = AssemblyDefinition.ReadAssembly(path, new ReaderParameters { AssemblyResolver = this });
                loaded.Add(name.Name, found);
                return found;
            }
            protected override void Dispose(bool disposing)
            {
                foreach (var assembly in loaded.Values) assembly.Dispose();
                base.Dispose(disposing);
            }
        }

        private sealed class Rewriter
        {
            private readonly Dictionary<string, Dictionary<string, Names>> originals = new Dictionary<string, Dictionary<string, Names>>();
            public int Changes;

            private static IEnumerable<TypeDefinition> Types(IEnumerable<TypeDefinition> roots)
            {
                foreach (var type in roots)
                {
                    yield return type;
                    foreach (var nested in Types(type.NestedTypes)) yield return nested;
                }
            }

            private Dictionary<string, Names> Original(string assembly)
            {
                if (originals.TryGetValue(assembly, out var found)) return found;
                found = new Dictionary<string, Names>();
                originals.Add(assembly, found);
                if (!IsOwned(assembly)) return found;
                var path = Path.Combine(DummyDll, assembly + ".dll");
                if (!File.Exists(path)) throw new FileNotFoundException("Original DummyDll is required to restore metadata names", path);
                using (var source = AssemblyDefinition.ReadAssembly(path))
                {
                    foreach (var type in Types(source.MainModule.Types))
                    {
                        var names = new Names();
                        foreach (var field in type.Fields) names.Fields.Add(field.Name);
                        foreach (var method in type.Methods)
                        {
                            names.Methods.Add(method.Name);
                            foreach (var parameter in method.Parameters) names.Parameters.Add(parameter.Name);
                            foreach (var parameter in method.GenericParameters) names.GenericParameters.Add(parameter.Name);
                        }
                        foreach (var property in type.Properties) names.Properties.Add(property.Name);
                        foreach (var ev in type.Events) names.Events.Add(ev.Name);
                        foreach (var parameter in type.GenericParameters) names.GenericParameters.Add(parameter.Name);
                        found.Add(type.FullName, names);
                    }
                }
                return found;
            }

            private static string AssemblyName(TypeReference type)
            {
                while (type is TypeSpecification specification) type = specification.ElementType;
                while (type.DeclaringType != null) type = type.DeclaringType;
                if (type.Scope is AssemblyNameReference reference) return reference.Name;
                if (type.Scope is ModuleDefinition module) return module.Assembly.Name.Name;
                return type.Module?.Assembly?.Name.Name;
            }

            private Names Owner(TypeReference type)
            {
                while (type is TypeSpecification specification) type = specification.ElementType;
                var assembly = AssemblyName(type);
                if (assembly == null) return null;
                Original(assembly).TryGetValue(Decode(type.FullName), out var names);
                return names;
            }

            private string Member(string name, HashSet<string> allowed)
            {
                // An existing original identifier always wins, including a
                // literal sequence such as _003C in the game's real source.
                if (allowed == null || allowed.Contains(name)) return name;
                var candidate = Decode(name);
                // ILSpy prefixes identifiers that originally start with a digit
                // (notably PrivateImplementationDetails SHA-named RVA fields).
                if (candidate.Length > 1 && candidate[0] == '_' && char.IsDigit(candidate[1]) && allowed.Contains(candidate.Substring(1)))
                    candidate = candidate.Substring(1);
                if (candidate == name || !allowed.Contains(candidate)) return name;
                Changes++;
                return candidate;
            }

            public void Type(TypeReference type)
            {
                if (type == null || type is GenericParameter) return;
                if (type is TypeSpecification specification)
                {
                    Type(specification.ElementType);
                    if (type is GenericInstanceType instance) foreach (var argument in instance.GenericArguments) Type(argument);
                    if (type is IModifierType modifier) Type(modifier.ModifierType);
                    return;
                }
                Type(type.DeclaringType);
                var assembly = AssemblyName(type);
                if (assembly == null) return;
                var original = Original(assembly);
                if (!original.ContainsKey(type.FullName) && original.ContainsKey(Decode(type.FullName)))
                {
                    type.Name = Decode(type.Name);
                    Changes++;
                }
            }

            private void Field(FieldReference field)
            {
                Type(field.DeclaringType);
                field.Name = Member(field.Name, Owner(field.DeclaringType)?.Fields);
                Type(field.FieldType);
            }

            private void Method(MethodReference method)
            {
                if (method is GenericInstanceMethod instance)
                {
                    Method(instance.ElementMethod);
                    foreach (var argument in instance.GenericArguments) Type(argument);
                    return;
                }
                Type(method.DeclaringType);
                var owner = Owner(method.DeclaringType);
                method.Name = Member(method.Name, owner?.Methods);
                Type(method.ReturnType);
                foreach (var parameter in method.Parameters)
                {
                    Type(parameter.ParameterType);
                    parameter.Name = Member(parameter.Name, owner?.Parameters);
                }
                foreach (var parameter in method.GenericParameters) parameter.Name = Member(parameter.Name, owner?.GenericParameters);
            }

            private void AttributeArgument(CustomAttributeArgument argument)
            {
                Type(argument.Type);
                if (argument.Value is TypeReference type) Type(type);
                if (argument.Value is CustomAttributeArgument[] elements) foreach (var element in elements) AttributeArgument(element);
            }

            private void Attributes(ICustomAttributeProvider provider)
            {
                foreach (var attribute in provider.CustomAttributes)
                {
                    Method(attribute.Constructor);
                    foreach (var argument in attribute.ConstructorArguments) AttributeArgument(argument);
                    foreach (var argument in attribute.Fields) AttributeArgument(argument.Argument);
                    foreach (var argument in attribute.Properties) AttributeArgument(argument.Argument);
                }
            }

            public void Run(ModuleDefinition module)
            {
                // Snapshot reference tables before definitions change their names.
                var typeReferences = module.GetTypeReferences().ToArray();
                var memberReferences = module.GetMemberReferences().ToArray();
                // Unity's MonoScript source generator emits a new compiler data
                // holder, independent of the one reconstructed from the game.
                // Keep this build-only data in a separate type so the original
                // holder can recover its exact name without a type collision.
                var compilerDetails = module.Types.FirstOrDefault(t => t.Name == "<PrivateImplementationDetails>");
                if (compilerDetails != null && module.Types.Any(t => t.Name == "_003CPrivateImplementationDetails_003E"))
                {
                    const string buildDetails = "<QAReconstructionImplementationDetails>";
                    if (module.Types.Any(t => t.Name == buildDetails)) throw new InvalidOperationException("Build metadata holder already exists");
                    // Same-module references are normally TypeDefinitions;
                    // also update independent TypeRefs before the definition.
                    foreach (var reference in typeReferences)
                    {
                        var root = reference;
                        while (root is TypeSpecification specification) root = specification.ElementType;
                        while (root.DeclaringType != null) root = root.DeclaringType;
                        if (AssemblyName(root) == module.Assembly.Name.Name && root.Name == "<PrivateImplementationDetails>") root.Name = buildDetails;
                    }
                    compilerDetails.Name = buildDetails;
                    Changes++;
                }
                var definitions = Types(module.Types).ToArray();
                foreach (var type in typeReferences) Type(type);
                foreach (var member in memberReferences)
                {
                    if (member is MethodReference method) Method(method);
                    else if (member is FieldReference field) Field(field);
                }
                foreach (var type in definitions)
                {
                    Type(type);
                    Type(type.BaseType);
                    var owner = Owner(type);
                    Attributes(type);
                    foreach (var parameter in type.GenericParameters)
                    {
                        parameter.Name = Member(parameter.Name, owner?.GenericParameters);
                        foreach (var constraint in parameter.Constraints) Type(constraint.ConstraintType);
                    }
                    foreach (var implemented in type.Interfaces) Type(implemented.InterfaceType);
                    foreach (var field in type.Fields) { Field(field); Attributes(field); }
                    foreach (var property in type.Properties)
                    {
                        property.Name = Member(property.Name, owner?.Properties);
                        Type(property.PropertyType);
                        Attributes(property);
                    }
                    foreach (var ev in type.Events)
                    {
                        ev.Name = Member(ev.Name, owner?.Events);
                        Type(ev.EventType);
                        Attributes(ev);
                    }
                    foreach (var method in type.Methods)
                    {
                        Method(method);
                        Attributes(method);
                        Attributes(method.MethodReturnType);
                        foreach (var parameter in method.Parameters) Attributes(parameter);
                        foreach (var parameter in method.GenericParameters)
                            foreach (var constraint in parameter.Constraints) Type(constraint.ConstraintType);
                        foreach (var overridden in method.Overrides) Method(overridden);
                        if (!method.HasBody) continue;
                        foreach (var variable in method.Body.Variables) Type(variable.VariableType);
                        foreach (var handler in method.Body.ExceptionHandlers) Type(handler.CatchType);
                        foreach (var instruction in method.Body.Instructions)
                        {
                            if (instruction.Operand is MethodReference called) Method(called);
                            else if (instruction.Operand is FieldReference field) Field(field);
                            else if (instruction.Operand is TypeReference operand) Type(operand);
                        }
                    }
                }
                Attributes(module);
                Attributes(module.Assembly);
                // A compiler-added member can otherwise collide with an
                // explicitly reconstructed generated name. Fail compilation
                // instead of emitting ambiguous or invalid metadata.
                var duplicateType = definitions.GroupBy(t => t.FullName).FirstOrDefault(g => g.Count() > 1);
                if (duplicateType != null) throw new InvalidOperationException("Restored type name collision: " + duplicateType.Key);
                foreach (var type in definitions)
                {
                    var duplicateField = type.Fields.GroupBy(f => f.Name).FirstOrDefault(g => g.Count() > 1);
                    if (duplicateField != null) throw new InvalidOperationException("Restored field name collision: " + type.FullName + "." + duplicateField.Key);
                    var duplicateMethod = type.Methods.GroupBy(m => m.FullName + "``" + m.GenericParameters.Count).FirstOrDefault(g => g.Count() > 1);
                    if (duplicateMethod != null) throw new InvalidOperationException("Restored method signature collision: " + duplicateMethod.Key);
                }
            }
        }

        public override ILPostProcessResult Process(ICompiledAssembly compiledAssembly)
        {
            var diagnostics = new List<DiagnosticMessage>();
            if (!WillProcess(compiledAssembly)) return new ILPostProcessResult(null, diagnostics);
            try
            {
                var input = compiledAssembly.InMemoryAssembly;
                var hasSymbols = input.PdbData != null && input.PdbData.Length != 0;
                using (var resolver = new ReferenceResolver(compiledAssembly.References))
                using (var pe = new MemoryStream(input.PeData))
                using (var pdb = new MemoryStream(input.PdbData ?? new byte[0]))
                using (var assembly = AssemblyDefinition.ReadAssembly(pe, new ReaderParameters
                {
                    AssemblyResolver = resolver,
                    ReadSymbols = hasSymbols,
                    SymbolReaderProvider = hasSymbols ? new PortablePdbReaderProvider() : null,
                    SymbolStream = hasSymbols ? pdb : null
                }))
                {
                    var rewriter = new Rewriter();
                    rewriter.Run(assembly.MainModule);
                    if (rewriter.Changes == 0) return new ILPostProcessResult(null, diagnostics);
                    using (var output = new MemoryStream())
                    using (var symbols = new MemoryStream())
                    {
                        assembly.Write(output, new WriterParameters
                        {
                            WriteSymbols = hasSymbols,
                            SymbolWriterProvider = hasSymbols ? new PortablePdbWriterProvider() : null,
                            SymbolStream = hasSymbols ? symbols : null
                        });
                        Console.WriteLine($"QA_RECON_METADATA {compiledAssembly.Name}: restored {rewriter.Changes} metadata identifiers");
                        return new ILPostProcessResult(new InMemoryAssembly(output.ToArray(), symbols.ToArray()), diagnostics);
                    }
                }
            }
            catch (Exception exception)
            {
                diagnostics.Add(new DiagnosticMessage { DiagnosticType = DiagnosticType.Error,
                    MessageData = $"QA metadata name restoration failed for {compiledAssembly.Name}: {exception}" });
                return new ILPostProcessResult(null, diagnostics);
            }
        }
    }
}

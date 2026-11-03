using ICSharpCode.Decompiler;
using ICSharpCode.Decompiler.CSharp;
using ICSharpCode.Decompiler.Metadata;
using ICSharpCode.Decompiler.CSharp.Transforms;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
if(args[0]=="clean") { Cleaner.ConfigureBases(Environment.GetEnvironmentVariable("QA_RECON_PROJECT") ?? "/data/xy/gakumas/live-urp"); foreach(var dir in args.Skip(1)) Cleaner.Run(dir);return;}
if(args[0]=="settings") {foreach(var p in typeof(DecompilerSettings).GetProperties()) Console.WriteLine(p.Name);return;}
var settings=new DecompilerSettings(ICSharpCode.Decompiler.CSharp.LanguageVersion.CSharp9_0) {AutomaticProperties=false,AutomaticEvents=false,AsyncAwait=false,YieldReturn=false};
var decompiler=new CSharpDecompiler(args[0],settings);
decompiler.AstTransforms.Add(new EscapeInvalidIdentifiers());
using var pe=new PEFile(args[0]);
Directory.CreateDirectory(args[1]);
foreach(var handle in pe.Metadata.TypeDefinitions) {
 var td=pe.Metadata.GetTypeDefinition(handle);
 if(!td.GetDeclaringType().IsNil)continue;
 var name=pe.Metadata.GetString(td.Name);if(name=="<Module>")continue;
 var ns=pe.Metadata.GetString(td.Namespace);
 var path=Path.Combine(args[1],ns); Directory.CreateDirectory(path);
 File.WriteAllText(Path.Combine(path,name.Replace('`','_')+".cs"),(ns.Length>0 ? "namespace "+ns+" {\n" : "")+decompiler.DecompileAsString(handle)+(ns.Length>0 ? "\n}\n" : ""));
}

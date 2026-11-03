#!/usr/bin/env python3
"""Regenerate Unity local skeleton packages from Il2CppDumper DummyDll projects.
No game implementation is reconstructed. Raw ilspy projects are retained in .recon/raw.
"""
import argparse, json, os, pathlib, re, subprocess, time, xml.etree.ElementTree as ET
ROOT=pathlib.Path('/data/xy/gakumas')
DEFAULT_ROOTS=['vl-unity.Runtime','campus-submodule.Runtime','campus-submodule.Shader.Runtime','AmplifyOcclusion.Runtime','ActorAnimation.Runtime','ProFlare.Runtime','quaunity-volumetriclightbeam.Runtime','Uguiss.Runtime','Uguiss-Timeline.Runtime','UniTask','UniTask.Linq']
REGISTRY={'Octo','Cinemachine','Unity.Timeline','Unity.Burst','Unity.Burst.Unsafe','Unity.Collections','Unity.Mathematics','Unity.Animation.Rigging','UnityEngine.UI','Unity.TextMeshPro','Unity.VisualEffectGraph.Runtime','Unity.Profiling.Core','Unity.MemoryProfiler','Unity.RenderPipelines.Core.Runtime','Unity.RenderPipelines.Universal.Runtime','Unity.RenderPipeline.Universal.ShaderLibrary','Newtonsoft.Json'}
CUT=re.compile(r'^(Assembly-CSharp$|Firebase|Grpc|Google\.|Unity\.(Purchasing|Services|Notifications)|quaunity-(account|api\.|fire|inapp|integrity|userdata|master|image-storage)|Cysharp.Net.Http|Octo|octdata|octurl|OCTProto|protobuf|NJsonSchema|AngleSharp|UniWebView|VideoKit|NatML|FastAES|System\.)')
def builtin(n): return n=='Il2CppDummyDll' or n in {'mscorlib','netstandard','Microsoft.CSharp','Mono.Security','System'} or n.startswith(('System.','UnityEngine.')) and n!='UnityEngine.UI'
def clean_source(s):
    s=re.sub(r'\[(?:Il2CppDummyDll\.)?FieldOffset\(Offset = "(0x[0-9A-Fa-f]+)"\)\]',r'[System.Runtime.InteropServices.FieldOffset(\1)]',s)
    s=re.sub(r'^using Il2CppDummyDll;\s*\n','',s,flags=re.M)
    s=re.sub(r'^\s*\[(?:Il2CppDummyDll\.)?(?:Token|Address|FieldOffset|MetadataOffset|Attribute|AttributeAttribute)\([^\n]*\)\]\s*\n','\n',s,flags=re.M)
    # Metadata numeric enum constants must be explicitly typed in C# source.
    s=re.sub(r'\[StructLayout\((\d+)\)',r'[StructLayout((LayoutKind)\1)',s)
    # Some project-mode versions default to C#10; keep Unity's C#9 syntax.
    s=re.sub(r'^namespace ([\w.]+);\s*\n',r'namespace \1\n{\n',s,flags=re.M) + ('\n}\n' if re.search(r'^namespace [\w.]+;',s,re.M) else '')
    return s

def main():
    p=argparse.ArgumentParser(description=__doc__);p.add_argument('--project',type=pathlib.Path,default=ROOT/'live-urp');p.add_argument('--dummy',type=pathlib.Path,default=ROOT/'work/il2cpp-3.5.3/DummyDll');p.add_argument('--roots',nargs='*',default=DEFAULT_ROOTS);p.add_argument('--refresh',action='store_true');a=p.parse_args()
    raw=a.project/'.recon/raw'; raw.mkdir(parents=True,exist_ok=True)
    cutfile=a.project/'Tools/closure-cuts.json'
    policy=json.loads(cutfile.read_text()) if cutfile.exists() else {}
    env=dict(os.environ,DOTNET_ROOT='/data/xy/.toolchains/dotnet-8',DOTNET_ROLL_FORWARD='Major',QA_RECON_PROJECT=str(a.project))
    subprocess.run(['/data/xy/.toolchains/dotnet-8/dotnet','build',str(a.project/'Tools/SkeletonMetadata'),'-o',str(a.project/'.recon/metadata-tool'),'--nologo','-v','quiet'],env=env,check=True)
    queue=list(a.roots); seen={};cuts={}
    while queue:
        asm=queue.pop(0)
        if asm in seen:continue
        d=raw/asm; proj=d/(asm+'.csproj')
        if a.refresh or not proj.exists():
            if d.exists():
                archive=a.project/'.recon/raw-archive'/str(time.time_ns());archive.mkdir(parents=True,exist_ok=True);d.rename(archive/asm)
            d.mkdir(parents=True,exist_ok=True)
            subprocess.run(['/data/xy/.toolchains/ilspycmd/ilspycmd','--disable-updatecheck','-lv','CSharp9_0','-p','-o',str(d),str(a.dummy/(asm+'.dll'))],env=env,check=True,stdout=subprocess.DEVNULL)
        refs=[r.attrib['Include'] for r in ET.parse(proj).iter('Reference') if r.attrib['Include']!='Il2CppDummyDll']
        seen[asm]=refs
        for ref in refs:
            if builtin(ref) or ref in REGISTRY:continue
            if CUT.match(ref):cuts.setdefault(asm,[]).append(ref);continue
            if (a.dummy/(ref+'.dll')).exists():queue.append(ref)
    for asm,refs in seen.items():
        d=raw/asm
        full=a.project/'.recon/complete'/asm
        if a.refresh or not full.exists():
            subprocess.run(['/data/xy/.toolchains/dotnet-8/dotnet',str(a.project/'.recon/metadata-tool/SkeletonMetadata.dll'),str(a.dummy/(asm+'.dll')),str(full)],env=env,check=True)
        d=full
        out=a.project/'Packages'/asm;out.mkdir(parents=True,exist_ok=True)
        manifest={'name':'com.qa-recon.'+asm.lower().replace('_','-'),'version':'0.0.1','displayName':asm+' (DummyDll skeleton)','unity':'6000.0'}
        (out/'package.json').write_text(json.dumps(manifest,indent=2)+'\n')
        reference_cuts={r for c in policy.get('reference_only_cuts',[]) if c['assembly']==asm for r in c['references']}
        asmrefs=[r for r in refs if not builtin(r) and r not in cuts.get(asm,[]) and r not in reference_cuts]
        (out/(asm+'.asmdef')).write_text(json.dumps({'name':asm,'references':asmrefs,'allowUnsafeCode':True,'autoReferenced':True},indent=2)+'\n')
        for src in sorted(d.rglob('*.cs')):
            if src.parent.name=='Properties' or src.name.startswith(('UnitySourceGeneratedAssemblyMonoScriptTypes','__JobReflectionRegistrationOutput__')):continue
            rel=src.relative_to(d)
            if str(rel).startswith('Campus.live/'):rel=pathlib.Path(str(rel).replace('Campus.live/','Campus.live_lowercase/',1))
            dest=out/'Runtime'/rel;dest.parent.mkdir(parents=True,exist_ok=True)
            source=clean_source(src.read_text())
            if asm=='vl-unity.Runtime' and src.name=='VLActorRigFurisodeJob.cs':
                # IL signature names Unity.Animation.Rigging; newer Mathematics also defines this short name.
                source=re.sub(r'\bAffineTransform\b','global::UnityEngine.Animations.Rigging.AffineTransform',source)
            for c in policy.get('source_cuts',[]):
                if c['assembly']==asm and c['file']==str(src.relative_to(d)):
                    for r in c['replacements']:
                        source=re.sub(r['pattern'],r['replacement'],source,flags=re.M if 'M' in r.get('flags','') else 0)
            dest.write_text(source)
        assembly_info=raw/asm/'Properties/AssemblyInfo.cs'
        if assembly_info.exists():
            dest=out/'Runtime/Properties/AssemblyInfo.cs';dest.parent.mkdir(parents=True,exist_ok=True);dest.write_text(clean_source(assembly_info.read_text()))
        print(asm, len(list(d.rglob('*.cs'))),'files',flush=True)
    subprocess.run(['/data/xy/.toolchains/dotnet-8/dotnet',str(a.project/'.recon/metadata-tool/SkeletonMetadata.dll'),'clean']+[str(a.project/'Packages'/asm/'Runtime') for asm in seen],env=env,check=True)
    (a.project/'.recon/closure.json').write_text(json.dumps({'assemblies':seen,'cuts':cuts},indent=2)+'\n')
if __name__=='__main__':main()

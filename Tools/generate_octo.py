#!/usr/bin/env python3
"""Regenerate Octo skeleton while preserving its rendering-facing inheritance.

Octo.AssetKeeper is a MonoBehaviour base of CampusAssetKeeperBase<T>. Keeping
Octo's definitions preserves that base and the asset/scene-loader field types.
Only metadata serializer/crypto edges are cut; no network or crypto body is
implemented. Run the shared compiler cleanup after this generator.
"""
import argparse
import importlib.util
import json
import os
from pathlib import Path
import re
import subprocess
import xml.etree.ElementTree as ET


def main():
    p = argparse.ArgumentParser(description=__doc__)
    p.add_argument('--project', type=Path, default=Path(__file__).resolve().parents[1])
    p.add_argument('--dummy', type=Path, default=Path('/data/xy/gakumas/work/il2cpp-3.5.3/DummyDll'))
    p.add_argument('--refresh', action='store_true')
    a = p.parse_args()
    spec = importlib.util.spec_from_file_location('skeleton_cleanup', a.project / 'Tools/skeleton_from_dummydll.py')
    cleanup = importlib.util.module_from_spec(spec)
    spec.loader.exec_module(cleanup)
    env = dict(os.environ, DOTNET_ROOT='/data/xy/.toolchains/dotnet-8', DOTNET_ROLL_FORWARD='Major')
    raw = a.project / '.recon/raw/Octo'
    full = a.project / '.recon/complete/Octo'
    if a.refresh or not (raw / 'Octo.csproj').exists():
        raw.mkdir(parents=True, exist_ok=True)
        subprocess.run(['/data/xy/.toolchains/ilspycmd/ilspycmd', '--disable-updatecheck', '-p', '-lv', 'CSharp9_0', '-o', str(raw), str(a.dummy / 'Octo.dll')], env=env, check=True)
    if a.refresh or not full.exists():
        subprocess.run(['/data/xy/.toolchains/dotnet-8/dotnet', str(a.project / '.recon/metadata-tool/SkeletonMetadata.dll'), str(a.dummy / 'Octo.dll'), str(full)], env=env, check=True)
    out = a.project / 'Packages/Octo'
    out.mkdir(parents=True, exist_ok=True)
    refs = [n.attrib['Include'] for n in ET.parse(raw / 'Octo.csproj').iter('Reference')]
    cuts = {'OCTProtoSerializer', 'octdata', 'protobuf-net', 'FastAES'}
    references = [r for r in refs if r not in cuts and not cleanup.builtin(r)]
    (out / 'package.json').write_text(json.dumps({'name':'com.qa-recon.octo','version':'0.0.1','displayName':'Octo (DummyDll skeleton)','unity':'6000.0'}, indent=2)+'\n')
    (out / 'Octo.asmdef').write_text(json.dumps({'name':'Octo','references':references,'allowUnsafeCode':True,'autoReferenced':True}, indent=2)+'\n')
    substitutions = [
        # Whole namespace imports contain no type declaration. Actual type uses
        # below are limited to metadata serialization signatures/fields.
        (r'^using ProtoBuf;\n', '', 'remove excluded protobuf namespace import'),
        (r'\bData\.State\b', 'int /* TODO(qa-recon): octdata Octo.Proto.Data.State (Int32) excluded. */', 'Octo.Data.Item.state: Data.State -> int'),
        (r'\bData (?=(?:data|octodata)\b)', 'object /* TODO(qa-recon): octdata Octo.Proto.Data excluded. */ ', 'Octo.Proto.Data parameter -> object'),
        (r'\bDatabase\b', 'object /* TODO(qa-recon): octdata Octo.Proto.Database excluded. */', 'Octo.Proto.Database signature -> object'),
        (r'\bProtoWriter\b', 'object /* TODO(qa-recon): protobuf-net ProtoBuf.ProtoWriter excluded. */', 'ProtoBuf.ProtoWriter parameter -> object'),
        (r'\bOCTProtoSerializer (?=_serializer\b)', 'object /* TODO(qa-recon): OCTProtoSerializer excluded. */ ', 'Octo.Proto.StaticSerializer._serializer -> object'),
        (r'\bFastAES (?=_fastAes\b)', 'object /* TODO(qa-recon): FastAES excluded. */ ', 'Octo.Data.AESCrypt._fastAes -> object'),
    ]
    applied = []
    for source in sorted(full.rglob('*.cs')):
        if source.parent.name == 'Properties':
            continue
        relative = source.relative_to(full)
        text = cleanup.clean_source(source.read_text())
        # External Database is only used in DataManager; do not rename an
        # unrelated identifier in future generated Octo types.
        for pattern, replacement, reason in substitutions:
            if pattern == r'\bDatabase\b' and relative.as_posix() != 'Octo.Data/DataManager.cs':
                continue
            declarations = [line.strip() for line in text.splitlines() if re.search(pattern, line + '\n', flags=re.M)]
            text, count = re.subn(pattern, replacement, text, flags=re.M)
            if count:
                applied.append({'file':relative.as_posix(), 'reason':reason, 'occurrences':count, 'original_declarations':declarations})
        target = out / 'Runtime' / relative
        target.parent.mkdir(parents=True, exist_ok=True)
        target.write_text(text)
    assembly_info = raw / 'Properties/AssemblyInfo.cs'
    if assembly_info.exists():
        destination = out / 'Runtime/Properties/AssemblyInfo.cs'
        destination.parent.mkdir(parents=True, exist_ok=True)
        destination.write_text(cleanup.clean_source(assembly_info.read_text()))
    subprocess.run(['/data/xy/.toolchains/dotnet-8/dotnet', str(a.project / '.recon/metadata-tool/SkeletonMetadata.dll'), 'clean', str(out / 'Runtime')], env=env, check=True)
    manifest = json.dumps({'assembly':'Octo','original_references':refs,'cut_references':sorted(cuts),'source_cuts':applied},indent=2)+'\n'
    (a.project / '.recon/octo-cuts.json').write_text(manifest)
    (a.project / 'Tools/octo-cuts.json').write_text(manifest)
    print(f'Octo: {len(list(full.rglob("*.cs")))} source files; {len(applied)} targeted source cuts; renderer inheritance retained.')

if __name__ == '__main__':
    main()

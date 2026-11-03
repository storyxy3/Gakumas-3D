#!/usr/bin/env python3
"""Summarize real Il2CppDumper output; never substitutes managed estimates for native offsets."""
import collections
import hashlib
import json
from pathlib import Path
import re
import subprocess

ROOT = Path(__file__).resolve().parents[1]
GAME = ROOT.parent / 'work/il2cpp-3.5.3/dump.cs'
DUMP = ROOT / '.recon/live-dump/dump.cs'
NATIVE = ROOT / 'Library/Bee/Android/Prj/IL2CPP/Gradle/unityLibrary/src/main'


def sha(path):
    h = hashlib.sha256()
    with path.open('rb') as f:
        for block in iter(lambda: f.read(1024 * 1024), b''):
            h.update(block)
    return h.hexdigest()


def compare(assemblies, output, json_output):
    regex = '^(?:' + '|'.join(re.escape(a) for a in sorted(assemblies)) + ')$'
    subprocess.run(['python3', str(ROOT / 'Tools/dump_type_diff.py'), '--layout', str(GAME), str(DUMP), regex,
                    '--output', str(output), '--json', str(json_output)], check=True)


def main():
    selected = json.loads((ROOT / 'Tools/layout-assemblies.json').read_text())
    detail = ROOT / '.recon/layout-detail.md'
    compare([a + '.dll' for a in selected], detail, ROOT / '.recon/layout.json')
    images = []
    with DUMP.open() as f:
        for line in f:
            m = re.match(r'// Image \d+: (\S+) - ', line)
            if m:
                images.append(m[1])
            elif line.strip():
                break
    compare(images, ROOT / 'LAYOUT-ALL.md', ROOT / '.recon/layout-all.json')
    result = json.loads((ROOT / '.recon/layout.json').read_text())
    closure = set(json.loads((ROOT / 'Tools/closure.json').read_text())['assemblies']) | {'Octo'}
    summary = collections.Counter()
    instance_offsets, static_offsets = [], []
    for item in result['types']:
        if item['assembly'][:-4] in closure:
            summary[item['status']] += 1
        before, after = item['old'], item['new']
        if before and after:
            old_fields = {f['name']: f for f in before['fields']}
            for field in after['fields']:
                old_field = old_fields.get(field['name'])
                if old_field and old_field['offset'] != field['offset']:
                    target = instance_offsets if field['storage'] == 'instance' else static_offsets
                    target.append((item['assembly'], item['type'], field['name']))
    build_log = (ROOT / '.recon/build.log').read_text(errors='replace')
    build_status = re.findall(r'LIVE_BUILD [^\r\n]+', build_log)
    import_log = (ROOT / '.recon/import-success.log').read_text(errors='replace')
    binaries = {'libil2cpp.so': NATIVE / 'jniLibs/arm64-v8a/libil2cpp.so',
                'global-metadata.dat': NATIVE / 'assets/bin/Data/Managed/Metadata/global-metadata.dat'}
    fork = subprocess.check_output(['git', '-C', str(ROOT.parent / 'work/urp14-fork-live'), 'rev-parse', 'HEAD'], text=True).strip()
    project = subprocess.check_output(['git', '-C', str(ROOT), 'rev-parse', 'HEAD'], text=True).strip()
    lines = ['# Android native layout acceptance', '',
             'Unity **6000.0.77f1**, Android **IL2CPP ARM64**, compared with APK **3.5.3**.', '',
             f'- Editor batchmode import: {"successful" if "Exiting batchmode successfully" in import_log else "not established"}; compiler/postprocessor errors: ' + str(len(re.findall(r'error CS\d+|error QA metadata', import_log))) + '.',
             '- Native IL2CPP conversion, C++ compilation and linking produced the library and metadata below. Il2CppDumper recovered metadata version 31.',
             '- Unity build result: `' + (build_status[-1] if build_status else 'unreported') + '`.',
             '- Gradle packaging fails at `:unityLibrary:lintVitalAnalyzeRelease`, parsing SDK version `37.0`. The requested native artifacts are complete; no successful APK packaging is claimed.',
             '- No tests were authored or run. No deployment was performed.', '',
             '## Rendering-closure result', '',
             'Local skeleton assemblies including Octo: ' + ', '.join(f'**{summary[s]} {s}**' for s in ['matching', 'mismatching', 'indeterminate', 'missing', 'extra']) + '.', '',
             f'Across the local skeleton, registry and fork assemblies below, **{len(set((a,t) for a,t,_ in instance_offsets))} types** have differing offsets for same-named declared instance fields; **{len(set((a,t) for a,t,_ in static_offsets))} types** have differing static-storage offsets. Other mismatches include field names/types/order, constants, interface/base declarations and explicit closure cuts. Inherited storage is evaluated in each declaring type.', '',
             'Generic definitions with unavailable concrete offsets remain indeterminate. Compiler/linker-generated additions and stripping differences remain visible. This is a structural skeleton, not evidence of reconstructed runtime behavior.', '',
             '[LAYOUT-ALL.md](LAYOUT-ALL.md) covers **every assembly present in the rebuilt native metadata**, including engine and framework classes. The detailed rendering table below lists every matching, mismatching, missing, extra or indeterminate type in the selected closure.', '',
             '## Build provenance', '', f'- Project source/report checkpoint: `{project}`.', f'- URP/Core fork: `{fork}`.',
             '- Rebuild: `bash Tools/build_android.sh`; dump and compare: `bash Tools/dump_layout.sh`.',
             '- Input DummyDll hashes: [Tools/skeleton-inputs.json](Tools/skeleton-inputs.json). Package evidence: [PACKAGES.md](PACKAGES.md). Exact dependency cuts and compiler repairs: [CLOSURE.md](CLOSURE.md).', '']
    provenance = {'project_commit': project, 'fork_commit': fork, 'artifacts': {}}
    for name, path in binaries.items():
        digest = sha(path)
        lines += [f'- `{name}`: `{path.relative_to(ROOT)}`; SHA-256 `{digest}`.']
        provenance['artifacts'][name] = {'path': str(path.relative_to(ROOT)), 'sha256': digest, 'size': path.stat().st_size}
    lines += ['', '## Types with remaining instance-offset differences', '']
    if instance_offsets:
        for a, t in sorted(set((a, t) for a, t, _ in instance_offsets)):
            lines.append(f'- `{a}` — `{t}`')
    else:
        lines.append('None among fields with exact matching names; field additions/removals/type changes are still reported below.')
    (ROOT / 'LAYOUT.md').write_text('\n'.join(lines) + '\n\n' + detail.read_text())
    (ROOT / 'Tools/build-artifacts.json').write_text(json.dumps(provenance, indent=2) + '\n')


if __name__ == '__main__':
    main()

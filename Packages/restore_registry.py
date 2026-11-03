#!/usr/bin/env python3
"""Restore the reviewed registry-source packages without test dependencies.

This is package preparation, not a validation/test runner. Sources are immutable
registry archives or the pinned Unity editor installation. See PACKAGES.md.
"""
import hashlib
import importlib.util
import io
import json
import os
from pathlib import Path
import shutil
import subprocess
import tarfile
import urllib.request

PACKAGES = Path(__file__).resolve().parent
EDITOR = Path('/data/xy/.toolchains/unity-6000.0.77f1/Editor/Data/Resources/PackageManager/BuiltInPackages')
VERSIONS = {'com.unity.animation.rigging': '1.4.0', 'com.unity.collections': '2.6.8', 'com.unity.timeline': '1.8.12', 'com.unity.cinemachine': '2.6.0'}
OMIT = {'Tests', 'Tests~', 'Tests.meta', 'Tests~.meta', 'Samples~', 'Samples~.meta', 'Documentation~', 'Documentation~.meta', 'DocCodeExamples', 'DocCodeExamples.meta', '.signature'}


def omit(name):
    return name in OMIT or any(x in name for x in ['.Tests', '.PerformanceTests', '.BurstCompatibilityGen'])


def copy_source(source, destination):
    if destination.exists():
        shutil.rmtree(destination)
    shutil.copytree(source, destination, ignore=lambda directory, names: [n for n in names if omit(n)])


def replace_once(path, before, after):
    source = path.read_text()
    if source.count(before) != 1:
        raise ValueError(f'Expected one source anchor in {path}: {before!r}')
    path.write_text(source.replace(before, after, 1))


def restore_ui_additions():
    source = EDITOR / 'com.unity.ugui'
    destination = PACKAGES / 'com.unity.ugui'
    copy_source(source, destination)
    graphic = destination / 'Runtime/UGUI/UI/Core/Graphic.cs'
    marker = '        protected bool useLegacyMeshGeneration { get; set; }'
    replace_once(graphic, marker, marker + '''

        // TODO(qa-recon): game UI addition; accessor bodies remain skeletons.
        // Game field offset 0xA4, after <useLegacyMeshGeneration>k__BackingField.
        [System.Runtime.CompilerServices.CompilerGenerated]
        private int _003CGraphicRebuildOrder_003Ek__BackingField;
        public int GraphicRebuildOrder
        {
            [System.Runtime.CompilerServices.CompilerGenerated]
            get { return default(int); }
            [System.Runtime.CompilerServices.CompilerGenerated]
            set { }
        }
''')
    registry = destination / 'Runtime/UGUI/UI/Core/CanvasUpdateRegistry.cs'
    marker = '    public interface ICanvasElement\n    {'
    replace_once(registry, marker, marker + '''
        // TODO(qa-recon): game default interface accessor, DummyDll body.
        int GraphicRebuildOrder { get { return default(int); } }
''')

    marker = '        private readonly IndexedSet<ICanvasElement> m_GraphicRebuildQueue = new IndexedSet<ICanvasElement>();'
    replace_once(registry, marker, marker + '''

        // TODO(qa-recon): game event storage; registration bodies are skeletons.
        [System.Runtime.CompilerServices.CompilerGenerated]
        private Action m_onLayoutComplete;
        public event Action onLayoutComplete
        {
            [System.Runtime.CompilerServices.CompilerGenerated]
            add { }
            [System.Runtime.CompilerServices.CompilerGenerated]
            remove { }
        }
''')
    marker = '        private static readonly Comparison<ICanvasElement> s_SortLayoutFunction = SortLayoutList;'
    replace_once(registry, marker, marker + '''
        // TODO(qa-recon): game comparer storage, no reconstructed initializer.
        private static readonly IComparer<ICanvasElement> s_SortGraphicComparer;
        private class GraphicSortComparer : IComparer<ICanvasElement>
        {
            public int Compare(ICanvasElement x, ICanvasElement y) { return default(int); }
            public GraphicSortComparer() { }
        }
''')


def strip_unused_tmp_player_storage():
    path = PACKAGES / 'com.unity.ugui/Runtime/TMP/TMP_MaterialManager.cs'
    source = path.read_text()
    # These legacy APIs have no caller outside this source file in the
    # rendering closure, and none exists in the game DummyDll. Keep editor
    # behavior while reproducing the game's stripped player storage.
    for signature in [
        'public static Material GetStencilMaterial(Material baseMaterial, int stencilID)',
        'public static Material GetBaseMaterial(Material stencilMaterial)',
        'public static void AddMaskingMaterial(Material baseMaterial, Material stencilMaterial, int stencilID)',
        'public static void ReleaseBaseMaterial(Material baseMaterial)',
    ]:
        anchor = '        ' + signature + '\n'
        if source.count(anchor) != 1:
            raise ValueError(f'Expected one TMP member: {signature}')
        start = source.index(anchor)
        end = source.index('\n        }', start) + len('\n        }')
        source = source[:start] + '#if UNITY_EDITOR\n' + source[start:end] + '\n#endif' + source[end:]
    for declaration in ['public Material baseMaterial;', 'public int stencilID;']:
        anchor = '            ' + declaration
        if source.count(anchor) != 1:
            raise ValueError(f'Expected one TMP field: {declaration}')
        source = source.replace(anchor, '#if UNITY_EDITOR\n' + anchor + '\n#endif', 1)
    # ListMaterials is a debug-only legacy API; its calls and definition must
    # share the editor condition of the storage it inspects.
    source = source.replace('#if TMP_DEBUG_MODE', '#if UNITY_EDITOR && TMP_DEBUG_MODE')
    path.write_text(source)


def restore_cinemachine_additions():
    package = PACKAGES / 'com.unity.cinemachine'
    lens = package / 'Runtime/Core/LensSettings.cs'
    marker = '        public float Dutch;'
    replace_once(lens, marker, marker + '''

        // TODO(qa-recon): game lens storage; camera conversion remains unknown.
        [Tooltip("Focal Length for physical camera")]
        public float FocalLength;

        public void VerticalFOVToFocalLength(float fov) { }
        public float FocalLengthToVerticalFOV() { return default(float); }
''')
    brain = package / 'Runtime/Behaviours/CinemachineBrain.cs'
    marker = '        CinemachineBlend mCurrentLiveCameras = new CinemachineBlend(null, null, null, 0, 0);'
    replace_once(brain, marker, marker + '''
        // TODO(qa-recon): game static storage; leave initializer unset.
        private static readonly AnimationCurve mDefaultLinearAnimationCurve;
''')
    shot = package / 'Runtime/Timeline/CinemachineShotPlayable.cs'
    marker = '        public CinemachineVirtualCameraBase VirtualCamera;'
    replace_once(shot, marker, marker + '''
        // TODO(qa-recon): game shot storage and lifecycle signatures only.
        public UnityEngine.Animator CameraAnimator;
        public override void OnGraphStart(Playable playable) { }
        public override void OnBehaviourPlay(Playable playable, FrameData info) { }
        public override void OnBehaviourPause(Playable playable, FrameData info) { }
''')


def restore_timeline_additions():
    project = PACKAGES.parent
    raw = project / '.recon/complete/Unity.Timeline'
    helper = project / '.recon/metadata-tool/SkeletonMetadata.dll'
    env = dict(os.environ, DOTNET_ROOT='/data/xy/.toolchains/dotnet-8', DOTNET_ROLL_FORWARD='Major')
    dotnet = '/data/xy/.toolchains/dotnet-8/dotnet'
    subprocess.run([dotnet, str(helper), str(project.parent / 'work/il2cpp-3.5.3/DummyDll/Unity.Timeline.dll'), str(raw)], env=env, check=True)
    spec = importlib.util.spec_from_file_location('skeleton_from_dummydll', project / 'Tools/skeleton_from_dummydll.py')
    cleaner = importlib.util.module_from_spec(spec)
    spec.loader.exec_module(cleaner)
    destination = PACKAGES / 'com.unity.timeline/Runtime/QualiArts/_Skeleton'
    destination.mkdir(parents=True, exist_ok=True)
    # Full top-level inventory: TitanTrackBase is the only game-added type.
    # TrackAsset already exposes its internal virtual GetSequenceTime hook.
    source = raw / 'Titan/TitanTrackBase.cs'
    (destination / 'TitanTrackBase.cs').write_text(cleaner.clean_source(source.read_text()))
    subprocess.run([dotnet, str(helper), 'clean', str(destination)], env=env, check=True)
    # Unreferenced stock storage, absent from game metadata. No executable
    # statement in 1.8.12 reads or writes this field.
    replace_once(PACKAGES / 'com.unity.timeline/Runtime/Animation/AnimationOutputWeightProcessor.cs',
                 '        AnimationMotionXToDeltaPlayable m_MotionXPlayable;\n',
                 '        // Game metadata omits the unused stock m_MotionXPlayable field.\n')


def restore():
    evidence = {}
    for name, version in VERSIONS.items():
        url = f'https://packages.unity.com/{name}/-/{name}-{version}.tgz'
        data = urllib.request.urlopen(url).read()
        destination = PACKAGES / name
        if destination.exists():
            shutil.rmtree(destination)
        destination.mkdir()
        with tarfile.open(fileobj=io.BytesIO(data), mode='r:gz') as archive:
            for member in archive.getmembers():
                parts = Path(member.name).parts[1:]
                if not parts or any(omit(part) for part in parts):
                    continue
                member.name = str(Path(*parts))
                archive.extract(member, destination, filter='data')
        metadata_file = destination / 'package.json'
        metadata = json.loads(metadata_file.read_text())
        removed = {key: value for key, value in metadata.get('dependencies', {}).items() if 'test-framework' in key or 'nunit' in key}
        metadata['dependencies'] = {key: value for key, value in metadata.get('dependencies', {}).items() if key not in removed}
        metadata.pop('samples', None)
        metadata_file.write_text(json.dumps(metadata, indent=2) + '\n')
        evidence[name] = {'version': version, 'source': url, 'sha256': hashlib.sha256(data).hexdigest(), 'removedTestDependencies': removed}

    name = 'com.unity.visualeffectgraph'
    source, destination = EDITOR / name, PACKAGES / name
    if destination.exists():
        shutil.rmtree(destination)
    destination.mkdir()
    shutil.copytree(source / 'Runtime', destination / 'Runtime')
    for filename in ['Runtime.meta', 'Unity.VisualEffectGraph.Runtime.asmdef', 'Unity.VisualEffectGraph.Runtime.asmdef.meta', 'LICENSE.md']:
        if (source / filename).exists():
            shutil.copy2(source / filename, destination / filename)
    metadata = json.loads((source / 'package.json').read_text())
    metadata['dependencies'] = {'com.unity.timeline': '1.8.12', 'com.unity.ugui': '2.0.0'}
    metadata.pop('samples', None)
    (destination / 'package.json').write_text(json.dumps(metadata, indent=2) + '\n')
    asmdef_file = destination / 'Unity.VisualEffectGraph.Runtime.asmdef'
    asmdef = json.loads(asmdef_file.read_text())
    asmdef['references'] = ['Unity.Timeline', 'UnityEngine.UI']
    asmdef_file.write_text(json.dumps(asmdef, indent=2) + '\n')
    evidence[name] = {'version': metadata['version'], 'source': str(source), 'scope': 'Runtime only; no graph authoring/editor assembly', 'asmdefAdaptation': 'Unity.ugui -> UnityEngine.UI; omit absent optional Unity.InputSystem'}
    restore_timeline_additions()
    evidence['com.unity.timeline']['gameAdditions'] = ['Titan.TitanTrackBase (DummyDll skeleton)']
    evidence['com.unity.timeline']['omittedUnusedStorage'] = ['AnimationOutputWeightProcessor.m_MotionXPlayable (declaration only in stock source; absent in game)']
    restore_ui_additions()
    strip_unused_tmp_player_storage()
    evidence['com.unity.ugui'] = {'version': '2.0.0', 'source': str(EDITOR / 'com.unity.ugui'), 'gameAdditions': ['Graphic.GraphicRebuildOrder and backing field', 'ICanvasElement.GraphicRebuildOrder default interface accessor', 'CanvasUpdateRegistry.onLayoutComplete event and backing field', 'CanvasUpdateRegistry.s_SortGraphicComparer and GraphicSortComparer']}
    evidence['com.unity.ugui']['editorOnlyLegacyStorage'] = ['TMP_MaterialManager.MaskingMaterial.baseMaterial', 'TMP_MaterialManager.MaskingMaterial.stencilID']
    restore_cinemachine_additions()
    evidence['com.unity.cinemachine']['gameAdditions'] = ['LensSettings.FocalLength and conversion signatures', 'CinemachineBrain.mDefaultLinearAnimationCurve', 'CinemachineShotPlayable.CameraAnimator and lifecycle signatures']
    (PACKAGES / 'registry-sources.json').write_text(json.dumps(evidence, indent=2) + '\n')


if __name__ == '__main__':
    restore()

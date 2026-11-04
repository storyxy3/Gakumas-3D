"""Install the real source of the open-source libraries the game ships (in place of their DummyDll skeleton packages) into
live-urp/Packages, under the game's assembly names. Versions were chosen by scripts/thirdparty_version_match.py and are confirmed by
the per-method code comparison after building. Sources come from the GitHub tag tarballs cached in work/thirdparty/.
  UniRx 7.1.0 (neuecc/UniRx)              -> Packages/UniRx            (assembly UniRx)
  UniTask <tag> (Cysharp/UniTask)          -> Packages/UniTask          (assemblies UniTask, UniTask.Linq; External/* not shipped by the game)
  DOTween v1.2.420 (Demigiant/dotween)     -> Packages/DOTween          (assembly DOTween, Release build: no COMPATIBLE define)
                                           -> Packages/DOTween.Modules  (assembly DOTween.Modules)
  Coffee.UIParticle 4.2.x (mob-sakai/ParticleEffectForUGUI) -> Packages/Coffee.UIParticle
usage: install_thirdparty.py [--unitask TAG] [--coffee TAG]"""
import os, sys, json, shutil, re
ROOT = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))
TP = os.path.join(ROOT, "work/thirdparty"); PK = os.path.join(ROOT, "live-urp/Packages")
sys.path.insert(0, os.path.dirname(os.path.abspath(__file__)))
from thirdparty_version_match import fetch


def reset(pkg, display, version, source):
    d = os.path.join(PK, pkg)
    if os.path.isdir(d): shutil.rmtree(d)
    os.makedirs(d)
    json.dump({"name": "com.thirdparty." + pkg.lower(), "version": version, "displayName": display, "unity": "6000.0",
               "description": "Original source: " + source}, open(os.path.join(d, "package.json"), "w"), indent=2)
    return d


def copytree(src, dst, skip=()):
    for dp, dn, fn in os.walk(src):
        rel = os.path.relpath(dp, src)
        if any(rel == s or rel.startswith(s + os.sep) for s in skip): continue
        dn[:] = [x for x in dn if x not in ("Tests", "Editor", "Examples")]
        os.makedirs(os.path.join(dst, rel), exist_ok=True)
        for f in fn:
            if f.endswith((".cs", ".asmdef")): shutil.copy2(os.path.join(dp, f), os.path.join(dst, rel, f))


def main():
    unitask = sys.argv[sys.argv.index("--unitask") + 1] if "--unitask" in sys.argv else "2.5.10"
    coffee = sys.argv[sys.argv.index("--coffee") + 1] if "--coffee" in sys.argv else "4.2.2"
    # UniRx
    src = os.path.join(fetch("neuecc/UniRx", "7.1.0"), "Assets/Plugins/UniRx/Scripts")
    d = reset("UniRx", "UniRx", "7.1.0", "https://github.com/neuecc/UniRx/tree/7.1.0/Assets/Plugins/UniRx/Scripts")
    copytree(src, os.path.join(d, "Runtime"))
    # UniTask (+ Linq)
    src = os.path.join(fetch("Cysharp/UniTask", unitask), "src/UniTask/Assets/Plugins/UniTask/Runtime")
    d = reset("UniTask", "UniTask", unitask, f"https://github.com/Cysharp/UniTask/tree/{unitask}/src/UniTask/Assets/Plugins/UniTask/Runtime")
    copytree(src, os.path.join(d, "Runtime"), skip=("External",))
    if os.path.isdir(os.path.join(PK, "UniTask.Linq")): shutil.rmtree(os.path.join(PK, "UniTask.Linq"))   # UniTask.Linq.asmdef ships inside Runtime/Linq
    # DOTween core (files listed in the Release csproj) + Modules
    root = fetch("Demigiant/dotween", "v1.2.420")
    core = os.path.join(root, "_DOTween.Assembly/DOTween")
    proj = os.path.join(core, "DOTween.csproj")
    files = re.findall(r'<Compile Include="([^"]+\.cs)"', open(proj).read()) if os.path.exists(proj) else None
    d = reset("DOTween", "DOTween", "1.2.420", "https://github.com/Demigiant/dotween/tree/v1.2.420/_DOTween.Assembly/DOTween")
    rt = os.path.join(d, "Runtime"); os.makedirs(rt)
    for f in files or []:
        f = f.replace("\\", "/")
        if f.startswith("Properties/"): continue
        os.makedirs(os.path.dirname(os.path.join(rt, f)), exist_ok=True); shutil.copy2(os.path.join(core, f), os.path.join(rt, f))
    json.dump({"name": "DOTween", "references": [], "allowUnsafeCode": False, "autoReferenced": True}, open(os.path.join(rt, "DOTween.asmdef"), "w"), indent=2)
    d = reset("DOTween.Modules", "DOTween Modules", "1.2.420", "https://github.com/Demigiant/dotween/tree/v1.2.420/_DOTween.Assembly/bin/Modules")
    rt = os.path.join(d, "Runtime"); os.makedirs(rt)
    for f in sorted(os.listdir(os.path.join(root, "_DOTween.Assembly/bin/Modules"))):
        if f.endswith(".cs"): shutil.copy2(os.path.join(root, "_DOTween.Assembly/bin/Modules", f), os.path.join(rt, f))
    json.dump({"name": "DOTween.Modules", "references": ["DOTween", "UnityEngine.UI"], "allowUnsafeCode": False, "autoReferenced": True},
              open(os.path.join(rt, "DOTween.Modules.asmdef"), "w"), indent=2)
    # Coffee.UIParticle (mob-sakai/ParticleEffectForUGUI): 4.2.x (bool autoScaling, no AutoScalingMode)
    src = os.path.join(fetch("mob-sakai/ParticleEffectForUGUI", coffee), "Scripts")
    d = reset("Coffee.UIParticle", "UIParticle", coffee, f"https://github.com/mob-sakai/ParticleEffectForUGUI/tree/{coffee}/Scripts")
    copytree(src, os.path.join(d, "Runtime"))
    print("installed UniRx 7.1.0, UniTask", unitask, ", DOTween 1.2.420 (+Modules), Coffee.UIParticle", coffee)


if __name__ == "__main__":
    main()

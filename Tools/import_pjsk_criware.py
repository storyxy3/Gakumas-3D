"""Import the managed CriWare port from the PJSK project (ALONE, Haruki.MV Streaming/CriWare: CRI Atom/Mana/Fs runtime classes +
a managed native backend) into live-urp's CriMw.CriWare.Runtime package, replacing the DummyDll skeleton of every type the port
defines. Gakumas ships CriWare Unity plugin 2.44.49, PJSK 2.42.33 (+patch); of the 36 CriWare types a Gakumas live reaches, 21 have
identical layout and 9 differ only in methods (mostly the per-build obfuscated P/Invoke names, which the port does not use: it calls
ICriWareNativeBackend). Gakumas-only members are added back separately (TODO(qa-recon) where not reconstructed).
Skips HarukiCriAtomAudioOutput.cs (PJSK's WebGL output host). Writes Runtime/PJSK-Port/IMPORT.json (source commit, replaced files).
usage: import_pjsk_criware.py [--dry-run]"""
import os, re, sys, json, shutil, subprocess
ROOT = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))
SRC_REPO = "/data/xy/ALONE"
SRC = os.path.join(SRC_REPO, "unity/Haruki3DMV/Assets/Haruki/MV/Runtime/Streaming/CriWare")
PKG = os.path.join(ROOT, "live-urp/Packages/CriMw.CriWare.Runtime/Runtime")
DST = os.path.join(PKG, "PJSK-Port")
SKIP = {"HarukiCriAtomAudioOutput.cs"}
# Backend support outside the CriWare folder: the HCA codec the managed backend decodes with (PJSK-only helper types).
EXTRA = [os.path.join(SRC_REPO, "unity/Haruki3DMV/Assets/Haruki/MV/Runtime/Streaming/Sekai.Streaming", f) for f in ("HcaFileDecoder.cs", "CriHcaDecoder.cs")]
ADD = os.path.join(PKG, "Gakumas-Additions")


def top_types(path):
    """namespace-qualified top-level types declared in a C# file (block or file-scoped namespaces)."""
    s = open(path, encoding="utf-8-sig").read()
    out = []; ns_stack = []; depth = 0; pending_ns = None
    for tok in re.finditer(r'"(?:\\.|[^"\\])*"|//[^\n]*|/\*.*?\*/|\bnamespace\s+([\w.]+)\s*(;|\{)|\b(class|struct|interface|enum|record)\s+(\w+)|\bdelegate\s+[\w.<>\[\], ]+?\s+(\w+)\s*[<(]|[{}]', s, re.S):
        t = tok.group(0)
        if t.startswith(('"', "//", "/*")): continue
        if tok.group(1):
            if tok.group(2) == ";": ns_stack = [(tok.group(1), -1)]
            else: ns_stack.append((tok.group(1), depth)); depth += 1
            continue
        name = tok.group(4) or tok.group(5)
        if name:
            nsd = len([1 for _, d in ns_stack if d >= 0])
            if depth == nsd:
                ns = ".".join(n for n, _ in ns_stack)
                out.append((ns + "." if ns else "") + name)
            continue
        if t == "{": depth += 1
        elif t == "}":
            depth -= 1
            if ns_stack and ns_stack[-1][1] == depth: ns_stack.pop()
    return out


def blocks(src, cls):
    """top-level members of type `cls` (class/struct/enum/delegate declarations and their bodies) as {name: text}."""
    m = re.search(r"\b(?:class|struct)\s+" + cls + r"\b[^{]*\{", src)
    if not m: return {}
    i = m.end(); depth = 1; start = i; out = {}; seg_start = i
    while i < len(src) and depth > 0:
        c = src[i]
        if c == "{": depth += 1
        elif c == "}":
            depth -= 1
            if depth == 1:
                seg = src[seg_start:i + 1]; seg_start = i + 1
                n = re.search(r"\b(?:class|struct|enum|interface)\s+(\w+)", seg)
                if n and not re.search(r"\)\s*\{", seg.split(n.group(0))[0][-200:]): out[n.group(1)] = seg.strip("\n")
        elif c == ";" and depth == 1:
            seg = src[seg_start:i + 1]
            n = re.search(r"\bdelegate\s+[\w.<>\[\], ]+?\s+(\w+)\s*\(", seg)
            if n: out[n.group(1)] = seg.strip("\n")
            seg_start = i + 1
        i += 1
    return out


def add_missing_nested(replaced):
    """For each replaced skeleton type, nested types the port lacks are copied from the skeleton (git HEAD of live-urp) into
    Gakumas-Additions/<Type>.cs as a partial type; the port's declaration gets `partial`."""
    added = {}
    for rel, ts in replaced:
        try:
            skel = subprocess.check_output(["git", "-C", os.path.join(ROOT, "live-urp"), "show", "HEAD:Packages/CriMw.CriWare.Runtime/Runtime/" + rel]).decode("utf-8-sig")
        except subprocess.CalledProcessError:
            continue
        for full in ts:
            ns, _, cls = full.rpartition(".")
            port_files = [os.path.join(DST, f) for f in sorted(os.listdir(DST)) if f.endswith(".cs") and full in top_types(os.path.join(DST, f))]
            if not port_files: continue
            port_file = port_files[0]
            port = open(port_file, encoding="utf-8-sig").read()
            sk, pt = blocks(skel, cls), {}
            for pf in port_files: pt.update(blocks(open(pf, encoding="utf-8-sig").read(), cls))
            miss = [n for n in sk if n not in pt and not n.startswith("_003C")]   # compiler-generated: the port has its own
            if not miss: continue
            decl = re.search(r"((?:public|internal)\s+(?:static\s+|sealed\s+|abstract\s+)*)(class|struct)(\s+" + cls + r"\b)", port)
            if decl and "partial" not in decl.group(1):
                port = port[:decl.start()] + decl.group(1) + "partial " + decl.group(2) + decl.group(3) + port[decl.end():]
                open(port_file, "w", encoding="utf-8").write(port)
            kind = decl.group(2) if decl else "class"
            mods = re.sub(r"\s+", " ", decl.group(1)).strip() if decl else "public"
            body = "\n\n".join(sk[n] for n in miss)
            os.makedirs(ADD, exist_ok=True)
            open(os.path.join(ADD, cls + ".cs"), "w", encoding="utf-8").write(
                "// Gakumas (CriWare 2.44.49) nested types missing from the PJSK port, copied from the DummyDll skeleton.\n"
                "using System;\nusing System.Runtime.InteropServices;\nusing UnityEngine;\nusing UnityEngine.Scripting;\n\nnamespace " + ns + "\n{\n    " + mods + " partial " + kind + " " + cls + "\n    {\n" + body + "\n    }\n}\n")
            added[full] = miss
    return added


def main():
    dry = "--dry-run" in sys.argv
    files = sorted(f for f in os.listdir(SRC) if f.endswith(".cs") and f not in SKIP)
    defined = {}
    for f in files:
        for t in top_types(os.path.join(SRC, f)): defined.setdefault(t, f)
    replaced, kept = [], []
    for dp, _, fn in os.walk(PKG):
        if dp.startswith(DST): continue
        for f in fn:
            if not f.endswith(".cs"): continue
            p = os.path.join(dp, f); ts = top_types(p)
            if ts and all(t in defined for t in ts): replaced.append((os.path.relpath(p, PKG), ts))
            elif any(t in defined for t in ts): kept.append((os.path.relpath(p, PKG), ts))
    print(f"port: {len(files)} files, {len(defined)} top-level types; skeleton files replaced: {len(replaced)}; mixed (kept, check): {len(kept)}")
    for k in kept: print("  mixed:", k)
    if dry: return
    os.makedirs(DST, exist_ok=True)
    for f in files: shutil.copy2(os.path.join(SRC, f), os.path.join(DST, f))
    os.makedirs(os.path.join(DST, "Backend"), exist_ok=True)
    for p in EXTRA: shutil.copy2(p, os.path.join(DST, "Backend", os.path.basename(p)))
    for rel, _ in replaced:
        for p in (os.path.join(PKG, rel), os.path.join(PKG, rel) + ".meta"):
            if os.path.exists(p): os.remove(p)
    added = add_missing_nested(replaced)
    commit = subprocess.check_output(["git", "-C", SRC_REPO, "log", "-1", "--format=%H", "--", os.path.relpath(SRC, SRC_REPO)]).decode().strip()
    json.dump({"source": os.path.relpath(SRC, SRC_REPO), "sourceCommit": commit, "files": files, "skipped": sorted(SKIP),
               "typesDefined": sorted(defined), "skeletonReplaced": sorted(r for r, _ in replaced),
               "backendExtra": [os.path.basename(p) for p in EXTRA], "gakumasNestedAdded": added}, open(os.path.join(DST, "IMPORT.json"), "w"), indent=1)
    print("imported; nested types added for", len(added), "types; IMPORT.json written")


if __name__ == "__main__":
    main()

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
BASE = "0cdf8552a66b9e79412f647982859f1b4c05619d"   # live-urp commit with the full DummyDll skeleton (before the import)


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


def members(src, cls):
    """depth-0 members of type `cls`: list of (kind, key, name, text). kind: type/delegate/method/ctor/property/event/field."""
    m = re.search(r"\b(?:class|struct)\s+" + cls + r"\b[^{;]*\{", src)
    if not m: return []
    i = m.end(); depth = 1; seg = i; out = []
    def classify(t):
        t = re.sub(r"//[^\n]*|/\*.*?\*/", "", t, flags=re.S)
        head = re.sub(r"^(\s*\[[^\]]*\]\s*)+", "", t.strip())
        n = re.search(r"\b(?:class|struct|enum|interface)\s+(\w+)", head.split("{")[0])
        if n and "(" not in head.split(n.group(0))[0]: return ("type", n.group(1), n.group(1))
        n = re.search(r"\bdelegate\s+[\w.<>\[\], ?]+?\s+(\w+)\s*[<(]", head)
        if n: return ("delegate", n.group(1), n.group(1))
        pre = head.split("{")[0].split("=>")[0].strip().rstrip(";")
        eq = re.search(r"(?<![=!<>])=(?![=>])", pre)
        if eq and "(" not in pre[:eq.start()]:   # field with initializer:  T name = new X(...);
            decl = pre[:eq.start()].strip()
            if "," not in re.sub(r"<[^<>]*>", "", decl):
                n = re.search(r"(\w+)\s*$", decl)
                if n: return ("field", n.group(1), n.group(1))
        n = re.search(r"(?:\bevent\s+[\w.<>\[\], ?]+?\s+)(\w+)\s*$", pre.split(";")[0].strip()) or re.search(r"\bevent\s+[\w.<>\[\], ?]+?\s+(\w+)", pre)
        if n: return ("event", n.group(1), n.group(1))
        n = re.search(r"([~\w]+)\s*(?:<[^<>()]*>)?\s*\(([^()]*(?:\([^()]*\)[^()]*)*)\)\s*(?::\s*(?:base|this)\s*\([^)]*\))?\s*$", pre.strip())
        if n:
            nm = n.group(1)
            def ptype(p):
                p = re.sub(r"\[[^\]]*\]", "", p).split("=")[0].strip()
                p = re.sub(r"\b(?:this|params|ref|in|out)\s+", "", p)   # C# cannot overload on ref/in/out alone
                p = p.rsplit(None, 1)[0] if " " in p else p
                return re.sub(r"\s+", "", re.sub(r"\b(?:global::|System\.|UnityEngine\.|CriWare\.)", "", p))
            ps = []; depth = 0; cur = ""
            for ch in n.group(2):
                if ch in "<([": depth += 1
                if ch in ">)]": depth -= 1
                if ch == "," and depth == 0: ps.append(cur); cur = ""
                else: cur += ch
            if cur.strip(): ps.append(cur)
            sig = ",".join(ptype(x) for x in ps)
            return ("ctor" if nm == cls else "method", f"{nm}({sig})", nm)
        n = re.search(r"(\w+)\s*$", pre.strip().rstrip(";").split("=")[0].strip())
        if n and "{" in head: return ("property", n.group(1), n.group(1))
        if "{" not in head and "," in pre:   # int a, b, c;  -> several fields
            decl = re.sub(r"<[^<>]*>", "", pre.strip().rstrip(";"))
            names = [re.split(r"\s*=", x.strip())[0].split()[-1] for x in decl.split(",") if x.strip()]
            return ("fields", "|".join(names), names)
        if n: return ("field", n.group(1), n.group(1))
        return None
    while i < len(src) and depth > 0:
        c = src[i]
        if c == '"':
            i += 1
            while i < len(src) and src[i] != '"': i += 2 if src[i] == "\\" else 1
        elif c == "{": depth += 1
        elif c == "}":
            depth -= 1
            if depth == 1:
                t = src[seg:i + 1]; seg = i + 1; k = classify(t)
                if k: out.append(k + (t.strip("\n"),))
        elif c == ";" and depth == 1:
            t = src[seg:i + 1]; seg = i + 1; k = classify(t)
            if k: out.append(k + (t.strip("\n"),))
        i += 1
    return out


skipped = []


def add_missing_members(replaced):
    """Members of the game's types the port lacks (from the skeleton) -> Gakumas-Additions/<Type>.Members.cs (partial, stub bodies).
    Skipped: names the port declares in another form, compiler-generated members, obfuscated native imports (CRIWAREXXXXXXXX:
    the port replaces the native layer)."""
    added = {}
    for rel, ts in replaced:
        try:
            skel = subprocess.check_output(["git", "-C", os.path.join(ROOT, "live-urp"), "show", BASE + ":Packages/CriMw.CriWare.Runtime/Runtime/" + rel]).decode("utf-8-sig")
        except subprocess.CalledProcessError:
            continue
        for full in ts:
            ns, _, cls = full.rpartition(".")
            port_files = [os.path.join(DST, f) for f in sorted(os.listdir(DST)) if f.endswith(".cs") and full in top_types(os.path.join(DST, f))]
            if not port_files: continue
            pm = []
            for pf in port_files: pm += members(open(pf, encoding="utf-8-sig").read(), cls)
            for f in os.listdir(ADD) if os.path.isdir(ADD) else []:
                if f.startswith(cls + "."): pm += members(open(os.path.join(ADD, f), encoding="utf-8-sig").read(), cls)
            keys = {k for _, k, _, _ in pm}; names = set()
            for _, _, n, _ in pm: names.update(n if isinstance(n, list) else [n])
            port_head = re.search(r"\b(?:class|struct)\s+" + cls + r"\b([^{]*)\{", open(port_files[0], encoding="utf-8-sig").read())
            skel_head = re.search(r"\b(?:class|struct)\s+" + cls + r"\b([^{]*)\{", skel)
            port_static = bool(re.search(r"\bstatic\s+(?:partial\s+)?class\s+" + cls + r"\b", open(port_files[0], encoding="utf-8-sig").read()))
            base_of = lambda h: (h.group(1).split(":")[1].split(",")[0].strip() if h and ":" in h.group(1) else "")
            same_base = base_of(port_head) == base_of(skel_head)
            miss = []
            skm = members(skel, cls)
            events = {n for k, _, n, _ in skm if k == "event"}
            for kind, key, name, text in skm:
                if kind in ("type", "delegate", "fields"): continue
                if kind == "field" and name.startswith("m_") and name[2:] in events: continue   # event backing field (restored to the event's name)
                head = text.split("{")[0].split("=>")[0]
                if port_static and (kind == "ctor" or (kind != "field" and " static " not in " " + head + " ")) and "const" not in head:
                    skipped.append((full, name, "port class is static")); continue
                if not same_base and re.search(r"\boverride\b", head):
                    skipped.append((full, name, "port base class differs")); continue
                if kind in ("type", "delegate", "fields"): continue
                if "_003C" in text: continue   # refers to compiler-generated state machines / closures
                if key in keys or (kind != "method" and kind != "ctor" and name in names): continue
                if kind in ("method", "ctor") and name in names and kind == "ctor": pass
                if name.startswith("_003C") or "CompilerGenerated" in text.split("\n")[0] and kind == "field": continue
                if re.fullmatch(r"CRIWARE[0-9A-F]{8}", name): continue
                if kind == "field" and name in names: continue
                if kind == "event" and ("m_" + name) in {n for k2, _, n, _ in skm if k2 == "field"}:
                    # field-like event in the game (backing field named like the event): emit `event T name;`
                    ev = re.match(r"\s*((?:\[[^\]]*\]\s*)*)(.*?\bevent\s+[\w.<>\[\], ?]+?\s+" + re.escape(name) + r")\b", text, re.S)
                    if ev: text = "        " + ev.group(2).strip() + ";"
                if kind == "method" and re.search(r"\bextern\b", head):
                    # native import (the DummyDll lost the DllImport): API stub that fails loudly; the port's backend replaces natives
                    text = re.sub(r"\bextern\s+", "", text).rstrip().rstrip(";") + " { throw new NotSupportedException(\"native " + name + " (game P/Invoke; not part of the managed port)\"); }"
                miss.append(text)
            if not miss: continue
            port = open(port_files[0], encoding="utf-8-sig").read()
            decl = re.search(r"((?:public|internal)\s+(?:static\s+|sealed\s+|abstract\s+)*)(partial\s+)?(class|struct)(\s+" + cls + r"\b)", port)
            if decl and not decl.group(2):
                port = port[:decl.start()] + decl.group(1) + "partial " + decl.group(3) + decl.group(4) + port[decl.end():]
                open(port_files[0], "w", encoding="utf-8").write(port)
            kind = decl.group(3) if decl else "class"
            mods = re.sub(r"\s+", " ", decl.group(1)).strip() if decl else "public"
            os.makedirs(ADD, exist_ok=True)
            usings = sorted(set(re.findall(r"^\s*(using\s+(?:global::)?[\w.]+\s*;)", skel, re.M)) | {"using System;", "using UnityEngine;", "using UnityEngine.Scripting;", "using AOT;"})
            open(os.path.join(ADD, cls + ".Members.cs"), "w", encoding="utf-8").write(
                "// Gakumas (CriWare 2.44.49) members missing from the PJSK port, copied from the DummyDll skeleton.\n"
                "// TODO(qa-recon): bodies are skeleton placeholders until reconstructed from the game.\n"
                "#pragma warning disable 0067, 0169, 0414, 0649\n" + "\n".join(u.strip() for u in usings) + "\n\nnamespace " + ns + "\n{\n    " + mods + " partial " + kind + " " + cls + "\n    {\n" + "\n\n".join(miss) + "\n    }\n}\n")
            added[full] = len(miss)
    return added


def add_missing_nested(replaced):
    """For each replaced skeleton type, nested types the port lacks are copied from the skeleton (git HEAD of live-urp) into
    Gakumas-Additions/<Type>.cs as a partial type; the port's declaration gets `partial`."""
    added = {}
    for rel, ts in replaced:
        try:
            skel = subprocess.check_output(["git", "-C", os.path.join(ROOT, "live-urp"), "show", BASE + ":Packages/CriMw.CriWare.Runtime/Runtime/" + rel]).decode("utf-8-sig")
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
    if not dry:   # start from the skeleton state: restore the pre-import package, drop generated folders (Gakumas-Members is kept)
        subprocess.check_call(["git", "-C", os.path.join(ROOT, "live-urp"), "checkout", "-q", BASE, "--", "Packages/CriMw.CriWare.Runtime"])
        for d in (DST, ADD):
            if os.path.isdir(d): shutil.rmtree(d)
        for d in (DST, ADD):
            if os.path.exists(d + ".meta"): os.remove(d + ".meta")
    files = sorted(f for f in os.listdir(SRC) if f.endswith(".cs") and f not in SKIP)
    defined = {}
    for f in files:
        for t in top_types(os.path.join(SRC, f)): defined.setdefault(t, f)
    replaced, kept = [], []
    for dp, _, fn in os.walk(PKG):
        if dp.startswith((DST, ADD, os.path.join(PKG, "Gakumas-Members"))): continue
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
    added_members = add_missing_members(replaced)
    commit = subprocess.check_output(["git", "-C", SRC_REPO, "log", "-1", "--format=%H", "--", os.path.relpath(SRC, SRC_REPO)]).decode().strip()
    json.dump({"source": os.path.relpath(SRC, SRC_REPO), "sourceCommit": commit, "files": files, "skipped": sorted(SKIP),
               "typesDefined": sorted(defined), "skeletonReplaced": sorted(r for r, _ in replaced),
               "backendExtra": [os.path.basename(p) for p in EXTRA], "gakumasNestedAdded": added, "gakumasMembersAdded": added_members, "gakumasMembersSkipped": skipped}, open(os.path.join(DST, "IMPORT.json"), "w"), indent=1)
    print("imported; nested types added for", len(added), "types, members for", len(added_members), "types; IMPORT.json written")


if __name__ == "__main__":
    main()

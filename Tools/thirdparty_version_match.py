"""Pick the release of an open-source library that matches the game's (stripped) assembly: download each candidate tag's source
(GitHub tarball, into work/thirdparty/<repo>/<tag>/), then count the game's type names and method names (from dump.cs, the
assembly's TypeDefIndex range) missing from that tag's source. The game is linker-stripped, so extra members in a candidate
mean nothing; missing ones rule it out. Final confirmation is the per-method code comparison after building the chosen tag.
usage: thirdparty_version_match.py <assembly name> <owner/repo> <tag>... [--subdir path-substring]"""
import sys, os, re, io, tarfile, urllib.request, collections
ROOT = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))
DUMP = os.path.join(ROOT, "work/il2cpp-3.5.3/dump.cs")


def game_names(asm):
    imgs = []; types, methods = set(), set(); cur_asm = None; ns = ""; game_fields.clear(); cur_type = None
    for l in open(DUMP, encoding="utf-8", errors="ignore"):
        m = re.match(r"// Image \d+: (\S+)\.dll - (\d+)", l)
        if m: imgs.append((int(m.group(2)), m.group(1))); continue
        m = re.search(r"(?:class|struct|interface|enum) (.+?)(?: :.*)? // TypeDefIndex: (\d+)", l)
        if m:
            idx = int(m.group(2)); a = None
            for s, n in imgs:
                if idx >= s: a = n
            cur_asm = a
            cur_type = None
            if a == asm:
                name = re.sub(r"<.*", "", m.group(1).split(".")[-1])
                if not name.startswith(("<", "__")): types.add(name); cur_type = name
            continue
        if cur_asm != asm: continue
        m = re.match(r"\t(?:\[.*\] )?(?:public|private|internal|protected)[^(]*? ([A-Za-z_]\w*); // 0x", l)
        if m and cur_type and "const " not in l: game_fields.add((cur_type, m.group(1)))
        m = re.match(r"\t(?:public|private|internal|protected)[^(]*? ([A-Za-z_]\w*)(?:<[^>]*>)?\((.*)\) \{ \}", l)
        if m and m.group(1) not in (".ctor", ".cctor") and not m.group(1).startswith(("get_", "set_", "add_", "remove_", "op_")):
            methods.add(m.group(1))
        m = re.match(r"\t(?:public|private|internal|protected)[^(]*? (get|set)_(\w+)\(", l)
        if m: methods.add(m.group(2))
    return types, methods


game_fields = set()


def source_fields(d, sub):
    """(type, field) pairs: identifiers declared as fields directly inside a class/struct body (brace depth tracking)."""
    out = set()
    for dp, _, fn in os.walk(d):
        if sub and sub not in dp: continue
        if re.search(r"(^|/)(Tests?|Editor|Samples?~?|Example\w*)(/|$)", os.path.relpath(dp, d)): continue
        for f in fn:
            if not f.endswith(".cs"): continue
            s = open(os.path.join(dp, f), encoding="utf-8", errors="ignore").read()
            s = re.sub(r"//[^\n]*|/\*.*?\*/|\"(?:\\.|[^\"\\])*\"", "", s, flags=re.S)
            stack = []; i = 0; pending = None
            for m in re.finditer(r"\b(?:class|struct|record)\s+(\w+)|[{};]", s):
                t = m.group(0)
                if m.group(1): pending = m.group(1); continue
                if t == "{":
                    stack.append(pending); pending = None
                elif t == "}":
                    if stack: stack.pop()
                elif t == ";" and stack and stack[-1]:
                    stmt = s[s.rfind("\n", 0, m.start()) + 1:m.start()]
                    fm = re.search(r"^\s*(?:\[[^\]]*\]\s*)*(?:(?:public|private|internal|protected|static|readonly|volatile|new)\s+)*[\w.<>\[\], ?]+\s+(\w+)\s*(?:=.*)?$", stmt)
                    if fm and "(" not in stmt.split("=")[0]: out.add((stack[-1], fm.group(1)))
    return out


def fetch(repo, tag):
    d = os.path.join(ROOT, "work/thirdparty", repo.replace("/", "__"), tag)
    if not os.path.isdir(d):
        url = f"https://codeload.github.com/{repo}/tar.gz/refs/tags/{tag}"
        data = urllib.request.urlopen(urllib.request.Request(url, headers={"User-Agent": "thirdparty-version-match"}), timeout=300).read()
        os.makedirs(d)
        with tarfile.open(fileobj=io.BytesIO(data)) as t:
            for mem in t.getmembers():
                if mem.isfile() and mem.name.endswith((".cs", ".asmdef", ".json", ".md")) and ".." not in mem.name and not mem.name.startswith("/"):
                    mem.name = mem.name.split("/", 1)[1] if "/" in mem.name else mem.name
                    t.extract(mem, d, filter="data")
    return d


def source_names(d, sub):
    types, idents = set(), set()
    for dp, _, fn in os.walk(d):
        if sub and sub not in dp: continue
        if re.search(r"(^|/)(Tests?|Editor|Samples?~?|Example\w*)(/|$)", os.path.relpath(dp, d)): continue
        for f in fn:
            if not f.endswith(".cs"): continue
            s = open(os.path.join(dp, f), encoding="utf-8", errors="ignore").read()
            types.update(re.findall(r"\b(?:class|struct|interface|enum|record)\s+(\w+)", s))
            types.update(re.findall(r"\bdelegate\s+[\w.<>\[\], ?]+?\s+(\w+)\s*[<(]", s))
            idents.update(re.findall(r"\b([A-Za-z_]\w*)\s*(?:<[^<>()]*>)?\s*\(", s))
            idents.update(re.findall(r"\b([A-Za-z_]\w*)\s*(?:\{|=>)", s))
    return types, idents


def main():
    args = [a for a in sys.argv[1:] if not a.startswith("--")]
    sub = sys.argv[sys.argv.index("--subdir") + 1] if "--subdir" in sys.argv else None
    if sub in args: args.remove(sub)
    asm, repo, tags = args[0], args[1], args[2:]
    gt, gm = game_names(asm)
    print(f"{asm}: game types {len(gt)}, methods/properties {len(gm)}")
    for tag in tags:
        try: d = fetch(repo, tag)
        except Exception as e: print(f"  {tag}: fetch failed {e}"); continue
        st, si = source_names(d, sub)
        mt, mm = sorted(gt - st), sorted(gm - si)
        sf = source_fields(d, sub); mf = sorted(f for f in game_fields if f not in sf and not f[1].startswith("<"))
        print(f"  {tag:14s} missing types {len(mt):4d}  members {len(mm):4d}  fields {len(mf):4d}   e.g. {mt[:3]} {mm[:3]} {mf[:4]}")


if __name__ == "__main__":
    main()

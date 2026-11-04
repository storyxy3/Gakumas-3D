"""Compare the types of a namespace between two Il2CppDumper dump.cs files (fields with types/offsets, method signatures).
usage: compare_dump_types.py <dumpA> <dumpB> <namespace regex> [types of interest file]  -> per type: same / fields differ / methods differ / only A / only B"""
import re, sys, collections


def parse(path, nsrx):
    types = {}; ns = ""; cur = None
    for l in open(path, encoding="utf-8", errors="ignore"):
        m = re.match(r"// Namespace: ?(.*)", l)
        if m: ns = m.group(1).strip(); cur = None; continue
        m = re.match(r"\S.*?(?:class|struct|interface|enum) (.+?)(?: :.*)? // TypeDefIndex", l)
        if m:
            cur = None
            if re.match(nsrx, ns): cur = types.setdefault(ns + "." + m.group(1), {"fields": [], "methods": []})
            continue
        if cur is None: continue
        m = re.match(r"\t(?:\[.*\] )?([^\t(]*?) (\w+|<[^>]+>k__BackingField|<>\w+); // (0x[0-9A-F]+)", l)
        if m and "(" not in l: cur["fields"].append((m.group(2), m.group(1).replace("readonly ", ""), m.group(3))); continue
        m = re.match(r"\t((?:public|private|internal|protected)[^(]*?) ([\w.<>,\[\] ]+)\((.*)\) \{ \}", l)
        if m: cur["methods"].append(re.sub(r"\s+", " ", m.group(2) + "(" + m.group(3) + ")"))
    return types


def main():
    A, B = parse(sys.argv[1], sys.argv[3]), parse(sys.argv[2], sys.argv[3])
    want = set(open(sys.argv[4]).read().split()) if len(sys.argv) > 4 else None
    res = collections.defaultdict(list)
    for t in sorted(set(A) | set(B)):
        if want is not None and t not in want: continue
        if t not in B: res["only A"].append(t); continue
        if t not in A: res["only B"].append(t); continue
        fa, fb = A[t]["fields"], B[t]["fields"]; ma, mb = set(A[t]["methods"]), set(B[t]["methods"])
        if fa != fb: res["fields differ"].append((t, [f for f in fa if f not in fb][:4], [f for f in fb if f not in fa][:4]))
        elif ma != mb: res["methods differ"].append((t, sorted(ma - mb)[:4], sorted(mb - ma)[:4]))
        else: res["same"].append(t)
    for k in ("same", "methods differ", "fields differ", "only A", "only B"):
        print(f"== {k}: {len(res[k])}")
        for x in res[k][:200]: print("  ", x if isinstance(x, str) else x[0])
    return res


if __name__ == "__main__":
    main()

"""Compare two Il2CppDumper dump.cs files: types and member signatures per type, filtered by namespace / image.
usage: dump_type_diff.py <old dump.cs> <new dump.cs> [image regex]"""
import re, sys, collections
def parse(path, img_rx):
    types = {}; cur = None; ns = ""; img_ranges = []
    lines = open(path, encoding="utf-8", errors="replace").read().split("\n")
    for l in lines[:500]:
        m = re.match(r"// Image (\d+): (\S+) - (\d+)", l)
        if m: img_ranges.append((int(m.group(3)), m.group(2)))
    img_ranges.sort()
    def image_of(i):
        n = None
        for s, name in img_ranges:
            if i >= s: n = name
        return n
    for l in lines:
        if l.startswith("// Namespace: "): ns = l[14:].strip(); continue
        m = re.search(r"(class|struct|enum|interface) (.+?) (?::.*)?// TypeDefIndex: (\d+)", l)
        if m:
            img = image_of(int(m.group(3)))
            cur = (img, ns + "." + m.group(2).strip()) if img and re.search(img_rx, img) else None
            if cur: types[cur] = set()
            continue
        if cur is None: continue
        if l.startswith("}"): cur = None; continue
        s = l.strip()
        if not s or s.startswith("//") or s.startswith("[") or s.startswith("|-RVA"): continue
        s = re.sub(r"/\*Metadata offset 0x[0-9A-F]+\*/", "", s)
        s = re.sub(r"\s*//.*", "", s)                  # offsets / RVAs
        s = re.sub(r"<>c__DisplayClass\d+_\d+|<\w+>b__\d+_\d+|<>9__\d+_\d+|<\w+>d__\d+", "<gen>", s)
        types[cur].add(s)
    return types
def signature_main(argv):
    old, new = parse(argv[0], argv[2] if len(argv) > 2 else "."), parse(argv[1], argv[2] if len(argv) > 2 else ".")
    added = sorted(set(new) - set(old)); removed = sorted(set(old) - set(new))
    changed = [(t, sorted(new[t] - old[t]), sorted(old[t] - new[t])) for t in sorted(set(old) & set(new)) if new[t] != old[t]]
    print(f"types: +{len(added)} -{len(removed)} changed {len(changed)}")
    for t in added: print("  + type", t[0], t[1])
    for t in removed: print("  - type", t[0], t[1])
    for t, a, r in changed:
        print(f"  ~ {t[0]} {t[1]}")
        for x in a: print("      +", x[:200])
        for x in r: print("      -", x[:200])


def parse_layout(path, image_regex="."):
    """Read declaration order and offsets, without normalizing metadata names.

    Offsets belong to different storage areas for instance, static and thread
    static fields. Literal constants have no storage and their values are not
    a layout claim. The parser rejects unknown field declarations rather than
    silently dropping them from the acceptance comparison.
    """
    import bisect
    images, starts, result = [], [], {}
    selected = re.compile(image_regex)
    namespace, current, section = "", None, None
    pending_attributes = []
    attribute_continuation = False
    modifiers = {"public", "private", "protected", "internal", "static", "readonly", "const", "volatile", "unsafe", "fixed"}
    with open(path, encoding="utf-8", errors="replace") as stream:
        for number, line in enumerate(stream, 1):
            if attribute_continuation:
                pending_attributes[-1] += "\n" + line.strip()
                attribute_continuation = not line.rstrip().endswith("]")
                continue
            image = re.match(r"// Image \d+: (\S+) - (\d+)", line)
            if image:
                images.append(image.group(1))
                starts.append(int(image.group(2)))
                continue
            if line.startswith("// Namespace: "):
                namespace = line[14:].strip()
                current, section, pending_attributes = None, None, []
                continue
            header = re.search(r"\b(class|struct|enum|interface) (.+?)\s*// TypeDefIndex: (\d+)", line)
            if header:
                index = bisect.bisect_right(starts, int(header.group(3))) - 1
                if index < 0:
                    raise ValueError(f"{path}:{number}: type without image header")
                assembly = images[index]
                declaration = header.group(2).strip()
                name, separator, bases = declaration.partition(" : ")
                full_name = namespace + "." + name if namespace else name
                current = None
                if selected.search(assembly):
                    key = (assembly, full_name)
                    if key in result:
                        raise ValueError(f"{path}:{number}: duplicate type {key}")
                    current = {"kind": header.group(1), "bases": bases if separator else "", "fields": [],
                               "attributes": pending_attributes, "line": number,
                               "generated": "[CompilerGenerated]" in pending_attributes or bool(re.search(r"<>|_003C|>d__|>c__", full_name)),
                               "generic": bool(re.search(r"<[^>]+>$", name))}
                    result[key] = current
                pending_attributes = []
                continue
            stripped = line.strip()
            if stripped.startswith("["):
                pending_attributes.append(re.sub(r"\s*/\*Metadata.*?\*/", "", stripped))
                attribute_continuation = not stripped.endswith("]")
                continue
            if current is None:
                continue
            if stripped in ("// Fields", "// Properties", "// Methods", "// Events"):
                section = stripped
                pending_attributes = []
                continue
            if line.startswith("}") or stripped == "{}":
                current = None
                continue
            if section != "// Fields" or not stripped or stripped.startswith("//"):
                continue
            field = re.match(r"(.+);(?:\s*//\s*(0x[\dA-Fa-f]+|-?\d+))?\s*$", stripped)
            if not field:
                raise ValueError(f"{path}:{number}: unrecognized field: {stripped}")
            body = field.group(1).split(" = ", 1)[0]
            parts = body.split()
            flags = []
            while parts and parts[0] in modifiers:
                flags.append(parts.pop(0))
            if len(parts) < 2:
                raise ValueError(f"{path}:{number}: incomplete field: {stripped}")
            storage = "constant" if "const" in flags else "thread-static" if any("ThreadStatic" in a for a in pending_attributes) else "static" if "static" in flags else "instance"
            offset = int(field.group(2), 0) if field.group(2) else None
            if storage == "constant" or offset is not None and (offset < 0 or offset >= 0x80000000):
                offset = None
            current["fields"].append({"name": parts[-1], "type": " ".join(parts[:-1]), "storage": storage,
                                      "offset": offset, "attributes": pending_attributes, "line": number})
            pending_attributes = []
    if not starts or starts != sorted(starts):
        raise ValueError(f"{path}: missing or unordered image table")
    return result


def layout_difference(old, new):
    changes, uncertain = [], []
    for key in ("kind", "bases"):
        if old[key] != new[key]:
            changes.append(f"{key}: {old[key]!r} → {new[key]!r}")
    old_fields, new_fields = old["fields"], new["fields"]
    old_names, new_names = [f["name"] for f in old_fields], [f["name"] for f in new_fields]
    if old_names != new_names:
        changes.append("field declaration order/names: " + repr(old_names) + " → " + repr(new_names))
    by_name = {f["name"]: f for f in new_fields}
    for before in old_fields:
        after = by_name.get(before["name"])
        if after is None:
            changes.append(f"missing field {before['storage']} {before['type']} {before['name']}")
            continue
        for key in ("type", "storage", "offset"):
            if before[key] != after[key]:
                left, right = before[key], after[key]
                if key == "offset":
                    left = hex(left) if left is not None else "unavailable"
                    right = hex(right) if right is not None else "unavailable"
                changes.append(f"{before['name']}: {key} {left!r} → {right!r}")
        if before["storage"] != "constant" and (before["offset"] is None or after["offset"] is None):
            uncertain.append(f"{before['name']}: no comparable storage offset")
    for after in new_fields:
        if after["name"] not in old_names:
            changes.append(f"extra field {after['storage']} {after['type']} {after['name']}")
    if (old["generic"] or new["generic"]) and any(f["storage"] != "constant" for f in old_fields + new_fields):
        uncertain.append("generic definition offsets do not establish concrete generic-instance layouts")
    return changes, uncertain


def layout_main(argv):
    import argparse
    import hashlib
    import json
    from pathlib import Path
    parser = argparse.ArgumentParser(description="Compare Il2CppDumper type/field layouts; no runtime execution.")
    parser.add_argument("old", help="original game dump.cs")
    parser.add_argument("new", help="new build dump.cs")
    parser.add_argument("image_regex", nargs="?", default=".", help="assembly name regex (default: every image)")
    parser.add_argument("--output", "-o", help="Markdown report destination; default stdout")
    parser.add_argument("--json", dest="json_output", help="optional full machine-readable comparison")
    args = parser.parse_args(argv)
    old, new = parse_layout(args.old, args.image_regex), parse_layout(args.new, args.image_regex)
    if not old:
        parser.error("no original types match the assembly selection")
    entries, counts = [], collections.defaultdict(collections.Counter)
    for assembly, name in sorted(old.keys() | new.keys()):
        key = (assembly, name)
        before, after = old.get(key), new.get(key)
        changes, uncertain = [], []
        if before is None:
            status = "extra"
        elif after is None:
            status = "missing"
        else:
            changes, uncertain = layout_difference(before, after)
            status = "mismatching" if changes else "indeterminate" if uncertain else "matching"
        entry = {"assembly": assembly, "type": name, "status": status, "changes": changes, "limitations": uncertain,
                 "compiler_generated": (before or after)["generated"], "old": before, "new": after}
        entries.append(entry)
        counts[assembly][status] += 1
    def sha256(path):
        h = hashlib.sha256()
        with open(path, "rb") as stream:
            for block in iter(lambda: stream.read(1024 * 1024), b""):
                h.update(block)
        return h.hexdigest()
    provenance = {"original": {"path": str(Path(args.old).resolve()), "sha256": sha256(args.old)},
                  "build": {"path": str(Path(args.new).resolve()), "sha256": sha256(args.new)}, "image_regex": args.image_regex}
    def code(value):
        return "`" + str(value).replace("`", "&#96;").replace("|", "&#124;") + "`"
    lines = ["# IL2CPP field layout comparison", "", f"Original: {code(provenance['original']['path'])}",
             f"SHA-256: {code(provenance['original']['sha256'])}", "", f"Build: {code(provenance['build']['path'])}",
             f"SHA-256: {code(provenance['build']['sha256'])}", "", f"Assembly selection: {code(args.image_regex)}", "",
             "Names are matched exactly within each assembly, including nested and compiler-generated types. "
             "Matching means equal type kind/base declarations and declared field names, types, order, storage kind and available offsets. "
             "Instance, static and thread-static offsets belong to separate storage areas; constants have no storage. "
             "Missing/extra types remain visible; stripping and compiler-generated renaming can cause these outcomes.", "",
             "This report cannot establish object size, tail padding, concrete generic-instance layouts, method behavior, "
             "serialization attribute argument values, or runtime initialization. Inherited fields are compared in their declaring types. "
             "A type with no declared storage fields matches vacuously. Generic definitions and unavailable storage offsets are indeterminate. "
             "Dumps must come from the same architecture and compatible IL2CPP object model for offsets to be comparable.", "",
             "| Assembly | Matching | Mismatching | Indeterminate | Missing from build | Extra in build |",
             "| --- | ---: | ---: | ---: | ---: | ---: |"]
    statuses = ("matching", "mismatching", "indeterminate", "missing", "extra")
    for assembly, count in sorted(counts.items()):
        lines.append("| " + code(assembly) + " | " + " | ".join(str(count[s]) for s in statuses) + " |")
    totals = sum(counts.values(), collections.Counter())
    lines.append("| **Total** | " + " | ".join(str(totals[s]) for s in statuses) + " |")
    for assembly in sorted(counts):
        lines += ["", "## " + assembly, ""]
        selected = [e for e in entries if e["assembly"] == assembly]
        for status in statuses:
            subset = [e for e in selected if e["status"] == status]
            if not subset:
                continue
            lines += [f"<details><summary>{status.capitalize()}: {len(subset)}</summary>", ""]
            for entry in subset:
                generated = " (compiler-generated name)" if entry["compiler_generated"] else ""
                lines.append("- " + code(entry["type"]) + generated)
                if entry["changes"] or entry["limitations"]:
                    lines.append("")
                    for difference in entry["changes"]:
                        lines.append("  - " + code(difference))
                    for limitation in entry["limitations"]:
                        lines.append("  - Limitation: " + limitation)
                    lines.append("")
            lines += ["", "</details>", ""]
    report = "\n".join(lines) + "\n"
    if args.output:
        Path(args.output).write_text(report, encoding="utf-8")
        print("layout: " + ", ".join(f"{s}={totals[s]}" for s in statuses) + f"; report={args.output}")
    else:
        print(report, end="")
    if args.json_output:
        Path(args.json_output).write_text(json.dumps({"provenance": provenance, "summary": dict(counts), "types": entries}, indent=2) + "\n", encoding="utf-8")


if __name__ == "__main__":
    if "--layout" in sys.argv[1:]:
        layout_main([arg for arg in sys.argv[1:] if arg != "--layout"])
    elif len(sys.argv) >= 3:
        signature_main(sys.argv[1:])
    else:
        print(__doc__ + "\nLayout report: dump_type_diff.py --layout <old dump.cs> <new dump.cs> [image regex] --output LAYOUT.md")
        sys.exit(2)

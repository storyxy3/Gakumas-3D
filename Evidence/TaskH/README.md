# Task H evidence

See [TASK_H_REPORT.md](../../TASK_H_REPORT.md) for scope, counts, commits and TODOs.
The source snapshot is commit `d9f3fef`; later source edits before that commit only
update comments relative to the final compiled bodies.

- `method-status.json`: exhaustive 1,070-name census, with assembly/type, source
  status, strict reported status, raw comparator result, original addresses and
  missing signatures. Overloads are aggregated by native name.
- `final-func-diff.json`, `final-compare.txt`: unmodified final canonical comparison
  output. Raw `same` can include skipped generic signatures; use the stricter
  inventory for completion counts.
- `missing-signatures.json`: all 167 unmatched original signatures, including the
  list overload of `FasterLinq.Select<object, object>` skipped by the normal tool.
- `final-native-review.txt`: reduced instruction diffs for reconstructed/reviewed
  changed methods, using the canonical comparison module's `Image.norm` and
  `semantic` operations. These diffs are diagnostic, not execution tests or an
  independent equivalence proof. Full instructions were inspected where needed.
- `retained-disasm.txt`: original APK instructions for 71 unchanged constructors
  and zero-valued clip-capability getters separately reviewed before crediting.
- `accessor-evidence.json`: original instructions/field mapping for restored
  straightforward field accessors.
- `rgctx-evidence.txt`: original collection-interface metadata used by Qua.Utility.
- `math-disasm.txt`, `job-lookat.disasm.txt`: APK instructions used to recover
  missing floating-point decompiler output and the failed look-at job body.
- `build-summary.txt`: final compilation/package result; the full local log is
  `.recon/task-h/build-final-unity.log` (ignored). No tests were written or run.
- `input-SHA256SUMS`: original and rebuilt binary/dump fingerprints.
- `census-regex.txt`: exact distinct census names for the canonical comparator.

Reproduce the build/comparison from the project root:

```sh
Tools/build_android.sh
/data/xy/gakumas/scripts/live_check.sh /data/xy/gakumas/live-urp-codex "$(cat Evidence/TaskH/census-regex.txt)"
/data/xy/gakumas/tools/venv/bin/python /data/xy/gakumas/scripts/live_show.py /data/xy/gakumas/live-urp-codex 'ActorAnimation.ActorAnimationMathUtility$$ToQuaternion'
```

The Gradle failure follows successful native output and is expected for this
checkout. Keep the rebuilt library and dump from the same build when inspecting
individual differences. `.recon/task-h/` also retains decompilations and working
notes that are not included in Git.

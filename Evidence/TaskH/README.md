# Task H / H2 evidence

See [TASK_H_REPORT.md](../../TASK_H_REPORT.md) for assembly/type counts, source
commits and remaining work. The final compiled source snapshot is `7b23cff`.

- `method-status.json` contains the exhaustive 1,070-name census with assembly,
  type, source status, strict status, raw comparator result, APK addresses,
  missing signatures and previous Task H statuses.
- `h2-summary.json` records totals, the source commit and all 16 H2 source commits.
- `final-func-diff.json` and `final-compare.txt` are the unmodified final canonical
  comparison outputs. Strict completion counts come from the signature audit.
- `missing-signatures.json` lists all 141 missing signatures across 127 names.
  These include the list overloads of `FasterLinq.Select<object, int>` and
  `FasterLinq.Select<object, object>` skipped by the normal comparator.
- `final-native-review.txt` records reduced instruction differences for the final
  census using the canonical module's `Image.norm` and `semantic` functions.
  These diagnostics accompany source/disassembly review.
- `dependency-compare.json` records 15 same and one semantic difference across
  16 dependency names, with zero missing.
- `task-f-regression.json` records the final Task F raw comparison, 630 same,
  75 changed and zero only-in-game.
- `final-regression-review.txt` records the renderer dependency and newly flagged
  census/Task F methods. `final-boundary-review.txt` includes full normalized
  instructions for the fully shared skinning static constructor and its trailing
  neighboring instructions.
- `retained-disasm.txt`, `accessor-evidence.json`, `rgctx-evidence.txt`,
  `math-disasm.txt` and `job-lookat.disasm.txt` preserve Task H's original APK
  instruction/field evidence. Their input APK is unchanged.
- `build-summary.txt` records C#/native compilation and the Gradle packaging
  failure. The complete local log is `.recon/task-h2/build-final-unity.log`.
- `input-SHA256SUMS` fingerprints the original and final rebuilt binary/dump inputs.
- `census-regex.txt` selects the exact distinct Task H names.

Run the documented compilation and function comparison from the project root.

```sh
Tools/build_android.sh
/data/xy/gakumas/scripts/live_check.sh /data/xy/gakumas/live-urp-codex "$(cat Evidence/TaskH/census-regex.txt)"
/data/xy/gakumas/tools/venv/bin/python /data/xy/gakumas/scripts/live_show.py /data/xy/gakumas/live-urp-codex 'ActorAnimation.ActorAnimationMathUtility$$ToQuaternion'
```

APK packaging fails after native linking with Gradle's `For input string: "37.0"`.
Keep the rebuilt library and dump from the same build for individual comparisons.
Local `.recon/task-h2/` contains additional decompilation, disassembly and batch
comparison records. No tests or runtime harnesses were written or run.

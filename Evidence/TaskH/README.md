# Task H / H2 / H3 evidence

The current reconstruction report is [TASK_H_REPORT.md](../../TASK_H_REPORT.md).
H3 remains incomplete. Its compiled source snapshot is `018e559`.

## Current H3 inventory

- `method-status.json` contains 1,654 native names with assembly/type, source state,
  raw comparison label, strict status, APK addresses and missing signatures.
- `h3-census-additions.json` lists the 584 added names and their dependency reasons.
  Of these, 374 have reconstructed or native-reviewed bodies and paired signatures.
- `h3-summary.json` records assembly totals, source commit and comparison totals.
- `h3-census-regex.txt` selects the exact expanded inventory.
- `h3-final-func-diff.json` and `h3-final-compare.txt` contain the final canonical
  comparison. `h3-original-census-compare.json` keeps the original H census comparable.
- `missing-signatures.json` includes all 146 absent signatures across 132 names.
  The strict audit includes generic overloads skipped by the canonical comparator.
- `h3-out-of-scope.json`, `h3-out-of-scope-callers.txt` and
  `h3-missing-signature-callers.json` document feature-specific generic exclusions.
  Shared/erased signatures with uncertain live callers remain unfinished.
- `h3-combined-submesh-callers.json` records the empty direct-call result for
  AddCombinedOpaqueSubMesh. Its recovered initializer also contains no call.
- `h3-reconstructed-native-review.txt`, `h3-regression-native-review.txt` and
  `h3-regression-changes.json` retain reduced native instruction differences.
- `h3-task-f-regression.json`, `h3-task-f-full-review.txt` and
  `h3-task-f-branch-review.txt` document the final Task F comparison and load thunks.
- `h3-quartz-calcs.disasm.txt`, `h3-create-ik.disasm.txt` and
  `h3-canvas-3d.disasm.txt` preserve instruction evidence where decompilation failed.
- `h3-build-summary.txt` records native/C# compilation and the Gradle packaging failure.
  The full log is available locally at `.recon/task-h3/build-final-unity.log`.
- `h3-input-SHA256SUMS` fingerprints the original and rebuilt binary/dump inputs.

Status `not done` takes precedence over raw layout/semantic labels for unfinished
source or missing native signatures. `out of scope` identifies the 16 feature-specific
missing names. A reconstructed method's status does not certify its dependency closure.
The report lists unfinished callees separately.

## Reproduce the comparison

```sh
Tools/build_android.sh
/data/xy/gakumas/scripts/live_check.sh /data/xy/gakumas/live-urp-codex "$(cat Evidence/TaskH/h3-census-regex.txt)"
/data/xy/gakumas/tools/venv/bin/python /data/xy/gakumas/scripts/live_show.py /data/xy/gakumas/live-urp-codex 'ActorAnimation.CampusActorAnimationJob$$CreateFullBodyIK'
```

Restore generated LAYOUT.md, LAYOUT-ALL.md and Tools/build-artifacts.json before
committing. Native IL2CPP output is usable despite the Gradle `37.0` packaging failure.
No tests or runtime harnesses were written or run.

## Historical H / H2 evidence

The unprefixed final comparison/review files, `h2-summary.json`,
`task-f-regression.json`, `dependency-compare.json`, `build-summary.txt` and
`input-SHA256SUMS` retain the H2 snapshot. Its compiled source is `7b23cff`.
`census-regex.txt` still selects the original 1,070 names. Historical method-status
and missing-signature inventories are available in commit `8b94fbb`.

Task F's pre-H2 result was 632 same, 36 layout, 37 semantic and zero missing.
The former H2 report incorrectly described the 37 semantic flags as missing.

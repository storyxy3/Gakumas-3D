# Task H / H2 / H3 / H4 evidence

The current reconstruction report is [TASK_H_REPORT.md](../../TASK_H_REPORT.md).
H4 closes the expanded rendering census at source commit `0c793f9`.

## Current H4 inventory

- `method-status.json` records 1,676 names with per-method status and reasons.
  Totals are 1,272 same, 133 layout, 146 semantic and 125 out of scope.
- `h4-census-additions.json` records 22 new names and their reached callers.
- `h4-restored-methods.json` records the reconstructed batches and evidence.
- `h4-summary.json`, `h4-final-func-diff.json` and `h4-final-compare.txt` retain
  the final counts and canonical comparison.
- `missing-signatures.json` contains 141 absent signatures, all with caller-based
  scope decisions in `h4-generic-scope.json`. The secondary caller graph and
  event-bonus disassembly document the indirect cases.
- `h4-semantic-reasons.json` gives reasons for all 146 semantic names.
  `h4-semantic-summary.json`, `h4-final-new-flags-review.txt` and
  `h4-final-boundary-review.txt` preserve the corresponding native differences.
- `h4-task-f-regression.json`, `h4-task-f-review.txt` and `h4-task-f-thunk.txt`
  record 630 same, 36 layout, 39 semantic and zero missing names for Task F.
- `h4-build-summary.txt` and `h4-input-SHA256SUMS` record compilation and inputs.
  The source was compiled after its final edit. Gradle packaging still fails
  on the SDK version string `37.0`.

The rendering census excludes client asset loading and unrelated UI/feature
instantiations under the existing `CLOSURE.md` boundary. The report identifies
these callers, including the Assembly-CSharp live-player loading layer.

## Historical H3 inventory

- The H3 version of `method-status.json` contains 1,654 native names with assembly/type, source state,
  raw comparison label, strict status, APK addresses and missing signatures.
- `h3-census-additions.json` lists the 584 added names and their dependency reasons.
  Of these, 374 have reconstructed or native-reviewed bodies and paired signatures.
- `h3-summary.json` records assembly totals, source commit and comparison totals.
- `h3-census-regex.txt` selects the exact expanded inventory.
- `h3-final-func-diff.json` and `h3-final-compare.txt` contain the final canonical
  comparison. `h3-original-census-compare.json` keeps the original H census comparable.
- The H3 version of `missing-signatures.json` includes all 146 absent signatures across 132 names.
  The strict audit includes generic overloads skipped by the canonical comparator.
- `h3-out-of-scope.json`, `h3-out-of-scope-callers.txt` and
  `h3-missing-signature-callers.json` document feature-specific generic exclusions.
  H3 left shared/erased signatures with uncertain live callers unfinished.
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

In the H3 inventory, status `not done` takes precedence over raw layout/semantic labels for unfinished
source or missing native signatures. `out of scope` identifies the 16 feature-specific
missing names. A reconstructed method's status does not certify its dependency closure.
The report lists unfinished callees separately.

## Reproduce the comparison

```sh
Tools/build_android.sh
/data/xy/gakumas/scripts/live_check.sh /data/xy/gakumas/live-urp-codex "$(cat Evidence/TaskH/h4-census-regex.txt)"
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

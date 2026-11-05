# ToEuler return-register audit (APK 3.5.3)

`ActorAnimation.ActorAnimationMathUtility.ToEuler` at `0x657cb30` calls `ThreeAxisRot`, then rearranges its three float return registers. The previous reconstruction directly returned the helper for every order. Hex-Rays' untyped output did not show the return-register moves. The normalized comparator strips register-to-register moves; its previous accepted result cannot establish this dataflow.

Let `(a,b,c)` be the helper's returned `(s0,s1,s2)`.

| Rotation order | Native return | Branch / shuffle addresses |
| --- | --- | --- |
| XYZ (0) | `(c,b,a)` / `.zyx` | `0x657ccd8–0x657cce4`, `0x657cdd8`, common return |
| XZY (1) | `(c,a,b)` / `.zxy` | `0x657cdcc–0x657cddc`, common return |
| YXZ (2) | `(b,c,a)` / `.yzx` | `0x657cbec–0x657cbf8`, `0x657cd4c`, common return |
| YZX (3) | `(a,c,b)` / `.xzy` | `0x657cd44–0x657cd50`, common return |
| ZXY (4) | `(b,a,c)` / `.yxz` | `0x657ce38–0x657ce44`, common return |
| ZYX (5) | `(a,b,c)` / `.xyz` | `0x657cc70–0x657cc78`, `0x657ce44`, common return |

Common return `0x657ce48–0x657ce60` moves `s3` into `s1` and `s4` into `s2`. The complete raw disassembly is `to-euler-game.asm`.

All eight skirt drivers in Temari's `cstm-0003` body use XYZ. This helper also serves other Quartz drivers; no costume coefficients, capsule geometry, masks, limits or solver iterations were adjusted.

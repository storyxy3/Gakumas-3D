=== Campus.Timeline.CampusDirectorControlAsset$$CreatePlayable @ 0x4e1cff4 (80 insns)
    UnityEngine_Playables_Playable_o Campus_Timeline_CampusDirectorControlAsset__CreatePlayable (Campus_Timeline_CampusDirectorControlAsset_o* __this, UnityEngine_Playables_PlayableGraph_o graph, UnityEngine_GameObject_o* owner, const MethodInfo* method);
  04e1cff4  sub     sp, sp, #0x40
  04e1cff8  str     x30, [sp, #0x10]
  04e1cffc  stp     x22, x21, [sp, #0x20]
  04e1d000  stp     x20, x19, [sp, #0x30]
  04e1d004  adrp    x22, #0x5836000
  04e1d008  adrp    x21, #0x5509000
  04e1d00c  adrp    x20, #0x54c9000
  04e1d010  ldrb    w8, [x22, #0xcdc]
  04e1d014  ldr     x21, [x21, #0x170]  ; MMETH Method$UnityEngine.ExposedReference<PlayableDirector>.Resolve()
  04e1d018  b       #0x50a7664
  04e1d01c  mov     x19, x0
  04e1d020  stp     x1, x2, [sp]
  04e1d024  tbnz    w8, #0, #0x4e1d06c
  04e1d028  adrp    x0, #0x5509000
  04e1d02c  ldr     x0, [x0, #0x170]  ; MMETH Method$UnityEngine.ExposedReference<PlayableDirector>.Resolve()
  04e1d030  bl      #0x26808d0
  04e1d034  adrp    x0, #0x54c9000
  04e1d038  ldr     x0, [x0, #0xe40]  ; META UnityEngine.Object_TypeInfo
  04e1d03c  bl      #0x26808d0
  04e1d040  adrp    x0, #0x54d0000
  04e1d044  ldr     x0, [x0, #0xed8]  ; META UnityEngine.Playables.Playable_TypeInfo
  04e1d048  bl      #0x26808d0
  04e1d04c  adrp    x0, #0x54f1000
  04e1d050  ldr     x0, [x0, #0xf18]  ; MMETH Method$UnityEngine.Playables.ScriptPlayable<DirectorControlPlayable>.op_Implicit()
  04e1d054  bl      #0x26808d0
  04e1d058  adrp    x0, #0x54f1000
  04e1d05c  ldr     x0, [x0, #0xf20]  ; META UnityEngine.Playables.ScriptPlayable<DirectorControlPlayable>_TypeInfo
  04e1d060  bl      #0x26808d0
  04e1d064  mov     w8, #1
  04e1d068  strb    w8, [x22, #0xcdc]
  04e1d06c  mov     x0, sp
  04e1d070  mov     x1, xzr
  04e1d074  bl      #0x4b3b460  ; -> UnityEngine.Playables.PlayableGraph$$GetResolver
  04e1d078  ldr     x2, [x21]
  04e1d07c  mov     x1, x0
  04e1d080  add     x0, x19, #0x18
  04e1d084  bl      #0x427adec  ; -> UnityEngine.ExposedReference<object>$$Resolve
  04e1d088  ldr     x8, [x20]
  04e1d08c  mov     x19, x0
  04e1d090  ldr     w9, [x8, #0xe4]
  04e1d094  cbnz    w9, #0x4e1d0a0
  04e1d098  mov     x0, x8
  04e1d09c  bl      #0x2680a4c
  04e1d0a0  mov     x0, x19
  04e1d0a4  mov     x1, xzr
  04e1d0a8  mov     x2, xzr
  04e1d0ac  bl      #0x4b250f8  ; -> UnityEngine.Object$$op_Equality
  04e1d0b0  tbz     w0, #0, #0x4e1d0d8
  04e1d0b4  adrp    x8, #0x54d0000
  04e1d0b8  ldr     x8, [x8, #0xed8]  ; META UnityEngine.Playables.Playable_TypeInfo
  04e1d0bc  ldr     x0, [x8]
  04e1d0c0  ldr     w8, [x0, #0xe4]
  04e1d0c4  cbnz    w8, #0x4e1d0cc
  04e1d0c8  bl      #0x2680a4c
  04e1d0cc  mov     x0, xzr
  04e1d0d0  bl      #0x4b3a76c  ; -> UnityEngine.Playables.Playable$$get_Null
  04e1d0d4  b       #0x4e1d120
  04e1d0d8  adrp    x20, #0x54f1000
  04e1d0dc  adrp    x21, #0x54f1000
  04e1d0e0  mov     x2, x19
  04e1d0e4  ldr     x20, [x20, #0xf20]  ; META UnityEngine.Playables.ScriptPlayable<DirectorControlPlayable>_TypeInfo
  04e1d0e8  ldr     x21, [x21, #0xf18]  ; MMETH Method$UnityEngine.Playables.ScriptPlayable<DirectorControlPlayable>.op_Implicit()
  04e1d0ec  mov     x3, xzr
  04e1d0f0  ldp     x0, x1, [sp]
  04e1d0f4  bl      #0x4a854e4  ; -> UnityEngine.Timeline.DirectorControlPlayable$$Create
  04e1d0f8  mov     x19, x0
  04e1d0fc  ldr     x0, [x20]
  04e1d100  mov     x20, x1
  04e1d104  ldr     w8, [x0, #0xe4]
  04e1d108  cbnz    w8, #0x4e1d110
  04e1d10c  bl      #0x2680a4c
  04e1d110  ldr     x2, [x21]
  04e1d114  mov     x0, x19
  04e1d118  mov     x1, x20
  04e1d11c  bl      #0x3379b44  ; -> UnityEngine.Playables.ScriptPlayable<object>$$op_Implicit
  04e1d120  ldp     x20, x19, [sp, #0x30]
  04e1d124  ldr     x30, [sp, #0x10]
  04e1d128  ldp     x22, x21, [sp, #0x20]
  04e1d12c  add     sp, sp, #0x40
  04e1d130  ret     

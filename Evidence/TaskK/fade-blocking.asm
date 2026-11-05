=== Campus.Common.Extensions.CanvasGroupExtensions$$SetBlockingAlpha @ 0x7470d0c (41 insns)
    void Campus_Common_Extensions_CanvasGroupExtensions__SetBlockingAlpha (UnityEngine_CanvasGroup_o* canvasGroup, float alpha, const MethodInfo* method);
  07470d0c  str     d8, [sp, #-0x20]!
  07470d10  str     x30, [sp, #8]
  07470d14  stp     x20, x19, [sp, #0x10]
  07470d18  cbz     x0, #0x7470dac
  07470d1c  mov     x1, xzr
  07470d20  mov     x19, x0
  07470d24  fmov    s8, s0
  07470d28  bl      #0xdca6ae0  ; -> UnityEngine.CanvasGroup$$set_alpha
  07470d2c  mov     x0, x19
  07470d30  mov     x1, xzr
  07470d34  bl      #0xdca6bb4  ; -> UnityEngine.CanvasGroup$$get_interactable
  07470d38  tbz     w0, #0, #0x7470d50
  07470d3c  mov     x0, x19
  07470d40  mov     x1, xzr
  07470d44  bl      #0xdca6d2c  ; -> UnityEngine.CanvasGroup$$get_blocksRaycasts
  07470d48  and     w8, w0, #1
  07470d4c  b       #0x7470d54
  07470d50  mov     w8, wzr
  07470d54  fmov    s0, #1.00000000
  07470d58  fcmp    s8, s0
  07470d5c  cset    w9, pl
  07470d60  cmp     w8, w9
  07470d64  b.ne    #0x7470d78
  07470d68  ldp     x20, x19, [sp, #0x10]
  07470d6c  ldr     x30, [sp, #8]
  07470d70  ldr     d8, [sp], #0x20
  07470d74  ret     
  07470d78  fcmp    s8, s0
  07470d7c  mov     x0, x19
  07470d80  mov     x2, xzr
  07470d84  cset    w20, pl
  07470d88  mov     w1, w20
  07470d8c  bl      #0xdca6c68  ; -> UnityEngine.CanvasGroup$$set_interactable
  07470d90  mov     x0, x19
  07470d94  mov     w1, w20
  07470d98  ldr     x30, [sp, #8]
  07470d9c  ldp     x20, x19, [sp, #0x10]
  07470da0  mov     x2, xzr
  07470da4  ldr     d8, [sp], #0x20
  07470da8  b       #0xdca6de0  ; -> UnityEngine.CanvasGroup$$set_blocksRaycasts
  07470dac  bl      #0x63cf120

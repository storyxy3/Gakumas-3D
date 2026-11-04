=== VLB.VLBDrawCallSystem.DrawCallJob$$UpdateParams @ 0xe0cb778 (256 insns)
    void VLB_VLBDrawCallSystem_DrawCallJob__UpdateParams (VLB_VLBDrawCallSystem_DrawCallJob_o __this, int32_t instanceIndex, int32_t visibleIndex, const MethodInfo* method);
  0e0cb778  sub     sp, sp, #0x170
  0e0cb77c  stp     d15, d14, [sp, #0xf0]
  0e0cb780  stp     d13, d12, [sp, #0x100]
  0e0cb784  stp     d11, d10, [sp, #0x110]
  0e0cb788  stp     d9, d8, [sp, #0x120]
  0e0cb78c  str     x29, [sp, #0x130]
  0e0cb790  stp     x30, x23, [sp, #0x140]
  0e0cb794  stp     x22, x21, [sp, #0x150]
  0e0cb798  stp     x20, x19, [sp, #0x160]
  0e0cb79c  ldr     x8, [x0, #0x20]
  0e0cb7a0  mov     x19, x0
  0e0cb7a4  mov     x0, xzr
  0e0cb7a8  sxtw    x21, w2
  0e0cb7ac  mov     w20, w1
  0e0cb7b0  add     x8, x8, w2, sxtw #4
  0e0cb7b4  ldp     s0, s8, [x8]
  0e0cb7b8  ldp     s9, s11, [x8, #8]
  0e0cb7bc  bl      #0xd9c4d94  ; -> UnityEngine.Mathf$$GammaToLinearSpace
  0e0cb7c0  fmov    s10, s0
  0e0cb7c4  fmov    s0, s8
  0e0cb7c8  mov     x0, xzr
  0e0cb7cc  bl      #0xd9c4d94  ; -> UnityEngine.Mathf$$GammaToLinearSpace
  0e0cb7d0  fmov    s8, s0
  0e0cb7d4  fmov    s0, s9
  0e0cb7d8  mov     x0, xzr
  0e0cb7dc  bl      #0xd9c4d94  ; -> UnityEngine.Mathf$$GammaToLinearSpace
  0e0cb7e0  ldr     x8, [x19, #0x150]
  0e0cb7e4  add     x0, sp, #0x30
  0e0cb7e8  mov     x1, xzr
  0e0cb7ec  add     x8, x8, w20, sxtw #4
  0e0cb7f0  stp     s10, s8, [x8]
  0e0cb7f4  stp     s0, s11, [x8, #8]
  0e0cb7f8  ldr     x8, [x19]
  0e0cb7fc  add     x8, x8, x21, lsl #6
  0e0cb800  ldp     q0, q1, [x8]
  0e0cb804  ldp     q2, q3, [x8, #0x20]
  0e0cb808  add     x8, sp, #0x70
  0e0cb80c  stp     q0, q1, [sp, #0x30]
  0e0cb810  stp     q2, q3, [sp, #0x50]
  0e0cb814  stp     q0, q1, [sp, #0xb0]
  0e0cb818  stp     q2, q3, [sp, #0xd0]
  0e0cb81c  bl      #0xd70579c  ; -> Unity.Mathematics.math$$inverse
  0e0cb820  ldr     s15, [sp, #0x78]
  0e0cb824  ldr     s8, [sp, #0x88]
  0e0cb828  ldr     s11, [sp, #0x98]
  0e0cb82c  ldr     d14, [sp, #0x70]
  0e0cb830  ldr     d13, [sp, #0x80]
  0e0cb834  ldrb    w8, [x19, #0x128]
  0e0cb838  ldr     d12, [sp, #0x90]
  0e0cb83c  ldr     d9, [sp, #0xa0]
  0e0cb840  ldr     s10, [sp, #0xa8]
  0e0cb844  cbz     w8, #0xe0cb850
  0e0cb848  fmov    s0, #-1.00000000
  0e0cb84c  b       #0xe0cb8a4
  0e0cb850  ldr     s0, [x19, #0x110]
  0e0cb854  ldr     s1, [x19, #0x114]
  0e0cb858  ldr     s4, [x19, #0x118]
  0e0cb85c  ldr     x8, [x19, #0x90]
  0e0cb860  ldr     x9, [x19, #0xa0]
  0e0cb864  fmul    v2.2s, v14.2s, v0.s[0]
  0e0cb868  fmul    v3.2s, v13.2s, v1.s[0]
  0e0cb86c  fmul    s0, s15, s0
  0e0cb870  fmul    s1, s8, s1
  0e0cb874  fadd    v2.2s, v2.2s, v3.2s
  0e0cb878  fmul    v3.2s, v12.2s, v4.s[0]
  0e0cb87c  fadd    s0, s0, s1
  0e0cb880  fmul    s1, s11, s4
  0e0cb884  ldr     s4, [x9, x21, lsl #2]
  0e0cb888  fadd    v2.2s, v2.2s, v3.2s
  0e0cb88c  ldr     s3, [x8, x21, lsl #2]
  0e0cb890  fadd    s1, s0, s1
  0e0cb894  fadd    v0.2s, v9.2s, v2.2s
  0e0cb898  fadd    s2, s10, s1
  0e0cb89c  mov     s1, v0.s[1]
  0e0cb8a0  bl      #0xe0cbb78  ; -> VLB.VLBDrawCallSystem.DrawCallJob$$GetInsideBeamFactorFromObjectSpacePos
  0e0cb8a4  ldr     s4, [x19, #0x11c]
  0e0cb8a8  ldr     s1, [x19, #0x120]
  0e0cb8ac  adrp    x22, #0xf400000
  0e0cb8b0  ldrb    w8, [x22, #0x4be]
  0e0cb8b4  fmul    s2, s15, s4
  0e0cb8b8  fmul    s3, s8, s1
  0e0cb8bc  fmul    v5.2s, v14.2s, v4.s[0]
  0e0cb8c0  fmul    v1.2s, v13.2s, v1.s[0]
  0e0cb8c4  ldr     s4, [x19, #0x124]
  0e0cb8c8  fadd    s2, s2, s3
  0e0cb8cc  fmul    s3, s11, s4
  0e0cb8d0  fadd    v5.2s, v5.2s, v1.2s
  0e0cb8d4  fmul    v1.2s, v12.2s, v4.s[0]
  0e0cb8d8  fadd    s11, s2, s3
  0e0cb8dc  fadd    v8.2s, v5.2s, v1.2s
  0e0cb8e0  cbnz    w8, #0xe0cb900
  0e0cb8e4  adrp    x0, #0xea67000
  0e0cb8e8  fmov    s12, s0
  0e0cb8ec  ldr     x0, [x0, #0x190]  ; META System.Math_TypeInfo
  0e0cb8f0  bl      #0x63cee78
  0e0cb8f4  fmov    s0, s12
  0e0cb8f8  mov     w8, #1
  0e0cb8fc  strb    w8, [x22, #0x4be]
  0e0cb900  adrp    x22, #0xea67000
  0e0cb904  fadd    v8.2s, v9.2s, v8.2s
  0e0cb908  fadd    s9, s10, s11
  0e0cb90c  ldr     x22, [x22, #0x190]  ; META System.Math_TypeInfo
  0e0cb910  sxtw    x20, w20
  0e0cb914  ldr     x0, [x22]
  0e0cb918  ldr     w8, [x0, #0xe4]
  0e0cb91c  cbnz    w8, #0xe0cb92c
  0e0cb920  fmov    s10, s0
  0e0cb924  bl      #0x63ceff4
  0e0cb928  fmov    s0, s10
  0e0cb92c  fmul    v2.2s, v8.2s, v8.2s
  0e0cb930  fmul    s1, s9, s9
  0e0cb934  ldr     x8, [x19, #0x160]
  0e0cb938  adrp    x10, #0x276e000
  0e0cb93c  mov     x0, xzr
  0e0cb940  add     x8, x8, x20, lsl #4
  0e0cb944  faddp   s2, v2.2s
  0e0cb948  fadd    s1, s1, s2
  0e0cb94c  fsqrt   s2, s1
  0e0cb950  fmov    s1, #1.00000000
  0e0cb954  fdiv    s2, s1, s2
  0e0cb958  fmul    v1.2s, v8.2s, v2.s[0]
  0e0cb95c  fmul    s2, s9, s2
  0e0cb960  str     d1, [x8]
  0e0cb964  stp     s2, s0, [x8, #8]
  0e0cb968  ldr     s2, [x10, #0xa84]
  0e0cb96c  ldr     x9, [x19, #0x40]
  0e0cb970  ldr     x8, [x19, #0x30]
  0e0cb974  ldr     x11, [x19, #0x50]
  0e0cb978  ldr     x10, [x19, #0x60]
  0e0cb97c  str     s2, [sp, #0x24]
  0e0cb980  add     x9, x9, x21, lsl #3
  0e0cb984  add     x8, x8, x21, lsl #3
  0e0cb988  add     x10, x10, x21, lsl #4
  0e0cb98c  ldp     s4, s3, [x9]
  0e0cb990  ldr     x9, [x19, #0x70]
  0e0cb994  ldp     s0, s1, [x8]
  0e0cb998  add     x8, x11, x21, lsl #4
  0e0cb99c  add     x9, x9, x21, lsl #3
  0e0cb9a0  ldp     s10, s9, [x10]
  0e0cb9a4  stp     s4, s3, [sp, #0x1c]
  0e0cb9a8  ldp     s4, s3, [x8]
  0e0cb9ac  fmaxnm  s15, s0, s2
  0e0cb9b0  fmaxnm  s8, s1, s2
  0e0cb9b4  ldp     s14, s13, [x10, #8]
  0e0cb9b8  stp     s4, s3, [sp, #0xc]
  0e0cb9bc  ldp     s4, s3, [x8, #8]
  0e0cb9c0  ldr     x8, [x19, #0x10]
  0e0cb9c4  ldp     s12, s11, [x9]
  0e0cb9c8  add     x8, x8, x21, lsl #6
  0e0cb9cc  stp     s4, s3, [sp, #0x14]
  0e0cb9d0  ldp     s0, s1, [x8, #0x30]
  0e0cb9d4  ldr     s2, [x8, #0x38]
  0e0cb9d8  bl      #0xd704a68  ; -> Unity.Mathematics.noise$$snoise
  0e0cb9dc  ldr     x8, [x19, #0x170]
  0e0cb9e0  ldp     s4, s1, [sp, #0xc]
  0e0cb9e4  adrp    x23, #0xf400000
  0e0cb9e8  add     x8, x8, x20, lsl #6
  0e0cb9ec  ldrb    w10, [x23, #0x4f4]
  0e0cb9f0  stp     s15, s4, [x8]
  0e0cb9f4  ldr     s4, [sp, #0x1c]
  0e0cb9f8  stp     s8, s1, [x8, #0x10]
  0e0cb9fc  ldr     s1, [sp, #0x14]
  0e0cba00  stp     s10, s12, [x8, #8]
  0e0cba04  stp     s4, s1, [x8, #0x20]
  0e0cba08  ldr     s4, [sp, #0x20]
  0e0cba0c  ldr     s1, [sp, #0x18]
  0e0cba10  stp     s9, s11, [x8, #0x18]
  0e0cba14  str     s14, [x8, #0x28]
  0e0cba18  str     wzr, [x8, #0x2c]
  0e0cba1c  stp     s4, s1, [x8, #0x30]
  0e0cba20  stp     s13, s0, [x8, #0x38]
  0e0cba24  ldr     x8, [x19, #0x90]
  0e0cba28  ldr     x9, [x19, #0xa0]
  0e0cba2c  ldr     s9, [x8, x21, lsl #2]
  0e0cba30  ldr     s10, [x9, x21, lsl #2]
  0e0cba34  cbnz    w10, #0xe0cba4c
  0e0cba38  adrp    x0, #0xea67000
  0e0cba3c  ldr     x0, [x0, #0x190]  ; META System.Math_TypeInfo
  0e0cba40  bl      #0x63cee78
  0e0cba44  mov     w8, #1
  0e0cba48  strb    w8, [x23, #0x4f4]
  0e0cba4c  ldr     x0, [x22]
  0e0cba50  ldr     w8, [x0, #0xe4]
  0e0cba54  cbnz    w8, #0xe0cba5c
  0e0cba58  bl      #0x63ceff4
  0e0cba5c  adrp    x23, #0xf400000
  0e0cba60  ldrb    w8, [x23, #0x4bf]
  0e0cba64  cbnz    w8, #0xe0cba7c
  0e0cba68  adrp    x0, #0xea67000
  0e0cba6c  ldr     x0, [x0, #0x190]  ; META System.Math_TypeInfo
  0e0cba70  bl      #0x63cee78
  0e0cba74  mov     w8, #1
  0e0cba78  strb    w8, [x23, #0x4bf]
  0e0cba7c  ldr     x0, [x22]
  0e0cba80  ldr     w8, [x0, #0xe4]
  0e0cba84  cbnz    w8, #0xe0cba8c
  0e0cba88  bl      #0x63ceff4
  0e0cba8c  adrp    x8, #0x276e000
  0e0cba90  fmov    s1, #0.50000000
  0e0cba94  add     x0, sp, #0x138
  0e0cba98  ldr     s0, [x8, #0xb44]
  0e0cba9c  add     x1, sp, #0x28
  0e0cbaa0  fmul    s0, s10, s0
  0e0cbaa4  fmul    s0, s0, s1
  0e0cbaa8  fcvt    d0, s0
  0e0cbaac  bl      #0xe1b84a0
  0e0cbab0  fabs    s0, s9
  0e0cbab4  ldr     x8, [x19, #0xc0]
  0e0cbab8  ldr     s3, [sp, #0x24]
  0e0cbabc  ldr     x9, [x19, #0xb0]
  0e0cbac0  ldr     x11, [x19, #0xe0]
  0e0cbac4  movi    d1, #0000000000000000
  0e0cbac8  ldr     s2, [x8, x21, lsl #2]
  0e0cbacc  ldr     x8, [x19, #0xd0]
  0e0cbad0  fcmp    s9, #0.0
  0e0cbad4  ldr     x10, [x19, #0x180]
  0e0cbad8  add     x9, x9, x21, lsl #3
  0e0cbadc  ldr     s6, [x11, x21, lsl #2]
  0e0cbae0  fmaxnm  s0, s0, s3
  0e0cbae4  ldr     s5, [x8, x21, lsl #2]
  0e0cbae8  ldr     d3, [sp, #0x138]
  0e0cbaec  add     x10, x10, x20, lsl #6
  0e0cbaf0  ldp     s7, s16, [x9]
  0e0cbaf4  fmov    w11, s5
  0e0cbaf8  adrp    x9, #0x276e000
  0e0cbafc  ldr     d4, [sp, #0x28]
  0e0cbb00  str     d1, [x10, #8]
  0e0cbb04  mov     w8, #0x7f800000
  0e0cbb08  fcvt    s3, d3
  0e0cbb0c  fneg    s17, s0
  0e0cbb10  str     d1, [x10, #0x18]
  0e0cbb14  fcvt    s4, d4
  0e0cbb18  str     d1, [x10, #0x28]
  0e0cbb1c  ldr     s1, [x9, #0xb48]
  0e0cbb20  and     w9, w11, #0x7fffffff
  0e0cbb24  ldp     x20, x19, [sp, #0x160]
  0e0cbb28  ldr     x29, [sp, #0x130]
  0e0cbb2c  ldp     x22, x21, [sp, #0x150]
  0e0cbb30  str     wzr, [x10, #0x10]
  0e0cbb34  fcsel   s0, s17, s0, lt
  0e0cbb38  cmp     w9, w8
  0e0cbb3c  str     s16, [x10, #0x14]
  0e0cbb40  fccmp   s5, s1, #8, ls
  0e0cbb44  ldp     x30, x23, [sp, #0x140]
  0e0cbb48  ldp     d9, d8, [sp, #0x120]
  0e0cbb4c  stp     s4, s2, [x10, #0x20]
  0e0cbb50  ldp     d11, d10, [sp, #0x110]
  0e0cbb54  str     s3, [x10, #0x30]
  0e0cbb58  fcsel   s1, s1, s5, mi
  0e0cbb5c  ldp     d13, d12, [sp, #0x100]
  0e0cbb60  ldp     d15, d14, [sp, #0xf0]
  0e0cbb64  stp     s0, s7, [x10]
  0e0cbb68  str     wzr, [x10, #0x3c]
  0e0cbb6c  stp     s1, s6, [x10, #0x34]
  0e0cbb70  add     sp, sp, #0x170
  0e0cbb74  ret     

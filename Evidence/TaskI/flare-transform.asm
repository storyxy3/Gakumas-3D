=== ProFlareUpdateJob$$Execute @ 0xd1d5bb4 (127 insns)
    void ProFlareUpdateJob__Execute (ProFlareUpdateJob_o __this, int32_t index, UnityEngine_Jobs_TransformAccess_o transform, const MethodInfo* method);
  0d1d5bb4  sub     sp, sp, #0x80
  0d1d5bb8  stp     d15, d14, [sp, #0x10]
  0d1d5bbc  stp     d13, d12, [sp, #0x20]
  0d1d5bc0  stp     d11, d10, [sp, #0x30]
  0d1d5bc4  stp     d9, d8, [sp, #0x40]
  0d1d5bc8  str     x30, [sp, #0x50]
  0d1d5bcc  stp     x22, x21, [sp, #0x60]
  0d1d5bd0  stp     x20, x19, [sp, #0x70]
  0d1d5bd4  sxtw    x20, w1
  0d1d5bd8  ldr     x8, [x0, #0x60]
  0d1d5bdc  stp     x2, x3, [sp]
  0d1d5be0  mov     x19, x0
  0d1d5be4  mov     x0, sp
  0d1d5be8  mov     x1, xzr
  0d1d5bec  add     x8, x8, x20, lsl #5
  0d1d5bf0  ldr     w21, [x8]
  0d1d5bf4  ldr     s14, [x8, #4]
  0d1d5bf8  bl      #0xd9f4d80  ; -> UnityEngine.Jobs.TransformAccess$$get_isValid
  0d1d5bfc  tbz     w0, #0, #0xd1d5d8c
  0d1d5c00  tbz     w21, #0, #0xd1d5d8c
  0d1d5c04  mov     x0, sp
  0d1d5c08  mov     x1, xzr
  0d1d5c0c  and     w21, w21, #0xffffff00
  0d1d5c10  bl      #0xd9f4a5c  ; -> UnityEngine.Jobs.TransformAccess$$get_position
  0d1d5c14  mov     x0, xzr
  0d1d5c18  bl      #0xd70a1d0  ; -> Unity.Mathematics.float3$$op_Implicit
  0d1d5c1c  mov     x0, x19
  0d1d5c20  fmov    s12, s0
  0d1d5c24  fmov    s13, s1
  0d1d5c28  fmov    s11, s2
  0d1d5c2c  bl      #0xd1d5db0  ; -> ProFlareUpdateJob$$WorldToViewportPoint
  0d1d5c30  fmov    s8, s0
  0d1d5c34  fadd    s0, s14, s0
  0d1d5c38  mov     w8, wzr
  0d1d5c3c  fmov    s10, s1
  0d1d5c40  fmov    s15, #1.00000000
  0d1d5c44  fmov    s9, s2
  0d1d5c48  fsub    s1, s8, s14
  0d1d5c4c  fcmp    s0, #0.0
  0d1d5c50  fccmp   s1, s15, #0, gt
  0d1d5c54  b.pl    #0xd1d5c74
  0d1d5c58  fadd    s0, s14, s10
  0d1d5c5c  fcmp    s0, #0.0
  0d1d5c60  b.le    #0xd1d5c74
  0d1d5c64  fsub    s0, s10, s14
  0d1d5c68  fmov    s1, #1.00000000
  0d1d5c6c  fcmp    s0, s1
  0d1d5c70  cset    w8, mi
  0d1d5c74  fcmp    s9, #0.0
  0d1d5c78  ldrb    w10, [x19]
  0d1d5c7c  mov     x0, sp
  0d1d5c80  mov     x1, xzr
  0d1d5c84  cset    w9, gt
  0d1d5c88  fcmp    s9, s15
  0d1d5c8c  cset    w11, mi
  0d1d5c90  cmp     w10, #0
  0d1d5c94  csel    w9, w9, w11, eq
  0d1d5c98  and     w22, w8, w9
  0d1d5c9c  bl      #0xd9f4afc  ; -> UnityEngine.Jobs.TransformAccess$$get_rotation
  0d1d5ca0  mov     x0, xzr
  0d1d5ca4  bl      #0xd70d6ac  ; -> Unity.Mathematics.quaternion$$op_Implicit
  0d1d5ca8  movi    d4, #0000000000000000
  0d1d5cac  fmul    s5, s2, s4
  0d1d5cb0  fmul    s6, s0, s4
  0d1d5cb4  fmul    s7, s1, s4
  0d1d5cb8  fsub    s16, s1, s5
  0d1d5cbc  fsub    s5, s5, s0
  0d1d5cc0  fsub    s6, s6, s7
  0d1d5cc4  fadd    s7, s16, s16
  0d1d5cc8  fadd    s5, s5, s5
  0d1d5ccc  fadd    s6, s6, s6
  0d1d5cd0  fmul    s16, s3, s7
  0d1d5cd4  fmul    s17, s3, s5
  0d1d5cd8  fmul    s3, s3, s6
  0d1d5cdc  fmul    s18, s0, s5
  0d1d5ce0  fmul    s5, s2, s5
  0d1d5ce4  fmul    s2, s2, s7
  0d1d5ce8  fmul    s7, s1, s7
  0d1d5cec  fmul    s1, s1, s6
  0d1d5cf0  fmul    s0, s0, s6
  0d1d5cf4  fadd    s6, s16, s4
  0d1d5cf8  fadd    s4, s17, s4
  0d1d5cfc  fadd    s3, s3, s15
  0d1d5d00  ldr     s17, [x19, #0xc]
  0d1d5d04  fsub    s7, s18, s7
  0d1d5d08  fsub    s1, s1, s5
  0d1d5d0c  fsub    s2, s2, s0
  0d1d5d10  ldp     s5, s16, [x19, #4]
  0d1d5d14  fadd    s0, s6, s1
  0d1d5d18  fadd    s1, s4, s2
  0d1d5d1c  fadd    s2, s3, s7
  0d1d5d20  fsub    s3, s5, s12
  0d1d5d24  fsub    s4, s16, s13
  0d1d5d28  fsub    s5, s17, s11
  0d1d5d2c  bl      #0xd1d5e20  ; -> ProFlareUpdateJob$$Angle
  0d1d5d30  ldp     s1, s2, [x19, #4]
  0d1d5d34  mov     x0, sp
  0d1d5d38  ldp     s3, s4, [x19, #0xc]
  0d1d5d3c  mov     x1, xzr
  0d1d5d40  ldp     s5, s6, [x19, #0x14]
  0d1d5d44  fsub    s1, s12, s1
  0d1d5d48  fsub    s2, s13, s2
  0d1d5d4c  fsub    s3, s11, s3
  0d1d5d50  fmov    s11, s0
  0d1d5d54  fmul    s1, s1, s4
  0d1d5d58  fmul    s2, s2, s5
  0d1d5d5c  fadd    s1, s1, s2
  0d1d5d60  fmul    s2, s3, s6
  0d1d5d64  fadd    s12, s2, s1
  0d1d5d68  bl      #0xd9f4c30  ; -> UnityEngine.Jobs.TransformAccess$$get_localScale
  0d1d5d6c  ldr     x8, [x19, #0x60]
  0d1d5d70  orr     w9, w21, w22
  0d1d5d74  add     x8, x8, x20, lsl #5
  0d1d5d78  str     w9, [x8]
  0d1d5d7c  stp     s14, s8, [x8, #4]
  0d1d5d80  stp     s10, s9, [x8, #0xc]
  0d1d5d84  stp     s11, s12, [x8, #0x14]
  0d1d5d88  str     s0, [x8, #0x1c]
  0d1d5d8c  ldp     x20, x19, [sp, #0x70]
  0d1d5d90  ldr     x30, [sp, #0x50]
  0d1d5d94  ldp     x22, x21, [sp, #0x60]
  0d1d5d98  ldp     d9, d8, [sp, #0x40]
  0d1d5d9c  ldp     d11, d10, [sp, #0x30]
  0d1d5da0  ldp     d13, d12, [sp, #0x20]
  0d1d5da4  ldp     d15, d14, [sp, #0x10]
  0d1d5da8  add     sp, sp, #0x80
  0d1d5dac  ret     
=== ProFlareUpdateJob$$WorldToViewportPoint @ 0xd1d5db0 (28 insns)
    Unity_Mathematics_float3_o ProFlareUpdateJob__WorldToViewportPoint (ProFlareUpdateJob_o __this, Unity_Mathematics_float3_o position, const MethodInfo* method);
  0d1d5db0  ldur    d3, [x0, #0x24]
  0d1d5db4  ldur    d4, [x0, #0x34]
  0d1d5db8  ldur    d5, [x0, #0x44]
  0d1d5dbc  ldur    d6, [x0, #0x1c]
  0d1d5dc0  ldur    d7, [x0, #0x2c]
  0d1d5dc4  fmul    v3.2s, v3.2s, v0.s[0]
  0d1d5dc8  fmul    v4.2s, v4.2s, v1.s[0]
  0d1d5dcc  fmul    v0.2s, v6.2s, v0.s[0]
  0d1d5dd0  fmul    v1.2s, v7.2s, v1.s[0]
  0d1d5dd4  fadd    v3.2s, v3.2s, v4.2s
  0d1d5dd8  fmul    v4.2s, v5.2s, v2.s[0]
  0d1d5ddc  ldur    d5, [x0, #0x3c]
  0d1d5de0  fadd    v0.2s, v0.2s, v1.2s
  0d1d5de4  fmul    v1.2s, v5.2s, v2.s[0]
  0d1d5de8  ldur    d2, [x0, #0x54]
  0d1d5dec  fadd    v3.2s, v3.2s, v4.2s
  0d1d5df0  fadd    v0.2s, v0.2s, v1.2s
  0d1d5df4  ldur    d1, [x0, #0x4c]
  0d1d5df8  fadd    v2.2s, v3.2s, v2.2s
  0d1d5dfc  fadd    v0.2s, v0.2s, v1.2s
  0d1d5e00  movi    v1.2s, #0x3f, lsl #24
  0d1d5e04  dup     v3.2s, v2.s[1]
  0d1d5e08  fdiv    v0.2s, v0.2s, v3.2s
  0d1d5e0c  fdiv    v2.2s, v2.2s, v3.2s
  0d1d5e10  fmul    v0.2s, v0.2s, v1.2s
  0d1d5e14  fadd    v0.2s, v0.2s, v1.2s
  0d1d5e18  mov     s1, v0.s[1]
  0d1d5e1c  ret     

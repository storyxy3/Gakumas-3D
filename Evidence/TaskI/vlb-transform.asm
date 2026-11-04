=== VLB.VLBUpdateCachedSystem.UpdateTransformsJob$$Execute @ 0xe0ca590 (145 insns)
    void VLB_VLBUpdateCachedSystem_UpdateTransformsJob__Execute (VLB_VLBUpdateCachedSystem_UpdateTransformsJob_o __this, int32_t index, UnityEngine_Jobs_TransformAccess_o transform, const MethodInfo* method);
  0e0ca590  stp     d9, d8, [sp, #-0x40]!
  0e0ca594  stp     x29, x30, [sp, #0x10]
  0e0ca598  stp     x22, x21, [sp, #0x20]
  0e0ca59c  stp     x20, x19, [sp, #0x30]
  0e0ca5a0  sub     sp, sp, #0x2f0
  0e0ca5a4  adrp    x22, #0xf43d000
  0e0ca5a8  adrp    x21, #0xea69000
  0e0ca5ac  mov     w19, w1
  0e0ca5b0  ldrb    w8, [x22, #0x9cd]
  0e0ca5b4  ldr     x21, [x21, #0xf80]  ; META Unity.Mathematics.float3_TypeInfo
  0e0ca5b8  mov     x20, x0
  0e0ca5bc  str     x2, [sp, #0x2e0]
  0e0ca5c0  str     x3, [sp, #0x2e8]
  0e0ca5c4  tbnz    w8, #0, #0xe0ca5dc
  0e0ca5c8  adrp    x0, #0xea69000
  0e0ca5cc  ldr     x0, [x0, #0xf80]  ; META Unity.Mathematics.float3_TypeInfo
  0e0ca5d0  bl      #0x63cee78
  0e0ca5d4  mov     w8, #1
  0e0ca5d8  strb    w8, [x22, #0x9cd]
  0e0ca5dc  add     x8, sp, #0x260
  0e0ca5e0  add     x0, sp, #0x2e0
  0e0ca5e4  mov     x1, xzr
  0e0ca5e8  bl      #0xd9f4cd0  ; -> UnityEngine.Jobs.TransformAccess$$get_localToWorldMatrix
  0e0ca5ec  ldp     q0, q1, [sp, #0x260]
  0e0ca5f0  add     x8, sp, #0x220
  0e0ca5f4  add     x0, sp, #0x1e0
  0e0ca5f8  mov     x1, xzr
  0e0ca5fc  stp     q0, q1, [sp, #0x1e0]
  0e0ca600  ldp     q0, q2, [sp, #0x280]
  0e0ca604  stp     q0, q2, [sp, #0x200]
  0e0ca608  bl      #0xd70c278  ; -> Unity.Mathematics.float4x4$$op_Implicit
  0e0ca60c  mov     w10, #0xc
  0e0ca610  ldr     x11, [x20, #0x10]
  0e0ca614  ldr     x9, [x20]
  0e0ca618  nop     
  0e0ca61c  smaddl  x10, w19, w10, x11
  0e0ca620  ldp     q0, q1, [sp, #0x220]
  0e0ca624  ldp     q2, q3, [sp, #0x240]
  0e0ca628  add     x9, x9, w19, sxtw #4
  0e0ca62c  ldr     x8, [x21]
  0e0ca630  movi    v4.2d, #0000000000000000
  0e0ca634  add     x0, sp, #0x160
  0e0ca638  ldr     s5, [x10]
  0e0ca63c  stp     q0, q1, [sp, #0xa0]
  0e0ca640  mov     x1, xzr
  0e0ca644  stp     q2, q3, [sp, #0xc0]
  0e0ca648  ldr     x8, [x8, #0xb8]
  0e0ca64c  sxtw    x21, w19
  0e0ca650  str     q5, [sp]
  0e0ca654  ldr     s5, [x10, #4]
  0e0ca658  stp     q0, q1, [sp, #0x1a0]
  0e0ca65c  ldp     s0, s1, [x9]
  0e0ca660  stp     q2, q3, [sp, #0x1c0]
  0e0ca664  ldp     s2, s3, [x9, #8]
  0e0ca668  str     q5, [sp, #0x10]
  0e0ca66c  ldr     s5, [x10, #8]
  0e0ca670  ldr     s8, [x8, #8]
  0e0ca674  ldr     d9, [x8]
  0e0ca678  str     wzr, [sp, #0x180]
  0e0ca67c  str     q5, [sp, #0x20]
  0e0ca680  stp     q4, q4, [sp, #0x160]
  0e0ca684  bl      #0xd707ba8  ; -> Unity.Mathematics.float3x3$$.ctor
  0e0ca688  ldp     q1, q4, [sp, #0x1a0]
  0e0ca68c  add     x8, sp, #0x6d
  0e0ca690  ldr     d0, [sp, #0x160]
  0e0ca694  ldr     s2, [sp, #0x168]
  0e0ca698  add     x0, sp, #0x120
  0e0ca69c  ldr     q6, [sp]
  0e0ca6a0  ldur    d3, [x8, #0xff]
  0e0ca6a4  mov     w8, #0x3f800000
  0e0ca6a8  stp     q1, q4, [sp, #0x120]
  0e0ca6ac  ldr     s4, [sp, #0x174]
  0e0ca6b0  add     x1, sp, #0xe0
  0e0ca6b4  fmul    v0.2s, v0.2s, v6.s[0]
  0e0ca6b8  fmul    s1, s6, s2
  0e0ca6bc  str     w8, [sp, #0x11c]
  0e0ca6c0  ldp     q5, q2, [sp, #0x1c0]
  0e0ca6c4  add     x8, sp, #0x160
  0e0ca6c8  mov     x2, xzr
  0e0ca6cc  str     wzr, [sp, #0xec]
  0e0ca6d0  str     wzr, [sp, #0xfc]
  0e0ca6d4  stp     q5, q2, [sp, #0x140]
  0e0ca6d8  ldp     q7, q5, [sp, #0x10]
  0e0ca6dc  ldr     d2, [sp, #0x178]
  0e0ca6e0  str     d0, [sp, #0xe0]
  0e0ca6e4  ldr     s0, [sp, #0x180]
  0e0ca6e8  str     s1, [sp, #0xe8]
  0e0ca6ec  fmul    v3.2s, v3.2s, v7.s[0]
  0e0ca6f0  fmul    s4, s7, s4
  0e0ca6f4  fmul    v1.2s, v2.2s, v5.s[0]
  0e0ca6f8  fmul    s0, s5, s0
  0e0ca6fc  str     wzr, [sp, #0x10c]
  0e0ca700  str     d9, [sp, #0x110]
  0e0ca704  str     s8, [sp, #0x118]
  0e0ca708  str     d3, [sp, #0xf0]
  0e0ca70c  str     s4, [sp, #0xf8]
  0e0ca710  str     d1, [sp, #0x100]
  0e0ca714  str     s0, [sp, #0x108]
  0e0ca718  bl      #0xd7d0e8c
  0e0ca71c  ldr     x8, [x20, #0x20]
  0e0ca720  ldp     q3, q0, [sp, #0xc0]
  0e0ca724  ldp     q1, q2, [sp, #0x160]
  0e0ca728  adrp    x9, #0x2770000
  0e0ca72c  add     x8, x8, x21, lsl #6
  0e0ca730  ldp     q4, q5, [sp, #0x180]
  0e0ca734  add     x0, sp, #0x70
  0e0ca738  add     x1, sp, #0x30
  0e0ca73c  mov     x2, xzr
  0e0ca740  stp     q3, q0, [x8, #0x20]
  0e0ca744  ldp     q0, q6, [sp, #0xa0]
  0e0ca748  stp     q1, q2, [sp, #0x2a0]
  0e0ca74c  ldr     q2, [x9, #0x410]
  0e0ca750  adrp    x9, #0x276c000
  0e0ca754  stp     q4, q5, [sp, #0x2c0]
  0e0ca758  stp     q0, q6, [x8]
  0e0ca75c  ldp     q3, q0, [sp, #0x2c0]
  0e0ca760  ldr     x8, [x20, #0x30]
  0e0ca764  ldp     q1, q4, [sp, #0x2b0]
  0e0ca768  ldr     q5, [sp, #0x2d0]
  0e0ca76c  add     x8, x8, x21, lsl #6
  0e0ca770  stp     q3, q0, [x8, #0x20]
  0e0ca774  ldp     q0, q6, [sp, #0x2a0]
  0e0ca778  ldr     q3, [sp, #0x2a0]
  0e0ca77c  stp     q0, q1, [x8]
  0e0ca780  ldr     d0, [x9, #0xac0]
  0e0ca784  add     x8, sp, #0x88
  0e0ca788  stp     q6, q4, [sp, #0x40]
  0e0ca78c  stp     q5, q2, [sp, #0x60]
  0e0ca790  str     d0, [sp, #0x80]
  0e0ca794  str     q3, [sp, #0x30]
  0e0ca798  bl      #0xe0e3098  ; -> VLB.Utils$$TransformAABB
  0e0ca79c  mov     w8, #0x18
  0e0ca7a0  ldr     x9, [x20, #0x40]
  0e0ca7a4  ldur    q0, [sp, #0x88]
  0e0ca7a8  nop     
  0e0ca7ac  smaddl  x8, w19, w8, x9
  0e0ca7b0  ldr     x9, [sp, #0x98]
  0e0ca7b4  str     x9, [x8, #0x10]
  0e0ca7b8  str     q0, [x8]
  0e0ca7bc  add     sp, sp, #0x2f0
  0e0ca7c0  ldp     x20, x19, [sp, #0x30]
  0e0ca7c4  ldp     x22, x21, [sp, #0x20]
  0e0ca7c8  ldp     x29, x30, [sp, #0x10]
  0e0ca7cc  ldp     d9, d8, [sp], #0x40
  0e0ca7d0  ret     

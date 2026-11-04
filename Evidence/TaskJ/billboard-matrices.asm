=== Campus.Crowd.BillboardMatricesJobHandler.BillboardMatricesJob$$CalculateObjToWorldMatrix @ 0xddc6854 (77 insns)
    UnityEngine_Matrix4x4_o Campus_Crowd_BillboardMatricesJobHandler_BillboardMatricesJob__CalculateObjToWorldMatrix (Campus_Crowd_BillboardMatricesJobHandler_BillboardMatricesJob_o __this, int32_t sumMeshIndex, int32_t forwardIndex, UnityEngine_Matrix4x4_o rotateMatrix, UnityEngine_Bounds_o rotatedBounds, const MethodInfo* method);
  0ddc6854  sub     sp, sp, #0x170
  0ddc6858  stp     d11, d10, [sp, #0x110]
  0ddc685c  stp     d9, d8, [sp, #0x120]
  0ddc6860  str     x29, [sp, #0x130]
  0ddc6864  stp     x30, x23, [sp, #0x140]
  0ddc6868  stp     x22, x21, [sp, #0x150]
  0ddc686c  stp     x20, x19, [sp, #0x160]
  0ddc6870  adrp    x23, #0xf400000
  0ddc6874  ldp     s11, s10, [x4, #0xc]
  0ddc6878  ldp     s9, s8, [x4]
  0ddc687c  mov     x20, x3
  0ddc6880  ldrb    w9, [x23, #0x4bc]
  0ddc6884  mov     w22, w2
  0ddc6888  mov     w21, w1
  0ddc688c  mov     x19, x8
  0ddc6890  cbnz    w9, #0xddc68a8
  0ddc6894  adrp    x0, #0xea6a000
  0ddc6898  ldr     x0, [x0, #0x4c0]  ; META UnityEngine.Quaternion_TypeInfo
  0ddc689c  bl      #0x63cee78
  0ddc68a0  mov     w8, #1
  0ddc68a4  strb    w8, [x23, #0x4bc]
  0ddc68a8  fadd    s0, s11, s11
  0ddc68ac  movi    v1.2s, #0x42, lsl #24
  0ddc68b0  adrp    x8, #0xea6a000
  0ddc68b4  fmov    s2, #0.50000000
  0ddc68b8  fadd    s3, s10, s10
  0ddc68bc  ldr     x8, [x8, #0x4c0]  ; META UnityEngine.Quaternion_TypeInfo
  0ddc68c0  mov     x0, xzr
  0ddc68c4  ldr     x8, [x8]
  0ddc68c8  fmul    s0, s0, s1
  0ddc68cc  fmov    s1, #1.00000000
  0ddc68d0  ldr     x8, [x8, #0xb8]
  0ddc68d4  fdiv    s16, s1, s3
  0ddc68d8  ldp     s3, s4, [x8]
  0ddc68dc  ldp     s5, s6, [x8, #8]
  0ddc68e0  add     x8, sp, #0xd0
  0ddc68e4  fdiv    s7, s1, s0
  0ddc68e8  scvtf   s0, w22
  0ddc68ec  scvtf   s1, w21, #3
  0ddc68f0  fadd    s0, s0, s2
  0ddc68f4  movi    v2.2s, #0x3d, lsl #24
  0ddc68f8  fmul    s0, s0, s2
  0ddc68fc  fmov    s2, #-0.50000000
  0ddc6900  fadd    s0, s1, s0
  0ddc6904  fmul    s1, s9, s7
  0ddc6908  stp     s16, s7, [sp, #4]
  0ddc690c  str     s7, [sp]
  0ddc6910  fsub    s0, s0, s1
  0ddc6914  fnmul   s1, s8, s16
  0ddc6918  fadd    s0, s0, s2
  0ddc691c  movi    d2, #0000000000000000
  0ddc6920  bl      #0xd9c720c  ; -> UnityEngine.Matrix4x4$$TRS
  0ddc6924  ldp     q0, q1, [x20]
  0ddc6928  add     x8, sp, #0x90
  0ddc692c  add     x0, sp, #0x50
  0ddc6930  add     x1, sp, #0x10
  0ddc6934  mov     x2, xzr
  0ddc6938  stp     q0, q1, [sp, #0x10]
  0ddc693c  ldp     q0, q2, [x20, #0x20]
  0ddc6940  stp     q0, q2, [sp, #0x30]
  0ddc6944  ldp     q1, q0, [sp, #0xd0]
  0ddc6948  stp     q1, q0, [sp, #0x50]
  0ddc694c  ldp     q2, q0, [sp, #0xf0]
  0ddc6950  stp     q2, q0, [sp, #0x70]
  0ddc6954  bl      #0xd9c8008  ; -> UnityEngine.Matrix4x4$$op_Multiply
  0ddc6958  ldp     q0, q1, [sp, #0x90]
  0ddc695c  ldr     x29, [sp, #0x130]
  0ddc6960  ldp     x22, x21, [sp, #0x150]
  0ddc6964  ldp     x30, x23, [sp, #0x140]
  0ddc6968  stp     q0, q1, [x19]
  0ddc696c  ldp     q0, q2, [sp, #0xb0]
  0ddc6970  ldp     d9, d8, [sp, #0x120]
  0ddc6974  ldp     d11, d10, [sp, #0x110]
  0ddc6978  stp     q0, q2, [x19, #0x20]
  0ddc697c  ldp     x20, x19, [sp, #0x160]
  0ddc6980  add     sp, sp, #0x170
  0ddc6984  ret     
=== Campus.Crowd.BillboardMatricesJobHandler.BillboardMatricesJob$$CalculateBillboardMatrix @ 0xddc6988 (42 insns)
    UnityEngine_Matrix4x4_o Campus_Crowd_BillboardMatricesJobHandler_BillboardMatricesJob__CalculateBillboardMatrix (Campus_Crowd_BillboardMatricesJobHandler_BillboardMatricesJob_o __this, UnityEngine_Bounds_o rotatedBounds, const MethodInfo* method);
  0ddc6988  sub     sp, sp, #0x80
  0ddc698c  str     d10, [sp, #0x50]
  0ddc6990  stp     d9, d8, [sp, #0x58]
  0ddc6994  str     x30, [sp, #0x68]
  0ddc6998  stp     x20, x19, [sp, #0x70]
  0ddc699c  adrp    x20, #0xf400000
  0ddc69a0  ldp     s9, s8, [x1]
  0ddc69a4  ldrb    w9, [x20, #0x4bc]
  0ddc69a8  ldur    d10, [x1, #0xc]
  0ddc69ac  mov     x19, x8
  0ddc69b0  cbnz    w9, #0xddc69c8
  0ddc69b4  adrp    x0, #0xea6a000
  0ddc69b8  ldr     x0, [x0, #0x4c0]  ; META UnityEngine.Quaternion_TypeInfo
  0ddc69bc  bl      #0x63cee78
  0ddc69c0  mov     w8, #1
  0ddc69c4  strb    w8, [x20, #0x4bc]
  0ddc69c8  adrp    x8, #0xea6a000
  0ddc69cc  fadd    v7.2s, v10.2s, v10.2s
  0ddc69d0  fneg    s0, s9
  0ddc69d4  ldr     x8, [x8, #0x4c0]  ; META UnityEngine.Quaternion_TypeInfo
  0ddc69d8  movi    d2, #0000000000000000
  0ddc69dc  fmov    s1, s8
  0ddc69e0  mov     x0, xzr
  0ddc69e4  ldr     x8, [x8]
  0ddc69e8  ldr     x8, [x8, #0xb8]
  0ddc69ec  ldp     s3, s4, [x8]
  0ddc69f0  ldp     s5, s6, [x8, #8]
  0ddc69f4  mov     w8, #0x3f800000
  0ddc69f8  str     w8, [sp, #8]
  0ddc69fc  add     x8, sp, #0x10
  0ddc6a00  str     d7, [sp]
  0ddc6a04  bl      #0xd9c720c  ; -> UnityEngine.Matrix4x4$$TRS
  0ddc6a08  ldp     q0, q1, [sp, #0x10]
  0ddc6a0c  ldr     x30, [sp, #0x68]
  0ddc6a10  ldp     d9, d8, [sp, #0x58]
  0ddc6a14  ldr     d10, [sp, #0x50]
  0ddc6a18  stp     q0, q1, [x19]
  0ddc6a1c  ldp     q0, q2, [sp, #0x30]
  0ddc6a20  stp     q0, q2, [x19, #0x20]
  0ddc6a24  ldp     x20, x19, [sp, #0x70]
  0ddc6a28  add     sp, sp, #0x80
  0ddc6a2c  ret     

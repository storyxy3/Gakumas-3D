=== ProFlareUpdateElementJob$$GetOffsetPosition @ 0xd1d6138 (89 insns)
    Unity_Mathematics_float3_o ProFlareUpdateElementJob__GetOffsetPosition (ProFlareUpdateElementJob_o __this, ProFlareUpdateElementData_o* input, float* rotateToFlareAngle, const MethodInfo* method);
  0d1d6138  stp     d13, d12, [sp, #-0x50]!
  0d1d613c  stp     d11, d10, [sp, #0x10]
  0d1d6140  stp     d9, d8, [sp, #0x20]
  0d1d6144  stp     x30, x21, [sp, #0x30]
  0d1d6148  stp     x20, x19, [sp, #0x40]
  0d1d614c  ldp     s0, s1, [x1, #0x50]
  0d1d6150  mov     x21, x0
  0d1d6154  ldr     s2, [x1, #0x40]
  0d1d6158  ldr     s3, [x1, #0x58]
  0d1d615c  mov     x0, xzr
  0d1d6160  mov     x19, x2
  0d1d6164  mov     x20, x1
  0d1d6168  fnmul   s0, s2, s0
  0d1d616c  fnmul   s1, s2, s1
  0d1d6170  fnmul   s2, s2, s3
  0d1d6174  bl      #0xd70a1d0  ; -> Unity.Mathematics.float3$$op_Implicit
  0d1d6178  ldr     s2, [x20, #0x58]
  0d1d617c  fmov    s8, s0
  0d1d6180  fmov    s9, s1
  0d1d6184  ldrb    w8, [x21]
  0d1d6188  fmov    s12, s2
  0d1d618c  cbz     w8, #0xd1d61b0
  0d1d6190  fmov    s0, #-1.00000000
  0d1d6194  ldr     s1, [x20, #0x40]
  0d1d6198  fsub    s0, s0, s1
  0d1d619c  ldr     s1, [x21, #4]
  0d1d61a0  fmul    s0, s0, s1
  0d1d61a4  fmov    s1, #1.00000000
  0d1d61a8  fadd    s0, s0, s1
  0d1d61ac  fmul    s12, s2, s0
  0d1d61b0  ldp     s0, s1, [x20, #0x50]
  0d1d61b4  mov     x0, xzr
  0d1d61b8  bl      #0xd70a1d0  ; -> Unity.Mathematics.float3$$op_Implicit
  0d1d61bc  fmov    s10, s0
  0d1d61c0  ldp     s0, s3, [x20, #0x5c]
  0d1d61c4  fmov    s11, s1
  0d1d61c8  ldr     s2, [x20, #0x64]
  0d1d61cc  mov     x0, xzr
  0d1d61d0  fmov    s1, s3
  0d1d61d4  bl      #0xd70a1d0  ; -> Unity.Mathematics.float3$$op_Implicit
  0d1d61d8  fsub    s2, s10, s8
  0d1d61dc  fsub    s3, s11, s9
  0d1d61e0  mov     x0, xzr
  0d1d61e4  fmul    s0, s2, s0
  0d1d61e8  fmul    s1, s3, s1
  0d1d61ec  ldr     s2, [x20, #0x4c]
  0d1d61f0  fadd    s8, s8, s0
  0d1d61f4  fadd    s9, s9, s1
  0d1d61f8  ldp     s0, s1, [x20, #0x44]
  0d1d61fc  bl      #0xd70a1d0  ; -> Unity.Mathematics.float3$$op_Implicit
  0d1d6200  fadd    s8, s8, s0
  0d1d6204  fadd    s9, s9, s1
  0d1d6208  ldrb    w8, [x20, #0x68]
  0d1d620c  fmov    s10, s2
  0d1d6210  cbz     w8, #0xd1d6278
  0d1d6214  adrp    x21, #0xf400000
  0d1d6218  ldp     s13, s11, [x20, #0x50]
  0d1d621c  ldrb    w8, [x21, #0x4c1]
  0d1d6220  cbnz    w8, #0xd1d6238
  0d1d6224  adrp    x0, #0xea67000
  0d1d6228  ldr     x0, [x0, #0x190]  ; META System.Math_TypeInfo
  0d1d622c  bl      #0x63cee78
  0d1d6230  mov     w8, #1
  0d1d6234  strb    w8, [x21, #0x4c1]
  0d1d6238  adrp    x8, #0xea67000
  0d1d623c  fsub    s11, s11, s9
  0d1d6240  fsub    s13, s13, s8
  0d1d6244  ldr     x8, [x8, #0x190]  ; META System.Math_TypeInfo
  0d1d6248  ldr     x0, [x8]
  0d1d624c  ldr     w8, [x0, #0xe4]
  0d1d6250  cbnz    w8, #0xd1d6258
  0d1d6254  bl      #0x63ceff4
  0d1d6258  fcvt    d0, s11
  0d1d625c  fcvt    d1, s13
  0d1d6260  bl      #0xe1b8470
  0d1d6264  fcvt    s0, d0
  0d1d6268  adrp    x8, #0x276e000
  0d1d626c  ldr     s1, [x8, #0x2a0]
  0d1d6270  fmul    s0, s0, s1
  0d1d6274  str     s0, [x19]
  0d1d6278  fadd    s2, s12, s10
  0d1d627c  fmov    s0, s8
  0d1d6280  fmov    s1, s9
  0d1d6284  ldp     x20, x19, [sp, #0x40]
  0d1d6288  ldp     x30, x21, [sp, #0x30]
  0d1d628c  ldp     d9, d8, [sp, #0x20]
  0d1d6290  ldp     d11, d10, [sp, #0x10]
  0d1d6294  ldp     d13, d12, [sp], #0x50
  0d1d6298  ret     

=== VLB.MeshGenerator$$GenerateConeZ_Radii @ 0xe0d6bd0 (551 insns)
    UnityEngine_Mesh_o* VLB_MeshGenerator__GenerateConeZ_Radii (float lengthZ, float radiusStart, float radiusEnd, int32_t numSides, int32_t numSegments, bool cap, bool doubleSided, const MethodInfo* method);
  0e0d6bd0  sub     sp, sp, #0xf0
  0e0d6bd4  stp     d15, d14, [sp, #0x50]
  0e0d6bd8  stp     d13, d12, [sp, #0x60]
  0e0d6bdc  stp     d11, d10, [sp, #0x70]
  0e0d6be0  stp     d9, d8, [sp, #0x80]
  0e0d6be4  stp     x29, x30, [sp, #0x90]
  0e0d6be8  stp     x28, x27, [sp, #0xa0]
  0e0d6bec  stp     x26, x25, [sp, #0xb0]
  0e0d6bf0  stp     x24, x23, [sp, #0xc0]
  0e0d6bf4  stp     x22, x21, [sp, #0xd0]
  0e0d6bf8  stp     x20, x19, [sp, #0xe0]
  0e0d6bfc  fmov    s8, s2
  0e0d6c00  fmov    s9, s1
  0e0d6c04  str     w3, [sp, #4]
  0e0d6c08  adrp    x19, #0xf43d000
  0e0d6c0c  adrp    x21, #0xeb68000
  0e0d6c10  adrp    x24, #0xea96000
  0e0d6c14  ldrb    w8, [x19, #0xa47]
  0e0d6c18  ldr     x21, [x21, #0x8a0]  ; META UnityEngine.Mesh_TypeInfo
  0e0d6c1c  ldr     x24, [x24, #0x648]  ; META UnityEngine.Vector3[]_TypeInfo
  0e0d6c20  mov     w20, w2
  0e0d6c24  mov     w23, w1
  0e0d6c28  mov     w22, w0
  0e0d6c2c  str     q0, [sp, #0x10]
  0e0d6c30  tbnz    w8, #0, #0xe0d6c6c
  0e0d6c34  adrp    x0, #0xea87000
  0e0d6c38  ldr     x0, [x0, #0xac0]  ; META int[]_TypeInfo
  0e0d6c3c  bl      #0x63cee78
  0e0d6c40  adrp    x0, #0xeb68000
  0e0d6c44  ldr     x0, [x0, #0x8a0]  ; META UnityEngine.Mesh_TypeInfo
  0e0d6c48  bl      #0x63cee78
  0e0d6c4c  adrp    x0, #0xea96000
  0e0d6c50  ldr     x0, [x0, #0x648]  ; META UnityEngine.Vector3[]_TypeInfo
  0e0d6c54  bl      #0x63cee78
  0e0d6c58  adrp    x0, #0xeb67000
  0e0d6c5c  ldr     x0, [x0, #0xf30]  ; META UnityEngine.Vector4[]_TypeInfo
  0e0d6c60  bl      #0x63cee78
  0e0d6c64  mov     w8, #1
  0e0d6c68  strb    w8, [x19, #0xa47]
  0e0d6c6c  ldr     x0, [x21]
  0e0d6c70  bl      #0x63cf110
  0e0d6c74  mov     x1, xzr
  0e0d6c78  mov     x19, x0
  0e0d6c7c  bl      #0xd9a0470  ; -> UnityEngine.Mesh$$.ctor
  0e0d6c80  fcmp    s9, #0.0
  0e0d6c84  adrp    x8, #0x276e000
  0e0d6c88  adrp    x9, #0x276e000
  0e0d6c8c  fmov    s11, #1.00000000
  0e0d6c90  add     w29, w22, #2
  0e0d6c94  ldr     s0, [x8, #0xb48]
  0e0d6c98  ldr     s1, [x9, #0x3b0]
  0e0d6c9c  add     w28, w22, #1
  0e0d6ca0  add     w25, w23, #2
  0e0d6ca4  cset    w10, gt
  0e0d6ca8  fmaxnm  s0, s9, s0
  0e0d6cac  mul     w26, w25, w28
  0e0d6cb0  ands    w8, w10, w20
  0e0d6cb4  movi    d12, #0000000000000000
  0e0d6cb8  adrp    x9, #0x276e000
  0e0d6cbc  str     w8, [sp, #8]
  0e0d6cc0  csel    w8, w29, wzr, ne
  0e0d6cc4  cmp     w22, #4
  0e0d6cc8  fcsel   s1, s1, s11, eq
  0e0d6ccc  ldr     s2, [x9, #0x444]
  0e0d6cd0  ldr     x0, [x24]
  0e0d6cd4  add     w20, w8, w26
  0e0d6cd8  mov     w1, w20
  0e0d6cdc  fcsel   s10, s2, s12, eq
  0e0d6ce0  fmul    s9, s0, s1
  0e0d6ce4  fmul    s0, s1, s8
  0e0d6ce8  str     s0, [sp, #0xc]
  0e0d6cec  bl      #0x63cef64
  0e0d6cf0  cmp     w22, #1
  0e0d6cf4  mov     x24, x0
  0e0d6cf8  b.lt    #0xe0d6db8
  0e0d6cfc  ldr     s0, [sp, #0xc]
  0e0d6d00  add     w8, w23, #1
  0e0d6d04  scvtf   s13, w22
  0e0d6d08  scvtf   s14, w8
  0e0d6d0c  adrp    x8, #0x276e000
  0e0d6d10  mov     w21, wzr
  0e0d6d14  fsub    s15, s0, s9
  0e0d6d18  ldr     s8, [x8, #0x238]
  0e0d6d1c  mov     w27, #0xc
  0e0d6d20  scvtf   s0, w21
  0e0d6d24  add     x0, sp, #0x34
  0e0d6d28  add     x1, sp, #0x30
  0e0d6d2c  fmul    s0, s0, s8
  0e0d6d30  fdiv    s0, s0, s13
  0e0d6d34  fadd    s0, s10, s0
  0e0d6d38  bl      #0xe1b8420
  0e0d6d3c  ldr     q5, [sp, #0x10]
  0e0d6d40  cmp     w25, #1
  0e0d6d44  b.lt    #0xe0d6dac
  0e0d6d48  cbz     x24, #0xe0d7468
  0e0d6d4c  ldp     s0, s1, [sp, #0x30]
  0e0d6d50  mov     x8, xzr
  0e0d6d54  mov     w9, w21
  0e0d6d58  ldr     w10, [x24, #0x18]
  0e0d6d5c  cmp     w9, w10
  0e0d6d60  b.hs    #0xe0d7464
  0e0d6d64  scvtf   s2, w8
  0e0d6d68  smaddl  x10, w9, w27, x24
  0e0d6d6c  add     x8, x8, #1
  0e0d6d70  add     w9, w9, w28
  0e0d6d74  fdiv    s2, s2, s14
  0e0d6d78  fcmp    s2, s11
  0e0d6d7c  fcsel   s3, s11, s2, gt
  0e0d6d80  fcmp    s2, #0.0
  0e0d6d84  fmul    s2, s2, s5
  0e0d6d88  fcsel   s3, s12, s3, mi
  0e0d6d8c  cmp     x25, x8
  0e0d6d90  str     s2, [x10, #0x28]
  0e0d6d94  fmul    s3, s15, s3
  0e0d6d98  fadd    s3, s9, s3
  0e0d6d9c  fmul    s4, s0, s3
  0e0d6da0  fmul    s3, s1, s3
  0e0d6da4  stp     s4, s3, [x10, #0x20]
  0e0d6da8  b.ne    #0xe0d6d58
  0e0d6dac  add     w21, w21, #1
  0e0d6db0  cmp     w21, w22
  0e0d6db4  b.ne    #0xe0d6d20
  0e0d6db8  ldp     w27, w21, [sp, #4]
  0e0d6dbc  cmp     w25, #1
  0e0d6dc0  b.lt    #0xe0d6e10
  0e0d6dc4  cbz     x24, #0xe0d7468
  0e0d6dc8  mov     w8, wzr
  0e0d6dcc  mov     w9, #0xc
  0e0d6dd0  ldr     w11, [x24, #0x18]
  0e0d6dd4  cmp     w8, w11
  0e0d6dd8  b.hs    #0xe0d7464
  0e0d6ddc  add     w10, w22, w8
  0e0d6de0  cmp     w10, w11
  0e0d6de4  b.hs    #0xe0d7464
  0e0d6de8  add     x11, x24, #0x20
  0e0d6dec  smaddl  x12, w8, w9, x11
  0e0d6df0  subs    x25, x25, #1
  0e0d6df4  smaddl  x10, w10, w9, x11
  0e0d6df8  add     w8, w8, w28
  0e0d6dfc  ldr     d0, [x12]
  0e0d6e00  ldr     s1, [x12, #8]
  0e0d6e04  str     d0, [x10]
  0e0d6e08  str     s1, [x10, #8]
  0e0d6e0c  b.ne    #0xe0d6dd0
  0e0d6e10  tbz     w21, #0, #0xe0d6f34
  0e0d6e14  adrp    x21, #0xf400000
  0e0d6e18  ldrb    w8, [x21, #0x9d]
  0e0d6e1c  cbnz    w8, #0xe0d6e34
  0e0d6e20  adrp    x0, #0xea67000
  0e0d6e24  ldr     x0, [x0, #0x438]  ; META UnityEngine.Vector3_TypeInfo
  0e0d6e28  bl      #0x63cee78
  0e0d6e2c  mov     w8, #1
  0e0d6e30  strb    w8, [x21, #0x9d]
  0e0d6e34  cbz     x24, #0xe0d7468
  0e0d6e38  ldr     w8, [x24, #0x18]
  0e0d6e3c  cmp     w26, w8
  0e0d6e40  b.hs    #0xe0d7464
  0e0d6e44  adrp    x8, #0xea67000
  0e0d6e48  mov     w21, #0xc
  0e0d6e4c  cmp     w22, #1
  0e0d6e50  ldr     x8, [x8, #0x438]  ; META UnityEngine.Vector3_TypeInfo
  0e0d6e54  nop     
  0e0d6e58  smaddl  x9, w26, w21, x24
  0e0d6e5c  ldr     x8, [x8]
  0e0d6e60  ldr     x8, [x8, #0xb8]
  0e0d6e64  ldr     d0, [x8]
  0e0d6e68  ldr     s1, [x8, #8]
  0e0d6e6c  str     d0, [x9, #0x20]
  0e0d6e70  str     s1, [x9, #0x28]
  0e0d6e74  b.lt    #0xe0d6ef0
  0e0d6e78  scvtf   s8, w22
  0e0d6e7c  adrp    x8, #0x276e000
  0e0d6e80  mov     w25, wzr
  0e0d6e84  ldr     s11, [x8, #0x238]
  0e0d6e88  add     w8, w26, w25
  0e0d6e8c  ldr     w9, [x24, #0x18]
  0e0d6e90  add     w27, w8, #1
  0e0d6e94  cmp     w27, w9
  0e0d6e98  b.hs    #0xe0d7464
  0e0d6e9c  scvtf   s0, w25
  0e0d6ea0  add     x0, sp, #0x2c
  0e0d6ea4  add     x1, sp, #0x28
  0e0d6ea8  fmul    s0, s0, s11
  0e0d6eac  fdiv    s0, s0, s8
  0e0d6eb0  fadd    s0, s10, s0
  0e0d6eb4  bl      #0xe1b8420
  0e0d6eb8  ldp     s0, s1, [sp, #0x28]
  0e0d6ebc  nop     
  0e0d6ec0  smaddl  x8, w27, w21, x24
  0e0d6ec4  add     w25, w25, #1
  0e0d6ec8  cmp     w22, w25
  0e0d6ecc  fmul    s0, s9, s0
  0e0d6ed0  fmul    s1, s9, s1
  0e0d6ed4  str     wzr, [x8, #0x28]
  0e0d6ed8  stp     s0, s1, [x8, #0x20]
  0e0d6edc  b.ne    #0xe0d6e88
  0e0d6ee0  add     w9, w26, w25
  0e0d6ee4  ldr     w27, [sp, #4]
  0e0d6ee8  add     w8, w9, #1
  0e0d6eec  b       #0xe0d6ef8
  0e0d6ef0  add     w8, w26, #1
  0e0d6ef4  mov     w9, w26
  0e0d6ef8  ldr     w10, [x24, #0x18]
  0e0d6efc  sub     w9, w9, w22
  0e0d6f00  ldr     w21, [sp, #8]
  0e0d6f04  cmp     w9, w10
  0e0d6f08  b.hs    #0xe0d7464
  0e0d6f0c  cmp     w8, w10
  0e0d6f10  b.hs    #0xe0d7464
  0e0d6f14  mov     w10, #0xc
  0e0d6f18  add     x11, x24, #0x20
  0e0d6f1c  smaddl  x9, w9, w10, x11
  0e0d6f20  smaddl  x8, w8, w10, x11
  0e0d6f24  ldr     d0, [x9]
  0e0d6f28  ldr     s1, [x9, #8]
  0e0d6f2c  str     d0, [x8]
  0e0d6f30  str     s1, [x8, #8]
  0e0d6f34  tbz     w27, #0, #0xe0d6f84
  0e0d6f38  cbz     x24, #0xe0d7468
  0e0d6f3c  adrp    x9, #0xea96000
  0e0d6f40  ldr     w8, [x24, #0x18]
  0e0d6f44  ldr     x9, [x9, #0x648]  ; META UnityEngine.Vector3[]_TypeInfo
  0e0d6f48  lsl     w1, w8, #1
  0e0d6f4c  ldr     x0, [x9]
  0e0d6f50  bl      #0x63cef64
  0e0d6f54  mov     x25, x0
  0e0d6f58  mov     x0, x24
  0e0d6f5c  mov     w2, wzr
  0e0d6f60  mov     x1, x25
  0e0d6f64  mov     x3, xzr
  0e0d6f68  bl      #0xe001b74  ; -> System.Array$$CopyTo
  0e0d6f6c  ldr     w2, [x24, #0x18]
  0e0d6f70  mov     x0, x24
  0e0d6f74  mov     x1, x25
  0e0d6f78  mov     x3, xzr
  0e0d6f7c  bl      #0xe001b74  ; -> System.Array$$CopyTo
  0e0d6f80  mov     x24, x25
  0e0d6f84  cbz     x19, #0xe0d7468
  0e0d6f88  adrp    x25, #0xeb67000
  0e0d6f8c  mov     x0, x19
  0e0d6f90  mov     x1, x24
  0e0d6f94  ldr     x25, [x25, #0xf30]  ; META UnityEngine.Vector4[]_TypeInfo
  0e0d6f98  mov     x2, xzr
  0e0d6f9c  bl      #0xd9a74f8  ; -> UnityEngine.Mesh$$set_vertices
  0e0d6fa0  ldr     x0, [x25]
  0e0d6fa4  mov     w1, w20
  0e0d6fa8  bl      #0x63cef64
  0e0d6fac  cmp     w26, #1
  0e0d6fb0  mov     x24, x0
  0e0d6fb4  b.lt    #0xe0d7024
  0e0d6fb8  cbz     x24, #0xe0d7468
  0e0d6fbc  scvtf   s0, w23
  0e0d6fc0  fmov    s1, #2.00000000
  0e0d6fc4  mov     x8, xzr
  0e0d6fc8  scvtf   s2, w28
  0e0d6fcc  fmov    s3, #-1.00000000
  0e0d6fd0  add     x9, x24, #0x2c
  0e0d6fd4  fadd    s1, s0, s1
  0e0d6fd8  fadd    s0, s2, s3
  0e0d6fdc  fadd    s1, s1, s3
  0e0d6fe0  ldr     w10, [x24, #0x18]
  0e0d6fe4  cmp     x8, x10
  0e0d6fe8  b.hs    #0xe0d7464
  0e0d6fec  sdiv    w10, w8, w28
  0e0d6ff0  stur    xzr, [x9, #-0xc]
  0e0d6ff4  msub    w11, w10, w28, w8
  0e0d6ff8  scvtf   s3, w10
  0e0d6ffc  add     x8, x8, #1
  0e0d7000  cmp     x26, x8
  0e0d7004  scvtf   s2, w11
  0e0d7008  fdiv    s3, s3, s1
  0e0d700c  fdiv    s2, s2, s0
  0e0d7010  stp     s2, s3, [x9, #-4]
  0e0d7014  add     x9, x9, #0x10
  0e0d7018  b.ne    #0xe0d6fe0
  0e0d701c  mov     w8, w26
  0e0d7020  b       #0xe0d7028
  0e0d7024  mov     w8, wzr
  0e0d7028  cmp     w29, #1
  0e0d702c  cset    w9, lt
  0e0d7030  orn     w9, w9, w21
  0e0d7034  tbnz    w9, #0, #0xe0d7064
  0e0d7038  cbz     x24, #0xe0d7468
  0e0d703c  adrp    x9, #0x276f000
  0e0d7040  ldr     q0, [x9, #0x6c0]
  0e0d7044  ldr     w9, [x24, #0x18]
  0e0d7048  cmp     w8, w9
  0e0d704c  b.hs    #0xe0d7464
  0e0d7050  add     x9, x24, w8, sxtw #4
  0e0d7054  add     w8, w8, #1
  0e0d7058  subs    w29, w29, #1
  0e0d705c  str     q0, [x9, #0x20]
  0e0d7060  b.ne    #0xe0d7044
  0e0d7064  tbz     w27, #0, #0xe0d70ec
  0e0d7068  cbz     x24, #0xe0d7468
  0e0d706c  ldr     w8, [x24, #0x18]
  0e0d7070  ldr     x0, [x25]
  0e0d7074  lsl     w1, w8, #1
  0e0d7078  bl      #0x63cef64
  0e0d707c  mov     x25, x0
  0e0d7080  mov     x0, x24
  0e0d7084  mov     w2, wzr
  0e0d7088  mov     x1, x25
  0e0d708c  mov     x3, xzr
  0e0d7090  bl      #0xe001b74  ; -> System.Array$$CopyTo
  0e0d7094  ldr     w2, [x24, #0x18]
  0e0d7098  mov     x0, x24
  0e0d709c  mov     x1, x25
  0e0d70a0  mov     x3, xzr
  0e0d70a4  bl      #0xe001b74  ; -> System.Array$$CopyTo
  0e0d70a8  ldr     w9, [x24, #0x18]
  0e0d70ac  cmp     w9, #1
  0e0d70b0  b.lt    #0xe0d70f0
  0e0d70b4  cbz     x25, #0xe0d7468
  0e0d70b8  ldr     w10, [x25, #0x18]
  0e0d70bc  mov     w8, wzr
  0e0d70c0  mov     w11, #0x3f800000
  0e0d70c4  add     w9, w9, w8
  0e0d70c8  cmp     w9, w10
  0e0d70cc  b.hs    #0xe0d7464
  0e0d70d0  add     x9, x25, w9, sxtw #4
  0e0d70d4  add     w8, w8, #1
  0e0d70d8  str     w11, [x9, #0x24]
  0e0d70dc  ldr     w9, [x24, #0x18]
  0e0d70e0  cmp     w8, w9
  0e0d70e4  b.lt    #0xe0d70c4
  0e0d70e8  b       #0xe0d70f0
  0e0d70ec  mov     x25, x24
  0e0d70f0  cbz     x19, #0xe0d7468
  0e0d70f4  adrp    x29, #0xea87000
  0e0d70f8  mov     x0, x19
  0e0d70fc  mov     w1, wzr
  0e0d7100  ldr     x29, [x29, #0xac0]  ; META int[]_TypeInfo
  0e0d7104  mov     x2, x25
  0e0d7108  mov     x3, xzr
  0e0d710c  bl      #0xd9a9124  ; -> UnityEngine.Mesh$$SetUVs
  0e0d7110  add     w25, w23, #1
  0e0d7114  mov     w8, #1
  0e0d7118  ldr     x0, [x29]
  0e0d711c  cmp     w25, #1
  0e0d7120  csinc   w8, w8, w23, le
  0e0d7124  tst     w21, #1
  0e0d7128  mul     w8, w22, w8
  0e0d712c  csel    w9, w22, wzr, ne
  0e0d7130  add     w8, w9, w8, lsl #1
  0e0d7134  add     w1, w8, w8, lsl #1
  0e0d7138  bl      #0x63cef64
  0e0d713c  cmp     w22, #1
  0e0d7140  mov     x24, x0
  0e0d7144  b.lt    #0xe0d72a4
  0e0d7148  mov     w10, wzr
  0e0d714c  mov     w8, wzr
  0e0d7150  mov     w9, #1
  0e0d7154  mov     w11, #0x7ffffffe
  0e0d7158  cmp     w23, w11
  0e0d715c  b.hi    #0xe0d721c
  0e0d7160  cbz     x24, #0xe0d7468
  0e0d7164  ldr     w12, [x24, #0x18]
  0e0d7168  mov     w13, w9
  0e0d716c  mov     w14, w25
  0e0d7170  cmp     w10, w12
  0e0d7174  b.hs    #0xe0d7464
  0e0d7178  mov     w15, w10
  0e0d717c  add     w10, w10, #1
  0e0d7180  sub     w17, w13, #1
  0e0d7184  add     x16, x24, w15, sxtw #2
  0e0d7188  cmp     w10, w12
  0e0d718c  str     w17, [x16, #0x20]
  0e0d7190  b.hs    #0xe0d7464
  0e0d7194  add     x16, x24, w10, sxtw #2
  0e0d7198  add     w10, w10, #1
  0e0d719c  cmp     w10, w12
  0e0d71a0  str     w13, [x16, #0x20]
  0e0d71a4  b.hs    #0xe0d7464
  0e0d71a8  add     w16, w15, #2
  0e0d71ac  add     x17, x24, w16, sxtw #2
  0e0d71b0  add     w16, w10, #1
  0e0d71b4  add     w10, w22, w13
  0e0d71b8  cmp     w16, w12
  0e0d71bc  str     w10, [x17, #0x20]
  0e0d71c0  b.hs    #0xe0d7464
  0e0d71c4  add     w17, w15, #3
  0e0d71c8  add     w0, w22, w13
  0e0d71cc  add     w16, w16, #1
  0e0d71d0  add     x17, x24, w17, sxtw #2
  0e0d71d4  add     w0, w0, #1
  0e0d71d8  cmp     w16, w12
  0e0d71dc  str     w0, [x17, #0x20]
  0e0d71e0  b.hs    #0xe0d7464
  0e0d71e4  add     w17, w15, #4
  0e0d71e8  add     w16, w16, #1
  0e0d71ec  add     x17, x24, w17, sxtw #2
  0e0d71f0  cmp     w16, w12
  0e0d71f4  str     w10, [x17, #0x20]
  0e0d71f8  b.hs    #0xe0d7464
  0e0d71fc  add     w10, w15, #5
  0e0d7200  subs    w14, w14, #1
  0e0d7204  add     x10, x24, w10, sxtw #2
  0e0d7208  str     w13, [x10, #0x20]
  0e0d720c  add     w13, w13, w28
  0e0d7210  add     w10, w16, #1
  0e0d7214  b.ne    #0xe0d7170
  0e0d7218  add     w10, w15, #6
  0e0d721c  add     w8, w8, #1
  0e0d7220  add     w9, w9, #1
  0e0d7224  cmp     w8, w22
  0e0d7228  b.ne    #0xe0d7158
  0e0d722c  tbz     w21, #0, #0xe0d72f4
  0e0d7230  cmp     w22, #1
  0e0d7234  b.lt    #0xe0d72ac
  0e0d7238  cbz     x24, #0xe0d7468
  0e0d723c  ldr     w8, [x24, #0x18]
  0e0d7240  add     w12, w26, #1
  0e0d7244  mov     w9, w22
  0e0d7248  cmp     w10, w8
  0e0d724c  b.hs    #0xe0d7464
  0e0d7250  mov     w11, w10
  0e0d7254  add     w10, w10, #1
  0e0d7258  add     x13, x24, w11, sxtw #2
  0e0d725c  cmp     w10, w8
  0e0d7260  str     w26, [x13, #0x20]
  0e0d7264  b.hs    #0xe0d7464
  0e0d7268  add     x14, x24, w10, sxtw #2
  0e0d726c  add     w10, w10, #1
  0e0d7270  add     w13, w12, #1
  0e0d7274  cmp     w10, w8
  0e0d7278  str     w13, [x14, #0x20]
  0e0d727c  b.hs    #0xe0d7464
  0e0d7280  add     w14, w11, #2
  0e0d7284  subs    w9, w9, #1
  0e0d7288  add     w10, w10, #1
  0e0d728c  add     x14, x24, w14, sxtw #2
  0e0d7290  str     w12, [x14, #0x20]
  0e0d7294  mov     w12, w13
  0e0d7298  b.ne    #0xe0d7248
  0e0d729c  add     w10, w11, #3
  0e0d72a0  b       #0xe0d72b0
  0e0d72a4  tbz     w21, #0, #0xe0d72f4
  0e0d72a8  mov     w10, wzr
  0e0d72ac  cbz     x24, #0xe0d7468
  0e0d72b0  ldr     w9, [x24, #0x18]
  0e0d72b4  add     w8, w10, #1
  0e0d72b8  cmp     w10, w9
  0e0d72bc  b.hs    #0xe0d7464
  0e0d72c0  add     x11, x24, w10, sxtw #2
  0e0d72c4  cmp     w8, w9
  0e0d72c8  str     w26, [x11, #0x20]
  0e0d72cc  b.hs    #0xe0d7464
  0e0d72d0  add     w10, w10, #2
  0e0d72d4  add     x8, x24, w8, sxtw #2
  0e0d72d8  add     w11, w26, #1
  0e0d72dc  cmp     w10, w9
  0e0d72e0  str     w11, [x8, #0x20]
  0e0d72e4  b.hs    #0xe0d7464
  0e0d72e8  add     x8, x24, w10, sxtw #2
  0e0d72ec  add     w9, w26, w22
  0e0d72f0  str     w9, [x8, #0x20]
  0e0d72f4  tbz     w27, #0, #0xe0d73d8
  0e0d72f8  cbz     x24, #0xe0d7468
  0e0d72fc  ldr     w8, [x24, #0x18]
  0e0d7300  ldr     x0, [x29]
  0e0d7304  lsl     w1, w8, #1
  0e0d7308  bl      #0x63cef64
  0e0d730c  mov     x21, x0
  0e0d7310  mov     x0, x24
  0e0d7314  mov     w2, wzr
  0e0d7318  mov     x1, x21
  0e0d731c  mov     x3, xzr
  0e0d7320  bl      #0xe001b74  ; -> System.Array$$CopyTo
  0e0d7324  ldr     w8, [x24, #0x18]
  0e0d7328  cmp     w8, #1
  0e0d732c  b.lt    #0xe0d73dc
  0e0d7330  mov     w9, wzr
  0e0d7334  cmp     w9, w8
  0e0d7338  b.hs    #0xe0d7464
  0e0d733c  cbz     x21, #0xe0d7468
  0e0d7340  ldr     w10, [x21, #0x18]
  0e0d7344  add     w11, w8, w9
  0e0d7348  cmp     w11, w10
  0e0d734c  b.hs    #0xe0d7464
  0e0d7350  add     x12, x24, w9, sxtw #2
  0e0d7354  add     x13, x21, w11, sxtw #2
  0e0d7358  add     w11, w9, #2
  0e0d735c  cmp     w11, w8
  0e0d7360  ldr     w12, [x12, #0x20]
  0e0d7364  add     w12, w12, w20
  0e0d7368  str     w12, [x13, #0x20]
  0e0d736c  b.hs    #0xe0d7464
  0e0d7370  add     w12, w8, w9
  0e0d7374  add     w12, w12, #1
  0e0d7378  cmp     w12, w10
  0e0d737c  b.hs    #0xe0d7464
  0e0d7380  add     x13, x24, w11, sxtw #2
  0e0d7384  add     x12, x21, w12, sxtw #2
  0e0d7388  sub     w11, w11, #1
  0e0d738c  cmp     w11, w8
  0e0d7390  ldr     w13, [x13, #0x20]
  0e0d7394  add     w13, w13, w20
  0e0d7398  str     w13, [x12, #0x20]
  0e0d739c  b.hs    #0xe0d7464
  0e0d73a0  add     w12, w8, w9
  0e0d73a4  add     w12, w12, #2
  0e0d73a8  cmp     w12, w10
  0e0d73ac  b.hs    #0xe0d7464
  0e0d73b0  add     w9, w9, #1
  0e0d73b4  add     x12, x21, w12, sxtw #2
  0e0d73b8  add     x9, x24, w9, sxtw #2
  0e0d73bc  ldr     w10, [x9, #0x20]
  0e0d73c0  add     w9, w11, #2
  0e0d73c4  cmp     w9, w8
  0e0d73c8  add     w10, w10, w20
  0e0d73cc  str     w10, [x12, #0x20]
  0e0d73d0  b.lt    #0xe0d7334
  0e0d73d4  b       #0xe0d73dc
  0e0d73d8  mov     x21, x24
  0e0d73dc  cbz     x19, #0xe0d7468
  0e0d73e0  mov     x0, x19
  0e0d73e4  mov     x1, x21
  0e0d73e8  mov     x2, xzr
  0e0d73ec  bl      #0xd9aadb4  ; -> UnityEngine.Mesh$$set_triangles
  0e0d73f0  ldr     s0, [sp, #0xc]
  0e0d73f4  ldr     q1, [sp, #0x10]
  0e0d73f8  add     x1, sp, #0x38
  0e0d73fc  mov     x0, x19
  0e0d7400  mov     x2, xzr
  0e0d7404  str     xzr, [sp, #0x38]
  0e0d7408  fcmp    s9, s0
  0e0d740c  fcsel   s0, s9, s0, gt
  0e0d7410  fadd    s0, s0, s0
  0e0d7414  mov     v1.s[1], v0.s[0]
  0e0d7418  movi    v0.2s, #0x3f, lsl #24
  0e0d741c  fmul    v0.2s, v1.2s, v0.2s
  0e0d7420  rev64   v1.4s, v0.4s
  0e0d7424  zip1    v0.4s, v0.4s, v1.4s
  0e0d7428  stur    q0, [sp, #0x40]
  0e0d742c  bl      #0xd9a625c  ; -> UnityEngine.Mesh$$set_bounds
  0e0d7430  mov     x0, x19
  0e0d7434  ldp     x20, x19, [sp, #0xe0]
  0e0d7438  ldp     x22, x21, [sp, #0xd0]
  0e0d743c  ldp     x24, x23, [sp, #0xc0]
  0e0d7440  ldp     x26, x25, [sp, #0xb0]
  0e0d7444  ldp     x28, x27, [sp, #0xa0]
  0e0d7448  ldp     x29, x30, [sp, #0x90]
  0e0d744c  ldp     d9, d8, [sp, #0x80]
  0e0d7450  ldp     d11, d10, [sp, #0x70]
  0e0d7454  ldp     d13, d12, [sp, #0x60]
  0e0d7458  ldp     d15, d14, [sp, #0x50]
  0e0d745c  add     sp, sp, #0xf0
  0e0d7460  ret     
  0e0d7464  bl      #0x63cf128
  0e0d7468  bl      #0x63cf120

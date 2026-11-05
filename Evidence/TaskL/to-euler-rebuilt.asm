=== ActorAnimation.ActorAnimationMathUtility$$ToEuler @ 0x277e050 (205 insns)
    Unity_Mathematics_float3_o ActorAnimation_ActorAnimationMathUtility__ToEuler (Unity_Mathematics_quaternion_o q, uint8_t rotSeq, const MethodInfo* method);
  0277e050  stp     d11, d10, [sp, #-0x40]!
  0277e054  stp     d9, d8, [sp, #0x10]
  0277e058  str     x30, [sp, #0x20]
  0277e05c  stp     x20, x19, [sp, #0x30]
  0277e060  fmov    s9, s3
  0277e064  fmov    s8, s2
  0277e068  adrp    x20, #0x5828000
  0277e06c  fmov    s10, s1
  0277e070  fmov    s11, s0
  0277e074  ldrb    w8, [x20, #0x75a]
  0277e078  mov     w19, w0
  0277e07c  tbnz    w8, #0, #0x277e094
  0277e080  adrp    x0, #0x54c9000
  0277e084  ldr     x0, [x0, #0xe48]  ; META Unity.Mathematics.float3_TypeInfo
  0277e088  bl      #0x26808d0
  0277e08c  mov     w8, #1
  0277e090  strb    w8, [x20, #0x75a]
  0277e094  and     w8, w19, #0xff
  0277e098  cmp     w8, #2
  0277e09c  b.gt    #0x277e11c
  0277e0a0  cbz     w8, #0x277e19c
  0277e0a4  cmp     w8, #1
  0277e0a8  b.eq    #0x277e290
  0277e0ac  cmp     w8, #2
  0277e0b0  b.ne    #0x277e274
  0277e0b4  fmul    s0, s9, s9
  0277e0b8  fmul    s1, s11, s11
  0277e0bc  fmul    s2, s11, s8
  0277e0c0  fmul    s3, s9, s10
  0277e0c4  fmul    s4, s10, s10
  0277e0c8  fmul    s5, s10, s8
  0277e0cc  fmul    s6, s9, s11
  0277e0d0  fmul    s7, s9, s8
  0277e0d4  fsub    s0, s0, s1
  0277e0d8  fmul    s1, s11, s10
  0277e0dc  fmul    s16, s8, s8
  0277e0e0  fsub    s2, s2, s3
  0277e0e4  fadd    s5, s5, s6
  0277e0e8  fsub    s3, s0, s4
  0277e0ec  fsub    s6, s1, s7
  0277e0f0  fadd    s4, s4, s0
  0277e0f4  fmov    s7, #-2.00000000
  0277e0f8  fadd    s0, s2, s2
  0277e0fc  fadd    s1, s16, s3
  0277e100  fmul    s2, s5, s7
  0277e104  fadd    s3, s6, s6
  0277e108  fsub    s4, s4, s16
  0277e10c  bl      #0x277e384  ; -> ActorAnimation.ActorAnimationMathUtility$$ThreeAxisRot
  0277e110  fmov    s4, s0
  0277e114  fmov    s0, s1
  0277e118  b       #0x277e26c
  0277e11c  cmp     w8, #3
  0277e120  b.eq    #0x277e208
  0277e124  cmp     w8, #4
  0277e128  b.eq    #0x277e300
  0277e12c  cmp     w8, #5
  0277e130  b.ne    #0x277e274
  0277e134  fmul    s0, s9, s9
  0277e138  fmul    s1, s11, s11
  0277e13c  fmul    s2, s11, s10
  0277e140  fmul    s3, s9, s8
  0277e144  fmul    s4, s10, s10
  0277e148  fmul    s5, s11, s8
  0277e14c  fmul    s6, s9, s10
  0277e150  fmul    s16, s10, s8
  0277e154  fadd    s7, s0, s1
  0277e158  fmul    s17, s9, s11
  0277e15c  fsub    s0, s0, s1
  0277e160  fmul    s18, s8, s8
  0277e164  fsub    s1, s2, s3
  0277e168  fadd    s3, s5, s6
  0277e16c  fmov    s6, #-2.00000000
  0277e170  fsub    s2, s7, s4
  0277e174  fsub    s5, s16, s17
  0277e178  fsub    s4, s0, s4
  0277e17c  fadd    s0, s1, s1
  0277e180  fsub    s1, s2, s18
  0277e184  fmul    s2, s3, s6
  0277e188  fadd    s3, s5, s5
  0277e18c  fadd    s4, s18, s4
  0277e190  bl      #0x277e384  ; -> ActorAnimation.ActorAnimationMathUtility$$ThreeAxisRot
  0277e194  fmov    s3, s1
  0277e198  b       #0x277e364
  0277e19c  fmul    s0, s9, s9
  0277e1a0  fmul    s1, s11, s11
  0277e1a4  fmov    s18, #-2.00000000
  0277e1a8  fmul    s2, s10, s8
  0277e1ac  fmul    s3, s9, s11
  0277e1b0  fmul    s4, s10, s10
  0277e1b4  fmul    s5, s11, s8
  0277e1b8  fmul    s6, s9, s10
  0277e1bc  fmul    s16, s11, s10
  0277e1c0  fsub    s7, s0, s1
  0277e1c4  fmul    s17, s9, s8
  0277e1c8  fadd    s0, s0, s1
  0277e1cc  fmul    s19, s8, s8
  0277e1d0  fadd    s1, s2, s3
  0277e1d4  fsub    s3, s5, s6
  0277e1d8  fsub    s2, s7, s4
  0277e1dc  fadd    s5, s16, s17
  0277e1e0  fsub    s4, s0, s4
  0277e1e4  fmul    s0, s1, s18
  0277e1e8  fadd    s1, s19, s2
  0277e1ec  fadd    s2, s3, s3
  0277e1f0  fmul    s3, s5, s18
  0277e1f4  fsub    s4, s4, s19
  0277e1f8  bl      #0x277e384  ; -> ActorAnimation.ActorAnimationMathUtility$$ThreeAxisRot
  0277e1fc  fmov    s4, s0
  0277e200  fmov    s3, s1
  0277e204  b       #0x277e2f8
  0277e208  fmul    s0, s9, s9
  0277e20c  fmul    s1, s11, s11
  0277e210  fmov    s18, #-2.00000000
  0277e214  fmul    s2, s11, s8
  0277e218  fmul    s3, s9, s10
  0277e21c  fmul    s4, s10, s10
  0277e220  fmul    s5, s11, s10
  0277e224  fmul    s6, s9, s8
  0277e228  fmul    s16, s10, s8
  0277e22c  fadd    s7, s0, s1
  0277e230  fmul    s17, s9, s11
  0277e234  fsub    s0, s0, s1
  0277e238  fmul    s19, s8, s8
  0277e23c  fadd    s1, s2, s3
  0277e240  fsub    s3, s5, s6
  0277e244  fsub    s2, s7, s4
  0277e248  fadd    s5, s16, s17
  0277e24c  fadd    s4, s4, s0
  0277e250  fmul    s0, s1, s18
  0277e254  fsub    s1, s2, s19
  0277e258  fadd    s2, s3, s3
  0277e25c  fmul    s3, s5, s18
  0277e260  fsub    s4, s4, s19
  0277e264  bl      #0x277e384  ; -> ActorAnimation.ActorAnimationMathUtility$$ThreeAxisRot
  0277e268  fmov    s4, s1
  0277e26c  fmov    s3, s2
  0277e270  b       #0x277e368
  0277e274  adrp    x8, #0x54c9000
  0277e278  ldr     x8, [x8, #0xe48]  ; META Unity.Mathematics.float3_TypeInfo
  0277e27c  ldr     x8, [x8]
  0277e280  ldr     x8, [x8, #0xb8]
  0277e284  ldp     s0, s3, [x8]
  0277e288  ldr     s4, [x8, #8]
  0277e28c  b       #0x277e368
  0277e290  fmul    s0, s9, s9
  0277e294  fmul    s1, s11, s11
  0277e298  fmul    s2, s10, s8
  0277e29c  fmul    s3, s9, s11
  0277e2a0  fmul    s4, s10, s10
  0277e2a4  fmul    s5, s11, s10
  0277e2a8  fmul    s6, s9, s8
  0277e2ac  fmul    s16, s11, s8
  0277e2b0  fsub    s7, s0, s1
  0277e2b4  fmul    s17, s9, s10
  0277e2b8  fadd    s0, s0, s1
  0277e2bc  fmul    s18, s8, s8
  0277e2c0  fsub    s1, s2, s3
  0277e2c4  fadd    s3, s5, s6
  0277e2c8  fmov    s6, #-2.00000000
  0277e2cc  fadd    s2, s4, s7
  0277e2d0  fsub    s5, s16, s17
  0277e2d4  fsub    s4, s0, s4
  0277e2d8  fadd    s0, s1, s1
  0277e2dc  fsub    s1, s2, s18
  0277e2e0  fmul    s2, s3, s6
  0277e2e4  fadd    s3, s5, s5
  0277e2e8  fsub    s4, s4, s18
  0277e2ec  bl      #0x277e384  ; -> ActorAnimation.ActorAnimationMathUtility$$ThreeAxisRot
  0277e2f0  fmov    s3, s0
  0277e2f4  fmov    s4, s1
  0277e2f8  fmov    s0, s2
  0277e2fc  b       #0x277e368
  0277e300  fmul    s0, s9, s9
  0277e304  fmul    s1, s11, s11
  0277e308  fmov    s16, #-2.00000000
  0277e30c  fmul    s2, s11, s10
  0277e310  fmul    s3, s9, s8
  0277e314  fmul    s4, s10, s10
  0277e318  fmul    s5, s10, s8
  0277e31c  fmul    s6, s9, s11
  0277e320  fmul    s7, s9, s10
  0277e324  fsub    s0, s0, s1
  0277e328  fmul    s1, s11, s8
  0277e32c  fmul    s17, s8, s8
  0277e330  fadd    s2, s2, s3
  0277e334  fsub    s5, s5, s6
  0277e338  fadd    s3, s4, s0
  0277e33c  fadd    s6, s1, s7
  0277e340  fsub    s4, s0, s4
  0277e344  fmul    s0, s2, s16
  0277e348  fadd    s2, s5, s5
  0277e34c  fsub    s1, s3, s17
  0277e350  fmul    s3, s6, s16
  0277e354  fadd    s4, s17, s4
  0277e358  bl      #0x277e384  ; -> ActorAnimation.ActorAnimationMathUtility$$ThreeAxisRot
  0277e35c  fmov    s3, s0
  0277e360  fmov    s0, s1
  0277e364  fmov    s4, s2
  0277e368  ldp     x20, x19, [sp, #0x30]
  0277e36c  fmov    s1, s3
  0277e370  ldp     d9, d8, [sp, #0x10]
  0277e374  fmov    s2, s4
  0277e378  ldr     x30, [sp, #0x20]
  0277e37c  ldp     d11, d10, [sp], #0x40
  0277e380  ret     

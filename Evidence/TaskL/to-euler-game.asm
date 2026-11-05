=== ActorAnimation.ActorAnimationMathUtility$$ToEuler @ 0x657cb30 (205 insns)
    Unity_Mathematics_float3_o ActorAnimation_ActorAnimationMathUtility__ToEuler (Unity_Mathematics_quaternion_o q, uint8_t rotSeq, const MethodInfo* method);
  0657cb30  stp     d11, d10, [sp, #-0x40]!
  0657cb34  stp     d9, d8, [sp, #0x10]
  0657cb38  str     x30, [sp, #0x20]
  0657cb3c  stp     x20, x19, [sp, #0x30]
  0657cb40  fmov    s9, s3
  0657cb44  fmov    s8, s2
  0657cb48  adrp    x20, #0xf400000
  0657cb4c  fmov    s10, s1
  0657cb50  fmov    s11, s0
  0657cb54  ldrb    w8, [x20, #0x4e4]
  0657cb58  mov     w19, w0
  0657cb5c  tbnz    w8, #0, #0x657cb74
  0657cb60  adrp    x0, #0xea69000
  0657cb64  ldr     x0, [x0, #0xf80]  ; META Unity.Mathematics.float3_TypeInfo
  0657cb68  bl      #0x63cee78
  0657cb6c  mov     w8, #1
  0657cb70  strb    w8, [x20, #0x4e4]
  0657cb74  and     w8, w19, #0xff
  0657cb78  cmp     w8, #2
  0657cb7c  b.gt    #0x657cbfc
  0657cb80  cbz     w8, #0x657cc7c
  0657cb84  cmp     w8, #1
  0657cb88  b.eq    #0x657cd70
  0657cb8c  cmp     w8, #2
  0657cb90  b.ne    #0x657cd54
  0657cb94  fmul    s0, s9, s9
  0657cb98  fmul    s1, s11, s11
  0657cb9c  fmul    s2, s11, s8
  0657cba0  fmul    s3, s9, s10
  0657cba4  fmul    s4, s10, s10
  0657cba8  fmul    s5, s10, s8
  0657cbac  fmul    s6, s9, s11
  0657cbb0  fmul    s7, s9, s8
  0657cbb4  fsub    s0, s0, s1
  0657cbb8  fmul    s1, s11, s10
  0657cbbc  fmul    s16, s8, s8
  0657cbc0  fsub    s2, s2, s3
  0657cbc4  fadd    s5, s5, s6
  0657cbc8  fsub    s3, s0, s4
  0657cbcc  fsub    s6, s1, s7
  0657cbd0  fadd    s4, s4, s0
  0657cbd4  fmov    s7, #-2.00000000
  0657cbd8  fadd    s0, s2, s2
  0657cbdc  fadd    s1, s16, s3
  0657cbe0  fmul    s2, s5, s7
  0657cbe4  fadd    s3, s6, s6
  0657cbe8  fsub    s4, s4, s16
  0657cbec  bl      #0x657ce64  ; -> ActorAnimation.ActorAnimationMathUtility$$ThreeAxisRot
  0657cbf0  fmov    s4, s0
  0657cbf4  fmov    s0, s1
  0657cbf8  b       #0x657cd4c
  0657cbfc  cmp     w8, #3
  0657cc00  b.eq    #0x657cce8
  0657cc04  cmp     w8, #4
  0657cc08  b.eq    #0x657cde0
  0657cc0c  cmp     w8, #5
  0657cc10  b.ne    #0x657cd54
  0657cc14  fmul    s0, s9, s9
  0657cc18  fmul    s1, s11, s11
  0657cc1c  fmul    s2, s11, s10
  0657cc20  fmul    s3, s9, s8
  0657cc24  fmul    s4, s10, s10
  0657cc28  fmul    s5, s11, s8
  0657cc2c  fmul    s6, s9, s10
  0657cc30  fmul    s16, s10, s8
  0657cc34  fadd    s7, s0, s1
  0657cc38  fmul    s17, s9, s11
  0657cc3c  fsub    s0, s0, s1
  0657cc40  fmul    s18, s8, s8
  0657cc44  fsub    s1, s2, s3
  0657cc48  fadd    s3, s5, s6
  0657cc4c  fmov    s6, #-2.00000000
  0657cc50  fsub    s2, s7, s4
  0657cc54  fsub    s5, s16, s17
  0657cc58  fsub    s4, s0, s4
  0657cc5c  fadd    s0, s1, s1
  0657cc60  fsub    s1, s2, s18
  0657cc64  fmul    s2, s3, s6
  0657cc68  fadd    s3, s5, s5
  0657cc6c  fadd    s4, s18, s4
  0657cc70  bl      #0x657ce64  ; -> ActorAnimation.ActorAnimationMathUtility$$ThreeAxisRot
  0657cc74  fmov    s3, s1
  0657cc78  b       #0x657ce44
  0657cc7c  fmul    s0, s9, s9
  0657cc80  fmul    s1, s11, s11
  0657cc84  fmov    s18, #-2.00000000
  0657cc88  fmul    s2, s10, s8
  0657cc8c  fmul    s3, s9, s11
  0657cc90  fmul    s4, s10, s10
  0657cc94  fmul    s5, s11, s8
  0657cc98  fmul    s6, s9, s10
  0657cc9c  fmul    s16, s11, s10
  0657cca0  fsub    s7, s0, s1
  0657cca4  fmul    s17, s9, s8
  0657cca8  fadd    s0, s0, s1
  0657ccac  fmul    s19, s8, s8
  0657ccb0  fadd    s1, s2, s3
  0657ccb4  fsub    s3, s5, s6
  0657ccb8  fsub    s2, s7, s4
  0657ccbc  fadd    s5, s16, s17
  0657ccc0  fsub    s4, s0, s4
  0657ccc4  fmul    s0, s1, s18
  0657ccc8  fadd    s1, s19, s2
  0657cccc  fadd    s2, s3, s3
  0657ccd0  fmul    s3, s5, s18
  0657ccd4  fsub    s4, s4, s19
  0657ccd8  bl      #0x657ce64  ; -> ActorAnimation.ActorAnimationMathUtility$$ThreeAxisRot
  0657ccdc  fmov    s4, s0
  0657cce0  fmov    s3, s1
  0657cce4  b       #0x657cdd8
  0657cce8  fmul    s0, s9, s9
  0657ccec  fmul    s1, s11, s11
  0657ccf0  fmov    s18, #-2.00000000
  0657ccf4  fmul    s2, s11, s8
  0657ccf8  fmul    s3, s9, s10
  0657ccfc  fmul    s4, s10, s10
  0657cd00  fmul    s5, s11, s10
  0657cd04  fmul    s6, s9, s8
  0657cd08  fmul    s16, s10, s8
  0657cd0c  fadd    s7, s0, s1
  0657cd10  fmul    s17, s9, s11
  0657cd14  fsub    s0, s0, s1
  0657cd18  fmul    s19, s8, s8
  0657cd1c  fadd    s1, s2, s3
  0657cd20  fsub    s3, s5, s6
  0657cd24  fsub    s2, s7, s4
  0657cd28  fadd    s5, s16, s17
  0657cd2c  fadd    s4, s4, s0
  0657cd30  fmul    s0, s1, s18
  0657cd34  fsub    s1, s2, s19
  0657cd38  fadd    s2, s3, s3
  0657cd3c  fmul    s3, s5, s18
  0657cd40  fsub    s4, s4, s19
  0657cd44  bl      #0x657ce64  ; -> ActorAnimation.ActorAnimationMathUtility$$ThreeAxisRot
  0657cd48  fmov    s4, s1
  0657cd4c  fmov    s3, s2
  0657cd50  b       #0x657ce48
  0657cd54  adrp    x8, #0xea69000
  0657cd58  ldr     x8, [x8, #0xf80]  ; META Unity.Mathematics.float3_TypeInfo
  0657cd5c  ldr     x8, [x8]
  0657cd60  ldr     x8, [x8, #0xb8]
  0657cd64  ldp     s0, s3, [x8]
  0657cd68  ldr     s4, [x8, #8]
  0657cd6c  b       #0x657ce48
  0657cd70  fmul    s0, s9, s9
  0657cd74  fmul    s1, s11, s11
  0657cd78  fmul    s2, s10, s8
  0657cd7c  fmul    s3, s9, s11
  0657cd80  fmul    s4, s10, s10
  0657cd84  fmul    s5, s11, s10
  0657cd88  fmul    s6, s9, s8
  0657cd8c  fmul    s16, s11, s8
  0657cd90  fsub    s7, s0, s1
  0657cd94  fmul    s17, s9, s10
  0657cd98  fadd    s0, s0, s1
  0657cd9c  fmul    s18, s8, s8
  0657cda0  fsub    s1, s2, s3
  0657cda4  fadd    s3, s5, s6
  0657cda8  fmov    s6, #-2.00000000
  0657cdac  fadd    s2, s4, s7
  0657cdb0  fsub    s5, s16, s17
  0657cdb4  fsub    s4, s0, s4
  0657cdb8  fadd    s0, s1, s1
  0657cdbc  fsub    s1, s2, s18
  0657cdc0  fmul    s2, s3, s6
  0657cdc4  fadd    s3, s5, s5
  0657cdc8  fsub    s4, s4, s18
  0657cdcc  bl      #0x657ce64  ; -> ActorAnimation.ActorAnimationMathUtility$$ThreeAxisRot
  0657cdd0  fmov    s3, s0
  0657cdd4  fmov    s4, s1
  0657cdd8  fmov    s0, s2
  0657cddc  b       #0x657ce48
  0657cde0  fmul    s0, s9, s9
  0657cde4  fmul    s1, s11, s11
  0657cde8  fmov    s16, #-2.00000000
  0657cdec  fmul    s2, s11, s10
  0657cdf0  fmul    s3, s9, s8
  0657cdf4  fmul    s4, s10, s10
  0657cdf8  fmul    s5, s10, s8
  0657cdfc  fmul    s6, s9, s11
  0657ce00  fmul    s7, s9, s10
  0657ce04  fsub    s0, s0, s1
  0657ce08  fmul    s1, s11, s8
  0657ce0c  fmul    s17, s8, s8
  0657ce10  fadd    s2, s2, s3
  0657ce14  fsub    s5, s5, s6
  0657ce18  fadd    s3, s4, s0
  0657ce1c  fadd    s6, s1, s7
  0657ce20  fsub    s4, s0, s4
  0657ce24  fmul    s0, s2, s16
  0657ce28  fadd    s2, s5, s5
  0657ce2c  fsub    s1, s3, s17
  0657ce30  fmul    s3, s6, s16
  0657ce34  fadd    s4, s17, s4
  0657ce38  bl      #0x657ce64  ; -> ActorAnimation.ActorAnimationMathUtility$$ThreeAxisRot
  0657ce3c  fmov    s3, s0
  0657ce40  fmov    s0, s1
  0657ce44  fmov    s4, s2
  0657ce48  ldp     x20, x19, [sp, #0x30]
  0657ce4c  fmov    s1, s3
  0657ce50  ldp     d9, d8, [sp, #0x10]
  0657ce54  fmov    s2, s4
  0657ce58  ldr     x30, [sp, #0x20]
  0657ce5c  ldp     d11, d10, [sp], #0x40
  0657ce60  ret     

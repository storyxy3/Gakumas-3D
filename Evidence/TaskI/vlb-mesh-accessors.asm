=== VLB.SubDrawCall$$get_count @ 0xe0cc8e4 (3 insns)
    int32_t VLB_SubDrawCall__get_count (VLB_SubDrawCall_o __this, const MethodInfo* method);
  0e0cc8e4  ldp     w9, w8, [x0]
  0e0cc8e8  sub     w0, w8, w9
  0e0cc8ec  ret     
=== VLB.GlobalMeshSD$$Get @ 0xe0ddc68 (95 insns)
    UnityEngine_Mesh_o* VLB_GlobalMeshSD__Get (const MethodInfo* method);
  0e0ddc68  str     x30, [sp, #-0x30]!
  0e0ddc6c  stp     x22, x21, [sp, #0x10]
  0e0ddc70  stp     x20, x19, [sp, #0x20]
  0e0ddc74  adrp    x19, #0xf43d000
  0e0ddc78  ldrb    w8, [x19, #0xa84]
  0e0ddc7c  tbnz    w8, #0, #0xe0ddcac
  0e0ddc80  adrp    x0, #0xebd7000
  0e0ddc84  ldr     x0, [x0, #0x738]  ; META VLB.GlobalMeshSD_TypeInfo
  0e0ddc88  bl      #0x63cee78
  0e0ddc8c  adrp    x0, #0xebd6000
  0e0ddc90  ldr     x0, [x0, #0xf78]  ; META VLB.Consts.Internal_TypeInfo
  0e0ddc94  bl      #0x63cee78
  0e0ddc98  adrp    x0, #0xea65000
  0e0ddc9c  ldr     x0, [x0, #0x718]  ; META UnityEngine.Object_TypeInfo
  0e0ddca0  bl      #0x63cee78
  0e0ddca4  mov     w8, #1
  0e0ddca8  strb    w8, [x19, #0xa84]
  0e0ddcac  mov     x0, xzr
  0e0ddcb0  bl      #0xe0c71fc  ; -> VLB.Config$$get_Instance
  0e0ddcb4  cbz     x0, #0xe0ddde0
  0e0ddcb8  adrp    x21, #0xebd7000
  0e0ddcbc  adrp    x19, #0xea65000
  0e0ddcc0  mov     x1, xzr
  0e0ddcc4  ldr     x21, [x21, #0x738]  ; META VLB.GlobalMeshSD_TypeInfo
  0e0ddcc8  ldr     x19, [x19, #0x718]  ; META UnityEngine.Object_TypeInfo
  0e0ddccc  bl      #0xe0c73b0  ; -> VLB.Config$$get_SD_requiresDoubleSidedMesh
  0e0ddcd0  ldr     x9, [x21]
  0e0ddcd4  ldr     x8, [x19]
  0e0ddcd8  mov     w19, w0
  0e0ddcdc  ldr     x9, [x9, #0xb8]
  0e0ddce0  ldr     w10, [x8, #0xe4]
  0e0ddce4  ldr     x20, [x9]
  0e0ddce8  cbnz    w10, #0xe0ddcf4
  0e0ddcec  mov     x0, x8
  0e0ddcf0  bl      #0x63ceff4
  0e0ddcf4  mov     x0, x20
  0e0ddcf8  mov     x1, xzr
  0e0ddcfc  mov     x2, xzr
  0e0ddd00  and     w19, w19, #1
  0e0ddd04  bl      #0xd9de99c  ; -> UnityEngine.Object$$op_Equality
  0e0ddd08  tbnz    w0, #0, #0xe0ddd20
  0e0ddd0c  ldr     x8, [x21]
  0e0ddd10  ldr     x8, [x8, #0xb8]
  0e0ddd14  ldrb    w9, [x8, #8]
  0e0ddd18  cmp     w9, w19
  0e0ddd1c  b.eq    #0xe0dddcc
  0e0ddd20  bl      #0xe0ddde4  ; -> VLB.GlobalMeshSD$$Destroy
  0e0ddd24  mov     x0, xzr
  0e0ddd28  bl      #0xe0c71fc  ; -> VLB.Config$$get_Instance
  0e0ddd2c  cbz     x0, #0xe0ddde0
  0e0ddd30  ldr     w20, [x0, #0x40]
  0e0ddd34  mov     x0, xzr
  0e0ddd38  bl      #0xe0c71fc  ; -> VLB.Config$$get_Instance
  0e0ddd3c  cbz     x0, #0xe0ddde0
  0e0ddd40  adrp    x22, #0xebd6000
  0e0ddd44  fmov    s0, #1.00000000
  0e0ddd48  fmov    s1, #1.00000000
  0e0ddd4c  fmov    s2, #1.00000000
  0e0ddd50  ldr     x22, [x22, #0xf78]  ; META VLB.Consts.Internal_TypeInfo
  0e0ddd54  ldr     w1, [x0, #0x44]
  0e0ddd58  mov     w0, w20
  0e0ddd5c  mov     w2, wzr
  0e0ddd60  mov     w3, w19
  0e0ddd64  mov     x4, xzr
  0e0ddd68  bl      #0xe0d6bd0  ; -> VLB.MeshGenerator$$GenerateConeZ_Radii
  0e0ddd6c  ldr     x8, [x21]
  0e0ddd70  mov     x1, x0
  0e0ddd74  ldr     x8, [x8, #0xb8]
  0e0ddd78  str     x0, [x8]
  0e0ddd7c  ldr     x8, [x21]
  0e0ddd80  ldr     x0, [x8, #0xb8]
  0e0ddd84  bl      #0x63cee24
  0e0ddd88  ldr     x8, [x21]
  0e0ddd8c  ldr     x0, [x22]
  0e0ddd90  ldr     x8, [x8, #0xb8]
  0e0ddd94  ldr     w9, [x0, #0xe4]
  0e0ddd98  ldr     x20, [x8]
  0e0ddd9c  cbnz    w9, #0xe0ddda4
  0e0ddda0  bl      #0x63ceff4
  0e0ddda4  mov     x0, xzr
  0e0ddda8  bl      #0xe0c7630  ; -> VLB.Consts.Internal$$get_ProceduralObjectsHideFlags
  0e0dddac  cbz     x20, #0xe0ddde0
  0e0dddb0  mov     w1, w0
  0e0dddb4  mov     x0, x20
  0e0dddb8  mov     x2, xzr
  0e0dddbc  bl      #0xd9e3d80  ; -> UnityEngine.Object$$set_hideFlags
  0e0dddc0  ldr     x8, [x21]
  0e0dddc4  ldr     x8, [x8, #0xb8]
  0e0dddc8  strb    w19, [x8, #8]
  0e0dddcc  ldp     x20, x19, [sp, #0x20]
  0e0dddd0  ldr     x0, [x8]
  0e0dddd4  ldp     x22, x21, [sp, #0x10]
  0e0dddd8  ldr     x30, [sp], #0x30
  0e0ddddc  ret     
  0e0ddde0  bl      #0x63cf120
=== VLB.GlobalMeshSD$$Destroy @ 0xe0ddde4 (51 insns)
    void VLB_GlobalMeshSD__Destroy (const MethodInfo* method);
  0e0ddde4  stp     x30, x21, [sp, #-0x20]!
  0e0ddde8  stp     x20, x19, [sp, #0x10]
  0e0dddec  adrp    x19, #0xf43d000
  0e0dddf0  adrp    x20, #0xebd7000
  0e0dddf4  adrp    x21, #0xea65000
  0e0dddf8  ldrb    w8, [x19, #0xa85]
  0e0dddfc  ldr     x20, [x20, #0x738]  ; META VLB.GlobalMeshSD_TypeInfo
  0e0dde00  ldr     x21, [x21, #0x718]  ; META UnityEngine.Object_TypeInfo
  0e0dde04  tbnz    w8, #0, #0xe0dde28
  0e0dde08  adrp    x0, #0xebd7000
  0e0dde0c  ldr     x0, [x0, #0x738]  ; META VLB.GlobalMeshSD_TypeInfo
  0e0dde10  bl      #0x63cee78
  0e0dde14  adrp    x0, #0xea65000
  0e0dde18  ldr     x0, [x0, #0x718]  ; META UnityEngine.Object_TypeInfo
  0e0dde1c  bl      #0x63cee78
  0e0dde20  mov     w8, #1
  0e0dde24  strb    w8, [x19, #0xa85]
  0e0dde28  ldr     x8, [x20]
  0e0dde2c  ldr     x0, [x21]
  0e0dde30  ldr     x8, [x8, #0xb8]
  0e0dde34  ldr     w9, [x0, #0xe4]
  0e0dde38  ldr     x19, [x8]
  0e0dde3c  cbnz    w9, #0xe0dde44
  0e0dde40  bl      #0x63ceff4
  0e0dde44  mov     x0, x19
  0e0dde48  mov     x1, xzr
  0e0dde4c  mov     x2, xzr
  0e0dde50  bl      #0xd9db6c4  ; -> UnityEngine.Object$$op_Inequality
  0e0dde54  tbz     w0, #0, #0xe0ddea4
  0e0dde58  ldr     x8, [x20]
  0e0dde5c  ldr     x0, [x21]
  0e0dde60  ldr     x8, [x8, #0xb8]
  0e0dde64  ldr     w9, [x0, #0xe4]
  0e0dde68  ldr     x19, [x8]
  0e0dde6c  cbnz    w9, #0xe0dde74
  0e0dde70  bl      #0x63ceff4
  0e0dde74  mov     x0, x19
  0e0dde78  mov     x1, xzr
  0e0dde7c  bl      #0xd9e39b0  ; -> UnityEngine.Object$$DestroyImmediate
  0e0dde80  ldr     x8, [x20]
  0e0dde84  mov     x1, xzr
  0e0dde88  ldr     x8, [x8, #0xb8]
  0e0dde8c  str     xzr, [x8]
  0e0dde90  ldr     x8, [x20]
  0e0dde94  ldp     x20, x19, [sp, #0x10]
  0e0dde98  ldr     x0, [x8, #0xb8]
  0e0dde9c  ldp     x30, x21, [sp], #0x20
  0e0ddea0  b       #0x63cee24
  0e0ddea4  ldp     x20, x19, [sp, #0x10]
  0e0ddea8  ldp     x30, x21, [sp], #0x20
  0e0ddeac  ret     

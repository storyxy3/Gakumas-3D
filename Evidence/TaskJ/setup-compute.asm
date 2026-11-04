=== Campus.Crowd.CrowdSystem$$SetupComputeCrowd @ 0xddc5ea8 (66 insns)
    void Campus_Crowd_CrowdSystem__SetupComputeCrowd (Campus_Crowd_CrowdSystem_o* __this, UnityEngine_Rendering_CommandBuffer_o* cmd, UnityEngine_Vector3_o lookAt, float randomLookAtWeight, UnityEngine_Vector3_o cameraPos, UnityEngine_Vector3_o cameraForward, UnityEngine_Vector4_o occlusionSphere, const MethodInfo* method);
  0ddc5ea8  sub     sp, sp, #0x90
  0ddc5eac  stp     d15, d14, [sp, #0x30]
  0ddc5eb0  stp     d13, d12, [sp, #0x40]
  0ddc5eb4  stp     d11, d10, [sp, #0x50]
  0ddc5eb8  stp     d9, d8, [sp, #0x60]
  0ddc5ebc  str     x30, [sp, #0x70]
  0ddc5ec0  stp     x20, x19, [sp, #0x80]
  0ddc5ec4  ldp     s16, s7, [sp, #0xa8]
  0ddc5ec8  mov     x19, x0
  0ddc5ecc  ldp     s17, s11, [sp, #0xa0]
  0ddc5ed0  mov     x20, x1
  0ddc5ed4  ldp     s21, s19, [sp, #0x94]
  0ddc5ed8  ldr     x8, [x0, #0x50]
  0ddc5edc  ldr     s20, [sp, #0x90]
  0ddc5ee0  cbz     x8, #0xddc5f50
  0ddc5ee4  ldr     x2, [x8, #0x90]
  0ddc5ee8  mov     x1, x20
  0ddc5eec  stp     s16, s7, [sp, #0x18]
  0ddc5ef0  stp     s17, s11, [sp, #0x10]
  0ddc5ef4  fmov    s15, s0
  0ddc5ef8  fmov    s12, s1
  0ddc5efc  stp     s21, s19, [sp, #4]
  0ddc5f00  fmov    s10, s2
  0ddc5f04  fmov    s9, s3
  0ddc5f08  fmov    s8, s4
  0ddc5f0c  fmov    s14, s5
  0ddc5f10  fmov    s13, s6
  0ddc5f14  str     s20, [sp]
  0ddc5f18  stp     s19, s7, [sp, #0x28]
  0ddc5f1c  stp     s17, s16, [sp, #0x78]
  0ddc5f20  stp     s21, s20, [sp, #0x20]
  0ddc5f24  bl      #0xddc9e30  ; -> Campus.Crowd.CrowdSystem$$SetComputeParams
  0ddc5f28  fmov    s0, s15
  0ddc5f2c  fmov    s1, s12
  0ddc5f30  fmov    s2, s10
  0ddc5f34  fmov    s3, s9
  0ddc5f38  ldp     s21, s20, [sp, #0x20]
  0ddc5f3c  fmov    s4, s8
  0ddc5f40  fmov    s5, s14
  0ddc5f44  fmov    s6, s13
  0ddc5f48  ldp     s19, s7, [sp, #0x28]
  0ddc5f4c  ldp     s17, s16, [sp, #0x78]
  0ddc5f50  ldr     x8, [x19, #0x48]
  0ddc5f54  cbz     x8, #0xddc5f90
  0ddc5f58  ldr     x2, [x8, #0x38]
  0ddc5f5c  stp     s17, s11, [sp, #0xa0]
  0ddc5f60  mov     x1, x20
  0ddc5f64  ldp     x20, x19, [sp, #0x80]
  0ddc5f68  ldr     x30, [sp, #0x70]
  0ddc5f6c  ldp     d9, d8, [sp, #0x60]
  0ddc5f70  stp     s20, s21, [sp, #0x90]
  0ddc5f74  stp     s16, s7, [sp, #0xa8]
  0ddc5f78  ldp     d11, d10, [sp, #0x50]
  0ddc5f7c  str     s19, [sp, #0x98]
  0ddc5f80  ldp     d13, d12, [sp, #0x40]
  0ddc5f84  ldp     d15, d14, [sp, #0x30]
  0ddc5f88  add     sp, sp, #0x90
  0ddc5f8c  b       #0xddc9e30  ; -> Campus.Crowd.CrowdSystem$$SetComputeParams
  0ddc5f90  ldp     x20, x19, [sp, #0x80]
  0ddc5f94  ldr     x30, [sp, #0x70]
  0ddc5f98  ldp     d9, d8, [sp, #0x60]
  0ddc5f9c  ldp     d11, d10, [sp, #0x50]
  0ddc5fa0  ldp     d13, d12, [sp, #0x40]
  0ddc5fa4  ldp     d15, d14, [sp, #0x30]
  0ddc5fa8  add     sp, sp, #0x90
  0ddc5fac  ret     

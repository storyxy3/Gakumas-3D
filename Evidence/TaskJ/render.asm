=== Campus.Crowd.CrowdRenderingSetupData$$Update @ 0xddc45fc (152 insns)
    void Campus_Crowd_CrowdRenderingSetupData__Update (Campus_Crowd_CrowdRenderingSetupData_o* __this, UnityEngine_Rendering_Universal_CameraData_o* cameraData, bool useMainCamera, Campus_Crowd_Crowd_o* crowd, const MethodInfo* method);
  0ddc45fc  stp     d15, d14, [sp, #-0x70]!
  0ddc4600  stp     d13, d12, [sp, #0x10]
  0ddc4604  stp     d11, d10, [sp, #0x20]
  0ddc4608  stp     d9, d8, [sp, #0x30]
  0ddc460c  str     x29, [sp, #0x40]
  0ddc4610  stp     x30, x21, [sp, #0x50]
  0ddc4614  stp     x20, x19, [sp, #0x60]
  0ddc4618  sub     sp, sp, #0x3b0
  0ddc461c  mov     x19, x0
  0ddc4620  add     x0, sp, #0x150
  0ddc4624  mov     w2, #0x210
  0ddc4628  mov     x20, x3
  0ddc462c  mov     x21, x1
  0ddc4630  bl      #0xe1b8430
  0ddc4634  add     x8, sp, #0x110
  0ddc4638  add     x0, sp, #0x150
  0ddc463c  mov     w1, wzr
  0ddc4640  mov     x2, xzr
  0ddc4644  bl      #0xd8489e8  ; -> UnityEngine.Rendering.Universal.CameraData$$GetProjectionMatrix
  0ddc4648  add     x0, sp, #0x150
  0ddc464c  mov     x1, x21
  0ddc4650  mov     w2, #0x210
  0ddc4654  bl      #0xe1b8430
  0ddc4658  add     x8, sp, #0xd0
  0ddc465c  add     x0, sp, #0x150
  0ddc4660  mov     w1, wzr
  0ddc4664  mov     x2, xzr
  0ddc4668  bl      #0xd84896c  ; -> UnityEngine.Rendering.Universal.CameraData$$GetViewMatrix
  0ddc466c  ldp     q0, q1, [sp, #0x110]
  0ddc4670  add     x8, sp, #0x90
  0ddc4674  add     x0, sp, #0x50
  0ddc4678  add     x1, sp, #0x10
  0ddc467c  mov     x2, xzr
  0ddc4680  stp     q0, q1, [sp, #0x50]
  0ddc4684  ldp     q0, q2, [sp, #0x130]
  0ddc4688  stp     q0, q2, [sp, #0x70]
  0ddc468c  ldp     q1, q0, [sp, #0xd0]
  0ddc4690  stp     q1, q0, [sp, #0x10]
  0ddc4694  ldp     q2, q0, [sp, #0xf0]
  0ddc4698  stp     q2, q0, [sp, #0x30]
  0ddc469c  bl      #0xd9c8008  ; -> UnityEngine.Matrix4x4$$op_Multiply
  0ddc46a0  ldp     q0, q1, [sp, #0x90]
  0ddc46a4  add     x8, x21, #0x1c4
  0ddc46a8  ldr     x8, [x8]
  0ddc46ac  ldr     w9, [x21, #0x1cc]
  0ddc46b0  ldr     x0, [x21, #0xc0]
  0ddc46b4  stp     q0, q1, [sp, #0x370]
  0ddc46b8  ldp     q0, q2, [sp, #0xb0]
  0ddc46bc  str     x8, [sp, #0x360]
  0ddc46c0  str     w9, [sp, #0x368]
  0ddc46c4  stp     q0, q2, [sp, #0x390]
  0ddc46c8  cbz     x0, #0xddc4858
  0ddc46cc  mov     x1, xzr
  0ddc46d0  bl      #0xd9d7844  ; -> UnityEngine.Component$$get_transform
  0ddc46d4  cbz     x0, #0xddc4858
  0ddc46d8  mov     x1, xzr
  0ddc46dc  bl      #0xd9ef84c  ; -> UnityEngine.Transform$$get_forward
  0ddc46e0  cbz     x20, #0xddc4858
  0ddc46e4  ldr     x0, [x20, #0x58]
  0ddc46e8  cbz     x0, #0xddc4858
  0ddc46ec  ldr     x8, [x0]
  0ddc46f0  fmov    s8, s0
  0ddc46f4  fmov    s9, s1
  0ddc46f8  fmov    s10, s2
  0ddc46fc  ldr     x9, [x8, #0x218]
  0ddc4700  ldr     x1, [x8, #0x220]
  0ddc4704  blr     x9
  0ddc4708  ldr     x0, [x20, #0x60]
  0ddc470c  cbz     x0, #0xddc4858
  0ddc4710  ldr     x8, [x0]
  0ddc4714  fmov    s14, s0
  0ddc4718  ldr     x9, [x8, #0x218]
  0ddc471c  ldr     x1, [x8, #0x220]
  0ddc4720  blr     x9
  0ddc4724  ldr     x0, [x20, #0x38]
  0ddc4728  cbz     x0, #0xddc4858
  0ddc472c  ldr     x8, [x0]
  0ddc4730  fmov    s11, s0
  0ddc4734  ldr     x9, [x8, #0x218]
  0ddc4738  ldr     x1, [x8, #0x220]
  0ddc473c  blr     x9
  0ddc4740  cbz     x0, #0xddc4858
  0ddc4744  bl      #0xddcd4a0  ; -> Campus.Crowd.CrowdVolume$$get_Position
  0ddc4748  ldr     x0, [x20, #0x38]
  0ddc474c  cbz     x0, #0xddc4858
  0ddc4750  ldr     x8, [x0]
  0ddc4754  fmov    s12, s0
  0ddc4758  fmov    s13, s1
  0ddc475c  fmov    s15, s2
  0ddc4760  ldr     x9, [x8, #0x218]
  0ddc4764  ldr     x1, [x8, #0x220]
  0ddc4768  blr     x9
  0ddc476c  cbz     x0, #0xddc4858
  0ddc4770  ldr     x8, [x20, #0x40]
  0ddc4774  str     s15, [sp, #0x3f8]
  0ddc4778  str     s13, [sp, #0x3fc]
  0ddc477c  cbz     x8, #0xddc4858
  0ddc4780  ldr     x9, [x8]
  0ddc4784  ldr     s0, [x0, #0x70]
  0ddc4788  mov     x0, x8
  0ddc478c  stp     s12, s11, [sp, #8]
  0ddc4790  fmov    s11, s10
  0ddc4794  fmov    s15, s9
  0ddc4798  ldr     x10, [x9, #0x218]
  0ddc479c  ldr     x1, [x9, #0x220]
  0ddc47a0  str     s0, [sp, #4]
  0ddc47a4  blr     x10
  0ddc47a8  ldr     x0, [x20, #0x48]
  0ddc47ac  cbz     x0, #0xddc4858
  0ddc47b0  adrp    x8, #0x276e000
  0ddc47b4  fmov    s13, s0
  0ddc47b8  fmov    s9, s1
  0ddc47bc  ldr     s0, [x8, #0xb48]
  0ddc47c0  ldr     x8, [x0]
  0ddc47c4  fmov    s10, s2
  0ddc47c8  fcmp    s14, s0
  0ddc47cc  ldr     x9, [x8, #0x218]
  0ddc47d0  ldr     x1, [x8, #0x220]
  0ddc47d4  fcsel   s14, s0, s14, mi
  0ddc47d8  fmov    s0, #1.00000000
  0ddc47dc  fdiv    s12, s0, s14
  0ddc47e0  blr     x9
  0ddc47e4  ldp     q1, q2, [sp, #0x370]
  0ddc47e8  ldr     x8, [sp, #0x360]
  0ddc47ec  stp     s8, s15, [x19, #0x5c]
  0ddc47f0  str     x8, [x19, #0x50]
  0ddc47f4  ldr     w8, [sp, #0x368]
  0ddc47f8  stp     q1, q2, [x19, #0x10]
  0ddc47fc  ldp     q1, q2, [sp, #0x390]
  0ddc4800  str     w8, [x19, #0x58]
  0ddc4804  stp     s11, s14, [x19, #0x64]
  0ddc4808  stp     q1, q2, [x19, #0x30]
  0ddc480c  ldp     s3, s2, [sp, #8]
  0ddc4810  ldr     s1, [sp, #0x3fc]
  0ddc4814  stp     wzr, wzr, [x19, #0x74]
  0ddc4818  stp     s13, s9, [x19, #0x8c]
  0ddc481c  stp     s12, s2, [x19, #0x6c]
  0ddc4820  ldr     s2, [sp, #0x3f8]
  0ddc4824  stp     s3, s1, [x19, #0x7c]
  0ddc4828  ldr     s1, [sp, #4]
  0ddc482c  stp     s10, s0, [x19, #0x94]
  0ddc4830  stp     s2, s1, [x19, #0x84]
  0ddc4834  add     sp, sp, #0x3b0
  0ddc4838  ldp     x20, x19, [sp, #0x60]
  0ddc483c  ldr     x29, [sp, #0x40]
  0ddc4840  ldp     x30, x21, [sp, #0x50]
  0ddc4844  ldp     d9, d8, [sp, #0x30]
  0ddc4848  ldp     d11, d10, [sp, #0x20]
  0ddc484c  ldp     d13, d12, [sp, #0x10]
  0ddc4850  ldp     d15, d14, [sp], #0x70
  0ddc4854  ret     
  0ddc4858  bl      #0x63cf120
=== Campus.Crowd.CrowdComputePass$$Execute @ 0xddc5bdc (176 insns)
    void Campus_Crowd_CrowdComputePass__Execute (Campus_Crowd_CrowdComputePass_o* __this, UnityEngine_Rendering_ScriptableRenderContext_o context, UnityEngine_Rendering_Universal_RenderingData_o* renderingData, const MethodInfo* method);
  0ddc5bdc  sub     sp, sp, #0x80
  0ddc5be0  stp     x30, x1, [sp, #0x40]
  0ddc5be4  stp     x24, x23, [sp, #0x50]
  0ddc5be8  stp     x22, x21, [sp, #0x60]
  0ddc5bec  stp     x20, x19, [sp, #0x70]
  0ddc5bf0  adrp    x21, #0xf43b000
  0ddc5bf4  mov     x19, x2
  0ddc5bf8  mov     x20, x0
  0ddc5bfc  ldrb    w8, [x21, #0xcfd]
  0ddc5c00  tbnz    w8, #0, #0xddc5c30
  0ddc5c04  adrp    x0, #0xea6a000
  0ddc5c08  ldr     x0, [x0, #0xcc8]  ; META UnityEngine.Rendering.CommandBufferPool_TypeInfo
  0ddc5c0c  bl      #0x63cee78
  0ddc5c10  adrp    x0, #0xebc6000
  0ddc5c14  ldr     x0, [x0, #0x6f0]  ; META Campus.Crowd.CrowdComputePass_TypeInfo
  0ddc5c18  bl      #0x63cee78
  0ddc5c1c  adrp    x0, #0xea6a000
  0ddc5c20  ldr     x0, [x0, #0xcd0]  ; META UnityEngine.Rendering.ScriptableRenderContext_TypeInfo
  0ddc5c24  bl      #0x63cee78
  0ddc5c28  mov     w8, #1
  0ddc5c2c  strb    w8, [x21, #0xcfd]
  0ddc5c30  ldr     x8, [x20, #0xe0]
  0ddc5c34  strb    wzr, [sp, #0x3c]
  0ddc5c38  cbz     x8, #0xddc5de8
  0ddc5c3c  ldr     x8, [x20, #0xf0]
  0ddc5c40  cbz     x8, #0xddc5de8
  0ddc5c44  adrp    x23, #0xea6a000
  0ddc5c48  ldr     x23, [x23, #0xcc8]  ; META UnityEngine.Rendering.CommandBufferPool_TypeInfo
  0ddc5c4c  ldr     x0, [x23]
  0ddc5c50  ldr     w8, [x0, #0xe4]
  0ddc5c54  cbnz    w8, #0xddc5c5c
  0ddc5c58  bl      #0x63ceff4
  0ddc5c5c  mov     x0, xzr
  0ddc5c60  bl      #0xd787274  ; -> UnityEngine.Rendering.CommandBufferPool$$Get
  0ddc5c64  ldr     x2, [x20, #0x38]
  0ddc5c68  mov     x21, x0
  0ddc5c6c  add     x0, sp, #0x3c
  0ddc5c70  mov     x1, x21
  0ddc5c74  mov     x3, xzr
  0ddc5c78  add     x22, sp, #0x3c
  0ddc5c7c  bl      #0xd7952fc  ; -> UnityEngine.Rendering.ProfilingScope$$.ctor
  0ddc5c80  adrp    x24, #0xea6a000
  0ddc5c84  ldr     x24, [x24, #0xcd0]  ; META UnityEngine.Rendering.ScriptableRenderContext_TypeInfo
  0ddc5c88  stp     xzr, x22, [sp, #0x28]
  0ddc5c8c  ldr     x0, [x24]
  0ddc5c90  ldr     w8, [x0, #0xe4]
  0ddc5c94  cbnz    w8, #0xddc5c9c
  0ddc5c98  bl      #0x63ceff4
  0ddc5c9c  add     x0, sp, #0x48
  0ddc5ca0  mov     x1, x21
  0ddc5ca4  mov     x2, xzr
  0ddc5ca8  bl      #0xda14ca4  ; -> UnityEngine.Rendering.ScriptableRenderContext$$ExecuteCommandBuffer
  0ddc5cac  cbz     x21, #0xddc5e04
  0ddc5cb0  mov     x0, x21
  0ddc5cb4  mov     x1, xzr
  0ddc5cb8  bl      #0xda04cfc  ; -> UnityEngine.Rendering.CommandBuffer$$Clear
  0ddc5cbc  ldr     x8, [x20, #0xe0]
  0ddc5cc0  cbz     x8, #0xddc5e08
  0ddc5cc4  add     x0, x8, #0x58
  0ddc5cc8  mov     x1, xzr
  0ddc5ccc  bl      #0xd958af0  ; -> Unity.Jobs.JobHandle$$Complete
  0ddc5cd0  ldr     x8, [x20, #0xf0]
  0ddc5cd4  cbz     x8, #0xddc5e0c
  0ddc5cd8  ldr     x0, [x20, #0xe0]
  0ddc5cdc  cbz     x0, #0xddc5e10
  0ddc5ce0  ldp     s3, s16, [x8, #0x88]
  0ddc5ce4  ldr     s7, [x8, #0x98]
  0ddc5ce8  ldp     s5, s6, [x8, #0x54]
  0ddc5cec  ldr     x9, [x8, #0x90]
  0ddc5cf0  ldr     s17, [x8, #0x64]
  0ddc5cf4  ldur    x10, [x8, #0x5c]
  0ddc5cf8  ldr     s4, [x8, #0x50]
  0ddc5cfc  ldr     s0, [x8, #0x7c]
  0ddc5d00  ldp     s1, s2, [x8, #0x80]
  0ddc5d04  mov     x1, x21
  0ddc5d08  str     s7, [sp, #0x1c]
  0ddc5d0c  stur    x9, [sp, #0x14]
  0ddc5d10  str     s16, [sp, #0x10]
  0ddc5d14  str     s17, [sp, #8]
  0ddc5d18  str     x10, [sp]
  0ddc5d1c  bl      #0xddc5ea8  ; -> Campus.Crowd.CrowdSystem$$SetupComputeCrowd
  0ddc5d20  ldr     x0, [x20, #0xe0]
  0ddc5d24  cbz     x0, #0xddc5e14
  0ddc5d28  mov     x1, x21
  0ddc5d2c  bl      #0xddc5fb0  ; -> Campus.Crowd.CrowdSystem$$ComputeCrowdSkinning
  0ddc5d30  ldr     x0, [x20, #0xe0]
  0ddc5d34  cbz     x0, #0xddc5e18
  0ddc5d38  mov     x1, x21
  0ddc5d3c  bl      #0xddc61bc  ; -> Campus.Crowd.CrowdSystem$$ComputeCrowd
  0ddc5d40  ldr     x0, [x20, #0xe0]
  0ddc5d44  cbz     x0, #0xddc5e1c
  0ddc5d48  bl      #0xddc6208  ; -> Campus.Crowd.CrowdSystem$$SetupRenderingParameter
  0ddc5d4c  adrp    x22, #0xebc6000
  0ddc5d50  ldr     x22, [x22, #0x6f0]  ; META Campus.Crowd.CrowdComputePass_TypeInfo
  0ddc5d54  ldr     x0, [x22]
  0ddc5d58  ldr     w8, [x0, #0xe4]
  0ddc5d5c  cbnz    w8, #0xddc5d64
  0ddc5d60  bl      #0x63ceff4
  0ddc5d64  ldr     x8, [x20, #0xf0]
  0ddc5d68  cbz     x8, #0xddc5e20
  0ddc5d6c  ldr     x9, [x22]
  0ddc5d70  ldp     s0, s1, [x8, #0x6c]
  0ddc5d74  ldp     s2, s3, [x8, #0x74]
  0ddc5d78  ldr     x9, [x9, #0xb8]
  0ddc5d7c  ldr     w1, [x9]
  0ddc5d80  mov     x0, x21
  0ddc5d84  mov     x2, xzr
  0ddc5d88  bl      #0xda066e0  ; -> UnityEngine.Rendering.CommandBuffer$$SetGlobalVector
  0ddc5d8c  add     x0, sp, #0x3c
  0ddc5d90  mov     x1, xzr
  0ddc5d94  bl      #0xd795300  ; -> UnityEngine.Rendering.ProfilingScope$$Dispose
  0ddc5d98  ldr     x0, [x24]
  0ddc5d9c  ldr     w8, [x0, #0xe4]
  0ddc5da0  cbnz    w8, #0xddc5da8
  0ddc5da4  bl      #0x63ceff4
  0ddc5da8  add     x0, sp, #0x48
  0ddc5dac  mov     x1, x21
  0ddc5db0  mov     x2, xzr
  0ddc5db4  bl      #0xda14ca4  ; -> UnityEngine.Rendering.ScriptableRenderContext$$ExecuteCommandBuffer
  0ddc5db8  ldr     x0, [x23]
  0ddc5dbc  ldr     w8, [x0, #0xe4]
  0ddc5dc0  cbnz    w8, #0xddc5dc8
  0ddc5dc4  bl      #0x63ceff4
  0ddc5dc8  mov     x0, x21
  0ddc5dcc  mov     x1, xzr
  0ddc5dd0  bl      #0xd78163c  ; -> UnityEngine.Rendering.CommandBufferPool$$Release
  0ddc5dd4  ldr     x0, [x20, #0xe0]
  0ddc5dd8  cbz     x0, #0xddc5e00
  0ddc5ddc  ldr     x1, [sp, #0x48]
  0ddc5de0  mov     x2, x19
  0ddc5de4  bl      #0xddc638c  ; -> Campus.Crowd.CrowdSystem$$BakeBillboardCrowd
  0ddc5de8  ldp     x20, x19, [sp, #0x70]
  0ddc5dec  ldr     x30, [sp, #0x40]
  0ddc5df0  ldp     x22, x21, [sp, #0x60]
  0ddc5df4  ldp     x24, x23, [sp, #0x50]
  0ddc5df8  add     sp, sp, #0x80
  0ddc5dfc  ret     
  0ddc5e00  bl      #0x63cf120
  0ddc5e04  bl      #0x63cf120
  0ddc5e08  bl      #0x63cf120
  0ddc5e0c  bl      #0x63cf120
  0ddc5e10  bl      #0x63cf120
  0ddc5e14  bl      #0x63cf120
  0ddc5e18  bl      #0x63cf120
  0ddc5e1c  bl      #0x63cf120
  0ddc5e20  bl      #0x63cf120
  0ddc5e24  b       #0xddc5e4c
  0ddc5e28  b       #0xddc5e4c
  0ddc5e2c  b       #0xddc5e4c
  0ddc5e30  b       #0xddc5e4c
  0ddc5e34  b       #0xddc5e4c
  0ddc5e38  b       #0xddc5e4c
  0ddc5e3c  b       #0xddc5e4c
  0ddc5e40  b       #0xddc5e4c
  0ddc5e44  b       #0xddc5e4c
  0ddc5e48  b       #0xddc5e4c
  0ddc5e4c  mov     x22, x0
  0ddc5e50  cmp     w1, #1
  0ddc5e54  b.ne    #0xddc5e88
  0ddc5e58  mov     x0, x22
  0ddc5e5c  bl      #0xe1b8390
  0ddc5e60  ldr     x22, [x0]
  0ddc5e64  str     x22, [sp, #0x28]
  0ddc5e68  bl      #0xe1b83a0
  0ddc5e6c  ldr     x0, [sp, #0x30]
  0ddc5e70  mov     x1, xzr
  0ddc5e74  bl      #0xd795300  ; -> UnityEngine.Rendering.ProfilingScope$$Dispose
  0ddc5e78  cbz     x22, #0xddc5d98
  0ddc5e7c  mov     x0, x22
  0ddc5e80  bl      #0x63cf118
  0ddc5e84  mov     x22, x0
  0ddc5e88  add     x0, sp, #0x28
  0ddc5e8c  bl      #0xe1b6ffc
  0ddc5e90  mov     x0, x22
  0ddc5e94  bl      #0x64bd8dc
  0ddc5e98  bl      #0xe1b6fd8
=== Campus.Crowd.PenlightMeshRenderSystem$$Render @ 0xddcae1c (251 insns)
    void Campus_Crowd_PenlightMeshRenderSystem__Render (Campus_Crowd_PenlightMeshRenderSystem_o* __this, UnityEngine_Rendering_CommandBuffer_o* cmd, UnityEngine_MaterialPropertyBlock_o* mpb, UnityEngine_Bounds_o bounds, Campus_AudiencePenlight_IAudiencePenlight_o* penlight, int32_t evetType, const MethodInfo* method);
  0ddcae1c  sub     sp, sp, #0x90
  0ddcae20  stp     d11, d10, [sp, #0x10]
  0ddcae24  stp     d9, d8, [sp, #0x20]
  0ddcae28  stp     x29, x30, [sp, #0x30]
  0ddcae2c  stp     x28, x27, [sp, #0x40]
  0ddcae30  stp     x26, x25, [sp, #0x50]
  0ddcae34  stp     x24, x23, [sp, #0x60]
  0ddcae38  stp     x22, x21, [sp, #0x70]
  0ddcae3c  stp     x20, x19, [sp, #0x80]
  0ddcae40  adrp    x25, #0xf43b000
  0ddcae44  mov     w22, w5
  0ddcae48  mov     x23, x4
  0ddcae4c  ldrb    w8, [x25, #0xd33]
  0ddcae50  mov     x24, x3
  0ddcae54  mov     x19, x2
  0ddcae58  mov     x20, x1
  0ddcae5c  mov     x21, x0
  0ddcae60  tbnz    w8, #0, #0xddcaea8
  0ddcae64  adrp    x0, #0xebc5000
  0ddcae68  ldr     x0, [x0, #0xce0]  ; META Campus.AudiencePenlight.IAudiencePenlight_TypeInfo
  0ddcae6c  bl      #0x63cee78
  0ddcae70  adrp    x0, #0xebc6000
  0ddcae74  ldr     x0, [x0, #0x9a0]  ; MMETH Method$System.Runtime.InteropServices.Marshal.SizeOf<uint>()
  0ddcae78  bl      #0x63cee78
  0ddcae7c  adrp    x0, #0xeb68000
  0ddcae80  ldr     x0, [x0, #0xa18]  ; META System.Runtime.InteropServices.Marshal_TypeInfo
  0ddcae84  bl      #0x63cee78
  0ddcae88  adrp    x0, #0xea65000
  0ddcae8c  ldr     x0, [x0, #0x718]  ; META UnityEngine.Object_TypeInfo
  0ddcae90  bl      #0x63cee78
  0ddcae94  adrp    x0, #0xebc6000
  0ddcae98  ldr     x0, [x0, #0x950]  ; META Campus.Crowd.PenlightMeshRenderSystem_TypeInfo
  0ddcae9c  bl      #0x63cee78
  0ddcaea0  mov     w8, #1
  0ddcaea4  strb    w8, [x25, #0xd33]
  0ddcaea8  ldr     x8, [x21, #0x10]
  0ddcaeac  cbz     x8, #0xddcb1d8
  0ddcaeb0  adrp    x27, #0xea65000
  0ddcaeb4  ldr     x27, [x27, #0x718]  ; META UnityEngine.Object_TypeInfo
  0ddcaeb8  ldr     x25, [x21, #0x18]
  0ddcaebc  ldr     x0, [x27]
  0ddcaec0  ldr     w8, [x0, #0xe4]
  0ddcaec4  cbnz    w8, #0xddcaecc
  0ddcaec8  bl      #0x63ceff4
  0ddcaecc  mov     x0, x25
  0ddcaed0  mov     x1, xzr
  0ddcaed4  mov     x2, xzr
  0ddcaed8  bl      #0xd9de99c  ; -> UnityEngine.Object$$op_Equality
  0ddcaedc  tbnz    w0, #0, #0xddcb1d8
  0ddcaee0  cbz     x19, #0xddcb1d8
  0ddcaee4  cbz     x23, #0xddcb1d8
  0ddcaee8  adrp    x25, #0xebc5000
  0ddcaeec  ldr     x8, [x23]
  0ddcaef0  ldr     x25, [x25, #0xce0]  ; META Campus.AudiencePenlight.IAudiencePenlight_TypeInfo
  0ddcaef4  ldrh    w9, [x8, #0x12e]
  0ddcaef8  ldr     x1, [x25]
  0ddcaefc  cbz     x9, #0xddcaf20
  0ddcaf00  ldr     x10, [x8, #0xb0]
  0ddcaf04  add     x10, x10, #8
  0ddcaf08  ldur    x11, [x10, #-8]
  0ddcaf0c  cmp     x11, x1
  0ddcaf10  b.eq    #0xddcaf30
  0ddcaf14  subs    x9, x9, #1
  0ddcaf18  add     x10, x10, #0x10
  0ddcaf1c  b.ne    #0xddcaf08
  0ddcaf20  mov     x0, x23
  0ddcaf24  mov     w2, wzr
  0ddcaf28  bl      #0x6408234
  0ddcaf2c  b       #0xddcaf3c
  0ddcaf30  ldrsw   x9, [x10]
  0ddcaf34  add     x8, x8, x9, lsl #4
  0ddcaf38  add     x0, x8, #0x138
  0ddcaf3c  ldp     x8, x1, [x0]
  0ddcaf40  mov     x0, x23
  0ddcaf44  blr     x8
  0ddcaf48  tbz     w0, #0, #0xddcb010
  0ddcaf4c  ldp     s1, s0, [x24, #8]
  0ddcaf50  fmov    s3, #1.00000000
  0ddcaf54  fadd    s2, s0, s0
  0ddcaf58  fdiv    s8, s3, s2
  0ddcaf5c  ldr     s2, [x24, #0x14]
  0ddcaf60  fadd    s4, s2, s2
  0ddcaf64  fsub    s1, s1, s2
  0ddcaf68  fdiv    s9, s3, s4
  0ddcaf6c  ldr     s3, [x24]
  0ddcaf70  adrp    x24, #0xebc6000
  0ddcaf74  ldr     x24, [x24, #0x950]  ; META Campus.Crowd.PenlightMeshRenderSystem_TypeInfo
  0ddcaf78  fsub    s0, s3, s0
  0ddcaf7c  ldr     x0, [x24]
  0ddcaf80  ldr     w8, [x0, #0xe4]
  0ddcaf84  fmul    s10, s8, s0
  0ddcaf88  fmul    s11, s9, s1
  0ddcaf8c  cbnz    w8, #0xddcaf98
  0ddcaf90  bl      #0x63ceff4
  0ddcaf94  ldr     x0, [x24]
  0ddcaf98  ldr     x8, [x0, #0xb8]
  0ddcaf9c  fmov    s0, s10
  0ddcafa0  fmov    s1, s11
  0ddcafa4  fmov    s2, s8
  0ddcafa8  fmov    s3, s9
  0ddcafac  mov     x0, x19
  0ddcafb0  ldr     w1, [x8, #0x14]
  0ddcafb4  mov     x2, xzr
  0ddcafb8  bl      #0xd98619c  ; -> UnityEngine.MaterialPropertyBlock$$SetVector
  0ddcafbc  ldr     x1, [x25]
  0ddcafc0  mov     w0, #2
  0ddcafc4  mov     x2, x23
  0ddcafc8  bl      #0xe1b7008
  0ddcafcc  ldr     x1, [x25]
  0ddcafd0  mov     w0, #3
  0ddcafd4  mov     x2, x23
  0ddcafd8  fmov    s8, s0
  0ddcafdc  fmov    s9, s1
  0ddcafe0  bl      #0xe1b7008
  0ddcafe4  ldr     x8, [x24]
  0ddcafe8  fsub    s0, s0, s8
  0ddcafec  fsub    s1, s1, s9
  0ddcaff0  fmov    s2, s8
  0ddcaff4  fmov    s3, s9
  0ddcaff8  mov     x0, x19
  0ddcaffc  ldr     x8, [x8, #0xb8]
  0ddcb000  mov     x2, xzr
  0ddcb004  ldr     w1, [x8, #0x18]
  0ddcb008  bl      #0xd98619c  ; -> UnityEngine.MaterialPropertyBlock$$SetVector
  0ddcb00c  b       #0xddcb058
  0ddcb010  adrp    x24, #0xebc6000
  0ddcb014  ldr     x24, [x24, #0x950]  ; META Campus.Crowd.PenlightMeshRenderSystem_TypeInfo
  0ddcb018  ldr     x0, [x24]
  0ddcb01c  ldr     w8, [x0, #0xe4]
  0ddcb020  cbnz    w8, #0xddcb02c
  0ddcb024  bl      #0x63ceff4
  0ddcb028  ldr     x0, [x24]
  0ddcb02c  ldr     x8, [x0, #0xb8]
  0ddcb030  ldr     x1, [x25]
  0ddcb034  mov     w0, #1
  0ddcb038  mov     x2, x23
  0ddcb03c  ldr     w24, [x8, #0x10]
  0ddcb040  bl      #0xe1b7008
  0ddcb044  mov     x2, x0
  0ddcb048  mov     x0, x19
  0ddcb04c  mov     w1, w24
  0ddcb050  mov     x3, xzr
  0ddcb054  bl      #0xd986278  ; -> UnityEngine.MaterialPropertyBlock$$SetVectorArray
  0ddcb058  cmp     w22, #1
  0ddcb05c  b.eq    #0xddcb08c
  0ddcb060  cbnz    w22, #0xddcb0b4
  0ddcb064  adrp    x22, #0xebc6000
  0ddcb068  ldr     x22, [x22, #0x950]  ; META Campus.Crowd.PenlightMeshRenderSystem_TypeInfo
  0ddcb06c  ldr     x0, [x22]
  0ddcb070  ldr     w8, [x0, #0xe4]
  0ddcb074  cbnz    w8, #0xddcb080
  0ddcb078  bl      #0x63ceff4
  0ddcb07c  ldr     x0, [x22]
  0ddcb080  ldr     x8, [x0, #0xb8]
  0ddcb084  ldr     w22, [x8, #0x2c]
  0ddcb088  b       #0xddcb0b8
  0ddcb08c  adrp    x22, #0xebc6000
  0ddcb090  ldr     x22, [x22, #0x950]  ; META Campus.Crowd.PenlightMeshRenderSystem_TypeInfo
  0ddcb094  ldr     x0, [x22]
  0ddcb098  ldr     w8, [x0, #0xe4]
  0ddcb09c  cbnz    w8, #0xddcb0a8
  0ddcb0a0  bl      #0x63ceff4
  0ddcb0a4  ldr     x0, [x22]
  0ddcb0a8  ldr     x8, [x0, #0xb8]
  0ddcb0ac  ldr     w22, [x8, #0x28]
  0ddcb0b0  b       #0xddcb0b8
  0ddcb0b4  mov     w22, #-1
  0ddcb0b8  adrp    x8, #0xeb68000
  0ddcb0bc  ldr     x8, [x8, #0xa18]  ; META System.Runtime.InteropServices.Marshal_TypeInfo
  0ddcb0c0  ldr     x0, [x8]
  0ddcb0c4  ldr     w8, [x0, #0xe4]
  0ddcb0c8  cbnz    w8, #0xddcb0d0
  0ddcb0cc  bl      #0x63ceff4
  0ddcb0d0  adrp    x8, #0xebc6000
  0ddcb0d4  ldr     x8, [x8, #0x9a0]  ; MMETH Method$System.Runtime.InteropServices.Marshal.SizeOf<uint>()
  0ddcb0d8  ldr     x0, [x8]
  0ddcb0dc  bl      #0x92666c0  ; -> System.Runtime.InteropServices.Marshal$$SizeOf<uint>
  0ddcb0e0  ldr     w8, [x21, #0x20]
  0ddcb0e4  cmp     w8, #1
  0ddcb0e8  b.lt    #0xddcb1d8
  0ddcb0ec  adrp    x29, #0xebc6000
  0ddcb0f0  add     w28, w0, w0, lsl #2
  0ddcb0f4  mov     w23, wzr
  0ddcb0f8  ldr     x29, [x29, #0x950]  ; META Campus.Crowd.PenlightMeshRenderSystem_TypeInfo
  0ddcb0fc  mov     x24, xzr
  0ddcb100  ldr     x8, [x21, #0x10]
  0ddcb104  cbz     x8, #0xddcb200
  0ddcb108  ldr     x8, [x8, #0x18]
  0ddcb10c  cbz     x8, #0xddcb200
  0ddcb110  ldr     w9, [x8, #0x18]
  0ddcb114  cmp     x24, x9
  0ddcb118  b.hs    #0xddcb204
  0ddcb11c  add     x8, x8, x24, lsl #3
  0ddcb120  ldr     x8, [x8, #0x20]
  0ddcb124  cbz     x8, #0xddcb130
  0ddcb128  ldr     x25, [x8, #0x20]
  0ddcb12c  b       #0xddcb134
  0ddcb130  mov     x25, xzr
  0ddcb134  ldr     x0, [x27]
  0ddcb138  ldr     w8, [x0, #0xe4]
  0ddcb13c  cbnz    w8, #0xddcb144
  0ddcb140  bl      #0x63ceff4
  0ddcb144  mov     x0, x25
  0ddcb148  mov     x1, xzr
  0ddcb14c  mov     x2, xzr
  0ddcb150  bl      #0xd9de99c  ; -> UnityEngine.Object$$op_Equality
  0ddcb154  tbnz    w0, #0, #0xddcb1c4
  0ddcb158  mov     x0, x21
  0ddcb15c  mov     w1, w24
  0ddcb160  bl      #0xddcc0e0  ; -> Campus.Crowd.PenlightMeshRenderSystem$$GetPenlightInfoBytesBuffer
  0ddcb164  cbz     x0, #0xddcb1c4
  0ddcb168  mov     x26, x0
  0ddcb16c  ldr     x0, [x29]
  0ddcb170  ldr     w8, [x0, #0xe4]
  0ddcb174  cbnz    w8, #0xddcb180
  0ddcb178  bl      #0x63ceff4
  0ddcb17c  ldr     x0, [x29]
  0ddcb180  ldr     x8, [x0, #0xb8]
  0ddcb184  mov     x0, x19
  0ddcb188  mov     x2, x26
  0ddcb18c  mov     x3, xzr
  0ddcb190  ldr     w1, [x8, #0xc]
  0ddcb194  bl      #0xd986220  ; -> UnityEngine.MaterialPropertyBlock$$SetBuffer
  0ddcb198  cbz     x20, #0xddcb200
  0ddcb19c  ldr     x5, [x21, #0x28]
  0ddcb1a0  ldr     x1, [x21, #0x18]
  0ddcb1a4  mov     x0, x20
  0ddcb1a8  mov     w2, w24
  0ddcb1ac  mov     x3, x25
  0ddcb1b0  mov     w4, w22
  0ddcb1b4  mov     w6, w23
  0ddcb1b8  mov     x7, x19
  0ddcb1bc  str     xzr, [sp]
  0ddcb1c0  bl      #0xda0a808  ; -> UnityEngine.Rendering.CommandBuffer$$DrawMeshInstancedIndirect
  0ddcb1c4  ldrsw   x8, [x21, #0x20]
  0ddcb1c8  add     x24, x24, #1
  0ddcb1cc  add     w23, w23, w28
  0ddcb1d0  cmp     x24, x8
  0ddcb1d4  b.lt    #0xddcb100
  0ddcb1d8  ldp     x20, x19, [sp, #0x80]
  0ddcb1dc  ldp     x22, x21, [sp, #0x70]
  0ddcb1e0  ldp     x24, x23, [sp, #0x60]
  0ddcb1e4  ldp     x26, x25, [sp, #0x50]
  0ddcb1e8  ldp     x28, x27, [sp, #0x40]
  0ddcb1ec  ldp     x29, x30, [sp, #0x30]
  0ddcb1f0  ldp     d9, d8, [sp, #0x20]
  0ddcb1f4  ldp     d11, d10, [sp, #0x10]
  0ddcb1f8  add     sp, sp, #0x90
  0ddcb1fc  ret     
  0ddcb200  bl      #0x63cf120
  0ddcb204  bl      #0x63cf128

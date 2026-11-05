=== VLB.VLBDrawSystem$$ExecuteHD @ 0xe0cc2e0 (93 insns)
    void VLB_VLBDrawSystem__ExecuteHD (VLB_VLBDrawSystem_o* __this, UnityEngine_Rendering_CommandBuffer_o* cmd, UnityEngine_Rendering_CullingResults_o* cullResults, UnityEngine_Rendering_Universal_Internal_AdditionalLightsShadowCasterPass_o* shadowCasterPass, const MethodInfo* method);
  0e0cc2e0  sub     sp, sp, #0x70
  0e0cc2e4  stp     x29, x30, [sp, #0x10]
  0e0cc2e8  stp     x28, x27, [sp, #0x20]
  0e0cc2ec  stp     x26, x25, [sp, #0x30]
  0e0cc2f0  stp     x24, x23, [sp, #0x40]
  0e0cc2f4  stp     x22, x21, [sp, #0x50]
  0e0cc2f8  stp     x20, x19, [sp, #0x60]
  0e0cc2fc  adrp    x23, #0xf43d000
  0e0cc300  mov     x19, x3
  0e0cc304  mov     x20, x2
  0e0cc308  ldrb    w8, [x23, #0x9df]
  0e0cc30c  mov     x21, x1
  0e0cc310  mov     x22, x0
  0e0cc314  tbnz    w8, #0, #0xe0cc344
  0e0cc318  adrp    x0, #0xebd7000
  0e0cc31c  ldr     x0, [x0, #0x170]  ; MMETH Method$System.Collections.Generic.List<VLBEntityChunk>.get_Item()
  0e0cc320  bl      #0x63cee78
  0e0cc324  adrp    x0, #0xebd7000
  0e0cc328  ldr     x0, [x0, #0x178]  ; MMETH Method$System.Collections.Generic.List<VLBCachedChunk>.get_Item()
  0e0cc32c  bl      #0x63cee78
  0e0cc330  adrp    x0, #0xebd7000
  0e0cc334  ldr     x0, [x0, #0x200]  ; MMETH Method$System.Collections.Generic.List<VLBDrawCallChunk>.get_Item()
  0e0cc338  bl      #0x63cee78
  0e0cc33c  mov     w8, #1
  0e0cc340  strb    w8, [x23, #0x9df]
  0e0cc344  ldrb    w8, [x22, #0x10]
  0e0cc348  cbz     w8, #0xe0cc434
  0e0cc34c  ldr     x8, [x22, #0x18]
  0e0cc350  cbz     x8, #0xe0cc430
  0e0cc354  adrp    x27, #0xebd7000
  0e0cc358  adrp    x28, #0xebd7000
  0e0cc35c  adrp    x29, #0xebd7000
  0e0cc360  ldr     x27, [x27, #0x170]  ; MMETH Method$System.Collections.Generic.List<VLBEntityChunk>.get_Item()
  0e0cc364  ldr     x28, [x28, #0x178]  ; MMETH Method$System.Collections.Generic.List<VLBCachedChunk>.get_Item()
  0e0cc368  ldr     x29, [x29, #0x200]  ; MMETH Method$System.Collections.Generic.List<VLBDrawCallChunk>.get_Item()
  0e0cc36c  mov     w23, wzr
  0e0cc370  ldr     w9, [x8, #0x38]
  0e0cc374  cmp     w23, w9
  0e0cc378  b.ge    #0xe0cc434
  0e0cc37c  ldr     x0, [x8, #0x18]
  0e0cc380  cbz     x0, #0xe0cc430
  0e0cc384  ldr     x2, [x27]
  0e0cc388  mov     w1, w23
  0e0cc38c  bl      #0xac1b344  ; -> System.Collections.Generic.List<object>$$get_Item
  0e0cc390  cbz     x0, #0xe0cc430
  0e0cc394  ldrb    w8, [x0, #0x49]
  0e0cc398  mov     x24, x0
  0e0cc39c  tbz     w8, #2, #0xe0cc424
  0e0cc3a0  ldr     x8, [x22, #0x18]
  0e0cc3a4  cbz     x8, #0xe0cc430
  0e0cc3a8  ldr     x0, [x8, #0x20]
  0e0cc3ac  cbz     x0, #0xe0cc430
  0e0cc3b0  ldr     x2, [x28]
  0e0cc3b4  mov     w1, w23
  0e0cc3b8  bl      #0xac1b344  ; -> System.Collections.Generic.List<object>$$get_Item
  0e0cc3bc  ldr     x8, [x22, #0x18]
  0e0cc3c0  cbz     x8, #0xe0cc430
  0e0cc3c4  mov     x25, x0
  0e0cc3c8  ldr     x0, [x8, #0x30]
  0e0cc3cc  cbz     x0, #0xe0cc430
  0e0cc3d0  ldr     x2, [x29]
  0e0cc3d4  mov     w1, w23
  0e0cc3d8  bl      #0xac1b344  ; -> System.Collections.Generic.List<object>$$get_Item
  0e0cc3dc  ldr     x8, [x22, #0x18]
  0e0cc3e0  cbz     x8, #0xe0cc430
  0e0cc3e4  mov     x26, x0
  0e0cc3e8  ldr     x0, [x8, #0x18]
  0e0cc3ec  cbz     x0, #0xe0cc430
  0e0cc3f0  ldr     x2, [x27]
  0e0cc3f4  mov     w1, w23
  0e0cc3f8  bl      #0xac1b344  ; -> System.Collections.Generic.List<object>$$get_Item
  0e0cc3fc  cbz     x0, #0xe0cc430
  0e0cc400  ldr     w5, [x0, #0x10]
  0e0cc404  mov     x0, x22
  0e0cc408  mov     x1, x21
  0e0cc40c  mov     x2, x24
  0e0cc410  mov     x3, x25
  0e0cc414  mov     x4, x26
  0e0cc418  mov     x6, x20
  0e0cc41c  mov     x7, x19
  0e0cc420  bl      #0xe0cc454  ; -> VLB.VLBDrawSystem$$ExecuteHD
  0e0cc424  ldr     x8, [x22, #0x18]
  0e0cc428  add     w23, w23, #1
  0e0cc42c  cbnz    x8, #0xe0cc370
  0e0cc430  bl      #0x63cf120
  0e0cc434  ldp     x20, x19, [sp, #0x60]
  0e0cc438  ldp     x22, x21, [sp, #0x50]
  0e0cc43c  ldp     x24, x23, [sp, #0x40]
  0e0cc440  ldp     x26, x25, [sp, #0x30]
  0e0cc444  ldp     x28, x27, [sp, #0x20]
  0e0cc448  ldp     x29, x30, [sp, #0x10]
  0e0cc44c  add     sp, sp, #0x70
  0e0cc450  ret     
=== VLB.VLBDrawSystem$$ExecuteHD @ 0xe0cc454 (289 insns)
    void VLB_VLBDrawSystem__ExecuteHD (VLB_VLBDrawSystem_o* __this, UnityEngine_Rendering_CommandBuffer_o* cmd, VLB_VLBEntityChunk_o* entityChunk, VLB_VLBCachedChunk_o* cachedChunk, VLB_VLBDrawCallChunk_o* drawCallChunk, int32_t count, UnityEngine_Rendering_CullingResults_o* cullResults, UnityEngine_Rendering_Universal_Internal_AdditionalLightsShadowCasterPass_o* shadowCasterPass, const MethodInfo* method);
  0e0cc454  str     d12, [sp, #-0x90]!
  0e0cc458  stp     d11, d10, [sp, #0x10]
  0e0cc45c  stp     d9, d8, [sp, #0x20]
  0e0cc460  stp     x29, x30, [sp, #0x30]
  0e0cc464  stp     x28, x27, [sp, #0x40]
  0e0cc468  stp     x26, x25, [sp, #0x50]
  0e0cc46c  stp     x24, x23, [sp, #0x60]
  0e0cc470  stp     x22, x21, [sp, #0x70]
  0e0cc474  stp     x20, x19, [sp, #0x80]
  0e0cc478  sub     sp, sp, #0x280
  0e0cc47c  adrp    x19, #0xf43d000
  0e0cc480  mov     x26, x6
  0e0cc484  mov     w24, w5
  0e0cc488  ldrb    w8, [x19, #0x9e2]
  0e0cc48c  mov     x20, x4
  0e0cc490  mov     x21, x3
  0e0cc494  mov     x29, x1
  0e0cc498  str     x7, [sp, #0x68]
  0e0cc49c  str     x2, [sp, #0x288]
  0e0cc4a0  tbnz    w8, #0, #0xe0cc4d0
  0e0cc4a4  adrp    x0, #0xea67000
  0e0cc4a8  ldr     x0, [x0, #0x190]  ; META System.Math_TypeInfo
  0e0cc4ac  bl      #0x63cee78
  0e0cc4b0  adrp    x0, #0xea65000
  0e0cc4b4  ldr     x0, [x0, #0x718]  ; META UnityEngine.Object_TypeInfo
  0e0cc4b8  bl      #0x63cee78
  0e0cc4bc  adrp    x0, #0xebd7000
  0e0cc4c0  ldr     x0, [x0, #0x220]  ; META VLB.VLBDrawSystem_TypeInfo
  0e0cc4c4  bl      #0x63cee78
  0e0cc4c8  mov     w8, #1
  0e0cc4cc  strb    w8, [x19, #0x9e2]
  0e0cc4d0  str     xzr, [sp, #0x278]
  0e0cc4d4  str     xzr, [sp, #0x270]
  0e0cc4d8  cbz     x21, #0xe0cc8d0
  0e0cc4dc  ldur    q0, [x21, #0x18]
  0e0cc4e0  add     x0, sp, #0x270
  0e0cc4e4  mov     x1, xzr
  0e0cc4e8  str     q0, [sp, #0x270]
  0e0cc4ec  bl      #0xd958af0  ; -> Unity.Jobs.JobHandle$$Complete
  0e0cc4f0  cbz     x20, #0xe0cc8d0
  0e0cc4f4  ldur    q0, [x20, #0x18]
  0e0cc4f8  add     x0, sp, #0x270
  0e0cc4fc  mov     x1, xzr
  0e0cc500  str     q0, [sp, #0x270]
  0e0cc504  bl      #0xd958af0  ; -> Unity.Jobs.JobHandle$$Complete
  0e0cc508  ldr     x8, [sp, #0x288]
  0e0cc50c  cbz     x8, #0xe0cc8d0
  0e0cc510  cbz     w24, #0xe0cc8a4
  0e0cc514  adrp    x8, #0xea65000
  0e0cc518  ldr     x8, [x8, #0x718]  ; META UnityEngine.Object_TypeInfo
  0e0cc51c  ldr     x9, [sp, #0x288]
  0e0cc520  ldr     x0, [x8]
  0e0cc524  ldr     x19, [x9, #0x50]
  0e0cc528  ldr     w8, [x0, #0xe4]
  0e0cc52c  cbnz    w8, #0xe0cc534
  0e0cc530  bl      #0x63ceff4
  0e0cc534  mov     x0, x19
  0e0cc538  mov     x1, xzr
  0e0cc53c  mov     x2, xzr
  0e0cc540  bl      #0xd9de99c  ; -> UnityEngine.Object$$op_Equality
  0e0cc544  tbnz    w0, #0, #0xe0cc8a4
  0e0cc548  cbz     x19, #0xe0cc8d0
  0e0cc54c  mov     x0, x19
  0e0cc550  mov     x1, xzr
  0e0cc554  bl      #0xd97f634  ; -> UnityEngine.Material$$get_enableInstancing
  0e0cc558  ldr     x8, [sp, #0x68]
  0e0cc55c  cbz     x8, #0xe0cc8a4
  0e0cc560  tbz     w0, #0, #0xe0cc8a4
  0e0cc564  bl      #0xe0cca14  ; -> VLB.GlobalMeshHD$$Get
  0e0cc568  str     x0, [sp, #0x50]
  0e0cc56c  mov     x0, x26
  0e0cc570  mov     x1, xzr
  0e0cc574  bl      #0xda0ddf0  ; -> UnityEngine.Rendering.CullingResults$$get_visibleLights
  0e0cc578  stp     x1, x0, [sp, #0x58]
  0e0cc57c  mov     x0, xzr
  0e0cc580  bl      #0xd9e5f00  ; -> UnityEngine.Time$$get_timeAsDouble
  0e0cc584  adrp    x8, #0xea67000
  0e0cc588  fmov    d8, d0
  0e0cc58c  ldr     x8, [x8, #0x190]  ; META System.Math_TypeInfo
  0e0cc590  ldr     x0, [x8]
  0e0cc594  ldr     w8, [x0, #0xe4]
  0e0cc598  cbnz    w8, #0xe0cc5a0
  0e0cc59c  bl      #0x63ceff4
  0e0cc5a0  ldr     x8, [x20, #0x88]
  0e0cc5a4  ldr     w8, [x8]
  0e0cc5a8  cmp     w8, #1
  0e0cc5ac  str     x8, [sp, #0x10]
  0e0cc5b0  b.lt    #0xe0cc8a4
  0e0cc5b4  mov     x8, #0x404e000000000000
  0e0cc5b8  adrp    x25, #0xebd7000
  0e0cc5bc  mov     x9, xzr
  0e0cc5c0  fmov    d0, x8
  0e0cc5c4  adrp    x8, #0x276d000
  0e0cc5c8  ldr     x25, [x25, #0x220]  ; META VLB.VLBDrawSystem_TypeInfo
  0e0cc5cc  ldr     d1, [x8, #0xac8]
  0e0cc5d0  stp     x19, x29, [sp, #0x40]
  0e0cc5d4  fmul    d0, d8, d0
  0e0cc5d8  frintm  d0, d0
  0e0cc5dc  fmul    d0, d0, d1
  0e0cc5e0  frintm  d1, d0
  0e0cc5e4  fsub    d0, d0, d1
  0e0cc5e8  fcvt    s8, d0
  0e0cc5ec  ldr     x8, [x20, #0x78]
  0e0cc5f0  str     x9, [sp, #0x18]
  0e0cc5f4  add     x9, x8, x9, lsl #3
  0e0cc5f8  ldp     w8, w9, [x9]
  0e0cc5fc  sxtw    x8, w8
  0e0cc600  cmp     w9, w8
  0e0cc604  b.le    #0xe0cc894
  0e0cc608  lsl     x19, x8, #2
  0e0cc60c  lsl     x22, x8, #4
  0e0cc610  lsl     x26, x8, #6
  0e0cc614  sub     w27, w9, w8
  0e0cc618  ldr     x8, [sp, #0x288]
  0e0cc61c  ldr     x8, [x8, #0x38]
  0e0cc620  cbz     x8, #0xe0cc8d0
  0e0cc624  ldr     x9, [x20, #0x98]
  0e0cc628  ldrsw   x23, [x9, x19]
  0e0cc62c  ldr     w9, [x8, #0x18]
  0e0cc630  cmp     w23, w9
  0e0cc634  b.hs    #0xe0cc8d4
  0e0cc638  add     x8, x8, x23, lsl #3
  0e0cc63c  ldp     x3, x2, [sp, #0x58]
  0e0cc640  ldr     x4, [sp, #0x68]
  0e0cc644  ldr     x1, [x8, #0x20]
  0e0cc648  bl      #0xe0cc8f0  ; -> VLB.VLBDrawSystem$$GetShadowLightIndex
  0e0cc64c  tbnz    w0, #0x1f, #0xe0cc880
  0e0cc650  ldr     x8, [x20, #0x68]
  0e0cc654  mov     w28, w0
  0e0cc658  ldr     x0, [x25]
  0e0cc65c  ldr     x9, [x20, #0x38]
  0e0cc660  ldr     x29, [x21, #0x28]
  0e0cc664  add     x8, x8, x22, lsl #2
  0e0cc668  ldr     w10, [x0, #0xe4]
  0e0cc66c  ldr     s0, [x8, #4]
  0e0cc670  ldr     s1, [x8, #0x14]
  0e0cc674  ldr     x8, [x20, #0x58]
  0e0cc678  fcmp    s0, s1
  0e0cc67c  add     x8, x8, x22, lsl #2
  0e0cc680  ldp     s10, s11, [x8, #0x10]
  0e0cc684  ldr     s9, [x8, #4]
  0e0cc688  fcsel   s0, s0, s1, gt
  0e0cc68c  ldr     s12, [x8, #0x24]
  0e0cc690  ldr     q1, [x9, x22]
  0e0cc694  cbnz    w10, #0xe0cc6a8
  0e0cc698  stp     q1, q0, [sp, #0x20]
  0e0cc69c  bl      #0x63ceff4
  0e0cc6a0  ldp     q1, q0, [sp, #0x20]
  0e0cc6a4  ldr     x0, [x25]
  0e0cc6a8  fmul    v0.4s, v1.4s, v0.s[0]
  0e0cc6ac  ldr     x8, [x0, #0xb8]
  0e0cc6b0  mov     x0, xzr
  0e0cc6b4  ldr     w24, [x8]
  0e0cc6b8  mov     s1, v0.s[1]
  0e0cc6bc  mov     s2, v0.s[2]
  0e0cc6c0  mov     s3, v0.s[3]
  0e0cc6c4  bl      #0xd70b35c  ; -> Unity.Mathematics.float4$$op_Implicit
  0e0cc6c8  cbz     x29, #0xe0cc8d0
  0e0cc6cc  mov     x0, x29
  0e0cc6d0  mov     w1, w24
  0e0cc6d4  mov     x2, xzr
  0e0cc6d8  bl      #0xd98619c  ; -> UnityEngine.MaterialPropertyBlock$$SetVector
  0e0cc6dc  ldr     x9, [x20, #0x48]
  0e0cc6e0  ldr     x8, [x25]
  0e0cc6e4  mov     x0, xzr
  0e0cc6e8  ldr     x29, [x21, #0x28]
  0e0cc6ec  add     x9, x9, x22
  0e0cc6f0  ldr     x8, [x8, #0xb8]
  0e0cc6f4  ldp     s0, s1, [x9]
  0e0cc6f8  ldp     s2, s3, [x9, #8]
  0e0cc6fc  ldr     w24, [x8, #4]
  0e0cc700  bl      #0xd70b35c  ; -> Unity.Mathematics.float4$$op_Implicit
  0e0cc704  cbz     x29, #0xe0cc8d0
  0e0cc708  mov     x0, x29
  0e0cc70c  mov     w1, w24
  0e0cc710  mov     x2, xzr
  0e0cc714  bl      #0xd98619c  ; -> UnityEngine.MaterialPropertyBlock$$SetVector
  0e0cc718  ldr     x0, [x21, #0x28]
  0e0cc71c  cbz     x0, #0xe0cc8d0
  0e0cc720  ldr     x8, [x25]
  0e0cc724  fmov    s0, s9
  0e0cc728  fmov    s1, s11
  0e0cc72c  fmov    s2, s12
  0e0cc730  fmov    s3, s10
  0e0cc734  mov     x2, xzr
  0e0cc738  ldr     x8, [x8, #0xb8]
  0e0cc73c  ldr     w1, [x8, #8]
  0e0cc740  bl      #0xd98619c  ; -> UnityEngine.MaterialPropertyBlock$$SetVector
  0e0cc744  adrp    x9, #0xea67000
  0e0cc748  ldr     x8, [x25]
  0e0cc74c  ldr     x9, [x9, #0x190]  ; META System.Math_TypeInfo
  0e0cc750  ldr     x24, [x21, #0x28]
  0e0cc754  ldr     x8, [x8, #0xb8]
  0e0cc758  ldr     x0, [x9]
  0e0cc75c  ldr     x9, [x21, #0x158]
  0e0cc760  ldr     w29, [x8, #0x10]
  0e0cc764  ldr     w10, [x0, #0xe4]
  0e0cc768  ldr     s9, [x9, x23, lsl #2]
  0e0cc76c  cbnz    w10, #0xe0cc774
  0e0cc770  bl      #0x63ceff4
  0e0cc774  cbz     x24, #0xe0cc8d0
  0e0cc778  movi    d2, #0000000000000000
  0e0cc77c  movi    d3, #0000000000000000
  0e0cc780  mov     x0, x24
  0e0cc784  fmov    s0, s9
  0e0cc788  fmov    s1, s8
  0e0cc78c  mov     w1, w29
  0e0cc790  mov     x2, xzr
  0e0cc794  bl      #0xd98619c  ; -> UnityEngine.MaterialPropertyBlock$$SetVector
  0e0cc798  ldr     x8, [x21, #0x48]
  0e0cc79c  add     x0, sp, #0x1b0
  0e0cc7a0  mov     x1, xzr
  0e0cc7a4  add     x8, x8, x23, lsl #6
  0e0cc7a8  ldp     q1, q0, [x8]
  0e0cc7ac  ldp     q2, q3, [x8, #0x20]
  0e0cc7b0  add     x8, sp, #0x1f0
  0e0cc7b4  stp     q1, q0, [sp, #0x1b0]
  0e0cc7b8  stp     q2, q3, [sp, #0x1d0]
  0e0cc7bc  stp     q1, q0, [sp, #0x230]
  0e0cc7c0  stp     q2, q3, [sp, #0x250]
  0e0cc7c4  bl      #0xd70c354  ; -> Unity.Mathematics.float4x4$$op_Implicit
  0e0cc7c8  ldr     x0, [x21, #0x28]
  0e0cc7cc  cbz     x0, #0xe0cc8d0
  0e0cc7d0  ldr     x8, [x25]
  0e0cc7d4  ldp     q0, q1, [sp, #0x1f0]
  0e0cc7d8  add     x2, sp, #0x170
  0e0cc7dc  mov     x3, xzr
  0e0cc7e0  ldr     x8, [x8, #0xb8]
  0e0cc7e4  ldr     w1, [x8, #0x14]
  0e0cc7e8  stp     q0, q1, [sp, #0x170]
  0e0cc7ec  ldp     q0, q2, [sp, #0x210]
  0e0cc7f0  stp     q0, q2, [sp, #0x190]
  0e0cc7f4  bl      #0xd9861f0  ; -> UnityEngine.MaterialPropertyBlock$$SetMatrix
  0e0cc7f8  ldp     x23, x29, [sp, #0x40]
  0e0cc7fc  cbz     x29, #0xe0cc8d0
  0e0cc800  ldr     x8, [x25]
  0e0cc804  mov     x0, x29
  0e0cc808  mov     w2, w28
  0e0cc80c  mov     x3, xzr
  0e0cc810  ldr     x8, [x8, #0xb8]
  0e0cc814  ldr     w1, [x8, #0x18]
  0e0cc818  bl      #0xda06570  ; -> UnityEngine.Rendering.CommandBuffer$$SetGlobalInt
  0e0cc81c  ldr     x8, [x20, #0x28]
  0e0cc820  add     x0, sp, #0xb0
  0e0cc824  mov     x1, xzr
  0e0cc828  add     x8, x8, x26
  0e0cc82c  ldp     q1, q0, [x8]
  0e0cc830  ldp     q2, q3, [x8, #0x20]
  0e0cc834  add     x8, sp, #0xf0
  0e0cc838  stp     q1, q0, [sp, #0xb0]
  0e0cc83c  stp     q2, q3, [sp, #0xd0]
  0e0cc840  stp     q1, q0, [sp, #0x130]
  0e0cc844  stp     q2, q3, [sp, #0x150]
  0e0cc848  bl      #0xd70c354  ; -> Unity.Mathematics.float4x4$$op_Implicit
  0e0cc84c  ldp     q0, q1, [sp, #0xf0]
  0e0cc850  add     x2, sp, #0x70
  0e0cc854  ldr     x6, [x21, #0x28]
  0e0cc858  ldr     x1, [sp, #0x50]
  0e0cc85c  mov     x0, x29
  0e0cc860  mov     x3, x23
  0e0cc864  mov     w4, wzr
  0e0cc868  mov     w5, wzr
  0e0cc86c  stp     q0, q1, [sp, #0x70]
  0e0cc870  ldp     q0, q2, [sp, #0x110]
  0e0cc874  mov     x7, xzr
  0e0cc878  stp     q0, q2, [sp, #0x90]
  0e0cc87c  bl      #0xda09a9c  ; -> UnityEngine.Rendering.CommandBuffer$$DrawMesh
  0e0cc880  subs    w27, w27, #1
  0e0cc884  add     x19, x19, #4
  0e0cc888  add     x22, x22, #0x10
  0e0cc88c  add     x26, x26, #0x40
  0e0cc890  b.ne    #0xe0cc618
  0e0cc894  ldp     x8, x9, [sp, #0x10]
  0e0cc898  add     x9, x9, #1
  0e0cc89c  cmp     x9, x8
  0e0cc8a0  b.ne    #0xe0cc5ec
  0e0cc8a4  add     sp, sp, #0x280
  0e0cc8a8  ldp     x20, x19, [sp, #0x80]
  0e0cc8ac  ldp     x22, x21, [sp, #0x70]
  0e0cc8b0  ldp     x24, x23, [sp, #0x60]
  0e0cc8b4  ldp     x26, x25, [sp, #0x50]
  0e0cc8b8  ldp     x28, x27, [sp, #0x40]
  0e0cc8bc  ldp     x29, x30, [sp, #0x30]
  0e0cc8c0  ldp     d9, d8, [sp, #0x20]
  0e0cc8c4  ldp     d11, d10, [sp, #0x10]
  0e0cc8c8  ldr     d12, [sp], #0x90
  0e0cc8cc  ret     
  0e0cc8d0  bl      #0x63cf120
  0e0cc8d4  bl      #0x63cf128

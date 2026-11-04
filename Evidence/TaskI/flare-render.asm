=== ProFlareBatchForSRPData$$RenderFlares @ 0xd1d54f8 (244 insns)
    void ProFlareBatchForSRPData__RenderFlares (ProFlareBatchForSRPData_o* __this, UnityEngine_Rendering_CommandBuffer_o* cmd, const MethodInfo* method);
  0d1d54f8  sub     sp, sp, #0x1e0
  0d1d54fc  stp     d9, d8, [sp, #0x180]
  0d1d5500  str     x29, [sp, #0x190]
  0d1d5504  stp     x30, x25, [sp, #0x1a0]
  0d1d5508  stp     x24, x23, [sp, #0x1b0]
  0d1d550c  stp     x22, x21, [sp, #0x1c0]
  0d1d5510  stp     x20, x19, [sp, #0x1d0]
  0d1d5514  adrp    x21, #0xf42c000
  0d1d5518  mov     x19, x1
  0d1d551c  mov     x20, x0
  0d1d5520  ldrb    w8, [x21, #0x94b]
  0d1d5524  add     x24, sp, #0x90
  0d1d5528  tbnz    w8, #0, #0xd1d5540
  0d1d552c  adrp    x0, #0xeb81000
  0d1d5530  ldr     x0, [x0, #0xeb8]  ; META ProFlareBatchForSRPData_TypeInfo
  0d1d5534  bl      #0x63cee78
  0d1d5538  mov     w8, #1
  0d1d553c  strb    w8, [x21, #0x94b]
  0d1d5540  movi    v0.2d, #0000000000000000
  0d1d5544  ldr     w8, [x20, #0xd8]
  0d1d5548  strb    wzr, [sp, #0x17c]
  0d1d554c  stp     xzr, xzr, [sp, #0x120]
  0d1d5550  str     wzr, [sp, #0x130]
  0d1d5554  stp     q0, q0, [sp, #0x140]
  0d1d5558  str     q0, [sp, #0x160]
  0d1d555c  stur    q0, [x24, #0xdc]
  0d1d5560  cbz     w8, #0xd1d57f0
  0d1d5564  ldr     x2, [x20, #0x18]
  0d1d5568  add     x0, sp, #0x17c
  0d1d556c  mov     x1, x19
  0d1d5570  mov     x3, xzr
  0d1d5574  add     x21, sp, #0x17c
  0d1d5578  bl      #0xd7952fc  ; -> UnityEngine.Rendering.ProfilingScope$$.ctor
  0d1d557c  ldr     x8, [x20, #0x20]
  0d1d5580  stp     xzr, x21, [sp, #0x110]
  0d1d5584  cbz     x8, #0xd1d5810
  0d1d5588  adrp    x23, #0xeb81000
  0d1d558c  ldr     x23, [x23, #0xeb8]  ; META ProFlareBatchForSRPData_TypeInfo
  0d1d5590  ldrb    w10, [x8, #0x70]
  0d1d5594  ldr     x21, [x20, #0x48]
  0d1d5598  ldr     x0, [x23]
  0d1d559c  ldr     w9, [x0, #0xe4]
  0d1d55a0  cbz     w10, #0xd1d55dc
  0d1d55a4  cbnz    w9, #0xd1d55b0
  0d1d55a8  bl      #0x63ceff4
  0d1d55ac  ldr     x0, [x23]
  0d1d55b0  ldr     x8, [x0, #0xb8]
  0d1d55b4  ldr     w22, [x8, #0x10]
  0d1d55b8  mov     x0, xzr
  0d1d55bc  bl      #0xd9b08d8  ; -> UnityEngine.Texture2D$$get_whiteTexture
  0d1d55c0  cbz     x21, #0xd1d581c
  0d1d55c4  mov     x2, x0
  0d1d55c8  mov     x0, x21
  0d1d55cc  mov     w1, w22
  0d1d55d0  mov     x3, xzr
  0d1d55d4  bl      #0xd986224  ; -> UnityEngine.MaterialPropertyBlock$$SetTexture
  0d1d55d8  b       #0xd1d5614
  0d1d55dc  cbnz    w9, #0xd1d55f0
  0d1d55e0  bl      #0x63ceff4
  0d1d55e4  ldr     x8, [x20, #0x20]
  0d1d55e8  cbz     x8, #0xd1d5830
  0d1d55ec  ldr     x0, [x23]
  0d1d55f0  ldr     x8, [x8, #0x28]
  0d1d55f4  cbz     x8, #0xd1d5828
  0d1d55f8  cbz     x21, #0xd1d582c
  0d1d55fc  ldr     x9, [x0, #0xb8]
  0d1d5600  ldr     x2, [x8, #0x20]
  0d1d5604  ldr     w1, [x9, #0x10]
  0d1d5608  mov     x0, x21
  0d1d560c  mov     x3, xzr
  0d1d5610  bl      #0xd986224  ; -> UnityEngine.MaterialPropertyBlock$$SetTexture
  0d1d5614  ldr     x0, [x20, #0x28]
  0d1d5618  cbz     x0, #0xd1d5814
  0d1d561c  mov     x1, xzr
  0d1d5620  bl      #0xd965404  ; -> UnityEngine.Camera$$get_aspect
  0d1d5624  fmov    s8, s0
  0d1d5628  fmov    s0, #-1.00000000
  0d1d562c  add     x8, sp, #0xd0
  0d1d5630  fmov    s1, #1.00000000
  0d1d5634  fmov    s2, #-1.00000000
  0d1d5638  mov     x0, xzr
  0d1d563c  fmov    s3, #1.00000000
  0d1d5640  fmov    s4, #-2.00000000
  0d1d5644  fmov    s5, #2.00000000
  0d1d5648  fmov    s9, #1.00000000
  0d1d564c  bl      #0xd9c75f0  ; -> UnityEngine.Matrix4x4$$Ortho
  0d1d5650  ldur    q0, [x24, #0x44]
  0d1d5654  ldur    q1, [x24, #0x54]
  0d1d5658  adrp    x22, #0xf400000
  0d1d565c  ldur    q2, [x24, #0x64]
  0d1d5660  ldrb    w8, [x22, #0x4f3]
  0d1d5664  stp     q0, q1, [sp, #0x140]
  0d1d5668  ldr     q0, [sp, #0x100]
  0d1d566c  str     q2, [sp, #0x160]
  0d1d5670  stur    q0, [x24, #0xdc]
  0d1d5674  cbnz    w8, #0xd1d568c
  0d1d5678  adrp    x0, #0xea6a000
  0d1d567c  ldr     x0, [x0, #0xa98]  ; META UnityEngine.Matrix4x4_TypeInfo
  0d1d5680  bl      #0x63cee78
  0d1d5684  mov     w8, #1
  0d1d5688  strb    w8, [x22, #0x4f3]
  0d1d568c  adrp    x25, #0xea6a000
  0d1d5690  ldr     x25, [x25, #0xa98]  ; META UnityEngine.Matrix4x4_TypeInfo
  0d1d5694  ldr     x8, [x25]
  0d1d5698  ldr     x8, [x8, #0xb8]
  0d1d569c  ldp     q1, q0, [x8, #0x60]
  0d1d56a0  stp     q1, q0, [sp, #0xf0]
  0d1d56a4  ldur    q0, [x24, #0x6c]
  0d1d56a8  ldr     w9, [sp, #0x10c]
  0d1d56ac  str     q0, [sp, #0x120]
  0d1d56b0  str     w9, [sp, #0x130]
  0d1d56b4  cbz     x19, #0xd1d5818
  0d1d56b8  fdiv    s0, s9, s8
  0d1d56bc  ldp     q1, q2, [x8, #0x40]
  0d1d56c0  ldur    x8, [x8, #0x60]
  0d1d56c4  ldr     q3, [sp, #0x120]
  0d1d56c8  mov     w9, #-0x40800000
  0d1d56cc  str     w9, [sp, #0xb8]
  0d1d56d0  stp     q1, q2, [sp, #0x90]
  0d1d56d4  ldur    q1, [x24, #0xdc]
  0d1d56d8  str     x8, [sp, #0xb0]
  0d1d56dc  ldr     w8, [sp, #0x130]
  0d1d56e0  str     q1, [sp, #0x80]
  0d1d56e4  ldp     q1, q2, [sp, #0x150]
  0d1d56e8  stur    q3, [x24, #0x2c]
  0d1d56ec  str     w8, [sp, #0xcc]
  0d1d56f0  stur    q2, [sp, #0x74]
  0d1d56f4  ldr     q2, [sp, #0x140]
  0d1d56f8  stur    q1, [sp, #0x64]
  0d1d56fc  stur    q2, [sp, #0x54]
  0d1d5700  str     s0, [sp, #0x50]
  0d1d5704  add     x1, sp, #0x90
  0d1d5708  add     x2, sp, #0x50
  0d1d570c  mov     x0, x19
  0d1d5710  mov     x3, xzr
  0d1d5714  bl      #0xda06e3c  ; -> UnityEngine.Rendering.CommandBuffer$$SetViewProjectionMatrices
  0d1d5718  mov     x0, xzr
  0d1d571c  bl      #0xd9ead18  ; -> UnityEngine.SystemInfo$$get_maxComputeBufferInputsVertex
  0d1d5720  cmp     w0, #2
  0d1d5724  b.lt    #0xd1d57e4
  0d1d5728  ldr     x0, [x23]
  0d1d572c  ldr     x21, [x20, #0x48]
  0d1d5730  ldr     w8, [x0, #0xe4]
  0d1d5734  cbnz    w8, #0xd1d573c
  0d1d5738  bl      #0x63ceff4
  0d1d573c  cbz     x21, #0xd1d5820
  0d1d5740  ldr     x8, [x23]
  0d1d5744  ldr     x2, [x20, #0xc8]
  0d1d5748  ldr     x8, [x8, #0xb8]
  0d1d574c  ldr     w1, [x8, #4]
  0d1d5750  mov     x0, x21
  0d1d5754  mov     x3, xzr
  0d1d5758  bl      #0xd98621c  ; -> UnityEngine.MaterialPropertyBlock$$SetBuffer
  0d1d575c  ldr     x0, [x20, #0x48]
  0d1d5760  cbz     x0, #0xd1d5824
  0d1d5764  ldr     x8, [x23]
  0d1d5768  ldr     x2, [x20, #0x68]
  0d1d576c  ldr     x8, [x8, #0xb8]
  0d1d5770  ldr     w1, [x8, #0xc]
  0d1d5774  mov     x3, xzr
  0d1d5778  bl      #0xd98621c  ; -> UnityEngine.MaterialPropertyBlock$$SetBuffer
  0d1d577c  ldrb    w8, [x22, #0x4f3]
  0d1d5780  ldr     x21, [x20, #0x50]
  0d1d5784  cbnz    w8, #0xd1d579c
  0d1d5788  adrp    x0, #0xea6a000
  0d1d578c  ldr     x0, [x0, #0xa98]  ; META UnityEngine.Matrix4x4_TypeInfo
  0d1d5790  bl      #0x63cee78
  0d1d5794  mov     w8, #1
  0d1d5798  strb    w8, [x22, #0x4f3]
  0d1d579c  ldr     x8, [x25]
  0d1d57a0  ldr     w9, [x20, #0xd8]
  0d1d57a4  ldr     x8, [x8, #0xb8]
  0d1d57a8  add     w9, w9, w9, lsl #1
  0d1d57ac  ldp     q0, q1, [x8, #0x40]
  0d1d57b0  lsl     w6, w9, #1
  0d1d57b4  stp     q0, q1, [sp, #0x10]
  0d1d57b8  ldp     q0, q2, [x8, #0x60]
  0d1d57bc  ldp     x3, x8, [x20, #0x40]
  0d1d57c0  stp     q0, q2, [sp, #0x30]
  0d1d57c4  mov     w4, wzr
  0d1d57c8  mov     w5, wzr
  0d1d57cc  add     x2, sp, #0x10
  0d1d57d0  mov     x0, x19
  0d1d57d4  mov     x1, x21
  0d1d57d8  mov     w7, #1
  0d1d57dc  stp     x8, xzr, [sp]
  0d1d57e0  bl      #0xda0a0cc  ; -> UnityEngine.Rendering.CommandBuffer$$DrawProcedural
  0d1d57e4  add     x0, sp, #0x17c
  0d1d57e8  mov     x1, xzr
  0d1d57ec  bl      #0xd795300  ; -> UnityEngine.Rendering.ProfilingScope$$Dispose
  0d1d57f0  ldp     x20, x19, [sp, #0x1d0]
  0d1d57f4  ldr     x29, [sp, #0x190]
  0d1d57f8  ldp     x22, x21, [sp, #0x1c0]
  0d1d57fc  ldp     x24, x23, [sp, #0x1b0]
  0d1d5800  ldp     x30, x25, [sp, #0x1a0]
  0d1d5804  ldp     d9, d8, [sp, #0x180]
  0d1d5808  add     sp, sp, #0x1e0
  0d1d580c  ret     
  0d1d5810  bl      #0x63cf120
  0d1d5814  bl      #0x63cf120
  0d1d5818  bl      #0x63cf120
  0d1d581c  bl      #0x63cf120
  0d1d5820  bl      #0x63cf120
  0d1d5824  bl      #0x63cf120
  0d1d5828  bl      #0x63cf120
  0d1d582c  bl      #0x63cf120
  0d1d5830  bl      #0x63cf120
  0d1d5834  b       #0xd1d5878
  0d1d5838  b       #0xd1d5878
  0d1d583c  b       #0xd1d5878
  0d1d5840  b       #0xd1d5878
  0d1d5844  b       #0xd1d5878
  0d1d5848  b       #0xd1d5878
  0d1d584c  b       #0xd1d5878
  0d1d5850  b       #0xd1d5878
  0d1d5854  b       #0xd1d5878
  0d1d5858  b       #0xd1d5878
  0d1d585c  b       #0xd1d5878
  0d1d5860  b       #0xd1d5878
  0d1d5864  b       #0xd1d5878
  0d1d5868  b       #0xd1d5878
  0d1d586c  b       #0xd1d5878
  0d1d5870  b       #0xd1d5878
  0d1d5874  b       #0xd1d5878
  0d1d5878  mov     x19, x0
  0d1d587c  cmp     w1, #1
  0d1d5880  b.ne    #0xd1d58b4
  0d1d5884  mov     x0, x19
  0d1d5888  bl      #0xe1b8390
  0d1d588c  ldr     x19, [x0]
  0d1d5890  str     x19, [sp, #0x110]
  0d1d5894  bl      #0xe1b83a0
  0d1d5898  ldr     x0, [sp, #0x118]
  0d1d589c  mov     x1, xzr
  0d1d58a0  bl      #0xd795300  ; -> UnityEngine.Rendering.ProfilingScope$$Dispose
  0d1d58a4  cbz     x19, #0xd1d57f0
  0d1d58a8  mov     x0, x19
  0d1d58ac  bl      #0x63cf118
  0d1d58b0  mov     x19, x0
  0d1d58b4  add     x0, sp, #0x110
  0d1d58b8  bl      #0x5d9c258
  0d1d58bc  mov     x0, x19
  0d1d58c0  bl      #0x64bd8dc
  0d1d58c4  bl      #0x5d96648

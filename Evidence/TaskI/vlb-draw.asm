=== VLB.VLBDrawSystem$$Execute @ 0xe0cbe70 (85 insns)
    void VLB_VLBDrawSystem__Execute (VLB_VLBDrawSystem_o* __this, UnityEngine_Rendering_CommandBuffer_o* cmd, UnityEngine_Rendering_CullingResults_o* cullResults, const MethodInfo* method);
  0e0cbe70  stp     x30, x27, [sp, #-0x50]!
  0e0cbe74  stp     x26, x25, [sp, #0x10]
  0e0cbe78  stp     x24, x23, [sp, #0x20]
  0e0cbe7c  stp     x22, x21, [sp, #0x30]
  0e0cbe80  stp     x20, x19, [sp, #0x40]
  0e0cbe84  adrp    x21, #0xf43d000
  0e0cbe88  mov     x19, x1
  0e0cbe8c  mov     x20, x0
  0e0cbe90  ldrb    w8, [x21, #0x9de]
  0e0cbe94  tbnz    w8, #0, #0xe0cbec4
  0e0cbe98  adrp    x0, #0xebd7000
  0e0cbe9c  ldr     x0, [x0, #0x170]  ; MMETH Method$System.Collections.Generic.List<VLBEntityChunk>.get_Item()
  0e0cbea0  bl      #0x63cee78
  0e0cbea4  adrp    x0, #0xebd7000
  0e0cbea8  ldr     x0, [x0, #0x178]  ; MMETH Method$System.Collections.Generic.List<VLBCachedChunk>.get_Item()
  0e0cbeac  bl      #0x63cee78
  0e0cbeb0  adrp    x0, #0xebd7000
  0e0cbeb4  ldr     x0, [x0, #0x200]  ; MMETH Method$System.Collections.Generic.List<VLBDrawCallChunk>.get_Item()
  0e0cbeb8  bl      #0x63cee78
  0e0cbebc  mov     w8, #1
  0e0cbec0  strb    w8, [x21, #0x9de]
  0e0cbec4  ldrb    w8, [x20, #0x10]
  0e0cbec8  cbz     w8, #0xe0cbfac
  0e0cbecc  ldr     x8, [x20, #0x18]
  0e0cbed0  cbz     x8, #0xe0cbfa8
  0e0cbed4  adrp    x25, #0xebd7000
  0e0cbed8  adrp    x26, #0xebd7000
  0e0cbedc  adrp    x27, #0xebd7000
  0e0cbee0  ldr     x25, [x25, #0x170]  ; MMETH Method$System.Collections.Generic.List<VLBEntityChunk>.get_Item()
  0e0cbee4  ldr     x26, [x26, #0x178]  ; MMETH Method$System.Collections.Generic.List<VLBCachedChunk>.get_Item()
  0e0cbee8  ldr     x27, [x27, #0x200]  ; MMETH Method$System.Collections.Generic.List<VLBDrawCallChunk>.get_Item()
  0e0cbeec  mov     w21, wzr
  0e0cbef0  ldr     w9, [x8, #0x38]
  0e0cbef4  cmp     w21, w9
  0e0cbef8  b.ge    #0xe0cbfac
  0e0cbefc  ldr     x0, [x8, #0x18]
  0e0cbf00  cbz     x0, #0xe0cbfa8
  0e0cbf04  ldr     x2, [x25]
  0e0cbf08  mov     w1, w21
  0e0cbf0c  bl      #0xac1b344  ; -> System.Collections.Generic.List<object>$$get_Item
  0e0cbf10  cbz     x0, #0xe0cbfa8
  0e0cbf14  ldrb    w8, [x0, #0x49]
  0e0cbf18  mov     x22, x0
  0e0cbf1c  tbnz    w8, #2, #0xe0cbf9c
  0e0cbf20  ldr     x8, [x20, #0x18]
  0e0cbf24  cbz     x8, #0xe0cbfa8
  0e0cbf28  ldr     x0, [x8, #0x20]
  0e0cbf2c  cbz     x0, #0xe0cbfa8
  0e0cbf30  ldr     x2, [x26]
  0e0cbf34  mov     w1, w21
  0e0cbf38  bl      #0xac1b344  ; -> System.Collections.Generic.List<object>$$get_Item
  0e0cbf3c  ldr     x8, [x20, #0x18]
  0e0cbf40  cbz     x8, #0xe0cbfa8
  0e0cbf44  mov     x23, x0
  0e0cbf48  ldr     x0, [x8, #0x30]
  0e0cbf4c  cbz     x0, #0xe0cbfa8
  0e0cbf50  ldr     x2, [x27]
  0e0cbf54  mov     w1, w21
  0e0cbf58  bl      #0xac1b344  ; -> System.Collections.Generic.List<object>$$get_Item
  0e0cbf5c  ldr     x8, [x20, #0x18]
  0e0cbf60  cbz     x8, #0xe0cbfa8
  0e0cbf64  mov     x24, x0
  0e0cbf68  ldr     x0, [x8, #0x18]
  0e0cbf6c  cbz     x0, #0xe0cbfa8
  0e0cbf70  ldr     x2, [x25]
  0e0cbf74  mov     w1, w21
  0e0cbf78  bl      #0xac1b344  ; -> System.Collections.Generic.List<object>$$get_Item
  0e0cbf7c  cbz     x0, #0xe0cbfa8
  0e0cbf80  ldr     w5, [x0, #0x10]
  0e0cbf84  mov     x0, x20
  0e0cbf88  mov     x1, x19
  0e0cbf8c  mov     x2, x22
  0e0cbf90  mov     x3, x23
  0e0cbf94  mov     x4, x24
  0e0cbf98  bl      #0xe0cbfc4  ; -> VLB.VLBDrawSystem$$Execute
  0e0cbf9c  ldr     x8, [x20, #0x18]
  0e0cbfa0  add     w21, w21, #1
  0e0cbfa4  cbnz    x8, #0xe0cbef0
  0e0cbfa8  bl      #0x63cf120
  0e0cbfac  ldp     x20, x19, [sp, #0x40]
  0e0cbfb0  ldp     x22, x21, [sp, #0x30]
  0e0cbfb4  ldp     x24, x23, [sp, #0x20]
  0e0cbfb8  ldp     x26, x25, [sp, #0x10]
  0e0cbfbc  ldp     x30, x27, [sp], #0x50
  0e0cbfc0  ret     
=== VLB.VLBDrawSystem$$Execute @ 0xe0cbfc4 (199 insns)
    void VLB_VLBDrawSystem__Execute (VLB_VLBDrawSystem_o* __this, UnityEngine_Rendering_CommandBuffer_o* cmd, VLB_VLBEntityChunk_o* entityChunk, VLB_VLBCachedChunk_o* cachedChunk, VLB_VLBDrawCallChunk_o* drawCallChunk, int32_t count, UnityEngine_Rendering_CullingResults_o* cullResults, const MethodInfo* method);
  0e0cbfc4  sub     sp, sp, #0x90
  0e0cbfc8  stp     x29, x30, [sp, #0x30]
  0e0cbfcc  stp     x28, x27, [sp, #0x40]
  0e0cbfd0  stp     x26, x25, [sp, #0x50]
  0e0cbfd4  stp     x24, x23, [sp, #0x60]
  0e0cbfd8  stp     x22, x21, [sp, #0x70]
  0e0cbfdc  stp     x20, x19, [sp, #0x80]
  0e0cbfe0  adrp    x25, #0xf43d000
  0e0cbfe4  mov     w24, w5
  0e0cbfe8  mov     x19, x4
  0e0cbfec  ldrb    w8, [x25, #0x9e0]
  0e0cbff0  mov     x20, x3
  0e0cbff4  mov     x23, x2
  0e0cbff8  mov     x21, x1
  0e0cbffc  mov     x22, x0
  0e0cc000  tbnz    w8, #0, #0xe0cc054
  0e0cc004  adrp    x0, #0xebc6000
  0e0cc008  ldr     x0, [x0, #0x370]  ; MMETH Method$Unity.Collections.NativeArray<Vector4>.Copy()
  0e0cc00c  bl      #0x63cee78
  0e0cc010  adrp    x0, #0xeba3000
  0e0cc014  ldr     x0, [x0, #0xdc0]  ; MMETH Method$Unity.Collections.NativeArray<Matrix4x4>.Copy()
  0e0cc018  bl      #0x63cee78
  0e0cc01c  adrp    x0, #0xeba3000
  0e0cc020  ldr     x0, [x0, #0xdd0]  ; MMETH Method$Unity.Collections.NativeArray<float4x4>.Reinterpret<Matrix4x4>()
  0e0cc024  bl      #0x63cee78
  0e0cc028  adrp    x0, #0xebc6000
  0e0cc02c  ldr     x0, [x0, #0x378]  ; MMETH Method$Unity.Collections.NativeArray<float4>.Reinterpret<Vector4>()
  0e0cc030  bl      #0x63cee78
  0e0cc034  adrp    x0, #0xea65000
  0e0cc038  ldr     x0, [x0, #0x718]  ; META UnityEngine.Object_TypeInfo
  0e0cc03c  bl      #0x63cee78
  0e0cc040  adrp    x0, #0xebd7000
  0e0cc044  ldr     x0, [x0, #0x220]  ; META VLB.VLBDrawSystem_TypeInfo
  0e0cc048  bl      #0x63cee78
  0e0cc04c  mov     w8, #1
  0e0cc050  strb    w8, [x25, #0x9e0]
  0e0cc054  stp     xzr, xzr, [sp, #0x20]
  0e0cc058  cbz     x20, #0xe0cc2dc
  0e0cc05c  ldur    q0, [x20, #0x18]
  0e0cc060  add     x0, sp, #0x20
  0e0cc064  mov     x1, xzr
  0e0cc068  str     q0, [sp, #0x20]
  0e0cc06c  bl      #0xd958af0  ; -> Unity.Jobs.JobHandle$$Complete
  0e0cc070  cbz     x19, #0xe0cc2dc
  0e0cc074  ldur    q0, [x19, #0x18]
  0e0cc078  add     x0, sp, #0x20
  0e0cc07c  mov     x1, xzr
  0e0cc080  str     q0, [sp, #0x20]
  0e0cc084  bl      #0xd958af0  ; -> Unity.Jobs.JobHandle$$Complete
  0e0cc088  cbz     x23, #0xe0cc2dc
  0e0cc08c  cbz     w24, #0xe0cc2bc
  0e0cc090  adrp    x8, #0xea65000
  0e0cc094  ldr     x8, [x8, #0x718]  ; META UnityEngine.Object_TypeInfo
  0e0cc098  ldr     x27, [x23, #0x50]
  0e0cc09c  ldr     x0, [x8]
  0e0cc0a0  ldr     w8, [x0, #0xe4]
  0e0cc0a4  cbnz    w8, #0xe0cc0ac
  0e0cc0a8  bl      #0x63ceff4
  0e0cc0ac  mov     x0, x27
  0e0cc0b0  mov     x1, xzr
  0e0cc0b4  mov     x2, xzr
  0e0cc0b8  bl      #0xd9de99c  ; -> UnityEngine.Object$$op_Equality
  0e0cc0bc  tbnz    w0, #0, #0xe0cc2bc
  0e0cc0c0  cbz     x27, #0xe0cc2dc
  0e0cc0c4  mov     x0, x27
  0e0cc0c8  mov     x1, xzr
  0e0cc0cc  bl      #0xd97f634  ; -> UnityEngine.Material$$get_enableInstancing
  0e0cc0d0  tbz     w0, #0, #0xe0cc2bc
  0e0cc0d4  mov     x0, xzr
  0e0cc0d8  bl      #0xe0ddc68  ; -> VLB.GlobalMeshSD$$Get
  0e0cc0dc  ldr     x8, [x19, #0x88]
  0e0cc0e0  str     x0, [sp, #0x18]
  0e0cc0e4  ldr     w8, [x8]
  0e0cc0e8  cmp     w8, #1
  0e0cc0ec  b.lt    #0xe0cc2bc
  0e0cc0f0  lsl     x8, x8, #3
  0e0cc0f4  adrp    x28, #0xeba3000
  0e0cc0f8  adrp    x23, #0xebc6000
  0e0cc0fc  mov     x29, xzr
  0e0cc100  stp     x8, x21, [sp, #8]
  0e0cc104  ldr     x28, [x28, #0xdd0]  ; MMETH Method$Unity.Collections.NativeArray<float4x4>.Reinterpret<Matrix4x4>()
  0e0cc108  ldr     x23, [x23, #0x378]  ; MMETH Method$Unity.Collections.NativeArray<float4>.Reinterpret<Vector4>()
  0e0cc10c  ldr     x8, [x19, #0x78]
  0e0cc110  ldr     x1, [x28]
  0e0cc114  add     x0, x19, #0x28
  0e0cc118  add     x8, x8, x29
  0e0cc11c  ldp     w26, w25, [x8]
  0e0cc120  bl      #0x8b81e38  ; -> Unity.Collections.NativeArray<float4x4>$$Reinterpret<Matrix4x4>
  0e0cc124  adrp    x21, #0xeba3000
  0e0cc128  ldr     x3, [x22, #0x20]
  0e0cc12c  sub     w25, w25, w26
  0e0cc130  ldr     x21, [x21, #0xdc0]  ; MMETH Method$Unity.Collections.NativeArray<Matrix4x4>.Copy()
  0e0cc134  mov     w2, w26
  0e0cc138  mov     w4, wzr
  0e0cc13c  mov     w5, w25
  0e0cc140  ldr     x6, [x21]
  0e0cc144  bl      #0xb2dd2d4  ; -> Unity.Collections.NativeArray<Matrix4x4>$$Copy
  0e0cc148  ldr     x1, [x23]
  0e0cc14c  add     x0, x19, #0x38
  0e0cc150  bl      #0x8b81d64  ; -> Unity.Collections.NativeArray<float4>$$Reinterpret<Vector4>
  0e0cc154  adrp    x24, #0xebc6000
  0e0cc158  ldr     x3, [x22, #0x28]
  0e0cc15c  mov     w2, w26
  0e0cc160  ldr     x24, [x24, #0x370]  ; MMETH Method$Unity.Collections.NativeArray<Vector4>.Copy()
  0e0cc164  mov     w4, wzr
  0e0cc168  mov     w5, w25
  0e0cc16c  ldr     x6, [x24]
  0e0cc170  bl      #0xb3012cc  ; -> Unity.Collections.NativeArray<Vector4>$$Copy
  0e0cc174  ldr     x1, [x23]
  0e0cc178  add     x0, x19, #0x48
  0e0cc17c  bl      #0x8b81d64  ; -> Unity.Collections.NativeArray<float4>$$Reinterpret<Vector4>
  0e0cc180  ldr     x3, [x22, #0x30]
  0e0cc184  ldr     x6, [x24]
  0e0cc188  mov     w2, w26
  0e0cc18c  mov     w4, wzr
  0e0cc190  mov     w5, w25
  0e0cc194  bl      #0xb3012cc  ; -> Unity.Collections.NativeArray<Vector4>$$Copy
  0e0cc198  ldr     x1, [x28]
  0e0cc19c  add     x0, x19, #0x58
  0e0cc1a0  bl      #0x8b81e38  ; -> Unity.Collections.NativeArray<float4x4>$$Reinterpret<Matrix4x4>
  0e0cc1a4  ldr     x3, [x22, #0x38]
  0e0cc1a8  ldr     x6, [x21]
  0e0cc1ac  mov     w2, w26
  0e0cc1b0  mov     w4, wzr
  0e0cc1b4  mov     w5, w25
  0e0cc1b8  bl      #0xb2dd2d4  ; -> Unity.Collections.NativeArray<Matrix4x4>$$Copy
  0e0cc1bc  ldr     x1, [x28]
  0e0cc1c0  add     x0, x19, #0x68
  0e0cc1c4  bl      #0x8b81e38  ; -> Unity.Collections.NativeArray<float4x4>$$Reinterpret<Matrix4x4>
  0e0cc1c8  ldr     x3, [x22, #0x40]
  0e0cc1cc  ldr     x6, [x21]
  0e0cc1d0  mov     w2, w26
  0e0cc1d4  mov     w4, wzr
  0e0cc1d8  mov     w5, w25
  0e0cc1dc  bl      #0xb2dd2d4  ; -> Unity.Collections.NativeArray<Matrix4x4>$$Copy
  0e0cc1e0  adrp    x24, #0xebd7000
  0e0cc1e4  ldr     x24, [x24, #0x220]  ; META VLB.VLBDrawSystem_TypeInfo
  0e0cc1e8  ldr     x26, [x20, #0x28]
  0e0cc1ec  ldr     x0, [x24]
  0e0cc1f0  ldr     w8, [x0, #0xe4]
  0e0cc1f4  cbnz    w8, #0xe0cc1fc
  0e0cc1f8  bl      #0x63ceff4
  0e0cc1fc  cbz     x26, #0xe0cc2dc
  0e0cc200  ldr     x8, [x24]
  0e0cc204  ldr     x2, [x22, #0x28]
  0e0cc208  mov     x0, x26
  0e0cc20c  mov     x3, xzr
  0e0cc210  ldr     x8, [x8, #0xb8]
  0e0cc214  ldr     w1, [x8]
  0e0cc218  bl      #0xd986278  ; -> UnityEngine.MaterialPropertyBlock$$SetVectorArray
  0e0cc21c  ldr     x0, [x20, #0x28]
  0e0cc220  cbz     x0, #0xe0cc2dc
  0e0cc224  ldr     x8, [x24]
  0e0cc228  ldr     x2, [x22, #0x30]
  0e0cc22c  mov     x3, xzr
  0e0cc230  ldr     x8, [x8, #0xb8]
  0e0cc234  ldr     w1, [x8, #4]
  0e0cc238  bl      #0xd986278  ; -> UnityEngine.MaterialPropertyBlock$$SetVectorArray
  0e0cc23c  ldr     x0, [x20, #0x28]
  0e0cc240  cbz     x0, #0xe0cc2dc
  0e0cc244  ldr     x8, [x24]
  0e0cc248  ldr     x2, [x22, #0x38]
  0e0cc24c  mov     x3, xzr
  0e0cc250  ldr     x8, [x8, #0xb8]
  0e0cc254  ldr     w1, [x8, #8]
  0e0cc258  bl      #0xd9862c8  ; -> UnityEngine.MaterialPropertyBlock$$SetMatrixArray
  0e0cc25c  ldr     x0, [x20, #0x28]
  0e0cc260  ldr     x21, [sp, #0x10]
  0e0cc264  cbz     x0, #0xe0cc2dc
  0e0cc268  ldr     x8, [x24]
  0e0cc26c  ldr     x2, [x22, #0x40]
  0e0cc270  mov     x3, xzr
  0e0cc274  ldr     x8, [x8, #0xb8]
  0e0cc278  ldr     w1, [x8, #0xc]
  0e0cc27c  bl      #0xd9862c8  ; -> UnityEngine.MaterialPropertyBlock$$SetMatrixArray
  0e0cc280  cbz     x21, #0xe0cc2dc
  0e0cc284  ldr     x7, [x20, #0x28]
  0e0cc288  ldr     x5, [x22, #0x20]
  0e0cc28c  mov     x0, x21
  0e0cc290  ldr     x1, [sp, #0x18]
  0e0cc294  mov     w2, wzr
  0e0cc298  mov     x3, x27
  0e0cc29c  mov     w4, wzr
  0e0cc2a0  mov     w6, w25
  0e0cc2a4  add     x29, x29, #8
  0e0cc2a8  str     xzr, [sp]
  0e0cc2ac  bl      #0xda0a214  ; -> UnityEngine.Rendering.CommandBuffer$$DrawMeshInstanced
  0e0cc2b0  ldr     x8, [sp, #8]
  0e0cc2b4  cmp     x8, x29
  0e0cc2b8  b.ne    #0xe0cc10c
  0e0cc2bc  ldp     x20, x19, [sp, #0x80]
  0e0cc2c0  ldp     x22, x21, [sp, #0x70]
  0e0cc2c4  ldp     x24, x23, [sp, #0x60]
  0e0cc2c8  ldp     x26, x25, [sp, #0x50]
  0e0cc2cc  ldp     x28, x27, [sp, #0x40]
  0e0cc2d0  ldp     x29, x30, [sp, #0x30]
  0e0cc2d4  add     sp, sp, #0x90
  0e0cc2d8  ret     
  0e0cc2dc  bl      #0x63cf120

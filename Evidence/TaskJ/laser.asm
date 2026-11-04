=== Campus.Live.Equipment.Environment.LiveLaser$$OnEnable @ 0xddb663c (381 insns)
    void Campus_Live_Equipment_Environment_LiveLaser__OnEnable (Campus_Live_Equipment_Environment_LiveLaser_o* __this, const MethodInfo* method);
  0ddb663c  sub     sp, sp, #0xb0
  0ddb6640  str     x30, [sp, #0x60]
  0ddb6644  stp     x26, x25, [sp, #0x70]
  0ddb6648  stp     x24, x23, [sp, #0x80]
  0ddb664c  stp     x22, x21, [sp, #0x90]
  0ddb6650  stp     x20, x19, [sp, #0xa0]
  0ddb6654  adrp    x20, #0xf43b000
  0ddb6658  adrp    x21, #0xeb68000
  0ddb665c  adrp    x22, #0xebc6000
  0ddb6660  ldrb    w8, [x20, #0xc73]
  0ddb6664  ldr     x21, [x21, #0x8a0]  ; META UnityEngine.Mesh_TypeInfo
  0ddb6668  ldr     x22, [x22, #0x180]  ; STR "LaserMesh_"
  0ddb666c  mov     x19, x0
  0ddb6670  tbnz    w8, #0, #0xddb6718
  0ddb6674  adrp    x0, #0xebc6000
  0ddb6678  ldr     x0, [x0, #0x188]  ; MMETH Method$UnityEngine.Component.TryGetComponent<MeshFilter>()
  0ddb667c  bl      #0x63cee78
  0ddb6680  adrp    x0, #0xea67000
  0ddb6684  ldr     x0, [x0, #0x3c0]  ; META UnityEngine.Debug_TypeInfo
  0ddb6688  bl      #0x63cee78
  0ddb668c  adrp    x0, #0xeb74000
  0ddb6690  ldr     x0, [x0, #0x878]  ; MMETH Method$UnityEngine.GameObject.AddComponent<MeshFilter>()
  0ddb6694  bl      #0x63cee78
  0ddb6698  adrp    x0, #0xebc4000
  0ddb669c  ldr     x0, [x0, #0xa10]  ; MMETH Method$UnityEngine.Mesh.SetIndexBufferData<ushort>()
  0ddb66a0  bl      #0x63cee78
  0ddb66a4  adrp    x0, #0xebc6000
  0ddb66a8  ldr     x0, [x0, #0x190]  ; MMETH Method$UnityEngine.Mesh.SetVertexBufferData<LiveLaser.VertexLayout>()
  0ddb66ac  bl      #0x63cee78
  0ddb66b0  adrp    x0, #0xeb68000
  0ddb66b4  ldr     x0, [x0, #0x8a0]  ; META UnityEngine.Mesh_TypeInfo
  0ddb66b8  bl      #0x63cee78
  0ddb66bc  adrp    x0, #0xeba7000
  0ddb66c0  ldr     x0, [x0, #0x8e8]  ; MMETH Method$Unity.Collections.NativeArray<ushort>..ctor()
  0ddb66c4  bl      #0x63cee78
  0ddb66c8  adrp    x0, #0xebc6000
  0ddb66cc  ldr     x0, [x0, #0x198]  ; MMETH Method$Unity.Collections.NativeArray<LiveLaser.VertexLayout>..ctor()
  0ddb66d0  bl      #0x63cee78
  0ddb66d4  adrp    x0, #0xea65000
  0ddb66d8  ldr     x0, [x0, #0x718]  ; META UnityEngine.Object_TypeInfo
  0ddb66dc  bl      #0x63cee78
  0ddb66e0  adrp    x0, #0xebac000
  0ddb66e4  ldr     x0, [x0, #0xf88]  ; META UnityEngine.Rendering.VertexAttributeDescriptor[]_TypeInfo
  0ddb66e8  bl      #0x63cee78
  0ddb66ec  adrp    x0, #0xebc6000
  0ddb66f0  ldr     x0, [x0, #0x180]  ; STR "LaserMesh_"
  0ddb66f4  bl      #0x63cee78
  0ddb66f8  adrp    x0, #0xebc6000
  0ddb66fc  ldr     x0, [x0, #0x1a0]  ; STR "Laser用のRendererが指定されていません"
  0ddb6700  bl      #0x63cee78
  0ddb6704  adrp    x0, #0xebc6000
  0ddb6708  ldr     x0, [x0, #0x1a8]  ; STR "Materialを指定してください"
  0ddb670c  bl      #0x63cee78
  0ddb6710  mov     w8, #1
  0ddb6714  strb    w8, [x20, #0xc73]
  0ddb6718  ldr     x0, [x21]
  0ddb671c  bl      #0x63cf110
  0ddb6720  mov     x1, xzr
  0ddb6724  mov     x21, x0
  0ddb6728  bl      #0xd9a0470  ; -> UnityEngine.Mesh$$.ctor
  0ddb672c  mov     x20, x19
  0ddb6730  mov     x1, x21
  0ddb6734  str     x21, [x20, #0x78]!
  0ddb6738  mov     x0, x20
  0ddb673c  bl      #0x63cee24
  0ddb6740  ldr     x21, [x20]
  0ddb6744  mov     x0, x19
  0ddb6748  mov     x1, xzr
  0ddb674c  bl      #0xd9e278c  ; -> UnityEngine.Object$$get_name
  0ddb6750  ldr     x8, [x22]
  0ddb6754  mov     x1, x0
  0ddb6758  mov     x2, xzr
  0ddb675c  mov     x0, x8
  0ddb6760  bl      #0xde502c0  ; -> System.String$$Concat
  0ddb6764  cbz     x21, #0xddb6c28
  0ddb6768  mov     x1, x0
  0ddb676c  mov     x0, x21
  0ddb6770  mov     x2, xzr
  0ddb6774  bl      #0xd9e28e0  ; -> UnityEngine.Object$$set_name
  0ddb6778  ldr     x0, [x20]
  0ddb677c  cbz     x0, #0xddb6c28
  0ddb6780  adrp    x21, #0xebac000
  0ddb6784  mov     w1, #0x34
  0ddb6788  mov     x2, xzr
  0ddb678c  ldr     x21, [x21, #0xf88]  ; META UnityEngine.Rendering.VertexAttributeDescriptor[]_TypeInfo
  0ddb6790  bl      #0xd9e3d80  ; -> UnityEngine.Object$$set_hideFlags
  0ddb6794  ldr     x0, [x21]
  0ddb6798  mov     w1, #4
  0ddb679c  bl      #0x63cef64
  0ddb67a0  mov     x21, x0
  0ddb67a4  add     x0, sp, #0x50
  0ddb67a8  mov     w1, wzr
  0ddb67ac  mov     w2, wzr
  0ddb67b0  mov     w3, #3
  0ddb67b4  mov     w4, wzr
  0ddb67b8  mov     x5, xzr
  0ddb67bc  stp     xzr, xzr, [sp, #0x50]
  0ddb67c0  bl      #0xda01dac  ; -> UnityEngine.Rendering.VertexAttributeDescriptor$$.ctor
  0ddb67c4  cbz     x21, #0xddb6c28
  0ddb67c8  ldr     w8, [x21, #0x18]
  0ddb67cc  cbz     w8, #0xddb6c2c
  0ddb67d0  ldr     q0, [sp, #0x50]
  0ddb67d4  add     x0, sp, #0x40
  0ddb67d8  mov     w1, #3
  0ddb67dc  mov     w2, wzr
  0ddb67e0  mov     w3, #4
  0ddb67e4  mov     w4, wzr
  0ddb67e8  mov     x5, xzr
  0ddb67ec  str     q0, [x21, #0x20]
  0ddb67f0  stp     xzr, xzr, [sp, #0x40]
  0ddb67f4  bl      #0xda01dac  ; -> UnityEngine.Rendering.VertexAttributeDescriptor$$.ctor
  0ddb67f8  ldr     w8, [x21, #0x18]
  0ddb67fc  tst     w8, #0xfffffffe
  0ddb6800  b.eq    #0xddb6c2c
  0ddb6804  ldr     q0, [sp, #0x40]
  0ddb6808  add     x0, sp, #0x30
  0ddb680c  mov     w1, #4
  0ddb6810  mov     w2, wzr
  0ddb6814  mov     w3, #2
  0ddb6818  mov     w4, wzr
  0ddb681c  mov     x5, xzr
  0ddb6820  str     q0, [x21, #0x30]
  0ddb6824  stp     xzr, xzr, [sp, #0x30]
  0ddb6828  bl      #0xda01dac  ; -> UnityEngine.Rendering.VertexAttributeDescriptor$$.ctor
  0ddb682c  ldr     w8, [x21, #0x18]
  0ddb6830  cmp     w8, #2
  0ddb6834  b.ls    #0xddb6c2c
  0ddb6838  ldr     q0, [sp, #0x30]
  0ddb683c  add     x0, sp, #0x20
  0ddb6840  mov     w1, #5
  0ddb6844  mov     w2, wzr
  0ddb6848  mov     w3, #2
  0ddb684c  mov     w4, wzr
  0ddb6850  mov     x5, xzr
  0ddb6854  str     q0, [x21, #0x40]
  0ddb6858  stp     xzr, xzr, [sp, #0x20]
  0ddb685c  bl      #0xda01dac  ; -> UnityEngine.Rendering.VertexAttributeDescriptor$$.ctor
  0ddb6860  ldr     w8, [x21, #0x18]
  0ddb6864  tst     w8, #0xfffffffc
  0ddb6868  b.eq    #0xddb6c2c
  0ddb686c  ldr     q0, [sp, #0x20]
  0ddb6870  str     q0, [x21, #0x50]
  0ddb6874  ldr     x0, [x20]
  0ddb6878  cbz     x0, #0xddb6c28
  0ddb687c  adrp    x26, #0xebc6000
  0ddb6880  adrp    x25, #0xebc6000
  0ddb6884  adrp    x24, #0xeba7000
  0ddb6888  adrp    x23, #0xebc4000
  0ddb688c  adrp    x22, #0xea65000
  0ddb6890  ldr     x26, [x26, #0x198]  ; MMETH Method$Unity.Collections.NativeArray<LiveLaser.VertexLayout>..ctor()
  0ddb6894  ldr     x25, [x25, #0x190]  ; MMETH Method$UnityEngine.Mesh.SetVertexBufferData<LiveLaser.VertexLayout>()
  0ddb6898  ldr     x24, [x24, #0x8e8]  ; MMETH Method$Unity.Collections.NativeArray<ushort>..ctor()
  0ddb689c  ldr     x23, [x23, #0xa10]  ; MMETH Method$UnityEngine.Mesh.SetIndexBufferData<ushort>()
  0ddb68a0  ldr     x22, [x22, #0x718]  ; META UnityEngine.Object_TypeInfo
  0ddb68a4  mov     w1, #0xf0
  0ddb68a8  mov     x2, x21
  0ddb68ac  mov     x3, xzr
  0ddb68b0  bl      #0xd9a9370  ; -> UnityEngine.Mesh$$SetVertexBufferParams
  0ddb68b4  ldr     x4, [x26]
  0ddb68b8  add     x0, sp, #0x10
  0ddb68bc  mov     w1, #0xf0
  0ddb68c0  mov     w2, #4
  0ddb68c4  mov     w3, wzr
  0ddb68c8  stp     xzr, xzr, [sp, #0x10]
  0ddb68cc  bl      #0xb318f14  ; -> Unity.Collections.NativeArray<LiveLaser.VertexLayout>$$.ctor
  0ddb68d0  fmov    s0, #-0.50000000
  0ddb68d4  adrp    x10, #0x276e000
  0ddb68d8  adrp    x11, #0x276e000
  0ddb68dc  fmov    s1, #0.75000000
  0ddb68e0  ldr     q4, [sp, #0x10]
  0ddb68e4  ldr     s2, [x10, #0x3f8]
  0ddb68e8  ldr     s3, [x11, #0xb48]
  0ddb68ec  mov     w10, #0xaaab
  0ddb68f0  mov     x8, xzr
  0ddb68f4  mov     x9, xzr
  0ddb68f8  movk    w10, #0xaaaa, lsl #16
  0ddb68fc  stur    q4, [x19, #0x88]
  0ddb6900  scvtf   s4, w9, #4
  0ddb6904  mov     w11, wzr
  0ddb6908  mov     x12, xzr
  0ddb690c  umull   x13, w11, w10
  0ddb6910  ldur    x15, [x19, #0x88]
  0ddb6914  add     x16, x8, x12
  0ddb6918  add     x12, x12, #0x2c
  0ddb691c  add     x15, x15, x16
  0ddb6920  cmp     x12, #0x294
  0ddb6924  lsr     x13, x13, #0x21
  0ddb6928  str     wzr, [x15, #4]
  0ddb692c  stur    xzr, [x15, #0x14]
  0ddb6930  add     w14, w13, w13, lsl #1
  0ddb6934  scvtf   s7, w13, #2
  0ddb6938  stur    xzr, [x15, #0xc]
  0ddb693c  sub     w14, w11, w14
  0ddb6940  add     w11, w11, #1
  0ddb6944  scvtf   s5, w14
  0ddb6948  scvtf   s6, w14, #1
  0ddb694c  scvtf   s16, w14, #5
  0ddb6950  str     s7, [x15, #8]
  0ddb6954  fmul    s5, s5, s2
  0ddb6958  fadd    s6, s6, s0
  0ddb695c  fadd    s16, s4, s16
  0ddb6960  fadd    s5, s5, s3
  0ddb6964  str     s6, [x15]
  0ddb6968  stp     s16, s7, [x15, #0x24]
  0ddb696c  fadd    s5, s5, s1
  0ddb6970  stp     s5, s7, [x15, #0x1c]
  0ddb6974  b.ne    #0xddb690c
  0ddb6978  add     x9, x9, #1
  0ddb697c  add     x8, x8, #0x294
  0ddb6980  cmp     x9, #0x10
  0ddb6984  b.ne    #0xddb6900
  0ddb6988  ldr     x0, [x20]
  0ddb698c  cbz     x0, #0xddb6c28
  0ddb6990  ldp     x1, x2, [x19, #0x88]
  0ddb6994  mov     w3, wzr
  0ddb6998  ldr     x8, [x25]
  0ddb699c  mov     w4, wzr
  0ddb69a0  mov     w5, #0xf0
  0ddb69a4  mov     w6, wzr
  0ddb69a8  mov     w7, wzr
  0ddb69ac  str     x8, [sp]
  0ddb69b0  bl      #0x92749a8  ; -> UnityEngine.Mesh$$SetVertexBufferData<LiveLaser.VertexLayout>
  0ddb69b4  ldr     x4, [x24]
  0ddb69b8  add     x0, sp, #0x50
  0ddb69bc  mov     w1, #0x300
  0ddb69c0  mov     w2, #4
  0ddb69c4  mov     w3, wzr
  0ddb69c8  stp     xzr, xzr, [sp, #0x50]
  0ddb69cc  bl      #0xb2fb244  ; -> Unity.Collections.NativeArray<ushort>$$.ctor
  0ddb69d0  ldr     q0, [sp, #0x50]
  0ddb69d4  mov     w8, wzr
  0ddb69d8  mov     w10, wzr
  0ddb69dc  stur    q0, [x19, #0x98]
  0ddb69e0  ldr     x9, [x19, #0x98]
  0ddb69e4  lsl     w12, w10, #4
  0ddb69e8  mov     w11, wzr
  0ddb69ec  sub     w12, w12, w10
  0ddb69f0  add     w13, w11, w11, lsl #1
  0ddb69f4  mov     w14, #1
  0ddb69f8  add     w13, w13, w12
  0ddb69fc  mov     w0, w14
  0ddb6a00  add     w14, w8, #4
  0ddb6a04  add     w15, w13, #3
  0ddb6a08  add     w16, w8, #1
  0ddb6a0c  add     w17, w8, #2
  0ddb6a10  strh    w15, [x9, w14, sxtw #1]
  0ddb6a14  add     w14, w8, #5
  0ddb6a18  strh    w13, [x9, w8, sxtw #1]
  0ddb6a1c  strh    w15, [x9, w16, sxtw #1]
  0ddb6a20  add     w16, w13, #4
  0ddb6a24  add     w13, w13, #1
  0ddb6a28  strh    w13, [x9, w17, sxtw #1]
  0ddb6a2c  add     w17, w8, #3
  0ddb6a30  add     w8, w8, #6
  0ddb6a34  strh    w16, [x9, w14, sxtw #1]
  0ddb6a38  mov     w14, wzr
  0ddb6a3c  strh    w13, [x9, w17, sxtw #1]
  0ddb6a40  tbnz    w0, #0, #0xddb69fc
  0ddb6a44  add     w11, w11, #1
  0ddb6a48  cmp     w11, #4
  0ddb6a4c  b.ne    #0xddb69f0
  0ddb6a50  add     w10, w10, #1
  0ddb6a54  cmp     w10, #0x10
  0ddb6a58  b.ne    #0xddb69e4
  0ddb6a5c  ldr     x0, [x20]
  0ddb6a60  cbz     x0, #0xddb6c28
  0ddb6a64  mov     w1, #0x300
  0ddb6a68  mov     w2, wzr
  0ddb6a6c  mov     x3, xzr
  0ddb6a70  bl      #0xd9a07c4  ; -> UnityEngine.Mesh$$SetIndexBufferParams
  0ddb6a74  ldr     x0, [x20]
  0ddb6a78  cbz     x0, #0xddb6c28
  0ddb6a7c  ldp     x1, x2, [x19, #0x98]
  0ddb6a80  mov     w3, wzr
  0ddb6a84  ldr     x7, [x23]
  0ddb6a88  mov     w4, wzr
  0ddb6a8c  mov     w5, #0x300
  0ddb6a90  mov     w6, wzr
  0ddb6a94  bl      #0x927218c  ; -> UnityEngine.Mesh$$SetIndexBufferData<ushort>
  0ddb6a98  ldr     x0, [x19, #0x78]
  0ddb6a9c  cbz     x0, #0xddb6c28
  0ddb6aa0  mov     w1, #1
  0ddb6aa4  mov     x2, xzr
  0ddb6aa8  bl      #0xd9a5c0c  ; -> UnityEngine.Mesh$$set_subMeshCount
  0ddb6aac  ldr     x0, [x20]
  0ddb6ab0  cbz     x0, #0xddb6c28
  0ddb6ab4  mov     x1, xzr
  0ddb6ab8  bl      #0xd9acf68  ; -> UnityEngine.Mesh$$MarkDynamic
  0ddb6abc  ldr     x0, [x22]
  0ddb6ac0  ldr     x21, [x19, #0x30]
  0ddb6ac4  ldr     w8, [x0, #0xe4]
  0ddb6ac8  cbnz    w8, #0xddb6ad0
  0ddb6acc  bl      #0x63ceff4
  0ddb6ad0  mov     x0, x21
  0ddb6ad4  mov     x1, xzr
  0ddb6ad8  mov     x2, xzr
  0ddb6adc  bl      #0xd9db6c4  ; -> UnityEngine.Object$$op_Inequality
  0ddb6ae0  tbz     w0, #0, #0xddb6be0
  0ddb6ae4  ldr     x0, [x19, #0x30]
  0ddb6ae8  cbz     x0, #0xddb6c28
  0ddb6aec  mov     w1, wzr
  0ddb6af0  mov     x2, xzr
  0ddb6af4  bl      #0xd9872ec  ; -> UnityEngine.Renderer$$set_shadowCastingMode
  0ddb6af8  ldr     x0, [x19, #0x30]
  0ddb6afc  cbz     x0, #0xddb6c28
  0ddb6b00  mov     w1, wzr
  0ddb6b04  mov     x2, xzr
  0ddb6b08  bl      #0xd987474  ; -> UnityEngine.Renderer$$set_lightProbeUsage
  0ddb6b0c  ldr     x0, [x19, #0x30]
  0ddb6b10  cbz     x0, #0xddb6c28
  0ddb6b14  mov     x1, xzr
  0ddb6b18  bl      #0xd987efc  ; -> UnityEngine.Renderer$$get_sharedMaterial
  0ddb6b1c  ldr     x8, [x22]
  0ddb6b20  mov     x21, x0
  0ddb6b24  ldr     w9, [x8, #0xe4]
  0ddb6b28  cbnz    w9, #0xddb6b34
  0ddb6b2c  mov     x0, x8
  0ddb6b30  bl      #0x63ceff4
  0ddb6b34  mov     x0, x21
  0ddb6b38  mov     x1, xzr
  0ddb6b3c  mov     x2, xzr
  0ddb6b40  bl      #0xd9de99c  ; -> UnityEngine.Object$$op_Equality
  0ddb6b44  tbz     w0, #0, #0xddb6b74
  0ddb6b48  adrp    x8, #0xea67000
  0ddb6b4c  ldr     x8, [x8, #0x3c0]  ; META UnityEngine.Debug_TypeInfo
  0ddb6b50  ldr     x0, [x8]
  0ddb6b54  ldr     w8, [x0, #0xe4]
  0ddb6b58  cbnz    w8, #0xddb6b60
  0ddb6b5c  bl      #0x63ceff4
  0ddb6b60  adrp    x8, #0xebc6000
  0ddb6b64  mov     x1, xzr
  0ddb6b68  ldr     x8, [x8, #0x1a8]  ; STR "Materialを指定してください"
  0ddb6b6c  ldr     x0, [x8]
  0ddb6b70  bl      #0xd973858  ; -> UnityEngine.Debug$$LogError
  0ddb6b74  ldr     x0, [x19, #0x30]
  0ddb6b78  cbz     x0, #0xddb6c28
  0ddb6b7c  adrp    x8, #0xebc6000
  0ddb6b80  add     x1, x19, #0x80
  0ddb6b84  ldr     x8, [x8, #0x188]  ; MMETH Method$UnityEngine.Component.TryGetComponent<MeshFilter>()
  0ddb6b88  ldr     x2, [x8]
  0ddb6b8c  bl      #0x90b50fc  ; -> UnityEngine.Component$$TryGetComponent<object>
  0ddb6b90  tbnz    w0, #0, #0xddb6bc8
  0ddb6b94  ldr     x0, [x19, #0x30]
  0ddb6b98  cbz     x0, #0xddb6c28
  0ddb6b9c  mov     x1, xzr
  0ddb6ba0  bl      #0xd9d7914  ; -> UnityEngine.Component$$get_gameObject
  0ddb6ba4  cbz     x0, #0xddb6c28
  0ddb6ba8  adrp    x8, #0xeb74000
  0ddb6bac  ldr     x8, [x8, #0x878]  ; MMETH Method$UnityEngine.GameObject.AddComponent<MeshFilter>()
  0ddb6bb0  ldr     x1, [x8]
  0ddb6bb4  bl      #0x92207a0  ; -> UnityEngine.GameObject$$AddComponent<object>
  0ddb6bb8  mov     x1, x0
  0ddb6bbc  stur    x0, [x19, #0x80]
  0ddb6bc0  add     x0, x19, #0x80
  0ddb6bc4  bl      #0x63cee24
  0ddb6bc8  ldur    x0, [x19, #0x80]
  0ddb6bcc  cbz     x0, #0xddb6c28
  0ddb6bd0  ldr     x1, [x20]
  0ddb6bd4  mov     x2, xzr
  0ddb6bd8  bl      #0xd99dcd0  ; -> UnityEngine.MeshFilter$$set_sharedMesh
  0ddb6bdc  b       #0xddb6c0c
  0ddb6be0  adrp    x8, #0xea67000
  0ddb6be4  ldr     x8, [x8, #0x3c0]  ; META UnityEngine.Debug_TypeInfo
  0ddb6be8  ldr     x0, [x8]
  0ddb6bec  ldr     w8, [x0, #0xe4]
  0ddb6bf0  cbnz    w8, #0xddb6bf8
  0ddb6bf4  bl      #0x63ceff4
  0ddb6bf8  adrp    x8, #0xebc6000
  0ddb6bfc  mov     x1, xzr
  0ddb6c00  ldr     x8, [x8, #0x1a0]  ; STR "Laser用のRendererが指定されていません"
  0ddb6c04  ldr     x0, [x8]
  0ddb6c08  bl      #0xd973858  ; -> UnityEngine.Debug$$LogError
  0ddb6c0c  ldp     x20, x19, [sp, #0xa0]
  0ddb6c10  ldr     x30, [sp, #0x60]
  0ddb6c14  ldp     x22, x21, [sp, #0x90]
  0ddb6c18  ldp     x24, x23, [sp, #0x80]
  0ddb6c1c  ldp     x26, x25, [sp, #0x70]
  0ddb6c20  add     sp, sp, #0xb0
  0ddb6c24  ret     
  0ddb6c28  bl      #0x63cf120
  0ddb6c2c  bl      #0x63cf128
=== Campus.Live.Equipment.Environment.LiveLaser$$AddDependencyJob @ 0xddb6fd8 (131 insns)
    Unity_Jobs_JobHandle_o Campus_Live_Equipment_Environment_LiveLaser__AddDependencyJob (Campus_Live_Equipment_Environment_LiveLaser_o* __this, Unity_Jobs_JobHandle_o handle, Unity_Collections_NativeArray_LiveEquipmentStreamData__o streamData, const MethodInfo* method);
  0ddb6fd8  sub     sp, sp, #0x100
  0ddb6fdc  str     d10, [sp, #0xa0]
  0ddb6fe0  stp     d9, d8, [sp, #0xb0]
  0ddb6fe4  stp     x30, x25, [sp, #0xc0]
  0ddb6fe8  stp     x24, x23, [sp, #0xd0]
  0ddb6fec  stp     x22, x21, [sp, #0xe0]
  0ddb6ff0  stp     x20, x19, [sp, #0xf0]
  0ddb6ff4  adrp    x24, #0xf43b000
  0ddb6ff8  mov     x22, x4
  0ddb6ffc  mov     x23, x3
  0ddb7000  ldrb    w8, [x24, #0xc77]
  0ddb7004  mov     x20, x2
  0ddb7008  mov     x21, x1
  0ddb700c  mov     x19, x0
  0ddb7010  tbnz    w8, #0, #0xddb7034
  0ddb7014  adrp    x0, #0xebc6000
  0ddb7018  ldr     x0, [x0, #0x1c8]  ; MMETH Method$Unity.Jobs.IJobExtensions.Schedule<LiveLaser.LaserVertexJob>()
  0ddb701c  bl      #0x63cee78
  0ddb7020  adrp    x0, #0xea67000
  0ddb7024  ldr     x0, [x0, #0x428]  ; META VL.IVLTransform_TypeInfo
  0ddb7028  bl      #0x63cee78
  0ddb702c  mov     w8, #1
  0ddb7030  strb    w8, [x24, #0xc77]
  0ddb7034  adrp    x24, #0xf400000
  0ddb7038  stp     xzr, xzr, [sp]
  0ddb703c  ldrb    w8, [x24, #0x9d]
  0ddb7040  cbnz    w8, #0xddb7058
  0ddb7044  adrp    x0, #0xea67000
  0ddb7048  ldr     x0, [x0, #0x438]  ; META UnityEngine.Vector3_TypeInfo
  0ddb704c  bl      #0x63cee78
  0ddb7050  mov     w8, #1
  0ddb7054  strb    w8, [x24, #0x9d]
  0ddb7058  adrp    x8, #0xea67000
  0ddb705c  mov     x0, xzr
  0ddb7060  ldr     x8, [x8, #0x438]  ; META UnityEngine.Vector3_TypeInfo
  0ddb7064  ldr     x8, [x8]
  0ddb7068  ldr     x8, [x8, #0xb8]
  0ddb706c  ldp     s8, s9, [x8]
  0ddb7070  ldr     s10, [x8, #8]
  0ddb7074  bl      #0xe0f6644  ; -> VL.VLCameraController$$get_HasInstance
  0ddb7078  tbz     w0, #0, #0xddb7120
  0ddb707c  adrp    x24, #0xf41d000
  0ddb7080  ldrb    w8, [x24, #0x6d7]
  0ddb7084  cbnz    w8, #0xddb709c
  0ddb7088  adrp    x0, #0xeb74000
  0ddb708c  ldr     x0, [x0, #0x6e0]  ; META VL.VLCameraController_TypeInfo
  0ddb7090  bl      #0x63cee78
  0ddb7094  mov     w8, #1
  0ddb7098  strb    w8, [x24, #0x6d7]
  0ddb709c  adrp    x8, #0xeb74000
  0ddb70a0  ldr     x8, [x8, #0x6e0]  ; META VL.VLCameraController_TypeInfo
  0ddb70a4  ldr     x8, [x8]
  0ddb70a8  ldr     x8, [x8, #0xb8]
  0ddb70ac  ldr     x24, [x8]
  0ddb70b0  cbz     x24, #0xddb71e0
  0ddb70b4  adrp    x10, #0xea67000
  0ddb70b8  ldr     x8, [x24]
  0ddb70bc  ldr     x10, [x10, #0x428]  ; META VL.IVLTransform_TypeInfo
  0ddb70c0  ldrh    w9, [x8, #0x12e]
  0ddb70c4  ldr     x1, [x10]
  0ddb70c8  cbz     x9, #0xddb70ec
  0ddb70cc  ldr     x10, [x8, #0xb0]
  0ddb70d0  add     x10, x10, #8
  0ddb70d4  ldur    x11, [x10, #-8]
  0ddb70d8  cmp     x11, x1
  0ddb70dc  b.eq    #0xddb70fc
  0ddb70e0  subs    x9, x9, #1
  0ddb70e4  add     x10, x10, #0x10
  0ddb70e8  b.ne    #0xddb70d4
  0ddb70ec  mov     x0, x24
  0ddb70f0  mov     w2, wzr
  0ddb70f4  bl      #0x6408234
  0ddb70f8  b       #0xddb7108
  0ddb70fc  ldrsw   x9, [x10]
  0ddb7100  add     x8, x8, x9, lsl #4
  0ddb7104  add     x0, x8, #0x138
  0ddb7108  ldp     x8, x1, [x0]
  0ddb710c  mov     x0, x24
  0ddb7110  blr     x8
  0ddb7114  fmov    s8, s0
  0ddb7118  fmov    s9, s1
  0ddb711c  fmov    s10, s2
  0ddb7120  ldur    q0, [x19, #0x88]
  0ddb7124  fmov    s1, s9
  0ddb7128  fmov    s2, s10
  0ddb712c  ldr     w24, [x19, #0x20]
  0ddb7130  mov     x0, xzr
  0ddb7134  str     q0, [sp]
  0ddb7138  fmov    s0, s8
  0ddb713c  bl      #0xd70a1d0  ; -> Unity.Mathematics.float3$$op_Implicit
  0ddb7140  mov     x0, x19
  0ddb7144  mov     x1, xzr
  0ddb7148  fmov    s8, s0
  0ddb714c  fmov    s9, s1
  0ddb7150  fmov    s10, s2
  0ddb7154  bl      #0xd9d7844  ; -> UnityEngine.Component$$get_transform
  0ddb7158  cbz     x0, #0xddb71e0
  0ddb715c  adrp    x25, #0xebc6000
  0ddb7160  mov     x1, xzr
  0ddb7164  ldr     x25, [x25, #0x1c8]  ; MMETH Method$Unity.Jobs.IJobExtensions.Schedule<LiveLaser.LaserVertexJob>()
  0ddb7168  bl      #0xd9eee58  ; -> UnityEngine.Transform$$get_position
  0ddb716c  mov     x0, xzr
  0ddb7170  bl      #0xd70a1d0  ; -> Unity.Mathematics.float3$$op_Implicit
  0ddb7174  ldr     q3, [sp]
  0ddb7178  ldr     x3, [x25]
  0ddb717c  add     x0, sp, #0x18
  0ddb7180  mov     x1, x21
  0ddb7184  mov     x2, x20
  0ddb7188  stp     xzr, xzr, [sp, #0x90]
  0ddb718c  stur    q3, [sp, #0x28]
  0ddb7190  movi    v3.2d, #0000000000000000
  0ddb7194  stp     x23, x22, [sp, #0x18]
  0ddb7198  str     w24, [sp, #0x38]
  0ddb719c  stp     s8, s9, [sp, #0x78]
  0ddb71a0  stur    q3, [sp, #0x3c]
  0ddb71a4  stur    q3, [sp, #0x4c]
  0ddb71a8  stur    q3, [sp, #0x5c]
  0ddb71ac  stur    q3, [sp, #0x68]
  0ddb71b0  stp     s10, s0, [sp, #0x80]
  0ddb71b4  stp     s1, s2, [sp, #0x88]
  0ddb71b8  bl      #0x923f0ac  ; -> Unity.Jobs.IJobExtensions$$Schedule<LiveLaser.LaserVertexJob>
  0ddb71bc  stp     x0, x1, [x19, #0xa8]
  0ddb71c0  ldp     x20, x19, [sp, #0xf0]
  0ddb71c4  ldp     x22, x21, [sp, #0xe0]
  0ddb71c8  ldr     d10, [sp, #0xa0]
  0ddb71cc  ldp     x24, x23, [sp, #0xd0]
  0ddb71d0  ldp     x30, x25, [sp, #0xc0]
  0ddb71d4  ldp     d9, d8, [sp, #0xb0]
  0ddb71d8  add     sp, sp, #0x100
  0ddb71dc  ret     
  0ddb71e0  bl      #0x63cf120
=== Campus.Live.Equipment.Environment.LiveLaser$$UpdateLaserVertex @ 0xddb7470 (120 insns)
    void Campus_Live_Equipment_Environment_LiveLaser__UpdateLaserVertex (Campus_Live_Equipment_Environment_LiveLaser_VertexLayout_o* pVertex, Unity_Mathematics_quaternion_o rotation, float radius, float length, UnityEngine_Color_o color, Unity_Mathematics_float2_o uvOffset, const MethodInfo* method);
  0ddb7470  stp     d15, d14, [sp, #-0x60]!
  0ddb7474  stp     d13, d12, [sp, #0x10]
  0ddb7478  stp     d11, d10, [sp, #0x20]
  0ddb747c  stp     d9, d8, [sp, #0x30]
  0ddb7480  str     x30, [sp, #0x40]
  0ddb7484  stp     x20, x19, [sp, #0x50]
  0ddb7488  fmov    s12, s0
  0ddb748c  fmov    s0, #20.00000000
  0ddb7490  fmul    s15, s5, s5
  0ddb7494  fmov    s8, s5
  0ddb7498  fmov    s9, s3
  0ddb749c  adrp    x20, #0xf400000
  0ddb74a0  fmov    s10, s2
  0ddb74a4  fmov    s11, s1
  0ddb74a8  ldrb    w8, [x20, #0x4be]
  0ddb74ac  fmul    s13, s4, s0
  0ddb74b0  mov     x19, x0
  0ddb74b4  fmul    s14, s13, s13
  0ddb74b8  cbnz    w8, #0xddb74d0
  0ddb74bc  adrp    x0, #0xea67000
  0ddb74c0  ldr     x0, [x0, #0x190]  ; META System.Math_TypeInfo
  0ddb74c4  bl      #0x63cee78
  0ddb74c8  mov     w8, #1
  0ddb74cc  strb    w8, [x20, #0x4be]
  0ddb74d0  adrp    x8, #0xea67000
  0ddb74d4  fadd    s14, s14, s15
  0ddb74d8  ldr     x8, [x8, #0x190]  ; META System.Math_TypeInfo
  0ddb74dc  ldr     x0, [x8]
  0ddb74e0  ldr     w8, [x0, #0xe4]
  0ddb74e4  cbnz    w8, #0xddb74ec
  0ddb74e8  bl      #0x63ceff4
  0ddb74ec  fsqrt   s0, s14
  0ddb74f0  movi    d1, #0000000000000000
  0ddb74f4  fsub    s6, s13, s13
  0ddb74f8  adrp    x9, #0x276e000
  0ddb74fc  ldp     s2, s3, [sp, #0x60]
  0ddb7500  ldp     s4, s5, [sp, #0x68]
  0ddb7504  ldr     s18, [x9, #0x3f8]
  0ddb7508  adrp    x9, #0x276e000
  0ddb750c  ldp     s19, s20, [sp, #0x70]
  0ddb7510  fmul    s7, s12, s1
  0ddb7514  fmul    s16, s10, s1
  0ddb7518  ldr     s21, [x9, #0xb48]
  0ddb751c  mov     w9, #0xaaab
  0ddb7520  mov     w8, wzr
  0ddb7524  movk    w9, #0xaaaa, lsl #16
  0ddb7528  fdiv    s0, s8, s0
  0ddb752c  cbz     x19, #0xddb764c
  0ddb7530  umull   x10, w8, w9
  0ddb7534  fmov    s1, #0.50000000
  0ddb7538  stp     s3, s4, [x19, #0x10]
  0ddb753c  lsr     x10, x10, #0x21
  0ddb7540  scvtf   s22, w10, #2
  0ddb7544  sub     w10, w10, w10, lsl #2
  0ddb7548  add     w10, w8, w10
  0ddb754c  add     w8, w8, #1
  0ddb7550  scvtf   s25, w10
  0ddb7554  scvtf   s15, w10, #5
  0ddb7558  cmp     w8, #0xf
  0ddb755c  fmul    s23, s6, s22
  0ddb7560  fmul    s27, s22, s8
  0ddb7564  str     s22, [x19, #0x28]
  0ddb7568  fadd    s23, s13, s23
  0ddb756c  fmul    s28, s0, s27
  0ddb7570  fadd    s24, s23, s23
  0ddb7574  fsub    s28, s28, s27
  0ddb7578  fmul    s24, s24, s1
  0ddb757c  fmul    s24, s24, s25
  0ddb7580  fmul    s25, s25, s18
  0ddb7584  fabd    s26, s24, s23
  0ddb7588  fsub    s23, s24, s23
  0ddb758c  fadd    s25, s25, s21
  0ddb7590  fdiv    s26, s26, s13
  0ddb7594  fadd    s25, s19, s25
  0ddb7598  stp     s5, s25, [x19, #0x18]
  0ddb759c  fmul    s26, s28, s26
  0ddb75a0  fadd    s24, s27, s26
  0ddb75a4  fmul    s27, s10, s23
  0ddb75a8  fmul    s26, s11, s23
  0ddb75ac  fmul    s28, s12, s24
  0ddb75b0  fmul    s29, s11, s24
  0ddb75b4  fsub    s26, s7, s26
  0ddb75b8  fsub    s27, s27, s28
  0ddb75bc  fsub    s28, s29, s16
  0ddb75c0  fadd    s26, s26, s26
  0ddb75c4  fadd    s28, s28, s28
  0ddb75c8  fadd    s27, s27, s27
  0ddb75cc  fmul    s29, s9, s26
  0ddb75d0  fmul    s30, s12, s26
  0ddb75d4  fmul    s26, s11, s26
  0ddb75d8  fmul    s31, s9, s28
  0ddb75dc  fmul    s14, s10, s27
  0ddb75e0  fadd    s24, s24, s29
  0ddb75e4  fmul    s1, s9, s27
  0ddb75e8  fmul    s17, s10, s28
  0ddb75ec  fmul    s27, s12, s27
  0ddb75f0  fmul    s28, s11, s28
  0ddb75f4  fadd    s23, s23, s31
  0ddb75f8  movi    d31, #0000000000000000
  0ddb75fc  fsub    s26, s26, s14
  0ddb7600  fsub    s17, s17, s30
  0ddb7604  fadd    s30, s20, s15
  0ddb7608  fsub    s27, s27, s28
  0ddb760c  fadd    s1, s1, s31
  0ddb7610  fadd    s23, s23, s26
  0ddb7614  stp     s22, s30, [x19, #0x20]
  0ddb7618  fadd    s1, s1, s17
  0ddb761c  fadd    s17, s24, s27
  0ddb7620  stp     s23, s1, [x19]
  0ddb7624  stp     s17, s2, [x19, #8]
  0ddb7628  add     x19, x19, #0x2c
  0ddb762c  b.ne    #0xddb752c
  0ddb7630  ldp     x20, x19, [sp, #0x50]
  0ddb7634  ldr     x30, [sp, #0x40]
  0ddb7638  ldp     d9, d8, [sp, #0x30]
  0ddb763c  ldp     d11, d10, [sp, #0x20]
  0ddb7640  ldp     d13, d12, [sp, #0x10]
  0ddb7644  ldp     d15, d14, [sp], #0x60
  0ddb7648  ret     
  0ddb764c  bl      #0x63cf120
=== Campus.Live.Equipment.Environment.LiveLaser.LaserVertexJob$$LookCamera @ 0xddb7d94 (132 insns)
    Unity_Mathematics_quaternion_o Campus_Live_Equipment_Environment_LiveLaser_LaserVertexJob__LookCamera (Campus_Live_Equipment_Environment_LiveLaser_LaserVertexJob_o __this, Unity_Mathematics_quaternion_o rotation, const MethodInfo* method);
  0ddb7d94  sub     sp, sp, #0x70
  0ddb7d98  stp     d15, d14, [sp, #0x10]
  0ddb7d9c  stp     d13, d12, [sp, #0x20]
  0ddb7da0  stp     d11, d10, [sp, #0x30]
  0ddb7da4  stp     d9, d8, [sp, #0x40]
  0ddb7da8  stp     x30, x21, [sp, #0x50]
  0ddb7dac  stp     x20, x19, [sp, #0x60]
  0ddb7db0  fmov    s10, s3
  0ddb7db4  fmov    s8, s2
  0ddb7db8  adrp    x20, #0xf400000
  0ddb7dbc  fmov    s9, s1
  0ddb7dc0  fmov    s11, s0
  0ddb7dc4  ldr     s12, [x0, #0x74]
  0ddb7dc8  ldp     s14, s15, [x0, #0x68]
  0ddb7dcc  ldrb    w8, [x20, #0x4c1]
  0ddb7dd0  ldr     s13, [x0, #0x60]
  0ddb7dd4  mov     x19, x0
  0ddb7dd8  cbnz    w8, #0xddb7df0
  0ddb7ddc  adrp    x0, #0xea67000
  0ddb7de0  ldr     x0, [x0, #0x190]  ; META System.Math_TypeInfo
  0ddb7de4  bl      #0x63cee78
  0ddb7de8  mov     w8, #1
  0ddb7dec  strb    w8, [x20, #0x4c1]
  0ddb7df0  adrp    x20, #0xea67000
  0ddb7df4  ldr     x20, [x20, #0x190]  ; META System.Math_TypeInfo
  0ddb7df8  ldr     x0, [x20]
  0ddb7dfc  ldr     w8, [x0, #0xe4]
  0ddb7e00  cbnz    w8, #0xddb7e08
  0ddb7e04  bl      #0x63ceff4
  0ddb7e08  adrp    x21, #0xf400000
  0ddb7e0c  ldrb    w8, [x21, #0x4bf]
  0ddb7e10  cbnz    w8, #0xddb7e28
  0ddb7e14  adrp    x0, #0xea67000
  0ddb7e18  ldr     x0, [x0, #0x190]  ; META System.Math_TypeInfo
  0ddb7e1c  bl      #0x63cee78
  0ddb7e20  mov     w8, #1
  0ddb7e24  strb    w8, [x21, #0x4bf]
  0ddb7e28  ldr     x0, [x20]
  0ddb7e2c  ldr     w8, [x0, #0xe4]
  0ddb7e30  cbnz    w8, #0xddb7e38
  0ddb7e34  bl      #0x63ceff4
  0ddb7e38  adrp    x21, #0xf400000
  0ddb7e3c  ldrb    w8, [x21, #0x4f4]
  0ddb7e40  cbnz    w8, #0xddb7e58
  0ddb7e44  adrp    x0, #0xea67000
  0ddb7e48  ldr     x0, [x0, #0x190]  ; META System.Math_TypeInfo
  0ddb7e4c  bl      #0x63cee78
  0ddb7e50  mov     w8, #1
  0ddb7e54  strb    w8, [x21, #0x4f4]
  0ddb7e58  ldr     x0, [x20]
  0ddb7e5c  ldr     w8, [x0, #0xe4]
  0ddb7e60  cbnz    w8, #0xddb7e68
  0ddb7e64  bl      #0x63ceff4
  0ddb7e68  fsub    s0, s15, s13
  0ddb7e6c  fsub    s1, s12, s14
  0ddb7e70  fcvt    d0, s0
  0ddb7e74  fcvt    d1, s1
  0ddb7e78  bl      #0xe1b8470
  0ddb7e7c  fcvt    s0, d0
  0ddb7e80  fmov    s1, #0.50000000
  0ddb7e84  add     x0, sp, #8
  0ddb7e88  mov     x1, sp
  0ddb7e8c  fmul    s0, s0, s1
  0ddb7e90  fcvt    d0, s0
  0ddb7e94  bl      #0xe1b84a0
  0ddb7e98  ldp     d2, d0, [sp]
  0ddb7e9c  movi    d1, #0000000000000000
  0ddb7ea0  ldp     s3, s4, [x19, #0x78]
  0ddb7ea4  ldp     s7, s18, [x19, #0x80]
  0ddb7ea8  fcvt    s0, d0
  0ddb7eac  fcvt    s2, d2
  0ddb7eb0  ldp     x20, x19, [sp, #0x60]
  0ddb7eb4  ldp     x30, x21, [sp, #0x50]
  0ddb7eb8  ldp     d13, d12, [sp, #0x20]
  0ddb7ebc  fmul    s1, s0, s1
  0ddb7ec0  fmul    s5, s3, s2
  0ddb7ec4  fmul    s6, s4, s0
  0ddb7ec8  fmul    s19, s7, s2
  0ddb7ecc  ldp     d15, d14, [sp, #0x10]
  0ddb7ed0  fmul    s16, s3, s1
  0ddb7ed4  fmul    s17, s4, s1
  0ddb7ed8  fmul    s4, s4, s2
  0ddb7edc  fmul    s20, s7, s1
  0ddb7ee0  fadd    s5, s5, s6
  0ddb7ee4  fmul    s1, s18, s1
  0ddb7ee8  fmul    s2, s18, s2
  0ddb7eec  fmul    s18, s18, s0
  0ddb7ef0  fmul    s7, s7, s0
  0ddb7ef4  fadd    s6, s16, s17
  0ddb7ef8  fadd    s16, s19, s16
  0ddb7efc  fmul    s0, s3, s0
  0ddb7f00  fadd    s4, s4, s20
  0ddb7f04  fadd    s5, s1, s5
  0ddb7f08  fsub    s2, s2, s6
  0ddb7f0c  fadd    s6, s18, s16
  0ddb7f10  fadd    s1, s1, s4
  0ddb7f14  fsub    s3, s5, s20
  0ddb7f18  fsub    s2, s2, s7
  0ddb7f1c  fsub    s4, s6, s17
  0ddb7f20  fsub    s0, s1, s0
  0ddb7f24  fmul    s1, s11, s3
  0ddb7f28  fmul    s5, s8, s3
  0ddb7f2c  fmul    s20, s10, s3
  0ddb7f30  fmul    s3, s9, s3
  0ddb7f34  fmul    s6, s11, s2
  0ddb7f38  fmul    s7, s9, s2
  0ddb7f3c  fmul    s16, s8, s2
  0ddb7f40  fmul    s17, s9, s4
  0ddb7f44  fmul    s18, s11, s0
  0ddb7f48  fmul    s19, s9, s0
  0ddb7f4c  fmul    s21, s10, s0
  0ddb7f50  fmul    s2, s10, s2
  0ddb7f54  fmul    s22, s10, s4
  0ddb7f58  fadd    s5, s5, s7
  0ddb7f5c  fmul    s0, s8, s0
  0ddb7f60  fadd    s6, s6, s17
  0ddb7f64  fadd    s7, s16, s18
  0ddb7f68  fadd    s1, s1, s19
  0ddb7f6c  fmul    s16, s11, s4
  0ddb7f70  fmul    s4, s8, s4
  0ddb7f74  ldp     d9, d8, [sp, #0x40]
  0ddb7f78  fadd    s5, s21, s5
  0ddb7f7c  ldp     d11, d10, [sp, #0x30]
  0ddb7f80  fadd    s6, s20, s6
  0ddb7f84  fadd    s7, s22, s7
  0ddb7f88  fsub    s17, s2, s1
  0ddb7f8c  fsub    s1, s5, s16
  0ddb7f90  fsub    s0, s6, s0
  0ddb7f94  fsub    s2, s7, s3
  0ddb7f98  fsub    s3, s17, s4
  0ddb7f9c  add     sp, sp, #0x70
  0ddb7fa0  ret     

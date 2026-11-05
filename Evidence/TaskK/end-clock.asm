=== Campus.Live.Live3DPresenter$$get_TimelineTime @ 0x84f3b90 (50 insns)
    float Campus_Live_Live3DPresenter__get_TimelineTime (Campus_Live_Live3DPresenter_o* __this, const MethodInfo* method);
  084f3b90  str     d8, [sp, #-0x30]!
  084f3b94  stp     x30, x21, [sp, #0x10]
  084f3b98  stp     x20, x19, [sp, #0x20]
  084f3b9c  adrp    x20, #0xf413000
  084f3ba0  adrp    x21, #0xea65000
  084f3ba4  mov     x19, x0
  084f3ba8  ldrb    w8, [x20, #0x23]
  084f3bac  ldr     x21, [x21, #0x718]  ; META UnityEngine.Object_TypeInfo
  084f3bb0  tbnz    w8, #0, #0x84f3bc8
  084f3bb4  adrp    x0, #0xea65000
  084f3bb8  ldr     x0, [x0, #0x718]  ; META UnityEngine.Object_TypeInfo
  084f3bbc  bl      #0x63cee78
  084f3bc0  mov     w8, #1
  084f3bc4  strb    w8, [x20, #0x23]
  084f3bc8  ldr     x0, [x21]
  084f3bcc  ldr     x20, [x19, #0x40]
  084f3bd0  ldr     w8, [x0, #0xe4]
  084f3bd4  cbnz    w8, #0x84f3bdc
  084f3bd8  bl      #0x63ceff4
  084f3bdc  mov     x0, x20
  084f3be0  mov     x1, xzr
  084f3be4  mov     x2, xzr
  084f3be8  bl      #0xd9de99c  ; -> UnityEngine.Object$$op_Equality
  084f3bec  movi    d8, #0000000000000000
  084f3bf0  tbnz    w0, #0, #0x84f3c40
  084f3bf4  ldr     x8, [x19, #0x40]
  084f3bf8  cbz     x8, #0x84f3c54
  084f3bfc  ldr     x0, [x21]
  084f3c00  ldr     x20, [x8, #0x20]
  084f3c04  ldr     w9, [x0, #0xe4]
  084f3c08  cbnz    w9, #0x84f3c10
  084f3c0c  bl      #0x63ceff4
  084f3c10  mov     x0, x20
  084f3c14  mov     x1, xzr
  084f3c18  mov     x2, xzr
  084f3c1c  bl      #0xd9de99c  ; -> UnityEngine.Object$$op_Equality
  084f3c20  tbnz    w0, #0, #0x84f3c40
  084f3c24  ldr     x8, [x19, #0x40]
  084f3c28  cbz     x8, #0x84f3c54
  084f3c2c  ldr     x0, [x8, #0x20]
  084f3c30  cbz     x0, #0x84f3c54
  084f3c34  mov     x1, xzr
  084f3c38  bl      #0xda1f730  ; -> UnityEngine.Playables.PlayableDirector$$get_time
  084f3c3c  fcvt    s8, d0
  084f3c40  ldp     x20, x19, [sp, #0x20]
  084f3c44  fmov    s0, s8
  084f3c48  ldp     x30, x21, [sp, #0x10]
  084f3c4c  ldr     d8, [sp], #0x30
  084f3c50  ret     
  084f3c54  bl      #0x63cf120
=== Campus.Live.LivePlayerPresenter$$get_TimelineTime @ 0x863a478 (6 insns)
    float Campus_Live_LivePlayerPresenter__get_TimelineTime (Campus_Live_LivePlayerPresenter_o* __this, const MethodInfo* method);
  0863a478  ldr     x0, [x0, #0x20]
  0863a47c  cbz     x0, #0x863a488
  0863a480  mov     x1, xzr
  0863a484  b       #0x84f3b90  ; -> Campus.Live.Live3DPresenter$$get_TimelineTime
  0863a488  str     x30, [sp, #-0x10]!
  0863a48c  bl      #0x63cf120
=== Campus.Live.LivePresenter$$BeginLiveLoop @ 0x863e2e4 (14 insns)
    void Campus_Live_LivePresenter__BeginLiveLoop (Campus_Live_LivePresenter_o* __this, const MethodInfo* method);
  0863e2e4  stp     x30, x19, [sp, #-0x10]!
  0863e2e8  mov     x19, x0
  0863e2ec  ldr     x0, [x0, #0x30]
  0863e2f0  cbz     x0, #0x863e318
  0863e2f4  bl      #0x863ac4c  ; -> Campus.Live.LivePlayerPresenter$$OnBeginLiveLoop
  0863e2f8  ldr     x8, [x19, #0x20]
  0863e2fc  cbz     x8, #0x863e318
  0863e300  ldr     x8, [x8, #0x20]
  0863e304  cbz     x8, #0x863e318
  0863e308  mov     w9, #1
  0863e30c  strb    w9, [x8, #0x10]
  0863e310  ldp     x30, x19, [sp], #0x10
  0863e314  ret     
  0863e318  bl      #0x63cf120
=== Campus.Live.LivePresenter$$<CreateLiveSequence>b__24_0 @ 0x863e698 (32 insns)
    void Campus_Live_LivePresenter___CreateLiveSequence_b__24_0 (Campus_Live_LivePresenter_o* __this, const MethodInfo* method);
  0863e698  str     d8, [sp, #-0x20]!
  0863e69c  stp     x30, x19, [sp, #0x10]
  0863e6a0  ldr     x8, [x0, #0x30]
  0863e6a4  cbz     x8, #0x863e714
  0863e6a8  mov     x19, x0
  0863e6ac  ldr     x0, [x8, #0x20]
  0863e6b0  cbz     x0, #0x863e714
  0863e6b4  mov     x1, xzr
  0863e6b8  bl      #0x84f3b90  ; -> Campus.Live.Live3DPresenter$$get_TimelineTime
  0863e6bc  ldr     x8, [x19, #0x20]
  0863e6c0  cbz     x8, #0x863e714
  0863e6c4  ldr     x0, [x8, #0x20]
  0863e6c8  cbz     x0, #0x863e714
  0863e6cc  mov     x1, xzr
  0863e6d0  fmov    s8, s0
  0863e6d4  bl      #0x671c9ac  ; -> Campus.Live.Data.LiveExecutionData$$SetCurrentTime
  0863e6d8  fmov    s0, s8
  0863e6dc  mov     x0, x19
  0863e6e0  bl      #0x863e52c  ; -> Campus.Live.LivePresenter$$CheckLiveEnd
  0863e6e4  ldr     x8, [x19, #0x58]
  0863e6e8  cbz     x8, #0x863e708
  0863e6ec  ldp     x30, x19, [sp, #0x10]
  0863e6f0  fmov    s0, s8
  0863e6f4  ldr     x0, [x8, #0x40]
  0863e6f8  ldr     x1, [x8, #0x28]
  0863e6fc  ldr     x2, [x8, #0x18]
  0863e700  ldr     d8, [sp], #0x20
  0863e704  br      x2
  0863e708  ldp     x30, x19, [sp, #0x10]
  0863e70c  ldr     d8, [sp], #0x20
  0863e710  ret     
  0863e714  bl      #0x63cf120

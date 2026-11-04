=== Campus.Timeline.CampusLightTrack$$GatherPropertiesLight @ 0x4e096d0 (413 insns)
    void Campus_Timeline_CampusLightTrack__GatherPropertiesLight (Campus_Timeline_CampusLightTrack_o* __this, UnityEngine_Timeline_IPropertyCollector_o* driver, Campus_Common_CampusLightAnchor_o* lightAnchor, const MethodInfo* method);
  04e096d0  str     x30, [sp, #-0x40]!
  04e096d4  stp     x24, x23, [sp, #0x10]
  04e096d8  stp     x22, x21, [sp, #0x20]
  04e096dc  stp     x20, x19, [sp, #0x30]
  04e096e0  adrp    x22, #0x5817000
  04e096e4  adrp    x21, #0x54ab000
  04e096e8  mov     x20, x2
  04e096ec  ldrb    w8, [x22, #0x3b9]
  04e096f0  ldr     x21, [x21, #0x5e8]  ; META UnityEngine.Object_TypeInfo
  04e096f4  mov     x19, x1
  04e096f8  tbnz    w8, #0, #0x4e09788
  04e096fc  adrp    x0, #0x54ea000
  04e09700  ldr     x0, [x0, #0x7e8]  ; MMETH Method$UnityEngine.Timeline.IPropertyCollector.AddFromName<Light>()
  04e09704  bl      #0x2673db4
  04e09708  adrp    x0, #0x54ab000
  04e0970c  ldr     x0, [x0, #0x5e8]  ; META UnityEngine.Object_TypeInfo
  04e09710  bl      #0x2673db4
  04e09714  adrp    x0, #0x54ea000
  04e09718  ldr     x0, [x0, #0x7f0]  ; STR "m_Shadows.m_Type"
  04e0971c  bl      #0x2673db4
  04e09720  adrp    x0, #0x54ea000
  04e09724  ldr     x0, [x0, #0x7f8]  ; STR "m_Color"
  04e09728  bl      #0x2673db4
  04e0972c  adrp    x0, #0x54ea000
  04e09730  ldr     x0, [x0, #0x800]  ; STR "m_Range"
  04e09734  bl      #0x2673db4
  04e09738  adrp    x0, #0x54ea000
  04e0973c  ldr     x0, [x0, #0x808]  ; STR "m_ColorTemperature"
  04e09740  bl      #0x2673db4
  04e09744  adrp    x0, #0x54ea000
  04e09748  ldr     x0, [x0, #0x810]  ; STR "m_Shadows.m_Strength"
  04e0974c  bl      #0x2673db4
  04e09750  adrp    x0, #0x54ea000
  04e09754  ldr     x0, [x0, #0x818]  ; STR "m_InnerSpotAngle"
  04e09758  bl      #0x2673db4
  04e0975c  adrp    x0, #0x54ea000
  04e09760  ldr     x0, [x0, #0x820]  ; STR "m_UseColorTemperature"
  04e09764  bl      #0x2673db4
  04e09768  adrp    x0, #0x54ea000
  04e0976c  ldr     x0, [x0, #0x828]  ; STR "m_SpotAngle"
  04e09770  bl      #0x2673db4
  04e09774  adrp    x0, #0x54ea000
  04e09778  ldr     x0, [x0, #0x830]  ; STR "m_Intensity"
  04e0977c  bl      #0x2673db4
  04e09780  mov     w8, #1
  04e09784  strb    w8, [x22, #0x3b9]
  04e09788  ldr     x0, [x21]
  04e0978c  ldr     w8, [x0, #0xe4]
  04e09790  cbnz    w8, #0x4e09798
  04e09794  bl      #0x2673f30
  04e09798  mov     x0, x20
  04e0979c  mov     x1, xzr
  04e097a0  mov     x2, xzr
  04e097a4  bl      #0x4b1133c  ; -> UnityEngine.Object$$op_Equality
  04e097a8  tbnz    w0, #0, #0x4e097dc
  04e097ac  cbz     x19, #0x4e097dc
  04e097b0  cbz     x20, #0x4e09d40
  04e097b4  ldr     x0, [x21]
  04e097b8  ldr     x20, [x20, #0x20]
  04e097bc  ldr     w8, [x0, #0xe4]
  04e097c0  cbnz    w8, #0x4e097c8
  04e097c4  bl      #0x2673f30
  04e097c8  mov     x0, x20
  04e097cc  mov     x1, xzr
  04e097d0  mov     x2, xzr
  04e097d4  bl      #0x4b1133c  ; -> UnityEngine.Object$$op_Equality
  04e097d8  tbz     w0, #0, #0x4e097f0
  04e097dc  ldp     x20, x19, [sp, #0x30]
  04e097e0  ldp     x22, x21, [sp, #0x20]
  04e097e4  ldp     x24, x23, [sp, #0x10]
  04e097e8  ldr     x30, [sp], #0x40
  04e097ec  ret
  04e097f0  cbz     x20, #0x4e09d40
  04e097f4  mov     x0, x20
  04e097f8  mov     x1, xzr
  04e097fc  bl      #0x4b0c654  ; -> UnityEngine.Component$$get_gameObject
  04e09800  adrp    x24, #0x54ea000
  04e09804  adrp    x10, #0x54ea000
  04e09808  mov     x22, x0
  04e0980c  ldr     x24, [x24, #0x7e8]  ; MMETH Method$UnityEngine.Timeline.IPropertyCollector.AddFromName<Light>()
  04e09810  ldr     x8, [x19]
  04e09814  ldr     x23, [x24]
  04e09818  ldr     x10, [x10, #0x830]  ; STR "m_Intensity"
  04e0981c  ldrh    w9, [x8, #0x12e]
  04e09820  ldr     x21, [x10]
  04e09824  ldr     x1, [x23, #0x20]
  04e09828  ldrh    w2, [x23, #0x50]
  04e0982c  cbz     x9, #0x4e09850
  04e09830  ldr     x10, [x8, #0xb0]
  04e09834  add     x10, x10, #8
  04e09838  ldur    x11, [x10, #-8]
  04e0983c  cmp     x11, x1
  04e09840  b.eq    #0x4e0985c
  04e09844  subs    x9, x9, #1
  04e09848  add     x10, x10, #0x10
  04e0984c  b.ne    #0x4e09838
  04e09850  mov     x0, x19
  04e09854  bl      #0x26ac5d4
  04e09858  b       #0x4e0986c
  04e0985c  ldr     w9, [x10]
  04e09860  add     w9, w9, w2
  04e09864  add     x8, x8, w9, sxtw #4
  04e09868  add     x0, x8, #0x138
  04e0986c  ldr     x0, [x0, #8]
  04e09870  mov     x1, x23
  04e09874  bl      #0x2673f2c
  04e09878  ldr     x8, [x0, #8]
  04e0987c  mov     x3, x0
  04e09880  mov     x0, x19
  04e09884  mov     x1, x22
  04e09888  mov     x2, x21
  04e0988c  blr     x8
  04e09890  mov     x0, x20
  04e09894  mov     x1, xzr
  04e09898  bl      #0x4b0c654  ; -> UnityEngine.Component$$get_gameObject
  04e0989c  adrp    x10, #0x54ea000
  04e098a0  ldr     x8, [x19]
  04e098a4  ldr     x23, [x24]
  04e098a8  ldr     x10, [x10, #0x7f8]  ; STR "m_Color"
  04e098ac  mov     x22, x0
  04e098b0  ldrh    w9, [x8, #0x12e]
  04e098b4  ldr     x1, [x23, #0x20]
  04e098b8  ldrh    w2, [x23, #0x50]
  04e098bc  ldr     x21, [x10]
  04e098c0  cbz     x9, #0x4e098e4
  04e098c4  ldr     x10, [x8, #0xb0]
  04e098c8  add     x10, x10, #8
  04e098cc  ldur    x11, [x10, #-8]
  04e098d0  cmp     x11, x1
  04e098d4  b.eq    #0x4e098f0
  04e098d8  subs    x9, x9, #1
  04e098dc  add     x10, x10, #0x10
  04e098e0  b.ne    #0x4e098cc
  04e098e4  mov     x0, x19
  04e098e8  bl      #0x26ac5d4
  04e098ec  b       #0x4e09900
  04e098f0  ldr     w9, [x10]
  04e098f4  add     w9, w9, w2
  04e098f8  add     x8, x8, w9, sxtw #4
  04e098fc  add     x0, x8, #0x138
  04e09900  ldr     x0, [x0, #8]
  04e09904  mov     x1, x23
  04e09908  bl      #0x2673f2c
  04e0990c  ldr     x8, [x0, #8]
  04e09910  mov     x3, x0
  04e09914  mov     x0, x19
  04e09918  mov     x1, x22
  04e0991c  mov     x2, x21
  04e09920  blr     x8
  04e09924  mov     x0, x20
  04e09928  mov     x1, xzr
  04e0992c  bl      #0x4b0c654  ; -> UnityEngine.Component$$get_gameObject
  04e09930  adrp    x10, #0x54ea000
  04e09934  ldr     x8, [x19]
  04e09938  ldr     x23, [x24]
  04e0993c  ldr     x10, [x10, #0x808]  ; STR "m_ColorTemperature"
  04e09940  mov     x22, x0
  04e09944  ldrh    w9, [x8, #0x12e]
  04e09948  ldr     x1, [x23, #0x20]
  04e0994c  ldrh    w2, [x23, #0x50]
  04e09950  ldr     x21, [x10]
  04e09954  cbz     x9, #0x4e09978
  04e09958  ldr     x10, [x8, #0xb0]
  04e0995c  add     x10, x10, #8
  04e09960  ldur    x11, [x10, #-8]
  04e09964  cmp     x11, x1
  04e09968  b.eq    #0x4e09984
  04e0996c  subs    x9, x9, #1
  04e09970  add     x10, x10, #0x10
  04e09974  b.ne    #0x4e09960
  04e09978  mov     x0, x19
  04e0997c  bl      #0x26ac5d4
  04e09980  b       #0x4e09994
  04e09984  ldr     w9, [x10]
  04e09988  add     w9, w9, w2
  04e0998c  add     x8, x8, w9, sxtw #4
  04e09990  add     x0, x8, #0x138
  04e09994  ldr     x0, [x0, #8]
  04e09998  mov     x1, x23
  04e0999c  bl      #0x2673f2c
  04e099a0  ldr     x8, [x0, #8]
  04e099a4  mov     x3, x0
  04e099a8  mov     x0, x19
  04e099ac  mov     x1, x22
  04e099b0  mov     x2, x21
  04e099b4  blr     x8
  04e099b8  mov     x0, x20
  04e099bc  mov     x1, xzr
  04e099c0  bl      #0x4b0c654  ; -> UnityEngine.Component$$get_gameObject
  04e099c4  adrp    x10, #0x54ea000
  04e099c8  ldr     x8, [x19]
  04e099cc  ldr     x23, [x24]
  04e099d0  ldr     x10, [x10, #0x800]  ; STR "m_Range"
  04e099d4  mov     x22, x0
  04e099d8  ldrh    w9, [x8, #0x12e]
  04e099dc  ldr     x1, [x23, #0x20]
  04e099e0  ldrh    w2, [x23, #0x50]
  04e099e4  ldr     x21, [x10]
  04e099e8  cbz     x9, #0x4e09a0c
  04e099ec  ldr     x10, [x8, #0xb0]
  04e099f0  add     x10, x10, #8
  04e099f4  ldur    x11, [x10, #-8]
  04e099f8  cmp     x11, x1
  04e099fc  b.eq    #0x4e09a18
  04e09a00  subs    x9, x9, #1
  04e09a04  add     x10, x10, #0x10
  04e09a08  b.ne    #0x4e099f4
  04e09a0c  mov     x0, x19
  04e09a10  bl      #0x26ac5d4
  04e09a14  b       #0x4e09a28
  04e09a18  ldr     w9, [x10]
  04e09a1c  add     w9, w9, w2
  04e09a20  add     x8, x8, w9, sxtw #4
  04e09a24  add     x0, x8, #0x138
  04e09a28  ldr     x0, [x0, #8]
  04e09a2c  mov     x1, x23
  04e09a30  bl      #0x2673f2c
  04e09a34  ldr     x8, [x0, #8]
  04e09a38  mov     x3, x0
  04e09a3c  mov     x0, x19
  04e09a40  mov     x1, x22
  04e09a44  mov     x2, x21
  04e09a48  blr     x8
  04e09a4c  mov     x0, x20
  04e09a50  mov     x1, xzr
  04e09a54  bl      #0x4b0c654  ; -> UnityEngine.Component$$get_gameObject
  04e09a58  adrp    x10, #0x54ea000
  04e09a5c  ldr     x8, [x19]
  04e09a60  ldr     x23, [x24]
  04e09a64  ldr     x10, [x10, #0x820]  ; STR "m_UseColorTemperature"
  04e09a68  mov     x22, x0
  04e09a6c  ldrh    w9, [x8, #0x12e]
  04e09a70  ldr     x1, [x23, #0x20]
  04e09a74  ldrh    w2, [x23, #0x50]
  04e09a78  ldr     x21, [x10]
  04e09a7c  cbz     x9, #0x4e09aa0
  04e09a80  ldr     x10, [x8, #0xb0]
  04e09a84  add     x10, x10, #8
  04e09a88  ldur    x11, [x10, #-8]
  04e09a8c  cmp     x11, x1
  04e09a90  b.eq    #0x4e09aac
  04e09a94  subs    x9, x9, #1
  04e09a98  add     x10, x10, #0x10
  04e09a9c  b.ne    #0x4e09a88
  04e09aa0  mov     x0, x19
  04e09aa4  bl      #0x26ac5d4
  04e09aa8  b       #0x4e09abc
  04e09aac  ldr     w9, [x10]
  04e09ab0  add     w9, w9, w2
  04e09ab4  add     x8, x8, w9, sxtw #4
  04e09ab8  add     x0, x8, #0x138
  04e09abc  ldr     x0, [x0, #8]
  04e09ac0  mov     x1, x23
  04e09ac4  bl      #0x2673f2c
  04e09ac8  ldr     x8, [x0, #8]
  04e09acc  mov     x3, x0
  04e09ad0  mov     x0, x19
  04e09ad4  mov     x1, x22
  04e09ad8  mov     x2, x21
  04e09adc  blr     x8
  04e09ae0  mov     x0, x20
  04e09ae4  mov     x1, xzr
  04e09ae8  bl      #0x4b0c654  ; -> UnityEngine.Component$$get_gameObject
  04e09aec  adrp    x10, #0x54ea000
  04e09af0  ldr     x8, [x19]
  04e09af4  ldr     x23, [x24]
  04e09af8  ldr     x10, [x10, #0x7f0]  ; STR "m_Shadows.m_Type"
  04e09afc  mov     x22, x0
  04e09b00  ldrh    w9, [x8, #0x12e]
  04e09b04  ldr     x1, [x23, #0x20]
  04e09b08  ldrh    w2, [x23, #0x50]
  04e09b0c  ldr     x21, [x10]
  04e09b10  cbz     x9, #0x4e09b34
  04e09b14  ldr     x10, [x8, #0xb0]
  04e09b18  add     x10, x10, #8
  04e09b1c  ldur    x11, [x10, #-8]
  04e09b20  cmp     x11, x1
  04e09b24  b.eq    #0x4e09b40
  04e09b28  subs    x9, x9, #1
  04e09b2c  add     x10, x10, #0x10
  04e09b30  b.ne    #0x4e09b1c
  04e09b34  mov     x0, x19
  04e09b38  bl      #0x26ac5d4
  04e09b3c  b       #0x4e09b50
  04e09b40  ldr     w9, [x10]
  04e09b44  add     w9, w9, w2
  04e09b48  add     x8, x8, w9, sxtw #4
  04e09b4c  add     x0, x8, #0x138
  04e09b50  ldr     x0, [x0, #8]
  04e09b54  mov     x1, x23
  04e09b58  bl      #0x2673f2c
  04e09b5c  ldr     x8, [x0, #8]
  04e09b60  mov     x3, x0
  04e09b64  mov     x0, x19
  04e09b68  mov     x1, x22
  04e09b6c  mov     x2, x21
  04e09b70  blr     x8
  04e09b74  mov     x0, x20
  04e09b78  mov     x1, xzr
  04e09b7c  bl      #0x4b0c654  ; -> UnityEngine.Component$$get_gameObject
  04e09b80  adrp    x10, #0x54ea000
  04e09b84  ldr     x8, [x19]
  04e09b88  ldr     x23, [x24]
  04e09b8c  ldr     x10, [x10, #0x810]  ; STR "m_Shadows.m_Strength"
  04e09b90  mov     x22, x0
  04e09b94  ldrh    w9, [x8, #0x12e]
  04e09b98  ldr     x1, [x23, #0x20]
  04e09b9c  ldrh    w2, [x23, #0x50]
  04e09ba0  ldr     x21, [x10]
  04e09ba4  cbz     x9, #0x4e09bc8
  04e09ba8  ldr     x10, [x8, #0xb0]
  04e09bac  add     x10, x10, #8
  04e09bb0  ldur    x11, [x10, #-8]
  04e09bb4  cmp     x11, x1
  04e09bb8  b.eq    #0x4e09bd4
  04e09bbc  subs    x9, x9, #1
  04e09bc0  add     x10, x10, #0x10
  04e09bc4  b.ne    #0x4e09bb0
  04e09bc8  mov     x0, x19
  04e09bcc  bl      #0x26ac5d4
  04e09bd0  b       #0x4e09be4
  04e09bd4  ldr     w9, [x10]
  04e09bd8  add     w9, w9, w2
  04e09bdc  add     x8, x8, w9, sxtw #4
  04e09be0  add     x0, x8, #0x138
  04e09be4  ldr     x0, [x0, #8]
  04e09be8  mov     x1, x23
  04e09bec  bl      #0x2673f2c
  04e09bf0  ldr     x8, [x0, #8]
  04e09bf4  mov     x3, x0
  04e09bf8  mov     x0, x19
  04e09bfc  mov     x1, x22
  04e09c00  mov     x2, x21
  04e09c04  blr     x8
  04e09c08  mov     x0, x20
  04e09c0c  mov     x1, xzr
  04e09c10  bl      #0x4b0c654  ; -> UnityEngine.Component$$get_gameObject
  04e09c14  adrp    x10, #0x54ea000
  04e09c18  ldr     x8, [x19]
  04e09c1c  ldr     x23, [x24]
  04e09c20  ldr     x10, [x10, #0x828]  ; STR "m_SpotAngle"
  04e09c24  mov     x22, x0
  04e09c28  ldrh    w9, [x8, #0x12e]
  04e09c2c  ldr     x1, [x23, #0x20]
  04e09c30  ldrh    w2, [x23, #0x50]
  04e09c34  ldr     x21, [x10]
  04e09c38  cbz     x9, #0x4e09c5c
  04e09c3c  ldr     x10, [x8, #0xb0]
  04e09c40  add     x10, x10, #8
  04e09c44  ldur    x11, [x10, #-8]
  04e09c48  cmp     x11, x1
  04e09c4c  b.eq    #0x4e09c68
  04e09c50  subs    x9, x9, #1
  04e09c54  add     x10, x10, #0x10
  04e09c58  b.ne    #0x4e09c44
  04e09c5c  mov     x0, x19
  04e09c60  bl      #0x26ac5d4
  04e09c64  b       #0x4e09c78
  04e09c68  ldr     w9, [x10]
  04e09c6c  add     w9, w9, w2
  04e09c70  add     x8, x8, w9, sxtw #4
  04e09c74  add     x0, x8, #0x138
  04e09c78  ldr     x0, [x0, #8]
  04e09c7c  mov     x1, x23
  04e09c80  bl      #0x2673f2c
  04e09c84  ldr     x8, [x0, #8]
  04e09c88  mov     x3, x0
  04e09c8c  mov     x0, x19
  04e09c90  mov     x1, x22
  04e09c94  mov     x2, x21
  04e09c98  blr     x8
  04e09c9c  mov     x0, x20
  04e09ca0  mov     x1, xzr
  04e09ca4  bl      #0x4b0c654  ; -> UnityEngine.Component$$get_gameObject
  04e09ca8  adrp    x10, #0x54ea000
  04e09cac  ldr     x8, [x19]
  04e09cb0  ldr     x22, [x24]
  04e09cb4  ldr     x10, [x10, #0x818]  ; STR "m_InnerSpotAngle"
  04e09cb8  mov     x21, x0
  04e09cbc  ldrh    w9, [x8, #0x12e]
  04e09cc0  ldr     x1, [x22, #0x20]
  04e09cc4  ldrh    w2, [x22, #0x50]
  04e09cc8  ldr     x20, [x10]
  04e09ccc  cbz     x9, #0x4e09cf0
  04e09cd0  ldr     x10, [x8, #0xb0]
  04e09cd4  add     x10, x10, #8
  04e09cd8  ldur    x11, [x10, #-8]
  04e09cdc  cmp     x11, x1
  04e09ce0  b.eq    #0x4e09cfc
  04e09ce4  subs    x9, x9, #1
  04e09ce8  add     x10, x10, #0x10
  04e09cec  b.ne    #0x4e09cd8
  04e09cf0  mov     x0, x19
  04e09cf4  bl      #0x26ac5d4
  04e09cf8  b       #0x4e09d0c
  04e09cfc  ldr     w9, [x10]
  04e09d00  add     w9, w9, w2
  04e09d04  add     x8, x8, w9, sxtw #4
  04e09d08  add     x0, x8, #0x138
  04e09d0c  ldr     x0, [x0, #8]
  04e09d10  mov     x1, x22
  04e09d14  bl      #0x2673f2c
  04e09d18  mov     x3, x0
  04e09d1c  mov     x0, x19
  04e09d20  mov     x1, x21
  04e09d24  mov     x2, x20
  04e09d28  ldp     x20, x19, [sp, #0x30]
  04e09d2c  ldp     x22, x21, [sp, #0x20]
  04e09d30  ldr     x4, [x3, #8]
  04e09d34  ldp     x24, x23, [sp, #0x10]
  04e09d38  ldr     x30, [sp], #0x40
  04e09d3c  br      x4
  04e09d40  bl      #0x267405c
=== Campus.Crowd.CrowdTimelineTrack$$.ctor @ 0x4e276b4 (211 insns)
    void Campus_Crowd_CrowdTimelineTrack___ctor (Campus_Crowd_CrowdTimelineTrack_o* __this, const MethodInfo* method);
  04e276b4  mov     x1, xzr
  04e276b8  b       #0x4a7b31c  ; -> UnityEngine.Timeline.PlayableTrack$$.ctor
  04e276bc  sub     sp, sp, #0x80
  04e276c0  stp     d15, d14, [sp, #0x20]
  04e276c4  stp     d13, d12, [sp, #0x30]
  04e276c8  stp     d11, d10, [sp, #0x40]
  04e276cc  stp     d9, d8, [sp, #0x50]
  04e276d0  stp     x30, x21, [sp, #0x60]
  04e276d4  stp     x20, x19, [sp, #0x70]
  04e276d8  fmov    s9, s1
  04e276dc  ldr     s4, [x0, #0x60]
  04e276e0  ldr     s1, [x0, #0x74]
  04e276e4  fmov    s10, s3
  04e276e8  fmov    s8, s2
  04e276ec  fmov    s11, s0
  04e276f0  adrp    x20, #0x5808000
  04e276f4  stp     s1, s4, [sp, #8]
  04e276f8  mov     x19, x0
  04e276fc  ldp     s1, s4, [x0, #0x68]
  04e27700  ldrb    w8, [x20, #0xefd]
  04e27704  stp     s4, s1, [sp]
  04e27708  cbnz    w8, #0x4e27720
  04e2770c  adrp    x0, #0x559f000
  04e27710  add     x0, x0, #0x628  ; META System.Math_TypeInfo
  04e27714  bl      #0x2673db4
  04e27718  mov     w8, #1
  04e2771c  strb    w8, [x20, #0xefd]
  04e27720  adrp    x20, #0x559f000
  04e27724  add     x20, x20, #0x628  ; META System.Math_TypeInfo
  04e27728  ldr     x0, [x20]
  04e2772c  ldr     w8, [x0, #0xe4]
  04e27730  cbnz    w8, #0x4e27738
  04e27734  bl      #0x2673f30
  04e27738  adrp    x21, #0x5808000
  04e2773c  ldp     s13, s15, [x19, #0x78]
  04e27740  ldp     s12, s14, [x19, #0x80]
  04e27744  ldrb    w8, [x21, #0xefc]
  04e27748  cbnz    w8, #0x4e27760
  04e2774c  adrp    x0, #0x559f000
  04e27750  add     x0, x0, #0x628  ; META System.Math_TypeInfo
  04e27754  bl      #0x2673db4
  04e27758  mov     w8, #1
  04e2775c  strb    w8, [x21, #0xefc]
  04e27760  ldr     x0, [x20]
  04e27764  ldr     w8, [x0, #0xe4]
  04e27768  cbnz    w8, #0x4e27770
  04e2776c  bl      #0x2673f30
  04e27770  adrp    x19, #0x5808000
  04e27774  ldrb    w8, [x19, #0xefb]
  04e27778  cbnz    w8, #0x4e27790
  04e2777c  adrp    x0, #0x559f000
  04e27780  add     x0, x0, #0x628  ; META System.Math_TypeInfo
  04e27784  bl      #0x2673db4
  04e27788  mov     w8, #1
  04e2778c  strb    w8, [x19, #0xefb]
  04e27790  ldr     x0, [x20]
  04e27794  ldr     w8, [x0, #0xe4]
  04e27798  cbnz    w8, #0x4e277a0
  04e2779c  bl      #0x2673f30
  04e277a0  ldp     s1, s2, [sp]
  04e277a4  ldr     s0, [sp, #0xc]
  04e277a8  fsub    s0, s1, s0
  04e277ac  ldr     s1, [sp, #8]
  04e277b0  fsub    s1, s1, s2
  04e277b4  fcvt    d0, s0
  04e277b8  fcvt    d1, s1
  04e277bc  bl      #0x5089e20
  04e277c0  fcvt    s0, d0
  04e277c4  fmov    s1, #0.50000000
  04e277c8  add     x0, sp, #0x18
  04e277cc  add     x1, sp, #0x10
  04e277d0  fmul    s0, s0, s1
  04e277d4  fcvt    d0, s0
  04e277d8  bl      #0x5089e40
  04e277dc  ldp     d2, d0, [sp, #0x10]
  04e277e0  movi    d1, #0000000000000000
  04e277e4  ldp     x20, x19, [sp, #0x70]
  04e277e8  ldp     x30, x21, [sp, #0x60]
  04e277ec  fcvt    s0, d0
  04e277f0  fcvt    s2, d2
  04e277f4  fmul    s1, s0, s1
  04e277f8  fmul    s3, s13, s2
  04e277fc  fmul    s4, s15, s0
  04e27800  fmul    s5, s15, s2
  04e27804  fmul    s7, s12, s2
  04e27808  fmul    s2, s14, s2
  04e2780c  fmul    s18, s13, s0
  04e27810  fmul    s6, s12, s1
  04e27814  fmul    s16, s13, s1
  04e27818  fmul    s17, s14, s1
  04e2781c  fadd    s3, s3, s4
  04e27820  fmul    s1, s15, s1
  04e27824  fadd    s4, s5, s6
  04e27828  fmul    s5, s14, s0
  04e2782c  fadd    s7, s7, s16
  04e27830  fadd    s3, s17, s3
  04e27834  fadd    s16, s16, s1
  04e27838  fmul    s0, s12, s0
  04e2783c  ldp     d13, d12, [sp, #0x30]
  04e27840  ldp     d15, d14, [sp, #0x20]
  04e27844  fadd    s4, s17, s4
  04e27848  fadd    s5, s5, s7
  04e2784c  fsub    s3, s3, s6
  04e27850  fsub    s2, s2, s16
  04e27854  fsub    s4, s4, s18
  04e27858  fsub    s1, s5, s1
  04e2785c  fmul    s5, s10, s3
  04e27860  fmul    s6, s11, s3
  04e27864  fsub    s0, s2, s0
  04e27868  fmul    s2, s9, s3
  04e2786c  fmul    s3, s8, s3
  04e27870  fmul    s7, s10, s4
  04e27874  fmul    s16, s10, s1
  04e27878  fmul    s17, s8, s4
  04e2787c  fmul    s18, s11, s1
  04e27880  fmul    s19, s9, s4
  04e27884  fmul    s20, s11, s0
  04e27888  fmul    s21, s9, s0
  04e2788c  fmul    s22, s10, s0
  04e27890  fmul    s0, s8, s0
  04e27894  fadd    s2, s2, s16
  04e27898  fmul    s16, s9, s1
  04e2789c  fadd    s5, s5, s17
  04e278a0  fadd    s7, s7, s18
  04e278a4  fmul    s4, s11, s4
  04e278a8  fadd    s6, s6, s19
  04e278ac  fmul    s17, s8, s1
  04e278b0  ldp     d9, d8, [sp, #0x50]
  04e278b4  fadd    s2, s0, s2
  04e278b8  ldp     d11, d10, [sp, #0x40]
  04e278bc  fadd    s1, s20, s5
  04e278c0  fadd    s5, s21, s7
  04e278c4  fsub    s6, s22, s6
  04e278c8  fsub    s2, s2, s4
  04e278cc  fsub    s0, s1, s16
  04e278d0  fsub    s1, s5, s3
  04e278d4  fsub    s3, s6, s17
  04e278d8  add     sp, sp, #0x80
  04e278dc  ret
  04e278e0  sub     sp, sp, #0x80
  04e278e4  stp     d13, d12, [sp, #0x40]
  04e278e8  stp     d11, d10, [sp, #0x50]
  04e278ec  stp     d9, d8, [sp, #0x60]
  04e278f0  stp     x30, x19, [sp, #0x70]
  04e278f4  fmov    s13, s5
  04e278f8  fmov    s11, s4
  04e278fc  adrp    x19, #0x5808000
  04e27900  fmov    s12, s3
  04e27904  fmov    s8, s2
  04e27908  ldrb    w8, [x19, #0xef3]
  04e2790c  fmov    s9, s1
  04e27910  fmov    s10, s0
  04e27914  cbnz    w8, #0x4e2792c
  04e27918  adrp    x0, #0x559f000
  04e2791c  add     x0, x0, #0x628  ; META System.Math_TypeInfo
  04e27920  bl      #0x2673db4
  04e27924  mov     w8, #1
  04e27928  strb    w8, [x19, #0xef3]
  04e2792c  adrp    x8, #0x559f000
  04e27930  add     x8, x8, #0x628  ; META System.Math_TypeInfo
  04e27934  ldr     x0, [x8]
  04e27938  ldr     w8, [x0, #0xe4]
  04e2793c  cbnz    w8, #0x4e27944
  04e27940  bl      #0x2673f30
  04e27944  fmul    s0, s10, s13
  04e27948  fmul    s1, s8, s12
  04e2794c  add     x0, sp, #0x30
  04e27950  fmul    s2, s8, s11
  04e27954  fmul    s3, s9, s13
  04e27958  add     x1, sp, #0xc
  04e2795c  fmul    s4, s9, s12
  04e27960  fmul    s5, s10, s11
  04e27964  mov     x2, xzr
  04e27968  stp     s10, s9, [sp, #0x24]
  04e2796c  fsub    s0, s0, s1
  04e27970  str     s8, [sp, #0x2c]
  04e27974  fsub    s1, s2, s3
  04e27978  stp     xzr, xzr, [sp, #0x30]
  04e2797c  fsub    s2, s4, s5
  04e27980  fmul    s4, s0, s0
  04e27984  fmul    s3, s1, s1
  04e27988  fmul    s5, s2, s2
  04e2798c  fadd    s3, s3, s4
  04e27990  fmov    s4, #1.00000000
  04e27994  fadd    s3, s5, s3
  04e27998  fsqrt   s3, s3
  04e2799c  fdiv    s3, s4, s3
  04e279a0  fmul    s0, s0, s3
  04e279a4  fmul    s2, s2, s3
  04e279a8  fmul    s1, s1, s3
  04e279ac  fmul    s3, s9, s2
  04e279b0  fmul    s4, s8, s0
  04e279b4  fmul    s5, s8, s1
  04e279b8  fmul    s6, s10, s2
  04e279bc  stp     s1, s0, [sp, #0xc]
  04e279c0  fmul    s7, s10, s0
  04e279c4  fmul    s16, s9, s1
  04e279c8  fsub    s3, s3, s4
  04e279cc  fsub    s4, s5, s6
  04e279d0  fsub    s0, s7, s16
  04e279d4  stp     s2, s3, [sp, #0x14]
  04e279d8  stp     s4, s0, [sp, #0x1c]
  04e279dc  bl      #0x4856f38  ; -> Unity.Mathematics.quaternion$$.ctor
  04e279e0  ldp     s0, s1, [sp, #0x30]
  04e279e4  ldp     s2, s3, [sp, #0x38]
  04e279e8  ldp     x30, x19, [sp, #0x70]
  04e279ec  ldp     d9, d8, [sp, #0x60]
  04e279f0  ldp     d11, d10, [sp, #0x50]
  04e279f4  ldp     d13, d12, [sp, #0x40]
  04e279f8  add     sp, sp, #0x80
  04e279fc  ret
=== VLB.VolumetricLightBeamSD$$get_additionalClippingPlane @ 0x504da34 (66 insns)
    UnityEngine_Vector4_o VLB_VolumetricLightBeamSD__get_additionalClippingPlane (VLB_VolumetricLightBeamSD_o* __this, const MethodInfo* method);
  0504da34  str     d10, [sp, #-0x40]!
  0504da38  stp     d9, d8, [sp, #0x10]
  0504da3c  stp     x30, x21, [sp, #0x20]
  0504da40  stp     x20, x19, [sp, #0x30]
  0504da44  adrp    x21, #0x5818000
  0504da48  adrp    x20, #0x54ab000
  0504da4c  mov     x19, x0
  0504da50  ldrb    w8, [x21, #0x82a]
  0504da54  ldr     x20, [x20, #0x5e8]  ; META UnityEngine.Object_TypeInfo
  0504da58  tbnz    w8, #0, #0x504da70
  0504da5c  adrp    x0, #0x54ab000
  0504da60  ldr     x0, [x0, #0x5e8]  ; META UnityEngine.Object_TypeInfo
  0504da64  bl      #0x2673db4
  0504da68  mov     w8, #1
  0504da6c  strb    w8, [x21, #0x82a]
  0504da70  ldr     x0, [x20]
  0504da74  ldr     x20, [x19, #0x98]
  0504da78  ldr     w8, [x0, #0xe4]
  0504da7c  cbnz    w8, #0x504da84
  0504da80  bl      #0x2673f30
  0504da84  mov     x0, x20
  0504da88  mov     x1, xzr
  0504da8c  mov     x2, xzr
  0504da90  bl      #0x4b1133c  ; -> UnityEngine.Object$$op_Equality
  0504da94  tbz     w0, #0, #0x504dad4
  0504da98  adrp    x19, #0x5808000
  0504da9c  ldrb    w8, [x19, #0xfd4]
  0504daa0  cbnz    w8, #0x504dab8
  0504daa4  adrp    x0, #0x54ab000
  0504daa8  ldr     x0, [x0, #0xfe0]  ; META UnityEngine.Vector4_TypeInfo
  0504daac  bl      #0x2673db4
  0504dab0  mov     w8, #1
  0504dab4  strb    w8, [x19, #0xfd4]
  0504dab8  adrp    x8, #0x54ab000
  0504dabc  ldr     x8, [x8, #0xfe0]  ; META UnityEngine.Vector4_TypeInfo
  0504dac0  ldr     x8, [x8]
  0504dac4  ldr     x8, [x8, #0xb8]
  0504dac8  ldp     s8, s9, [x8]
  0504dacc  ldp     s10, s3, [x8, #8]
  0504dad0  b       #0x504db18
  0504dad4  ldr     x0, [x19, #0x98]
  0504dad8  cbz     x0, #0x504db38
  0504dadc  mov     x1, xzr
  0504dae0  bl      #0x4b1d354  ; -> UnityEngine.Transform$$get_forward
  0504dae4  ldr     x0, [x19, #0x98]
  0504dae8  cbz     x0, #0x504db38
  0504daec  mov     x1, xzr
  0504daf0  fmov    s8, s0
  0504daf4  fmov    s9, s1
  0504daf8  fmov    s10, s2
  0504dafc  bl      #0x4b1cd4c  ; -> UnityEngine.Transform$$get_position
  0504db00  fmul    s0, s8, s0
  0504db04  fmul    s1, s9, s1
  0504db08  fadd    s0, s0, s1
  0504db0c  fmul    s1, s10, s2
  0504db10  fadd    s0, s1, s0
  0504db14  fneg    s3, s0
  0504db18  fmov    s0, s8
  0504db1c  fmov    s1, s9
  0504db20  fmov    s2, s10
  0504db24  ldp     x20, x19, [sp, #0x30]
  0504db28  ldp     x30, x21, [sp, #0x20]
  0504db2c  ldp     d9, d8, [sp, #0x10]
  0504db30  ldr     d10, [sp], #0x40
  0504db34  ret
  0504db38  bl      #0x267405c
=== VLB.VolumetricLightBeamSD$$get_skewingLocalForwardDirectionNormalized @ 0x504dc4c (150 insns)
    UnityEngine_Vector3_o VLB_VolumetricLightBeamSD__get_skewingLocalForwardDirectionNormalized (VLB_VolumetricLightBeamSD_o* __this, const MethodInfo* method);
  0504dc4c  str     d10, [sp, #-0x30]!
  0504dc50  stp     d9, d8, [sp, #8]
  0504dc54  str     x30, [sp, #0x18]
  0504dc58  stp     x20, x19, [sp, #0x20]
  0504dc5c  adrp    x20, #0x5818000
  0504dc60  mov     x19, x0
  0504dc64  ldrb    w8, [x20, #0x829]
  0504dc68  tbnz    w8, #0, #0x504dc98
  0504dc6c  adrp    x0, #0x54ab000
  0504dc70  ldr     x0, [x0, #0x640]  ; META UnityEngine.Debug_TypeInfo
  0504dc74  bl      #0x2673db4
  0504dc78  adrp    x0, #0x54ac000
  0504dc7c  ldr     x0, [x0, #0xa58]  ; META object[]_TypeInfo
  0504dc80  bl      #0x2673db4
  0504dc84  adrp    x0, #0x54f8000
  0504dc88  ldr     x0, [x0, #0xc60]  ; STR "Beam {0} has a skewingLocalForwardDirection with a null Z, which is forbidden"
  0504dc8c  bl      #0x2673db4
  0504dc90  mov     w8, #1
  0504dc94  strb    w8, [x20, #0x829]
  0504dc98  adrp    x20, #0x5808000
  0504dc9c  ldr     s8, [x19, #0x90]
  0504dca0  ldrb    w8, [x20, #0xfd1]
  0504dca4  cbnz    w8, #0x504dcbc
  0504dca8  adrp    x0, #0x54ab000
  0504dcac  ldr     x0, [x0, #0xe80]  ; META UnityEngine.Mathf_TypeInfo
  0504dcb0  bl      #0x2673db4
  0504dcb4  mov     w8, #1
  0504dcb8  strb    w8, [x20, #0xfd1]
  0504dcbc  adrp    x8, #0x54ab000
  0504dcc0  fabs    s0, s8
  0504dcc4  movi    d1, #0000000000000000
  0504dcc8  ldr     x8, [x8, #0xe80]  ; META UnityEngine.Mathf_TypeInfo
  0504dccc  adrp    x9, #0xf9a000
  0504dcd0  fmov    s2, #8.00000000
  0504dcd4  ldr     s4, [x9, #0xd80]
  0504dcd8  ldr     x8, [x8]
  0504dcdc  fmaxnm  s0, s0, s1
  0504dce0  fabd    s1, s1, s8
  0504dce4  ldr     x8, [x8, #0xb8]
  0504dce8  ldr     s3, [x8]
  0504dcec  fmul    s0, s0, s4
  0504dcf0  fmul    s2, s3, s2
  0504dcf4  fcmp    s0, s2
  0504dcf8  fcsel   s0, s0, s2, gt
  0504dcfc  fcmp    s1, s0
  0504dd00  b.pl    #0x504ddcc
  0504dd04  adrp    x8, #0x54ac000
  0504dd08  mov     w1, #1
  0504dd0c  ldr     x8, [x8, #0xa58]  ; META object[]_TypeInfo
  0504dd10  ldr     x0, [x8]
  0504dd14  bl      #0x2673ea0
  0504dd18  mov     x20, x0
  0504dd1c  mov     x0, x19
  0504dd20  mov     x1, xzr
  0504dd24  bl      #0x4b14ea0  ; -> UnityEngine.Object$$get_name
  0504dd28  cbz     x20, #0x504de90
  0504dd2c  mov     x19, x0
  0504dd30  cbz     x0, #0x504dd48
  0504dd34  ldr     x8, [x20]
  0504dd38  mov     x0, x19
  0504dd3c  ldr     x1, [x8, #0x40]
  0504dd40  bl      #0x2673f34
  0504dd44  cbz     x0, #0x504de98
  0504dd48  ldr     w8, [x20, #0x18]
  0504dd4c  cbz     w8, #0x504de94
  0504dd50  mov     x0, x20
  0504dd54  mov     x1, x19
  0504dd58  str     x19, [x0, #0x20]!
  0504dd5c  bl      #0x2673d60
  0504dd60  adrp    x8, #0x54ab000
  0504dd64  ldr     x8, [x8, #0x640]  ; META UnityEngine.Debug_TypeInfo
  0504dd68  ldr     x0, [x8]
  0504dd6c  ldr     w8, [x0, #0xe4]
  0504dd70  cbnz    w8, #0x504dd78
  0504dd74  bl      #0x2673f30
  0504dd78  adrp    x8, #0x54f8000
  0504dd7c  mov     x1, x20
  0504dd80  mov     x2, xzr
  0504dd84  ldr     x8, [x8, #0xc60]  ; STR "Beam {0} has a skewingLocalForwardDirection with a null Z, which is forbidden"
  0504dd88  ldr     x0, [x8]
  0504dd8c  bl      #0x4ad14dc  ; -> UnityEngine.Debug$$LogErrorFormat
  0504dd90  adrp    x19, #0x5808000
  0504dd94  ldrb    w8, [x19, #0xfce]
  0504dd98  cbnz    w8, #0x504ddb0
  0504dd9c  adrp    x0, #0x54ab000
  0504dda0  ldr     x0, [x0, #0x638]  ; META UnityEngine.Vector3_TypeInfo
  0504dda4  bl      #0x2673db4
  0504dda8  mov     w8, #1
  0504ddac  strb    w8, [x19, #0xfce]
  0504ddb0  adrp    x8, #0x54ab000
  0504ddb4  ldr     x8, [x8, #0x638]  ; META UnityEngine.Vector3_TypeInfo
  0504ddb8  ldr     x8, [x8]
  0504ddbc  ldr     x8, [x8, #0xb8]
  0504ddc0  ldp     s0, s1, [x8, #0x48]
  0504ddc4  ldr     s2, [x8, #0x50]
  0504ddc8  b       #0x504de7c
  0504ddcc  adrp    x20, #0x5808000
  0504ddd0  ldp     s8, s9, [x19, #0x88]
  0504ddd4  ldrb    w8, [x20, #0xef5]
  0504ddd8  ldr     s10, [x19, #0x90]
  0504dddc  cbnz    w8, #0x504ddf4
  0504dde0  adrp    x0, #0x54ab000
  0504dde4  ldr     x0, [x0, #0x608]  ; META System.Math_TypeInfo
  0504dde8  bl      #0x2673db4
  0504ddec  mov     w8, #1
  0504ddf0  strb    w8, [x20, #0xef5]
  0504ddf4  adrp    x8, #0x54ab000
  0504ddf8  ldr     x8, [x8, #0x608]  ; META System.Math_TypeInfo
  0504ddfc  ldr     x0, [x8]
  0504de00  ldr     w8, [x0, #0xe4]
  0504de04  cbnz    w8, #0x504de0c
  0504de08  bl      #0x2673f30
  0504de0c  fmul    s0, s8, s8
  0504de10  fmul    s1, s9, s9
  0504de14  adrp    x8, #0xf9a000
  0504de18  fadd    s0, s0, s1
  0504de1c  fmul    s1, s10, s10
  0504de20  fadd    s0, s1, s0
  0504de24  fsqrt   s2, s0
  0504de28  ldr     s0, [x8, #0xe00]
  0504de2c  fcmp    s2, s0
  0504de30  b.le    #0x504de44
  0504de34  fdiv    s0, s8, s2
  0504de38  fdiv    s1, s9, s2
  0504de3c  fdiv    s2, s10, s2
  0504de40  b       #0x504de7c
  0504de44  adrp    x19, #0x5808000
  0504de48  ldrb    w8, [x19, #0xef6]
  0504de4c  cbnz    w8, #0x504de64
  0504de50  adrp    x0, #0x54ab000
  0504de54  ldr     x0, [x0, #0x638]  ; META UnityEngine.Vector3_TypeInfo
  0504de58  bl      #0x2673db4
  0504de5c  mov     w8, #1
  0504de60  strb    w8, [x19, #0xef6]
  0504de64  adrp    x8, #0x54ab000
  0504de68  ldr     x8, [x8, #0x638]  ; META UnityEngine.Vector3_TypeInfo
  0504de6c  ldr     x8, [x8]
  0504de70  ldr     x8, [x8, #0xb8]
  0504de74  ldp     s0, s1, [x8]
  0504de78  ldr     s2, [x8, #8]
  0504de7c  ldp     x20, x19, [sp, #0x20]
  0504de80  ldr     x30, [sp, #0x18]
  0504de84  ldp     d9, d8, [sp, #8]
  0504de88  ldr     d10, [sp], #0x30
  0504de8c  ret
  0504de90  bl      #0x267405c
  0504de94  bl      #0x2674064
  0504de98  bl      #0x2674080
  0504de9c  mov     x1, xzr
  0504dea0  bl      #0x2673f20
=== VLB.Config$$get_SD_requiresDoubleSidedMesh @ 0x504e224 (7 insns)
    bool VLB_Config__get_SD_requiresDoubleSidedMesh (VLB_Config_o* __this, const MethodInfo* method);
  0504e224  str     x30, [sp, #-0x10]!
  0504e228  mov     w1, wzr
  0504e22c  bl      #0x504b694  ; -> VLB.Config$$GetActualRenderingMode
  0504e230  cmp     w0, #0
  0504e234  cset    w0, ne
  0504e238  ldr     x30, [sp], #0x10
  0504e23c  ret
=== VL.FaceSystem.VLActorFaceModel$$Setup @ 0x5076ec8 (375 insns)
    void VL_FaceSystem_VLActorFaceModel__Setup (VL_FaceSystem_VLActorFaceModel_o* __this, const MethodInfo* method);
  05076ec8  sub     sp, sp, #0xa0
  05076ecc  stp     x29, x30, [sp, #0x40]
  05076ed0  stp     x28, x27, [sp, #0x50]
  05076ed4  stp     x26, x25, [sp, #0x60]
  05076ed8  stp     x24, x23, [sp, #0x70]
  05076edc  stp     x22, x21, [sp, #0x80]
  05076ee0  stp     x20, x19, [sp, #0x90]
  05076ee4  adrp    x20, #0x5818000
  05076ee8  adrp    x26, #0x54fa000
  05076eec  mov     x19, x0
  05076ef0  ldrb    w8, [x20, #0x920]
  05076ef4  ldr     x26, [x26, #0x180]  ; META VL.ActorMesh.VLActorSkinningSystem_TypeInfo
  05076ef8  tbnz    w8, #0, #0x5076fdc
  05076efc  adrp    x0, #0x54fa000
  05076f00  ldr     x0, [x0, #0x188]  ; MMETH Method$System.Linq.Enumerable.GroupBy<ValueTuple<string, int>, string>()
  05076f04  bl      #0x2673db4
  05076f08  adrp    x0, #0x54fa000
  05076f0c  ldr     x0, [x0, #0x190]  ; MMETH Method$System.Linq.Enumerable.Select<BlendShapeData, ValueTuple<string, int>>()
  05076f10  bl      #0x2673db4
  05076f14  adrp    x0, #0x54fa000
  05076f18  ldr     x0, [x0, #0x198]  ; MMETH Method$System.Linq.Enumerable.ToDictionary<IGrouping<string, ValueTuple<string, int>>, string, int[]>()
  05076f1c  bl      #0x2673db4
  05076f20  adrp    x0, #0x54fa000
  05076f24  ldr     x0, [x0, #0x1a0]  ; MMETH Method$System.Linq.Enumerable.ToDictionary<ValueTuple<string, int>, string, int>()
  05076f28  bl      #0x2673db4
  05076f2c  adrp    x0, #0x54fa000
  05076f30  ldr     x0, [x0, #0x1a8]  ; META System.Func<ValueTuple<string, int>, int>_TypeInfo
  05076f34  bl      #0x2673db4
  05076f38  adrp    x0, #0x54fa000
  05076f3c  ldr     x0, [x0, #0x1b0]  ; META System.Func<ValueTuple<string, int>, string>_TypeInfo
  05076f40  bl      #0x2673db4
  05076f44  adrp    x0, #0x54fa000
  05076f48  ldr     x0, [x0, #0x1b8]  ; META System.Func<IGrouping<string, ValueTuple<string, int>>, int[]>_TypeInfo
  05076f4c  bl      #0x2673db4
  05076f50  adrp    x0, #0x54fa000
  05076f54  ldr     x0, [x0, #0x1c0]  ; META System.Func<IGrouping<string, ValueTuple<string, int>>, string>_TypeInfo
  05076f58  bl      #0x2673db4
  05076f5c  adrp    x0, #0x54fa000
  05076f60  ldr     x0, [x0, #0x1c8]  ; META System.Func<BlendShapeData, int, ValueTuple<string, int>>_TypeInfo
  05076f64  bl      #0x2673db4
  05076f68  adrp    x0, #0x54fa000
  05076f6c  ldr     x0, [x0, #0x1d0]  ; MMETH Method$VL.FaceSystem.VLActorFaceModel.<>c.<Setup>b__36_0()
  05076f70  bl      #0x2673db4
  05076f74  adrp    x0, #0x54fa000
  05076f78  ldr     x0, [x0, #0x1d8]  ; MMETH Method$VL.FaceSystem.VLActorFaceModel.<>c.<Setup>b__36_1()
  05076f7c  bl      #0x2673db4
  05076f80  adrp    x0, #0x54fa000
  05076f84  ldr     x0, [x0, #0x1e0]  ; MMETH Method$VL.FaceSystem.VLActorFaceModel.<>c.<Setup>b__36_2()
  05076f88  bl      #0x2673db4
  05076f8c  adrp    x0, #0x54fa000
  05076f90  ldr     x0, [x0, #0x1e8]  ; MMETH Method$VL.FaceSystem.VLActorFaceModel.<>c.<Setup>b__36_3()
  05076f94  bl      #0x2673db4
  05076f98  adrp    x0, #0x54fa000
  05076f9c  ldr     x0, [x0, #0x1f0]  ; MMETH Method$VL.FaceSystem.VLActorFaceModel.<>c.<Setup>b__36_4()
  05076fa0  bl      #0x2673db4
  05076fa4  adrp    x0, #0x54fa000
  05076fa8  ldr     x0, [x0, #0x1f8]  ; MMETH Method$VL.FaceSystem.VLActorFaceModel.<>c.<Setup>b__36_5()
  05076fac  bl      #0x2673db4
  05076fb0  adrp    x0, #0x54fa000
  05076fb4  ldr     x0, [x0, #0x200]  ; MMETH Method$VL.FaceSystem.VLActorFaceModel.<>c.<Setup>b__36_6()
  05076fb8  bl      #0x2673db4
  05076fbc  adrp    x0, #0x54fa000
  05076fc0  ldr     x0, [x0, #0x208]  ; META VL.FaceSystem.VLActorFaceModel.<>c_TypeInfo
  05076fc4  bl      #0x2673db4
  05076fc8  adrp    x0, #0x54fa000
  05076fcc  ldr     x0, [x0, #0x180]  ; META VL.ActorMesh.VLActorSkinningSystem_TypeInfo
  05076fd0  bl      #0x2673db4
  05076fd4  mov     w8, #1
  05076fd8  strb    w8, [x20, #0x920]
  05076fdc  mov     x0, x19
  05076fe0  mov     x1, xzr
  05076fe4  bl      #0x4b0c584  ; -> UnityEngine.Component$$get_transform
  05076fe8  ldp     x8, x24, [x19, #0x60]
  05076fec  mov     x20, x0
  05076ff0  ldr     q0, [x19, #0x50]
  05076ff4  ldp     x21, x22, [x19, #0x38]
  05076ff8  ldp     x25, x28, [x19, #0x20]
  05076ffc  ldr     x0, [x26]
  05077000  ldr     x23, [x19, #0x48]
  05077004  ldr     w29, [x19, #0x30]
  05077008  ldr     x27, [x19, #0x70]
  0507700c  str     q0, [sp, #0x20]
  05077010  str     x8, [sp, #0x30]
  05077014  bl      #0x267404c
  05077018  add     x7, sp, #0x20
  0507701c  mov     x1, x20
  05077020  mov     x2, x25
  05077024  mov     x3, x21
  05077028  mov     x4, x22
  0507702c  mov     x5, x23
  05077030  mov     x6, x24
  05077034  mov     x26, x0
  05077038  stp     x27, xzr, [sp, #0x10]
  0507703c  str     w29, [sp, #8]
  05077040  str     x28, [sp]
  05077044  bl      #0x5088710  ; -> VL.ActorMesh.VLActorSkinningSystem$$.ctor
  05077048  add     x0, x19, #0x378
  0507704c  mov     x1, x26
  05077050  str     x26, [x19, #0x378]
  05077054  bl      #0x2673d60
  05077058  adrp    x26, #0x54fa000
  0507705c  ldr     x26, [x26, #0x208]  ; META VL.FaceSystem.VLActorFaceModel.<>c_TypeInfo
  05077060  ldr     x20, [x19, #0x70]
  05077064  ldr     x0, [x26]
  05077068  ldr     w8, [x0, #0xe4]
  0507706c  cbnz    w8, #0x5077078
  05077070  bl      #0x2673f30
  05077074  ldr     x0, [x26]
  05077078  ldr     x8, [x0, #0xb8]
  0507707c  adrp    x24, #0x54fa000
  05077080  ldr     x21, [x8, #8]
  05077084  ldr     x24, [x24, #0x190]  ; MMETH Method$System.Linq.Enumerable.Select<BlendShapeData, ValueTuple<string, int>>()
  05077088  cbnz    x21, #0x50770e4
  0507708c  ldr     w9, [x0, #0xe4]
  05077090  cbnz    w9, #0x50770a0
  05077094  bl      #0x2673f30
  05077098  ldr     x8, [x26]
  0507709c  ldr     x8, [x8, #0xb8]
  050770a0  adrp    x9, #0x54fa000
  050770a4  ldr     x9, [x9, #0x1c8]  ; META System.Func<BlendShapeData, int, ValueTuple<string, int>>_TypeInfo
  050770a8  ldr     x22, [x8]
  050770ac  ldr     x0, [x9]
  050770b0  bl      #0x267404c
  050770b4  adrp    x8, #0x54fa000
  050770b8  mov     x1, x22
  050770bc  mov     x3, xzr
  050770c0  ldr     x8, [x8, #0x1d0]  ; MMETH Method$VL.FaceSystem.VLActorFaceModel.<>c.<Setup>b__36_0()
  050770c4  mov     x21, x0
  050770c8  ldr     x2, [x8]
  050770cc  bl      #0x42e5d18  ; -> System.Func<object, int, ValueTuple<object, int>>$$.ctor
  050770d0  ldr     x8, [x26]
  050770d4  mov     x1, x21
  050770d8  ldr     x0, [x8, #0xb8]
  050770dc  str     x21, [x0, #8]!
  050770e0  bl      #0x2673d60
  050770e4  ldr     x2, [x24]
  050770e8  mov     x0, x20
  050770ec  mov     x1, x21
  050770f0  bl      #0x2abcd70  ; -> System.Linq.Enumerable$$Select<object, ValueTuple<object, int>>
  050770f4  ldr     x8, [x26]
  050770f8  mov     x20, x0
  050770fc  ldr     w9, [x8, #0xe4]
  05077100  cbnz    w9, #0x5077110
  05077104  mov     x0, x8
  05077108  bl      #0x2673f30
  0507710c  ldr     x8, [x26]
  05077110  ldr     x9, [x8, #0xb8]
  05077114  ldr     x21, [x9, #0x10]
  05077118  cbnz    x21, #0x507717c
  0507711c  ldr     w10, [x8, #0xe4]
  05077120  cbnz    w10, #0x5077134
  05077124  mov     x0, x8
  05077128  bl      #0x2673f30
  0507712c  ldr     x8, [x26]
  05077130  ldr     x9, [x8, #0xb8]
  05077134  adrp    x8, #0x54fa000
  05077138  ldr     x8, [x8, #0x1b0]  ; META System.Func<ValueTuple<string, int>, string>_TypeInfo
  0507713c  ldr     x22, [x9]
  05077140  ldr     x0, [x8]
  05077144  bl      #0x267404c
  05077148  adrp    x8, #0x54fa000
  0507714c  mov     x1, x22
  05077150  mov     x3, xzr
  05077154  ldr     x8, [x8, #0x1d8]  ; MMETH Method$VL.FaceSystem.VLActorFaceModel.<>c.<Setup>b__36_1()
  05077158  mov     x21, x0
  0507715c  ldr     x2, [x8]
  05077160  bl      #0x42d6bac  ; -> System.Func<ValueTuple<object, int>, object>$$.ctor
  05077164  ldr     x8, [x26]
  05077168  mov     x1, x21
  0507716c  ldr     x0, [x8, #0xb8]
  05077170  str     x21, [x0, #0x10]!
  05077174  bl      #0x2673d60
  05077178  ldr     x8, [x26]
  0507717c  ldr     w9, [x8, #0xe4]
  05077180  cbnz    w9, #0x5077190
  05077184  mov     x0, x8
  05077188  bl      #0x2673f30
  0507718c  ldr     x8, [x26]
  05077190  ldr     x9, [x8, #0xb8]
  05077194  adrp    x25, #0x54fa000
  05077198  ldr     x22, [x9, #0x18]
  0507719c  ldr     x25, [x25, #0x1a0]  ; MMETH Method$System.Linq.Enumerable.ToDictionary<ValueTuple<string, int>, string, int>()
  050771a0  cbnz    x22, #0x5077200
  050771a4  ldr     w10, [x8, #0xe4]
  050771a8  cbnz    w10, #0x50771bc
  050771ac  mov     x0, x8
  050771b0  bl      #0x2673f30
  050771b4  ldr     x8, [x26]
  050771b8  ldr     x9, [x8, #0xb8]
  050771bc  adrp    x8, #0x54fa000
  050771c0  ldr     x8, [x8, #0x1a8]  ; META System.Func<ValueTuple<string, int>, int>_TypeInfo
  050771c4  ldr     x23, [x9]
  050771c8  ldr     x0, [x8]
  050771cc  bl      #0x267404c
  050771d0  adrp    x8, #0x54fa000
  050771d4  mov     x1, x23
  050771d8  mov     x3, xzr
  050771dc  ldr     x8, [x8, #0x1e0]  ; MMETH Method$VL.FaceSystem.VLActorFaceModel.<>c.<Setup>b__36_2()
  050771e0  mov     x22, x0
  050771e4  ldr     x2, [x8]
  050771e8  bl      #0x42d6af8  ; -> System.Func<ValueTuple<object, int>, int>$$.ctor
  050771ec  ldr     x8, [x26]
  050771f0  mov     x1, x22
  050771f4  ldr     x0, [x8, #0xb8]
  050771f8  str     x22, [x0, #0x18]!
  050771fc  bl      #0x2673d60
  05077200  ldr     x3, [x25]
  05077204  mov     x0, x20
  05077208  mov     x1, x21
  0507720c  mov     x2, x22
  05077210  bl      #0x2ac3c9c  ; -> System.Linq.Enumerable$$ToDictionary<ValueTuple<object, int>, object, int>
  05077214  mov     x1, x0
  05077218  str     x0, [x19, #0x380]
  0507721c  add     x0, x19, #0x380
  05077220  bl      #0x2673d60
  05077224  ldr     x0, [x26]
  05077228  ldr     x20, [x19, #0x70]
  0507722c  ldr     w8, [x0, #0xe4]
  05077230  cbnz    w8, #0x507723c
  05077234  bl      #0x2673f30
  05077238  ldr     x0, [x26]
  0507723c  ldr     x8, [x0, #0xb8]
  05077240  ldr     x21, [x8, #0x20]
  05077244  cbnz    x21, #0x50772a0
  05077248  ldr     w9, [x0, #0xe4]
  0507724c  cbnz    w9, #0x507725c
  05077250  bl      #0x2673f30
  05077254  ldr     x8, [x26]
  05077258  ldr     x8, [x8, #0xb8]
  0507725c  adrp    x9, #0x54fa000
  05077260  ldr     x9, [x9, #0x1c8]  ; META System.Func<BlendShapeData, int, ValueTuple<string, int>>_TypeInfo
  05077264  ldr     x22, [x8]
  05077268  ldr     x0, [x9]
  0507726c  bl      #0x267404c
  05077270  adrp    x8, #0x54fa000
  05077274  mov     x1, x22
  05077278  mov     x3, xzr
  0507727c  ldr     x8, [x8, #0x1e8]  ; MMETH Method$VL.FaceSystem.VLActorFaceModel.<>c.<Setup>b__36_3()
  05077280  mov     x21, x0
  05077284  ldr     x2, [x8]
  05077288  bl      #0x42e5d18  ; -> System.Func<object, int, ValueTuple<object, int>>$$.ctor
  0507728c  ldr     x8, [x26]
  05077290  mov     x1, x21
  05077294  ldr     x0, [x8, #0xb8]
  05077298  str     x21, [x0, #0x20]!
  0507729c  bl      #0x2673d60
  050772a0  ldr     x2, [x24]
  050772a4  mov     x0, x20
  050772a8  mov     x1, x21
  050772ac  bl      #0x2abcd70  ; -> System.Linq.Enumerable$$Select<object, ValueTuple<object, int>>
  050772b0  ldr     x8, [x26]
  050772b4  mov     x20, x0
  050772b8  ldr     w9, [x8, #0xe4]
  050772bc  cbnz    w9, #0x50772cc
  050772c0  mov     x0, x8
  050772c4  bl      #0x2673f30
  050772c8  ldr     x8, [x26]
  050772cc  ldr     x9, [x8, #0xb8]
  050772d0  adrp    x23, #0x54fa000
  050772d4  ldr     x21, [x9, #0x28]
  050772d8  ldr     x23, [x23, #0x188]  ; MMETH Method$System.Linq.Enumerable.GroupBy<ValueTuple<string, int>, string>()
  050772dc  cbnz    x21, #0x507733c
  050772e0  ldr     w10, [x8, #0xe4]
  050772e4  cbnz    w10, #0x50772f8
  050772e8  mov     x0, x8
  050772ec  bl      #0x2673f30
  050772f0  ldr     x8, [x26]
  050772f4  ldr     x9, [x8, #0xb8]
  050772f8  adrp    x8, #0x54fa000
  050772fc  ldr     x8, [x8, #0x1b0]  ; META System.Func<ValueTuple<string, int>, string>_TypeInfo
  05077300  ldr     x22, [x9]
  05077304  ldr     x0, [x8]
  05077308  bl      #0x267404c
  0507730c  adrp    x8, #0x54fa000
  05077310  mov     x1, x22
  05077314  mov     x3, xzr
  05077318  ldr     x8, [x8, #0x1f0]  ; MMETH Method$VL.FaceSystem.VLActorFaceModel.<>c.<Setup>b__36_4()
  0507731c  mov     x21, x0
  05077320  ldr     x2, [x8]
  05077324  bl      #0x42d6bac  ; -> System.Func<ValueTuple<object, int>, object>$$.ctor
  05077328  ldr     x8, [x26]
  0507732c  mov     x1, x21
  05077330  ldr     x0, [x8, #0xb8]
  05077334  str     x21, [x0, #0x28]!
  05077338  bl      #0x2673d60
  0507733c  ldr     x2, [x23]
  05077340  mov     x0, x20
  05077344  mov     x1, x21
  05077348  bl      #0x2ab986c  ; -> System.Linq.Enumerable$$GroupBy<ValueTuple<object, int>, object>
  0507734c  ldr     x8, [x26]
  05077350  mov     x20, x0
  05077354  ldr     w9, [x8, #0xe4]
  05077358  cbnz    w9, #0x5077368
  0507735c  mov     x0, x8
  05077360  bl      #0x2673f30
  05077364  ldr     x8, [x26]
  05077368  ldr     x9, [x8, #0xb8]
  0507736c  ldr     x21, [x9, #0x30]
  05077370  cbnz    x21, #0x50773d4
  05077374  ldr     w10, [x8, #0xe4]
  05077378  cbnz    w10, #0x507738c
  0507737c  mov     x0, x8
  05077380  bl      #0x2673f30
  05077384  ldr     x8, [x26]
  05077388  ldr     x9, [x8, #0xb8]
  0507738c  adrp    x8, #0x54fa000
  05077390  ldr     x8, [x8, #0x1c0]  ; META System.Func<IGrouping<string, ValueTuple<string, int>>, string>_TypeInfo
  05077394  ldr     x22, [x9]
  05077398  ldr     x0, [x8]
  0507739c  bl      #0x267404c
  050773a0  adrp    x8, #0x54fa000
  050773a4  mov     x1, x22
  050773a8  mov     x3, xzr
  050773ac  ldr     x8, [x8, #0x1f8]  ; MMETH Method$VL.FaceSystem.VLActorFaceModel.<>c.<Setup>b__36_5()
  050773b0  mov     x21, x0
  050773b4  ldr     x2, [x8]
  050773b8  bl      #0x42e1ec0  ; -> System.Func<object, object>$$.ctor
  050773bc  ldr     x8, [x26]
  050773c0  mov     x1, x21
  050773c4  ldr     x0, [x8, #0xb8]
  050773c8  str     x21, [x0, #0x30]!
  050773cc  bl      #0x2673d60
  050773d0  ldr     x8, [x26]
  050773d4  ldr     w9, [x8, #0xe4]
  050773d8  cbnz    w9, #0x50773e8
  050773dc  mov     x0, x8
  050773e0  bl      #0x2673f30
  050773e4  ldr     x8, [x26]
  050773e8  ldr     x9, [x8, #0xb8]
  050773ec  adrp    x24, #0x54fa000
  050773f0  ldr     x22, [x9, #0x40]
  050773f4  ldr     x24, [x24, #0x198]  ; MMETH Method$System.Linq.Enumerable.ToDictionary<IGrouping<string, ValueTuple<string, int>>, string, int[]>()
  050773f8  cbnz    x22, #0x5077458
  050773fc  ldr     w10, [x8, #0xe4]
  05077400  cbnz    w10, #0x5077414
  05077404  mov     x0, x8
  05077408  bl      #0x2673f30
  0507740c  ldr     x8, [x26]
  05077410  ldr     x9, [x8, #0xb8]
  05077414  adrp    x8, #0x54fa000
  05077418  ldr     x8, [x8, #0x1b8]  ; META System.Func<IGrouping<string, ValueTuple<string, int>>, int[]>_TypeInfo
  0507741c  ldr     x23, [x9]
  05077420  ldr     x0, [x8]
  05077424  bl      #0x267404c
  05077428  adrp    x8, #0x54fa000
  0507742c  mov     x1, x23
  05077430  mov     x3, xzr
  05077434  ldr     x8, [x8, #0x200]  ; MMETH Method$VL.FaceSystem.VLActorFaceModel.<>c.<Setup>b__36_6()
  05077438  mov     x22, x0
  0507743c  ldr     x2, [x8]
  05077440  bl      #0x42e1ec0  ; -> System.Func<object, object>$$.ctor
  05077444  ldr     x8, [x26]
  05077448  mov     x1, x22
  0507744c  ldr     x0, [x8, #0xb8]
  05077450  str     x22, [x0, #0x40]!
  05077454  bl      #0x2673d60
  05077458  ldr     x3, [x24]
  0507745c  mov     x0, x20
  05077460  mov     x1, x21
  05077464  mov     x2, x22
  05077468  bl      #0x2ac3d44  ; -> System.Linq.Enumerable$$ToDictionary<object, object, object>
  0507746c  mov     x1, x0
  05077470  str     x0, [x19, #0x388]
  05077474  add     x0, x19, #0x388
  05077478  bl      #0x2673d60
  0507747c  mov     x0, x19
  05077480  bl      #0x50775e8  ; -> VL.FaceSystem.VLActorFaceModel$$SetupBindVertices
  05077484  ldp     x20, x19, [sp, #0x90]
  05077488  ldp     x22, x21, [sp, #0x80]
  0507748c  ldp     x24, x23, [sp, #0x70]
  05077490  ldp     x26, x25, [sp, #0x60]
  05077494  ldp     x28, x27, [sp, #0x50]
  05077498  ldp     x29, x30, [sp, #0x40]
  0507749c  add     sp, sp, #0xa0
  050774a0  ret
=== VL.Animation.MotionLayerPlayable$$OnPlayableDestroy @ 0x5083fe0 (60 insns)
    void VL_Animation_MotionLayerPlayable__OnPlayableDestroy (VL_Animation_MotionLayerPlayable_o* __this, UnityEngine_Playables_Playable_o playable, const MethodInfo* method);
  05083fe0  str     x30, [sp, #-0x40]!
  05083fe4  stp     x24, x23, [sp, #0x10]
  05083fe8  stp     x22, x21, [sp, #0x20]
  05083fec  stp     x20, x19, [sp, #0x30]
  05083ff0  adrp    x23, #0x5818000
  05083ff4  adrp    x24, #0x54fa000
  05083ff8  adrp    x22, #0x54fa000
  05083ffc  ldrb    w8, [x23, #0x9ab]
  05084000  ldr     x24, [x24, #0x8f8]  ; MMETH Method$UnityEngine.Playables.PlayableExtensions.DisconnectInput<Playable>()
  05084004  b       #0x5089d1c
  05084008  mov     x20, x2
  0508400c  mov     x21, x1
  05084010  mov     x19, x0
  05084014  tbnz    w8, #0, #0x5084044
  05084018  adrp    x0, #0x54fa000
  0508401c  ldr     x0, [x0, #0x8b0]  ; MMETH Method$UnityEngine.Playables.PlayableExtensions.Destroy<AnimationMixerPlayable>()
  05084020  bl      #0x2673db4
  05084024  adrp    x0, #0x54fa000
  05084028  ldr     x0, [x0, #0x900]  ; MMETH Method$UnityEngine.Playables.PlayableExtensions.Destroy<ScriptPlayable<MotionClipPlayable>>()
  0508402c  bl      #0x2673db4
  05084030  adrp    x0, #0x54fa000
  05084034  ldr     x0, [x0, #0x8f8]  ; MMETH Method$UnityEngine.Playables.PlayableExtensions.DisconnectInput<Playable>()
  05084038  bl      #0x2673db4
  0508403c  mov     w8, #1
  05084040  strb    w8, [x23, #0x9ab]
  05084044  ldr     x3, [x24]
  05084048  mov     x0, x21
  0508404c  mov     x1, x20
  05084050  mov     w2, wzr
  05084054  bl      #0x2b9cf04  ; -> UnityEngine.Playables.PlayableExtensions$$DisconnectInput<Playable>
  05084058  ldp     x0, x1, [x19, #0x20]
  0508405c  ldr     x2, [x22]  ; STR "VLSRP Render Target Blur"
  05084060  bl      #0x2b9cb14  ; -> UnityEngine.Playables.PlayableExtensions$$Destroy<AnimationMixerPlayable>
  05084064  ldr     x8, [x19, #0x30]
  05084068  cbz     x8, #0x50840b4
  0508406c  adrp    x20, #0x54fa000
  05084070  mov     x9, xzr
  05084074  mov     x21, xzr
  05084078  ldr     x20, [x20, #0x900]  ; MMETH Method$UnityEngine.Playables.PlayableExtensions.Destroy<ScriptPlayable<MotionClipPlayable>>()
  0508407c  ldr     w10, [x8, #0x18]
  05084080  cmp     x21, w10, sxtw
  05084084  b.ge    #0x50840b8
  05084088  cmp     x21, x10
  0508408c  b.hs    #0x50840cc
  05084090  add     x8, x8, x9
  05084094  ldr     x2, [x20]
  05084098  add     x22, x9, #0x10
  0508409c  ldp     x0, x1, [x8, #0x20]
  050840a0  add     x21, x21, #1
  050840a4  bl      #0x2b9ca7c  ; -> UnityEngine.Playables.PlayableExtensions$$Destroy<ScriptPlayable<object>>
  050840a8  ldr     x8, [x19, #0x30]
  050840ac  mov     x9, x22
  050840b0  cbnz    x8, #0x508407c
  050840b4  bl      #0x267405c
  050840b8  ldp     x20, x19, [sp, #0x30]
  050840bc  ldp     x22, x21, [sp, #0x20]
  050840c0  ldp     x24, x23, [sp, #0x10]
  050840c4  ldr     x30, [sp], #0x40
  050840c8  ret
  050840cc  bl      #0x2674064

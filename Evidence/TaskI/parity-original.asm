=== Campus.Timeline.CampusLightTrack$$GatherPropertiesLight @ 0xdd4f748 (413 insns)
    void Campus_Timeline_CampusLightTrack__GatherPropertiesLight (Campus_Timeline_CampusLightTrack_o* __this, UnityEngine_Timeline_IPropertyCollector_o* driver, Campus_Common_CampusLightAnchor_o* lightAnchor, const MethodInfo* method);
  0dd4f748  str     x30, [sp, #-0x40]!
  0dd4f74c  stp     x24, x23, [sp, #0x10]
  0dd4f750  stp     x22, x21, [sp, #0x20]
  0dd4f754  stp     x20, x19, [sp, #0x30]
  0dd4f758  adrp    x22, #0xf43b000
  0dd4f75c  adrp    x21, #0xea65000
  0dd4f760  mov     x20, x2
  0dd4f764  ldrb    w8, [x22, #0x931]
  0dd4f768  ldr     x21, [x21, #0x718]  ; META UnityEngine.Object_TypeInfo
  0dd4f76c  mov     x19, x1
  0dd4f770  tbnz    w8, #0, #0xdd4f800
  0dd4f774  adrp    x0, #0xebc3000
  0dd4f778  ldr     x0, [x0, #0x940]  ; MMETH Method$UnityEngine.Timeline.IPropertyCollector.AddFromName<Light>()
  0dd4f77c  bl      #0x63cee78
  0dd4f780  adrp    x0, #0xea65000
  0dd4f784  ldr     x0, [x0, #0x718]  ; META UnityEngine.Object_TypeInfo
  0dd4f788  bl      #0x63cee78
  0dd4f78c  adrp    x0, #0xebc3000
  0dd4f790  ldr     x0, [x0, #0x948]  ; STR "m_Shadows.m_Type"
  0dd4f794  bl      #0x63cee78
  0dd4f798  adrp    x0, #0xebc3000
  0dd4f79c  ldr     x0, [x0, #0x950]  ; STR "m_Color"
  0dd4f7a0  bl      #0x63cee78
  0dd4f7a4  adrp    x0, #0xebc3000
  0dd4f7a8  ldr     x0, [x0, #0x958]  ; STR "m_Range"
  0dd4f7ac  bl      #0x63cee78
  0dd4f7b0  adrp    x0, #0xebc3000
  0dd4f7b4  ldr     x0, [x0, #0x960]  ; STR "m_ColorTemperature"
  0dd4f7b8  bl      #0x63cee78
  0dd4f7bc  adrp    x0, #0xebc3000
  0dd4f7c0  ldr     x0, [x0, #0x968]  ; STR "m_Shadows.m_Strength"
  0dd4f7c4  bl      #0x63cee78
  0dd4f7c8  adrp    x0, #0xebc3000
  0dd4f7cc  ldr     x0, [x0, #0x970]  ; STR "m_InnerSpotAngle"
  0dd4f7d0  bl      #0x63cee78
  0dd4f7d4  adrp    x0, #0xebc3000
  0dd4f7d8  ldr     x0, [x0, #0x978]  ; STR "m_UseColorTemperature"
  0dd4f7dc  bl      #0x63cee78
  0dd4f7e0  adrp    x0, #0xebc3000
  0dd4f7e4  ldr     x0, [x0, #0x980]  ; STR "m_SpotAngle"
  0dd4f7e8  bl      #0x63cee78
  0dd4f7ec  adrp    x0, #0xebc3000
  0dd4f7f0  ldr     x0, [x0, #0x988]  ; STR "m_Intensity"
  0dd4f7f4  bl      #0x63cee78
  0dd4f7f8  mov     w8, #1
  0dd4f7fc  strb    w8, [x22, #0x931]
  0dd4f800  ldr     x0, [x21]
  0dd4f804  ldr     w8, [x0, #0xe4]
  0dd4f808  cbnz    w8, #0xdd4f810
  0dd4f80c  bl      #0x63ceff4
  0dd4f810  mov     x0, x20
  0dd4f814  mov     x1, xzr
  0dd4f818  mov     x2, xzr
  0dd4f81c  bl      #0xd9de99c  ; -> UnityEngine.Object$$op_Equality
  0dd4f820  tbnz    w0, #0, #0xdd4f854
  0dd4f824  cbz     x19, #0xdd4f854
  0dd4f828  cbz     x20, #0xdd4fdb8
  0dd4f82c  ldr     x0, [x21]
  0dd4f830  ldr     x20, [x20, #0x20]
  0dd4f834  ldr     w8, [x0, #0xe4]
  0dd4f838  cbnz    w8, #0xdd4f840
  0dd4f83c  bl      #0x63ceff4
  0dd4f840  mov     x0, x20
  0dd4f844  mov     x1, xzr
  0dd4f848  mov     x2, xzr
  0dd4f84c  bl      #0xd9de99c  ; -> UnityEngine.Object$$op_Equality
  0dd4f850  tbz     w0, #0, #0xdd4f868
  0dd4f854  ldp     x20, x19, [sp, #0x30]
  0dd4f858  ldp     x22, x21, [sp, #0x20]
  0dd4f85c  ldp     x24, x23, [sp, #0x10]
  0dd4f860  ldr     x30, [sp], #0x40
  0dd4f864  ret
  0dd4f868  cbz     x20, #0xdd4fdb8
  0dd4f86c  mov     x0, x20
  0dd4f870  mov     x1, xzr
  0dd4f874  bl      #0xd9d7914  ; -> UnityEngine.Component$$get_gameObject
  0dd4f878  adrp    x24, #0xebc3000
  0dd4f87c  adrp    x10, #0xebc3000
  0dd4f880  mov     x22, x0
  0dd4f884  ldr     x24, [x24, #0x940]  ; MMETH Method$UnityEngine.Timeline.IPropertyCollector.AddFromName<Light>()
  0dd4f888  ldr     x8, [x19]
  0dd4f88c  ldr     x23, [x24]
  0dd4f890  ldr     x10, [x10, #0x988]  ; STR "m_Intensity"
  0dd4f894  ldrh    w9, [x8, #0x12e]
  0dd4f898  ldr     x21, [x10]
  0dd4f89c  ldr     x1, [x23, #0x20]
  0dd4f8a0  ldrh    w2, [x23, #0x50]
  0dd4f8a4  cbz     x9, #0xdd4f8c8
  0dd4f8a8  ldr     x10, [x8, #0xb0]
  0dd4f8ac  add     x10, x10, #8
  0dd4f8b0  ldur    x11, [x10, #-8]
  0dd4f8b4  cmp     x11, x1
  0dd4f8b8  b.eq    #0xdd4f8d4
  0dd4f8bc  subs    x9, x9, #1
  0dd4f8c0  add     x10, x10, #0x10
  0dd4f8c4  b.ne    #0xdd4f8b0
  0dd4f8c8  mov     x0, x19
  0dd4f8cc  bl      #0x6408234
  0dd4f8d0  b       #0xdd4f8e4
  0dd4f8d4  ldr     w9, [x10]
  0dd4f8d8  add     w9, w9, w2
  0dd4f8dc  add     x8, x8, w9, sxtw #4
  0dd4f8e0  add     x0, x8, #0x138
  0dd4f8e4  ldr     x0, [x0, #8]
  0dd4f8e8  mov     x1, x23
  0dd4f8ec  bl      #0x63ceff0
  0dd4f8f0  ldr     x8, [x0, #8]
  0dd4f8f4  mov     x3, x0
  0dd4f8f8  mov     x0, x19
  0dd4f8fc  mov     x1, x22
  0dd4f900  mov     x2, x21
  0dd4f904  blr     x8
  0dd4f908  mov     x0, x20
  0dd4f90c  mov     x1, xzr
  0dd4f910  bl      #0xd9d7914  ; -> UnityEngine.Component$$get_gameObject
  0dd4f914  adrp    x10, #0xebc3000
  0dd4f918  ldr     x8, [x19]
  0dd4f91c  ldr     x23, [x24]
  0dd4f920  ldr     x10, [x10, #0x950]  ; STR "m_Color"
  0dd4f924  mov     x22, x0
  0dd4f928  ldrh    w9, [x8, #0x12e]
  0dd4f92c  ldr     x1, [x23, #0x20]
  0dd4f930  ldrh    w2, [x23, #0x50]
  0dd4f934  ldr     x21, [x10]
  0dd4f938  cbz     x9, #0xdd4f95c
  0dd4f93c  ldr     x10, [x8, #0xb0]
  0dd4f940  add     x10, x10, #8
  0dd4f944  ldur    x11, [x10, #-8]
  0dd4f948  cmp     x11, x1
  0dd4f94c  b.eq    #0xdd4f968
  0dd4f950  subs    x9, x9, #1
  0dd4f954  add     x10, x10, #0x10
  0dd4f958  b.ne    #0xdd4f944
  0dd4f95c  mov     x0, x19
  0dd4f960  bl      #0x6408234
  0dd4f964  b       #0xdd4f978
  0dd4f968  ldr     w9, [x10]
  0dd4f96c  add     w9, w9, w2
  0dd4f970  add     x8, x8, w9, sxtw #4
  0dd4f974  add     x0, x8, #0x138
  0dd4f978  ldr     x0, [x0, #8]
  0dd4f97c  mov     x1, x23
  0dd4f980  bl      #0x63ceff0
  0dd4f984  ldr     x8, [x0, #8]
  0dd4f988  mov     x3, x0
  0dd4f98c  mov     x0, x19
  0dd4f990  mov     x1, x22
  0dd4f994  mov     x2, x21
  0dd4f998  blr     x8
  0dd4f99c  mov     x0, x20
  0dd4f9a0  mov     x1, xzr
  0dd4f9a4  bl      #0xd9d7914  ; -> UnityEngine.Component$$get_gameObject
  0dd4f9a8  adrp    x10, #0xebc3000
  0dd4f9ac  ldr     x8, [x19]
  0dd4f9b0  ldr     x23, [x24]
  0dd4f9b4  ldr     x10, [x10, #0x960]  ; STR "m_ColorTemperature"
  0dd4f9b8  mov     x22, x0
  0dd4f9bc  ldrh    w9, [x8, #0x12e]
  0dd4f9c0  ldr     x1, [x23, #0x20]
  0dd4f9c4  ldrh    w2, [x23, #0x50]
  0dd4f9c8  ldr     x21, [x10]
  0dd4f9cc  cbz     x9, #0xdd4f9f0
  0dd4f9d0  ldr     x10, [x8, #0xb0]
  0dd4f9d4  add     x10, x10, #8
  0dd4f9d8  ldur    x11, [x10, #-8]
  0dd4f9dc  cmp     x11, x1
  0dd4f9e0  b.eq    #0xdd4f9fc
  0dd4f9e4  subs    x9, x9, #1
  0dd4f9e8  add     x10, x10, #0x10
  0dd4f9ec  b.ne    #0xdd4f9d8
  0dd4f9f0  mov     x0, x19
  0dd4f9f4  bl      #0x6408234
  0dd4f9f8  b       #0xdd4fa0c
  0dd4f9fc  ldr     w9, [x10]
  0dd4fa00  add     w9, w9, w2
  0dd4fa04  add     x8, x8, w9, sxtw #4
  0dd4fa08  add     x0, x8, #0x138
  0dd4fa0c  ldr     x0, [x0, #8]
  0dd4fa10  mov     x1, x23
  0dd4fa14  bl      #0x63ceff0
  0dd4fa18  ldr     x8, [x0, #8]
  0dd4fa1c  mov     x3, x0
  0dd4fa20  mov     x0, x19
  0dd4fa24  mov     x1, x22
  0dd4fa28  mov     x2, x21
  0dd4fa2c  blr     x8
  0dd4fa30  mov     x0, x20
  0dd4fa34  mov     x1, xzr
  0dd4fa38  bl      #0xd9d7914  ; -> UnityEngine.Component$$get_gameObject
  0dd4fa3c  adrp    x10, #0xebc3000
  0dd4fa40  ldr     x8, [x19]
  0dd4fa44  ldr     x23, [x24]
  0dd4fa48  ldr     x10, [x10, #0x958]  ; STR "m_Range"
  0dd4fa4c  mov     x22, x0
  0dd4fa50  ldrh    w9, [x8, #0x12e]
  0dd4fa54  ldr     x1, [x23, #0x20]
  0dd4fa58  ldrh    w2, [x23, #0x50]
  0dd4fa5c  ldr     x21, [x10]
  0dd4fa60  cbz     x9, #0xdd4fa84
  0dd4fa64  ldr     x10, [x8, #0xb0]
  0dd4fa68  add     x10, x10, #8
  0dd4fa6c  ldur    x11, [x10, #-8]
  0dd4fa70  cmp     x11, x1
  0dd4fa74  b.eq    #0xdd4fa90
  0dd4fa78  subs    x9, x9, #1
  0dd4fa7c  add     x10, x10, #0x10
  0dd4fa80  b.ne    #0xdd4fa6c
  0dd4fa84  mov     x0, x19
  0dd4fa88  bl      #0x6408234
  0dd4fa8c  b       #0xdd4faa0
  0dd4fa90  ldr     w9, [x10]
  0dd4fa94  add     w9, w9, w2
  0dd4fa98  add     x8, x8, w9, sxtw #4
  0dd4fa9c  add     x0, x8, #0x138
  0dd4faa0  ldr     x0, [x0, #8]
  0dd4faa4  mov     x1, x23
  0dd4faa8  bl      #0x63ceff0
  0dd4faac  ldr     x8, [x0, #8]
  0dd4fab0  mov     x3, x0
  0dd4fab4  mov     x0, x19
  0dd4fab8  mov     x1, x22
  0dd4fabc  mov     x2, x21
  0dd4fac0  blr     x8
  0dd4fac4  mov     x0, x20
  0dd4fac8  mov     x1, xzr
  0dd4facc  bl      #0xd9d7914  ; -> UnityEngine.Component$$get_gameObject
  0dd4fad0  adrp    x10, #0xebc3000
  0dd4fad4  ldr     x8, [x19]
  0dd4fad8  ldr     x23, [x24]
  0dd4fadc  ldr     x10, [x10, #0x978]  ; STR "m_UseColorTemperature"
  0dd4fae0  mov     x22, x0
  0dd4fae4  ldrh    w9, [x8, #0x12e]
  0dd4fae8  ldr     x1, [x23, #0x20]
  0dd4faec  ldrh    w2, [x23, #0x50]
  0dd4faf0  ldr     x21, [x10]
  0dd4faf4  cbz     x9, #0xdd4fb18
  0dd4faf8  ldr     x10, [x8, #0xb0]
  0dd4fafc  add     x10, x10, #8
  0dd4fb00  ldur    x11, [x10, #-8]
  0dd4fb04  cmp     x11, x1
  0dd4fb08  b.eq    #0xdd4fb24
  0dd4fb0c  subs    x9, x9, #1
  0dd4fb10  add     x10, x10, #0x10
  0dd4fb14  b.ne    #0xdd4fb00
  0dd4fb18  mov     x0, x19
  0dd4fb1c  bl      #0x6408234
  0dd4fb20  b       #0xdd4fb34
  0dd4fb24  ldr     w9, [x10]
  0dd4fb28  add     w9, w9, w2
  0dd4fb2c  add     x8, x8, w9, sxtw #4
  0dd4fb30  add     x0, x8, #0x138
  0dd4fb34  ldr     x0, [x0, #8]
  0dd4fb38  mov     x1, x23
  0dd4fb3c  bl      #0x63ceff0
  0dd4fb40  ldr     x8, [x0, #8]
  0dd4fb44  mov     x3, x0
  0dd4fb48  mov     x0, x19
  0dd4fb4c  mov     x1, x22
  0dd4fb50  mov     x2, x21
  0dd4fb54  blr     x8
  0dd4fb58  mov     x0, x20
  0dd4fb5c  mov     x1, xzr
  0dd4fb60  bl      #0xd9d7914  ; -> UnityEngine.Component$$get_gameObject
  0dd4fb64  adrp    x10, #0xebc3000
  0dd4fb68  ldr     x8, [x19]
  0dd4fb6c  ldr     x23, [x24]
  0dd4fb70  ldr     x10, [x10, #0x948]  ; STR "m_Shadows.m_Type"
  0dd4fb74  mov     x22, x0
  0dd4fb78  ldrh    w9, [x8, #0x12e]
  0dd4fb7c  ldr     x1, [x23, #0x20]
  0dd4fb80  ldrh    w2, [x23, #0x50]
  0dd4fb84  ldr     x21, [x10]
  0dd4fb88  cbz     x9, #0xdd4fbac
  0dd4fb8c  ldr     x10, [x8, #0xb0]
  0dd4fb90  add     x10, x10, #8
  0dd4fb94  ldur    x11, [x10, #-8]
  0dd4fb98  cmp     x11, x1
  0dd4fb9c  b.eq    #0xdd4fbb8
  0dd4fba0  subs    x9, x9, #1
  0dd4fba4  add     x10, x10, #0x10
  0dd4fba8  b.ne    #0xdd4fb94
  0dd4fbac  mov     x0, x19
  0dd4fbb0  bl      #0x6408234
  0dd4fbb4  b       #0xdd4fbc8
  0dd4fbb8  ldr     w9, [x10]
  0dd4fbbc  add     w9, w9, w2
  0dd4fbc0  add     x8, x8, w9, sxtw #4
  0dd4fbc4  add     x0, x8, #0x138
  0dd4fbc8  ldr     x0, [x0, #8]
  0dd4fbcc  mov     x1, x23
  0dd4fbd0  bl      #0x63ceff0
  0dd4fbd4  ldr     x8, [x0, #8]
  0dd4fbd8  mov     x3, x0
  0dd4fbdc  mov     x0, x19
  0dd4fbe0  mov     x1, x22
  0dd4fbe4  mov     x2, x21
  0dd4fbe8  blr     x8
  0dd4fbec  mov     x0, x20
  0dd4fbf0  mov     x1, xzr
  0dd4fbf4  bl      #0xd9d7914  ; -> UnityEngine.Component$$get_gameObject
  0dd4fbf8  adrp    x10, #0xebc3000
  0dd4fbfc  ldr     x8, [x19]
  0dd4fc00  ldr     x23, [x24]
  0dd4fc04  ldr     x10, [x10, #0x968]  ; STR "m_Shadows.m_Strength"
  0dd4fc08  mov     x22, x0
  0dd4fc0c  ldrh    w9, [x8, #0x12e]
  0dd4fc10  ldr     x1, [x23, #0x20]
  0dd4fc14  ldrh    w2, [x23, #0x50]
  0dd4fc18  ldr     x21, [x10]
  0dd4fc1c  cbz     x9, #0xdd4fc40
  0dd4fc20  ldr     x10, [x8, #0xb0]
  0dd4fc24  add     x10, x10, #8
  0dd4fc28  ldur    x11, [x10, #-8]
  0dd4fc2c  cmp     x11, x1
  0dd4fc30  b.eq    #0xdd4fc4c
  0dd4fc34  subs    x9, x9, #1
  0dd4fc38  add     x10, x10, #0x10
  0dd4fc3c  b.ne    #0xdd4fc28
  0dd4fc40  mov     x0, x19
  0dd4fc44  bl      #0x6408234
  0dd4fc48  b       #0xdd4fc5c
  0dd4fc4c  ldr     w9, [x10]
  0dd4fc50  add     w9, w9, w2
  0dd4fc54  add     x8, x8, w9, sxtw #4
  0dd4fc58  add     x0, x8, #0x138
  0dd4fc5c  ldr     x0, [x0, #8]
  0dd4fc60  mov     x1, x23
  0dd4fc64  bl      #0x63ceff0
  0dd4fc68  ldr     x8, [x0, #8]
  0dd4fc6c  mov     x3, x0
  0dd4fc70  mov     x0, x19
  0dd4fc74  mov     x1, x22
  0dd4fc78  mov     x2, x21
  0dd4fc7c  blr     x8
  0dd4fc80  mov     x0, x20
  0dd4fc84  mov     x1, xzr
  0dd4fc88  bl      #0xd9d7914  ; -> UnityEngine.Component$$get_gameObject
  0dd4fc8c  adrp    x10, #0xebc3000
  0dd4fc90  ldr     x8, [x19]
  0dd4fc94  ldr     x23, [x24]
  0dd4fc98  ldr     x10, [x10, #0x980]  ; STR "m_SpotAngle"
  0dd4fc9c  mov     x22, x0
  0dd4fca0  ldrh    w9, [x8, #0x12e]
  0dd4fca4  ldr     x1, [x23, #0x20]
  0dd4fca8  ldrh    w2, [x23, #0x50]
  0dd4fcac  ldr     x21, [x10]
  0dd4fcb0  cbz     x9, #0xdd4fcd4
  0dd4fcb4  ldr     x10, [x8, #0xb0]
  0dd4fcb8  add     x10, x10, #8
  0dd4fcbc  ldur    x11, [x10, #-8]
  0dd4fcc0  cmp     x11, x1
  0dd4fcc4  b.eq    #0xdd4fce0
  0dd4fcc8  subs    x9, x9, #1
  0dd4fccc  add     x10, x10, #0x10
  0dd4fcd0  b.ne    #0xdd4fcbc
  0dd4fcd4  mov     x0, x19
  0dd4fcd8  bl      #0x6408234
  0dd4fcdc  b       #0xdd4fcf0
  0dd4fce0  ldr     w9, [x10]
  0dd4fce4  add     w9, w9, w2
  0dd4fce8  add     x8, x8, w9, sxtw #4
  0dd4fcec  add     x0, x8, #0x138
  0dd4fcf0  ldr     x0, [x0, #8]
  0dd4fcf4  mov     x1, x23
  0dd4fcf8  bl      #0x63ceff0
  0dd4fcfc  ldr     x8, [x0, #8]
  0dd4fd00  mov     x3, x0
  0dd4fd04  mov     x0, x19
  0dd4fd08  mov     x1, x22
  0dd4fd0c  mov     x2, x21
  0dd4fd10  blr     x8
  0dd4fd14  mov     x0, x20
  0dd4fd18  mov     x1, xzr
  0dd4fd1c  bl      #0xd9d7914  ; -> UnityEngine.Component$$get_gameObject
  0dd4fd20  adrp    x10, #0xebc3000
  0dd4fd24  ldr     x8, [x19]
  0dd4fd28  ldr     x22, [x24]
  0dd4fd2c  ldr     x10, [x10, #0x970]  ; STR "m_InnerSpotAngle"
  0dd4fd30  mov     x21, x0
  0dd4fd34  ldrh    w9, [x8, #0x12e]
  0dd4fd38  ldr     x1, [x22, #0x20]
  0dd4fd3c  ldrh    w2, [x22, #0x50]
  0dd4fd40  ldr     x20, [x10]
  0dd4fd44  cbz     x9, #0xdd4fd68
  0dd4fd48  ldr     x10, [x8, #0xb0]
  0dd4fd4c  add     x10, x10, #8
  0dd4fd50  ldur    x11, [x10, #-8]
  0dd4fd54  cmp     x11, x1
  0dd4fd58  b.eq    #0xdd4fd74
  0dd4fd5c  subs    x9, x9, #1
  0dd4fd60  add     x10, x10, #0x10
  0dd4fd64  b.ne    #0xdd4fd50
  0dd4fd68  mov     x0, x19
  0dd4fd6c  bl      #0x6408234
  0dd4fd70  b       #0xdd4fd84
  0dd4fd74  ldr     w9, [x10]
  0dd4fd78  add     w9, w9, w2
  0dd4fd7c  add     x8, x8, w9, sxtw #4
  0dd4fd80  add     x0, x8, #0x138
  0dd4fd84  ldr     x0, [x0, #8]
  0dd4fd88  mov     x1, x22
  0dd4fd8c  bl      #0x63ceff0
  0dd4fd90  mov     x3, x0
  0dd4fd94  mov     x0, x19
  0dd4fd98  mov     x1, x21
  0dd4fd9c  mov     x2, x20
  0dd4fda0  ldp     x20, x19, [sp, #0x30]
  0dd4fda4  ldp     x22, x21, [sp, #0x20]
  0dd4fda8  ldr     x4, [x3, #8]
  0dd4fdac  ldp     x24, x23, [sp, #0x10]
  0dd4fdb0  ldr     x30, [sp], #0x40
  0dd4fdb4  br      x4
  0dd4fdb8  bl      #0x63cf120
=== Campus.Crowd.CrowdTimelineTrack$$.ctor @ 0xddcd228 (2 insns)
    void Campus_Crowd_CrowdTimelineTrack___ctor (Campus_Crowd_CrowdTimelineTrack_o* __this, const MethodInfo* method);
  0ddcd228  mov     x1, xzr
  0ddcd22c  b       #0xd9078c4  ; -> UnityEngine.Timeline.PlayableTrack$$.ctor
=== VLB.Config$$get_SD_requiresDoubleSidedMesh @ 0xe0c73b0 (7 insns)
    bool VLB_Config__get_SD_requiresDoubleSidedMesh (VLB_Config_o* __this, const MethodInfo* method);
  0e0c73b0  str     x30, [sp, #-0x10]!
  0e0c73b4  mov     w1, wzr
  0e0c73b8  bl      #0xe0c7204  ; -> VLB.Config$$GetActualRenderingMode
  0e0c73bc  cmp     w0, #0
  0e0c73c0  cset    w0, ne
  0e0c73c4  ldr     x30, [sp], #0x10
  0e0c73c8  ret
=== VLB.VolumetricLightBeamSD$$get_skewingLocalForwardDirectionNormalized @ 0xe0de9b4 (150 insns)
    UnityEngine_Vector3_o VLB_VolumetricLightBeamSD__get_skewingLocalForwardDirectionNormalized (VLB_VolumetricLightBeamSD_o* __this, const MethodInfo* method);
  0e0de9b4  str     d10, [sp, #-0x30]!
  0e0de9b8  stp     d9, d8, [sp, #8]
  0e0de9bc  str     x30, [sp, #0x18]
  0e0de9c0  stp     x20, x19, [sp, #0x20]
  0e0de9c4  adrp    x20, #0xf43d000
  0e0de9c8  mov     x19, x0
  0e0de9cc  ldrb    w8, [x20, #0xa8f]
  0e0de9d0  tbnz    w8, #0, #0xe0dea00
  0e0de9d4  adrp    x0, #0xea67000
  0e0de9d8  ldr     x0, [x0, #0x3c0]  ; META UnityEngine.Debug_TypeInfo
  0e0de9dc  bl      #0x63cee78
  0e0de9e0  adrp    x0, #0xea68000
  0e0de9e4  ldr     x0, [x0, #0x4b8]  ; META object[]_TypeInfo
  0e0de9e8  bl      #0x63cee78
  0e0de9ec  adrp    x0, #0xebd7000
  0e0de9f0  ldr     x0, [x0, #0x768]  ; STR "Beam {0} has a skewingLocalForwardDirection with a null Z, which is forbidden"
  0e0de9f4  bl      #0x63cee78
  0e0de9f8  mov     w8, #1
  0e0de9fc  strb    w8, [x20, #0xa8f]
  0e0dea00  adrp    x20, #0xf400000
  0e0dea04  ldr     s8, [x19, #0x90]
  0e0dea08  ldrb    w8, [x20, #0x9a]
  0e0dea0c  cbnz    w8, #0xe0dea24
  0e0dea10  adrp    x0, #0xea66000
  0e0dea14  ldr     x0, [x0, #0xfd8]  ; META UnityEngine.Mathf_TypeInfo
  0e0dea18  bl      #0x63cee78
  0e0dea1c  mov     w8, #1
  0e0dea20  strb    w8, [x20, #0x9a]
  0e0dea24  adrp    x8, #0xea66000
  0e0dea28  fabs    s0, s8
  0e0dea2c  movi    d1, #0000000000000000
  0e0dea30  ldr     x8, [x8, #0xfd8]  ; META UnityEngine.Mathf_TypeInfo
  0e0dea34  adrp    x9, #0x276e000
  0e0dea38  fmov    s2, #8.00000000
  0e0dea3c  ldr     s4, [x9, #0xa1c]
  0e0dea40  ldr     x8, [x8]
  0e0dea44  fmaxnm  s0, s0, s1
  0e0dea48  fabd    s1, s1, s8
  0e0dea4c  ldr     x8, [x8, #0xb8]
  0e0dea50  ldr     s3, [x8]
  0e0dea54  fmul    s0, s0, s4
  0e0dea58  fmul    s2, s3, s2
  0e0dea5c  fcmp    s0, s2
  0e0dea60  fcsel   s0, s0, s2, gt
  0e0dea64  fcmp    s1, s0
  0e0dea68  b.pl    #0xe0deb34
  0e0dea6c  adrp    x8, #0xea68000
  0e0dea70  mov     w1, #1
  0e0dea74  ldr     x8, [x8, #0x4b8]  ; META object[]_TypeInfo
  0e0dea78  ldr     x0, [x8]
  0e0dea7c  bl      #0x63cef64
  0e0dea80  mov     x20, x0
  0e0dea84  mov     x0, x19
  0e0dea88  mov     x1, xzr
  0e0dea8c  bl      #0xd9e278c  ; -> UnityEngine.Object$$get_name
  0e0dea90  cbz     x20, #0xe0debf8
  0e0dea94  mov     x19, x0
  0e0dea98  cbz     x0, #0xe0deab0
  0e0dea9c  ldr     x8, [x20]
  0e0deaa0  mov     x0, x19
  0e0deaa4  ldr     x1, [x8, #0x40]
  0e0deaa8  bl      #0x63ceff8
  0e0deaac  cbz     x0, #0xe0dec00
  0e0deab0  ldr     w8, [x20, #0x18]
  0e0deab4  cbz     w8, #0xe0debfc
  0e0deab8  mov     x0, x20
  0e0deabc  mov     x1, x19
  0e0deac0  str     x19, [x0, #0x20]!
  0e0deac4  bl      #0x63cee24
  0e0deac8  adrp    x8, #0xea67000
  0e0deacc  ldr     x8, [x8, #0x3c0]  ; META UnityEngine.Debug_TypeInfo
  0e0dead0  ldr     x0, [x8]
  0e0dead4  ldr     w8, [x0, #0xe4]
  0e0dead8  cbnz    w8, #0xe0deae0
  0e0deadc  bl      #0x63ceff4
  0e0deae0  adrp    x8, #0xebd7000
  0e0deae4  mov     x1, x20
  0e0deae8  mov     x2, xzr
  0e0deaec  ldr     x8, [x8, #0x768]  ; STR "Beam {0} has a skewingLocalForwardDirection with a null Z, which is forbidden"
  0e0deaf0  ldr     x0, [x8]
  0e0deaf4  bl      #0xd973a78  ; -> UnityEngine.Debug$$LogErrorFormat
  0e0deaf8  adrp    x19, #0xf405000
  0e0deafc  ldrb    w8, [x19, #0x7c9]
  0e0deb00  cbnz    w8, #0xe0deb18
  0e0deb04  adrp    x0, #0xea67000
  0e0deb08  ldr     x0, [x0, #0x438]  ; META UnityEngine.Vector3_TypeInfo
  0e0deb0c  bl      #0x63cee78
  0e0deb10  mov     w8, #1
  0e0deb14  strb    w8, [x19, #0x7c9]
  0e0deb18  adrp    x8, #0xea67000
  0e0deb1c  ldr     x8, [x8, #0x438]  ; META UnityEngine.Vector3_TypeInfo
  0e0deb20  ldr     x8, [x8]
  0e0deb24  ldr     x8, [x8, #0xb8]
  0e0deb28  ldp     s0, s1, [x8, #0x48]
  0e0deb2c  ldr     s2, [x8, #0x50]
  0e0deb30  b       #0xe0debe4
  0e0deb34  adrp    x20, #0xf400000
  0e0deb38  ldp     s8, s9, [x19, #0x88]
  0e0deb3c  ldrb    w8, [x20, #0x430]
  0e0deb40  ldr     s10, [x19, #0x90]
  0e0deb44  cbnz    w8, #0xe0deb5c
  0e0deb48  adrp    x0, #0xea67000
  0e0deb4c  ldr     x0, [x0, #0x190]  ; META System.Math_TypeInfo
  0e0deb50  bl      #0x63cee78
  0e0deb54  mov     w8, #1
  0e0deb58  strb    w8, [x20, #0x430]
  0e0deb5c  adrp    x8, #0xea67000
  0e0deb60  ldr     x8, [x8, #0x190]  ; META System.Math_TypeInfo
  0e0deb64  ldr     x0, [x8]
  0e0deb68  ldr     w8, [x0, #0xe4]
  0e0deb6c  cbnz    w8, #0xe0deb74
  0e0deb70  bl      #0x63ceff4
  0e0deb74  fmul    s0, s8, s8
  0e0deb78  fmul    s1, s9, s9
  0e0deb7c  adrp    x8, #0x276e000
  0e0deb80  fadd    s0, s0, s1
  0e0deb84  fmul    s1, s10, s10
  0e0deb88  fadd    s0, s1, s0
  0e0deb8c  fsqrt   s2, s0
  0e0deb90  ldr     s0, [x8, #0xb00]
  0e0deb94  fcmp    s2, s0
  0e0deb98  b.le    #0xe0debac
  0e0deb9c  fdiv    s0, s8, s2
  0e0deba0  fdiv    s1, s9, s2
  0e0deba4  fdiv    s2, s10, s2
  0e0deba8  b       #0xe0debe4
  0e0debac  adrp    x19, #0xf400000
  0e0debb0  ldrb    w8, [x19, #0x9d]
  0e0debb4  cbnz    w8, #0xe0debcc
  0e0debb8  adrp    x0, #0xea67000
  0e0debbc  ldr     x0, [x0, #0x438]  ; META UnityEngine.Vector3_TypeInfo
  0e0debc0  bl      #0x63cee78
  0e0debc4  mov     w8, #1
  0e0debc8  strb    w8, [x19, #0x9d]
  0e0debcc  adrp    x8, #0xea67000
  0e0debd0  ldr     x8, [x8, #0x438]  ; META UnityEngine.Vector3_TypeInfo
  0e0debd4  ldr     x8, [x8]
  0e0debd8  ldr     x8, [x8, #0xb8]
  0e0debdc  ldp     s0, s1, [x8]
  0e0debe0  ldr     s2, [x8, #8]
  0e0debe4  ldp     x20, x19, [sp, #0x20]
  0e0debe8  ldr     x30, [sp, #0x18]
  0e0debec  ldp     d9, d8, [sp, #8]
  0e0debf0  ldr     d10, [sp], #0x30
  0e0debf4  ret
  0e0debf8  bl      #0x63cf120
  0e0debfc  bl      #0x63cf128
  0e0dec00  bl      #0x63cf144
  0e0dec04  mov     x1, xzr
  0e0dec08  bl      #0x63cefe4
=== VLB.VolumetricLightBeamSD$$get_additionalClippingPlane @ 0xe0ded20 (66 insns)
    UnityEngine_Vector4_o VLB_VolumetricLightBeamSD__get_additionalClippingPlane (VLB_VolumetricLightBeamSD_o* __this, const MethodInfo* method);
  0e0ded20  str     d10, [sp, #-0x40]!
  0e0ded24  stp     d9, d8, [sp, #0x10]
  0e0ded28  stp     x30, x21, [sp, #0x20]
  0e0ded2c  stp     x20, x19, [sp, #0x30]
  0e0ded30  adrp    x21, #0xf43d000
  0e0ded34  adrp    x20, #0xea65000
  0e0ded38  mov     x19, x0
  0e0ded3c  ldrb    w8, [x21, #0xa90]
  0e0ded40  ldr     x20, [x20, #0x718]  ; META UnityEngine.Object_TypeInfo
  0e0ded44  tbnz    w8, #0, #0xe0ded5c
  0e0ded48  adrp    x0, #0xea65000
  0e0ded4c  ldr     x0, [x0, #0x718]  ; META UnityEngine.Object_TypeInfo
  0e0ded50  bl      #0x63cee78
  0e0ded54  mov     w8, #1
  0e0ded58  strb    w8, [x21, #0xa90]
  0e0ded5c  ldr     x0, [x20]
  0e0ded60  ldr     x20, [x19, #0x98]
  0e0ded64  ldr     w8, [x0, #0xe4]
  0e0ded68  cbnz    w8, #0xe0ded70
  0e0ded6c  bl      #0x63ceff4
  0e0ded70  mov     x0, x20
  0e0ded74  mov     x1, xzr
  0e0ded78  mov     x2, xzr
  0e0ded7c  bl      #0xd9de99c  ; -> UnityEngine.Object$$op_Equality
  0e0ded80  tbz     w0, #0, #0xe0dedc0
  0e0ded84  adrp    x19, #0xf404000
  0e0ded88  ldrb    w8, [x19, #0x6a0]
  0e0ded8c  cbnz    w8, #0xe0deda4
  0e0ded90  adrp    x0, #0xeab1000
  0e0ded94  ldr     x0, [x0, #0xf60]  ; META UnityEngine.Vector4_TypeInfo
  0e0ded98  bl      #0x63cee78
  0e0ded9c  mov     w8, #1
  0e0deda0  strb    w8, [x19, #0x6a0]
  0e0deda4  adrp    x8, #0xeab1000
  0e0deda8  ldr     x8, [x8, #0xf60]  ; META UnityEngine.Vector4_TypeInfo
  0e0dedac  ldr     x8, [x8]
  0e0dedb0  ldr     x8, [x8, #0xb8]
  0e0dedb4  ldp     s8, s9, [x8]
  0e0dedb8  ldp     s10, s3, [x8, #8]
  0e0dedbc  b       #0xe0dee04
  0e0dedc0  ldr     x0, [x19, #0x98]
  0e0dedc4  cbz     x0, #0xe0dee24
  0e0dedc8  mov     x1, xzr
  0e0dedcc  bl      #0xd9ef84c  ; -> UnityEngine.Transform$$get_forward
  0e0dedd0  ldr     x0, [x19, #0x98]
  0e0dedd4  cbz     x0, #0xe0dee24
  0e0dedd8  mov     x1, xzr
  0e0deddc  fmov    s8, s0
  0e0dede0  fmov    s9, s1
  0e0dede4  fmov    s10, s2
  0e0dede8  bl      #0xd9eee58  ; -> UnityEngine.Transform$$get_position
  0e0dedec  fmul    s0, s8, s0
  0e0dedf0  fmul    s1, s9, s1
  0e0dedf4  fadd    s0, s0, s1
  0e0dedf8  fmul    s1, s10, s2
  0e0dedfc  fadd    s0, s1, s0
  0e0dee00  fneg    s3, s0
  0e0dee04  fmov    s0, s8
  0e0dee08  fmov    s1, s9
  0e0dee0c  fmov    s2, s10
  0e0dee10  ldp     x20, x19, [sp, #0x30]
  0e0dee14  ldp     x30, x21, [sp, #0x20]
  0e0dee18  ldp     d9, d8, [sp, #0x10]
  0e0dee1c  ldr     d10, [sp], #0x40
  0e0dee20  ret
  0e0dee24  bl      #0x63cf120
=== VL.Animation.MotionLayerPlayable$$OnPlayableDestroy @ 0xe11b3f0 (60 insns)
    void VL_Animation_MotionLayerPlayable__OnPlayableDestroy (VL_Animation_MotionLayerPlayable_o* __this, UnityEngine_Playables_Playable_o playable, const MethodInfo* method);
  0e11b3f0  str     x30, [sp, #-0x40]!
  0e11b3f4  stp     x24, x23, [sp, #0x10]
  0e11b3f8  stp     x22, x21, [sp, #0x20]
  0e11b3fc  stp     x20, x19, [sp, #0x30]
  0e11b400  adrp    x23, #0xf43d000
  0e11b404  adrp    x24, #0xeb9b000
  0e11b408  adrp    x22, #0xebd9000
  0e11b40c  ldrb    w8, [x23, #0xcdd]
  0e11b410  ldr     x24, [x24, #0x60]  ; MMETH Method$UnityEngine.Playables.PlayableExtensions.DisconnectInput<Playable>()
  0e11b414  ldr     x22, [x22, #0x380]  ; MMETH Method$UnityEngine.Playables.PlayableExtensions.Destroy<AnimationMixerPlayable>()
  0e11b418  mov     x20, x2
  0e11b41c  mov     x21, x1
  0e11b420  mov     x19, x0
  0e11b424  tbnz    w8, #0, #0xe11b454
  0e11b428  adrp    x0, #0xebd9000
  0e11b42c  ldr     x0, [x0, #0x380]  ; MMETH Method$UnityEngine.Playables.PlayableExtensions.Destroy<AnimationMixerPlayable>()
  0e11b430  bl      #0x63cee78
  0e11b434  adrp    x0, #0xebd9000
  0e11b438  ldr     x0, [x0, #0x3c8]  ; MMETH Method$UnityEngine.Playables.PlayableExtensions.Destroy<ScriptPlayable<MotionClipPlayable>>()
  0e11b43c  bl      #0x63cee78
  0e11b440  adrp    x0, #0xeb9b000
  0e11b444  ldr     x0, [x0, #0x60]  ; MMETH Method$UnityEngine.Playables.PlayableExtensions.DisconnectInput<Playable>()
  0e11b448  bl      #0x63cee78
  0e11b44c  mov     w8, #1
  0e11b450  strb    w8, [x23, #0xcdd]
  0e11b454  ldr     x3, [x24]
  0e11b458  mov     x0, x21
  0e11b45c  mov     x1, x20
  0e11b460  mov     w2, wzr
  0e11b464  bl      #0x9301e4c  ; -> UnityEngine.Playables.PlayableExtensions$$DisconnectInput<Playable>
  0e11b468  ldp     x0, x1, [x19, #0x20]
  0e11b46c  ldr     x2, [x22]
  0e11b470  bl      #0x9301a5c  ; -> UnityEngine.Playables.PlayableExtensions$$Destroy<AnimationMixerPlayable>
  0e11b474  ldr     x8, [x19, #0x30]
  0e11b478  cbz     x8, #0xe11b4c4
  0e11b47c  adrp    x20, #0xebd9000
  0e11b480  mov     x9, xzr
  0e11b484  mov     x21, xzr
  0e11b488  ldr     x20, [x20, #0x3c8]  ; MMETH Method$UnityEngine.Playables.PlayableExtensions.Destroy<ScriptPlayable<MotionClipPlayable>>()
  0e11b48c  ldr     w10, [x8, #0x18]
  0e11b490  cmp     x21, w10, sxtw
  0e11b494  b.ge    #0xe11b4c8
  0e11b498  cmp     x21, x10
  0e11b49c  b.hs    #0xe11b4dc
  0e11b4a0  add     x8, x8, x9
  0e11b4a4  ldr     x2, [x20]
  0e11b4a8  add     x22, x9, #0x10
  0e11b4ac  ldp     x0, x1, [x8, #0x20]
  0e11b4b0  add     x21, x21, #1
  0e11b4b4  bl      #0x93018a0  ; -> UnityEngine.Playables.PlayableExtensions$$Destroy<ScriptPlayable<object>>
  0e11b4b8  ldr     x8, [x19, #0x30]
  0e11b4bc  mov     x9, x22
  0e11b4c0  cbnz    x8, #0xe11b48c
  0e11b4c4  bl      #0x63cf120
  0e11b4c8  ldp     x20, x19, [sp, #0x30]
  0e11b4cc  ldp     x22, x21, [sp, #0x20]
  0e11b4d0  ldp     x24, x23, [sp, #0x10]
  0e11b4d4  ldr     x30, [sp], #0x40
  0e11b4d8  ret
  0e11b4dc  bl      #0x63cf128
=== VL.FaceSystem.VLActorFaceModel$$Setup @ 0xe12d0e4 (374 insns)
    void VL_FaceSystem_VLActorFaceModel__Setup (VL_FaceSystem_VLActorFaceModel_o* __this, const MethodInfo* method);
  0e12d0e4  sub     sp, sp, #0xa0
  0e12d0e8  stp     x29, x30, [sp, #0x40]
  0e12d0ec  stp     x28, x27, [sp, #0x50]
  0e12d0f0  stp     x26, x25, [sp, #0x60]
  0e12d0f4  stp     x24, x23, [sp, #0x70]
  0e12d0f8  stp     x22, x21, [sp, #0x80]
  0e12d0fc  stp     x20, x19, [sp, #0x90]
  0e12d100  adrp    x20, #0xf43d000
  0e12d104  adrp    x26, #0xebd9000
  0e12d108  mov     x19, x0
  0e12d10c  ldrb    w8, [x20, #0xd9f]
  0e12d110  ldr     x26, [x26, #0x970]  ; META VL.ActorMesh.VLActorSkinningSystem_TypeInfo
  0e12d114  tbnz    w8, #0, #0xe12d1f8
  0e12d118  adrp    x0, #0xebd9000
  0e12d11c  ldr     x0, [x0, #0x9d8]  ; MMETH Method$System.Linq.Enumerable.GroupBy<ValueTuple<string, int>, string>()
  0e12d120  bl      #0x63cee78
  0e12d124  adrp    x0, #0xebd9000
  0e12d128  ldr     x0, [x0, #0x9e0]  ; MMETH Method$System.Linq.Enumerable.Select<BlendShapeData, ValueTuple<string, int>>()
  0e12d12c  bl      #0x63cee78
  0e12d130  adrp    x0, #0xebd9000
  0e12d134  ldr     x0, [x0, #0x9e8]  ; MMETH Method$System.Linq.Enumerable.ToDictionary<IGrouping<string, ValueTuple<string, int>>, string, int[]>()
  0e12d138  bl      #0x63cee78
  0e12d13c  adrp    x0, #0xebd9000
  0e12d140  ldr     x0, [x0, #0x9f0]  ; MMETH Method$System.Linq.Enumerable.ToDictionary<ValueTuple<string, int>, string, int>()
  0e12d144  bl      #0x63cee78
  0e12d148  adrp    x0, #0xea8b000
  0e12d14c  ldr     x0, [x0, #0xec8]  ; META System.Func<ValueTuple<string, int>, int>_TypeInfo
  0e12d150  bl      #0x63cee78
  0e12d154  adrp    x0, #0xea8b000
  0e12d158  ldr     x0, [x0, #0xe30]  ; META System.Func<ValueTuple<string, int>, string>_TypeInfo
  0e12d15c  bl      #0x63cee78
  0e12d160  adrp    x0, #0xebd9000
  0e12d164  ldr     x0, [x0, #0x9f8]  ; META System.Func<IGrouping<string, ValueTuple<string, int>>, int[]>_TypeInfo
  0e12d168  bl      #0x63cee78
  0e12d16c  adrp    x0, #0xebd9000
  0e12d170  ldr     x0, [x0, #0xa00]  ; META System.Func<IGrouping<string, ValueTuple<string, int>>, string>_TypeInfo
  0e12d174  bl      #0x63cee78
  0e12d178  adrp    x0, #0xebd9000
  0e12d17c  ldr     x0, [x0, #0xa08]  ; META System.Func<BlendShapeData, int, ValueTuple<string, int>>_TypeInfo
  0e12d180  bl      #0x63cee78
  0e12d184  adrp    x0, #0xebd9000
  0e12d188  ldr     x0, [x0, #0xa10]  ; MMETH Method$VL.FaceSystem.VLActorFaceModel.<>c.<Setup>b__36_0()
  0e12d18c  bl      #0x63cee78
  0e12d190  adrp    x0, #0xebd9000
  0e12d194  ldr     x0, [x0, #0xa18]  ; MMETH Method$VL.FaceSystem.VLActorFaceModel.<>c.<Setup>b__36_1()
  0e12d198  bl      #0x63cee78
  0e12d19c  adrp    x0, #0xebd9000
  0e12d1a0  ldr     x0, [x0, #0xa20]  ; MMETH Method$VL.FaceSystem.VLActorFaceModel.<>c.<Setup>b__36_2()
  0e12d1a4  bl      #0x63cee78
  0e12d1a8  adrp    x0, #0xebd9000
  0e12d1ac  ldr     x0, [x0, #0xa28]  ; MMETH Method$VL.FaceSystem.VLActorFaceModel.<>c.<Setup>b__36_3()
  0e12d1b0  bl      #0x63cee78
  0e12d1b4  adrp    x0, #0xebd9000
  0e12d1b8  ldr     x0, [x0, #0xa30]  ; MMETH Method$VL.FaceSystem.VLActorFaceModel.<>c.<Setup>b__36_4()
  0e12d1bc  bl      #0x63cee78
  0e12d1c0  adrp    x0, #0xebd9000
  0e12d1c4  ldr     x0, [x0, #0xa38]  ; MMETH Method$VL.FaceSystem.VLActorFaceModel.<>c.<Setup>b__36_5()
  0e12d1c8  bl      #0x63cee78
  0e12d1cc  adrp    x0, #0xebd9000
  0e12d1d0  ldr     x0, [x0, #0xa40]  ; MMETH Method$VL.FaceSystem.VLActorFaceModel.<>c.<Setup>b__36_6()
  0e12d1d4  bl      #0x63cee78
  0e12d1d8  adrp    x0, #0xebd9000
  0e12d1dc  ldr     x0, [x0, #0xa48]  ; META VL.FaceSystem.VLActorFaceModel.<>c_TypeInfo
  0e12d1e0  bl      #0x63cee78
  0e12d1e4  adrp    x0, #0xebd9000
  0e12d1e8  ldr     x0, [x0, #0x970]  ; META VL.ActorMesh.VLActorSkinningSystem_TypeInfo
  0e12d1ec  bl      #0x63cee78
  0e12d1f0  mov     w8, #1
  0e12d1f4  strb    w8, [x20, #0xd9f]
  0e12d1f8  mov     x0, x19
  0e12d1fc  mov     x1, xzr
  0e12d200  bl      #0xd9d7844  ; -> UnityEngine.Component$$get_transform
  0e12d204  ldp     x8, x24, [x19, #0x60]
  0e12d208  mov     x20, x0
  0e12d20c  ldr     q0, [x19, #0x50]
  0e12d210  ldp     x21, x22, [x19, #0x38]
  0e12d214  ldp     x25, x28, [x19, #0x20]
  0e12d218  ldr     x0, [x26]
  0e12d21c  ldr     x23, [x19, #0x48]
  0e12d220  ldr     w29, [x19, #0x30]
  0e12d224  ldr     x27, [x19, #0x70]
  0e12d228  str     q0, [sp, #0x20]
  0e12d22c  str     x8, [sp, #0x30]
  0e12d230  bl      #0x63cf110
  0e12d234  add     x7, sp, #0x20
  0e12d238  mov     x1, x20
  0e12d23c  mov     x2, x25
  0e12d240  mov     x3, x21
  0e12d244  mov     x4, x22
  0e12d248  mov     x5, x23
  0e12d24c  mov     x6, x24
  0e12d250  mov     x26, x0
  0e12d254  str     x27, [sp, #0x10]
  0e12d258  str     w29, [sp, #8]
  0e12d25c  str     x28, [sp]
  0e12d260  bl      #0xe12a944  ; -> VL.ActorMesh.VLActorSkinningSystem$$.ctor
  0e12d264  add     x0, x19, #0x378
  0e12d268  mov     x1, x26
  0e12d26c  str     x26, [x19, #0x378]
  0e12d270  bl      #0x63cee24
  0e12d274  adrp    x26, #0xebd9000
  0e12d278  ldr     x26, [x26, #0xa48]  ; META VL.FaceSystem.VLActorFaceModel.<>c_TypeInfo
  0e12d27c  ldr     x20, [x19, #0x70]
  0e12d280  ldr     x0, [x26]
  0e12d284  ldr     w8, [x0, #0xe4]
  0e12d288  cbnz    w8, #0xe12d294
  0e12d28c  bl      #0x63ceff4
  0e12d290  ldr     x0, [x26]
  0e12d294  ldr     x8, [x0, #0xb8]
  0e12d298  adrp    x24, #0xebd9000
  0e12d29c  ldr     x21, [x8, #8]
  0e12d2a0  ldr     x24, [x24, #0x9e0]  ; MMETH Method$System.Linq.Enumerable.Select<BlendShapeData, ValueTuple<string, int>>()
  0e12d2a4  cbnz    x21, #0xe12d300
  0e12d2a8  ldr     w9, [x0, #0xe4]
  0e12d2ac  cbnz    w9, #0xe12d2bc
  0e12d2b0  bl      #0x63ceff4
  0e12d2b4  ldr     x8, [x26]
  0e12d2b8  ldr     x8, [x8, #0xb8]
  0e12d2bc  adrp    x9, #0xebd9000
  0e12d2c0  ldr     x9, [x9, #0xa08]  ; META System.Func<BlendShapeData, int, ValueTuple<string, int>>_TypeInfo
  0e12d2c4  ldr     x22, [x8]
  0e12d2c8  ldr     x0, [x9]
  0e12d2cc  bl      #0x63cf110
  0e12d2d0  adrp    x8, #0xebd9000
  0e12d2d4  mov     x1, x22
  0e12d2d8  mov     x3, xzr
  0e12d2dc  ldr     x8, [x8, #0xa10]  ; MMETH Method$VL.FaceSystem.VLActorFaceModel.<>c.<Setup>b__36_0()
  0e12d2e0  mov     x21, x0
  0e12d2e4  ldr     x2, [x8]
  0e12d2e8  bl      #0xa50f0a0  ; -> System.Func<object, int, ValueTuple<object, int>>$$.ctor
  0e12d2ec  ldr     x8, [x26]
  0e12d2f0  mov     x1, x21
  0e12d2f4  ldr     x0, [x8, #0xb8]
  0e12d2f8  str     x21, [x0, #8]!
  0e12d2fc  bl      #0x63cee24
  0e12d300  ldr     x2, [x24]
  0e12d304  mov     x0, x20
  0e12d308  mov     x1, x21
  0e12d30c  bl      #0x91c6320  ; -> System.Linq.Enumerable$$Select<object, ValueTuple<object, int>>
  0e12d310  ldr     x8, [x26]
  0e12d314  mov     x20, x0
  0e12d318  ldr     w9, [x8, #0xe4]
  0e12d31c  cbnz    w9, #0xe12d32c
  0e12d320  mov     x0, x8
  0e12d324  bl      #0x63ceff4
  0e12d328  ldr     x8, [x26]
  0e12d32c  ldr     x9, [x8, #0xb8]
  0e12d330  ldr     x21, [x9, #0x10]
  0e12d334  cbnz    x21, #0xe12d398
  0e12d338  ldr     w10, [x8, #0xe4]
  0e12d33c  cbnz    w10, #0xe12d350
  0e12d340  mov     x0, x8
  0e12d344  bl      #0x63ceff4
  0e12d348  ldr     x8, [x26]
  0e12d34c  ldr     x9, [x8, #0xb8]
  0e12d350  adrp    x8, #0xea8b000
  0e12d354  ldr     x8, [x8, #0xe30]  ; META System.Func<ValueTuple<string, int>, string>_TypeInfo
  0e12d358  ldr     x22, [x9]
  0e12d35c  ldr     x0, [x8]
  0e12d360  bl      #0x63cf110
  0e12d364  adrp    x8, #0xebd9000
  0e12d368  mov     x1, x22
  0e12d36c  mov     x3, xzr
  0e12d370  ldr     x8, [x8, #0xa18]  ; MMETH Method$VL.FaceSystem.VLActorFaceModel.<>c.<Setup>b__36_1()
  0e12d374  mov     x21, x0
  0e12d378  ldr     x2, [x8]
  0e12d37c  bl      #0xa4b6160  ; -> System.Func<ValueTuple<object, int>, object>$$.ctor
  0e12d380  ldr     x8, [x26]
  0e12d384  mov     x1, x21
  0e12d388  ldr     x0, [x8, #0xb8]
  0e12d38c  str     x21, [x0, #0x10]!
  0e12d390  bl      #0x63cee24
  0e12d394  ldr     x8, [x26]
  0e12d398  ldr     w9, [x8, #0xe4]
  0e12d39c  cbnz    w9, #0xe12d3ac
  0e12d3a0  mov     x0, x8
  0e12d3a4  bl      #0x63ceff4
  0e12d3a8  ldr     x8, [x26]
  0e12d3ac  ldr     x9, [x8, #0xb8]
  0e12d3b0  adrp    x25, #0xebd9000
  0e12d3b4  ldr     x22, [x9, #0x18]
  0e12d3b8  ldr     x25, [x25, #0x9f0]  ; MMETH Method$System.Linq.Enumerable.ToDictionary<ValueTuple<string, int>, string, int>()
  0e12d3bc  cbnz    x22, #0xe12d41c
  0e12d3c0  ldr     w10, [x8, #0xe4]
  0e12d3c4  cbnz    w10, #0xe12d3d8
  0e12d3c8  mov     x0, x8
  0e12d3cc  bl      #0x63ceff4
  0e12d3d0  ldr     x8, [x26]
  0e12d3d4  ldr     x9, [x8, #0xb8]
  0e12d3d8  adrp    x8, #0xea8b000
  0e12d3dc  ldr     x8, [x8, #0xec8]  ; META System.Func<ValueTuple<string, int>, int>_TypeInfo
  0e12d3e0  ldr     x23, [x9]
  0e12d3e4  ldr     x0, [x8]
  0e12d3e8  bl      #0x63cf110
  0e12d3ec  adrp    x8, #0xebd9000
  0e12d3f0  mov     x1, x23
  0e12d3f4  mov     x3, xzr
  0e12d3f8  ldr     x8, [x8, #0xa20]  ; MMETH Method$VL.FaceSystem.VLActorFaceModel.<>c.<Setup>b__36_2()
  0e12d3fc  mov     x22, x0
  0e12d400  ldr     x2, [x8]
  0e12d404  bl      #0xa4b5ddc  ; -> System.Func<ValueTuple<object, int>, int>$$.ctor
  0e12d408  ldr     x8, [x26]
  0e12d40c  mov     x1, x22
  0e12d410  ldr     x0, [x8, #0xb8]
  0e12d414  str     x22, [x0, #0x18]!
  0e12d418  bl      #0x63cee24
  0e12d41c  ldr     x3, [x25]
  0e12d420  mov     x0, x20
  0e12d424  mov     x1, x21
  0e12d428  mov     x2, x22
  0e12d42c  bl      #0x91e04a0  ; -> System.Linq.Enumerable$$ToDictionary<ValueTuple<object, int>, object, int>
  0e12d430  mov     x1, x0
  0e12d434  str     x0, [x19, #0x380]
  0e12d438  add     x0, x19, #0x380
  0e12d43c  bl      #0x63cee24
  0e12d440  ldr     x0, [x26]
  0e12d444  ldr     x20, [x19, #0x70]
  0e12d448  ldr     w8, [x0, #0xe4]
  0e12d44c  cbnz    w8, #0xe12d458
  0e12d450  bl      #0x63ceff4
  0e12d454  ldr     x0, [x26]
  0e12d458  ldr     x8, [x0, #0xb8]
  0e12d45c  ldr     x21, [x8, #0x20]
  0e12d460  cbnz    x21, #0xe12d4bc
  0e12d464  ldr     w9, [x0, #0xe4]
  0e12d468  cbnz    w9, #0xe12d478
  0e12d46c  bl      #0x63ceff4
  0e12d470  ldr     x8, [x26]
  0e12d474  ldr     x8, [x8, #0xb8]
  0e12d478  adrp    x9, #0xebd9000
  0e12d47c  ldr     x9, [x9, #0xa08]  ; META System.Func<BlendShapeData, int, ValueTuple<string, int>>_TypeInfo
  0e12d480  ldr     x22, [x8]
  0e12d484  ldr     x0, [x9]
  0e12d488  bl      #0x63cf110
  0e12d48c  adrp    x8, #0xebd9000
  0e12d490  mov     x1, x22
  0e12d494  mov     x3, xzr
  0e12d498  ldr     x8, [x8, #0xa28]  ; MMETH Method$VL.FaceSystem.VLActorFaceModel.<>c.<Setup>b__36_3()
  0e12d49c  mov     x21, x0
  0e12d4a0  ldr     x2, [x8]
  0e12d4a4  bl      #0xa50f0a0  ; -> System.Func<object, int, ValueTuple<object, int>>$$.ctor
  0e12d4a8  ldr     x8, [x26]
  0e12d4ac  mov     x1, x21
  0e12d4b0  ldr     x0, [x8, #0xb8]
  0e12d4b4  str     x21, [x0, #0x20]!
  0e12d4b8  bl      #0x63cee24
  0e12d4bc  ldr     x2, [x24]
  0e12d4c0  mov     x0, x20
  0e12d4c4  mov     x1, x21
  0e12d4c8  bl      #0x91c6320  ; -> System.Linq.Enumerable$$Select<object, ValueTuple<object, int>>
  0e12d4cc  ldr     x8, [x26]
  0e12d4d0  mov     x20, x0
  0e12d4d4  ldr     w9, [x8, #0xe4]
  0e12d4d8  cbnz    w9, #0xe12d4e8
  0e12d4dc  mov     x0, x8
  0e12d4e0  bl      #0x63ceff4
  0e12d4e4  ldr     x8, [x26]
  0e12d4e8  ldr     x9, [x8, #0xb8]
  0e12d4ec  adrp    x23, #0xebd9000
  0e12d4f0  ldr     x21, [x9, #0x28]
  0e12d4f4  ldr     x23, [x23, #0x9d8]  ; MMETH Method$System.Linq.Enumerable.GroupBy<ValueTuple<string, int>, string>()
  0e12d4f8  cbnz    x21, #0xe12d558
  0e12d4fc  ldr     w10, [x8, #0xe4]
  0e12d500  cbnz    w10, #0xe12d514
  0e12d504  mov     x0, x8
  0e12d508  bl      #0x63ceff4
  0e12d50c  ldr     x8, [x26]
  0e12d510  ldr     x9, [x8, #0xb8]
  0e12d514  adrp    x8, #0xea8b000
  0e12d518  ldr     x8, [x8, #0xe30]  ; META System.Func<ValueTuple<string, int>, string>_TypeInfo
  0e12d51c  ldr     x22, [x9]
  0e12d520  ldr     x0, [x8]
  0e12d524  bl      #0x63cf110
  0e12d528  adrp    x8, #0xebd9000
  0e12d52c  mov     x1, x22
  0e12d530  mov     x3, xzr
  0e12d534  ldr     x8, [x8, #0xa30]  ; MMETH Method$VL.FaceSystem.VLActorFaceModel.<>c.<Setup>b__36_4()
  0e12d538  mov     x21, x0
  0e12d53c  ldr     x2, [x8]
  0e12d540  bl      #0xa4b6160  ; -> System.Func<ValueTuple<object, int>, object>$$.ctor
  0e12d544  ldr     x8, [x26]
  0e12d548  mov     x1, x21
  0e12d54c  ldr     x0, [x8, #0xb8]
  0e12d550  str     x21, [x0, #0x28]!
  0e12d554  bl      #0x63cee24
  0e12d558  ldr     x2, [x23]
  0e12d55c  mov     x0, x20
  0e12d560  mov     x1, x21
  0e12d564  bl      #0x91a551c  ; -> System.Linq.Enumerable$$GroupBy<ValueTuple<object, int>, object>
  0e12d568  ldr     x8, [x26]
  0e12d56c  mov     x20, x0
  0e12d570  ldr     w9, [x8, #0xe4]
  0e12d574  cbnz    w9, #0xe12d584
  0e12d578  mov     x0, x8
  0e12d57c  bl      #0x63ceff4
  0e12d580  ldr     x8, [x26]
  0e12d584  ldr     x9, [x8, #0xb8]
  0e12d588  ldr     x21, [x9, #0x30]
  0e12d58c  cbnz    x21, #0xe12d5f0
  0e12d590  ldr     w10, [x8, #0xe4]
  0e12d594  cbnz    w10, #0xe12d5a8
  0e12d598  mov     x0, x8
  0e12d59c  bl      #0x63ceff4
  0e12d5a0  ldr     x8, [x26]
  0e12d5a4  ldr     x9, [x8, #0xb8]
  0e12d5a8  adrp    x8, #0xebd9000
  0e12d5ac  ldr     x8, [x8, #0xa00]  ; META System.Func<IGrouping<string, ValueTuple<string, int>>, string>_TypeInfo
  0e12d5b0  ldr     x22, [x9]
  0e12d5b4  ldr     x0, [x8]
  0e12d5b8  bl      #0x63cf110
  0e12d5bc  adrp    x8, #0xebd9000
  0e12d5c0  mov     x1, x22
  0e12d5c4  mov     x3, xzr
  0e12d5c8  ldr     x8, [x8, #0xa38]  ; MMETH Method$VL.FaceSystem.VLActorFaceModel.<>c.<Setup>b__36_5()
  0e12d5cc  mov     x21, x0
  0e12d5d0  ldr     x2, [x8]
  0e12d5d4  bl      #0xa4f009c  ; -> System.Func<object, object>$$.ctor
  0e12d5d8  ldr     x8, [x26]
  0e12d5dc  mov     x1, x21
  0e12d5e0  ldr     x0, [x8, #0xb8]
  0e12d5e4  str     x21, [x0, #0x30]!
  0e12d5e8  bl      #0x63cee24
  0e12d5ec  ldr     x8, [x26]
  0e12d5f0  ldr     w9, [x8, #0xe4]
  0e12d5f4  cbnz    w9, #0xe12d604
  0e12d5f8  mov     x0, x8
  0e12d5fc  bl      #0x63ceff4
  0e12d600  ldr     x8, [x26]
  0e12d604  ldr     x9, [x8, #0xb8]
  0e12d608  adrp    x24, #0xebd9000
  0e12d60c  ldr     x22, [x9, #0x40]
  0e12d610  ldr     x24, [x24, #0x9e8]  ; MMETH Method$System.Linq.Enumerable.ToDictionary<IGrouping<string, ValueTuple<string, int>>, string, int[]>()
  0e12d614  cbnz    x22, #0xe12d674
  0e12d618  ldr     w10, [x8, #0xe4]
  0e12d61c  cbnz    w10, #0xe12d630
  0e12d620  mov     x0, x8
  0e12d624  bl      #0x63ceff4
  0e12d628  ldr     x8, [x26]
  0e12d62c  ldr     x9, [x8, #0xb8]
  0e12d630  adrp    x8, #0xebd9000
  0e12d634  ldr     x8, [x8, #0x9f8]  ; META System.Func<IGrouping<string, ValueTuple<string, int>>, int[]>_TypeInfo
  0e12d638  ldr     x23, [x9]
  0e12d63c  ldr     x0, [x8]
  0e12d640  bl      #0x63cf110
  0e12d644  adrp    x8, #0xebd9000
  0e12d648  mov     x1, x23
  0e12d64c  mov     x3, xzr
  0e12d650  ldr     x8, [x8, #0xa40]  ; MMETH Method$VL.FaceSystem.VLActorFaceModel.<>c.<Setup>b__36_6()
  0e12d654  mov     x22, x0
  0e12d658  ldr     x2, [x8]
  0e12d65c  bl      #0xa4f009c  ; -> System.Func<object, object>$$.ctor
  0e12d660  ldr     x8, [x26]
  0e12d664  mov     x1, x22
  0e12d668  ldr     x0, [x8, #0xb8]
  0e12d66c  str     x22, [x0, #0x40]!
  0e12d670  bl      #0x63cee24
  0e12d674  ldr     x3, [x24]
  0e12d678  mov     x0, x20
  0e12d67c  mov     x1, x21
  0e12d680  mov     x2, x22
  0e12d684  bl      #0x91e0a34  ; -> System.Linq.Enumerable$$ToDictionary<object, object, object>
  0e12d688  mov     x1, x0
  0e12d68c  str     x0, [x19, #0x388]
  0e12d690  add     x0, x19, #0x388
  0e12d694  bl      #0x63cee24
  0e12d698  mov     x0, x19
  0e12d69c  ldp     x20, x19, [sp, #0x90]
  0e12d6a0  ldp     x22, x21, [sp, #0x80]
  0e12d6a4  ldp     x24, x23, [sp, #0x70]
  0e12d6a8  ldp     x26, x25, [sp, #0x60]
  0e12d6ac  ldp     x28, x27, [sp, #0x50]
  0e12d6b0  ldp     x29, x30, [sp, #0x40]
  0e12d6b4  add     sp, sp, #0xa0
  0e12d6b8  b       #0xe12d800  ; -> VL.FaceSystem.VLActorFaceModel$$SetupBindVertices

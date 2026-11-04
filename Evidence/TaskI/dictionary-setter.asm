=== VL.Core.SerializedDictionary<int, int>$$set_Item @ 0xb970038 (8 insns)
    void VL_Core_SerializedDictionary_int__int___set_Item (VL_Core_SerializedDictionary_int__int__o* __this, int32_t key, int32_t value, const MethodInfo_B970038* method);
  0b970038  ldr     x0, [x0, #0x20]
  0b97003c  cbz     x0, #0xb970050
  0b970040  ldr     x8, [x3, #0x20]
  0b970044  ldr     x8, [x8, #0xc0]
  0b970048  ldr     x3, [x8, #0x68]
  0b97004c  b       #0x9b16e6c  ; -> System.Collections.Generic.Dictionary<int, int>$$set_Item
  0b970050  str     x30, [sp, #-0x10]!
  0b970054  bl      #0x63cf120
=== VL.Core.SerializedDictionary<int, object>$$set_Item @ 0xb97066c (8 insns)
    void VL_Core_SerializedDictionary_int__object___set_Item (VL_Core_SerializedDictionary_TKey__TValue__o* __this, int32_t key, Il2CppObject* value, const MethodInfo_B97066C* method);
  0b97066c  ldr     x0, [x0, #0x20]
  0b970670  cbz     x0, #0xb970684
  0b970674  ldr     x8, [x3, #0x20]
  0b970678  ldr     x8, [x8, #0xc0]
  0b97067c  ldr     x3, [x8, #0x68]
  0b970680  b       #0x9b210f8  ; -> System.Collections.Generic.Dictionary<int, object>$$set_Item
  0b970684  str     x30, [sp, #-0x10]!
  0b970688  bl      #0x63cf120
=== VL.Core.SerializedDictionary<Int32Enum, object>$$set_Item @ 0xb970ce8 (8 insns)
    void VL_Core_SerializedDictionary_Int32Enum__object___set_Item (VL_Core_SerializedDictionary_TKey__TValue__o* __this, int32_t key, Il2CppObject* value, const MethodInfo_B970CE8* method);
  0b970ce8  ldr     x0, [x0, #0x20]
  0b970cec  cbz     x0, #0xb970d00
  0b970cf0  ldr     x8, [x3, #0x20]
  0b970cf4  ldr     x8, [x8, #0xc0]
  0b970cf8  ldr     x3, [x8, #0x68]
  0b970cfc  b       #0x9b6eb7c  ; -> System.Collections.Generic.Dictionary<Int32Enum, object>$$set_Item
  0b970d00  str     x30, [sp, #-0x10]!
  0b970d04  bl      #0x63cf120
=== VL.Core.SerializedDictionary<object, object>$$set_Item @ 0xb971364 (8 insns)
    void VL_Core_SerializedDictionary_object__object___set_Item (VL_Core_SerializedDictionary_TKey__TValue__o* __this, Il2CppObject* key, Il2CppObject* value, const MethodInfo_B971364* method);
  0b971364  ldr     x0, [x0, #0x20]
  0b971368  cbz     x0, #0xb97137c
  0b97136c  ldr     x8, [x3, #0x20]
  0b971370  ldr     x8, [x8, #0xc0]
  0b971374  ldr     x3, [x8, #0x68]
  0b971378  b       #0x9c2f108  ; -> System.Collections.Generic.Dictionary<object, object>$$set_Item
  0b97137c  str     x30, [sp, #-0x10]!
  0b971380  bl      #0x63cf120
=== VL.Core.SerializedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>$$set_Item @ 0xb971a18 (73 insns)
    void VL_Core_SerializedDictionary___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType___set_Item (VL_Core_SerializedDictionary_TKey__TValue__o* __this, Unity_IL2CPP_Metadata___Il2CppFullySharedGenericType_o key, Unity_IL2CPP_Metadata___Il2CppFullySharedGenericType_o value, const MethodInfo_B971A18* method);
  0b971a18  stp     x29, x30, [sp, #-0x60]!
  0b971a1c  str     x27, [sp, #0x10]
  0b971a20  stp     x26, x25, [sp, #0x20]
  0b971a24  stp     x24, x23, [sp, #0x30]
  0b971a28  stp     x22, x21, [sp, #0x40]
  0b971a2c  stp     x20, x19, [sp, #0x50]
  0b971a30  mov     x29, sp
  0b971a34  sub     sp, sp, #0x30
  0b971a38  mrs     x24, tpidr_el0
  0b971a3c  mov     x22, x2
  0b971a40  mov     x9, sp
  0b971a44  ldr     x8, [x24, #0x28]
  0b971a48  stur    x8, [x29, #-8]
  0b971a4c  ldr     x8, [x3, #0x20]
  0b971a50  stp     x22, x1, [x29, #-0x28]
  0b971a54  ldr     x25, [x8, #0xc0]
  0b971a58  ldp     x8, x26, [x25, #0x58]
  0b971a5c  ldr     w2, [x8, #0xfc]
  0b971a60  ldr     w23, [x26, #0xfc]
  0b971a64  add     x10, x2, #0xf
  0b971a68  and     x10, x10, #0x1fffffff0
  0b971a6c  sub     x20, x9, x10
  0b971a70  mov     sp, x20
  0b971a74  add     x10, x23, #0xf
  0b971a78  mov     x9, sp
  0b971a7c  and     x10, x10, #0x1fffffff0
  0b971a80  sub     x19, x9, x10
  0b971a84  mov     sp, x19
  0b971a88  ldr     w27, [x8, #0x28]
  0b971a8c  sub     x8, x29, #0x20
  0b971a90  ldr     x21, [x0, #0x20]
  0b971a94  mov     x0, x20
  0b971a98  cmp     w27, #0
  0b971a9c  csel    x1, x1, x8, lt
  0b971aa0  bl      #0xe1b8430
  0b971aa4  ldr     w26, [x26, #0x28]
  0b971aa8  sub     x8, x29, #0x28
  0b971aac  mov     x0, x19
  0b971ab0  mov     x2, x23
  0b971ab4  cmp     w26, #0
  0b971ab8  csel    x1, x22, x8, lt
  0b971abc  bl      #0xe1b8430
  0b971ac0  cbz     x21, #0xb971b24
  0b971ac4  ldr     x1, [x25, #0x68]
  0b971ac8  ldr     x0, [x1]
  0b971acc  tbnz    w27, #0x1f, #0xb971ad4
  0b971ad0  ldr     x20, [x20]
  0b971ad4  tbnz    w26, #0x1f, #0xb971adc
  0b971ad8  ldr     x19, [x19]
  0b971adc  ldr     x8, [x1, #0x10]
  0b971ae0  sub     x3, x29, #0x18
  0b971ae4  mov     x2, x21
  0b971ae8  mov     x4, x19
  0b971aec  stp     x20, x19, [x29, #-0x18]
  0b971af0  blr     x8
  0b971af4  ldr     x8, [x24, #0x28]
  0b971af8  ldur    x9, [x29, #-8]
  0b971afc  cmp     x8, x9
  0b971b00  b.ne    #0xb971b38
  0b971b04  mov     sp, x29
  0b971b08  ldp     x20, x19, [sp, #0x50]
  0b971b0c  ldr     x27, [sp, #0x10]
  0b971b10  ldp     x22, x21, [sp, #0x40]
  0b971b14  ldp     x24, x23, [sp, #0x30]
  0b971b18  ldp     x26, x25, [sp, #0x20]
  0b971b1c  ldp     x29, x30, [sp], #0x60
  0b971b20  ret     
  0b971b24  ldr     x8, [x24, #0x28]
  0b971b28  ldur    x9, [x29, #-8]
  0b971b2c  cmp     x8, x9
  0b971b30  b.ne    #0xb971b38
  0b971b34  bl      #0x63cf120
  0b971b38  bl      #0xe1b8490

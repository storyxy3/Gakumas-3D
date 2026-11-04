=== VLB.Config$$get_SD_requiresDoubleSidedMesh @ 0xe0c73b0 (7 insns)
    bool VLB_Config__get_SD_requiresDoubleSidedMesh (VLB_Config_o* __this, const MethodInfo* method);
  0e0c73b0  str     x30, [sp, #-0x10]!
  0e0c73b4  mov     w1, wzr
  0e0c73b8  bl      #0xe0c7204  ; -> VLB.Config$$GetActualRenderingMode
  0e0c73bc  cmp     w0, #0
  0e0c73c0  cset    w0, ne
  0e0c73c4  ldr     x30, [sp], #0x10
  0e0c73c8  ret     

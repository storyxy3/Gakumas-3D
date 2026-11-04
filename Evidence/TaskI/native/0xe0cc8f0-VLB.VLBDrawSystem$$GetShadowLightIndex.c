// VLB.VLBDrawSystem$$GetShadowLightIndex @ 0xe0cc8f0
int __fastcall VLB_VLBDrawSystem__GetShadowLightIndex(void *a0, void *a1, __int64 a2, void *a3, void *a4)
{
  int v6; // w23
  __int64 v9; // x22
  __int64 v10; // x26
  __int64 lightType; // x0
  __int64 v12; // x1
  void *v13; // x23
  void *light; // x24
  __int128 v16; // [xsp+0h] [xbp+0h] BYREF
  __int128 v17; // [xsp+10h] [xbp+10h]
  __int128 v18; // [xsp+20h] [xbp+20h]
  __int128 v19; // [xsp+30h] [xbp+30h]
  __int128 v20; // [xsp+40h] [xbp+40h]
  __int128 v21; // [xsp+50h] [xbp+50h]
  __int128 v22; // [xsp+60h] [xbp+60h]
  int v23; // [xsp+70h] [xbp+70h]

  v6 = (int)a3;
  if ( (unk_F43D9E1 & 1) == 0 )
  {
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    unk_F43D9E1 = 1;
  }
  v23 = 0;
  v17 = 0u;
  v18 = 0u;
  v19 = 0u;
  v20 = 0u;
  v21 = 0u;
  v22 = 0u;
  v16 = 0u;
  if ( v6 < 1 )
    return -1;
  v9 = 0;
  v10 = (unsigned int)v6;
  while ( 1 )
  {
    memmove(&v16, (const void *)a2, 0x74u);
    lightType = UnityEngine_Rendering_VisibleLight__get_lightType((__int64)&v16, nullptr);
    if ( !(_DWORD)lightType )
    {
      if ( !a1 )
        goto LABEL_15;
      v13 = *((void **)a1 + 5);
      light = UnityEngine_Rendering_VisibleLight__get_light((__int64)&v16, nullptr);
      if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
        sub_63CEFF4(UnityEngine_Object_TypeInfo);
      lightType = UnityEngine_Object__op_Equality(v13, light, nullptr);
      if ( (lightType & 1) != 0 )
        break;
    }
    ++v9;
    a2 += 116;
    if ( v10 == v9 )
      return -1;
  }
  if ( !a4 )
  {
LABEL_15:
    sub_63CF120(lightType, v12);
    JUMPOUT(0xE0CCA14);
  }
  return UnityEngine_Rendering_Universal_Internal_AdditionalLightsShadowCasterPass__GetShadowLightIndexFromLightIndex(
           a4,
           v9,
           nullptr);
}


using System;
using CriWare.CriMana;

namespace CriWare
{
    // The cri_ware_unity entry points of the CRI Mana movie player and renderer resources (SL-E3).
    public partial interface ICriWareNativeBackend
    {
        // CriManaPlugin
        bool criManaUnity_IsBufferOutputForH264Enabled_ANDROID();
        uint CRIWARE747D292C();
        bool criManaUnity_IsMediaCodecSupported_ANDROID(int device_type);
        uint criManaUnity_MediaCodecCreateTexture_ANDROID();
        void criManaUnity_MediaCodecDeleteTexture_ANDROID(uint oes_texture);
        bool criManaUnityPlayer_MediaCodecAttachTexture_ANDROID(int player_id, uint oes_texture);
        void criManaUnityPlayer_MediaCodecDetachTexture_ANDROID(int player_id, uint oes_texture);

        // CriMana.Player
        int CRIWARE069A61A1();
        int CRIWARED0162744(bool useAtomExPlayer, uint maxPathLength);
        IntPtr criManaUnityPlayer_GetAtomExPlayerByTrackId(int player_id, uint track_id);
        void CRIWARE0554C38E(int player_id);
        void CRIWARE1A89BB84(int player_id);
        void CRIWARE8F47EE33(int player_id, Player.CuePointCallbackFromNativeDelegate cbfunc);
        void CRIWAREA6273B3C(int player_id);
        void CRIWARE10F14332(int player_id, int sw);
        bool CRIWARE8F9064CB(int player_id);
        void CRIWAREF4FAFD40(int player_id, IntPtr binder, string path);
        bool CRIWARE97D4A74F(int player_id, IntPtr binder, string path, bool repeat);
        void CRIWARE45230ACB(int player_id, int sw);
        void CRIWAREBF4EA6F4(int player_id, int seek_frame_no);
        void CRIWAREAE6A37FE(int player_id, bool flag);
        void CRIWARE2A9F70F6(int player_id, int timer_type);
        void CRIWARE91A28C68(int player_id, ulong user_count, ulong user_unit);
        void CRIWAREFA328494(int player_id);
        void CRIWAREC91B6C0D(int player_id, MovieInfo movie_info);
        void CRIWARE38F608E1(int player_id);
        int CRIWARE64FBEFB2(int player_id);
        IntPtr criWareUnity_GetRenderEventFunc();

        // CriMana.Detail.RendererResource
        bool CRIWARE9F502893(int player_id, int num_textures, IntPtr[] tex_ptrs, FrameInfo frame_info,
            ref bool frame_drop);
        bool CRIWARE1A1436DD(int player_id, int num_textures, IntPtr[] tex_ptrs);
        bool CRIWAREDEF25F94(int player_id, int num_textures, IntPtr[] tex_ptrs);
        bool CRIWARE5F215F75(int player_id, int num_textures, IntPtr[] tex_ptrs);
        sbyte CRIWARE412BF0B2(int player_id);

        // CriAtomExPlayer (the Mana player's ambisonics source)
        void criAtomExPlayer_SetPanType(IntPtr player, CriAtomEx.PanType type);
    }

    public partial class CriManaPlugin
    {
        internal static bool criManaUnity_IsBufferOutputForH264Enabled_ANDROID() =>
            CriWareNative.Native.criManaUnity_IsBufferOutputForH264Enabled_ANDROID();
    }
}

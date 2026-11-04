namespace CriWare
{
    // CriWare.CriAtomExCategory (TypeDefIndex 31727), the member on the game's paths.
    public static partial class CriAtomExCategory
    {
        internal static void criAtomExCategory_SetVolumeByName(string name, float volume) =>
            CriWareNative.Native.criAtomExCategory_SetVolumeByName(name, volume);
    }
}

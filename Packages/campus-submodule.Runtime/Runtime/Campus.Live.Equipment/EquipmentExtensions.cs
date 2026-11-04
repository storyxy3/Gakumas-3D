namespace Campus.Live.Equipment
{
    using global::Campus.Live.Equipment;

    public static class EquipmentExtensions
    {
        public static bool IsFlag<T>(this ref T data, EquipmentValueType type)
            where T : struct, IUseFlags
        {
            return (data.UseFlags & (int)type) != 0;
        }

        public static void AddFlag<T>(this ref T data, EquipmentValueType type)
            where T : struct, IUseFlags
        {
            data.UseFlags |= (int)type;
        }
    }
}

namespace Campus.Live.Equipment
{
    using global::Campus.Live.Equipment;

    public static class EquipmentExtensions
    {
        public static bool IsFlag<T>(this ref T data, EquipmentValueType type)
            where T : struct, IUseFlags
        {
            return default(bool);
        }

        public static void AddFlag<T>(this ref T data, EquipmentValueType type)
            where T : struct, IUseFlags
        {
        }
    }
}

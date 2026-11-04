namespace Campus.Live.Equipment
{
    using global::Campus.Live.Equipment;
    using global::UnityEngine;

    public struct LiveEquipmentComponentProperty : ILiveEquipmentProperty
    {
        public readonly Component component;
        public readonly string name;
        public LiveEquipmentComponentProperty(Component component, string name)
        {
            this.component = component;
            this.name = name;
        }
    }
}

namespace VL
{
    using global::System.Collections.Generic;
    using global::UnityEngine;
    using global::VL;

    public interface IVLActorDescriptor
    {
        string name { get; }

        List<string> assets { get; }

        IEnumerable<GameObject> gameObjects { get; set; }

        bool usePropConstraint { set; }

        bool autoPropVisible { get; }

        List<int> propIndexList { get; set; }

        Dictionary<string, VLActorPropFixConstraint> propFixConstraintDict { get; }
    }
}

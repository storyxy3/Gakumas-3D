namespace VL
{
    using global::UnityEngine;

    public interface IVLTransform
    {
        Vector3 position { get; set; }

        Quaternion rotation { get; }

        Vector3 eulerAngles { get; set; }

        Vector3 forward { get; }

        Vector3 scale { set; }
    }
}

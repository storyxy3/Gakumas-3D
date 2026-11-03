using global::System;
using global::System.Collections.Generic;
using global::UnityEngine;

public class ProFlareAtlas : MonoBehaviour
{
    [Serializable]
    public class Element
    {
        public string name;
        public Rect UV;
        public bool Imported;
        public Element()
        {
        }
    }

    public Texture2D texture;
    public int elementNumber;
    public bool editElements;
    [SerializeField]
    public List<Element> elementsList;
    public string[] elementNameList;
    public void UpdateElementNameList()
    {
    }

    public ProFlareAtlas()
    {
    }
}

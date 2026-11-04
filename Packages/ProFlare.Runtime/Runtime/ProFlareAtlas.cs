using global::System;
using global::System.Collections.Generic;
using global::UnityEngine;

public class ProFlareAtlas : MonoBehaviour
{
    [Serializable]
    public class Element
    {
        public string name = "Flare Element";
        public Rect UV = new Rect(0, 0, 1, 1);
        public bool Imported;
        public Element()
        {
        }
    }

    public Texture2D texture;
    public int elementNumber;
    public bool editElements;
    [SerializeField]
    public List<Element> elementsList = new List<Element>();
    public string[] elementNameList;
    public void UpdateElementNameList()
    {
        elementNameList = new string[elementsList.Count];
        for (int i = 0; i < elementNameList.Length; ++i) elementNameList[i] = elementsList[i].name;
    }

    public ProFlareAtlas()
    {
    }
}

namespace VLB
{
    using global::UnityEngine;
    using global::VLB;

    [ExecuteInEditMode]
    [DisallowMultipleComponent]
    [SelectionBase]
    [HelpURL("http://saladgamer.com/vlb-doc/comp-lightbeam-hd/")]
    public class VolumetricLightBeamHD2D : VolumetricLightBeamHD
    {
        [SerializeField]
        private int m_SortingLayerID;
        [SerializeField]
        private int m_SortingOrder;
        public int sortingLayerID
        {
            get
            {
                return default(int);
            }

            set
            {
            }
        }

        public string sortingLayerName
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public int sortingOrder
        {
            get
            {
                return default(int);
            }

            set
            {
            }
        }

        public override Dimensions GetDimensions()
        {
            return default(Dimensions);
        }

        public override bool DoesSupportSorting2D()
        {
            return default(bool);
        }

        public override int GetSortingLayerID()
        {
            return default(int);
        }

        public override int GetSortingOrder()
        {
            return default(int);
        }

        public VolumetricLightBeamHD2D()
        {
        }
    }
}

namespace VL.Core
{
    using global::System;
    using global::System.Collections.Generic;
    using global::UnityEngine;
    using global::VL;

    [Serializable]
    public class VLActorDescriptor : IVLActorDescriptor
    {
        [SerializeField]
        private List<string> _assets;
        [SerializeField]
        private string _name;
        [SerializeField]
        private GameObject[] _gameObjects;
        [SerializeField]
        private bool _usePropConstraint;
        [SerializeField]
        private bool _autoPropVisible;
        [SerializeField]
        private List<int> _propIndexList;
        [SerializeField]
        private Dictionary<string, VLActorPropFixConstraint> _propFixConstraintDict;
        public List<string> assets
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public string name
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public IEnumerable<GameObject> gameObjects
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public bool usePropConstraint
        {
            set
            {
            }
        }

        public bool autoPropVisible
        {
            get
            {
                return default(bool);
            }

            set
            {
            }
        }

        public List<int> propIndexList
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public Dictionary<string, VLActorPropFixConstraint> propFixConstraintDict
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public VLActorDescriptor()
        {
        }
    }
}

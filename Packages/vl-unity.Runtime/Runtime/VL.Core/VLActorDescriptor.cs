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
        private bool _autoPropVisible = true;
        [SerializeField]
        private List<int> _propIndexList;
        [SerializeField]
        private Dictionary<string, VLActorPropFixConstraint> _propFixConstraintDict;
        public List<string> assets
        {
            get
            {
                return _assets;
            }

            set
            {
                _assets = value;
            }
        }

        public string name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public IEnumerable<GameObject> gameObjects
        {
            get
            {
                return _gameObjects;
            }

            set
            {
                _gameObjects = global::System.Linq.Enumerable.ToArray(value);
            }
        }

        public bool usePropConstraint
        {
            set
            {
                _usePropConstraint = value;
            }
        }

        public bool autoPropVisible
        {
            get
            {
                return _autoPropVisible;
            }

            set
            {
                _autoPropVisible = value;
            }
        }

        public List<int> propIndexList
        {
            get
            {
                return _propIndexList;
            }

            set
            {
                _propIndexList = value;
            }
        }

        public Dictionary<string, VLActorPropFixConstraint> propFixConstraintDict
        {
            get
            {
                return _propFixConstraintDict;
            }

            set
            {
                _propFixConstraintDict = value;
            }
        }

        public VLActorDescriptor()
        {
        }
    }
}

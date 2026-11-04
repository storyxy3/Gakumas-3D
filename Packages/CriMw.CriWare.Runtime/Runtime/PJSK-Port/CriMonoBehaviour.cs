using System;
using System.Collections.Generic;
using UnityEngine;

namespace CriWare
{
    // CriWare.CriMonoBehaviour (TypeDefIndex 31925): CRIWARE components updated by CriMonoBehaviourManager.
    public abstract class CriMonoBehaviour : MonoBehaviour
    {
        public Guid guid { get; private set; }

        protected CriMonoBehaviour()
        {
            guid = Guid.NewGuid();
        }

        protected virtual void OnEnable()
        {
            CriMonoBehaviourManager.instance.Register(this);
        }

        protected virtual void OnDisable()
        {
            CriMonoBehaviourManager.UnRegister(this);
        }

        public abstract void CriInternalUpdate();

        public abstract void CriInternalLateUpdate();
    }

    // CriWare.CriMonoBehaviourManager (TypeDefIndex 31926), on the "CRIWARE" manager object.
    public class CriMonoBehaviourManager : MonoBehaviour
    {
        private static CriMonoBehaviourManager _instance;
        private static List<CriMonoBehaviour> criMonoBehaviourList = new List<CriMonoBehaviour>();

        public static CriMonoBehaviourManager instance
        {
            get
            {
                CreateInstance();
                return _instance;
            }
        }

        public bool Register(CriMonoBehaviour criMonoBehaviour)
        {
            lock (criMonoBehaviourList)
            {
                if (GetIndex(criMonoBehaviour) >= 0)
                {
                    Debug.LogWarning("[CRIWARE] Internal: Duplicated CriMonoBehaviour GUID");
                    return false;
                }
                criMonoBehaviourList.Add(criMonoBehaviour);
                return true;
            }
        }

        public static bool UnRegister(CriMonoBehaviour criMonoBehaviour)
        {
            lock (criMonoBehaviourList)
            {
                var index = GetIndex(criMonoBehaviour);
                if (index < 0)
                    return false;
                criMonoBehaviourList.RemoveAt(index);
                return true;
            }
        }

        private static void CreateInstance()
        {
            if (_instance == null)
                Common.managerObject.AddComponent<CriMonoBehaviourManager>();
        }

        private static int GetIndex(CriMonoBehaviour criMonoBehaviour)
        {
            for (var i = 0; i < criMonoBehaviourList.Count; i++)
            {
                if (criMonoBehaviourList[i].guid == criMonoBehaviour.guid)
                    return i;
            }
            return -1;
        }

        private void Awake()
        {
            if (_instance == null)
                _instance = this;
            else
                Destroy(this);
        }

        private void Update()
        {
            lock (criMonoBehaviourList)
            {
                for (var i = 0; i < criMonoBehaviourList.Count; i++)
                    criMonoBehaviourList[i].CriInternalUpdate();
            }
        }

        private void LateUpdate()
        {
            lock (criMonoBehaviourList)
            {
                for (var i = 0; i < criMonoBehaviourList.Count; i++)
                    criMonoBehaviourList[i].CriInternalLateUpdate();
            }
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Game.Managers
{
    public class ManagerObjectPooling : MonoSingleton<ManagerObjectPooling>
    {



        [Serializable]
        public class Pool<T> where T : Component
        {
            public T ReferancePrefab;
            public List<T> PoolList;
            public Transform ParentOfTransform;
            public T GetPoolMember()
            {
                for (int i = 0; i < PoolList.Count; i++)
                {
                    if (!PoolList[i].gameObject.activeInHierarchy)
                    {
                        PoolList[i].gameObject.SetActive(true);

                        return PoolList[i];

                    }
                }

                GameObject poolMemberGameObject = Instantiate(ReferancePrefab.gameObject,ParentOfTransform);
                poolMemberGameObject.SetActive(true);
                T poolMember = poolMemberGameObject.GetComponent<T>();
                PoolList.Add(poolMember);
                return poolMember;


            }


        }


        public Pool<Image> ImageForItemEffectPool = new Pool<Image>();

      

    }
}
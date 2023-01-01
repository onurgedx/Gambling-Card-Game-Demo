using Game.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Managers
{

    public class ManagerInventory : MonoSingleton<ManagerInventory>
    {

        public Action<int> OnItemGained;
        public Action OnAllItemLose;

        private List<BaseItem> _items = new List<BaseItem>();



        private void OnEnable()
        {
            ManagerResultSpinWheel.Instance.OnResultDetermined += ItemProcess;
            
        }
        private void OnDisable()
        {
            ManagerResultSpinWheel.Instance.OnResultDetermined -= ItemProcess;
            
        }
        private void ItemProcess(IGainable gainable)
        {

            BaseItem item = new BaseItem(gainable.GetGainableData());



            AddItem(item);


        }

        private void AddItem(BaseItem item)
        {



            _items.Add(item);

            OnItemGained?.Invoke(_items.Count);

        }
        private void RemoveAllItems()
        {
            _items = new List<BaseItem>();
            OnAllItemLose?.Invoke();
        }


        



    }
}

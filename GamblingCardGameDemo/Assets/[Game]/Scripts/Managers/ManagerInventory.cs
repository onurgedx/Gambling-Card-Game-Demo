using Game.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Managers
{

    public class ManagerInventory : MonoSingleton<ManagerInventory>
    {

        public Action<int,BaseItem> OnItemGained;

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


            BaseItem item;
             
            switch (gainable.GetGainableData().GainableType)
            {
                case Enums.GainableTypeEnum.LoseAllItems:
                    item = new BombLoseItem(gainable.GetGainableData());
                  
                    break;
                default:
                    item = new BaseItem(gainable.GetGainableData());
                    break;


            }


            item.JoinInventory(_items,OnItemGained);

            

           
        }

        


        public void RemoveAllItems()
        {

            
            _items = new List<BaseItem>();

            OnAllItemLose?.Invoke();


        }

        

        



    }
}

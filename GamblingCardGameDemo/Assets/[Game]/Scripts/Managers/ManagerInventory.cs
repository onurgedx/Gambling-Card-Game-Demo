using Game.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Managers
{

    public class ManagerInventory : MonoSingleton<ManagerInventory>
    {

        public Action<int,BaseItem> OnTempItemGained;

        public Action<List<BaseItem>> OnMainItemsGained;

        public Action OnAllTempItemLose;

        private List<BaseItem> _tempItemsList = new List<BaseItem>();

        private List<BaseItem> _itemsList = new List<BaseItem>();

        

        private void OnEnable()
        {

            ManagerResultSpinWheel.Instance.OnResultDetermined += GainItemToTempInventory;
            ManagerLevel.Instance.OnLevelEnd += GainItemsToMainInventory;
            
        }
        private void OnDisable()
        {
            ManagerResultSpinWheel.Instance.OnResultDetermined -= GainItemToTempInventory;
            ManagerLevel.Instance.OnLevelEnd -= GainItemsToMainInventory;
            
        }
        private void GainItemToTempInventory(IGainable gainable)
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


            item.JoinTempInventory(_tempItemsList,OnTempItemGained);

            

           
        }
        
        
        private void GainItemsToMainInventory()
        {
            for (int i = 0; i < _tempItemsList.Count; i++)
            {
                _itemsList.Add(_tempItemsList[i]);
                

            }

            _tempItemsList = new List<BaseItem>();

            OnMainItemsGained?.Invoke(_itemsList);

        }

        public void RemoveAllItems()
        {

            
            _tempItemsList = new List<BaseItem>();

            OnAllTempItemLose?.Invoke();


        }

        

        



    }
}

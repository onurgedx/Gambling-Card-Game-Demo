using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Managers
{

    public class ManagerInventory : MonoSingleton<ManagerInventory>
    {

        
        private List<IItem> _items;

        public void AddItem(IItem item)
        {
            _items.Add(item);

        }
        public void RemoveItem(IItem item)
        {
            _items.Remove(item);

        }


        



    }
}

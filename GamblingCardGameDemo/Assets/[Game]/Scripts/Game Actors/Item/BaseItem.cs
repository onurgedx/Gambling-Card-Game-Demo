using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseItem : IItem
{

    private GainableData _gainableData;
    

    public BaseItem(GainableData gainableData)
    {
        _gainableData = gainableData;
       


    }
   
    
    public GainableData GetGainableData()
    {
        return _gainableData;
    }
   
    public virtual void JoinInventory(List<BaseItem> items,Action<int, BaseItem> onJoinInventory)
    {
        items.Add(this);
        onJoinInventory?.Invoke(items.Count,this);


    }


}

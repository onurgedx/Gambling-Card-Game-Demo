using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Game.Managers;

public class BombLoseItem : BaseItem
{
    public BombLoseItem(GainableData gainableData) : base(gainableData)
    {

    }

    public override void JoinInventory(List<BaseItem> items, Action<int, BaseItem> onJoinInventory)
    {
        ManagerInventory.Instance.RemoveAllItems();


    }
}

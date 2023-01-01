using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Game.Managers;

public class ItemCountTextUpdater : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI _textItemCount;

    private void OnEnable()
    {
        ManagerInventory.Instance.OnItemGained += UpdateItemCount ;
        ManagerInventory.Instance.OnAllItemLose += UpdateItemCount;
        
    }
    private void OnDisable()
    {
        ManagerInventory.Instance.OnItemGained -= UpdateItemCount ;
        ManagerInventory.Instance.OnAllItemLose -= UpdateItemCount;
        
    }
    private void UpdateItemCount(int itemCount)
    {
        _textItemCount.text = itemCount.ToString();

    }


    private void UpdateItemCount()
    {
        _textItemCount.text = "0";

    }

}

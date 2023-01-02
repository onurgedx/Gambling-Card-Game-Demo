using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Game.Managers;

public class InventoryMainItemCountUpdater : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textMainItemCount;


    private void OnEnable()
    {
        ManagerInventory.Instance.OnMainItemsGained += UpdateMainItemCount;


    }

    private void OnDisable()
    {
        ManagerInventory.Instance.OnMainItemsGained -= UpdateMainItemCount;


    }

    private void UpdateMainItemCount(List<BaseItem> items)
    {
        _textMainItemCount.text = items.Count.ToString();

    }

}

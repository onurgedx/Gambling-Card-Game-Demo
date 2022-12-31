using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Game.Managers;

public class WheelButtonInteractableController : MonoBehaviour
{

    [SerializeField] private WheelData _wheelData;
    [SerializeField] private Button _myButton;

    private void Start()
    {
        ManagerCurrency.Instance.OnCurrencyAmountChanged += AdjustInteractableButton;
        
    }

    private void AdjustInteractableButton(int currencyAmount)
    {
        bool isAfford = _wheelData.SpinCost < currencyAmount;
        if (isAfford)
        {
            ActivateInteractable();


        }
        else
        {
            DeactivateInteractable();
        }
      
        

    }


    private void ActivateInteractable()
    {
        if (_myButton.interactable != true)
        {
        _myButton.interactable = true;

        }
    }

    private void DeactivateInteractable()
    {
        if (_myButton.interactable != false)
        {
        _myButton.interactable = false;

        }
    }




    
}

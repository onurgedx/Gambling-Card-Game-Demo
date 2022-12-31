using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Game.Managers;

public class CurrencyTextUpdater : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI _text;


    private void OnEnable()
    {
        ManagerCurrency.Instance.OnCurrencyAmountChanged += UpdateCurrencyText;
        UpdateCurrencyText(ManagerCurrency.Instance.CurrencyAmount);
        
    }
    private void OnDisable()
    {
        ManagerCurrency.Instance.OnCurrencyAmountChanged -= UpdateCurrencyText;


    }
    private void UpdateCurrencyText(int currencyAmount)
    {
        _text.text = currencyAmount.ToString();
    }






    
}

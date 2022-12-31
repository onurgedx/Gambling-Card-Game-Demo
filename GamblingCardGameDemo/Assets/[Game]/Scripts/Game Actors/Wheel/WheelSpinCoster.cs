using Game.Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[DefaultExecutionOrder(4)]
public class WheelSpinCoster : MonoBehaviour
{

    [SerializeField] private WheelData _wheelData;

    [SerializeField] private Button _myButton;

    private void Start()
    {
        _myButton.onClick.AddListener(CostForSpin);
        
    }

    private void CostForSpin()
    {
        ManagerCurrency.Instance.DecreaseCurrency(_wheelData.SpinCost);



    }


    
}

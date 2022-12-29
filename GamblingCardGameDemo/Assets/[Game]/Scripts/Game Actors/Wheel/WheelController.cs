using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class WheelController : MonoBehaviour
{
    public Action WheelSpinEvent;
    [SerializeField] private Button _buttonSpin;

    private void OnEnable()
    {
        _buttonSpin.onClick.AddListener(RunWheelSpinEvent);
        
    }
    private void OnDisable()
    {
        _buttonSpin.onClick.RemoveListener(RunWheelSpinEvent);
    }

    private void RunWheelSpinEvent()
    {

        WheelSpinEvent?.Invoke();

    }



    
}

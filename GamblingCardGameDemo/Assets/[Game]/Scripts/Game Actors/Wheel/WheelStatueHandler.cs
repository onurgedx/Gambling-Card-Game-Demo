using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Enums;
using System;

public class WheelStatueHandler : MonoBehaviour
{
    [SerializeField] private WheelSpiner _wheelSpiner;

    private WheelStatuesEnum _wheelStatue = WheelStatuesEnum.Default;

    public Action OnWheelStatueDefault;
    public Action OnWheelStatueSpining;
    public WheelStatuesEnum WheelStatue
    {
        get
        {
            return _wheelStatue;
        }

    }


    private void OnEnable()
    {
        _wheelSpiner.OnSpinStart += SetWheelStatueSpining;
        _wheelSpiner.OnSpinEndDelayed += SetWheelStatueDefault;

    }
    private void SetWheelStatueDefault()
    {

            _wheelStatue = WheelStatuesEnum.Default;

            OnWheelStatueDefault?.Invoke();
        



    }

    private void SetWheelStatueSpining()
    {
        
        _wheelStatue = WheelStatuesEnum.Spining;

        OnWheelStatueSpining?.Invoke();


    }

}

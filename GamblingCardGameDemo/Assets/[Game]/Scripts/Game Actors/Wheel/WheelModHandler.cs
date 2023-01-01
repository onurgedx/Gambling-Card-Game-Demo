using Game.Enums;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelModHandler : MonoBehaviour
{
    [SerializeField] private WheelGainableSpawner _wheelGainableSpawner;
    [SerializeField] private WheelSpinCounter _wheelSpinCounter;
    public Action<WheelModsEnum> OnWheelModChanged;

    private WheelModsEnum _wheelMod= WheelModsEnum.Bronze;
    public WheelModsEnum WheelMod
    {
        get
        {
            return _wheelMod;
        }

        set
        {
            if (_wheelMod != value)
            {
                _wheelMod = value;
                OnWheelModChanged?.Invoke(_wheelMod);
            }


        }
    }

    
    private void OnEnable()
    {
        _wheelSpinCounter.OnSpinCountChanged += UpdateWheelMod;
        _wheelGainableSpawner.WheelModHandler += GetWheelMod;

    }

    private void OnDisable()
    {
        _wheelSpinCounter.OnSpinCountChanged -= UpdateWheelMod;
        _wheelGainableSpawner.WheelModHandler -= GetWheelMod;
    }
    private void UpdateWheelMod(int spinCount)
    {

        WheelModsEnum temp_wheelMod;

        if (spinCount % 30 == 0)
        {
            temp_wheelMod = WheelModsEnum.Gold;


        }
        else if (spinCount % 5 == 0)
        {
            temp_wheelMod = WheelModsEnum.Silver;
        }
        else
        {

            temp_wheelMod = WheelModsEnum.Bronze;

        }

        WheelMod = temp_wheelMod;

    }


    private WheelModsEnum GetWheelMod()
    {
        return WheelMod;
    }


}

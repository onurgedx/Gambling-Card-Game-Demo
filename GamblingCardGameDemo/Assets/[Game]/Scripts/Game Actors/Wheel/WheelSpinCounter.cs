using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelSpinCounter : MonoBehaviour
{
    [SerializeField] private WheelSpiner _wheelSpiner;
    public Action<int> OnSpinCountChanged;

    private int _spinCount = 0;
    public int SpinCount
    {
        get
        {
            return _spinCount;
        }

        set
        {
            if (value != _spinCount)
            {


                _spinCount = value;

                OnSpinCountChanged?.Invoke(_spinCount);



            }
        }

    }
    private void Start()
    {
        _wheelSpiner.OnSpinEnd += IncreaseSpinCount;
    }
    private void IncreaseSpinCount()
    {
        SpinCount++;
    }





}

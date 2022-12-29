using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Managers;
public class WheelSpiner : MonoBehaviour
{

    

    public Action OnSpinStart;
    public Action OnSpinEnd;
    [SerializeField] private Transform _wheelTransform;
    [SerializeField] private WheelController _wheelController;

    private void OnEnable()
    {
        _wheelController.WheelSpinEvent += Spin;
        
    }
    private void OnDisable()
    {
        _wheelController.WheelSpinEvent -= Spin;
    }
    private void Spin()
    {

        ManagerWheelSpiner.Instance.SpinWheel(OnSpinStart, OnSpinEnd, _wheelTransform);
    }



    
}

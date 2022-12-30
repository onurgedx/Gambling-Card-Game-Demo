using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Managers;
using Game.Interfaces;

public class WheelSpinResult : MonoBehaviour
{

    [SerializeField] private Transform _indicatorTransform;
    [SerializeField] private WheelSpiner _wheelSpiner;
   

    public delegate List<IGainable> GainableListDelegate();

    public GainableListDelegate GainableList;

    private void OnEnable()
    {
        _wheelSpiner.OnSpinEnd += CalculateResult;
        
    }

    private void OnDisable()
    {
        _wheelSpiner.OnSpinEnd -= CalculateResult;
        
    }


    private void CalculateResult()
    {
        ManagerResultSpinWheel.Instance.DetermineGainedItem(GainableList(), _indicatorTransform.position);

    }






}

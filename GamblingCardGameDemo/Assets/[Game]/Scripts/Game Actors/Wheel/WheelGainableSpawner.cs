using Game.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;
using Game.Managers;
using Game.Enums;
[DefaultExecutionOrder(8)]
public class WheelGainableSpawner : MonoBehaviour
{

     private List<IGainable> _gainablesList = new List<IGainable>();
    [SerializeField] private WheelSpiner _wheelSpiner;
    [SerializeField] private WheelSpinResult _wheelSpinResult;
    

    public delegate WheelModsEnum WheelModeDelegate();
    public WheelModeDelegate WheelModHandler;

    private void OnEnable()
    {
        _wheelSpiner.OnSpinEndDelayed += SpawnGainables;
        _wheelSpinResult.GainableList = GetGainables;
        

    }

    private void OnDisable()
    {
        _wheelSpiner.OnSpinEndDelayed -= SpawnGainables;
        

    }
    private void Start()
    {

        _gainablesList = GetComponentsInChildren<IGainable>().ToList();
        SpawnGainables();

    }



    private void SpawnGainables()
    {
        ManagerGainableSpawner.Instance.DetermineNewGainables(_gainablesList, WheelModHandler());

    }

    private List<IGainable> GetGainables()
    {
        return _gainablesList;
    }


}

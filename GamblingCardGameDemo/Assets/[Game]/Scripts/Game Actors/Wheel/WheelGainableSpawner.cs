using Game.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;
using Game.Managers;
public class WheelGainableSpawner : MonoBehaviour
{

     private List<IGainable> _gainablesList = new List<IGainable>();
    [SerializeField] private WheelSpiner _wheelSpiner;

    private void OnEnable()
    {
        _wheelSpiner.OnSpinEndDelayed += SpawnGainables;
        
    }

    private void OnDisable()
    {
        _wheelSpiner.OnSpinEndDelayed -= SpawnGainables;
        

    }
    private void Start()
    {

        _gainablesList = GetComponentsInChildren<IGainable>().ToList();

        
    }



    private void SpawnGainables()
    {
        ManagerGainableSpawner.Instance.DetermineNewGainables(_gainablesList);

    }



}

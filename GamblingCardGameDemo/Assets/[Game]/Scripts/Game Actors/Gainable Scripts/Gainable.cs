using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Interfaces;
using Game.Managers;
public class Gainable : MonoBehaviour ,IGainable
{

    public Action<GainableData> OnGainableDataChanged;

    private GainableData _gainableData;

    



    

    public void SetGainableData(GainableData gainableData)
    {

        _gainableData = gainableData;


        OnGainableDataChanged?.Invoke(_gainableData);

    }





}

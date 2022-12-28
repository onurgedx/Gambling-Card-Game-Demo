using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Managers
{

    public class ManagerDataGainables : MonoSingleton<ManagerDataGainables>
    {

        [SerializeField] private List<GainableData> _gainableDataList;
        
        public GainableData GetRandomGainableData()
        {

            int randomIndexForGainableData;
            randomIndexForGainableData = Random.Range(0, _gainableDataList.Count);

            return _gainableDataList[randomIndexForGainableData];

        }


    }

}
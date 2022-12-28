using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Managers
{

    public class ManagerDataGainables : MonoSingleton<ManagerDataGainables>
    {

        [SerializeField] private List<GainableData> _gainableDataList;
        

    }

}
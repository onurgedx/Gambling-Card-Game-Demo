using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Interfaces;
using Game.Enums;

namespace Game.Managers
{
    public class ManagerGainableSpawner : MonoSingleton<ManagerGainableSpawner>
    {


        public delegate GainableData GainableDataDelegate(WheelModsEnum wheelMod);
        public GainableDataDelegate GetGainableData;
        private void Start()
        {
            GetGainableData = ManagerDataGainables.Instance.GetRandomGainableData;

        }
        public void DetermineNewGainables(List<IGainable> gainablesList , WheelModsEnum wheelMod)
        {





      

            for (int i = 0; i < gainablesList.Count; i++)
            {
                

                gainablesList[i].SetGainableData(GetGainableData?.Invoke(wheelMod));

            }

        }

    

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Interfaces;
namespace Game.Managers
{
    public class ManagerGainableSpawner : MonoSingleton<ManagerGainableSpawner>
    {

        
       


        public void DetermineNewGainables(List<IGainable> gainablesList )
        {

            for (int i = 0; i < gainablesList.Count; i++)
            {
                gainablesList[i].SetGainableData(ManagerDataGainables.Instance.GetRandomGainableData());


            }

        }

        



    }
}

using Game.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Game.Managers
{

    public class ManagerResultSpinWheel : MonoSingleton<ManagerResultSpinWheel>
    {

        public Action<IGainable> OnResultDetermined;



        public void DetermineGainedItem(List<IGainable> gainablesList, Vector3 indicatorPosition)
        {
            IGainable tempGainable = null;

            float closestDistance = 100000;
            for (int i = 0; i < gainablesList.Count; i++)
            {
                if (tempGainable == null)
                {
                    tempGainable = gainablesList[i];
                    closestDistance = ( indicatorPosition - tempGainable.GetPosition()).sqrMagnitude;
                    continue;
                }
                
                

                float tempDistance = (indicatorPosition-gainablesList[i].GetPosition()).sqrMagnitude;

                if (closestDistance > tempDistance)
                {
                    closestDistance = tempDistance;
                    tempGainable = gainablesList[i];
                }
                


            }

            
            OnResultDetermined?.Invoke(tempGainable);
            

            

            

        }









    }

}
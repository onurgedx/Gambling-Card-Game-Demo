using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Interfaces;
namespace Game.Managers
{
    public class ManagerGainableSpawner : MonoSingleton<ManagerGainableSpawner>
    {

        [SerializeField] private List<IGainable> _gainables;
         
        public void AddGainable(IGainable  gainable)
        {

            _gainables.Add(gainable);

        }

        public void RemoveGainable(IGainable gainable)
        {

            _gainables.Remove(gainable);


        }


        private void DetermineNewGainables()
        {

            for (int i = 0; i < _gainables.Count; i++)
            {
                //_gainables[i].SetGainableData();


            }

        }

        



    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Interfaces;
namespace Game.Managers
{
    public class ManagerGainableSpawner : MonoSingleton<ManagerGainableSpawner>
    {

        [SerializeField] private List<IGainable> _gainables= new List<IGainable>();

        private void OnEnable()
        {
            ManagerTest.Instance.OnKeyADown += DetermineNewGainables;


        }
        private void OnDisable()
        {
            ManagerTest.Instance.OnKeyADown -= DetermineNewGainables;
            
        }
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
                _gainables[i].SetGainableData(ManagerDataGainables.Instance.GetRandomGainableData());


            }

        }

        



    }
}

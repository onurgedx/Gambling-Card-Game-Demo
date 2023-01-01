using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Managers
{
    public class ManagerLevel : MonoSingleton<ManagerLevel>
    {
        public Action OnLevelStart;
        public Action OnLevelEnd;


        private void Start()
        {
            ManagerUiButtons.Instance.StartButton.onClick.AddListener(StartLevel);
            ManagerUiButtons.Instance.MenuButton.onClick.AddListener(EndLevel);
           
            
        }


        private void StartLevel()
        {
            OnLevelStart?.Invoke();

        }

        private void EndLevel()
        {
            OnLevelEnd?.Invoke();
        }




    }


}

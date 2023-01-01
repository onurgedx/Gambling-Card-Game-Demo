using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



namespace Game.Managers
{


    public class ManagerUi : MonoSingleton<ManagerUi>
    {

        [SerializeField] private GameObject _menu;
        [SerializeField] private GameObject _level;


        private void Start()
        {
            ManagerLevel.Instance.OnLevelStart += ActivateLevel;
            ManagerLevel.Instance.OnLevelStart += DeactivateMenu;

            ManagerLevel.Instance.OnLevelEnd += ActivateMenu;
            ManagerLevel.Instance.OnLevelEnd += DeactivateLevel;
        }

        private void ActivateLevel()
        {

            _level.SetActive(true);

        }
        
        private void DeactivateLevel()
        {

            _level.SetActive(false);

        }


        private void ActivateMenu()
        {
            _menu.SetActive(true);
        }

        private void DeactivateMenu()
        {
            _menu.SetActive(false);
        }

    }


}
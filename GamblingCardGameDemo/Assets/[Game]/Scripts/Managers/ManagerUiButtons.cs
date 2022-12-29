using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Managers
{

    public class ManagerUiButtons : MonoSingleton<ManagerUiButtons>
    {



        public Button ButtonSpin;



        private void OnValidate()
        {
            ButtonSpin = GameObject.Find(GlobalStrings.ui_spin_button_spin).GetComponent<Button>();
            
        }





    }

}
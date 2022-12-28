using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Managers
{

    public class ManagerTest : MonoSingleton<ManagerTest>
    {


        public Action OnKeyADown;




        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.A)){
                OnKeyADown?.Invoke();

            }

        }



    }

}
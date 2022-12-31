using Game.Enums;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Managers
{

    public class ManagerSpinCounter : MonoSingleton<ManagerSpinCounter>
    {



        public Action<int> OnSpinCountChanged;

        private int _spinCount = 0;
        public int SpinCount
        {
            get
            {
                return _spinCount;
            }

            set
            {
                if (value != _spinCount)
                {

                    _spinCount = value;
                    OnSpinCountChanged?.Invoke(_spinCount);

                   
                   


                }
            }

        }



    }

}
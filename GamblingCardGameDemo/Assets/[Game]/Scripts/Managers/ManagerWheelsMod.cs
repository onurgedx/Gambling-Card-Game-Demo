using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Enums;

namespace Game.Managers
{

    public class ManagerWheelsMod : MonoSingleton<ManagerWheelsMod>
    {
        private WheelModsEnum _wheelMod = WheelModsEnum.Bronze;
        public WheelModsEnum WheelMod
        {
            get { return _wheelMod; }
            set
            {

                if(_wheelMod != value)
                {
                    _wheelMod = value;
                    OnWheelModChanged?.Invoke(_wheelMod);

                }

            }
        }

        public Action<WheelModsEnum> OnWheelModChanged;

        private void OnEnable()
        {
            ManagerSpinCounter.Instance.OnSpinCountChanged += UpdateWheelMod;
        }
        private void OnDisable()
        {
            ManagerSpinCounter.Instance.OnSpinCountChanged -= UpdateWheelMod;
            
        }


        private void UpdateWheelMod(int spinCount)
        {
            bool isGold = spinCount % (int)WheelModsEnum.Gold == 0;
            bool isSilver = spinCount % (int)WheelModsEnum.Silver == 0;
            WheelModsEnum wheelMod= WheelModsEnum.Bronze;
            if (isGold)
            {
                wheelMod = WheelModsEnum.Gold;
            }
            else if(isSilver)
            {
                wheelMod = WheelModsEnum.Silver;
            }
            else
            {
                wheelMod = WheelModsEnum.Bronze;

            }
            WheelMod = wheelMod;





        }





    }

}
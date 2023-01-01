using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Managers
{

   
    public class ManagerCurrency : MonoSingleton<ManagerCurrency>
    {

        private int _currencyAmount = 0;
        public Action<int> OnCurrencyAmountChanged;
        public Action<int> OnCurrencyAmountDecreased;
        public Action<int> OnCurrencyAmountIncreased;
        public int CurrencyAmount
        {
            get
            {
                return _currencyAmount;
            }

            set
            {

                if (_currencyAmount != value)
                {
                    if (value > _currencyAmount)
                    {
                        OnCurrencyAmountIncreased?.Invoke(value);
                    }
                    else
                    {
                        OnCurrencyAmountDecreased?.Invoke(value);
                    }

                
                    _currencyAmount = Mathf.Clamp( value ,14,100000);

                    OnCurrencyAmountChanged?.Invoke(_currencyAmount);

                    PlayerPrefs.SetInt(GlobalStrings.CurrencyAmount, _currencyAmount);
                }
                
                

            }
        }
        private void Start()
        {
            CurrencyAmount = PlayerPrefs.GetInt(GlobalStrings.CurrencyAmount,100);
            
        }



        public void DecreaseCurrency(int decreaseAmount)
        {
            CurrencyAmount -= decreaseAmount;

        }

        public void IncreaseCurrency(int increaseAmount)
        {
            CurrencyAmount += increaseAmount;

        }


    }
}

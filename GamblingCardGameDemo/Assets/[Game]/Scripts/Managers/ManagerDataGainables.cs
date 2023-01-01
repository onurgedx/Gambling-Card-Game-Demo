using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using Game.Enums;
namespace Game.Managers
{

    public class ManagerDataGainables : MonoSingleton<ManagerDataGainables>
    {

        
        [SerializeField] private List<GainableData> _gainableDataList=new List<GainableData>();

         private List<GainableData> _gainableBronzeDataList = new List<GainableData>();

        private List<GainableData> _gainableSilverDataList = new List<GainableData>();

        private List<GainableData> _gainableGoldDataList = new List<GainableData>();

        



        private void Start()
        {

            _gainableBronzeDataList= _gainableDataList.FindAll(value => value.Value == Enums.ValuesEnum.Bronze);
            _gainableSilverDataList= _gainableDataList.FindAll(value => value.Value == Enums.ValuesEnum.Silver);
            _gainableGoldDataList= _gainableDataList.FindAll(value => value.Value == Enums.ValuesEnum.Gold);


        }


        

        public GainableData GetRandomGainableData(WheelModsEnum wheelMod)
        {
            int randomIndexForGainableData;
            randomIndexForGainableData = Random.Range(0, GetGainableDatasAccordingToWheelMod(wheelMod).Count);

            return GetGainableDatasAccordingToWheelMod(wheelMod)[randomIndexForGainableData];

        }
        private List<GainableData> GetGainableDatasAccordingToWheelMod(WheelModsEnum wheelMod)
        {
            switch (wheelMod)
            {
                case WheelModsEnum.Bronze:
                    return _gainableBronzeDataList;

                case WheelModsEnum.Silver:
                    return _gainableSilverDataList;
                case WheelModsEnum.Gold:
                    return _gainableGoldDataList;
            }

            return _gainableDataList;

        }
        
        

    }

}
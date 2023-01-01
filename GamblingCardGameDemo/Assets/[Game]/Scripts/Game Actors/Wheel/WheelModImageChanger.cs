using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Enums;
using Game.Managers;
using UnityEngine.UI;

public class WheelModImageChanger : MonoBehaviour
{



    [SerializeField] private WheelImageTypesData _wheelImageTypesData;
    [SerializeField] private Image _wheelImage;
    [SerializeField] private Image _indicatorImage;
    [SerializeField] private WheelModHandler _wheelModHandler;

    private WheelModsEnum _wheelMod = WheelModsEnum.Bronze;

    private void OnEnable()
    {
        _wheelModHandler.OnWheelModChanged += SetProperImages;
        
    }

    private void OnDisable()
    {

        _wheelModHandler.OnWheelModChanged -= SetProperImages;

    }
  

    private void SetProperImages(WheelModsEnum wheelMod)
    {
       

      

        if (wheelMod == _wheelMod) return;
        _wheelMod = wheelMod;

        List<Sprite> spritesWheelAndIndicator = new List<Sprite>();


        switch (wheelMod)
        {

            case WheelModsEnum.Bronze:
                spritesWheelAndIndicator = _wheelImageTypesData.WheelAndIndicatorBronze;


                break;
            case WheelModsEnum.Silver:

                spritesWheelAndIndicator = _wheelImageTypesData.WheelAndIndicatorSilver;
                break;

            case WheelModsEnum.Gold:
                spritesWheelAndIndicator = _wheelImageTypesData.WheelAndIndicatorGold;

                break;

        }

        _wheelImage.sprite = spritesWheelAndIndicator[0];
        _indicatorImage.sprite = spritesWheelAndIndicator[1];

    }












}

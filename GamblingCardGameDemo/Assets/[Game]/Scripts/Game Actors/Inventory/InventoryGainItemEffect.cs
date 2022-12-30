using Game.Interfaces;
using Game.Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class InventoryGainItemEffect : MonoBehaviour
{
    [SerializeField] private Transform _inventoryImageTransform;


    private void OnEnable()
    {
        ManagerResultSpinWheel.Instance.OnResultDetermined += EffectProcess;
        
    }
    private void OnDisable()
    {
        ManagerResultSpinWheel.Instance.OnResultDetermined -= EffectProcess;
        
    }
    private void EffectProcess(IGainable gainable)
    {


       Image imageOfFakeEffectGain = ManagerObjectPooling.Instance.ImageForItemEffectPool.GetPoolMember();
        imageOfFakeEffectGain.transform.position = gainable.GetPosition();
        imageOfFakeEffectGain.sprite = gainable.GetGainableData().GainableSprite;
        imageOfFakeEffectGain.transform.DOMove(_inventoryImageTransform.position, Durations.DurationArriveToInventoryImagePosition)
            .OnComplete(()=>imageOfFakeEffectGain.gameObject.SetActive(false));

    }
   
}

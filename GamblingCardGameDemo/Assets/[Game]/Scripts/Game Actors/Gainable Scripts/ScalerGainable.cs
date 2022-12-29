using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class ScalerGainable : MonoBehaviour
{
    [SerializeField] private Gainable _gainable;
    [SerializeField] private Transform _transformImage;
   

    private void OnEnable()
    {
        _gainable.OnGainableDataChanged += RunScaleIncreaseEffect;
    }
    private void OnDisable()
    {
        _gainable.OnGainableDataChanged -= RunScaleIncreaseEffect;
        
    }


    private void RunScaleIncreaseEffect(GainableData gainableData)
    {
        _transformImage.localScale = Vector3.zero;
        _transformImage.DOScale(1, Durations.DurationGainableArriveDestinationScale);

    }
}

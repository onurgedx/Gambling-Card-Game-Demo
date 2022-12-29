using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


namespace Game.Managers
{

    public class ManagerWheelSpiner : MonoSingleton<ManagerWheelSpiner>
    {


        

        [SerializeField] private WheelRotateData _wheelRotateData;
         






        public void SpinWheel(Action onSpinStart, Action onSpinEnd, Transform wheelTransform)
        {
            onSpinStart?.Invoke();
            int randomindex = _wheelRotateData.GetRandomIndexAtAnglesList();
            
            wheelTransform.localRotation = Quaternion.identity;
            wheelTransform.DOLocalRotate(new Vector3(0, 0, _wheelRotateData.GetDesiredDestination(randomIndex:randomindex)), Durations.DurationWheelSpin, RotateMode.FastBeyond360)
                .SetRelative(true).SetEase(Ease.OutBack)
                .OnComplete(()=>onSpinEnd?.Invoke());


        }






    }
}

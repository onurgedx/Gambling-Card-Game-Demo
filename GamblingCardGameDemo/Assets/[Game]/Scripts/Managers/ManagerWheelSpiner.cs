using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


namespace Game.Managers
{

    public class ManagerWheelSpiner : MonoSingleton<ManagerWheelSpiner>
    {


        public Action OnWheelSpin;
        
        public Action OnWheelSpinStart;
        
        public Action OnWheelSpinEnd;

        [SerializeField] private WheelRotateData _wheelRotateData;
         




        [SerializeField] private Transform _wheelTransform;


        private void OnEnable()
        {
            ManagerUiButtons.Instance.ButtonSpin.onClick.AddListener( SpinWheel);
            
        }
        private void OnDisable()
        {
            ManagerUiButtons.Instance.ButtonSpin.onClick.RemoveListener( SpinWheel);
            
        }



        private void SpinWheel()
        {
            int randomindex = _wheelRotateData.GetRandomIndexAtAnglesList();
            OnWheelSpinStart?.Invoke();
            _wheelTransform.localRotation = Quaternion.identity;
            _wheelTransform.DOLocalRotate(new Vector3(0, 0, _wheelRotateData.GetDesiredDestination(randomIndex:randomindex)), Durations.DurationWheelSpin, RotateMode.FastBeyond360)
                .SetRelative(true).SetEase(Ease.OutBack)
                .OnComplete(()=>OnWheelSpinEnd?.Invoke());


        }






    }
}

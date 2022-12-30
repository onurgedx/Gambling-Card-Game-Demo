using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Managers;
public class WheelSpiner : MonoBehaviour
{

    

    public Action OnSpinStart;
    public Action OnSpinEnd;
    public Action OnSpinEndDelayed;
    
    [SerializeField] private Transform _wheelTransform;
    [SerializeField] private WheelController _wheelController;

    private WaitForSeconds _waitforSecondsOfSpinEndDelay;
    private void Start()
    {
        _waitforSecondsOfSpinEndDelay = new WaitForSeconds(Durations.DurationDelayAfterSpinEnd);
        OnSpinEnd += RunAfterAWhileSpinEnd;
       

    }

    
    private void OnEnable()
    {
        _wheelController.WheelSpinEvent += Spin;
    
        
    }
    private void OnDisable()
    {
        _wheelController.WheelSpinEvent -= Spin;
    }
    private void Spin()
    {

        ManagerWheelSpiner.Instance.SpinWheel(OnSpinStart, OnSpinEnd, _wheelTransform);
    }

    private void RunAfterAWhileSpinEnd()
    {
        StartCoroutine(DelayedSpinEndIEnumerator());

        IEnumerator DelayedSpinEndIEnumerator()
        {
            yield return _waitforSecondsOfSpinEndDelay;

            OnSpinEndDelayed?.Invoke();

        }

    }


    
}

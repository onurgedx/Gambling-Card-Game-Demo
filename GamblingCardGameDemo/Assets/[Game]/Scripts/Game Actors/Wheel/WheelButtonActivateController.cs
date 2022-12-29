using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class WheelButtonActivateController : MonoBehaviour
{

    [SerializeField] private Button _buttonSpin;
    [SerializeField] private WheelSpiner _wheelSpiner;


    private void Start()
    {
        _buttonSpin.onClick.AddListener(DeactivateButton);
        _wheelSpiner.OnAfterAWhileSpinEnd += ActivateButton ;
        
    }
    private void ActivateButton()
    {
        _buttonSpin.gameObject.SetActive(true);
    }

    private void DeactivateButton()
    {
        _buttonSpin.gameObject.SetActive(false);
    }


}

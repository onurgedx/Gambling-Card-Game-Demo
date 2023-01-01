using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class WheelSpinCountDisplayer : MonoBehaviour
{
    
    
    
    [SerializeField] private WheelSpinCounter _wheelSpinCounter;

    [SerializeField] private TextMeshProUGUI _textSpinCount;


    private void OnEnable()
    {

        _wheelSpinCounter.OnSpinCountChanged += UpdateSpinCountText;
        
    }
    private void OnDisable()
    {
        
        _wheelSpinCounter.OnSpinCountChanged -= UpdateSpinCountText;
    
    }


    private void UpdateSpinCountText(int spinCount)
    {
        _textSpinCount.text =  spinCount.ToString();

    }



    



    
}

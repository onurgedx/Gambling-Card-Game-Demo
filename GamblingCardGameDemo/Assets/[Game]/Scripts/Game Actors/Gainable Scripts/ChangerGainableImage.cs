using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChangerGainableImage : MonoBehaviour
{

    
    [SerializeField] private Gainable _deciderGainable;
    [SerializeField] private Image _gainableImage;

    private void OnEnable()
    {
        _deciderGainable.OnGainableDataChanged += SetGainableImage;
        
    }


    private void OnDisable()
    {

        _deciderGainable.OnGainableDataChanged -= SetGainableImage;
        
    }

    private void SetGainableImage(GainableData gainableData)
    {
        _gainableImage.sprite = gainableData.GainableSprite; 

    }

}

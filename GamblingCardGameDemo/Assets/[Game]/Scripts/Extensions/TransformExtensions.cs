using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public static class TransformExtensions 
{
    

    public static void DeactivateAfterXSeconds(this Transform myTransform,float xSeconds)
    {

        DOVirtual.DelayedCall(xSeconds, () => myTransform.gameObject.SetActive(false));

    }
   



}

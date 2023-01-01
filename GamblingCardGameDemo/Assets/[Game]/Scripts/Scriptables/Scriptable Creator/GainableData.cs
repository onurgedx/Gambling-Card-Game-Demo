using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using Game.Enums;
using UnityEngine.UI;

[CreateAssetMenu(fileName ="GainableData",menuName ="Scriptables/GainableData")]
public class GainableData : ScriptableObject
{
        
    public Sprite  GainableSprite;
    public ValuesEnum Value = ValuesEnum.Bronze;
    public int ValueAsMoney = 10;
    public GainableTypeEnum GainableType = GainableTypeEnum.Chest;
    [Range(0,1)]
    public float DropRate=0.5f;
    
    
}

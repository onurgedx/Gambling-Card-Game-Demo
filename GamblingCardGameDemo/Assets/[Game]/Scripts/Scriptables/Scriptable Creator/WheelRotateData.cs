using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="WheelRotateData",menuName ="Scriptables/WheelRotateData")]
public class WheelRotateData : ScriptableObject
{
   [SerializeField] private List<float> _wheelDestinationAnglesList = new List<float>();
    
    public float GetRandomDestination()
    {
        return _wheelDestinationAnglesList[Random.Range(0, _wheelDestinationAnglesList.Count)];
    }

}

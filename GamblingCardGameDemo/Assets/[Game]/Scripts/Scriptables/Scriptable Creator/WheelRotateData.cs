using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="WheelRotateData",menuName ="Scriptables/WheelRotateData")]
public class WheelRotateData : ScriptableObject
{
   [SerializeField] private List<float> _wheelDestinationAnglesList = new List<float>();
    
    public int GetRandomIndexAtAnglesList()
    {
        return Random.Range(0, _wheelDestinationAnglesList.Count);
    }
    public float GetDesiredDestination(int randomIndex)
    {
        return _wheelDestinationAnglesList[randomIndex];
    }
    

}

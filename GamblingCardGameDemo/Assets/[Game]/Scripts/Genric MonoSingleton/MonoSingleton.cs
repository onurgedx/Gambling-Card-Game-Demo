using UnityEngine;
public class MonoSingleton<T> : MonoBehaviour where T : MonoSingleton<T>
{
    // volatile avoids unwanted situations by case of multithread (example creating more than one instance) 
    private static volatile T _instance;

    public static T Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType(typeof(T)) as T;
            }
            return _instance;

        }

    }

}

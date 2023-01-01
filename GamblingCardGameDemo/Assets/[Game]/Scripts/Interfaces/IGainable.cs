using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Game.Interfaces
{

    public interface IGainable
    {
        public void SetGainableData(GainableData gainableData);

        public Vector3 GetPosition();

        public GainableData GetGainableData();



    }

}
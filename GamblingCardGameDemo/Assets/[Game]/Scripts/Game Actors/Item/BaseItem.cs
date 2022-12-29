using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseItem : IItem
{

    private GainableData _gainableData;
    

    public BaseItem(GainableData gainableData)
    {
        _gainableData = gainableData;



    }


}

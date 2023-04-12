using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Stats 
{
    [SerializeField]
    [Range(0,50)]
    private int baseValue;

    public int GetValue()
    {
        return baseValue;
    }


    
}

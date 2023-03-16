using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileChecker : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 thisTileLocation;
    Vector3[] _tileNumberArray;
    
    void Awake()
    {
        thisTileLocation = this.gameObject.transform.position;
        _tileNumberArray = new Vector3[4];
    }
    void Start()
    {
        _tileNumberArray[0] = thisTileLocation + new Vector3(10,0,0);
        _tileNumberArray[1] = thisTileLocation + new Vector3(0,0,10);
        _tileNumberArray[2] = thisTileLocation + new Vector3(-10,0,0);
        _tileNumberArray[3] = thisTileLocation + new Vector3(0,0,-10);

        foreach(Vector3 number in _tileNumberArray)
        {
            /*
            if you are next to player, make your number 1

            else if you are not next to player, check for lowest number between objects, add 1 and that becomes your number

            else print an error
            */
        }    
    }


}

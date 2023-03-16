using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileCreator : MonoBehaviour
{
    [Header("weewoo")]
    public GameObject tiles;
    public int unitMoveLength = 7;
    private Vector3 thisUnitLocation;
    public List<Vector3> thisUnitMovement = new List<Vector3>();
    [Header("weewoo")]
    Vector3[,] _numberArray;

    // positive and negative axis as they need to be instantiated multiple 
    // times to ensure path is correct
    private int xAxis;
    private int yAxis;
    private int nyAxis;
    private int nxAxis;

    

    //private int thisUnitMovement = 7;


    // Start is called before the first frame update
    void Awake()
    {
        _numberArray = new Vector3[unitMoveLength,unitMoveLength];
        thisUnitLocation = this.gameObject.transform.position;

    }
    void Start()
    {
        for(int xAxis = 0; xAxis < unitMoveLength; xAxis++)
        {
            for(int yAxis = 0; yAxis < unitMoveLength; yAxis++)
            {
                //_numberArray[xAxis,yAxis] = xAxis; 
                
                if ((xAxis + yAxis) < unitMoveLength &&(xAxis+yAxis !=0))
                {
                    _numberArray[xAxis,yAxis] = thisUnitLocation + new Vector3(10*yAxis,0,10*xAxis);
                    print(_numberArray[xAxis,yAxis]);
                    Instantiate(tiles, _numberArray[xAxis,yAxis], Quaternion.identity);
                }
            }
        }
        for(int xAxis = 1; xAxis < unitMoveLength; xAxis++)
        {
            for(int yAxis = 1; yAxis < unitMoveLength; yAxis++)
            {
                //_numberArray[xAxis,yAxis] = xAxis; 
                
                if ((xAxis + yAxis) < unitMoveLength && (xAxis+yAxis !=0))
                {
                    _numberArray[xAxis,yAxis] = thisUnitLocation + new Vector3(-10*yAxis,0,10*xAxis);
                    print(_numberArray[xAxis,yAxis]);
                    Instantiate(tiles, _numberArray[xAxis,yAxis], Quaternion.identity);
                }
            }
        }
        for(int xAxis = 1; xAxis < unitMoveLength; xAxis++)
        {
            for(int yAxis = 1; yAxis < unitMoveLength; yAxis++)
            {
                //_numberArray[xAxis,yAxis] = xAxis; 
                
                if ((xAxis + yAxis) < unitMoveLength && (xAxis+yAxis !=0))
                {
                    _numberArray[xAxis,yAxis] = thisUnitLocation + new Vector3(10*yAxis,0,-10*xAxis);
                    print(_numberArray[xAxis,yAxis]);
                    Instantiate(tiles, _numberArray[xAxis,yAxis], Quaternion.identity);
                }
            }
        }
        for(int xAxis = 0; xAxis < unitMoveLength; xAxis++)
        {
            for(int yAxis = 0; yAxis < unitMoveLength; yAxis++)
            {
                //_numberArray[xAxis,yAxis] = xAxis; 
                
                if ((xAxis + yAxis) < unitMoveLength)
                {
                    _numberArray[xAxis,yAxis] = thisUnitLocation + new Vector3(-10*yAxis,0,-10*xAxis);
                    print(_numberArray[xAxis,yAxis]);
                    Instantiate(tiles, _numberArray[xAxis,yAxis], Quaternion.identity);
                }
    
                //thisUnitLocation.position + new Vector3(10 * yAxis, 10* xAxis, 0);
                //print(_numberArray[xAxis,yAxis]);
                //thisUnitMovement.Add(thisUnitLocation.position + new Vector3(10*yAxis,10*xAxis,0));
                //Instantiate(tiles, new Vector3(_numberArray[xAxis,yAxis]), Quaternion.identity);
                //thisUnitMovement[0];
                //Instantiate(tiles,thisUnitMovement[yAxis]);
            }
        }

        //Instantiate(tiles, new Vector3(thisUnitMovement[0].x,thisUnitMovement[0].y, thisUnitMovement[0].z), Quaternion.identity);
        //thisUnitMovement.Add(thisUnitLocation.position + new Vector3(10,0,0));
        

        //thisUnitMovement = thisUnitLocation(+ unitMoveLength,0,0);

        //Instantiate(tiles);
    }
    
    /* Update is called once per frame
    void Movement(int moveLength)
    {
        while (moveLength > 0)
        {
            
        }
    }*/
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitiateBoard : MonoBehaviour
{
    [Header("Prefab")]
    public GameObject boardTiles;
    public int area;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = -area;  i < area; i++)
        {
            for (int j = -area; j < area; j++)
            {
                if (Mathf.Sqrt(i*i) < area)
                {
                    if(Mathf.Sqrt(j*j) < area)
                    {
                        Instantiate(boardTiles, this.gameObject.transform.position + new Vector3(i * 10,0, j * 10), Quaternion.identity, this.gameObject.transform);
                    }
                }
            }
        }
    
    }
}

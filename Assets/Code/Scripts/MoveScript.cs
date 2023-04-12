using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    [Header("Grabbed Objects")]
    public PlayerListLayer playerListLayer;
    public HighlightedTileScript highlightedTileScript;
    public StatsDisplayer statsDisplayer;
    public GameObject tileFound;
    public GameObject tileFoundAlways;
    [Header("Held GameObjects")]
    public GameObject highlightedTile;
    public GameObject highlightedTile2;
    [Header("Variables")]
    public bool found = false;
    public bool foundAlways = false;
    public bool foundLocation = false;
    public bool highlightedTilesUp = false;
    public bool highlightedState = false;
    [Range(1,8)]
    public int ranges = 1;
    private int range;

    void Awake()
    {
        playerListLayer = GameObject.Find("TileLayerObjects").GetComponent<PlayerListLayer>();
        highlightedTileScript = GameObject.Find("HighlightedTileObjects").GetComponent<HighlightedTileScript>();
    }
    void Start()
    {
        CheckBelow();
        CheckBelowAlways();
        range = ranges + 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) ||Input.GetKeyDown(KeyCode.D))
        {
            Move();
        }
        if(Input.GetKeyDown(KeyCode.Q) && highlightedState)
        {
            Exit();
        }
        if(Input.GetKeyDown(KeyCode.Return))
        {
            Enter();
        }
        
        

    }
    private void Move()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            this.transform.position += new Vector3(0,0,10);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            this.transform.position += new Vector3(-10,0,0);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            this.transform.position += new Vector3(0,0,-10);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            this.transform.position += new Vector3(10,0,0);
        }
        CheckBelow();
        CheckBelowAlways();
        //statsDisplayer.StatDisplay();
    }
    private void Exit()
    {    
        highlightedState = false;
        foreach(Transform child in highlightedTileScript.gameObject.transform)
        {
        GameObject.Destroy(child.gameObject);
        } 
    }

    private void Enter()
    { 
        if (highlightedState)
        {
            //foreach (GameObject object in highlightedTileScript.highlightedTiles)
            for(int i = 0; i < highlightedTileScript.highlightedTiles.Count; i++)
            {
                if((this.gameObject.transform.position.x == highlightedTileScript.highlightedTiles[i].transform.position.x) && this.gameObject.transform.position.z == highlightedTileScript.highlightedTiles[i].transform.position.z)
                {
                    tileFound.transform.position = new Vector3(highlightedTileScript.highlightedTiles[i].transform.position.x, 0, highlightedTileScript.highlightedTiles[i].transform.position.z); 
                    //highlightedTileScript.highlightedTiles[i].transform.position.x;
                    highlightedState = false;
                    CheckBelow();
                    CheckBelowAlways();
                    foreach(Transform child in highlightedTileScript.gameObject.transform)
                    {
                        GameObject.Destroy(child.gameObject);
                    }
                }
            }
        }
        else if(found)
        {
            highlightedState = true;
            foreach(Transform child in highlightedTileScript.gameObject.transform)
            {
                GameObject.Destroy(child.gameObject);
            }
            for (int i = -range;  i < range; i++)
            {
                for (int j = -range; j < range; j++)
                {
                    if ((Mathf.Sqrt(i*i) + Mathf.Sqrt(j*j)) < range)
                    {
                        if ((Mathf.Sqrt(i*i) + Mathf.Sqrt(j*j)) == 0)
                        {
                            Instantiate(highlightedTile, tileFound.transform.position + new Vector3(i * 10,0, j * 10), Quaternion.identity, highlightedTileScript.transform);
                        }
                        else if ((Mathf.Sqrt(i*i) + Mathf.Sqrt(j*j))%2 == 0)
                        {
                            Instantiate(highlightedTile, tileFound.transform.position + new Vector3(i * 10,0, j * 10), Quaternion.identity, highlightedTileScript.transform);
                        }
                        else if ((Mathf.Sqrt(i*i) + Mathf.Sqrt(j*j))%2 == 1)
                        {
                            Instantiate(highlightedTile2, tileFound.transform.position + new Vector3(i * 10,0, j * 10), Quaternion.identity, highlightedTileScript.transform);
                        }
                    }
                }
            }
        }
        highlightedTileScript.InitiateHighlightedTilesList();
    }

    private void CheckBelow()
    {
        found = false;
        if (!highlightedState)
        {

            for (int i = 0; i < playerListLayer.playerList.Count ; i++)
            {
                
                if((this.gameObject.transform.position.x == playerListLayer.playerList[i].transform.position.x) && this.gameObject.transform.position.z == playerListLayer.playerList[i].transform.position.z && !found)
                {
                    tileFound = playerListLayer.playerList[i];
                    found = true;
                }
                else if(!found)
                {
                    tileFound = null;
                }
            }
        }
    }
    private void CheckBelowAlways()
    {
        foundAlways = false;

        for (int i = 0; i < playerListLayer.playerList.Count ; i++)
        {
            if((this.gameObject.transform.position.x == playerListLayer.playerList[i].transform.position.x) && this.gameObject.transform.position.z == playerListLayer.playerList[i].transform.position.z && !foundAlways)
            {
                tileFoundAlways = playerListLayer.playerList[i];
                foundAlways = true;
            }
            else if(!foundAlways)
            {
                tileFoundAlways = null;
            }
        }
    }

}
            //print(playerListLayer.playerList[i].transform.position.x);
            //print(playerListLayer.playerList.Count - 1);
            
            
            /*
            Go through the list, checking the distance between the objects
            find the closest
            append that to a viewable variable
            */ 

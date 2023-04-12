using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerListLayer : MonoBehaviour
{
    public List<GameObject> playerList = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        InitiateChildren();
    }
    public void InitiateChildren()
    {
        playerList.Clear();
        foreach(Transform child in this.gameObject.transform)
        {
            playerList.Add(child.gameObject);
        }
    }

}

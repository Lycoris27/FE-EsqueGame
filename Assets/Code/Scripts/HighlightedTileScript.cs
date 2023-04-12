using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightedTileScript : MonoBehaviour
{
    public List<GameObject> highlightedTiles = new List<GameObject>();


    public void InitiateHighlightedTilesList()
    {
        highlightedTiles.Clear();
        foreach(Transform child in this.gameObject.transform)
        {
            highlightedTiles.Add(child.gameObject);
        }
    }
}

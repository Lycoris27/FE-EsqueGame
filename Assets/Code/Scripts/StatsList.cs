using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StatsList : MonoBehaviour
{
    public List<TMP_Text> UIStats = new List<TMP_Text>();
    // Start is called before the first frame update
    /*
    void Start()
    {
        InitiateChildStats();
    }
    public void InitiateChildStats()
    {
        
        UIStats.Clear();
        foreach(Transform child in this.gameObject.transform)
        {
            UIStats.Add(child.gameObject);
        }
    }
    */
}

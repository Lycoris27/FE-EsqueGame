using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StatsDisplayer : MonoBehaviour
{
    public StatsList statsList;
    
    public MoveScript moveScript;
    public CharacterStats characterStats;
    /*
    public List<TMP_Text> UIstats = new List<TMP_Text>();

    public TMP_Text atkStat;
    public TMP_Text magStat;
    public TMP_Text spdStat;
    public TMP_Text sklStat;
    public TMP_Text lckStat;
    public TMP_Text defStat;
    public TMP_Text resStat;

    public TMP_Text canvasText;
    public TMP_Text worldText;
    */
    // Start is called before the first frame update
    void Awake()
    {
        moveScript = this.gameObject.GetComponent<MoveScript>();
        statsList = GameObject.Find("Stats").GetComponent<StatsList>();
        
    }
    void Start()
    {
        /*
        foreach(TMP_Text text in UIstats)
        {

        }
        */
        StatDisplay();
    }
    void Update()
    {
        StatDisplay();
    }

    // Update is called once per frame
    public void StatDisplay()
    {
        //print(statsList.UIStats.Count);
        //print(characterStats.statss.Count);
        for (int i = 0; i < statsList.UIStats.Count; i++)
        {
            if (i < 8)
            {
                statsList.UIStats[i].text = characterStats.statss[i].GetValue().ToString();
            }
            if (i == 8)
            {
                statsList.UIStats[i].text = characterStats.currenthp.ToString();
            }
            //print(characterStats.attack.GetValue());
        }
        //you have the stats from the object and the stats display location(the text objects in the scene) you need to have both go through this



        //canvasText.text = moveScript.tileFound.attack;
        //characterStats.attack;
        //characterStats.beezus;
        //canvasText.text = characterStats.beezus.ToString();
    }
}

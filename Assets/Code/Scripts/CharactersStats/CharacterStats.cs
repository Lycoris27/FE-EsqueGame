using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    //{get; private set;}
    public List<Stats> statss = new List<Stats>();
    public Stats hp;
    public int currenthp;
    public Stats attack;
    public Stats magic;
    public Stats speed;
    public Stats skill;
    public Stats luck;
    public Stats defense;
    public Stats resistance;

    //public List<int> statss = new List<int>();

    /*
    public void Attack()
    {
        public Stats attack;
    }
    */
    void Awake()
    {
        currenthp = hp.GetValue();
    }
    void Start()
    {
        statss.Add(hp);
        statss.Add(attack);
        statss.Add(magic);
        statss.Add(speed);
        statss.Add(skill);
        statss.Add(luck);
        statss.Add(defense);
        statss.Add(resistance);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            TakeDamage(10, "magical");
        }
    }

    public void TakeDamage (int damage, string type)
    {
        if(type == "magical")
        {
            damage -= resistance.GetValue();
        }
        else if(type == "physical")
        {
            damage -= defense.GetValue();
        }
        damage = Mathf.Clamp(damage, 1, int.MaxValue);
        if(currenthp > 0)
        {
            currenthp -= damage;
            Debug.Log(transform.name + " takes " + damage + " damage.");
            print(currenthp);
        }
        if (currenthp <= 0)
        {
            Die();
        }
    }

    public virtual void Die ()
    {
        print( "you died" );
    }
}

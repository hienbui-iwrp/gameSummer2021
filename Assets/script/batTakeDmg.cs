using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batTakeDmg : MonoBehaviour
{
    // Start is called before the first frame update
    public static List<batTakeDmg> allBat = new List<batTakeDmg>();
    public static int batKilled = 0;
    public static bool lose = false;
    public HPbar hpBar;
    int hp = 4;
    private void Start()
    {
        allBat.Add(this);
        hpBar.setMaxHP(hp);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag.Equals("bullet"))
        {
            hp--;
            hpBar.setCurHP(hp);
            if (hp <= 0)
            {
                allBat.Remove(this);
                Destroy(gameObject);
                Destroy(other.gameObject);
                batKilled++;
            }
        }
        if (other.gameObject.tag.Equals("limit") || other.gameObject.tag.Equals("people"))
        {
            allBat.Remove(this);
            Destroy(gameObject);
        }
        if (other.gameObject.tag.Equals("hopital"))
        {
            allBat.Remove(this);
            lose = true;
        }
    }
    public void remove()
    {
        allBat.Remove(this);
    }
}

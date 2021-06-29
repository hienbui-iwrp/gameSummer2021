using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batTakeDmg : MonoBehaviour
{
    // Start is called before the first frame update
    public HPbar hpBar;
    int hp = 4;
    private void Start()
    {
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
                Destroy(gameObject);
                Destroy(other.gameObject);
                batInCave.numMaxCave--;
            }
        }
    }
}

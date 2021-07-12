using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batTakeDmg : MonoBehaviour
{
    // Start is called before the first frame update
    public static List<batTakeDmg> allBat = new List<batTakeDmg>();
    public static int batKilled = 0;
    public static bool lose = false;
    public static int maxHp = 5;
    public GameObject vaccine;
    public HPbar hpBar;
    int hp = maxHp;
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
                destroyBat();
                Destroy(other.gameObject);
                batKilled++;
                int createVaccine = (int)Random.Range(0, 3f);
                if (createVaccine == 0)
                    Instantiate<GameObject>(vaccine, transform.position, Quaternion.identity);
            }
        }
        if (other.gameObject.tag.Equals("limit"))
            destroyBat();

        if (other.gameObject.tag.Equals("people"))
            if (!other.gameObject.GetComponent<people>().vaccine && !other.gameObject.GetComponent<people>().virus)
                destroyBat();

        if (other.gameObject.tag.Equals("hopital"))
        {
            destroyBat();
            lose = true;
        }
    }
    public void remove()
    {
        allBat.Remove(this);
    }
    void destroyBat()
    {
        allBat.Remove(this);
        Destroy(gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class people : MonoBehaviour
{
    // Start is called before the first frame update
    public static List<people> allPeople = new List<people>();
    public bool vaccine = false;
    public bool beSick = false;
    public HPbar hpBar;
    public GameObject virus;
    public GameObject shield;
    public peopleMove move;
    public Vector2 oldPosition;
    public int hp = 10;
    public bool healing = false;
    float sickDelay = 6f;
    float now;
    float range = 2.5f;

    void Start()
    {
        hpBar.setMaxHP(hp);
        now = Time.time;
        //list all people
        allPeople.Add(this);
        virus.SetActive(false);
        shield.SetActive(false);
        oldPosition = gameObject.transform.position;
        GetComponent<Healing>().enabled = false;
    }
    private void FixedUpdate()
    {
        hpBar.setCurHP(hp);
        haveVaccine();
        contagious();
        if (!healing)
            sick(beSick);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag.Equals("bat"))
        {
            if (!vaccine)
            {
                batTakeDmg.allBat.Remove(other.gameObject.GetComponent<batTakeDmg>());
                beSick = true;
                Destroy(other.gameObject);
            }
        }
        if (other.tag.Equals("bullet"))
        {
            takeDmg();
        }
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag.Equals("hopital"))
        {
            healing = true;
            GetComponent<Healing>().enabled = true;
        }

    }
    public void takeVaccine()
    {
        vaccine = true;
        shield.SetActive(true);
    }
    //cách ly
    public void isolate()
    {
        gameObject.transform.position = new Vector3(11, 2, 0);
        GetComponent<peopleMove>().speedMin = 1;
        GetComponent<peopleMove>().speedMax = 2;
    }
    //vô nhiễm
    void haveVaccine()
    {
        if (vaccine)
        {
            shield.SetActive(true);
            beSick = false;
        }
        else shield.SetActive(false);
    }
    //lây nhiễm
    void contagious()
    {
        if (beSick)
        {
            foreach (people someOne in allPeople)
            {
                if (Vector2.Distance(transform.position, someOne.transform.position) < range)
                    someOne.beSick = true;
            }
        }
    }
    //mất sức
    void sick(bool beSick)
    {
        if (beSick)
        {
            virus.SetActive(true);
            if (Time.time > now + sickDelay)
            {
                takeDmg();
                now = Time.time;
            }
        }
        else
        {
            virus.SetActive(false);
        }
    }
    void takeDmg()
    {
        hp--;
        if (hp <= 0)
        {
            allPeople.Remove(this);
            Destroy(gameObject);
        }
    }
}

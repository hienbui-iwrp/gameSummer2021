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
    public Transform isolationArea;
    public peopleMove move;
    Transform oldPosition;
    float sickDelay = 4f;
    float now;
    float range = 2.5f;
    int hp = 10;
    void Start()
    {
        hpBar.setMaxHP(hp);
        now = Time.time;
        //list all people
        allPeople.Add(this);
        virus.SetActive(false);
        shield.SetActive(false);
        oldPosition = gameObject.transform;
    }
    private void FixedUpdate()
    {
        if (beSick)
        {
            foreach (people someOne in allPeople)
            {
                if (Vector2.Distance(transform.position, someOne.transform.position) < range)
                    someOne.beSick = true;

            }
        }
        sick(beSick);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag.Equals("bat"))
        {
            if (!vaccine)
            {
                beSick = true;
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
            healing();
        }

    }
    public void takeVaccine()
    {
        vaccine = true;
        shield.SetActive(true);
    }
    public void isolate()
    {
        gameObject.transform.position = isolationArea.position;
        GetComponent<peopleMove>().enabled = false;
    }
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
    void healing()
    {
        hp += 2;
        hpBar.setCurHP(hp);
        if (hp == 10)
        {
            beSick = false;
            transform.position = oldPosition.position;
            GetComponent<peopleMove>().enabled = true;
        }
    }
    void takeDmg()
    {
        hp--;
        hpBar.setCurHP(hp);
        if (hp <= 0)
        {
            allPeople.Remove(this);
            Destroy(gameObject);
        }
    }
}

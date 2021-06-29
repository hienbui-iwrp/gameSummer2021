using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class people : MonoBehaviour
{
    // Start is called before the first frame update
    public static List<people> peopleList = new List<people>();
    public bool beSick = false;
    public HPbar hpBar;
    float sickDelay = 10f;
    float now;
    int hp = 10;
    public static List<people> getPeopleList()
    {
        return peopleList;
    }
    void Start()
    {
        hpBar.setMaxHP(hp);
        now = Time.time;
    }
    // Update is called once per frame
    void Update()
    {
        if (!beSick) peopleList.Add(this);
        else peopleList.Remove(this);
    }
    private void FixedUpdate()
    {
        if (beSick)
        {
            if (Time.time > now + sickDelay) takeDmg();
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag.Equals("bat")) beSick = true;
        if (other.tag.Equals("bullet"))
        {
            takeDmg();
        }
    }
    void takeDmg()
    {
        hp--;
        hpBar.setCurHP(hp);
        if (hp <= 0)
        {
            Destroy(gameObject);
            gameControl.exit();
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Point : MonoBehaviour
{
    // Start is called before the first frame update
    public Text result;
    public Text peopleString;
    public Text batString;
    public Text BonusString;
    public Text TotalString;
    public Text peopleNum;
    public Text batNum;
    public Text BonusNum;
    public Text TotalNum;
    public Button Menu;
    public int bonus = 100;
    float now;
    void Start()
    {
        peopleString.text = "Người dân sống sót:";
        batString.text = "Dơi giết được:";
        BonusString.text = "Thưởng:";
        TotalString.text = "Tổng:";
        now = Time.time;
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //bonus
        if (bonus > 0)
        {
            if (Time.time > now + 5)
            {
                bonus--;
                now = Time.time;
            }
        }
        peopleNum.text = (numPeople.finalPeople * 10).ToString();
        batNum.text = (batTakeDmg.batKilled * 5).ToString();        
        BonusNum.text = bonus.ToString();
        TotalNum.text = (numPeople.finalPeople * 10 + batTakeDmg.batKilled * 5 + bonus).ToString();
    }
    public void enable()
    {
        gameObject.SetActive(true);
    }
}

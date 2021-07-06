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
        peopleNum.text = (numPeople.finalPeople).ToString() + " x10";
        batNum.text = (batTakeDmg.batKilled * 5).ToString() + " x5";
        BonusNum.text = gameControl.pointBonus.ToString();
        TotalNum.text = (numPeople.finalPeople * 10 + batTakeDmg.batKilled * 5 + gameControl.pointBonus).ToString();
    }

    public void enable()
    {
        gameObject.SetActive(true);
    }
}

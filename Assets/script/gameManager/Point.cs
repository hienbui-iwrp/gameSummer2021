using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Point : MonoBehaviour
{
    // Start is called before the first frame update
    public Text result;
    public Text peopleNum;
    public Text batNum;
    public Text BonusNum;
    public Text TotalNum;
    public Button Menu;

    float now;
    void Start()
    {
        now = Time.time;
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        peopleNum.text = (numPeople.finalPeople).ToString() + " x2";
        batNum.text = (batTakeDmg.batKilled).ToString();
        BonusNum.text = gameControl.pointBonus.ToString();
        TotalNum.text = (numPeople.finalPeople * 2 + batTakeDmg.batKilled + gameControl.pointBonus).ToString();
    }
    public void enable()
    {
        gameObject.SetActive(true);
    }
}

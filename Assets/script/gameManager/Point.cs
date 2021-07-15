using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Point : MonoBehaviour
{
    // Start is called before the first frame update
    public Text result;
    public Text highScore;
    public Text peopleNum;
    public Text batNum;
    public Text BonusNum;
    public Text TotalNum;
    public Button Menu;
    int total;
    float now;
    void Start()
    {
        now = Time.time;
        gameObject.SetActive(false);
        highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }
    public void setScore()
    {
        peopleNum.text = (numPeople.finalPeople).ToString() + " x2";
        batNum.text = (batTakeDmg.batKilled).ToString();
        BonusNum.text = gameControl.pointBonus.ToString();
        total = numPeople.finalPeople * 2 + batTakeDmg.batKilled + gameControl.pointBonus;
        TotalNum.text = total.ToString();
        if (total > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", total);
            highScore.text = total.ToString();
        }
    }
    public void enable()
    {
        gameObject.SetActive(true);
    }
}

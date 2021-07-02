using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameControl : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject panel;
    public Text note;
    float wait;
    private void Start()
    {
        wait = Time.time;
        note.text = "";
        panel.SetActive(false);
    }
    private void Update()
    {
        if (Time.time > wait + 1f)
        {
            panel.SetActive(false);
        }
    }
    public void takeVaccine()
    {
        panel.SetActive(true);
        note.text = "Nhận được vaccine!";
        wait = Time.time;
    }
    public void useVaccine()
    {
        panel.SetActive(true);
        note.text = "Tiêm vaccine thành công!";
        wait = Time.time;
    }
    public void fullVaccine()
    {
        panel.SetActive(true);
        note.text = "Vaccine đã đầy!!!";
        wait = Time.time;
    }
    public void outOfVaccine()
    {
        panel.SetActive(true);
        note.text = "Chúng ta cần thêm vaccine!!!";
        wait = Time.time;
    }
    public void takeStone()
    {
        panel.SetActive(true);
        note.text = "Nhặt đá thành công!";
        wait = Time.time;
    }
    public void fullStone()
    {
        panel.SetActive(true);
        note.text = "Đá đã đầy!!!";
        wait = Time.time;
    }
    public void outOfStone()
    {
        panel.SetActive(true);
        note.text = "Không đủ đá!!!";
        wait = Time.time;
    }
    public void isolate()
    {
        panel.SetActive(true);
        note.text = "Cách ly thành công";
        wait = Time.time;
    }
    public void exit()
    {
        Debug.Log("gameOver");
    }
}

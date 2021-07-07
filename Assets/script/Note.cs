using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Note : MonoBehaviour
{
    public GameObject NotePanel;
    public Text note;
    float wait;
    private void Start()
    {
        wait = Time.time;
        note.text = "";
        NotePanel.SetActive(false);
    }
    private void Update()
    {
        if (Time.time > wait + 1.5f)
        {
            NotePanel.SetActive(false);
        }
    }
    public void takeVaccine()
    {
        NotePanel.SetActive(true);
        note.text = "Nhận được vaccine!";
        wait = Time.time;
    }
    public void useVaccine()
    {
        NotePanel.SetActive(true);
        note.text = "Tiêm vaccine thành công!";
        wait = Time.time;
    }
    public void fullVaccine()
    {
        NotePanel.SetActive(true);
        note.text = "Vaccine đã đầy!!!";
        wait = Time.time;
    }
    public void outOfVaccine()
    {
        NotePanel.SetActive(true);
        note.text = "Chúng ta cần thêm vaccine!!!";
        wait = Time.time;
    }
    public void takeStone()
    {
        NotePanel.SetActive(true);
        note.text = "Nhặt đá thành công!";
        wait = Time.time;
    }
    public void fullStone()
    {
        NotePanel.SetActive(true);
        note.text = "Đá đã đầy!!!";
        wait = Time.time;
    }
    public void outOfStone()
    {
        NotePanel.SetActive(true);
        note.text = "Không đủ đá!!!";
        wait = Time.time;
    }
    public void isolate()
    {
        NotePanel.SetActive(true);
        note.text = "Cách ly thành công";
        wait = Time.time;
    }
    public void turnOnWarning()
    {
        NotePanel.SetActive(true);
        note.text = "Khu cách ly gặp nguy hiểm!!!";
        wait = Time.time;
    }
}

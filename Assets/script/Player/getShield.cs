using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getShield : MonoBehaviour
{
    public GameObject shield;
    public Note note;
    public static bool beProtected = false;
    float now;
    // Start is called before the first frame update
    private void Start()
    {
        now = Time.time;
        shield.SetActive(false);
    }
    private void Update()
    {
        if (beProtected)
        {
            if (Time.time > now + 30f)
                offShield();
        }
        else now = Time.time;
    }
    public void haveShield()
    {
        beProtected = true;
        shield.SetActive(true);
    }
    void offShield()
    {
        note.noShield();
        beProtected = false;
        shield.SetActive(false);
        createShield.curShield--;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healing : MonoBehaviour
{
    float timeTreatment;
    private void Start()
    {
        timeTreatment = Time.time;
    }
    public void Update()
    {
        healing();
    }
    void healing()
    {
        if (Time.time > timeTreatment + 4f)
        {
            GetComponent<people>().hp += 1;
            timeTreatment = Time.time;
        }
        if (GetComponent<people>().hp >= 10)
        {
            GetComponent<people>().hp = 10;
            GetComponent<people>().beSick = false;
            GetComponent<people>().healing = false;
            GetComponent<peopleMove>().speedMin = 3;
            GetComponent<peopleMove>().speedMax = 6;
            transform.position = GetComponent<people>().oldPosition;
            GetComponent<Healing>().enabled = false;
        }
    }
}

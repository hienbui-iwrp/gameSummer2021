using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class numPeople : MonoBehaviour
{
    public static int finalPeople = 0;
    public bagInfo peopleInfo;
    bool first = true;
    float wait;
    private void Start()
    {
        wait = Time.time;
    }
    private void Update()
    {
        if (Time.time > wait + 0.3f && first)
        {
            peopleInfo.max = countPeople();
            first = false;
        }
        peopleInfo.setNumber(countPeople());
        finalPeople = countPeople();
    }
    int countPeople()
    {
        int all = 0;
        foreach (people someOne in people.allPeople)
            all++;
        return all;
    }
}
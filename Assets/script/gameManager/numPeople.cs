using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class numPeople : MonoBehaviour
{
    public static int finalPeople = 0;
    public static int max = 7;
    public bagInfo peopleInfo;
    // bool first = true;
    float wait;
    private void Start()
    {
        wait = Time.time;
    }
    private void Update()
    {
        peopleInfo.max = max;

        //set current people
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

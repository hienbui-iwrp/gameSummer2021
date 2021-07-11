using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class numViruss : MonoBehaviour
{
    public bagInfo peopleInfo;
    private void Update()
    {
        peopleInfo.max = countPeople();
        peopleInfo.setNumber(countViruss());
    }
    int countPeople()
    {
        int all = 0;
        foreach (people someOne in people.allPeople)
            all++;
        return all;
    }
    int countViruss()
    {
        int num = 0;
        foreach (people someOne in people.allPeople)
            if (someOne.beSick) num++;
        return num;
    }
}

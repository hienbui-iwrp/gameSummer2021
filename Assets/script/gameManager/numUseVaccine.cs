using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class numUseVaccine : MonoBehaviour
{
    public bagInfo peopleUsed;
    // Start is called before the first frame update

    private void Update()
    {
        peopleUsed.max = countPeople();
        peopleUsed.setNumber(coutVaccine());
    }
    int countPeople()
    {
        int all = 0;
        foreach (people someOne in people.allPeople)
            all++;
        return all;
    }
    int coutVaccine()
    {
        int num = 0;
        foreach (people someOne in people.allPeople)
            if (someOne.vaccine) num++;
        return num;
    }
}

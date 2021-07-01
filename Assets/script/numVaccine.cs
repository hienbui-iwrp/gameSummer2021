using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class numVaccine : MonoBehaviour
{
    public bagInfo VaccineInfo;
    private void Start()
    {
        VaccineInfo.max = Player.numMaxVac;
    }
    private void Update()
    {
        VaccineInfo.setNumber(Player.numVac);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createVaccine : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject vaccine;
    public static int numVaccine = 0;
    public static int maxVaccine = 15;
    float delay = 10;
    float now = 0;

    private void Update()
    {
        if (Time.time > now + delay)
            if (numVaccine < maxVaccine)
            {
                if (Random.Range(0f, 1f) > 0.4)
                {
                    GameObject newVaccine = Instantiate<GameObject>(vaccine, transform);
                    numVaccine++;
                    newVaccine.transform.position = transform.position;
                }
                now = Time.time;
            }
    }
    public static void takeVaccine()
    {
        numVaccine--;
    }
}

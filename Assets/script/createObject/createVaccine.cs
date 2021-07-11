using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createVaccine : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject vaccine;
    public static int numVaccine = 0;
    float wait;
    bool first = true;
    void Start()
    {
        wait = Time.time;
    }
    private void Update()
    {
        if (Time.time > wait + 0.4f && first)
        {
            if (Random.Range(0f, 1f) > 0.4)
            {
                if (numVaccine <= numPeople.max)
                {
                    GameObject newVaccine = Instantiate<GameObject>(vaccine, transform);
                    numVaccine++;
                    newVaccine.transform.position = transform.position;
                }
            }
            first = false;
        }
    }
}

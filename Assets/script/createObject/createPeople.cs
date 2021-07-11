using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createPeople : MonoBehaviour
{
    public GameObject[] people;
    public static int curPeople = 0;
    float wait;
    bool first = true;
    void Start()
    {
        wait = Time.time;
    }
    private void Update()
    {
        if (Time.time > wait + 0.1f && first)
        {
            if (Random.Range(0f, 1f) > 0.2)
                if (curPeople < numPeople.max)
                {
                    int peopleType = Random.Range(0, people.Length);
                    GameObject newPeople = Instantiate<GameObject>(people[peopleType], transform);
                    newPeople.transform.position = transform.position;
                    curPeople++;
                }
            first = false;
        }
    }
}

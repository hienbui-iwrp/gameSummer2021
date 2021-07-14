using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createShield : MonoBehaviour
{
    public GameObject shield;
    public static int curShield = 0;
    public static float delay = 5;
    public static bool create = true;

    int max = 1;
    float now;

    private void Start()
    {
        now = -10;
    }
    // Update is called once per frame
    void Update()
    {
        if (curShield < max && create)
        {
            if (Time.time > now + delay)
                if (Random.Range(0f, 1f) > 0.5)
                {
                    GameObject newShield = Instantiate<GameObject>(shield, transform);
                    newShield.transform.position = transform.position;
                    curShield++;
                }
        }
        else now = Time.time;
    }
}

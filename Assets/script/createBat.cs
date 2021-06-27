using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createBat : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bat;
    public Transform door;
    public static int numBat = 0;
    float now;
    void Start()
    {
        now = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (numBat < 5)
            if (Time.time > now + 15f)
            {
                Instantiate<GameObject>(bat, door.position, Quaternion.identity);
                now = Time.time;
                numBat++;
            }
    }
}

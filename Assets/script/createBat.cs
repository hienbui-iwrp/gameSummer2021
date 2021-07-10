using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createBat : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bat;
    public Transform door;
    float delay;
    float now;
    void Start()
    {
        now = Time.time;
        delay = Random.Range(15f, 20f);
    }
    // Update is called once per frame
    void Update()
    {
        if (Time.time > now + delay)
        {
            Instantiate<GameObject>(bat, door.position, Quaternion.identity);
            now = Time.time;
            delay = Random.Range(5, 15);
        }
    }
}

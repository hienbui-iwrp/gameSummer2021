using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createBat : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bat;
    public Transform door;
    float now;
    void Start()
    {
        now = Time.time;
    }
    // Update is called once per frame
    void Update()
    {
        if (Time.time > now + 10f)
        {
            Instantiate<GameObject>(bat, door.position, Quaternion.identity);
            now = Time.time;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createBat : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bat;
    public Transform door;
    public static float delayMin;
    public static float delayMax;
    float delay;
    float now;
    void Start()
    {
        now = Time.time;
        delay = Random.Range(delayMin, delayMax);
    }
    // Update is called once per frame
    void Update()
    {
        if (Time.time > now + delay)
        {
            GameObject newBat = Instantiate<GameObject>(bat, door.transform);
            newBat.transform.position = new Vector3(door.position.x, door.position.y, 0);
            now = Time.time;
            delay = Random.Range(5, 15);
        }
    }
}

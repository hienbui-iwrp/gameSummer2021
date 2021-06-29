using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batInCave : MonoBehaviour
{
    // Start is called before the first frame update
    public static int numMaxCave = 5;
    public GameObject bat;
    public Transform well;
    public static int num;

    void Start()
    {
        num = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (num < numMaxCave)
        {
            Instantiate<GameObject>(bat, well.position, Quaternion.identity);
            num++;
        }
    }
}

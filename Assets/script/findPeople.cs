using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class findPeople : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bat;
    public Rigidbody2D batMove;
    public float range = 5f;
    private void Update()
    {
        foreach (people someOne in people.getPeopleList())
        {
            if (someOne.beSick == true) continue;
            if (Vector2.Distance(transform.position, someOne.transform.position) < range)
            {
                Vector2 direct = someOne.transform.position - bat.transform.position;
                batMove.velocity = direct * 10 / direct.magnitude;
            }
        }
    }
}

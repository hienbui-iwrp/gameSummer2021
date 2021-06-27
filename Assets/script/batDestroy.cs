using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("limit") || other.gameObject.tag.Equals("people"))
        {
            Destroy(gameObject);
            createBat.numBat--;
        }
    }
}

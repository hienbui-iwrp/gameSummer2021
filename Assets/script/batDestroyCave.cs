using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batDestroyCave : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("limit"))
        {
            Destroy(gameObject);
            batInCave.num--;
        }
    }
}

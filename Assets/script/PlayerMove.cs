using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Start is called before the first frame update
    float speed;
    Animator anim;
    Rigidbody2D rigidbody2D;
    void Start()
    {
        speed = 5f;
        rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey)
        {
            anim.enabled = true;
            if (Input.GetKey("s"))
            {
                anim.SetFloat("Blend", 0f);
                rigidbody2D.velocity = new Vector2(0, -1) * speed;
            }
            if (Input.GetKey("a"))
            {
                anim.SetFloat("Blend", 0.33f);
                rigidbody2D.velocity = new Vector2(-1, 0) * speed;
            }
            if (Input.GetKey("d"))
            {
                anim.SetFloat("Blend", 0.66f);
                rigidbody2D.velocity = new Vector2(1, 0) * speed;
            }
            if (Input.GetKey("w"))
            {
                anim.SetFloat("Blend", 1f);
                rigidbody2D.velocity = new Vector2(0, 1) * speed;
            }

        }
        else
        {
            anim.enabled = false;
            rigidbody2D.velocity = new Vector2(0, 0) * speed;
        }
    }
}

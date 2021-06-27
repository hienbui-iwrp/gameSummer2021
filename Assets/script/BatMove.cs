using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatMove : MonoBehaviour
{
    // Start is called before the first frame update
    float speed;
    Animator anim;
    Rigidbody2D rigidbody2D;
    float now;
    
    void Start()
    {
        now = Time.time;
        speed = 6f;
        rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > now + 2)
        {
            int status = (int)Random.Range(0f, 3.9f);
            if (status == 0)
            {
                anim.SetFloat("Blend", 0f);
                rigidbody2D.velocity = new Vector2(0, -1) * speed;
            }
            if (status == 1)
            {
                anim.SetFloat("Blend", 0.33f);
                rigidbody2D.velocity = new Vector2(-1, 0) * speed;
            }
            if (status == 2)
            {
                anim.SetFloat("Blend", 0.66f);
                rigidbody2D.velocity = new Vector2(1, 0) * speed;
            }
            if (status == 3)
            {
                anim.SetFloat("Blend", 1f);
                rigidbody2D.velocity = new Vector2(0, 1) * speed;
            }
            now = Time.time;
        }
        else
        {
            if (Time.time > now + 1)
            {
                rigidbody2D.velocity = new Vector2(0, 0) * speed;
            }
        }
    }
}

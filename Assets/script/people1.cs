using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class people1 : MonoBehaviour
{
    // Start is called before the first frame update
    float speed;
    Animator anim;
    Rigidbody2D rigidbody2D;
    bool rotate = false;
    float now, timeDelay;
    void Start()
    {
        now = Time.time;
        timeDelay = Random.Range(4, 6);
        speed = 1.5f;
        rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > now + timeDelay)
        {
            speed = Random.Range(3, 4);
            int status = (int)Random.Range(0f, 3.9f);
            anim.enabled = true;
            if (status == 0)
            {
                anim.SetFloat("Blend", 0f);
                rigidbody2D.velocity = new Vector2(0, -1) * speed;
            }

            if (status == 1)
            {
                if (!rotate)
                {
                    GetComponent<Transform>().Rotate(0, 180, 0);
                    rotate = true;
                }
            }
            if (status == 1)
            {
                anim.SetFloat("Blend", 0.33f);
                rigidbody2D.velocity = new Vector2(-1, 0) * speed;
            }

            if (status == 2)
            {
                if (rotate)
                {
                    GetComponent<Transform>().Rotate(0, 180, 0);
                    rotate = false;
                }
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
                anim.enabled = false;
                rigidbody2D.velocity = new Vector2(0, 0) * speed;
            }
        }
    }
}

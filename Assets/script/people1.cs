using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class people1 : MonoBehaviour
{
    // Start is called before the first frame update
    public bool follow;
    public GameObject player;
    float speed;
    Animator anim;
    Rigidbody2D rig;
    bool rotate = false;
    float now, timeDelay;
    void Start()
    {
        follow = false;
        now = Time.time;
        timeDelay = Random.Range(4, 6);
        rig = gameObject.GetComponent<Rigidbody2D>();
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!follow)
        {
            if (Time.time > now + timeDelay)
            {
                speed = Random.Range(3, 4);
                int status = (int)Random.Range(0f, 3.9f);
                anim.enabled = true;
                if (status == 0)
                {
                    anim.SetFloat("Blend", 0f);
                    rig.velocity = new Vector2(0, -1) * speed;
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
                    rig.velocity = new Vector2(-1, 0) * speed;
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
                    rig.velocity = new Vector2(1, 0) * speed;
                }
                if (status == 3)
                {
                    anim.SetFloat("Blend", 1f);
                    rig.velocity = new Vector2(0, 1) * speed;
                }
                now = Time.time;
            }
            else
            {
                if (Time.time > now + 1)
                {
                    anim.enabled = false;
                    rig.velocity = new Vector2(0, 0) * speed;
                }
            }
        }
        else
        {
            speed = Player.speed;
             
        }
    }
}

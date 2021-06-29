using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public static float speed;
    public static Vector2 startPosition = new Vector2(8.5f, -3);
    public GameObject stone;
    int direction = 0;
    Animator anim;
    Rigidbody2D rig;
    int numStone = 0;
    int numVaxcin = 0;
    void Start()
    {
        speed = 5f;
        rig = gameObject.GetComponent<Rigidbody2D>();
        anim = gameObject.GetComponent<Animator>();
        transform.position = startPosition;
    }

    // Update is called once per frame
    void Update()
    {
        move();
        throwStone();
    }
    void move()
    {
        if (Input.anyKey)
        {
            anim.enabled = true;
            if (Input.GetAxisRaw("Vertical") == -1)
            {
                anim.SetFloat("Blend", 0f);
                rig.velocity = new Vector2(0, -1) * speed;
                direction = 0;
            }
            if (Input.GetAxisRaw("Horizontal") == -1)
            {
                anim.SetFloat("Blend", 0.33f);
                rig.velocity = new Vector2(-1, 0) * speed;
                direction = 1;
            }
            if (Input.GetAxisRaw("Horizontal") == 1)
            {
                anim.SetFloat("Blend", 0.66f);
                rig.velocity = new Vector2(1, 0) * speed;
                direction = 2;
            }
            if (Input.GetAxisRaw("Vertical") == 1)
            {
                anim.SetFloat("Blend", 1f);
                rig.velocity = new Vector2(0, 1) * speed;
                direction = 3;
            }

        }
        else
        {
            anim.enabled = false;
            rig.velocity = new Vector2(0, 0) * speed;
        }
    }
    void throwStone()
    {
        if (Input.GetKeyDown("space") && numStone > 0)
        {
            numStone--;
            GameObject Stone = Instantiate<GameObject>(stone, transform.position, Quaternion.identity);
            Rigidbody2D rigStone = Stone.GetComponent<Rigidbody2D>();
            switch (direction)
            {
                case 0:
                    rigStone.velocity = new Vector2(0, -1) * 10;
                    break;
                case 1:
                    rigStone.velocity = new Vector2(-1, 0) * 10;
                    break;
                case 2:
                    rigStone.velocity = new Vector2(1, 0) * 10;
                    break;
                case 3:
                    rigStone.velocity = new Vector2(0, 1) * 10;
                    break;
                default:
                    break;
            }
            Destroy(Stone, 0.8f);

        }
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag.Equals("stone"))
        {
            if (Input.GetKeyDown("z"))
            {
                takeStone();
            }
        }
    }

    void takeVaxcin()
    {
        if (numVaxcin < 3) numVaxcin++;
    }
    void useVaxcin()
    {
        if (numVaxcin > 0) numVaxcin--;
    }
    void takeStone()
    {
        numStone = 5;
    }
}

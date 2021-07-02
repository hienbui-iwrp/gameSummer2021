using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public static float speed;
    public static Vector2 startPosition = new Vector2(8.5f, -3);
    public GameObject stone;
    public Note note;
    public static int numVac = 0;
    public static int numMaxVac = 5;
    int direction = 0;
    Animator anim;
    Rigidbody2D rig;
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
        if (Input.GetKeyDown("space"))
            if (numStone.num > 0)
            {
                numStone.num--;
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
            else note.outOfStone();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag.Equals("stone"))
        {
            if (Input.GetKeyDown("z"))
            {
                if (numStone.num < 10)
                {
                    takeStone();
                    note.takeStone();
                }
                else note.fullStone();
            }
        }
        if (other.tag.Equals("vaccine"))
        {
            if (Input.GetKeyDown("z"))
            {
                if (numVac < numMaxVac)
                {
                    takeVaccine();
                    Destroy(other.gameObject);
                    note.takeVaccine();
                }
                else note.fullVaccine();
            }
        }
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag.Equals("stone"))
        {
            if (Input.GetKeyDown("z"))
            {
                if (numStone.num < 10)
                {
                    takeStone();
                    note.takeStone();
                }
                else note.fullStone();
            }
        }
        if (other.tag.Equals("vaccine"))
        {
            if (Input.GetKeyDown("z"))
            {
                if (numVac < numMaxVac)
                {
                    takeVaccine();
                    Destroy(other.gameObject);
                    note.takeVaccine();
                }
                else note.fullVaccine();
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.tag.Equals("people"))
        {
            if (Input.GetKeyDown("x"))
            {
                people someOne;
                someOne = other.gameObject.GetComponent<people>();
                if (someOne.beSick)
                {
                    //Isolate
                    someOne.isolate();
                    note.isolate();
                }
                else
                {
                    if (numVac > 0)
                    {
                        //use vaccine
                        if (!someOne.vaccine)
                        {
                            someOne.takeVaccine();
                            numVac--;
                            note.useVaccine();
                        }
                    }
                    else note.outOfVaccine();
                }
            }
        }
    }
    private void OnCollisionStay2D(Collision2D other)
    {
        if (other.collider.tag.Equals("people"))
        {
            if (Input.GetKeyDown("x"))
            {
                people someOne;
                someOne = other.gameObject.GetComponent<people>();
                if (someOne.beSick)
                {
                    //Isolate
                    someOne.isolate();
                    note.isolate();
                }
                else
                {
                    if (numVac > 0)
                    {
                        //use vaccine
                        if (!someOne.vaccine)
                        {
                            someOne.takeVaccine();
                            numVac--;
                            note.useVaccine();
                        }
                    }
                    else note.outOfVaccine();
                }
            }
        }
    }
    void takeVaccine()
    {
        numVac++;
    }
    void takeStone()
    {
        numStone.num += 5;
    }
}

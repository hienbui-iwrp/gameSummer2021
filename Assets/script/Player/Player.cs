using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public static float speed = 7f;
    public static Vector2 startPosition = new Vector2(8.5f, 0);
    public static float timeDestroyBullet = 1f;
    public GameObject shield;
    public GameObject stone;
    public getShield Shield;
    public Note note;
    public AudioSource TakeSound;
    public static int numVac = 0;
    public static int numMaxVac = 3;
    int direction = 0;
    Animator anim;
    Rigidbody2D rig;
    void Start()
    {
        TakeSound.volume = Menu.SoundVolume;
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
        if (Input.GetKeyDown("c"))
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
                Destroy(Stone, timeDestroyBullet);
            }
            else note.outOfStone();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag.Equals("stone"))
            takeStone(other);

        if (other.tag.Equals("vaccine"))
            takeVaccine(other);

        if (other.tag.Equals("shield"))
            takeShield(other);
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag.Equals("stone"))
            takeStone(other);

        if (other.tag.Equals("vaccine"))
            takeVaccine(other);

        if (other.tag.Equals("shield"))
            takeShield(other);
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
    void takeVaccine(Collider2D other)
    {
        if (Input.GetKeyDown("z"))
            if (numVac < numMaxVac)
            {
                createVaccine.takeVaccine();
                numVac++;
                Destroy(other.gameObject);
                note.takeVaccine();
                TakeSound.Play();
            }
            else note.fullVaccine();
    }
    void takeStone(Collider2D other)
    {
        if (Input.GetKeyDown("z"))
            if (numStone.num < numStone.max)
            {
                numStone.num += 5;
                other.gameObject.GetComponent<destroyStone>().takeStone();
                note.takeStone();
                TakeSound.Play();
            }
            else note.fullStone();
        if (numStone.num > numStone.max) numStone.num = numStone.max;
    }
    void takeShield(Collider2D other)
    {
        if (Input.GetKeyDown("z"))
        {
            note.takeShield();
            Shield.haveShield();
            Destroy(other.gameObject);
        }
    }
}

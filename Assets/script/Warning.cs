using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warning : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator warning;
    public AudioSource warningSound;
    public Note note;
    bool play = false;
    void Start()
    {
        warning.SetBool("show", false);
    }

    public void show()
    {
        warning.SetBool("show", true);
        if (!play)
        {
            warningSound.Play();
            play = true;
            note.turnOnWarning();
        }
    }
    public void offShow()
    {
        warning.SetBool("show", false);
        warningSound.Pause();
        play = false;
    }
}

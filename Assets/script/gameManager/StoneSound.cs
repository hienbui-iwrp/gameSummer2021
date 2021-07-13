using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneSound : MonoBehaviour
{
    public AudioSource hitSound;
    private void Start()
    {
        hitSound.volume = Menu.SoundVolume;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag.Equals("bat") || other.tag.Equals("people"))
            hitSound.Play();

    }
}

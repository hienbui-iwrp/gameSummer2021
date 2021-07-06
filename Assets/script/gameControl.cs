using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameControl : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject point;
    public GameObject info;
    public AudioSource inGameSound;
    public AudioClip winSound;
    public AudioClip loseSound;
    public AudioSource Sound;
    public static int pointBonus = 100;
    float now;
    bool EndGame = false;
    bool done = false;
    bool win = false;
    private void Start()
    {
        Time.timeScale = 1;
        now = Time.time;
    }
    private void Update()
    {
        inGameSound.volume = Menu.SoundVolume;
        Sound.volume = Menu.SoundVolume;
        EndGame = true;
        win = true;
        foreach (people someOne in people.allPeople)
        {
            if (someOne.vaccine == false) EndGame = false;
        }
        if (people.allPeople.Count <= 0 || batTakeDmg.lose)
        {
            EndGame = true;
            win = false;
        }
        if (EndGame && !done)
        {
            exit();
            done = true;
        }
        reduceBonus();
    }
    public void goMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void exit()
    {

        inGameSound.enabled = false;
        if (win)
        {
            point.GetComponent<Point>().result.text = "Chiến thắng!!!";
            Sound.clip = winSound;
            Sound.Play();
        }
        else
        {
            point.GetComponent<Point>().result.text = "Thất bại";
            pointBonus = 0;
            Sound.clip = loseSound;
            Sound.Play();
        }
        point.GetComponent<Point>().enable();
        info.SetActive(false);
        Time.timeScale = 0;
        people.allPeople.Clear();
        batTakeDmg.allBat.Clear();
    }
    void reduceBonus()
    {
        if (Time.time > now + 3)
        {
            pointBonus--;
            now = Time.time;
        }
        if (pointBonus < 0)
            pointBonus = 0;
    }
}

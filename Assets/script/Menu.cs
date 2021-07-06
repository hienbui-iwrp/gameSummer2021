using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    public AudioSource MenuSound;
    public GameObject firstMenu;
    public GameObject SoundSetting;
    // public Text startButton;
    // public Text soundButton;
    public Slider Sound;
    public static float SoundVolume;
    // public Text backButton;
    // Start is called before the first frame update
    void Start()
    {
        firstMenu.SetActive(true);
        SoundSetting.SetActive(false);
        Sound.value = 0.5f;
    }
    private void Update()
    {
        MenuSound.volume = Sound.value;
        SoundVolume = Sound.value;
    }
    public void goSoundSetting()
    {
        firstMenu.SetActive(false);
        SoundSetting.SetActive(true);
    }
    public void back()
    {
        firstMenu.SetActive(true);
        SoundSetting.SetActive(false);
    }
    public void goInGame()
    {
        SceneManager.LoadScene("inGame");
    }
}

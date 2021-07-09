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
    public GameObject HelpMenu;
    public Text start;
    public Text help;
    public Text soundSet;
    public Text size;
    // public Text startButton;
    // public Text soundButton;
    public Slider Sound;
    public static float SoundVolume;
    // public Text backButton;
    // Start is called before the first frame update
    void Start()
    {
        start.text = "Bắt đầu";
        help.text = "Hướng dẫn";
        soundSet.text = "Âm thanh";
        size.text = "Độ lớn:";
        firstMenu.SetActive(true);
        SoundSetting.SetActive(false);
        HelpMenu.SetActive(false);
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
        HelpMenu.SetActive(false);
    }
    public void backMainMenu()
    {
        firstMenu.SetActive(true);
        SoundSetting.SetActive(false);
        HelpMenu.SetActive(false);
    }
    public void goHelpMenu()
    {
        firstMenu.SetActive(false);
        SoundSetting.SetActive(false);
        HelpMenu.SetActive(true);
    }
    public void goInGame()
    {
        SceneManager.LoadScene("inGame");
    }
}

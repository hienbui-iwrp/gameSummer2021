using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    public AudioSource MenuSound;
    public GameObject maps;
    public Text maps1;
    public Text maps2;
    public GameObject Name;
    public Text nameGame;
    public GameObject firstMenu;
    public GameObject SoundSetting;
    public GameObject HelpMenu;
    public Text start;
    public Text help;
    public Text soundSet;
    public Text size;
    public Text quit;
    // public Text startButton;
    // public Text soundButton;
    public Slider Sound;
    public static float SoundVolume;
    // public Text backButton;
    // Start is called before the first frame update
    void Start()
    {
        Name.SetActive(true);
        nameGame.text = "Chưa có tên";
        maps.SetActive(false);
        maps1.text = "Tổng quát khu vực:";
        maps2.text = "Triển thôi!";
        start.text = "Bắt đầu";
        help.text = "Hướng dẫn";
        soundSet.text = "Âm thanh";
        quit.text = "Thoát";
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
        maps.SetActive(false);
        firstMenu.SetActive(false);
        SoundSetting.SetActive(true);
        HelpMenu.SetActive(false);
    }
    public void backMainMenu()
    {
        maps.SetActive(false);
        firstMenu.SetActive(true);
        SoundSetting.SetActive(false);
        HelpMenu.SetActive(false);
    }
    public void goHelpMenu()
    {
        maps.SetActive(false);
        firstMenu.SetActive(false);
        SoundSetting.SetActive(false);
        HelpMenu.SetActive(true);
    }
    public void goMaps()
    {
        Name.SetActive(false);
        maps.SetActive(true);
        firstMenu.SetActive(false);
        SoundSetting.SetActive(false);
        HelpMenu.SetActive(false);
    }
    public void goInGame()
    {
        SceneManager.LoadScene("inGame");
    }
    public void exit()
    {
        Application.Quit();
    }
}

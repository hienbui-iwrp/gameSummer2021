using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    public AudioSource MenuSound;
    public GameObject level;
    public Text level1;
    public Text level2;
    public Text level3;
    public Text level4;
    public Text nameGame;
    public GameObject firstMenu;
    public GameObject SoundSetting;
    public GameObject HelpMenu;
    public Text start;
    public Text help;
    public Text help1;
    public Text soundSet;
    public Text size;
    public Text size1;
    public Text quit;
    // public Text startButton;
    // public Text soundButton;
    public Slider Sound;
    public static float SoundVolume = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        nameGame.text = "Chưa có tên";
        level.SetActive(false);
        level1.text = "Dễ";
        level2.text = "Thường";
        level3.text = "Khó";
        level4.text = "Trở về";
        start.text = "Bắt đầu";
        help.text = "Hướng dẫn";
        help1.text = "Trở về";
        soundSet.text = "Âm thanh";
        quit.text = "Thoát";
        size.text = "Độ lớn:";
        size1.text = "Trở về";
        firstMenu.SetActive(true);
        SoundSetting.SetActive(false);
        HelpMenu.SetActive(false);
        Sound.value = SoundVolume;
    }
    private void Update()
    {
        MenuSound.volume = Sound.value;
        SoundVolume = Sound.value;
    }
    public void goSoundSetting()
    {
        level.SetActive(false);
        firstMenu.SetActive(false);
        SoundSetting.SetActive(true);
        HelpMenu.SetActive(false);
    }
    public void backMainMenu()
    {
        level.SetActive(false);
        firstMenu.SetActive(true);
        SoundSetting.SetActive(false);
        HelpMenu.SetActive(false);
    }
    public void goHelpMenu()
    {
        level.SetActive(false);
        firstMenu.SetActive(false);
        SoundSetting.SetActive(false);
        HelpMenu.SetActive(true);
    }
    public void goLevel()
    {
        level.SetActive(true);
        firstMenu.SetActive(false);
        SoundSetting.SetActive(false);
        HelpMenu.SetActive(false);
    }
    public void goInGame(int level)
    {
        setLevel(level);
        SceneManager.LoadScene("inGame");
    }
    public void setLevel(int level)
    {
        if (level == 1)
        {
            numPeople.max = 20;
            batTakeDmg.maxHp = 5;
            createBat.delayMin = 20f;
            createBat.delayMax = 25f;
            Player.timeDestroyBullet = 1.5f;
        }
        if (level == 2)
        {
            batTakeDmg.maxHp = 6;
            numPeople.max = 25;
            createBat.delayMin = 10f;
            createBat.delayMax = 20f;
            Player.timeDestroyBullet = 1.3f;
        }
        if (level == 3)
        {
            batTakeDmg.maxHp = 7;
            numPeople.max = 30;
            createBat.delayMin = 5f;
            createBat.delayMax = 10f;
            Player.timeDestroyBullet = 1f;
        }
    }
    public void exit()
    {
        Application.Quit();
    }
}

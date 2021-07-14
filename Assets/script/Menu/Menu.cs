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
    public GameObject story;
    public GameObject SoundSetting;
    public GameObject HelpMenu;
    // public Text startButton;
    // public Text soundButton;
    public Slider Sound;
    public static float SoundVolume = 0.5f;
    // Start is called before the first frame update
    void Start()
    {

        level.SetActive(false);
        story.SetActive(false);
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
        story.SetActive(false);
        firstMenu.SetActive(false);
        SoundSetting.SetActive(true);
        HelpMenu.SetActive(false);
    }
    public void backMainMenu()
    {
        level.SetActive(false);
        story.SetActive(false);
        firstMenu.SetActive(true);
        SoundSetting.SetActive(false);
        HelpMenu.SetActive(false);
    }
    public void goHelpMenu()
    {
        level.SetActive(false);
        story.SetActive(false);
        firstMenu.SetActive(false);
        SoundSetting.SetActive(false);
        HelpMenu.SetActive(true);
    }
    public void goLevel()
    {
        level.SetActive(true);
        story.SetActive(false);
        firstMenu.SetActive(false);
        SoundSetting.SetActive(false);
        HelpMenu.SetActive(false);
    }
    public void goStory(int lv)
    {
        level.SetActive(false);
        story.SetActive(true);
        firstMenu.SetActive(false);
        SoundSetting.SetActive(false);
        HelpMenu.SetActive(false);
        setLevel(lv);
        // goInGame();
    }
    public void goInGame()
    {
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
            createShield.create = true;
            createVaccine.maxVaccine = 10;
            createShield.delay = 0;
            Player.timeDestroyBullet = 1.5f;
            gameControl.delayBonus = 6;

        }
        if (level == 2)
        {
            batTakeDmg.maxHp = 6;
            numPeople.max = 25;
            createBat.delayMin = 10f;
            createBat.delayMax = 20f;
            createShield.create = true;
            createVaccine.maxVaccine = 8;
            createShield.delay = 10;
            Player.timeDestroyBullet = 1.3f;
            gameControl.delayBonus = 7;
        }
        if (level == 3)
        {
            batTakeDmg.maxHp = 7;
            numPeople.max = 30;
            createBat.delayMin = 5f;
            createBat.delayMax = 10f;
            createVaccine.maxVaccine = 6;
            createShield.create = false;
            Player.timeDestroyBullet = 1f;
            gameControl.delayBonus = 8;
        }
    }
    public void exit()
    {
        Application.Quit();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class firstMenu : MonoBehaviour
{
    public Text help;
    public Text exit;
    public GameObject FirstMenu;
    public GameObject HelpMenu;
    bool onSetting = false;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
        help.text = "Hướng dẫn";
        exit.text = "Thoát";
    }
    public void goHelpMenu()
    {
        gameObject.SetActive(false);
        HelpMenu.SetActive(true);
    }
    public void exitGame()
    {
        SceneManager.LoadScene("Menu");
    }
    public void goBack()
    {
        FirstMenu.SetActive(true);
        HelpMenu.SetActive(false);
    }
    public void goSetting()
    {
        if (!onSetting)
        {
            FirstMenu.SetActive(true);
            HelpMenu.SetActive(false);
            onSetting = true;
            Time.timeScale = 0;
        }
        else
        {
            FirstMenu.SetActive(false);
            HelpMenu.SetActive(false);
            onSetting = false;
            Time.timeScale = 1;
        }
    }
}

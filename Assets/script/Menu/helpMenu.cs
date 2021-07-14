using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class helpMenu : MonoBehaviour
{
    public GameObject[] helpList;
    public Menu menu;
    public GameObject mainMenu;
    public Text next;
    public int cur = 0;
    void Start()
    {
        gameObject.SetActive(false);
        for (int i = 0; i < helpList.Length; i++)
            helpList[i].SetActive(false);
    }
    private void Update()
    {
        for (int i = 0; i < helpList.Length; i++)
        {
            if (i == cur) helpList[i].SetActive(true);
            else helpList[i].SetActive(false);
        }
        if (cur == helpList.Length - 1) next.text = "Ok";
        else next.text = "Next";
    }
    public void goNext()
    {
        cur++;
        if (cur == helpList.Length)
        {
            goMainMenu();
            cur = 0;
        }
    }
    public void goNextStory()
    {
        cur++;
        if (cur == helpList.Length)
        {
            menu.goInGame();
            cur = 0;
        }
    }
    public void goBack()
    {
        cur--;
        if (cur == -1)
        {
            goMainMenu();
            cur = 0;
        }
    }
    public void goMainMenu()
    {
        gameObject.SetActive(false);
        mainMenu.SetActive(true);
    }
}

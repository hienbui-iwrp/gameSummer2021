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
    bool EndGame = false;
    bool win = false;
    private void Update()
    {
        EndGame = true;
        win = true;
        foreach (people someOne in people.allPeople)
        {
            if (someOne.vaccine == false) EndGame = false;
        }
        if (people.allPeople.Count <= 0)
        {
            EndGame = true;
            win = false;
        }
        if (EndGame) exit();
    }
    public void goMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void exit()
    {
        if (win) point.GetComponent<Point>().result.text = "Chiến thắng!!!";
        else
        {
            point.GetComponent<Point>().result.text = "Thất bại";
            point.GetComponent<Point>().bonus = 0;
        }
        point.GetComponent<Point>().enable();
        info.SetActive(false);
        Time.timeScale = 0;
    }
}

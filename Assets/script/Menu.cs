using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{

    public Text start;
    // Start is called before the first frame update
    void Start()
    {
        start.text = "Bắt đầu";
    }
    public void goInGame()
    {
        SceneManager.LoadScene("inGame");
    }
}

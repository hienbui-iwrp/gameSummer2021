using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class noteEnd : MonoBehaviour
{
    public Text note;
    public void winGame()
    {
        note.text = "Nhiệm vụ hoàn tất!!!";
    }
    public void loseGame()
    {
        note.text = "Dịch bệnh đã lan quá rộng";
    }
    public void loseBat()
    {
        note.text = "Khu cách ly đã bị virus xâm nhập";
    }
}

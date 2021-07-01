using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class bagInfo : MonoBehaviour
{
    // Start is called before the first frame update
    public int max;
    public Text number;
    private void Start()
    {
        setNumber(0);
    }
    public void setNumber(int num)
    {
        number.text = num.ToString() + "/" + max.ToString();
    }
}

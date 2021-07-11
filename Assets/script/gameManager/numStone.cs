using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class numStone : MonoBehaviour
{
    public bagInfo stoneInfo;
    public static int num = 0;
    public static int max = 20;
    private void Start()
    {
        stoneInfo.max = max;
    }
    private void Update()
    {
        stoneInfo.setNumber(num);
    }
}

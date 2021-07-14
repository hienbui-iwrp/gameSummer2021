using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createStone : MonoBehaviour
{
    public GameObject[] stoneList;
    public static int curStone = 0;
    public static int maxStone = 40;
    // Start is called before the first frame update
    void Start()
    {
        if (Random.Range(0f, 1f) > 0.3)
            if (curStone < maxStone)
            {
                int stoneType = Random.Range(0, stoneList.Length);
                GameObject newStone = Instantiate<GameObject>(stoneList[stoneType], transform);
                newStone.transform.position = transform.position;
                curStone++;
            }
    }
}

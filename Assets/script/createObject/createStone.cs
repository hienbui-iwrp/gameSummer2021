using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createStone : MonoBehaviour
{
    public GameObject[] stoneList;
    public static int curStone = 0;
    // Start is called before the first frame update
    void Start()
    {
        if (Random.Range(0f, 1f) > 0.5)
            if (curStone < 40)
            {
                int stoneType = Random.Range(0, stoneList.Length);
                GameObject newStone = Instantiate<GameObject>(stoneList[stoneType], transform);
                newStone.transform.position = transform.position;
                curStone++;
            }
    }
}

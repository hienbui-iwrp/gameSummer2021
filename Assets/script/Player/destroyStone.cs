using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyStone : MonoBehaviour
{
    int curStone = 15;
    public void takeStone()
    {
        curStone -= 5;
        if (curStone <= 0) Destroy(this.gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkBat : MonoBehaviour
{
    // Start is called before the first frame update
    public Warning warning;
    float range = 15;
    bool annouce = false;
    batTakeDmg batWarning = null;
    private void Update()
    {
        check();
    }
    void check()
    {
        if (!annouce)
        {
            if (!getShield.beProtected)
                foreach (batTakeDmg bat in batTakeDmg.allBat)
                {
                    if (Vector2.Distance(transform.position, bat.transform.position) < range)
                    {
                        warning.show();
                        batWarning = bat;
                        annouce = true;
                        break;
                    }
                }
        }
        else
        {
            if (getShield.beProtected || (batWarning == null) || (Vector2.Distance(transform.position, batWarning.transform.position) > range))
            {
                warning.offShow();
                annouce = false;
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class premierballs : MonoBehaviour
{
    berry inv;
    public int sigmaboy = 0;
    inventorymain hurhur;
    checkInteraction checker;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        inv = GameObject.Find("Berry").GetComponent<berry>();
        hurhur = GameObject.FindGameObjectWithTag("inventorymain").GetComponent<inventorymain>();
        checker = GameObject.FindGameObjectWithTag("Player").GetComponent<checkInteraction>();
        if (inv.berryinv == 1)
        {
            hurhur.slots += 1;
            if (hurhur.slots == 1)
            {
                sigmaboy = 1;
                inv.berryinv = 0;
            }
            else if (hurhur.slots == 2)
            {
                sigmaboy = 2;
                inv.berryinv = 0;
            }
            else if (hurhur.slots == 3)
            {
                sigmaboy = 3;
                inv.berryinv = 0;
            }
            else if (hurhur.slots >= 4)
            {
                print("too many items");
                inv.berryinv = 0;
            }
            checker.berrytime = 0;
            inv.berryinv = 0;
        }
        if (sigmaboy == 1)
        {
            transform.localPosition = new Vector3(hurhur.invx - 308f, hurhur.invy - 44.46f);
        }
        else if (sigmaboy == 2)
        {
            transform.localPosition = new Vector3(hurhur.invx, hurhur.invy - 44.46f);
        }
        else if (sigmaboy == 3)
        {
            transform.localPosition = new Vector3(hurhur.invx + 303, hurhur.invy - 44.46f);
        }
    }
}

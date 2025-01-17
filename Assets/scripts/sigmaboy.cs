using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sigmaboy : MonoBehaviour
{
    inventorymain inv;
    int sigmaballs = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        inv = GameObject.FindGameObjectWithTag("inventorymain").GetComponent<inventorymain>();
        if (inv.sigmaboy == 1)
        {
            if (inv.slots == 1)
            {
                sigmaballs = 1;
                inv.sigmaboy = 0;
            }
            else if (inv.slots == 2)
            {
                sigmaballs = 2;
                inv.sigmaboy = 0;
            }
            else if (inv.slots == 3)
            {
                sigmaballs = 3;
                inv.sigmaboy = 0;
            }
            else if (inv.slots >= 4)
            {
                print("too many items");
                inv.skibiditoilet = 0;
            }
        }
        if (sigmaballs == 1)
        {
            transform.localPosition = new Vector3(inv.invx - 308f, inv.invy - 44.46f);
        }
        else if (sigmaballs == 2)
        {
            transform.localPosition = new Vector3(inv.invx, inv.invy - 44.46f);
        }
        else if (sigmaballs == 3)
        {
            transform.localPosition = new Vector3(inv.invx + 303, inv.invy - 44.46f);
        }
    }
}

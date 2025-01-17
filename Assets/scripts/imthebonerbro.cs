using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class imthebonerbro : MonoBehaviour
{
    inventorymain inv;
    int sigmaboy = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        inv = GameObject.FindGameObjectWithTag("inventorymain").GetComponent<inventorymain>();
        if (inv.skibiditoilet == 1)
        {
           if (inv.slots == 1)
            {
                sigmaboy = 1;
                inv.skibiditoilet = 0;
            }else if (inv.slots == 2)
            {
                sigmaboy = 2;
                inv.skibiditoilet = 0;
            }
            else if (inv.slots == 3)
            {
                sigmaboy = 3;
                inv.skibiditoilet = 0;
            }
            else if (inv.slots >= 4)
            {
                print("too many items");
                inv.skibiditoilet = 0;
            }
        }
        if (sigmaboy == 1)
        {
            transform.localPosition = new Vector3(inv.invx - 308f, inv.invy - 44.46f);
        }else if (sigmaboy == 2)
        {
            transform.localPosition = new Vector3(inv.invx, inv.invy - 44.46f);
        }else if (sigmaboy == 3)
        {
            transform.localPosition = new Vector3(inv.invx + 303, inv.invy - 44.46f);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interact : MonoBehaviour
{
    doordetection Doordetectthingy;
    doordetection xything;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Doordetectthingy = GameObject.FindGameObjectWithTag("Player").GetComponent<doordetection>();
        xything = GameObject.FindGameObjectWithTag("Player").GetComponent<doordetection>();
        if (Doordetectthingy.wa == 0)
        {
            transform.position = new Vector3(1000, 1000);
        }else
        {
            transform.position = new Vector3(xything.playerx, xything.playery);
        }
    }
}

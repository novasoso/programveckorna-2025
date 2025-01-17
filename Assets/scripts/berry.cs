using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class berry : MonoBehaviour
{
    checkInteraction checker;
    public int berryinv = 0;
    NightMode hihi;
    float rememberx;
    float remembery;
    public int buffer = 0;
    public int emptyberry = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        checker = GameObject.FindGameObjectWithTag("Player").GetComponent<checkInteraction>();
        hihi = GameObject.FindGameObjectWithTag("nightcontroller").GetComponent<NightMode>();
        if (hihi.isNight == true && buffer == 0)
        {
            buffer = 1;
            rememberx = transform.position.x;
            remembery = transform.position.y;
            Invoke("byebye", 1f);
            emptyberry = 1;
        }
        if (hihi.isNight == false && buffer == 1)
        {
            buffer = 0;
            Invoke("comeback", 1f);
            emptyberry = 0;
        }
        if (checker.berrytime == 1)
        {
            transform.position = new Vector3(1000, transform.position.y, 2);
            berryinv = 1;
        }
    }
    void byebye()
    {
        transform.position = new Vector3(1000, transform.position.y, 2);
    }
    void comeback()
    {
        transform.position = new Vector3(rememberx, remembery, -1);
    }
}

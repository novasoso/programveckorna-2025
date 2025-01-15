using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class InventoryCenter : MonoBehaviour
{
    Vector3 positionToReturnTo;
    public int inventoryWIP;
    Rigidbody2D rb;
    public int invbuffer = 0;
    public float sigma = 0;
    // Start is called before the first frame update
    void Start()
    {
        inventoryWIP = 0;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        sigma = transform.localPosition.x;
        if (sigma <= 0 && inventoryWIP == 0 && invbuffer == 1) //detects if the cooldown is active, which version it is and if the object's x position is below a certain limit before stopping the object
        {
            Invoke("moveinventory", 0f);
        }else if (sigma >= 1700 && inventoryWIP == 1 && invbuffer == 1)
        {
            Invoke("moveinventory2", 0f);
        }
        if (Input.GetKeyDown(KeyCode.I) && invbuffer == 0) //detects if u pressed I and the cooldown isnt active
        {
            invbuffer = 1;
            if (inventoryWIP == 1) //checks whether it should move to the center of your screen or to the side
            {
                rb.velocity = new Vector2(1200, 0);
            } else if (inventoryWIP == 0)
            {
                rb.velocity = new Vector2(-1200, 0);
            }
        }
    }
    void moveinventory2() // different versions of the method that stops the object
    {
        rb.velocity = new Vector2(0, 0);
        transform.localPosition = new Vector3(1700, 0);
        inventoryWIP = 0;
        invbuffer = 0;
    }
    void moveinventory()
    {
        rb.velocity = new Vector2(0, 0);
        transform.localPosition = new Vector3(0, 0);
        inventoryWIP = 1;
        invbuffer = 0;
    }
}

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
    // Start is called before the first frame update
    void Start()
    {
        positionToReturnTo = transform.position;
        inventoryWIP = 0;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (inventoryWIP == 1)
            {
                rb.velocity = new Vector2(1200, 0);
                Invoke("moveinventory2", 0.55f);
            } else if (inventoryWIP == 0)
            {
                rb.velocity = new Vector2(-1200, 0);
                Invoke("moveinventory", 0.55f);
            }
        }
    }
    void moveinventory2()
    {
        rb.velocity = new Vector2(0, 0);
        transform.localPosition = new Vector3(1700, 0);
        inventoryWIP = 0;
    }
    void moveinventory()
    {
        rb.velocity = new Vector2(0, 0);
        transform.localPosition = new Vector3(0, 0);
        inventoryWIP = 1;
    }
}

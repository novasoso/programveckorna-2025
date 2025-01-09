using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    Rigidbody2D rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.velocity = new Vector2(0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody.velocity = new Vector2(0, 0);
        float speed = 4;
        if (Input.GetKey(KeyCode.A))
        {
            rigidbody.velocity = new Vector2(-8, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rigidbody.velocity = new Vector2(8, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rigidbody.velocity = new Vector2(0, -8);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rigidbody.velocity = new Vector2(0, 8);
        }
        if (Input.GetKey(KeyCode.R))
        {
            transform.position = new Vector3(0, 0);
        }
    }
}

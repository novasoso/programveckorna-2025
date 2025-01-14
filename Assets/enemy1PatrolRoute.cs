using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy1PatrolRoute : MonoBehaviour
{
    Rigidbody2D rb;
    Vector3 point1;
    Vector3 point2;
    Vector3 point3;
    Vector3 point4;

    bool walkingToPoint1;
    bool walkingToPoint2;
    bool walkingToPoint3;
    bool walkingToPoint4;

    public float walkSpeed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        findRoute(transform.position);
        walkingToPoint1 = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (walkingToPoint1)
        {
            print("walking to point1");
            if (transform.position == point1)
            {
                print("i am at point1, my current location is " + transform.position + " compared to point1 " + point1);
                walkingToPoint1 = false;
                walkingToPoint2 = true;
            }
            else
            {
                getToPoint(point1);
            }
        }
        else if (walkingToPoint2)
        {
            print("walking to point2");
            if (transform.position == point2)
            {
                print("i am at point2, my current location is " + transform.position + " compared to point2 " + point2);
                walkingToPoint2 = false;
                walkingToPoint3 = true;
            }
            else
            {
                getToPoint(point2);
            }
        }
        else if (walkingToPoint3)
        {
            print("walking to point3");
            if (transform.position == point3)
            {
                print("i am at point3, my current location is " + transform.position + " compared to point3 " + point3);
                walkingToPoint3 = false;
                walkingToPoint4 = true;
            }
            else
            {
                getToPoint(point3);
            }
        }
        else if (walkingToPoint4)
        {
            print("walking to point4");
            if (transform.position == point4)
            {
                print("i am at point4, my current location is " + transform.position + " compared to point4 " + point4);
                walkingToPoint4 = false;
                walkingToPoint1 = true;
            }
            else
            {
                getToPoint(point4);
            }
        }
        
    }

    private void findRoute(Vector2 myPosition)
    {
        point1.x = myPosition.x + Random.Range(3, 3);
        point1.y = point1.x;
        point1.z = 0;
        print(point1);

        point2.x = myPosition.x - Random.Range(3, 3);
        point2.y = -point2.x;
        point2.z = 0;
        print(point2);

        point3.x = myPosition.x - Random.Range(3, 3);
        point3.y = point3.x;
        point3.z = 0;
        print(point3);

        point4.x = myPosition.x + Random.Range(3, 3);
        point4.y = -point4.x;
        point4.z = 0;
        print(point4);
    }
    private void getToPoint(Vector2 point)
    {
        while(transform.position.x != point.x)
        {
            if (transform.position.x > point.x)
            {
                rb.velocity = new(0, walkSpeed);
            }
            else if (transform.position.x < point.x)
            {
                rb.velocity = new(0, -walkSpeed);
            }
            else if (transform.position.x == point.x)
            {
                rb.velocity = new(0, 0);
            }
        }
    }
}

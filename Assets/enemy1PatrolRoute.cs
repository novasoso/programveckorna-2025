using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class enemy1PatrolRoute : MonoBehaviour
{
    EnemyMovement chaseSequence;
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
        chaseSequence = GetComponent<EnemyMovement>();
        rb = GetComponent<Rigidbody2D>();
        findRoute(transform.position);
        walkingToPoint1 = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (chaseSequence.inChase == false)
        {
            if (walkingToPoint1)
            {
                if (atTarget(point1))
                {
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
                if (atTarget(point2))
                {
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
                if (atTarget(point3))
                {
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
                if (atTarget(point4))
                {
                    walkingToPoint4 = false;
                    walkingToPoint1 = true;
                }
                else
                {
                    getToPoint(point4);
                }
            }
        }
        else
        {
            chaseSequence.imChasinYouGraaahhhhhh();
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
        bool atPointX =false;
        if(atPointX == false)
        {
            if (atOneTarget(transform.position.x, point.x))
            {
                rb.velocity = new(0, 0);
                atPointX = true;
            }
            else if (transform.position.x > point.x)
            {
                rb.velocity = new(-walkSpeed, 0);
            }
            else if (transform.position.x < point.x)
            {
                rb.velocity = new(walkSpeed, 0);
            }
        }
        
        if (atPointX == true)
        {
            if (atOneTarget(transform.position.y, point.y))
            {
                rb.velocity = new(0, 0);
            }
            else if (transform.position.y > point.y)
            {
                rb.velocity = new(rb.velocity.x, -walkSpeed);
            }
            else if (transform.position.y < point.y)
            {
                rb.velocity = new(rb.velocity.x, walkSpeed);
            }
        }
    }
    bool atTarget(Vector2 point)
    {
        if (atOneTarget(transform.position.x, point.x))
        {
            if (atOneTarget(transform.position.y, point.y))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }
    bool atOneTarget(float myLocation, float target)
    {
        if (myLocation <= target + 0.1 && myLocation >= target - 0.1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && chaseSequence.inChase == false)
        {
            rb.velocity = new(0, 0);
            chaseSequence.inChase = true;
        }
    }
}

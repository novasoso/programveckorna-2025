using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treeScript : MonoBehaviour
{
    GameObject player;
    SpriteRenderer myLayer;
    public float offset;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        myLayer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y-offset > player.transform.position.y)
        {
            transform.position = new (transform.position.x, transform.position.y, 1);
        }
        else if (transform.position.y-offset < player.transform.position.y)
        {
            transform.position = new(transform.position.x, transform.position.y, -1);
        }
    }
}

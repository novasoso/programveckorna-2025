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
        myLayer.sortingOrder = -Mathf.FloorToInt (100* transform.position.y);
    }

    // Update is called once per frame
    void Update()
    {
    }
}

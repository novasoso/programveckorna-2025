using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderinLayer : MonoBehaviour
{
    SpriteRenderer me;
    // Start is called before the first frame update
    void Start()
    {
        me = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        me.sortingOrder = -Mathf.FloorToInt(100 * transform.position.y);
    }
}

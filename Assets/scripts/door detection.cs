using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class doordetection : MonoBehaviour
{
    public int wa = 0;
    public float playerx;
    public float playery;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerx = transform.position.x;
        playery = transform.position.y;
        wa = 0;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "door")
        {
            if (Input.GetKey(KeyCode.E))
            {
                SceneManager.LoadScene(3);
            }
            wa = 1;
        }
    }
}

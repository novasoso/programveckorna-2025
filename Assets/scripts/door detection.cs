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
    public string sceneToVisit;
    GameObject playa;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerx = transform.position.x;
        playery = transform.position.y;
        if (wa == 1 && (playa.tag == "Player")&&playa!=null)
        {
            if (Input.GetKey(KeyCode.E))
            {
                SceneManager.LoadScene(sceneToVisit);
            }
            wa = 1;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        wa = 1;
        playa = collision.gameObject;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        playa = null;
        wa = 0;
    }
}

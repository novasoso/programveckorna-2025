using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpHammer : MonoBehaviour
{
    checkInteraction hammertime;
   
    // Start is called before the first frame update
    void Start()
    {
        hammertime = GameObject.FindGameObjectWithTag("Player").GetComponent<checkInteraction>();
    }

    // Update is called once per frame(
    void Update()
    {
       if (hammertime.pickedUpHammer == true)
        {
            Destroy(gameObject);
        }
    }
}

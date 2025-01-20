using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class DialogBoxController : MonoBehaviour
{
    public GameObject box;
    playerDetecter  vhjkjlk;
    public float moveBox;
    // Start is called before the first frame update
    void Start()
    {
        box.transform.localPosition = new(box.transform.localPosition.x, moveBox - 140, box.transform.localPosition.z);
        vhjkjlk = GetComponent<playerDetecter>();
    }

    // Update is called once per frame
    void Update()
    {
        if (vhjkjlk.PlayerDetected == true && Input.GetKeyDown(KeyCode.E))
        {
            box.transform.localPosition = new(0, 160, 0);
        }
        else if (vhjkjlk.PlayerDetected == false)
        {
            if(box.transform.localPosition.y == 270)
            {
                box.transform.localPosition = new Vector3(0, -225, 0);
            }
        }
    }
}

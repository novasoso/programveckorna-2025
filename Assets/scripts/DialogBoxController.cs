using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class DialogBoxController : MonoBehaviour
{
    public GameObject box;
    playerDetecter  vhjkjlk;
    float moveBox;
    // Start is called before the first frame update
    void Start()
    {
        moveBox = box.transform.localPosition.y;
        box.transform.localPosition = new(box.transform.localPosition.x, moveBox - 140, box.transform.localPosition.z);
        vhjkjlk = GetComponent<playerDetecter>();
    }

    // Update is called once per frame
    void Update()
    {
        if (vhjkjlk.PlayerDetected == true && Input.GetKeyDown(KeyCode.E))
        {
            box.transform.localPosition = new( box.transform.localPosition.x, moveBox);
        }
        else if (vhjkjlk.PlayerDetected == false)
        {
            if(box.transform.localPosition.y > moveBox - 270)
            {
                box.transform.localPosition -= new Vector3(0, 270, 0);
            }
        }
    }
}

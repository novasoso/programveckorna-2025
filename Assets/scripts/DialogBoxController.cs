using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class DialogBoxController : MonoBehaviour
{
    public GameObject box;
    playerDetecter detector;
    public float moveBox;
    bool boxInView;
    // Start is called before the first frame update
    void Start()
    {
        box.transform.position = new(box.transform.position.x, -225, box.transform.position.z);
        detector = GetComponent<playerDetecter>();
    }

    // Update is called once per frame
    void Update()
    {
        print("hello!!11");
        if (detector.PlayerDetected == true && Input.GetKeyDown(KeyCode.E))
        {
            print("moved the bawcks");
            boxInView = true;
            box.transform.position = new(box.transform.position.x, 160, box.transform.position.z);
        }
        else if (detector.PlayerDetected == false && boxInView == false)
        {
            print("cant fidn u buddy");
            boxInView = false;
            box.transform.position = new Vector3(box.transform.position.x, -225, box.transform.position.z);
        }
    }
}

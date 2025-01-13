using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class DialogBoxController : MonoBehaviour
{
    public GameObject box;
    mainDialogueText tmp;
    private bool boxIsInView = true;
    // Start is called before the first frame update
    void Start()
    {
        tmp = box.GetComponentInChildren<mainDialogueText>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        tmp.tmpugui.text = "Hey there, buddy.";

        while (boxIsInView == false && Input.GetKeyDown(KeyCode.E)==false)
        {
            box.transform.position += new Vector3(0, 260, 0);
            boxIsInView = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        box.transform.position -= new Vector3(0, 260, 0);
        boxIsInView = false;
    }
}

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DialogBoxController : MonoBehaviour
{
    checkInteraction check;
    public GameObject box;
    private bool boxIsInView = true;
    // Start is called before the first frame update
    void Start()
    {
        check = GameObject.FindGameObjectWithTag("Player").GetComponent<checkInteraction>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("playered triggered npc & boxisinview is "+boxIsInView);
        while (boxIsInView == false && Input.GetKeyDown(KeyCode.E)==false)
        {
            box.transform.position = new(0, 160, 0);
            boxIsInView = true;
            print("Box moved to 160!");
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        print("player left npc trigger and");
        box.transform.position = new(0, -100, 0);
        boxIsInView = false;
        print("Box moved to -100!");
        print("boxisinview is " + boxIsInView);

    }
}

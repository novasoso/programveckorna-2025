using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DialogBoxController : MonoBehaviour
{
    checkInteraction check;
    List<GameObject> potentialBoxList;
    private bool isInside;
    private bool boxIsInView = false;
    // Start is called before the first frame update
    void Start()
    {
        check = GameObject.FindGameObjectWithTag("Player").GetComponent<checkInteraction>();
        potentialBoxList = new List<GameObject>(GameObject.FindObjectsOfType<GameObject>());
    }

    // Update is called once per frame
    void Update()
    {

    }
    private GameObject findBox()
    {
        print(potentialBoxList);
        foreach(GameObject obj in potentialBoxList)
        {
            print(obj);
            if (obj.name == "Dialoguebox")
            {
                print("found box! returning " + obj + "...");
                return obj;
            }
        }
        print("found nothing :(, returning null...");
        return null;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("playered triggered npc");
        isInside = true;
        while (boxIsInView == false || isInside == true)
        {
            print("in while loop");
            if (check.interacting == true && boxIsInView == false)
            {
                findBox().transform.position = new(0, 160, 0);
                boxIsInView = true;
                print("Box moved to 160!");
            }
        }
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        isInside = false;
        print("playered left npc trigger");
        findBox().transform.position = new(0, -100, 0);
        boxIsInView = false;
        print("Box moved to -100!");
    }
}

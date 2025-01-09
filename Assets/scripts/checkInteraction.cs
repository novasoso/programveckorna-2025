using System;
using Unity.VisualScripting;
using UnityEngine;

public class checkInteraction : MonoBehaviour
{
    playerDetecter detecter;
    GameObject nearbyInteractable;
    public bool interacting = false;
    public int timesInteracted = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (nearbyInteractable != null && detecter.PlayerDetected == true) //if nearby npc/item is found AND the nearby NPC is detecting the player
        {
            if (nearbyInteractable.CompareTag("Interactable") && Input.GetKeyDown(KeyCode.E)) // if the nearby interactable is item and E is pressed
            {
                interacting = true; //player has interacted
            }
            else if (nearbyInteractable.CompareTag("NPC") && Input.GetKeyDown(KeyCode.E)) // else, if the nearby interactable is NPC and E is pressed
            {
                interacting = true; //player has interacted
                string getDialogue = nearbyInteractable.name + "DialogueText"; //save the npc's name +"DialogueText" as a string, which is the script containing the given npcs dialogue
                if (nearbyInteractable.GetComponent(getDialogue.GetType()) != null) //if the nearby npc's dialogue script is not null, then -
                {
                    print("works kinda");
                    getDialogue.GetType DialogueToAccess = nearbyInteractable.GetComponent(getDialogue.GetType()); // access and assign the npc's dialogue script as getDialogues class
                    DialogueToAccess.Dialogue(); //call upon the npc's dialogue Method.
                    timesInteracted++;
                }
            }
        }
        else
        {
            timesInteracted = 0;
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (ObjectDetectedisInteractable(collision)) // determines if the object that triggererd is interactable:
        {
            nearbyInteractable = collision.gameObject;
            detecter = collision.gameObject.GetComponent<playerDetecter>();
            //save the npc's data
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        nearbyInteractable = null;
        detecter = null;
        //reset the variables that had saved the detected NPC's data
    }
    private bool ObjectDetectedisInteractable(Collider2D collision) //determine if the object given is interacteable. returns true if yes
    {
        if (collision.gameObject.CompareTag("Interactable") || collision.gameObject.CompareTag("NPC"))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

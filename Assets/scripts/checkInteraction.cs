using System;
using UnityEngine;

public class checkInteraction : MonoBehaviour
{
    playerDetecter detecter;
    GameObject nearbyInteractable;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (nearbyInteractable != null && detecter.PlayerDetected == true)
        {
            if (nearbyInteractable.CompareTag("Interactable") && Input.GetKeyDown(KeyCode.E))
            {
                print("begin interact with item/pick up sequence");
            }
            else if (nearbyInteractable.CompareTag("NPC") && Input.GetKeyDown(KeyCode.E))
            {
                print("begin dialogue");
                string getDialogue = nearbyInteractable.name + "DialogueText";
                if (nearbyInteractable.GetComponent(getDialogue.GetType()) != null)
                {
                    Type skibidi.GetType = nearbyInteractable.GetComponent(getDialogue.GetType());
                    nearbyInteractable.Dialogue();
                }
            }

        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (ObjectDetectedisInteractable(collision))
        {
            nearbyInteractable = collision.gameObject;
            detecter = collision.gameObject.GetComponent<playerDetecter>();
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        nearbyInteractable = null;

    }
    private bool ObjectDetectedisInteractable(Collider2D collision)
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

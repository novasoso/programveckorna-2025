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
        if (nearbyInteractable != null && nearbyInteractable.CompareTag("Interactable") && detecter.PlayerDetected == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                print("begin interact event sequence");
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
        if (collision.gameObject.CompareTag("Interactable"))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

using UnityEngine;

public class editInteractionPrompt : MonoBehaviour
{
    playerDetecter detector;
    GameObject interactionpromptcontroller;
    interactionPromptController TexttoEdit;
    // Start is called before the first frame update
    void Start()
    {
        detector = GetComponent<playerDetecter>();
        interactionpromptcontroller = GameObject.FindGameObjectWithTag("interactPrompt");
        TexttoEdit = interactionpromptcontroller.GetComponent<interactionPromptController>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (detector.CollisionIsPlayer(collision) == true)
        {
            TexttoEdit.tmpugui.text = "Press E to Interact.";
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (detector.CollisionIsPlayer(collision) == true)
        {
            TexttoEdit.tmpugui.text = " ";
        }
    }
}

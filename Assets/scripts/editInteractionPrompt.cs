using UnityEngine;

public class editInteractionPrompt : MonoBehaviour
{
    playerDetecter detector;
    GameObject interactionpromptcontroller;
    interactionPromptController TexttoEdit;
    firstTimer totalInteractsLeft;
    // Start is called before the first frame update
    void Start()
    {
        detector = GetComponent<playerDetecter>();
        interactionpromptcontroller = GameObject.FindGameObjectWithTag("interactPrompt");
        TexttoEdit = interactionpromptcontroller.GetComponent<interactionPromptController>();
        totalInteractsLeft = GameObject.FindGameObjectWithTag("Player").GetComponent<firstTimer>();

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (detector.CollisionIsPlayer(collision) == true && totalInteractsLeft.Index < 0)
        {
            TexttoEdit.tmpugui.text = "Interact?";
        }
        else if (detector.CollisionIsPlayer(collision) == true && totalInteractsLeft.Index > -1)
        {
            TexttoEdit.tmpugui.text = "Press E to Interact.";
            totalInteractsLeft.Index--;
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

using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NPC1DialogueText : MonoBehaviour
{
    GameObject box;

    private checkInteraction interactScript;
    private playerDetecter detector;
    public GameObject changeIcon;
    private Image changeThis;
    private mainDialogueText tmp;
    public Sprite myDialogueIcon;
    public int dialogueTrack = 0;
    public float revealTime;
    hehehh activator;
    public int skibidi = 0;
    // Start is called before the first frame update
    void Start()
    {
        
        detector = GetComponent<playerDetecter>(); //assign MY playerDetecter script
        interactScript = GameObject.FindGameObjectWithTag("Player").GetComponent<checkInteraction>(); // find and assign Player's checkInteraction script
        changeThis = changeIcon.GetComponent<Image>();
        tmp = GameObject.FindGameObjectWithTag("dialogue").GetComponentInChildren<mainDialogueText>();
    }

    public void Dialogue()
    {
        while (detector.PlayerDetected == true && interactScript.interacting == true)
        {
            changeThis.sprite = myDialogueIcon;
            if (dialogueTrack == 0)
            {
                tmp.StartRevealText("I'm mr sigma guy", revealTime); //calls upon method inside mainDialogueText that does stuff. reveal time accounts for time spent generating first arguement
            }
            else if (dialogueTrack == 1)
            {
                tmp.StartRevealText("I eat sigma", revealTime);
            }
            else if (dialogueTrack == 2)
            {
                tmp.StartRevealText("You're not sigma", revealTime);
            }
            else if (dialogueTrack == 3)
            {
                tmp.StartRevealText("Get items to become sigma", revealTime);
            }
            else if (dialogueTrack >= 4)
            {
                tmp.StartRevealText("Open inventory with I for a little more sigma", revealTime);
            }
            dialogueTrack++;
            interactScript.interacting = false;

        }
    }
}

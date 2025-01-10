using UnityEngine;

public class NPC1DialogueText : MonoBehaviour
{
    private checkInteraction interactScript;
    private playerDetecter detector;
    private mainDialogueText tmp;
    int dialogueTrack = 0;
    public float revealTime;
    // Start is called before the first frame update
    void Start()
    {
        
        detector = GetComponent<playerDetecter>(); //assign MY playerDetecter script
        interactScript = GameObject.FindGameObjectWithTag("Player").GetComponent<checkInteraction>(); // find and assign Player's checkInteraction script
        tmp = GameObject.FindGameObjectWithTag("dialogue").GetComponent<mainDialogueText>();
    }
    public void Dialogue()
    {
        while (detector.PlayerDetected == true && interactScript.interacting == true)
        {
            if (dialogueTrack == 0)
            {
                tmp.StartRevealText("insert dialogue track1", revealTime); //calls upon method inside mainDialogueText that does stuff. reveal time accounts for time spent generating first arguement
            }
            else if (dialogueTrack == 1)
            {
                tmp.StartRevealText("insert dialogue track2", revealTime);
            }
            else if (dialogueTrack == 2)
            {
                tmp.StartRevealText("insert dialogue track3", revealTime);
            }
            else if (dialogueTrack == 3)
            {
                tmp.StartRevealText("insert dialogue track4", revealTime);
            }
            else if (dialogueTrack >= 4)
            {
                tmp.StartRevealText("insert dialogue track5", revealTime);
            }
            dialogueTrack++;
            interactScript.interacting = false;
        }
    }
}

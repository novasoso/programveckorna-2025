using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NPC1DialogueText : MonoBehaviour
{
    GameObject box;

    checkInteraction hammertime;

    public bool startedSecondQuest = false;

    private checkInteraction interactScript;

    private playerDetecter detector;

    public GameObject changeIcon;

    private Image changeThis;

    private mainDialogueText tmp;
    
    public Sprite myDialogueIcon;
    
    public int dialogueTrack = 0;
    
    public float zibzab;
    
    public bool startedQuest = false;
    
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
            if (hammertime.pickedUpHammer == true)
            {
                tmp.StartRevealText("Can you find my planks as well?", zibzab);
                startedSecondQuest = true;

            }
            else if (dialogueTrack == 0)
            {
                tmp.StartRevealText("G'day friend! The name's Greg.", zibzab); //calls upon method inside mainDialogueText that does stuff. reveal time accounts for time spent generating first arguement
            }
            else if (dialogueTrack == 1)
            {
                tmp.StartRevealText("I've lost all me planks and tools. They're scattered around this area.", zibzab);
            }
            else if (dialogueTrack == 2)
            {
                tmp.StartRevealText("If ya can find them for me, and toss in a few bucks, I could build a real nice house for ya.", zibzab);
            }
            else if (dialogueTrack == 3)
            {
                tmp.StartRevealText("Good luck, mate.", zibzab);
                startedQuest = true;
            }
           
            dialogueTrack++;
            interactScript.interacting = false;

        }
    }
}

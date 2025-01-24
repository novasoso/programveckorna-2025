using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Dog_NPCDialogueText : MonoBehaviour
{
    GameObject box;

    private checkInteraction interactScript;
    private playerDetecter detector;
    public GameObject changeIcon;
    private Image changeThis;
    private mainDialogueText tmp;
    public Sprite myDialogueIcon;
    public int dialogueTrack = 0;
    public float zibzab;
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
                tmp.StartRevealText("bark bark bark bark woof woof bark", zibzab); //calls upon method inside mainDialogueText that does stuff. reveal time accounts for time spent generating first arguement
            }
            else if (dialogueTrack == 1)
            {
                tmp.StartRevealText("blarf blarf woof woof bark bark woof", zibzab);
            }
            else if (dialogueTrack == 2)
            {
                tmp.StartRevealText("bark woof woof woof bark", zibzab);
            }
            else if (dialogueTrack == 3)
            {
                tmp.StartRevealText("aaihhh whuvv ouuh", zibzab);
            }
            else if (dialogueTrack == 4)
            {
                tmp.StartRevealText("bark woof borf barf barf wooff bark bark bark", zibzab);
            }
            else if (dialogueTrack == 5)
            {
                tmp.StartRevealText("woof waoooofff awhoooooooooooooooooooooooooooooooooooooooooo", zibzab);
            }
            else if (dialogueTrack == 6)
            {
               tmp.StartRevealText("pant pant pant woof woof bark bark", zibzab);
            }
            else if (dialogueTrack == 7)
            {
                tmp.StartRevealText("woof bark bark woof woof bark bark bark barf woof woof bark", zibzab);
            }
            dialogueTrack++;
            interactScript.interacting = false;

        }
    }
}

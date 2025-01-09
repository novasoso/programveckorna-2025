using System.Security.Cryptography;
using UnityEngine;

public class NPC1DialogueText : MonoBehaviour
{
    private checkInteraction interactScript;
    private playerDetecter detector;
    int dialogueTrack = 0;
    // Start is called before the first frame update
    void Start()
    {
        detector = GetComponent<playerDetecter>(); //assign MY playerDetecter script
        interactScript = GameObject.FindGameObjectWithTag("Player").GetComponent<checkInteraction>(); // find and assign Player's checkInteraction script
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Dialogue()
    {
        interactScript.timesInteracted++; //increase times the npc has been interacted with
        while (detector.PlayerDetected == true && interactScript.interacting == true)
        {
            if (dialogueTrack == interactScript.timesInteracted)
            {

            }
            else if (dialogueTrack == interactScript.timesInteracted)
            {

            }
            else if (dialogueTrack == interactScript.timesInteracted)
            {

            }
            else if (dialogueTrack == interactScript.timesInteracted)
            {

            }
            else if (dialogueTrack >= interactScript.timesInteracted)
            {

            }
            interactScript.interacting = false;
        }
    }
}

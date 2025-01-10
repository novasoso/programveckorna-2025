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
        while (detector.PlayerDetected == true && interactScript.interacting == true)
        {
            if (dialogueTrack == 0)
            {
                print("gcvgjcjc");
            }
            else if (dialogueTrack == 1)
            {
                print("gcvgjbubcjc");
            }
            else if (dialogueTrack == 2)
            {
                print("gcvgjcjvhkjacghkujkygtfdrhjkjc");
            }
            else if (dialogueTrack == 3)
            {
                print("gcvgjcjc");
            }
            else if (dialogueTrack >= 4)
            {

            }
            dialogueTrack++;
            interactScript.interacting = false;
        }
    }
}

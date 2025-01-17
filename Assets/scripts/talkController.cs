using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class talkController : MonoBehaviour
{
    mainDialogueText text;
    public float revealTime;
    int index;
    public AudioClip Drink;
    public AudioClip Joke;
    public AudioClip Party;
    public AudioClip Grog;
    public AudioClip Pushy;
    public AudioClip Burp;
    private AudioSource audioSource;
    GameObject father;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<mainDialogueText>();
        audioSource = gameObject.AddComponent<AudioSource>(); // Add AudioSource component
        index = Random.Range(1, 7); // Adjusted range to include index 6
        father = GameObject.Find("convoTalk");
    }

    // Update is called once per frame
    void Update()
    {
        if (father.transform.localPosition == new Vector3(-157.6f, 0, 0))
        {
            switch (index)
            {
                case 1:
                    text.StartRevealText("I'll drink you under the table, scrub!", revealTime);
                    audioSource.PlayOneShot(Drink); // Play sound for index 1
                    break;
                case 2:
                    text.StartRevealText("The only time I have a drinking problem is when I spill it!", revealTime);
                    audioSource.PlayOneShot(Joke); // Play sound for index 2
                    break;
                case 3:
                    text.StartRevealText("Let's get this party started!", revealTime);
                    audioSource.PlayOneShot(Party); // Play sound for index 3
                    break;
                case 4:
                    text.StartRevealText("Need some grog... ", revealTime);
                    audioSource.PlayOneShot(Grog); // Play sound for index 4
                    break;
                case 5:
                    text.StartRevealText("Don't get pushy!", revealTime);
                    audioSource.PlayOneShot(Pushy); // Play sound for index 5
                    break;
                case 6:
                    text.StartRevealText("*burps*", revealTime);
                    audioSource.PlayOneShot(Burp); // Play sound for index 6
                    break;
            }
            index = 0;
        }
        else if (father.transform.localPosition == new Vector3 (-157.6f, -540, 0))
        {
            index = Random.Range(1, 7);
        }
    }
}

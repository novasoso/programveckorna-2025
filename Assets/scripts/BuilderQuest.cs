using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuilderQuest : MonoBehaviour
{
    private NPC1DialogueText builderDialogue;
    public GameObject builderHammer;
    public Vector3 hammerSpawn = new(16, -6, 0);
    // Start is called before the first frame update
    bool hasHammerSpawned = false;
    void Start()
    {
        builderDialogue = GetComponent<NPC1DialogueText>();
    }

    // Update is called once per frame
    void Update()
    {
        if (builderDialogue.startedQuest == true && hasHammerSpawned == false)
        {
            Instantiate(builderHammer, hammerSpawn, Quaternion.identity);
            hasHammerSpawned = true;
            print("Hammer has spawned at " + hammerSpawn);

        }

    }
}

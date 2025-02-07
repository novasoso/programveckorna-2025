using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuilderQuest : MonoBehaviour
{

    public GameObject buildersPlanks;

    private NPC1DialogueText builderDialogue;
    
    public GameObject builderHammer;
    public Vector3 hammerSpawn = new(16, -6, 0);

    public Vector3 plankSpawn = new(20, -8, 0);

    bool hasHammerSpawned = false;
    bool hasPlanksSpawned = false;
    void Start()
    {
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        builderDialogue = GetComponent<NPC1DialogueText>();

        if (builderDialogue.startedQuest == true && hasHammerSpawned == false)
        {
            Instantiate(builderHammer, hammerSpawn, Quaternion.identity);
            hasHammerSpawned = true;
            print("Hammer has spawned at " + hammerSpawn);

        }
        if (builderDialogue.startedSecondQuest == true && hasPlanksSpawned == false)
        {
            Instantiate(buildersPlanks, plankSpawn, Quaternion.identity);
            hasPlanksSpawned = true;
            print("Plank has spawned at " + plankSpawn);
        }



    }
}

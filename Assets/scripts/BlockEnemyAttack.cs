using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockEnemyAttack : MonoBehaviour
{
    public GameObject turns;
    PlayerAndEnemyTurns accessTurns;
    public bool isBlocking = false;

    // Start is called before the first frame update
    void Start()
    {

        accessTurns = turns.GetComponent<PlayerAndEnemyTurns>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void blockEnemyAttack()
    {
        if (accessTurns.playersTurn == true)
        {
            isBlocking = true;
            accessTurns.playersTurn = false;
        }
    }
}

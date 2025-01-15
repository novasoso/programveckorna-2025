using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttacksYou : MonoBehaviour
{
    public GameObject blockingFunction;
    BlockEnemyAttack isBlocking;
    public GameObject turns;
    PlayerAndEnemyTurns accessTurns;
    PlayerStats playerHealth;
    public EnemyStats foundEnemyDamage;
    public GameObject FindPlayerHealth;

    // Start is called before the first frame update
    void Start()
    {
        accessTurns = turns.GetComponent<PlayerAndEnemyTurns>();
        playerHealth = FindAnyObjectByType<PlayerStats>();
        isBlocking = blockingFunction.GetComponent<BlockEnemyAttack>();
    }

    // Update is called once per frame
    void Update()
    {
        if (accessTurns.playersTurn == false && isBlocking.isBlocking == false)
        {
            Invoke("enemyAttack", 1f);
            accessTurns.playersTurn = true;
        }

        if (accessTurns.playersTurn == false && isBlocking.isBlocking == true)
        { 
            accessTurns.playersTurn = true;
            print("Enemy tried to attack but the player blocked");
        }
    }

    void enemyAttack()
    {
        playerHealth.playerHealth -= foundEnemyDamage.EnemyDamage;

        print("Enemy dealt " + foundEnemyDamage.EnemyDamage + " and player now has " + playerHealth.playerHealth);
    }
}

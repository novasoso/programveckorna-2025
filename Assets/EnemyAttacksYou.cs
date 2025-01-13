using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttacksYou : MonoBehaviour
{
    public GameObject turns;
    PlayerAndEnemyTurns accessTurns;
    PlayerStats playerHealth;
    public EnemyStats foundEnemyDamage;
    public GameObject FindPlayerHealth;

    // Start is called before the first frame update
    void Start()
    {
        accessTurns = turns.GetComponent<PlayerAndEnemyTurns>();
        playerHealth = FindPlayerHealth.GetComponent<PlayerStats>();
    }

    // Update is called once per frame
    void Update()
    {
        if (accessTurns.playersTurn == false)
        {
            Invoke("enemyAttack", 1f);
            accessTurns.playersTurn = true;
        }
    }

    void enemyAttack()
    {
        playerHealth.playerHealth -= foundEnemyDamage.EnemyDamage;

        print("Enemy dealt " + foundEnemyDamage.EnemyDamage + " and player now has " + playerHealth.playerHealth);
    }
}

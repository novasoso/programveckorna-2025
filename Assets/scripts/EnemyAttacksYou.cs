using System.Collections;
using System.Collections.Generic;
using TMPro;
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
    TextMeshProUGUI tmpugui;

    // Start is called before the first frame update
    void Start()
    {
        tmpugui = GameObject.FindGameObjectWithTag("combatLog").GetComponent<TextMeshProUGUI>();
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
            tmpugui.text = "Enemy tried to attack, but Traveler blocked";
        }
    }

    void enemyAttack()
    {
        playerHealth.playerHealth -= foundEnemyDamage.EnemyDamage;
        tmpugui.text = "Enemy dealt " + foundEnemyDamage.EnemyDamage;
    }
}

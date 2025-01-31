using TMPro;
using UnityEngine;

public class AttackEnemy : MonoBehaviour
{
    public GameObject turns;
    PlayerAndEnemyTurns accessTurns;
    PlayerStats playerDamage;
    public EnemyStats foundEnemyHealth;
    public GameObject FindPlayerStats;
    TextMeshProUGUI tmpugui;
    private void Start()
    {
        tmpugui = GameObject.FindGameObjectWithTag("combatLog").GetComponent<TextMeshProUGUI>();
        accessTurns = turns.GetComponent<PlayerAndEnemyTurns>();
        playerDamage = FindPlayerStats.GetComponent<PlayerStats>();
        
        //invoke("sigma", 10f)
    }
    public void attackEnemy()
    {
        if (accessTurns.playersTurn == true)
        {
            foundEnemyHealth.EnemyHealth -= playerDamage.playerDamage;
            accessTurns.playersTurn = false;
            tmpugui.text = "Player dealt " + playerDamage.playerDamage + " and the enemy now has " + foundEnemyHealth.EnemyHealth;
        }
       
    }

}


using UnityEngine;

public class AttackEnemy : MonoBehaviour
{
    PlayerStats playerDamage;
    EnemyStats foundEnemyHealth;
    public GameObject EnemyToSearch;
    public GameObject FindPlayerStats;
    private void Start()
    {
        foundEnemyHealth = EnemyToSearch.GetComponent<EnemyStats>();
        playerDamage = FindPlayerStats.GetComponent<PlayerStats>();
        
    }
    public void attackEnemy()
    {
        foundEnemyHealth.EnemyHealth -= playerDamage.playerDamage;
        print("Player dealt " + playerDamage.playerDamage + " and the enemy now has " + foundEnemyHealth.EnemyHealth);
    }

}


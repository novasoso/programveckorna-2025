using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemyInCombat : MonoBehaviour
{
    public GameObject enemy;
    Vector3 spawnLocation;
    EnemyStats stats;
    public AttackEnemy attacker;

    // Start is called before the first frame update
    void Start()
    {
        spawnLocation = new Vector3(1, 0, 0);
        GameObject clone = Instantiate(enemy, spawnLocation, Quaternion.identity);
        
        print(clone);
        stats = clone.GetComponent<EnemyStats>();
        
        print(stats.EnemyHealth);
        attacker.foundEnemyHealth = stats;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

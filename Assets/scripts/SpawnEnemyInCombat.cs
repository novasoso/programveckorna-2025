using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemyInCombat : MonoBehaviour
{
    public GameObject enemy;
    Vector3 spawnLocation;
    EnemyStats stats;

    // Start is called before the first frame update
    void Start()
    {
        spawnLocation = new Vector3(0, 0, 0);
        GameObject clone = Instantiate(enemy, spawnLocation, Quaternion.identity);
        stats = clone.GetComponent<EnemyStats>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

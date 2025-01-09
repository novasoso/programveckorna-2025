using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemyInCombat : MonoBehaviour
{
    public GameObject enemy;
    Vector3 spawnLocation;

    // Start is called before the first frame update
    void Start()
    {
        spawnLocation = new Vector3(0, 0, 0);
        Instantiate(enemy, spawnLocation, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

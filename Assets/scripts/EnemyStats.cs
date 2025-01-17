using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyStats : MonoBehaviour
{
    public int EnemyHealth;
    public int EnemyDamage;
    int originalEnemyHealth;
    // Start is called before the first frame update
   
    
    void Start()
    {
        originalEnemyHealth = EnemyHealth;

    }

    // Update is called once per frame
    void Update()
    {
        if(EnemyHealth <= 0)
        {
            EnemyHealth = originalEnemyHealth;
            SceneManager.LoadScene("ElonsRoligaScen");
            Destroy(gameObject);
        }
    }
}

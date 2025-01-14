using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    public int playerDamage;
    public int playerHealth;
    // Start is called before the first frame update
    void Start()
    {
        playerHealth = 20;
    }

    // Update is called once per frame
    void Update()
    {
        if(playerHealth <= 0)
        {
            SceneManager.LoadScene(0);
            print("you died");
        }
    }
}

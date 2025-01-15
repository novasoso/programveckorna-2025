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
        DontDestroyOnLoad(gameObject);
       
    }

    // Update is called once per frame
    void Update()
    {
        if(playerHealth <= 0)
        {
            SceneManager.LoadScene("die scene");
            print("you died");
            playerHealth = 30;
        }
    }

    private void OnLevelWasLoaded(int level)
    {
        //if (SceneManager.GetActiveScene().name == "CombatScene")

        if(level == 0)
        {
            GetComponent<SpriteRenderer>().enabled = true;
        }
        else
        {
            GetComponent<SpriteRenderer>().enabled = false;
        }
    }
}

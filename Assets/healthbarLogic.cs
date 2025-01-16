using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthbarLogic : MonoBehaviour
{
    PlayerStats health;
    PlayerAndEnemyTurns turnStuff;
    Slider slide;
    int index = 1;
    float sig;
    float playerMaxHealth;
    // Start is called before the first frame update
    void Start()
    {
        health = GameObject.FindAnyObjectByType<PlayerStats>();
        turnStuff = GameObject.FindAnyObjectByType<PlayerAndEnemyTurns>();
        slide = GetComponent<Slider>();
        sig = health.playerHealth;
        playerMaxHealth = health.playerHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (buddyTurn())
        {
            if (sig != health.playerHealth)
            {
                float smeg = sig - health.playerHealth;
                slide.value -= smeg / playerMaxHealth;
            }
            sig = health.playerHealth;
        }
    }
    bool buddyTurn()
    {
        if (turnStuff.playersTurn)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

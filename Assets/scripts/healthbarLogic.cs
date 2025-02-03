using UnityEngine;
using UnityEngine.UI;

public class healthbarLogic : MonoBehaviour
{
    PlayerStats health;
    PlayerAndEnemyTurns turnStuff;
    healthbarText text;

    Slider slide;

    float sig = 0;
    float playerMaxHealth;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponentInChildren<healthbarText>();
        health = GameObject.FindAnyObjectByType<PlayerStats>();
        turnStuff = GameObject.FindAnyObjectByType<PlayerAndEnemyTurns>();
        slide = GetComponent<Slider>();
        sig = health.playerHealth;
        playerMaxHealth = health.playerHealth;
    }

    void Update()
    {
        // Check if it's the player's turn
        if (buddyTurn())
        {
            // Check if the player's health has changed
            if (sig != health.playerHealth)
            {
                float smeg = sig - health.playerHealth;
                slide.value -= smeg / playerMaxHealth;
                string healthText = Ligma(smeg, text);
                UpdateHealthText(healthText); // Update the health text display
            }
            // Store the current health for the next update
            sig = health.playerHealth;
        }
    }

    bool buddyTurn()
    {
        // Return true if it's the player's turn
        return turnStuff.playersTurn;
    }

    string Ligma(float s, healthbarText text)
    {
        float f = slide.value * 100; // Convert to percentage
        f = Mathf.Round(f); // Round to the nearest whole number
        string bomb = f.ToString() + "%";
        return bomb;
    }

    void UpdateHealthText(string healthText)
    {
        // Assuming healthbarText has a method to update the displayed text
        text.tmpugui.text = (healthText);
    }
}

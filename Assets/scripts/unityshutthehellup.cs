using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class unityshutthehellup : MonoBehaviour
{
    TextMeshProUGUI textthing;
    playerhealth playerhp;
    // Start is called before the first frame update
    void Start()
    {
        textthing = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        playerhp = GameObject.FindGameObjectWithTag("Player").GetComponent<playerhealth>();
        textthing.text = "health:" + playerhp.health;
    }
}

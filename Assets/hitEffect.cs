using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class hitEffect : MonoBehaviour
{
    SpawnEnemyInCombat enemy;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        enemy = GameObject.FindGameObjectWithTag("Interactable").GetComponent<SpawnEnemyInCombat>();
        animator = GetComponent<Animator>();
    }
    public void playAnim()
    {
        transform.position = new(2.8f, 1.02f, 0);
        animator.Play("onhiteffect");
    }
}

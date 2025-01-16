using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyCombatStart : MonoBehaviour
{
    public GameObject enemyType;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
       
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerPrefs.SetFloat("playerX", collision.gameObject.transform.position.x);
            PlayerPrefs.SetFloat("playerY", collision.gameObject.transform.position.y);
            SceneManager.LoadScene(0);
            print("Enemy collides with player");
            Destroy(gameObject);
        }
    }
}

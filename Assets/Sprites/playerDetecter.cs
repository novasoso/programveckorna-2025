using UnityEngine;

public class playerDetecter : MonoBehaviour
{
    public bool PlayerDetected = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (CollisionIsPlayer(collision) == true)
        {
            print("player is within trigger of an npc");
            PlayerDetected = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (CollisionIsPlayer(collision) == true)
        {
            print("player is no longer within trigger on an npc");
            PlayerDetected = false;
        }  
    }

    public bool CollisionIsPlayer(Collider2D collision)
    {
        if (collision.CompareTag("Player") == true)
        {
            return true;
        }
        else 
        {
            return false;
        }
    }
}

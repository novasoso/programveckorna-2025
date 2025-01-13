using UnityEngine;
public class playerDetecter : MonoBehaviour
{
    public bool PlayerDetected = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (CollisionIsPlayer(collision))
        {
            PlayerDetected = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (CollisionIsPlayer(collision))
        {
            PlayerDetected = false;
        }  
    }

    public bool CollisionIsPlayer(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            return true;
        }
        else 
        {
            return false;
        }
    }
}

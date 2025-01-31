using UnityEngine;
public class playerDetecter : MonoBehaviour
{
    public bool PlayerDetected;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (CollisionIsPlayer(collision))
        {
            PlayerDetected = true;
        }
        else
        {

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {

        if (CollisionIsPlayer(collision))
        {
            PlayerDetected = false;
        }
        else
        {

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

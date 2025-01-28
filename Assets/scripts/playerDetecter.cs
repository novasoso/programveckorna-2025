using UnityEngine;
public class playerDetecter : MonoBehaviour
{
    public bool PlayerDetected;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (CollisionIsPlayer(collision))
        {
            print("changed playerdetected bool to " + PlayerDetected);
            PlayerDetected = true;
        }
        else
        {
            print("playerdetected bool is " + PlayerDetected);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {

        if (CollisionIsPlayer(collision))
        {
            print("changed playerdetected bool to " + PlayerDetected);
            PlayerDetected = false;
        }
        else
        {
            print("playerdetected bool is " + PlayerDetected);
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

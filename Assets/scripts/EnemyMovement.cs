using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform player;
    public float speed = 2.0f;
    public bool inChase = false;
    public void imChasinYouGraaahhhhhh()
    {
        if (player != null && inChase == true)
        {
            Vector3 direction = (player.position - transform.position).normalized;
            transform.position += direction * speed * Time.deltaTime;
        }
    }
}

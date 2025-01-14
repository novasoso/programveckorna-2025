using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    Transform player;
    public float speed = 2.0f;
    public bool inChase = false;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }
    public void imChasinYouGraaahhhhhh()
    {
        if (player != null && inChase == true)
        {
            Vector3 direction = (player.position - transform.position).normalized;
            transform.position += direction * speed * Time.deltaTime;
        }
    }
}

using UnityEngine;

public class cameraCentertoPlayer : MonoBehaviour
{
    GameObject player;
    Vector3 playerPosition;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player"); //find player
    }

    // Update is called once per frame
    void Update()
    {
        playerPosition = player.transform.position; // update player position;
        transform.position = new Vector3 (playerPosition.x, playerPosition.y, -10); //center camera to preferred position
    }
}

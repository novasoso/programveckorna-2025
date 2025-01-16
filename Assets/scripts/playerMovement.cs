using System.Net.Sockets;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public SpriteRenderer currentSprite;
    public Sprite facingSouth;
    public Sprite facingWest;
    public Sprite facingEast;
    public Sprite facingNorth;
    public float moveSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        currentSprite = GetComponent<SpriteRenderer>();
        transform.position = new Vector2(PlayerPrefs.GetFloat("playerX"), PlayerPrefs.GetFloat("playerY"));

    }

    // Update is called once per frame

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveX, moveY);
        transform.Translate(movement * moveSpeed * Time.deltaTime);

        if(moveX < 0)
        {
            currentSprite.sprite = facingWest;
        }
        if (moveX > 0)
        {
            currentSprite.sprite = facingEast;
        }
        if (moveY < 0)
        {
            currentSprite.sprite = facingSouth;
        }
        if (moveY > 0)
        {
            currentSprite.sprite = facingNorth;
        }
    }
}

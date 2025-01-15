using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Sprite facingSouth;
    public Sprite facingWest;
    public Sprite facingEast;
    public Sprite facingNorth;
    public float moveSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        checkvelocity(moveY, moveX);
        Vector2 movement = new Vector2(moveX, moveY);
        transform.Translate(movement * moveSpeed * Time.deltaTime);
    }
    void checkvelocity(float blumpkin, float piggy)
    {
        print(blumpkin + " "+ piggy);
    }
}

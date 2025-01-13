using UnityEngine;
public class cameraCentertoPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject player;
    private Vector3 offset = new Vector3(0, 0, -10);
    public float smoothSpeed = 0.125f; // Smoothing factor

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player"); // Find player
    }

    // Update is called once per frame
    void LateUpdate() // Use LateUpdate for smoother camera movement
    {
        Vector3 desiredPosition = player.transform.position + offset; // Calculate desired position
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed); // Smoothly interpolate to the desired position
        transform.position = smoothedPosition; // Update camera position
    }
}

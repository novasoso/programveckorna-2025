using UnityEngine;
using UnityEngine.SceneManagement;

public class TemporaryGuy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "door")
        {
            SceneManager.LoadScene(0);
        }
    }
}

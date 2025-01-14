using UnityEngine;
using UnityEngine.SceneManagement;

public class playerhealth : MonoBehaviour
{
    public int health = 10;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            SceneManager.LoadScene("ElonsRoligaScen");
        }
    }
}

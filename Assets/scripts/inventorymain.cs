using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventorymain : MonoBehaviour
{
    public int berry = 0;
    public int skibiditoilet = 0;
    public int premierballs = 0;
    public int sigmaboy = 0;
    public float invy;
    public float invx;
    public int slots;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        invy = transform.localPosition.y;
        invx = transform.localPosition.x;
        if (Input.GetKeyDown(KeyCode.R) && slots != 3)
        {
            skibiditoilet = 1;
            slots += 1;
        }
        if (Input.GetKeyDown(KeyCode.T) && slots != 3)
        {
            premierballs = 1;
            slots += 1;
        }
        if (Input.GetKeyDown(KeyCode.Y) && slots != 3)
        {
            sigmaboy = 1;
            slots += 1;
        }
        if (Input.GetKeyDown(KeyCode.X) && slots != 3)
        {
            berry = 1;
            slots += 1;
        }
    }
}

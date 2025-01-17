using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class berryempty : MonoBehaviour
{
    berry sigma;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sigma = GameObject.Find("Berry").GetComponent<berry>();
        if (sigma.emptyberry == 1)
        {
            transform.localScale = new Vector3(1, 0.5f, 1);
        }else if (sigma.emptyberry == 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
    }
}

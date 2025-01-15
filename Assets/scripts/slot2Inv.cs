using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slot2Inv : MonoBehaviour
{
    InventoryCenter inv;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        inv = GameObject.FindGameObjectWithTag("inventorymain").GetComponent<InventoryCenter>();
        transform.localPosition = new Vector3(inv.sigma, inv.boy - 39.485f);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slot1Inv : MonoBehaviour
{
    InventoryCenter inv;
    public float wha;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        inv = GameObject.FindGameObjectWithTag("inventorymain").GetComponent<InventoryCenter>();
        transform.localPosition = new Vector3(inv.sigma -309, inv.boy - 39.485f);
    }
}

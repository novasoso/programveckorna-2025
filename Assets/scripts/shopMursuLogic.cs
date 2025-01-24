using UnityEngine;

public class shopMursuLogic : MonoBehaviour
{
    shopArrowSelector otherMursu;
    // Start is called before the first frame update
    void Start()
    {
        otherMursu = FindObjectOfType<shopArrowSelector>().GetComponent<shopArrowSelector>();
    }

    // Update is called once per frame
    void Update()
    {
        if (otherMursu.inSubMenu ==true && otherMursu.inShop == true)
        {
            
        }
    }
}

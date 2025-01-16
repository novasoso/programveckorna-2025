using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shopArrowSelector : MonoBehaviour
{
    bool atShopSelect = false;
    public GameObject shopSelect;
    bool atSellSelect = false;
    public GameObject sellselect;
    bool atTalkSelect = false;
    public GameObject talkSelect;
    bool atMursuSelect = false;
    public GameObject mursuSelect;
    bool atLeaveSelect = false;
    public GameObject leaveSelect;
    // Start is called before the first frame update
    void Start()
    {
        atShopSelect = true;
        goToShop();
    }

    // Update is called once per frame
    void Update()
    {
        redoSelect();
        checkSelect();
    }
    void redoSelect()
    {
        if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (atShopSelect == true)
            {
                goToLeave();
                atShopSelect = false;
            }
            else if (atSellSelect == true)
            {
                goToShop();
                atSellSelect = false;
            }
            else if (atTalkSelect == true)
            {
                goToSell();
                atTalkSelect = false;
            }
            else if (atMursuSelect == true)
            {
                goToTalk();
                atMursuSelect = false;
            }
            else if (atLeaveSelect == true)
            {
                goToMursu();
                atLeaveSelect = false;
            }
        }
        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (atShopSelect == true)
            {
                goToSell();
                atShopSelect = false;
            }
            else if (atSellSelect == true)
            {
                goToTalk();
                atSellSelect = false;
            }
            else if (atTalkSelect == true)
            {
                goToMursu();
                atTalkSelect = false;
            }
            else if (atMursuSelect == true)
            {
                goToLeave();
                atMursuSelect = false;
            }
            else if (atLeaveSelect == true)
            {
                goToShop();
                atLeaveSelect = false;
            }
        }
    }
    void goToShop()
    {
        transform.localPosition = new(-75, shopSelect.transform.localPosition.y);
        atShopSelect = true;
    }
    void goToSell()
    {
        transform.localPosition = new(-60, sellselect.transform.localPosition.y);
        atSellSelect = true;
    }
    void goToTalk()
    {
        transform.localPosition = new(-70f, talkSelect.transform.localPosition.y);
        atTalkSelect = true;
    }
    void goToMursu()
    {
        transform.localPosition = new(-108f, mursuSelect.transform.localPosition.y);
        atMursuSelect = true;
    }
    void goToLeave()
    {
        transform.localPosition = new(-96f, leaveSelect.transform.localPosition.y);
        atLeaveSelect = true;
    }
    void checkSelect()
    {
    
    }
}

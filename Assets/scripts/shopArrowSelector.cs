using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shopArrowSelector : MonoBehaviour
{
    bool atShopHover = false;
    public GameObject shopSelect;
    GameObject shopBox;

    bool atSellHover = false;
    public GameObject sellselect;
    GameObject sellBox;

    bool atTalkHover = false;
    public GameObject talkSelect;
    GameObject talkBox;

    bool atMursuHover = false;
    public GameObject mursuSelect;
    GameObject mursuBox;

    bool atLeaveHover = false;
    public GameObject leaveSelect;
    GameObject emptyBox;

    bool inSubMenu = false;
    bool inShop = false;

    bool berryHover = false;
    bool candyHover = false;
    bool crossantHover = false;
    bool bloomHover = false;
    bool tieHover = false;

    public float boxMoveSpeed;
    float greaterYOffset = 4;

    GameObject berrySelect;
    GameObject candySelect;
    GameObject crossantSelect;
    GameObject bloomSelect;
    GameObject tieSelect;
    GameObject shopMursu;

    // Start is called before the first frame update
    void Start()
    {
        atShopHover = true;
        goToShop();
        shopBox = GameObject.Find("shopTab");
        sellBox = GameObject.Find("inventorySell");
        talkBox = GameObject.Find("convoTalk");
        mursuBox = GameObject.Find("mursuTab");
        emptyBox = GameObject.Find("unselectedBlank");

        berrySelect = GameObject.Find("berrySelect");
        candySelect = GameObject.Find("candySelect");
        crossantSelect = GameObject.Find("crossantSelect");
        bloomSelect = GameObject.Find("bloomSelect");
        tieSelect = GameObject.Find("tieSelect");
        shopMursu = GameObject.Find("shopMursu");
    }

    // Update is called once per frame
    void Update()
    {
        redoSelect();
        checkSelect();
    }
    void redoSelect()
    {
        if(checkUpInput() && inSubMenu != true)
        {
            if (inSubMenu)
            {
                if (inShop)
                {
                    berryHover = true;
                    if (checkUpInput())
                    {
                        if (berryHover)
                        {
                            goToTie(ref berryHover, ref tieHover);
                        }
                        else if (candyHover)
                        {
                            goToBerry(ref candyHover, ref berryHover);
                        }
                        else if (crossantHover)
                        {
                            goToCandy(ref crossantHover, ref candyHover);
                        }
                        else if (bloomHover)
                        {
                            goToCrossant(ref bloomHover, ref crossantHover);
                        }
                        else if (tieHover)
                        {
                            goToBloom(ref tieHover, ref bloomHover);
                        }
                    }
                    else if (checkDownInput())
                    {
                        if (berryHover)
                        {
                            goToCandy(ref berryHover, ref candyHover);
                        }
                        else if (candyHover)
                        {
                            goToCrossant(ref candyHover, ref crossantHover);
                        }
                        else if (crossantHover)
                        {
                            goToBloom(ref crossantHover, ref bloomHover);
                        }
                        else if (bloomHover)
                        {
                            goToTie(ref bloomHover, ref tieHover);
                        }
                        else if (tieHover)
                        {
                            goToBerry(ref tieHover, ref berryHover);
                        }
                    }
                }
            }
            else if (atShopHover)
            {
                goToLeave();
                atShopHover = false;
            }
            else if (atSellHover)
            {
                goToShop();
                atSellHover = false;
            }
            else if (atTalkHover)
            {
                goToSell();
                atTalkHover = false;
            }
            else if (atMursuHover)
            {
                goToTalk();
                atMursuHover = false;
            }
            else if (atLeaveHover)
            {
                goToMursu();
                atLeaveHover = false;
            }
        }
        if (checkDownInput() && inSubMenu!=true)
        {
            if (atShopHover == true)
            {
                goToSell();
                atShopHover = false;
            }
            else if (atSellHover == true)
            {
                goToTalk();
                atSellHover = false;
            }
            else if (atTalkHover == true)
            {
                goToMursu();
                atTalkHover = false;
            }
            else if (atMursuHover == true)
            {
                goToLeave();
                atMursuHover = false;
            }
            else if (atLeaveHover == true)
            {
                goToShop();
                atLeaveHover = false;
            }
        }
    }
    void goToShop()
    {
        transform.localPosition = new(-75, shopSelect.transform.localPosition.y);
        atShopHover = true;
    }
    void goToSell()
    {
        transform.localPosition = new(-60, sellselect.transform.localPosition.y);
        atSellHover = true;
    }
    void goToTalk()
    {
        transform.localPosition = new(-70f, talkSelect.transform.localPosition.y);
        atTalkHover = true;
    }
    void goToMursu()
    {
        transform.localPosition = new(-108f, mursuSelect.transform.localPosition.y);
        atMursuHover = true;
    }
    void goToLeave()
    {
        transform.localPosition = new(-96f, leaveSelect.transform.localPosition.y);
        atLeaveHover = true;
    }
    void checkSelect()
    {
        Vector3 activeBox = new Vector3(-157.6f, 0, 0);
        if (checkConfirmInput())
        {
            resetActiveBox(activeBox);
            if (atShopHover)
            {
                makeBoxActive(shopBox, activeBox);
            }
            else if (atSellHover)
            {
                makeBoxActive(sellBox, activeBox);
            }
            else if (atTalkHover)
            {
                makeBoxActive(talkBox, activeBox);
            }
            else if (atMursuHover)
            {
                makeBoxActive(mursuBox, activeBox);
            }
            else if (atLeaveHover)
            {

            }
        }
        else if (Input.GetKeyDown(KeyCode.Escape))
        {
            resetActiveBox(activeBox);
            if (emptyBox.transform.localPosition != activeBox)
            {
                makeBoxActive(emptyBox, activeBox);
            }
        }
    }
    void resetActiveBox(Vector3 activeBox)
    {
        Vector3 R = new Vector3(-157.6f, -540, 0);
        if (shopBox.transform.localPosition == activeBox)
        {
            resetGivenBox(shopBox, R);
        }
        if (sellBox.transform.localPosition == activeBox)
        {
            resetGivenBox(sellBox, R);
        }
        if (talkBox.transform.localPosition == activeBox)
        {
            resetGivenBox(talkBox, R);
        }
        if (mursuBox.transform.localPosition == activeBox)
        {
            resetGivenBox(mursuBox, R);
        }
        if (emptyBox.transform.localPosition == activeBox)
        {
            resetGivenBox(emptyBox, R);
        }
    }
    void resetGivenBox(GameObject box, Vector3 returnTo)
    {
        box.transform.localPosition = returnTo;
        if (box.name == "shopTab")
        {
            inSubMenu = false;
            inShop = false;
        }
        /*Rigidbody2D rb = box.GetComponent<Rigidbody2D>();
        if (box.transform.localPosition != returnTo)
        {
            rb.velocity = new Vector2(0, -boxMoveSpeed);
        }
        else
        {
            box.transform.localPosition = returnTo;
            rb.velocity = Vector2.zero; // Stop the box when it reaches the return position
        }*/
    }

    void makeBoxActive(GameObject box, Vector3 activePos)
    {
        box.transform.localPosition = activePos;
        if (box.name == "shopTab")
        {
            inSubMenu = true;
            inShop = true;
        }
        /*Rigidbody2D rb = box.GetComponent<Rigidbody2D>();
        if (box.transform.position != activePos)
        {
            box.transform.position = Vector3.SmoothDamp(box.transform.position, activePos, ref new Vector3.z,  boxMoveSpeed, 0.3f);
        }
        else
        {
            box.transform.position = activePos;
            rb.velocity = Vector2.zero; // Stop the box when it reaches the active position
        }*/
    }

    GameObject assignSelection(string objectToAssign)
    {
        GameObject objectInFocus = GameObject.Find(objectToAssign);
        return objectInFocus;
    }
    void hoverShopSelection(GameObject objectToSelect, float xOffset, float yOffset, ref bool turnThisTrue, ref bool turnThisFalse)
    {
        shopMursu.transform.localPosition =
            new Vector3(objectToSelect.transform.localPosition.x + xOffset,
                        objectToSelect.transform.localPosition.y + yOffset,
                        objectToSelect.transform.localPosition.z);
        turnThisTrue = true;
        turnThisFalse = false;
    }

    bool checkDownInput()
    {
        if(Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    bool checkUpInput()
    {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    bool checkConfirmInput()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    void goToBerry(ref bool comingFrom, ref bool goingTo)
    {
        hoverShopSelection(berrySelect, 229f, greaterYOffset, ref comingFrom, ref goingTo);
    }

    void goToCandy(ref bool comingFrom, ref bool goingTo)
    {
        hoverShopSelection(candySelect, 215.3f, greaterYOffset, ref comingFrom, ref goingTo);
    }

    void goToCrossant(ref bool comingFrom, ref bool goingTo)
    {
        hoverShopSelection(crossantSelect, 92.4f, greaterYOffset, ref comingFrom, ref goingTo);
    }

    void goToBloom(ref bool comingFrom, ref bool goingTo)
    {
        hoverShopSelection(bloomSelect, 147.6f, greaterYOffset, ref comingFrom, ref goingTo);
    }

    void goToTie(ref bool comingFrom, ref bool goingTo)
    {
        hoverShopSelection(tieSelect, 150f, greaterYOffset, ref comingFrom, ref goingTo);
    }
}
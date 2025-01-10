using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class NightMode : MonoBehaviour
{
    public Color changeEnvironmentHue;
    public Color changeInteractableHue;
    public Color dayHue;
    public bool isNight = false;

    public List<GameObject> gameObjects;
    // Start is called before the first frame update
    void Start()
    {
        nightmode();
        Invoke("dayMode", 5f);
    }

    private void nightmode()
    {
        gameObjects = new List<GameObject>(GameObject.FindObjectsOfType<GameObject>());
        isNight = true;
        foreach (GameObject obj in gameObjects)
        {
            if (obj.CompareTag("Environment"))
            {
                SpriteRenderer spriteRenderer = obj.GetComponent<SpriteRenderer>();
                if (spriteRenderer == null)
                {
                    Image image = obj.GetComponent<Image>();
                    image.color = changeEnvironmentHue;
                }
                else
                {
                    spriteRenderer.color = changeEnvironmentHue;
                }
            }
            else if (obj.CompareTag("Enemy") || obj.CompareTag("Interactable") || obj.CompareTag("NPC") || obj.CompareTag("Player"))
            {
                SpriteRenderer spriteRenderer = obj.GetComponent<SpriteRenderer>();
                if (spriteRenderer == null)
                {
                    Image image = obj.GetComponent<Image>();
                    image.color = changeInteractableHue;
                }
                else
                {
                    spriteRenderer.color = changeInteractableHue;
                }
            }
        }
    }

    private void dayMode()
    {
        gameObjects = new List<GameObject>(GameObject.FindObjectsOfType<GameObject>());
        isNight = false;
        foreach (GameObject obj in gameObjects)
        {
            print(obj);
            Image image = obj.GetComponent<Image>();
            SpriteRenderer spriteRenderer = obj.GetComponent<SpriteRenderer>();
            if (spriteRenderer == null && image != null && obj.name != "darkness")
            {
                print(image.color);
                image.color = dayHue;
            }
            else if (obj.name == "darkness" && image != null)
            {
                print ("found darkness, its color right now is = "+image.color);
                image.color = new(image.color.r, image.color.b, image.color.g, 0f);
            }
            else if (spriteRenderer == null && image == null)
            {
                continue;
            }
            else
            {
                spriteRenderer.color = dayHue;
                print(spriteRenderer.color);
            }
        }
    }
}

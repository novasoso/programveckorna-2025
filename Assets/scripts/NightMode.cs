using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NightMode : MonoBehaviour
{
    public Color changeEnvironmentHue;
    public Color changeInteractableHue;
    public Color dayHue;
    public bool isNight = true;
    public List<GameObject> gameObjects;
    public float cycle = 0f;
    public GameObject enemyToSummon1;
    public int noOfEnemies;
    public float areaOfPotentialSpawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Update()
    {
        cycle += Time.deltaTime;
        if (cycle >= 360)
        {
            cycle = 0;
            if (isNight == false)
            {
                nightMode();
                for (int i = 0; i < noOfEnemies; i++)
                {
                    summon();
                }
                isNight = true;
            }
            else if (isNight)
            {
                dayMode();
                isNight = false;
            }
        }
    }

    private void nightMode()
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
    private void summon()
    {
        GameObject ligma = GameObject.FindGameObjectWithTag("Player");
        Vector4 playersNoNoSquare = areaOfNuhUh(ligma.transform.position);

        if (enemyToSummon1 != null && isNight)
        {
            Vector2 spawnHere = new Vector2(
                Random.Range(ligma.transform.position.x - areaOfPotentialSpawn, ligma.transform.position.x + areaOfPotentialSpawn),
                Random.Range(ligma.transform.position.y - areaOfPotentialSpawn, ligma.transform.position.y + areaOfPotentialSpawn)
            );

            if (spawnHere.x < playersNoNoSquare.x && spawnHere.x > playersNoNoSquare.y &&
                spawnHere.y < playersNoNoSquare.z && spawnHere.y > playersNoNoSquare.w)
            {
                print("ligma");
                GameObject clone = Instantiate(enemyToSummon1, new Vector3(spawnHere.x, spawnHere.y, 0), Quaternion.identity);
            }
            else
            {
                spawnHere = new Vector2(
                    Random.Range(ligma.transform.position.x - areaOfPotentialSpawn, ligma.transform.position.x + areaOfPotentialSpawn),
                    Random.Range(ligma.transform.position.y - areaOfPotentialSpawn, ligma.transform.position.y + areaOfPotentialSpawn)
                );
                return;
            }
        }
    }

    private Vector4 areaOfNuhUh(Vector2 playerPosiition)
    {
        Vector4 boxOfLimit;
        boxOfLimit.x = playerPosiition.x + 7;
        boxOfLimit.y = playerPosiition.x - 7;
        boxOfLimit.z = playerPosiition.y + 7;
        boxOfLimit.w = playerPosiition.y - 7;
        return boxOfLimit;
    }

}

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NightMode : MonoBehaviour
{
    public Color changeEnvironmentHue;
    public Color changeInteractableHue;
    public Color dayHue;
    public bool isNight = false;
    public List<GameObject> gameObjects;
    public float cycle = 0f;
    public GameObject enemyToSummon1;
    public int noOfEnemies;
    public float areaOfPotentialSpawn;
    public int areaOfNoNoSquare;
    public int otherIndex;
    // Start is called before the first frame update
    void Start()
    {
        dayMode();
    }
    void Update()
    {
        cycle += Time.deltaTime; //Vide used MY code and ruined it with these TRASH names!!
        if (cycle >= 360)
        {
            cycle = 0;
            if (isNight == false) //IsNiGhT, don't make me mad >:[
            {
                isNight = true;
                summon();
                nightMode();
            }
            else if (isNight)
            {
                dayMode();
                isNight = false; //listen here BUD you do NOT wanna mess with me I'm the alpha budy
            }
        }
    }

    private void nightMode() //since we changing eachothers code now, why dont i mess with YOUR code for a change. Check NPC1DialogueText. You're done heh
    {
        gameObjects = new List<GameObject>(GameObject.FindObjectsOfType<GameObject>());
        isNight = true;
        foreach (GameObject obj in gameObjects)
        {
            Image image = obj.GetComponent<Image>();
            if (obj.name == "darkness" && image != null)
            {
                print("i found darkness buddy im making him kinda opaque");
                image.color = new Color (0.068f, 0.081f, 0.137f, 0.98f);
            }
            else if (obj.CompareTag("Environment"))
            {
                SpriteRenderer spriteRenderer = obj.GetComponent<SpriteRenderer>();
                if (spriteRenderer == null)
                {
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
        print("summon");
        print(isNight);
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        Vector4 playersNoNoSquare = areaOfNuhUh(player.transform.position);
        int index = 0;

        if (enemyToSummon1 != null && isNight)
        {
            while (index < noOfEnemies)
            {
                Vector2 spawnHere = new Vector2(
                    Random.Range(player.transform.position.x - areaOfPotentialSpawn, player.transform.position.x + areaOfPotentialSpawn),
                    Random.Range(player.transform.position.y - areaOfPotentialSpawn, player.transform.position.y + areaOfPotentialSpawn)
                );

                if (spawnHere.x > playersNoNoSquare.x && spawnHere.y > playersNoNoSquare.z ||
                    spawnHere.x < playersNoNoSquare.y && spawnHere.y > playersNoNoSquare.z ||
                    spawnHere.x > playersNoNoSquare.x && spawnHere.y < playersNoNoSquare.w ||
                    spawnHere.x < playersNoNoSquare.y && spawnHere.y < playersNoNoSquare.w)
                {
                    print("yep i can spawn there at "+spawnHere);
                    GameObject clone = Instantiate(enemyToSummon1, new Vector3(spawnHere.x, spawnHere.y, 0), Quaternion.identity);
                    index++;
                }
                else
                {
                    print(" i cant spawn at " + spawnHere);
                }
            }
        }
    }

    private Vector4 areaOfNuhUh(Vector2 playerPosiition)
    {
        Vector4 boxOfLimit;
        boxOfLimit.x = playerPosiition.x + areaOfNoNoSquare;
        boxOfLimit.y = playerPosiition.x - areaOfNoNoSquare;
        boxOfLimit.z = playerPosiition.y + areaOfNoNoSquare;
        boxOfLimit.w = playerPosiition.y - areaOfNoNoSquare;
        return boxOfLimit;
    }

}

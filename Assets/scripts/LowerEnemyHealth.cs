using UnityEngine;

public class LowerEnemyHealth : MonoBehaviour
{
    public int value;

    public void LowerInt()
    {
        value--;
        Debug.Log("Value lowered to: " + value);
    }
}

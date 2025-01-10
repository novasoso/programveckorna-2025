using System.Collections;
using TMPro;
using UnityEngine;

public class mainDialogueText : MonoBehaviour
{
    public TextMeshProUGUI tmpugui;
    // Start is called before the first frame update
    void Start()
    {
        tmpugui = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator RevealText(string fullText, float revealTime)
    {
        tmpugui.text = string.Empty;
        for (int i = 0; i < fullText.Length; i++)
        {
            tmpugui.text += fullText[i];
            yield return new WaitForSeconds(revealTime / fullText.Length);
        }
    }
}

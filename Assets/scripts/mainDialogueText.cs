using System.Collections;
using TMPro;
using UnityEngine;

public class mainDialogueText : MonoBehaviour
{
    private Coroutine revealCoroutine;
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

    public void StartRevealText(string fullText, float revealTime)
    {
        if (revealCoroutine != null)
        {
            // Wait for the current text to finish revealing before stopping the coroutine
            StopCoroutine(revealCoroutine);
            // Ensure the current text is fully revealed
            tmpugui.text = fullText;
        }
        revealCoroutine = StartCoroutine(RevealText(fullText, revealTime));
    }

    private IEnumerator RevealText(string fullText, float revealTime)
    {
        tmpugui.text = string.Empty;
        for (int i = 0; i < fullText.Length; i++)
        {
            tmpugui.text += fullText[i];
            yield return new WaitForSeconds(revealTime / fullText.Length);
        }
    }
}

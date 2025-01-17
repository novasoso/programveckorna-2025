using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class healthbarText : MonoBehaviour
{
    TextMeshProUGUI tmpugui;
    // Start is called before the first frame update
    void Start()
    {
        tmpugui = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void smeg(float text)
    {
        tmpugui.text = text.ToString();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class JFade : MonoBehaviour
{
    public TextMeshProUGUI tmpText;
    public float fadeSpeed = 0.0f;

    private float alpha = 1.0f;
    private bool fadingIn = true;
    // Start is called before the first frame update
    void Start()
    {
        fadeSpeed = 0.01f;
    }

    // Update is called once per frame
    void Update()
    {
        Fade();
    }
     public void Fade()
    {
        if (fadingIn)
        {
            alpha += fadeSpeed * Time.deltaTime;
            if (alpha >= 1.0f) 
            {
                alpha = 1.0f;
                fadingIn = false;
            }
        }

        else
        {
            alpha -= fadeSpeed * Time.deltaTime;
            if (alpha <= 0.0f)
            {
                alpha = 0.0f;
                fadingIn = true;
            }
        }

        Color c = tmpText.color;
        c.a = alpha;
        tmpText.color = c;

    }
    
}
